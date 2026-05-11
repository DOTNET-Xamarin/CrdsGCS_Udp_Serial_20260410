using CrdsController.Controllers;
using CrdsModel.Mavlink;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrdsView
{
    enum MavMsgsPackedType
    {
        GPS_RTCM_DATA,
        GPS_INJECT_DATA,
        DATA96
    }

    abstract class AbstractSink
    {
      
        public bool Enabled { get; set; }
        protected DateTime lastTimeSent;
        protected DateTime lastReconnectAttempt;
        private double RECONNECT_DELAY = 2;
        private object innerlock = new object();

        protected void Connect()
        {
            lock (innerlock)
            {
                DoDisconnect();
                DoConnect();
                Enabled = true;
            }
        }

        public void Disconnect()
        {
            lock (innerlock)
            {
                DoDisconnect();
                Enabled = false;
            }
        }

        public void Send(byte[]  data)
        {
            lock (innerlock)
            {
                try
                {
                    // Do not send data while we trying to reconnect
                    if (DateTime.Now - lastReconnectAttempt < TimeSpan.FromSeconds(RECONNECT_DELAY))
                        return;

                    DoSend(data);
                    lastTimeSent = DateTime.Now;
                    
                }
                catch (Exception ex)
                {
                    if (DateTime.Now - lastReconnectAttempt > TimeSpan.FromSeconds(RECONNECT_DELAY))
                    {
                        lastReconnectAttempt = DateTime.Now; // Reset stopwatch to avoid endless Reconnection
                        try
                        {
                            DoDisconnect();
                            DoConnect();
                        } catch (Exception exrec)
                        {

                        }
                    }
                }
            }
        }

        protected abstract void DoConnect();
        protected abstract void DoSend(byte[] data);
        protected abstract void DoDisconnect();              
    }

    class SerialSink : AbstractSink
    {
        private SerialPort serialSink;
        private string port;
        private int baudRate;

        public void Enable(string port, int baudRate)
        {
            this.port = port;
            this.baudRate = baudRate;
            Connect();
        }

        protected override void DoConnect()
        {
            serialSink = new SerialPort(port);
            serialSink.BaudRate = baudRate;
            serialSink.Open();
        }

        protected override  void DoDisconnect()
        {
            if (serialSink != null)
            {                
                serialSink.Close();
                serialSink = null;
            }
        }

        protected override void DoSend(byte[] data)
        {
            if (serialSink != null)
            {
                serialSink.Write(data, 0, data.Length);             
            }
        }
    }

    class UdpSink : AbstractSink
    {
        private Socket udpSink;
        private IPEndPoint endPoint;
        private IPEndPoint localEndPoint;
        private string host;
        private int port;
        private int localPort;

        public void Enable(string host, int port)
        {
            this.host = host;
            this.port = port;
            this.localPort = CrdsView.Properties.Settings.Default.UdpLocalPort; 
            Connect();            
        }

        protected override void DoConnect()
        {
            udpSink = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            endPoint = new IPEndPoint(IPAddress.Parse(host), port);
            localEndPoint = new IPEndPoint(IPAddress.Any, localPort);
            
            udpSink.Bind(localEndPoint);
        }

        protected override void DoDisconnect()
        {
            if (udpSink != null)
            {
                udpSink.Close();
                udpSink = null;
            }
        }

        protected override void DoSend(byte[] data)
        {
            if (udpSink != null)
            {
                udpSink.SendTo(data, endPoint);
            }
        }
    }

    
    class RtkTransmitter
    {
        private SerialSink serialSink = new SerialSink();
        private UdpSink udpSink = new UdpSink();
        private List<AbstractSink> sinks;

        // we will put this copmonents id to mavlink messages to
        // separate channels onboard
        private byte wifiCompIdSettings = 25;
        private byte serialCompIdSettings = 26;

        public void SetCompIdSettings(byte wifiCompId, byte serialCompId)
        {
            wifiCompIdSettings = wifiCompId;
            serialCompIdSettings = serialCompId;
        }
        
        public RtkTransmitter()
        {
            sinks = new List<AbstractSink> { serialSink, udpSink };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception">Various serial port exceptions</exception>
        /// <param name="serialPortName"></param>
        public void SetSerialSink(string serialPortName, int baudRate)
        {
            serialSink.Enable(serialPortName, baudRate);
        }

        public void DisableSerialSink()
        {
            serialSink.Disconnect();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception">Various network/parsing exceptions</exception>
        /// <param name="host"></param>
        public void SetUdpClientSink(string host, int port)
        {
            udpSink.Enable(host, port);
        }

        public void DisableUdpClientSink()
        {
            udpSink.Disconnect();
        }

        private const int SYSTEM_ID = 255;

        public DateTime lastTimeSent;
        public DateTime LastTimeSet {
             get { return this.lastTimeSent; }
        }

        byte rtcmSequenceNumber = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception">Various IO exceptions</exception>
        /// <param name="data"></param>
        /// <param name="length"></param>
        private void Transmit(Message_GPS_RTCM_DATA message)
        {
            try
            {
                //Console.WriteLine("Transmit() - Trying to transmit RTCM message...");
                //string hexString = BitConverter.ToString(message.Buffer).Replace("-", " ");
                //Console.WriteLine($"message --> {hexString}");

                Packet packet;
                //bool result = InterfaceController.Instance.GetCurrentVehicle().IsMavlink2;
                //if (result)
                //{
                    // mavlink2
                    //packet = Packet.CreateMavLink2(this.Seq, (byte)this.SystemId, (byte)this.ComponentId,
                    //    message);
                    packet = Packet.CreateMavLink2(rtcmSequenceNumber, (byte)255, (byte)190,
                        (Message_GPS_RTCM_DATA)message);
                    //EOB - 20251107 - inserted to check complete MAVLink message packed with RTCM message
                    Console.WriteLine("MAVLink Ver - V2.0");
                    string hexStr = BitConverter.ToString(packet.Buffer).Replace("-", " ");
                    Console.WriteLine($"{hexStr}");
                    //EOB - 20251107 - inserted to check complete MAVLink message packed with RTCM message
                //}
                /*
                else
                {
                    Console.WriteLine("Transmit() - Make a MAVLink1 packet of RTCM message...");
                    //packet = Packet.CreateMavLink1(this.Seq, (byte)this.SystemId, (byte)this.ComponentId,
                    //    message);
                    packet = Packet.CreateMavLink1(rtcmSequenceNumber, (byte)255, (byte)190,
                        message);
                    Console.WriteLine("MAVLink Ver - V1.0");
                }
                */

                Parallel.ForEach(sinks, sink => {
                    lock (sink)
                    {
                        if (sink.Enabled)
                        {
                            if (sink.GetType() == typeof(SerialSink))
                            {
                                sink.Send(packet.Buffer);
                            }
                            else
                            {
                                Console.WriteLine("Transmit() - Trying to send RTCM message to UDP sink...");
                                sink.Send(packet.Buffer);
                            }
                            lastTimeSent = DateTime.Now;
                        }
                    }
                });
                rtcmSequenceNumber++;
            }
            catch (Exception e)
            {

                throw;
            }         
        }

        

        /*
        public void InjectGpsData(byte sysid, byte compid, byte[] data, ushort length, bool rtcm_message = true)
        {
            // new message
            if (rtcm_message)
            {
                mavlink_gps_rtcm_data_t gps = new mavlink_gps_rtcm_data_t();
                var msglen = 180;

                // TODO: if (length > msglen * 4)
                //log.Error("Message too large " + length);

                // number of packets we need, including a termination packet if needed
                var nopackets = (length % msglen) == 0 ? length / msglen + 1 : (length / msglen) + 1;

                if (nopackets >= 4)
                    nopackets = 4;

                // flags = isfrag(1)/frag(2)/seq(5)

                for (int a = 0; a < nopackets; a++)
                {
                    // check if its a fragment
                    if (nopackets > 1)
                        gps.flags = 1;
                    else
                        gps.flags = 0;

                    // add fragment number
                    gps.flags += (byte)((a & 0x3) << 1);

                    // add seq number
                    gps.flags += (byte)((rtcmSequenceNumber & 0x1f) << 3);

                    // create the empty buffer
                    gps.data = new byte[msglen];

                    // calc how much data we are copying
                    int copy = Math.Min(length - a * msglen, msglen);

                    // copy the data
                    Array.Copy(data, a * msglen, gps.data, 0, copy);

                    // set the length
                    gps.len = (byte)copy;

                    ...
                    //generatePacket((byte)MAVLINK_MSG_ID.GPS_RTCM_DATA, gps, sysid, compid);
                }

                rtcmSequenceNumber++;
            }
            else
            {
                mavlink_gps_inject_data_t gps = new mavlink_gps_inject_data_t();
                var msglen = 110;

                var len = (length % msglen) == 0 ? length / msglen : (length / msglen) + 1;

                for (int a = 0; a < len; a++)
                {
                    gps.data = new byte[msglen];

                    int copy = Math.Min(length - a * msglen, msglen);

                    Array.Copy(data, a * msglen, gps.data, 0, copy);
                    gps.len = (byte)copy;
                    gps.target_component = compid;
                    gps.target_system = sysid;

                    ...
                    //generatePacket((byte)MAVLINK_MSG_ID.GPS_INJECT_DATA, gps, sysid, compid);
                }
            }
        }
        */

        /*
        void generatePacket(int messageType, object indata, int sysid, int compid, bool forcemavlink2 = false, bool forcesigning = false)
        {
            
                byte[] data = MavlinkUtil.StructureToByteArray(indata);
                byte[] packet = new byte[0];
                int i = 0;
            
                    // trim packet for mavlink2
                    MavlinkUtil.trim_payload(ref data);

                    packet = new byte[data.Length + MAVLINK_NUM_HEADER_BYTES + MAVLINK_NUM_CHECKSUM_BYTES + MAVLINK_SIGNATURE_BLOCK_LEN];

                    packet[0] = MAVLINK_STX;
                    packet[1] = (byte)data.Length;
                    packet[2] = 0; // incompat
                    if (MAVlist[sysid, compid].signing || forcesigning) // current mav
                        packet[2] |= MAVLINK_IFLAG_SIGNED;
                    packet[3] = 0; // compat
                    packet[4] = (byte)packetcount;

                    packetcount++;

                    packet[5] = gcssysid;
                    packet[6] = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
                    packet[7] = (byte)(messageType & 0xff);
                    packet[8] = (byte)((messageType >> 8) & 0xff);
                    packet[9] = (byte)((messageType >> 16) & 0xff);

                    i = 10;
                    foreach (byte b in data)
                    {
                        packet[i] = b;
                        i++;
                    }

                    ushort checksum = MavlinkCRC.crc_calculate(packet, packet[1] + MAVLINK_NUM_HEADER_BYTES);

                    checksum = MavlinkCRC.crc_accumulate(MAVLINK_MESSAGE_INFOS.GetMessageInfo((uint)messageType).crc, checksum);

                    byte ck_a = (byte)(checksum & 0xFF); ///< High byte
                    byte ck_b = (byte)(checksum >> 8); ///< Low byte

                    packet[i] = ck_a;
                    i += 1;
                    packet[i] = ck_b;
                    i += 1;

                    if (MAVlist[sysid, compid].signing || forcesigning)
                    {
                        //https://docs.google.com/document/d/1ETle6qQRcaNWAmpG2wz0oOpFKSF_bcTmYMQvtTGI8ns/edit

                        
                        // 8 bits of link ID
                        // 48 bits of timestamp
                        // 48 bits of signature
                        

                        // signature = sha256_48(secret_key + header + payload + CRC + link-ID + timestamp)

                        var timestamp = (UInt64)((DateTime.UtcNow - new DateTime(2015, 1, 1)).TotalMilliseconds * 100);

                        if (timestamp == MAVlist[sysid, compid].timestamp)
                            timestamp++;

                        MAVlist[sysid, compid].timestamp = timestamp;

                        var timebytes = BitConverter.GetBytes(timestamp);

                        var sig = new byte[7]; // 13 includes the outgoing hash
                        sig[0] = MAVlist[sysid, compid].sendlinkid;
                        Array.Copy(timebytes, 0, sig, 1, 6); // timestamp

                        //Console.WriteLine("gen linkid {0}, time {1} {2} {3} {4} {5} {6} {7}", sig[0], sig[1], sig[2], sig[3], sig[4], sig[5], sig[6], timestamp);

                        var signingKey = MAVlist[sysid, compid].signingKey;

                        if (signingKey == null || signingKey.Length != 32)
                        {
                            signingKey = new byte[32];
                        }

                        using (SHA256Managed signit = new SHA256Managed())
                        {
                            signit.TransformBlock(signingKey, 0, signingKey.Length, null, 0);
                            signit.TransformBlock(packet, 0, i, null, 0);
                            signit.TransformFinalBlock(sig, 0, sig.Length);
                            var ctx = signit.Hash;
                            // trim to 48
                            Array.Resize(ref ctx, 6);

                            foreach (byte b in sig)
                            {
                                packet[i] = b;
                                i++;
                            }

                            foreach (byte b in ctx)
                            {
                                packet[i] = b;
                                i++;
                            }
                        }
                    }
        }
        */

        public bool Send(byte[] data, int length, MavMsgsPackedType mavType)
        {
            Console.WriteLine($"Trying to send RTCM message...");

            if (mavType == MavMsgsPackedType.GPS_RTCM_DATA) {

                
                const byte RTCM_MSGLEN = 180;
                byte[] data_buffer = new byte[RTCM_MSGLEN];
                byte flags = 0;

                // number of packets we need, including a termination packet if needed
                //var nopackets = (length % RTCM_MSGLEN) == 0 ? length / RTCM_MSGLEN + 1 : (length / RTCM_MSGLEN) + 1;
                var nopackets = length / RTCM_MSGLEN + 1;

                /* BOB - 20251106 - test code */
                //string hexStr = BitConverter.ToString(data).Replace("-", " ");
                //Console.WriteLine($"{nopackets} packets : {hexStr}");
                /* EOB - 20251106 - test code */

                if (nopackets > 4)
                {
                    Console.WriteLine($"Error : More than 4 packets. returning...");

                    return false;
                }

                for (int a = 0; a < nopackets; a++)
                {
                    flags = 0;
                    flags |= (byte)((nopackets > 1) ? 1 : 0);
                    flags |= (byte)((a & 0x3) << 1);
                    flags |= (byte)((rtcmSequenceNumber & 0x1f) << 3);
                    
                    // calc how much data we are copying
                    var copy = (byte)Math.Min(length - a * RTCM_MSGLEN, RTCM_MSGLEN);
                    //message.len = copy;

                    //message.data = new byte[RTCM_MSGLEN];
                    // copy the data
                    Array.Copy(data, a * RTCM_MSGLEN, data_buffer, 0, copy);

                    Message_GPS_RTCM_DATA message = new Message_GPS_RTCM_DATA(flags, copy, data_buffer);
                    Transmit((Message_GPS_RTCM_DATA)message);
                }

                rtcmSequenceNumber++;
            }
            
            return true;
        }
    }
}
