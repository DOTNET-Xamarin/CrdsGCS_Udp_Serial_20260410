using CrdsModel.CommunicationPort;
using CrdsModel.Mavlink;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// dns, ip address
// tcplistner

namespace Crds.CommunicationPort
{
    public class UdpSerial : CommsBase, ICommsSerial, IDisposable
    {
        #region Subscribe

        public Subscribe Subscribe { get; set; }

        /// <summary>
        /// Run Subscribe.
        /// </summary>
        /// <returns></returns>
        public bool RunSubscribe()
        {
            try
            {
                //BOB - 20260403 - debug
                Console.WriteLine("RunSubscribe called");
                Console.WriteLine("Subscribe is null = " + (this.Subscribe == null));
                Console.WriteLine("Subscribe thread alive = " + (this.Subscribe != null && this.Subscribe.IsThreadAlive));
                //EOB - 20260403 - debug

                if (this.Subscribe != null)
                {
                    if (!this.Subscribe.IsThreadAlive)
                    {
                        // re-run.
                        this.Subscribe.StartReader();
                    }

                    // already running.
                    return true;
                }

                this.Subscribe = new Subscribe(this);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                return false;
            }
        }

        #endregion

        public readonly List<IPEndPoint> EndPointList = new List<IPEndPoint>();

        private bool _isopen;

        public bool CancelConnect = false;
        /// <summary>
        /// add to EndPointList if need when injecting
        /// </summary>
        public UdpClient client = new UdpClient();

        private MemoryStream rbuffer = new MemoryStream();

        /// <summary>
        ///     this is the remote endpoint we send messages too. this class does not support multiple remote endpoints.
        /// </summary>
        public IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

        public string ConfigRef { get; set; } = "";

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        /// <summary>
        /// Read Mavlink packet
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> ReadMavlink()
        {
            await _semaphore.WaitAsync();
            try
            {
                if (this.ReadTimeout != 3000)
                {
                    this.ReadTimeout = 3000;
                }

                DateTime timeout = DateTime.Now.AddMilliseconds(this.ReadTimeout);

                while (true)
                {
                    if (DateTime.Now > timeout)
                    {
                        throw new TimeoutException(
                            $"No received packet from {timeout.AddMilliseconds(-ReadTimeout)} to {timeout}");
                    }

                    byte[] datagram = null;

                    // 먼저 기존 rbuffer에 남은 데이터를 우선 사용
                    lock (rbuffer)
                    {
                        long available = rbuffer.Length - rbuffer.Position;
                        if (available > 0)
                        {
                            datagram = new byte[available];
                            rbuffer.Read(datagram, 0, (int)available);

                            rbuffer.SetLength(0);
                            rbuffer.Position = 0;
                        }
                    }

                    // rbuffer에 없으면 새 UDP datagram 수신
                    if (datagram == null || datagram.Length == 0)
                    {
                        if (client.Available == 0)
                        {
                            Thread.Sleep(10);
                            continue;
                        }

                        IPEndPoint currentRemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                        datagram = client.Receive(ref currentRemoteIpEndPoint);

                        if (!EndPointList.Contains(currentRemoteIpEndPoint))
                        {
                            EndPointList.Add(currentRemoteIpEndPoint);
                        }

                        if (RemoteIpEndPoint == null ||
                            RemoteIpEndPoint.Address.Equals(IPAddress.Any) ||
                            RemoteIpEndPoint.Port == 0)
                        {
                            RemoteIpEndPoint = currentRemoteIpEndPoint;
                        }
                    }

                    if (datagram == null || datagram.Length == 0)
                    {
                        continue;
                    }

                    // datagram 안에서 첫 유효 MAVLink packet 찾기
                    for (int start = 0; start < datagram.Length; start++)
                    {
                        byte stx = datagram[start];

                        if (stx != 0xFE && stx != 0xFD)
                        {
                            continue;
                        }

                        int packetLen = 0;

                        if (stx == 0xFE)
                        {
                            // MAVLink1
                            if (start + 8 > datagram.Length)
                            {
                                continue;
                            }

                            int len = datagram[start + 1];
                            packetLen = 8 + len;
                        }
                        else
                        {
                            // MAVLink2
                            if (start + 12 > datagram.Length)
                            {
                                continue;
                            }

                            int len = datagram[start + 1];
                            byte incompatFlags = datagram[start + 2];

                            packetLen = 12 + len;
                            if ((incompatFlags & 0x01) == 0x01)
                            {
                                packetLen += 13;
                            }
                        }

                        if (start + packetLen > datagram.Length)
                        {
                            continue;
                        }

                        byte[] packet = new byte[packetLen];
                        Buffer.BlockCopy(datagram, start, packet, 0, packetLen);

                        Packet parsed = new Packet(packet);
                        if (parsed != null && parsed.IsValid)
                        {
                            // packet 뒤에 남은 바이트가 있으면 다시 rbuffer에 저장
                            int remaining = datagram.Length - (start + packetLen);
                            if (remaining > 0)
                            {
                                lock (rbuffer)
                                {
                                    rbuffer.SetLength(0);
                                    rbuffer.Position = 0;
                                    rbuffer.Write(datagram, start + packetLen, remaining);
                                    rbuffer.Position = 0;
                                }
                            }

                            return packet;
                        }
                    }

                    // 현재 datagram 안에서 유효 packet을 못 찾았으면 다음 datagram 시도
                }
            }
            catch (TimeoutException e_timeout)
            {
                Debug.WriteLine(e_timeout.Message);
                return null;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
            finally
            {
                _semaphore.Release();
            }
        }
        public UdpSerial()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Port = "14550";
            ReadTimeout = 3000;
        }

        public UdpSerial(UdpClient client)
        {
            this.client = client;
            _isopen = true;
            ReadTimeout = 3000;
        }

        public string Port { get; set; }

        public int WriteBufferSize { get; set; }
        public int WriteTimeout { get; set; }
        public bool RtsEnable { get; set; }
        public Stream BaseStream => new UDPStream(this);

        public void toggleDTR()
        {
        }

        public int ReadTimeout
        {
            get; // { return client.ReceiveTimeout; }
            set; // { client.ReceiveTimeout = value; }
        }

        public int ReadBufferSize { get; set; }

        public int BaudRate { get; set; }

        public int DataBits { get; set; }

        public string PortName
        {
            get => "UDP" + Port;
            set { }
        }

        public int BytesToRead => (int)(client.Available + rbuffer.Length - rbuffer.Position);

        public int BytesToWrite => 0;

        public bool IsOpen
        {
            get
            {
                if (client?.Client == null) return false;
                return _isopen;
            }
            set => _isopen = value;
        }

        public bool DtrEnable { get; set; }

        public void Open()
        {
            if (client.Client.Connected || IsOpen)
            {
                return;
            }

            try
            {
                client.Close();
            }
            catch
            {
            }

            var dest = Port;
            dest = OnSettings("UDP_port" + ConfigRef, dest);

            if (inputboxreturn.Cancel == OnInputBoxShow(
                    "Listern Port",
                    "Enter Local port (ensure remote end is already sending)",
                    ref dest))
            {
                return;
            }

            Port = dest;
            OnSettings("UDP_port" + ConfigRef, Port, true);
            Console.WriteLine("UDP_port " + ConfigRef + Port.ToString());

            try
            {
                if (client != null)
                    client.Close();
            }
            catch
            {
            }

            Console.WriteLine("### UdpSerial START ###");

            client = new UdpClient(int.Parse(Port));
            _isopen = true;

            Console.WriteLine("### UdpSerial Started. ###");
            Console.WriteLine("### UdpSerial.Subscribe null = " + (this.Subscribe == null) + " ###");

            while (true)
            {
                Thread.Sleep(300);

                if (CancelConnect)
                {
                    try
                    {
                        client.Close();
                    }
                    catch
                    {
                    }

                    _isopen = false;
                    return;
                }

                if (client.Available > 0)
                    break;
            }

            try
            {
                RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                // 첫 UDP datagram을 먼저 받아서 endpoint를 확정
                byte[] receivedData = client.Receive(ref RemoteIpEndPoint);

                lock (rbuffer)
                {
                    rbuffer.SetLength(0);
                    rbuffer.Position = 0;
                    rbuffer.Write(receivedData, 0, receivedData.Length);
                    rbuffer.Position = 0;
                }

                Console.WriteLine("UDPSerial connecting to {0} : {1}", RemoteIpEndPoint.Address, RemoteIpEndPoint.Port);

                if (!EndPointList.Contains(RemoteIpEndPoint))
                {
                    EndPointList.Add(RemoteIpEndPoint);
                }

                _isopen = true;

                // endpoint 확정과 첫 데이터 확보 후 subscribe 시작
                if (this.Subscribe == null)
                {
                    this.Subscribe = new Subscribe(this);
                }

                this.RunSubscribe();
            }
            catch (Exception ex)
            {
                try
                {
                    if (client != null)
                        client.Close();
                }
                catch
                {
                }

                _isopen = false;
                Console.WriteLine(ex.ToString());
                throw new Exception("The socket/UDPSerial is closed " + ex);
            }
        }

        public int Read(byte[] readto, int offset, int length)
        {
            VerifyConnected();
            if (length < 1) return 0;

            var deadline = DateTime.Now.AddMilliseconds(ReadTimeout);

            lock (rbuffer)
            {
                if (rbuffer.Position == rbuffer.Length)
                    rbuffer.SetLength(0);

                var position = rbuffer.Position;

                //Console.WriteLine("rbuffer.Length: " + rbuffer.Length + "  rbuffer.Position: " + rbuffer.Position);

                while ((rbuffer.Length - rbuffer.Position) < length && DateTime.Now < deadline)
                {
                    // read more
                    while (client.Available > 0 && (rbuffer.Length - rbuffer.Position) < length)
                    {
                        var currentRemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                        // assumes the udp packets are mavlink aligned, if we are receiving from more than one source
                        var b = client.Receive(ref currentRemoteIpEndPoint);
                        rbuffer.Seek(0, SeekOrigin.End);
                        rbuffer.Write(b, 0, b.Length);
                        rbuffer.Position = 0; //20250912 - inserted code
                        rbuffer.Seek(position, SeekOrigin.Begin);

                        if (!EndPointList.Contains(currentRemoteIpEndPoint))
                            EndPointList.Add(currentRemoteIpEndPoint);
                    }

                    Thread.Yield();
                }

                // prevent read past end of array
                if (rbuffer.Length - rbuffer.Position < length)
                    length = (int)(rbuffer.Length - rbuffer.Position);

                return rbuffer.Read(readto, offset, length);
            }
        }

        public int ReadByte()
        {
            VerifyConnected();
            var count = 0;
            while (BytesToRead == 0)
            {
                Thread.Sleep(1);
                if (count > ReadTimeout)
                    throw new Exception("NetSerial Timeout on read");
                count++;
            }

            var buffer = new byte[1];
            Read(buffer, 0, 1);
            return buffer[0];
        }

        public int ReadChar()
        {
            return ReadByte();
        }

        public string ReadExisting()
        {
            VerifyConnected();
            var data = new byte[client.Available];
            if (data.Length > 0)
                Read(data, 0, data.Length);

            var line = Encoding.ASCII.GetString(data, 0, data.Length);

            return line;
        }

        public void WriteLine(string line)
        {
            VerifyConnected();
            line = line + "\n";
            Write(line);
        }

        public void Write(string line)
        {
            VerifyConnected();
            var data = new ASCIIEncoding().GetBytes(line);
            Write(data, 0, data.Length);
        }

        public void Write(byte[] write, int offset, int length)
        {
            VerifyConnected();
            // this is not ideal. but works
            foreach (var ipEndPoint in EndPointList)
                try
                {
                    client.Send(write, length, ipEndPoint);
                }
                catch
                {
                } //throw new Exception("Comport / Socket Closed"); }
        }

        /// <summary>
        /// Write bytes to serial port.
        /// </summary>
        /// <param name="buffer"></param>
        public void WriteBytes(byte[] buffer)
        {
            this.Write(buffer, 0, buffer.Length);
        }
        public void DiscardInBuffer()
        {
            VerifyConnected();
            var size = client.Available;
            var crap = new byte[size];
            Console.WriteLine("UdpSerial DiscardInBuffer {0}", size);
            Read(crap, 0, size);
        }

        public string ReadLine()
        {
            var temp = new byte[4000];
            var count = 0;
            var timeout = 0;

            while (timeout <= 100)
            {
                if (!IsOpen) break;
                if (BytesToRead > 0)
                {
                    var letter = (byte) ReadByte();

                    temp[count] = letter;

                    if (letter == '\n') // normal line
                        break;

                    count++;
                    if (count == temp.Length)
                        break;
                    timeout = 0;
                }
                else
                {
                    timeout++;
                    Thread.Sleep(5);
                }
            }

            Array.Resize(ref temp, count + 1);

            return Encoding.ASCII.GetString(temp, 0, temp.Length);
        }

        public void Close()
        {
            _isopen = false;
            if (client != null) client.Close();

            client = new UdpClient();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void VerifyConnected()
        {
            if (client == null || !IsOpen)
            {
                Close();
                throw new Exception("The socket/serialproxy is closed");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                Close();
                client = null;
            }

            // free native resources
        }
    }
}