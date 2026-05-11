using CrdsModel.CommunicationPort;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Crds.CommunicationPort
{
    public class SerialPort : ICommsSerial
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
                //BOB - 20260331 - debug
                Console.WriteLine("RunSubscribe called");
                Console.WriteLine("Subscribe is null = " + (this.Subscribe == null));
                Console.WriteLine("Subscribe thread alive = " + (this.Subscribe != null && this.Subscribe.IsThreadAlive));
                //BOB - 20260331 - debug

                if (this.Subscribe != null)
                {
                    if (!this.Subscribe.IsThreadAlive)
                    {
                        this.Subscribe.StartReader();
                    }

                    return true;
                }

                this.Subscribe = new Subscribe(this);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message}");
                return false;
            }
        }

        #endregion

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        /// <summary>
        /// Read Mavlink packet
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> ReadMavlink()
        {
            //BOB - 20260331 - debug - show ReadMavlink called and bytes to read
            //Console.WriteLine("### OUTER SerialPort.ReadMavlink ENTER ###");
            //EOB - 20260331 - debug

            await _semaphore.WaitAsync();
            try
            {
                if (this.ReadTimeout != 1200)
                {
                    this.ReadTimeout = 1200;
                }

                // delay ReadTimeout.
                DateTime timeout = DateTime.Now.AddMilliseconds(this.ReadTimeout);

                // TODO : memory reading.
                //MemoryStream stream = new MemoryStream();

                while (true)
                {
                    if (DateTime.Now > timeout)
                    {
                        throw new TimeoutException(
                            $"No received packet from {timeout.AddMilliseconds(-ReadTimeout)} " +
                            $"to {timeout}");
                    }

                    int stx = this.ReadByte();
                    // make packet.
                    if (stx == 0xFD || stx == 0xFE)
                    {
                        int packetlen = 0;
                        int len = this.ReadByte();
                        int temp = this.ReadByte();

                        if (stx == 0xFD)
                        {
                            // mavlink 2
                            packetlen += (12 + len);
                            if (temp == 0x01)
                            {
                                packetlen += 13;
                            }
                        }
                        else
                        {
                            // mavlink 1
                            packetlen += (8 + len);
                        }

                        byte[] packet = new byte[packetlen];
                        packet[0] = (byte)stx;
                        packet[1] = (byte)len;
                        packet[2] = (byte)temp;
                        for (int p = 3; p < packetlen; p++)
                        {
                            packet[p] = (byte)this.ReadByte();
                        }

                        //BOB - 20260331 - debug - show ReadMavlink called and bytes to read
                        //Console.WriteLine("CommsSerialPort.ReadMavlink packet len = " + packet.Length);
                        //EOB - 20260331 - debug

                        return packet;
                    }
                }
            }
            catch (TimeoutException e_timeout)
            {
                // Show something. about timeout.
                Debug.WriteLine(e_timeout.Message);
                return null;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                /// How to throw?
                //throw e;
                return null;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public static Func<SerialPort, string, int, ICommsSerial> DefaultType { get; set; } = (self, portname, baudrate) =>
        {
            return new WinSerialPort();
        };

        public ICommsSerial _baseport;

        public SerialPort()
        {
            _baseport = DefaultType.Invoke(this, null, 0);
        }

        public SerialPort(string portname, int baudrate)
        {
            _baseport = DefaultType.Invoke(this, portname, baudrate);
            PortName = portname;
            BaudRate = baudrate;
        }

        public SerialPort(string portname)
        {
            _baseport = DefaultType.Invoke(this, portname, 0);
            PortName = portname;
        }

        public void Dispose()
        {
            _baseport.Dispose();
        }

        public Stream BaseStream => _baseport.BaseStream;

        public int BaudRate
        {
            get
            {
                if (_baseport == null) return 0; return _baseport.BaudRate; }
            set
            {
                if (_baseport == null)
                    _baseport = DefaultType.Invoke(this, PortName, value);
                if(_baseport == null) // we are trying to set baudrate on a port that has no portname/doesnt exist
                    return;
                _baseport.BaudRate = value;
            }
        }

        public int BytesToRead => _baseport.BytesToRead;

        public int BytesToWrite => _baseport.BytesToWrite;

        public int DataBits
        {
            get => _baseport.DataBits;
            set => _baseport.DataBits = value;
        }

        public bool DtrEnable
        {
            get => _baseport.DtrEnable;
            set => _baseport.DtrEnable = value;
        }

        public bool IsOpen
        {
            get
            {
                if (_baseport == null) return false;
                return _baseport.IsOpen;
            }
        }

        public string PortName
        {
            get
            {
                if (_baseport == null) return "";
                return _baseport.PortName;
            }
            set
            {
                if (_baseport != null)
                    _baseport.PortName = value;
                if (_baseport == null)
                    _baseport = DefaultType.Invoke(this, value, 0);
            }
        }

        public int ReadBufferSize
        {
            get => _baseport.ReadBufferSize;
            set => _baseport.ReadBufferSize = value;
        }

        public int ReadTimeout
        {
            get => _baseport.ReadTimeout;
            set => _baseport.ReadTimeout = value;
        }

        public bool RtsEnable
        {
            get => _baseport.RtsEnable;
            set => _baseport.RtsEnable = value;
        }

        public int WriteBufferSize
        {
            get => _baseport.WriteBufferSize;
            set => _baseport.WriteBufferSize = value;
        }

        public int WriteTimeout
        {
            get => _baseport.WriteTimeout;
            set => _baseport.WriteTimeout = value;
        }

        public void Close()
        {
            _baseport.Close();
        }

        public void DiscardInBuffer()
        {
            _baseport.DiscardInBuffer();
        }

        public void Open()
        {
            if (espFix && _baseport is WinSerialPort)
            {
                ((WinSerialPort)_baseport).espFix = true;
            }

            Console.WriteLine("### SerialPort.Open START ###");
            _baseport.Open();
            Console.WriteLine("### SerialPort.Open END ###");
            Console.WriteLine("### SerialPort.Subscribe null = " + (this.Subscribe == null) + " ###");
            Console.WriteLine("### BasePort.Subscribe null = " + (_baseport.Subscribe == null) + " ###");

            this.Subscribe = _baseport.Subscribe;

            // 여기서 굳이 RunSubscribe를 또 안 불러도 됨
            // _baseport.Open() 안에서 subscribe가 이미 시작되기 때문
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return _baseport.Read(buffer, offset, count);
        }

        public int ReadByte()
        {
            return _baseport.ReadByte();
        }

        public int ReadChar()
        {
            return _baseport.ReadChar();
        }

        public string ReadExisting()
        {
            return _baseport.ReadExisting();
        }

        public string ReadLine()
        {
            return _baseport.ReadLine();
        }

        public void Write(string text)
        {
            _baseport.Write(text);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            _baseport.Write(buffer, offset, count);
        }

        /// <summary>
        /// Write bytes to serial port.
        /// </summary>
        /// <param name="buffer"></param>
        public void WriteBytes(byte[] buffer)
        {
            this.Write(buffer, 0, buffer.Length);
        }

        public void WriteLine(string text)
        {
            _baseport.WriteLine(text);
        }

        public void toggleDTR()
        {
            _baseport.toggleDTR();
        }


        public bool espFix = false;

        private static readonly object locker = new object();

        private static readonly Dictionary<string, string> comportnamecache = new Dictionary<string, string>();

        private static string portnamenice = "";

        public new static string[] GetPortNames()
        {
            // prevent hammering
            lock (locker)
            {
                var allPorts = new List<string>();

                if (Directory.Exists("/dev/"))
                {
                    // cleanup now
                    GC.Collect();
                    // mono is failing in here on linux "too many open files"
                    try
                    {
                        if (Directory.Exists("/dev/serial/by-id/"))
                            allPorts.AddRange(Directory.GetFiles("/dev/serial/by-id/", "*"));
                    }
                    catch
                    {
                    }

                    try
                    {
                        allPorts.AddRange(Directory.GetFiles("/dev/", "ttyACM*"));
                    }
                    catch
                    {
                    }

                    try
                    {
                        allPorts.AddRange(Directory.GetFiles("/dev/", "ttyUSB*"));
                    }
                    catch
                    {
                    }

                    try
                    {
                        allPorts.AddRange(Directory.GetFiles("/dev/", "rfcomm*"));
                    }
                    catch
                    {
                    }

                    try
                    {
                        allPorts.AddRange(Directory.GetFiles("/dev/", "*usb*"));
                    }
                    catch
                    {
                    }

                    try
                    {
                        allPorts.AddRange(Directory.GetFiles("/dev/", "tty.*"));
                    }
                    catch
                    {
                    }

                    try
                    {
                        allPorts.AddRange(Directory.GetFiles("/dev/", "cu.*"));
                    }
                    catch
                    {
                    }
                }

                string[] ports = null;

                try
                {
                    ports = System.IO.Ports.SerialPort.GetPortNames();
                    // any exceptions will still result in a list
                    ports = ports.Select(p => p?.TrimEnd()).ToArray();
                    ports = ports.Select(FixBlueToothPortNameBug).ToArray();
                }
                catch
                {
                }

                if (ports != null)
                    allPorts.AddRange(ports);

                if (GetCustomPorts != null)
                {
                    try
                    {
                        allPorts.AddRange(GetCustomPorts.Invoke());
                    }
                    catch
                    {
                    }
                }

                return allPorts.Distinct().ToArray();
            }
        }

        public static Func<List<string>> GetCustomPorts;

        public static string GetNiceName(string port)
        {
            // make sure we are exclusive
            lock (locker)
            {
                portnamenice = "";

                if (port == "AUTO" || port == "UDP" || port == "UDPCl" || port == "TCP" || port == "WS")
                    return "";

                if (comportnamecache.ContainsKey(port))
                {
                    Console.WriteLine("done GetNiceName cache " + port + " " + comportnamecache[port]);
                    return comportnamecache[port];
                }

                try
                {
                    Console.WriteLine("start GetNiceName " + port);

                    CallWithTimeout(GetName, 1000, port);
                }
                catch
                {
                }

                Console.WriteLine("done GetNiceName " + port + " = " + portnamenice);

                comportnamecache[port] = portnamenice;

                return (string) portnamenice.Clone();
            }
        }

        public delegate string EventArgsDeviceName(string port);

        public static event EventArgsDeviceName GetDeviceName;

        private static void GetName(string port)
        {
            try
            {
                var ans = GetDeviceName?.Invoke(port);
                if (!String.IsNullOrEmpty(ans))
                {
                    portnamenice = ans;
                    return;
                }
            }
            catch
            {
            }

            portnamenice = "";
        }

        private static void CallWithTimeout<T>(Action<T> action, int timeoutMilliseconds, T data)
        {
            Thread threadToKill = null;
            Action wrappedAction = () =>
            {
                threadToKill = Thread.CurrentThread;
                action(data);
            };

            var result = wrappedAction.BeginInvoke(null, null);
            if (result.AsyncWaitHandle.WaitOne(timeoutMilliseconds))
            {
                wrappedAction.EndInvoke(result);
            }
            else
            {
                threadToKill.Abort();
                throw new TimeoutException();
            }
        }

        // .NET bug: sometimes bluetooth ports are enumerated with bogus characters
        // eg 'COM10' becomes 'COM10c' - one workaround is to remove the non numeric
        // char. Annoyingly, sometimes a numeric char is added, which means this
        // does not work in all cases.
        // See http://connect.microsoft.com/VisualStudio/feedback/details/236183/system-io-ports-serialport-getportnames-error-with-bluetooth
        private static string FixBlueToothPortNameBug(string portName)
        {
            if (portName == null)
                return null;
            if (!portName.StartsWith("COM"))
                return portName;
            var newPortName = "COM"; // Start over with "COM"
            foreach (var portChar in portName.Substring(3).Take(3)
            ) //  Remove "COM", put the rest in a character array
                if (char.IsDigit(portChar))
                    newPortName += portChar.ToString(); // Good character, append to portName
            //  else
            //log.WarnFormat("Bad (Non Numeric) character in port name '{0}' - removing", portName);

            return newPortName;
        }
    }

    public class WinSerialPort : System.IO.Ports.SerialPort, ICommsSerial
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
                Console.WriteLine("RunSubscribe called");
                Console.WriteLine("Subscribe is null = " + (this.Subscribe == null));
                Console.WriteLine("Subscribe thread alive = " + (this.Subscribe != null && this.Subscribe.IsThreadAlive));

                if (this.Subscribe != null)
                {
                    if (!this.Subscribe.IsThreadAlive)
                    {
                        this.Subscribe.StartReader();
                    }

                    return true;
                }

                this.Subscribe = new Subscribe(this);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message}");
                return false;
            }
        }

        #endregion

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        /// <summary>
        /// Read Mavlink packet
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> ReadMavlink()
        {
            //BOB - 20260331 - debug - show ReadMavlink called and bytes to read
            //Console.WriteLine("### INNER WinSerialPort.ReadMavlink ENTER ###");
            //EOB - 20260331 - debug

            await _semaphore.WaitAsync();
            try
            {
                if (this.ReadTimeout != 1200)
                {
                    this.ReadTimeout = 1200;
                }

                // delay ReadTimeout.
                DateTime timeout = DateTime.Now.AddMilliseconds(this.ReadTimeout);

                // TODO : memory reading.
                //MemoryStream stream = new MemoryStream();

                while (true)
                {
                    if (DateTime.Now > timeout)
                    {
                        throw new TimeoutException(
                            $"No received packet from {timeout.AddMilliseconds(-ReadTimeout)} " +
                            $"to {timeout}");
                    }

                    int stx = this.ReadByte();
                    // make packet.
                    if (stx == 0xFD | stx == 0xFE)
                    {
                        int packetlen = 0;
                        int len = this.ReadByte();
                        int temp = this.ReadByte();

                        if (stx == 0xFD)
                        {
                            // mavlink 2
                            packetlen += (12 + len);
                            if (temp == 0x01)
                            {
                                packetlen += 13;
                            }
                        }
                        else
                        {
                            // mavlink 1
                            packetlen += (8 + len);
                        }

                        byte[] packet = new byte[packetlen];
                        packet[0] = (byte)stx;
                        packet[1] = (byte)len;
                        packet[2] = (byte)temp;
                        for (int p = 3; p < packetlen; p++)
                        {
                            packet[p] = (byte)this.ReadByte();
                        }

                        //BOB - 20260331 - debug - show ReadMavlink called and bytes to read
                        //Console.WriteLine("WinSerialPort.ReadMavlink packet len = " + packet.Length);
                        //EOB - 20260331 - debug

                        return packet;
                    }
                }
            }
            catch (TimeoutException e_timeout)
            {
                // Show something. about timeout.
                Debug.WriteLine(e_timeout.Message);
                return null;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                /// How to throw?
                //throw e;
                return null;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// Write bytes to serial port.
        /// </summary>
        /// <param name="buffer"></param>
        public void WriteBytes(byte[] buffer)
        {
            this.Write(buffer, 0, buffer.Length);
        }

        public bool espFix = false;
        public WinSerialPort()
        {
        }

        public new bool DtrEnable
        {
            get => base.DtrEnable;
            set
            {
                Console.WriteLine(base.PortName + " DtrEnable " + value);
                if (base.DtrEnable == value) return;
                base.DtrEnable = value;
            }
        }

        public new bool RtsEnable
        {
            get => base.RtsEnable;
            set
            {
                Console.WriteLine(PortName + " RtsEnable " + value);
                if (base.RtsEnable == value) return;
                base.RtsEnable = value;
            }
        }

        /*
        protected override void Dispose(bool disposing)
        {
            try
            {
                try
                {
                    Type mytype = typeof(System.IO.Ports.SerialPort);
                    FieldInfo field = mytype.GetField("internalSerialStream", BindingFlags.Instance | BindingFlags.NonPublic);

                    if (field != null)
                    {
                        Stream stream = (Stream)field.GetValue(this);

                        if (stream != null)
                        {
                            try
                            {
                                stream.Dispose();
                            }
                            catch (Exception ex) { Console.WriteLine("1 " + ex.ToString()); }
                            stream = null;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine("2 " + ex.ToString()); }

                base.Dispose(disposing);
            }
            catch (Exception ex) { Console.WriteLine("3 " + ex.ToString()); }
        }
        */

        public new void Open()
        {
            // 500ms write timeout - win32 api default
            base.WriteTimeout = 500;


            if (base.IsOpen)
                return;

            try
            {
                // this causes element not found with bluetooth devices.
                if (base.BaudRate >= 115200)
                {
                    //Console.WriteLine("Doing SerialPortFixer");
                    //SerialPortFixer.Execute(PortName);
                    //Console.WriteLine("Done SerialPortFixer");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (PortName.StartsWith("/"))
                if (!File.Exists(PortName))
                    throw new Exception("No such device");


            if (espFix)
                base.Handshake = System.IO.Ports.Handshake.RequestToSend;

            //this.Subscribe = new Subscribe(this);
            //this.RunSubscribe();

            try
            {
                base.Open();
            }
            catch
            {
                try
                {
                    Close();
                }
                catch
                {
                }

                throw;
            }

            //BOB - 20260331 - added - show subscribe status after open
            // 포트가 실제 열린 뒤에 subscribe reader 시작
            if (this.Subscribe == null)
            {
                this.Subscribe = new Subscribe(this);
            }

            //this.RunSubscribe();
            //EOB - 20260331 - added

            if (espFix)
                base.Handshake = System.IO.Ports.Handshake.None;
        }

        public new void Close()
        {
            Console.WriteLine("Closing port " + PortName);
            base.Close();
        }

        public void toggleDTR()
        {
            var open = base.IsOpen;
            Console.WriteLine("toggleDTR " + IsOpen);
            try
            {
                if (!open)
                    Open();
            }
            catch
            {
            }

            base.DtrEnable = false;
            base.RtsEnable = false;

            Thread.Sleep(50);

            base.DtrEnable = true;
            base.RtsEnable = true;

            Thread.Sleep(50);

            try
            {
                if (!open)
                    Close();
            }
            catch
            {
            }

            Console.WriteLine("toggleDTR done " + IsOpen);
        }
    }

    public sealed class SerialPortFixer : IDisposable
    {
        #region IDisposable Members

        public void Dispose()
        {
            if (m_Handle != null)
            {
                m_Handle.Dispose();
                m_Handle = null;
            }

            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Members

        public static void Execute(string portName)
        {
            using (new SerialPortFixer(portName))
            {
            }
        }

        #region Implementation

        private const int DcbFlagAbortOnError = 14;
        private const int CommStateRetries = 10;
        private SafeFileHandle m_Handle;

        private SerialPortFixer(string portName)
        {
            const int dwFlagsAndAttributes = 0x40000000;
            const int dwAccess = unchecked((int) 0xC0000000);
            if (portName == null || !portName.StartsWith("COM", StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("Invalid Serial Port", "portName");
            var hFile = NativeMethods.CreateFile(@"\\.\" + portName, dwAccess, 0, IntPtr.Zero, 3, dwFlagsAndAttributes,
                IntPtr.Zero);
            if (hFile.IsInvalid) WinIoError();
            try
            {
                var fileType = NativeMethods.GetFileType(hFile);
                if (fileType != 2 && fileType != 0) throw new ArgumentException("Invalid Serial Port", "portName");
                m_Handle = hFile;
                InitializeDcb();
            }
            catch
            {
                hFile.Dispose();
                m_Handle = null;
                throw;
            }
        }

        private static class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern int FormatMessage(int dwFlags, HandleRef lpSource, int dwMessageId, int dwLanguageId,
                StringBuilder lpBuffer, int nSize, IntPtr arguments);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool GetCommState(SafeFileHandle hFile, ref Dcb lpDcb);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool SetCommState(SafeFileHandle hFile, ref Dcb lpDcb);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool ClearCommError(SafeFileHandle hFile, ref int lpErrors, ref Comstat lpStat);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, int dwShareMode,
                IntPtr securityAttrs, int dwCreationDisposition,
                int dwFlagsAndAttributes, IntPtr hTemplateFile);

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern int GetFileType(SafeFileHandle hFile);
        }

        private void InitializeDcb()
        {
            var dcb = new Dcb();
            GetCommStateNative(ref dcb);
            Console.WriteLine("before dcb flags: " + dcb.Flags);
            dcb.Flags &= ~(1u << DcbFlagAbortOnError);
            Console.WriteLine("after dcb flags: " + dcb.Flags);
            SetCommStateNative(ref dcb);
        }

        private static string GetMessage(int errorCode)
        {
            var lpBuffer = new StringBuilder(0x200);
            if (
                NativeMethods.FormatMessage(0x3200, new HandleRef(null, IntPtr.Zero), errorCode, 0, lpBuffer,
                    lpBuffer.Capacity,
                    IntPtr.Zero) != 0)
                return lpBuffer.ToString();
            return "Unknown Error";
        }

        private static int MakeHrFromErrorCode(int errorCode)
        {
            return (int) (0x80070000 | (uint) errorCode);
        }

        private static void WinIoError()
        {
            var errorCode = Marshal.GetLastWin32Error();
            throw new IOException(GetMessage(errorCode), MakeHrFromErrorCode(errorCode));
        }

        private void GetCommStateNative(ref Dcb lpDcb)
        {
            var commErrors = 0;
            var comStat = new Comstat();

            for (var i = 0; i < CommStateRetries; i++)
            {
                if (!NativeMethods.ClearCommError(m_Handle, ref commErrors, ref comStat)) WinIoError();
                if (NativeMethods.GetCommState(m_Handle, ref lpDcb)) break;
                if (i == CommStateRetries - 1) WinIoError();
            }
        }

        private void SetCommStateNative(ref Dcb lpDcb)
        {
            var commErrors = 0;
            var comStat = new Comstat();
            for (var i = 0; i < CommStateRetries; i++)
            {
                if (!NativeMethods.ClearCommError(m_Handle, ref commErrors, ref comStat)) WinIoError();
                if (NativeMethods.SetCommState(m_Handle, ref lpDcb)) break;
                if (i == CommStateRetries - 1) WinIoError();
            }
        }

        #region Nested type: COMSTAT

        [StructLayout(LayoutKind.Sequential)]
        private struct Comstat
        {
            public readonly uint Flags;
            public readonly uint cbInQue;
            public readonly uint cbOutQue;
        }

        #endregion Nested type: COMSTAT

        #region Nested type: DCB

        /*
         * https://msdn.microsoft.com/en-us/library/windows/desktop/aa363214(v=vs.85).aspx
  DWORD fBinary  :1;
  DWORD fParity  :1;
  DWORD fOutxCtsFlow  :1;
  DWORD fOutxDsrFlow  :1;
  DWORD fDtrControl  :2;
  DWORD fDsrSensitivity  :1;
  DWORD fTXContinueOnXoff  :1;
  DWORD fOutX  :1;
  DWORD fInX  :1;
  DWORD fErrorChar  :1;
  DWORD fNull  :1;
  DWORD fRtsControl  :2;
  DWORD fAbortOnError  :1;
  DWORD fDummy2  :17;
         */

        [StructLayout(LayoutKind.Sequential)]
        public struct Dcb
        {
            public readonly uint DCBlength;
            public readonly uint BaudRate;
            public uint Flags;
            public readonly ushort wReserved;
            public readonly ushort XonLim;
            public readonly ushort XoffLim;
            public readonly byte ByteSize;
            public readonly byte Parity;
            public readonly byte StopBits;
            public readonly byte XonChar;
            public readonly byte XoffChar;
            public readonly byte ErrorChar;
            public readonly byte EofChar;
            public readonly byte EvtChar;
            public readonly ushort wReserved1;
        }

        #endregion Nested type: DCB

        #endregion Implementation
    }
}