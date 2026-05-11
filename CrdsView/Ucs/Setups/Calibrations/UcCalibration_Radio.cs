using CrdsController.Controllers;
using CrdsModel.CommunicationPort;
using CrdsModel.Mavlink;
using CrdsModel.Mavlink.Ardupilotmega;
using CrdsModel.UAVs;
using CrdsView.Utilities;
using CrdsView.Components;
using CrdsView.Controls;
using CrdsView.Joystick;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrdsView.Ucs.Setups.Calibrations
{
    public enum FLIGHT_MODE
    {
        NONE = 0,
        FLIGHT_MODE_1 = 1,
        FLIGHT_MODE_2 = 2,
        FLIGHT_MODE_3 = 3,
        FLIGHT_MODE_4 = 4,
        FLIGHT_MODE_5 = 5,
        FLIGHT_MODE_6 = 6,
    }

    public partial class UcCalibration_Radio : UserControl, IDisposable
    {
        bool startup = true;

        int noButtons = 0;
        private int maxaxis = 16;

        // rc override
        public short rcoverridech1; //{ get; set; }
        public short rcoverridech10; // { get; set; }
        public short rcoverridech11; //{ get; set; }
        public short rcoverridech12; //{ get; set; }
        public short rcoverridech13; // { get; set; }
        public short rcoverridech14; // { get; set; }
        public short rcoverridech15; // { get; set; }
        public short rcoverridech16; // { get; set; }
        public short rcoverridech17; // { get; set; }
        public short rcoverridech18; // { get; set; }
        public short rcoverridech2; // { get; set; }
        public short rcoverridech3; //{ get; set; }
        public short rcoverridech4; //{ get; set; }
        public short rcoverridech5; // { get; set; }
        public short rcoverridech6; // { get; set; }
        public short rcoverridech7; // { get; set; }
        public short rcoverridech8; // { get; set; }
        public short rcoverridech9; //{ get; set; }

        public static Joystick.JoystickBase joystick { get; set; }

        /// Constructor / De-Constructor / Load
        #region Initialization.
        public UcCalibration_Radio()
        {
            InitializeComponent();
        }

        ~UcCalibration_Radio()
        {
            try
            {
                if(InterfaceController.Instance.GetCurrentVehicle() != null)
                {
                    InterfaceController.Instance.GetCurrentVehicle().AddUnSubscriber(22);
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Load Radio Calibration User control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcCalibration_Radio_Load(object sender, EventArgs e)
        {
            this.InitUI_UcCalibration_Radio();

            try
            {
                Console.WriteLine("Getting joystick devices...");
                var joysticklist = JoystickBase.getDevices();

                foreach (var device in joysticklist)
                {
                    cmbJoysticks.Items.Add(device);
                }

                // ComboBox에 항목이 1개 이상 있는지 확인 후 첫 번째 항목 선택
                if (cmbJoysticks.Items.Count > 0)
                {
                    cmbJoysticks.SelectedIndex = 0;
                }
            }
            catch
            {
                MessageBox.Show("Error geting joystick list: do you have the directx redist installed?");

                return;
            }

            var tempjoystick = JoystickBase.Create();

            //label14.Text += " " + MainV2.comPort.MAV.cs.firmware.ToString();

            //var y = label8.Bottom;
            var x = lblSelectJoystick.Left; 
            var y = lblControllerAxis.Bottom + 20; 

            this.SuspendLayout();

            for (int a = 1; a <= maxaxis; a++)
            {
                var config = tempjoystick.getChannel(a);

                var ax = new JoystickAxis()
                {
                    ChannelNo = a,
                    Label = "RC " + a,
                    AxisArray = (Enum.GetValues(typeof(joystickaxis))),
                    ChannelValue = config.axis.ToString(),
                    ExpoValue = config.expo.ToString(),
                    ReverseValue = config.reverse,
                    Location = new Point(x, y),
                    Name = "axis" + a
                };

                ax.CMB_CH.SelectedIndex = ax.CMB_CH.Items.IndexOf(config.axis);

                ax.Detect = () => JoystickBase.getMovingAxis(cmbJoysticks.Text, 16000).ToString();

                //BOB - 20260119 - added code
                if (!tempjoystick.start(cmbJoysticks.Text))
                {
                    MessageBox.Show("Please Connect a Joystick", "No Joystick");
                    tempjoystick.Dispose();
                    return;
                }
                CrdsGS.joystick = tempjoystick;
                //EOB - 20260119 - added code

                if (CrdsGS.joystick != null)
                {
                    //Console.WriteLine("joystick is not null!"); //20260118 - test code
                    ax.Reverse = () => CrdsGS.joystick.setReverse(ax.ChannelNo, ax.ReverseValue);
                    ax.SetAxis = () => CrdsGS.joystick.setAxis(ax.ChannelNo,
                                   (joystickaxis)Enum.Parse(typeof(joystickaxis), ax.ChannelValue));
                }
                ax.GetValue = () =>
                {
                    //    return (short)MainV2.comPort.MAV.cs.GetType().GetField("rcoverridech" + ax.ChannelNo)
                    //        .GetValue(MainV2.comPort.MAV.cs);
                    if (CrdsGS.joystick != null)
                    {
                        //return (short)joystick.GetType().GetField("rcoverridech" + ax.ChannelNo).GetValue(joystick);
                        return (short)InterfaceController.Instance.GetCurrentVehicle().GetType().GetField("rcoverridech" + ax.ChannelNo).GetValue(InterfaceController.Instance.GetCurrentVehicle());
                    }
                    else
                    {
                        Console.WriteLine("joystick is null!"); //20260118 - test code
                        return 0;
                    }
                };

                ax.Expo = () =>
                {
                    if (int.TryParse(ax.ExpoValue, out int expoValue))
                    {
                        CrdsGS.joystick?.setExpo(ax.ChannelNo, expoValue);
                    }
                };

                Controls.Add(ax);

                y += ax.Height;


                if ((ax.Bottom + 30) > this.Height)
                    this.Height = ax.Bottom;

                if ((ax.Right) > this.Width)
                    this.Width = ax.Right;
            }

            this.ResumeLayout();

            //BOB - 20260126 - moved from TimerCalibration_Tick
            if (CrdsGS.joystick != null || CrdsGS.joystick.enabled == false)
            {
                var joy = CrdsGS.joystick;
                for (int a = 1; a <= maxaxis; a++)
                {
                    var config = joy.getChannel(a);

                    joy.setChannel(a, config.axis, config.reverse, config.expo);
                    Console.WriteLine("Channel " + a + " set to axis " + config.axis.ToString() + ", reverse: " 
                        + config.reverse.ToString() + ", expo: " + config.expo.ToString());
                }

                joy.elevons = false; // CHK_elevons.Checked;

                noButtons = joy.getNumButtons();

                noButtons = Math.Min(16, noButtons);

                SuspendLayout();

                CrdsGS.joystick = joy;

                var maxctl = Controls.Find("axis" + 1, false).FirstOrDefault();

                for (int f = 0; f < noButtons; f++)
                {
                    string name = (f).ToString();

                    doButtontoUI(name, maxctl.Right + 60, maxctl.Top + f * maxctl.Height);

                    var config = joy.getButton(f);

                    joy.setButton(f, config);
                }

                ResumeLayout();

                cmbJoysticks.SelectedIndex = cmbJoysticks.Items.IndexOf(joy.name);
            }
            //EOB - 20260126 - moved from TimerCalibration_Tick

            if (CrdsGS.joystick != null && CrdsGS.joystick.enabled)
            {
                Console.WriteLine("joystick is not null! TimerCalibration is being started."); //20260118 - test code
                //BOB - 20260126 - Commented to test
                // get data stream.
                // enforcing
                InterfaceController.Instance.GetCurrentVehicle().SetDataStream(5, (byte)CrdsModel.Mavlink.MavEnums.MAV_DATA_STREAM.MAV_DATA_STREAM_RC_CHANNELS);
                //EOB - 20260126 - Commented to test
                //

                btnEnable.Text = "Disable";
                TimerCalibration.Start();
            }

            startup = false;
        }

        public new void Dispose()
        {

        }

        #endregion

        private readonly string[] rcmap_names = new string[]
        {
            "RCMAP_ROLL", "RCMAP_PITCH", "RCMAP_THROTTLE", "RCMAP_YAW"
        };

        protected bool IsStart { get; private set; } = false;
        protected Timer TimerCalibration { get; private set; }

        protected List<Label> RCLabels { get; set; }
        protected List<string> RCNames { get; set; }

        protected Dictionary<string, int> RcMaps { get; set; }
        protected Dictionary<int, bool> Reverses { get; set; }
        protected List<DualTrackBar> DualTrackbars { get; set; }

        protected Dictionary<string, float> Mins { get; set; }
        protected Dictionary<string, float> Maxs { get; set; }

        protected List<System.Windows.Forms.ComboBox> Combos { get; set; }

        /// <summary>
        ///  TODO : vehicle data set.
        /// </summary>
        /// <returns></returns>
        private bool ReadRadioParameters()
        {
            try
            {
                this.RcMaps = new Dictionary<string, int>();

                foreach(string name in this.rcmap_names)
                {
                    try
                    {
                        int v = (int)InterfaceController.Instance.GetParameter(name);
                        this.RcMaps.Add(name, v);
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                }

                this.Reverses = new Dictionary<int, bool>();
                // check reverse.
                for(int i = 1; i < 5; i++)
                {
                    string name = $"RC{i}_REVERSED";

                    try
                    {
                        int v = (int)InterfaceController.Instance.GetParameter(name);
                        bool result = v == 0 ? true : false;
                        this.Reverses.Add(i, result);
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                }

                int t = 0;
                foreach(KeyValuePair<string, int> v in this.RcMaps)
                {
                    string text = this.RCNames[t];
                    text += $" ({v.Value})";
                    string pad = this.Reverses[v.Value] == true ? "" : "R";
                    text += $" {pad}";
                    this.RCLabels[t].Text = text;
                    t++;
                }

                // Flight mode set up.
                object temp = InterfaceController.Instance.GetParameter("FLTMODE_CH");
                if (temp == null)
                {
                    this.FlightModeChannel = 0;
                    this.LabelCurrentChanel.Text = $"Disabled";
                }
                else
                {
                    this.FlightModeChannel = Convert.ToInt32(temp);
                    this.LabelCurrentChanel.Text = $"Channel {this.FlightModeChannel}";
                }

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private FLIGHT_MODE ConvertPWM(ushort pwm)
        {
            if (pwm < 0)
            {
                return FLIGHT_MODE.NONE;
            }
            else if (pwm <= 1230)
            {
                return FLIGHT_MODE.FLIGHT_MODE_1;
            }
            else if (pwm <= 1360)
            {
                return FLIGHT_MODE.FLIGHT_MODE_2;
            }
            else if (pwm <= 1490)
            {
                return FLIGHT_MODE.FLIGHT_MODE_3;
            }
            else if (pwm <= 1620)
            {
                return FLIGHT_MODE.FLIGHT_MODE_4;
            }
            else if (pwm <= 1759)
            {
                return FLIGHT_MODE.FLIGHT_MODE_5;
            }
            else
            {
                return FLIGHT_MODE.FLIGHT_MODE_6;
            }
        }

        private int FlightModeChannel { get; set; }

        #region Init UI

        private void InitUI_UcCalibration_Radio_TrackBars()
        {
            DualTrackbars = new List<DualTrackBar>()
            {
                this.dualTrackBar1, this.dualTrackBar2, this.dualTrackBar3, this.dualTrackBar4,
                this.dualTrackBar5, this.dualTrackBar6, this.dualTrackBar7, this.dualTrackBar8,
            };

            foreach (var bar in DualTrackbars)
            {
                //bar.Value = 1800;
                bar.SetRange(0, 3000);
            }
        }

        private void InitUI_UcCalibration_Radio_RCLabels()
        {
            this.RCLabels = new List<Label>()
            {
                this.LabelRoll, this.LabelPitch, this.LabelThrottle, this.LabelYaw,
                this.LabelAux1, this.LabelAux2, this.LabelAux3, this.LabelAux4
            };
            this.RCNames = new List<string>()
            {
                "ROLL", "PITCH", "THROTTLE", "YAW", "AUX1", "AUX2", "AUX3", "AUX4"
            };

            foreach(var item in this.RCLabels.Zip(this.RCNames, Tuple.Create))
            {
                Label label = item.Item1;
                label.Text = item.Item2;
            }

        }

        private void InitUI_UcCalibration_Radio_Timer()
        {
            this.TimerCalibration = new Timer();
            this.TimerCalibration.Interval = 100;
            this.TimerCalibration.Enabled = true;
            this.TimerCalibration.Tick += TimerCalibration_Tick;
        }
        
        private void InitUI_UcCalibration_Radio_Flight_Mode()
        {
            this.LabelCurrentChanel.Text = "";
            this.LabelCurrentFlightMode.Text = "";
            this.LabelCurrentMode.Text = "";

            Combos = new List<System.Windows.Forms.ComboBox>()
            {
                this.ComboFlightMode1, this.ComboFlightMode2, this.ComboFlightMode3,
                this.ComboFlightMode4, this.ComboFlightMode5, this.ComboFlightMode6
            };

            List<KeyValuePair<string, byte>> kvp = CrdsModel.Mavlink.Ardupilotmega.MavEnums.GetCopterModes();

            foreach(System.Windows.Forms.ComboBox combo in Combos)
            {
                combo.Items.Clear();
                combo.DisplayMember = "Key";
                combo.ValueMember = "Value";
                combo.DataSource = CrdsModel.Mavlink.Ardupilotmega.MavEnums.GetCopterModes();

            }

            this.LabelCurrentChanel.Text = $"Disabled";
            
        }

        private void InitUI_UcCalibration_Radio()
        {
            this.InitUI_UcCalibration_Radio_TrackBars();

            this.InitUI_UcCalibration_Radio_RCLabels();

            this.InitUI_UcCalibration_Radio_Timer();

            this.InitUI_UcCalibration_Radio_Flight_Mode();
        }

        #endregion

        #region Events
        private void TimerCalibration_Tick(object sender, EventArgs e)
        {
            {
                this.Invoke((Action)delegate
                {
                    var iface = InterfaceController.Instance.GetInterface();
                    var vehicle = InterfaceController.Instance.GetCurrentVehicle();
                    var com = iface?.ComPort ?? vehicle?.PublicComPort;
                    
                    if (com == null || vehicle == null)
                        return;
                    this.dualTrackBar1.Value = vehicle.Chan1_raw;
                    this.dualTrackBar2.Value = vehicle.Chan2_raw;
                    this.dualTrackBar3.Value = vehicle.Chan3_raw;
                    this.dualTrackBar4.Value = vehicle.Chan4_raw;
                    this.dualTrackBar5.Value = vehicle.Chan5_raw;
                    this.dualTrackBar6.Value = vehicle.Chan6_raw;
                    this.dualTrackBar7.Value = vehicle.Chan7_raw;
                    this.dualTrackBar8.Value = vehicle.Chan8_raw;

                    //BOB - 20260124 - Test Code
                    //Console.WriteLine("ch1:" + this.dualTrackBar1.Value + "  ch2:" + this.dualTrackBar2.Value
                    //    + "  ch3:" + this.dualTrackBar3.Value + "  ch4:" + this.dualTrackBar4.Value);
                    //Console.WriteLine("ch1:" + vehicle.Chan1_raw
                    //    + "  ch2:" + vehicle.Chan2_raw
                    //    + "  ch3:" + vehicle.Chan3_raw
                    //    + "  ch4:" + vehicle.Chan4_raw);
                    //EOB - 20260124 - Test Code

                    if (this.FlightModeChannel != 0)
                    {
                        // TODO :
                        FLIGHT_MODE mode = this.ConvertPWM(vehicle.Chan5_raw);
                        this.LabelCurrentFlightMode.Text = mode.ToString().Replace("_", " ");

                        object v = InterfaceController.Instance.GetParameter($"FLTMODE{Convert.ToByte(mode)}");
                        if(v != null)
                        {
                            byte t = Convert.ToByte(v);
                            this.LabelCurrentMode.Text = Enum.GetName(typeof(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE), t).Replace("COPTER_MODE_", "");
                        }
                    }
                    
                });
                    
            }

            try
            {
                //BOB - 20260126 - not operating. commented
                /*
                Console.WriteLine("trying to doButtontoUI"); //20260118 - test code
                if (CrdsGS.joystick == null || CrdsGS.joystick.enabled == false)
                {
                    //Console.WriteLine(DateTime.Now.Millisecond + " start "); //20260118 - test code
                    Console.WriteLine("joystick is null. Now it is being checked..."); //20260118 - test code
                    var joy = CrdsGS.joystick;
                    if (joy == null)
                    {
                        joy = JoystickBase.Create();
                        for (int a = 1; a <= maxaxis; a++)
                        {
                            var config = joy.getChannel(a);

                            joy.setChannel(a, config.axis, config.reverse, config.expo);
                        }

                        joy.elevons = false; // CHK_elevons.Checked;

                        joy.AcquireJoystick(cmbJoysticks.Text);

                        joy.name = cmbJoysticks.Text;

                        noButtons = joy.getNumButtons();

                        noButtons = Math.Min(16, noButtons);

                        SuspendLayout();

                        CrdsGS.joystick = joy;

                        var maxctl = Controls.Find("axis" + 1, false).FirstOrDefault();

                        Console.WriteLine("maxctl: " + maxctl.ToString());

                        for (int f = 0; f < noButtons; f++)
                        {
                            string name = (f).ToString();

                            doButtontoUI(name, maxctl.Right + 60, maxctl.Top + f * maxctl.Height);

                            var config = joy.getButton(f);

                            joy.setButton(f, config);
                        }

                        ResumeLayout();

                        cmbJoysticks.SelectedIndex = cmbJoysticks.Items.IndexOf(joy.name);
                    }
                }
                */
                //EOB - 20260126 - not operating. commented

                

                //else
                if (CrdsGS.joystick != null)
                {
                    //Console.WriteLine("joystick is not null or joystick is enabled. "); //20260119 - test code
                    //BOB - 20260126 - Inserted for test purpose
                    var iface = InterfaceController.Instance.GetInterface();
                    var vehicle = InterfaceController.Instance.GetCurrentVehicle();
                    var com = iface?.ComPort ?? vehicle?.PublicComPort;

                    if (com == null || vehicle == null)
                        return;

                    CrdsGS.joystick.elevons = false; // CHK_elevons.Checked;

                    vehicle.rcoverridech1 = CrdsGS.joystick.getValueForChannel(1);
                    vehicle.rcoverridech2 = CrdsGS.joystick.getValueForChannel(2);
                    vehicle.rcoverridech3 = CrdsGS.joystick.getValueForChannel(3);
                    vehicle.rcoverridech4 = CrdsGS.joystick.getValueForChannel(4);
                    vehicle.rcoverridech5 = CrdsGS.joystick.getValueForChannel(5);
                    vehicle.rcoverridech6 = CrdsGS.joystick.getValueForChannel(6);
                    vehicle.rcoverridech7 = CrdsGS.joystick.getValueForChannel(7);
                    vehicle.rcoverridech8 = CrdsGS.joystick.getValueForChannel(8);
                    vehicle.rcoverridech9 = CrdsGS.joystick.getValueForChannel(9);
                    vehicle.rcoverridech10 = CrdsGS.joystick.getValueForChannel(10);
                    vehicle.rcoverridech11 = CrdsGS.joystick.getValueForChannel(11);
                    vehicle.rcoverridech12 = CrdsGS.joystick.getValueForChannel(12);
                    vehicle.rcoverridech13 = CrdsGS.joystick.getValueForChannel(13);
                    vehicle.rcoverridech14 = CrdsGS.joystick.getValueForChannel(14);
                    vehicle.rcoverridech15 = CrdsGS.joystick.getValueForChannel(15);
                    vehicle.rcoverridech16 = CrdsGS.joystick.getValueForChannel(16);
                    vehicle.rcoverridech17 = CrdsGS.joystick.getValueForChannel(17);
                    vehicle.rcoverridech18 = CrdsGS.joystick.getValueForChannel(18);

                    //Console.WriteLine("ch1:" + rcoverridech1 + "  ch2:" + rcoverridech2 + "  ch3:" + rcoverridech3 + "  ch4:" + rcoverridech4);
                }
            }
            catch (SharpDX.SharpDXException ex)
            {
                ex.ToString();
                if (CrdsGS.joystick != null && CrdsGS.joystick.enabled == true)
                {
                    btnEnable_Click(null, null);
                }

                if (ex.Message.Contains("DIERR_NOTACQUIRED"))
                    CrdsGS.joystick = null;
            }
            catch
            {

            }

            try
            {
                for (int f = 0; f < noButtons; f++)
                {
                    string name = (f).ToString();

                    var items = this.Controls.Find("hbar" + name, false);

                    if (items.Length > 0)
                        ((System.Windows.Forms.ProgressBar)items[0]).Value =
                            CrdsGS.joystick.isButtonPressed(f) ? 100 : 0;
                }
            }
            catch
            {
            } // this is for buttons - silent fail
        }

        void doButtontoUI(string name, int x, int y)
        {
            System.Windows.Forms.Label butlabel = new System.Windows.Forms.Label();
            System.Windows.Forms.ComboBox butnumberlist = new System.Windows.Forms.ComboBox();
            MyButton but_detect = new MyButton();
            System.Windows.Forms.ProgressBar hbar = new System.Windows.Forms.ProgressBar();
            System.Windows.Forms.ComboBox cmbaction = new System.Windows.Forms.ComboBox();
            MyButton but_settings = new MyButton();

            if (CrdsGS.joystick == null)
            {
                butlabel.Dispose();
                butnumberlist.Dispose();
                but_detect.Dispose();
                hbar.Dispose();
                cmbaction.Dispose();
                but_settings.Dispose();
                return;
            }

            var config = CrdsGS.joystick.getButton(int.Parse(name));


            butlabel.Location = new Point(x, y);
            butlabel.Size = new Size(80, 25);
            butlabel.Text = "But " + (int.Parse(name) + 1);

            butnumberlist.Location = new Point(butlabel.Right, y);
            butnumberlist.Size = new Size(70, 25);
            //butnumberlist.DataSource = getButtonNumbers();

            butnumberlist.Items.AddRange(getButtonNumbers().Select(item => item.ToString()).ToArray());
            butnumberlist.SelectedIndex = 0;


            butnumberlist.DropDownStyle = ComboBoxStyle.DropDownList;
            butnumberlist.Name = "cmbbutton" + name;

            //butnumberlist.SelectedItem = "-1";
            butnumberlist.SelectedItem = config.buttonno.ToString();

            //if (Settings.Instance["butno" + name] != null)
            //    butnumberlist.Text = (Settings.Instance["butno" + name].ToString());
            //if (config.buttonno != -1)

            //butnumberlist.Text = config.buttonno.ToString();

            butnumberlist.SelectedIndexChanged += new EventHandler(cmbbutton_SelectedIndexChanged);

            but_detect.Location = new Point(butnumberlist.Right, y);
            //but_detect.Size = BUT_detch1.Size;
            but_detect.Text = "Detect";
            but_detect.AutoSize = true;

            but_detect.Name = "mybut" + name;
            but_detect.Click += new EventHandler(BUT_detbutton_Click);

            hbar.Location = new Point(but_detect.Right, y);
            hbar.Size = new Size(100, 30);
            hbar.Name = "hbar" + name;

            cmbaction.Location = new Point(hbar.Right + 5, y);
            cmbaction.Size = new Size(150, 25);

            //cmbaction.DataSource = Enum.GetNames(typeof(buttonfunction));
            cmbaction.Items.AddRange(Enum.GetNames(typeof(buttonfunction)));


            //Common.getModesList(MainV2.comPort.MAV.cs);
            //cmbaction.ValueMember = "Key";
            //cmbaction.DisplayMember = "Value";
            cmbaction.Tag = name;
            cmbaction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbaction.Name = "cmbaction" + name;
            //if (Settings.Instance["butaction" + name] != null)
            //  cmbaction.Text = Settings.Instance["butaction" + name].ToString();
            //if (config.function != buttonfunction.ChangeMode)
            cmbaction.Text = config.function.ToString();
            cmbaction.SelectedIndexChanged += cmbaction_SelectedIndexChanged;

            but_settings.Location = new Point(cmbaction.Right + 5, y);
            but_settings.Size = new Size(80, 30);
            but_settings.Text = "Settings";
            but_settings.Name = "butsettings" + name;
            but_settings.Click += but_settings_Click;
            but_settings.Tag = cmbaction;

            // do this here so putting in text works
            this.Controls.AddRange(new Control[] { butlabel, butnumberlist, but_detect, hbar, cmbaction, but_settings });

            if ((but_settings.Bottom + 30) > this.Height)
                this.Height += 25;

            if ((but_settings.Right) > this.Width)
                this.Width = but_settings.Right + 5;
        }

        int[] getButtonNumbers()
        {
            int[] temp = new int[128];
            temp[0] = -1;
            for (int a = 0; a < temp.Length - 1; a++)
            {
                temp[a + 1] = a;
            }
            return temp;
        }

        private void cmbbutton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startup)
                return;

            string name = ((System.Windows.Forms.ComboBox)sender).Name.Replace("cmbbutton", "");

            CrdsGS.joystick.changeButton((int.Parse(name)), int.Parse(((System.Windows.Forms.ComboBox)sender).Text));
        }

        private void BUT_detbutton_Click(object sender, EventArgs e)
        {
            string name = ((System.Windows.Forms.Button)sender).Name.Replace("mybut", "");

            System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)(this.Controls.Find("cmbbutton" + name, false)[0]);
            cmb.Text = JoystickBase.getPressedButton(cmbJoysticks.Text).ToString();
        }


        void cmbaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(((Control)sender).Tag.ToString());
            var config = CrdsGS.joystick.getButton(num);
            config.function =
                (buttonfunction)Enum.Parse(typeof(buttonfunction), ((Control)sender).Text);
            CrdsGS.joystick.setButton(num, config);
        }

        void but_settings_Click(object sender, EventArgs e)
        {
            var cmb = ((Control)sender).Tag as System.Windows.Forms.ComboBox;

            switch ((buttonfunction)Enum.Parse(typeof(buttonfunction), cmb.SelectedItem.ToString()))
            {
                case buttonfunction.ChangeMode:
                    //new Joy_ChangeMode((string)cmb.Tag).ShowDialog();
                    break;
                case buttonfunction.Mount_Mode:
                    //new Joy_Mount_Mode((string)cmb.Tag).ShowDialog();
                    break;
                case buttonfunction.Do_Repeat_Relay:
                    //new Joy_Do_Repeat_Relay((string)cmb.Tag).ShowDialog();
                    break;
                case buttonfunction.Do_Repeat_Servo:
                    //new Joy_Do_Repeat_Servo((string)cmb.Tag).ShowDialog();
                    break;
                case buttonfunction.Do_Set_Relay:
                    //new Joy_Do_Set_Relay((string)cmb.Tag).ShowDialog();
                    break;
                case buttonfunction.Do_Set_Servo:
                    //new Joy_Do_Set_Servo((string)cmb.Tag).ShowDialog();
                    break;
                case buttonfunction.Button_axis0:
                    //new Joy_Button_axis((string)cmb.Tag).ShowDialog();
                    break;
                case buttonfunction.Button_axis1:
                    //new Joy_Button_axis((string)cmb.Tag).ShowDialog();
                    break;
                default:
                    MessageBox.Show("No settings to set", "No settings");
                    break;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // when under doing calibration.
            if (IsStart)
            {
                // stop calibration timer
                this.TimerCalibration.Stop();

                IsStart = false;
                this.ButtonStart.Text = "Start";
                // set data.

                int i = 1;
                foreach(DualTrackBar bar in this.DualTrackbars)
                {
                    string rc_min = $"RC{i}_MIN";
                    InterfaceController.Instance.GetCurrentVehicle().SetParameter(rc_min, bar.MinValue);
                    this.Mins.Add(rc_min, InterfaceController.Instance.GetParameter(rc_min));

                    string rc_max = $"RC{i}_MAX";
                    InterfaceController.Instance.GetCurrentVehicle().SetParameter(rc_max, bar.MaxValue);
                    this.Maxs.Add(rc_max, InterfaceController.Instance.GetParameter(rc_max));

                    i++;
                }

                StringBuilder sb = new StringBuilder();
                foreach(var v in this.Mins.Zip(this.Maxs, Tuple.Create))
                {
                    sb.AppendLine($"{v.Item1.Key} : {v.Item1.Value} - {v.Item2.Key} : {v.Item2.Value}");
                }
                MessageBox.Show(sb.ToString());

                return;
            }

            /*BOB - 20251218 - Commented to test
            if (!this.ReadRadioParameters())
            {
                // TODO : parameter is not ready.
                return;
            }
            /*EOB - 20251218 - Commented to test
            */

            this.Mins = new Dictionary<string, float>();
            this.Maxs = new Dictionary<string, float>();
            this.InitUI_UcCalibration_Radio_TrackBars();
            IsStart = true;
            
            this.ButtonStart.Text = "Complete";

            //BOB - 20251218 - Commented to test
            // get data stream.
            // enforcing
            InterfaceController.Instance.GetCurrentVehicle().SetDataStream(5, (byte)CrdsModel.Mavlink.MavEnums.MAV_DATA_STREAM.MAV_DATA_STREAM_RC_CHANNELS);
            //EOB - 20251218 - Commented to test
            //

            this.TimerCalibration.Start();
        }

        #endregion

        private void ButtonFLTSet_Click(object sender, EventArgs e)
        {
            if(this.FlightModeChannel == 0)
            {
                return;
            }

            int i = 1;
            foreach(System.Windows.Forms.ComboBox combo in this.Combos)
            {
                try
                {
                    byte v = Convert.ToByte(combo.SelectedValue);
                    InterfaceController.Instance.GetCurrentVehicle().SetParameter($"FLTMODE{i++}", v);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (CrdsGS.joystick == null || CrdsGS.joystick.enabled == false)
            {
                try
                {
                    if (CrdsGS.joystick != null)
                        CrdsGS.joystick.UnAcquireJoyStick();
                }
                catch
                {
                }

                // all config is loaded from the xmls
                var joy = JoystickBase.Create();

                joy.elevons = false; // CHK_elevons.Checked;

                //show error message if a joystick is not connected when Enable is clicked
                if (!joy.start(cmbJoysticks.Text))
                {
                    MessageBox.Show("Please Connect a Joystick", "No Joystick");
                    joy.Dispose();
                    return;
                }

                //Settings.Instance["joystick_name"] = CMB_joysticks.Text;

                CrdsGS.joystick = joy;
                CrdsGS.joystick.enabled = true;
                //Console.WriteLine("Now joystick is enabled."); //20260119 - test code

                //BOB - 20260126 - Commented to test
                // get data stream.
                // enforcing
                InterfaceController.Instance.GetCurrentVehicle().SetDataStream(5, (byte)CrdsModel.Mavlink.MavEnums.MAV_DATA_STREAM.MAV_DATA_STREAM_RC_CHANNELS);
                //EOB - 20260126 - Commented to test
                //

                btnEnable.Text = "Disable";

                //timerCalibration.Start();
            }
            else
            {
                CrdsGS.joystick.enabled = false;

                CrdsGS.joystick.clearRCOverride();

                //CrdsGS.joystick = null; //20260119 - test code


                TimerCalibration.Stop();

                btnEnable.Text = "Enable";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CrdsGS.joystick == null)
            {
                MessageBox.Show("Please select a joystick");
                return;
            }
            CrdsGS.joystick.saveconfig();

            Settings.Instance["joy_elevons"] = CHK_elevons.Checked.ToString();
        }

        private void ComboFlightMode1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
