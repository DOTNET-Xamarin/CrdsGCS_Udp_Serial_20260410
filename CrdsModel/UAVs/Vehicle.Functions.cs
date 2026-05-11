using CrdsModel.CommunicationPort;
using CrdsModel.Mavlink;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using static CrdsModel.Mavlink.MavEnums;

namespace CrdsModel.UAVs
{
    public partial class Vehicle
    {
        #region For First Connection

        /// <summary>
        /// Heart Beat receiver
        /// </summary>
        /// <param name="packet"></param>
        /// <returns></returns>
        private object Receive_heartbeat(Packet packet)
        {
            //BOB - 20260331 - debug code to check message frame
            //Console.WriteLine("VehicleFunctions: Receive_heartbeat called");
            //EOB - 20260331 - debug code to check message frame

            try
            {
                if (packet is null)
                {
                    Console.WriteLine("packet is null.");
                    return null;
                }

                return packet;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public delegate void HeartBeatHandler(string state, string description);

        public event HeartBeatHandler HeartBeatEvent;

        private void InvokeHeartBeatEvent(string state, string description)
        {
            this.HeartBeatEvent?.Invoke(state, description);
        }

        /// <summary>
        /// Detect most received heartbeat.
        /// </summary>
        /// <returns></returns>
        public bool DetectHeartBeat()
        {
            try
            {
                //BOB - 20260331 - Inserted for test purpose
                Console.WriteLine("ConnectUAV ComPort type = " + this.ComPort.GetType().FullName);
                Console.WriteLine("ConnectUAV Subscribe null = " + (this.ComPort.Subscribe == null));
                //EOB - 20260331 - Inserted for test purpose

                Dictionary<Tuple<int, int>, int> history = new Dictionary<Tuple<int, int>, int>();
                Console.WriteLine("Wait HeartBeat from vehicles....");
                this.InvokeHeartBeatEvent("Wait HeartBeat", "");
                //BOB - 20250916 - inserted for test purpose
                //this.SystemId = 1;
                //this.ComponentId = 1;
                //EOB - 20250916 - inserted for test purpose

                int i = 0;
                while (i < 3)
                {
                    Subscriber s = new Subscriber(this.SystemId, this.ComponentId, 0, this.Receive_heartbeat, PERMANENCY.DISPOSABLE, timeoutSec: 20.0);
                    this.ComPort.Subscribe.DoSubscribe(s);

                    object r = s.GetResultAsync().Result;

                    if (r != null)
                    {
                        Packet t = (Packet)r;
                        var tuple = new Tuple<int, int>(t.SYSID, t.COMPID);

                        if (!history.ContainsKey(tuple))
                        {
                            history.Add(tuple, 0);
                        }

                        history[tuple] += 1;

                        Console.WriteLine($"\r\nDetect Heart --> Beat count : {history.Count}, system id : {t.SYSID}, component id : {t.COMPID}");
                        this.InvokeHeartBeatEvent("Detect HeartBeat", $"count - {history.Count}, system id - {t.SYSID}, component id - {t.COMPID}");

                        // 첫 heartbeat를 잡으면 바로 종료
                        break;
                    }

                    i++;
                }

                if (history.Count == 0) return false;

                int max = 0;
                Tuple<int, int> search = new Tuple<int, int>(-1, -1);
                foreach (KeyValuePair<Tuple<int, int>, int> pair in history)
                {
                    if (pair.Value > max)
                    {
                        max = pair.Value;
                        search = pair.Key;
                    }
                }
                this.SystemId = search.Item1;
                this.ComponentId = search.Item2;

                Console.WriteLine($"Connect to system id : {this.SystemId}, component id : {this.ComponentId} vehicle.");
                this.InvokeHeartBeatEvent("Complete HeartBeat", $"Connect to system id - {this.SystemId}, component id - {this.ComponentId} vehicle.");

                // subscribe heart beat
                this.DoSubscribeDataStream(0);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        /// <summary>
        /// Parameter initializing.
        /// </summary>
        public void RequestAllParameters()
        {
            try
            {
                // send message.
                Message_PARAM_REQUEST_LIST message = new Message_PARAM_REQUEST_LIST((byte)this.SystemId, (byte)this.ComponentId);
                this.SendMessage(message);
                int retry = 3;

                this.ComPort.Subscribe.DoSubscribe(this.SystemId, this.ComponentId, 22, this.Receive_Vehicledatas, PERMANENCY.SEMI_PERMANENT, 20);
                DateTime timeout = DateTime.Now.AddMilliseconds(20 * 1000);

                while (true)
                {
                    if (timeout < DateTime.Now)
                        return;

                    if (retry > 0)
                    {
                        this.SendMessage(message);
                        retry--;
                    }

                    if (this.ParameterCount == -1) continue;

                    // Complete.
                    if (this.ParameterCount == this.Parameters.Count) break;

                }

                Debug.WriteLine($"Total : {this.ParameterCount}, Received : {this.Parameters}");

            }
            catch (Exception e)
            {
                return;
                throw;
            }

        }

        /// <summary>
        /// Subscribe default data stream. 
        /// </summary>
        public void InitializeSubscribing()
        {
            this.DoSubscribeDataStream(1);  // sys status -> must.
            this.DoSubscribeDataStream(22); // param value -> must
            this.DoSubscribeDataStream(24); // gps raw int -> must?
            this.DoSubscribeDataStream(34); // rc channels scaled -> ?? or monitor?
            this.DoSubscribeDataStream(35); // rc channels raw -> ?? or monitor?
            this.DoSubscribeDataStream(65); // rc channels -> ?? or monitor?
            this.DoSubscribeDataStream(77); // command long -> must
            this.DoSubscribeDataStream(253); // status text -> must??
        }
        #endregion

        #region For Subscribing

        /// <summary>
        /// Do Subscribe Data Stream with permanent.
        /// </summary>
        /// <param name="msgid"></param>
        public void DoSubscribeDataStream(uint msgid)
        {
            if (_subscribedMessages.Contains(msgid))
            {
                return;
            }
            _subscribedMessages.Add(msgid);
            //this.ComPort.Subscribe.DoSubscribe((byte)this.SystemId, (byte)this.ComponentId, msgid, this.Receive_Vehicledatas, PERMANENCY.PERMANENT, -1);
            this.ComPort.Subscribe.DoSubscribe((byte)this.SystemId, (byte)this.ComponentId, msgid, this.Receive_Vehicledatas, PERMANENCY.PERMANENT, 20);
        }

        /// <summary>
        /// Do Subscribe
        /// </summary>
        /// <param name="msgid"></param>
        /// <param name="func"></param>
        /// <param name="permanency"></param>
        /// <param name="timeoutsec"></param>
        public void DoSubscribe(uint msgid, Func<Packet, object> func, PERMANENCY permanency, double timeoutsec = 5)
        {
            this.ComPort.Subscribe.DoSubscribe((byte)this.SystemId, (byte)this.ComponentId, msgid, func, permanency, timeoutsec);
        }

        /// <summary>
        /// Do Subscribe
        /// </summary>
        /// <param name="s"></param>
        public void DoSubscribe(Subscriber s)
        {
            this.ComPort.Subscribe.DoSubscribe(s);
        }

        /// <summary>
        /// Add UnSubscriber
        /// </summary>
        /// <param name="msgid"></param>
        public void AddUnSubscriber(uint msgid)
        {
            this.ComPort.Subscribe.AddUnSubscriber((byte)this.SystemId, (byte)this.ComponentId, msgid);
        }
        #endregion

        private readonly double timeout_parameter = 1.5;

        /// <summary>
        /// Set Parameter Sync
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetParameter(string id, float value)
        {
            var r = this.SetParameterAsync(id, value).GetAwaiter().GetResult();
            return r;
        }

        /// <summary>
        /// Set Parameter Async
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<bool> SetParameterAsync(string id, float value)
        {
            VehicleParameter pa;
            if (!this.Parameters.TryGetValue(id, out pa))
            {
                return false;
            }

            byte[] ids = VehicleParameter.ConvertTo16Bytes(id);
            Message_PARAM_SET m = new Message_PARAM_SET(value, (byte)this.SystemId, (byte)this.ComponentId, ids, pa.Type);

            float oldValue = pa.Value;
            this.SendMessage(m);

            bool result = false;
            //Debug.WriteLine($"run checker");
            var checker = Task.Run(() =>
            {
                DateTime timeout = DateTime.Now.AddMilliseconds(1.5 * 1000);

                while (true)
                {
                    if (timeout < DateTime.Now)
                    {
                        //Debug.WriteLine("Checker out with timeout");
                        result = false;
                        return;
                    }

                    if (this.Parameters[id].Value == value)
                    {
                        //Debug.WriteLine("Cheker out with same value.");
                        result = true;
                        return;
                    }
                }
            });
            //Debug.WriteLine($"wait checker");
            checker.Wait();
            //Debug.WriteLine($"get checker");
            return result;
        }

        /// <summary>
        /// Send Mavlink message.
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(Message message)
        {
            try
            {
                Packet packet;
                if (this.IsMavlink2)
                {
                    // mavlink2
                    //packet = Packet.CreateMavLink2(this.Seq, (byte)this.SystemId, (byte)this.ComponentId,
                    //    message);
                    packet = Packet.CreateMavLink2(this.Seq, (byte)255, (byte)190,
                        message);
                    //Console.WriteLine("MAVLink Ver - V2.0");
                    //string hexStr = BitConverter.ToString(packet.Buffer).Replace("-", " ");
                    //Console.WriteLine($"{hexStr}");
                }
                else
                {
                    //packet = Packet.CreateMavLink1(this.Seq, (byte)this.SystemId, (byte)this.ComponentId,
                    //    message);
                    packet = Packet.CreateMavLink1(this.Seq, (byte)255, (byte)190,
                        message);
                    //Console.WriteLine("MAVLink Ver - V1.0");
                }

                this.ComPort.WriteBytes(packet.Buffer);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        /// <summary>
        /// Set data stream.
        /// </summary>
        /// <param name="req_message_rate"></param>
        /// <param name="req_stream_id"></param>
        /// <param name="isStart"></param>
        public void SetDataStream(byte req_message_rate = 10, byte req_stream_id = 0, bool isStart = true)
        {
            byte start_stop = 0;
            if (isStart) start_stop = 1;

            this.SendMessage(new Message_REQUEST_DATA_STREAM(req_message_rate,
                (byte)this.SystemId, (byte)this.ComponentId, req_stream_id, start_stop));

        }

        private readonly double timeout_ack = 2.0;

        /// <summary>
        /// TODO :
        /// Send Command long message by async
        /// </summary>
        /// <param name="command"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private async Task<bool> SendCommandLongAsync(ushort command, params float[] p)
        {
            try
            {
                Message_COMMAND_LONG command_long = new Message_COMMAND_LONG(p[0], p[1], p[2], p[3], p[4], p[5], p[6],
                command, (byte)this.SystemId, (byte)this.ComponentId, this.Confirmation);
                this.SendMessage(command_long);

                DateTime timeout = DateTime.Now.AddMilliseconds(timeout_ack * 1000);
                while (true)
                {
                    if (timeout < DateTime.Now) return false;

                    if (this.command == command)
                    {
                        var value = (MavEnums.MAV_RESULT)this.result;
                        switch (value)
                        {
                            case MavEnums.MAV_RESULT.MAV_RESULT_ACCEPTED:
                                Console.WriteLine("SendCommandLong success.");
                                return true;
                            case MavEnums.MAV_RESULT.MAV_RESULT_FAILED:
                                Console.WriteLine("명령 실행에 실패했습니다.");
                                return false;
                            case MavEnums.MAV_RESULT.MAV_RESULT_DENIED:
                                Console.WriteLine("명령이 거부되었습니다.");
                                return false;
                            default:
                                Console.WriteLine($"명령 확인: 결과 {this.result}");
                                return false;                               
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            
        }

        /// <summary>
        /// Senc command long
        /// </summary>
        /// <param name="command"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="p5"></param>
        /// <param name="p6"></param>
        /// <param name="p7"></param>
        /// <returns></returns>
        public bool SendCommandLong(ushort command, float p1, float p2, float p3, float p4, float p5, float p6, float p7)
        {
            return this.SendCommandLongAsync(command, p1, p2, p3, p4, p5, p6, p7).Result;
        }

        /// <summary>
        /// Clean up 
        /// </summary>
        public void CleanSubscribe()
        {
            if (!this.ComPort.IsOpen)
                return;

            foreach(uint msgid in this._subscribedMessages)
            {
                this.AddUnSubscriber(msgid);
            }

            // subscribe clean.
            // TODO : 
        }

        public void Dispose()
        {
            // TODO : dispose.
        }
    }
}
