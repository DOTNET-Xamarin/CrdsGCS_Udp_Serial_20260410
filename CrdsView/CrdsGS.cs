using CrdsController.Controllers;
using CrdsModel.CommunicationPort;
using CrdsModel.Mavlink;
using CrdsView.Ucs.Common;
using CrdsView.Ucs.Configs;
using CrdsView.Ucs.Monitors;
using CrdsView.Ucs.Setups;
using CrdsView.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrdsView
{
    public enum VIEWSTATE
    {
        MONITOR = 0,
        SETUP = 1,
        CONFIG = 2,
    }

    /// <summary>
    /// Main form
    /// </summary>
    public partial class CrdsGS : Form
    {
        public CrdsGS()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // create one here - but override on load
            Settings.Instance["guid"] = Guid.NewGuid().ToString();

            //Check for -config argument, and if it is an xml extension filename then use that for config
            //if (Program.args.Length > 0 && Program.args.Contains("-config"))
            //{
            //    var cmds = ProcessCommandLine(Program
            //        .args); //This will be called later as well, but we need it here and now
            //    if (cmds.ContainsKey("config") &&
            //        (cmds["config"] != null) &&
            //        (String.Compare(Path.GetExtension(cmds["config"]), ".xml", true) == 0))
            //    {
            //        Settings.FileName = cmds["config"];
            //    }
            //}

            // load config
            LoadConfig();

            InitializeComponent();  
        }

        protected Dictionary<VIEWSTATE, UserControl> MainUcs { get; set; }
        //protected UcVehicleStatus UcVehicleStatus { get; set; }
        protected UcVehicleStatus_ UcVehicleStatus { get; set; }
        protected Panel MainPanel { get; set; }
        protected List<Control> Tops { get; set; }
        protected VIEWSTATE ViewState { get; set; }

        //BOB - 20260124 - Inserted to use available Joystick Controller
        /// <summary>
        /// joystick static class
        /// </summary>
        public static Joystick.JoystickBase joystick { get; set; }

        /// <summary>
        /// Comport name
        /// </summary>
        public static string comPortName = "";

        public static int comPortBaud = 115200;

        /// <summary>
        /// track last joystick packet sent. used to control rate
        /// </summary>
        DateTime lastjoystick = DateTime.UtcNow;

        bool joystickthreadrun = false;
        //EOB - 20260124 - Inserted to use available Joystick Controller

        private void SetMainPanel(VIEWSTATE viewstate)
        {
            try
            {
                this.MainPanel.Controls.Clear();
                this.MainPanel.Controls.Add(this.MainUcs[viewstate]);

                this.MainPanel.Dock = DockStyle.Fill;

                (this.MainUcs[viewstate] as IUcTops).SetTops(this.Tops);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        #region UI Control settings

        private void InitUI_CrdsGS_Labels()
        {
            string resource_path = Path.Combine(Application.StartupPath, "Resources");

            try
            {
                //Bitmap bitmap = new Bitmap(Path.Combine(resource_path, "Exens_Logo.png"));
                Bitmap bitmap = new Bitmap(Path.Combine(resource_path, "KAT_Logo.png"));

                Bitmap resize = new Bitmap(bitmap, this.LabelCrdsCI.Size);

                this.LabelCrdsCI.Image = resize;
                this.LabelCrdsCI.BackColor = Color.Transparent;
                this.LabelCrdsCI.ImageAlign = ContentAlignment.MiddleCenter;
            }
            catch (Exception e)
            {

                throw;
            }

            // Label vehicle status
            this.LabelVehicleStatus.Text = "";
            this.UcVehicleStatus = new UcVehicleStatus_() { Dock = DockStyle.Fill };
            this.LabelVehicleStatus.Controls.Add(this.UcVehicleStatus);
        }

        private void InitUI_CrdsGS_Buttons()
        {
            string resource_path = Path.Combine(Application.StartupPath, "Resources");

            List<Button> buttons = new List<Button>()
            {
                this.ButtonMonitor, this.ButtonSetup, this.ButtonConfig, this.ButtonConnection
            };
            List<string> imagename = new List<string>()
            {
                //"monitoring.png", "setup.png", "config.png", "network_disconnected.png", "OnOffButton_off.png"
                "monitoring.png", "setup.png", "config.png", "network_disconnected.png"
            };

            foreach (var val in buttons.Zip(imagename, Tuple.Create))
            {
                // load image
                Bitmap bitmap = new Bitmap(Path.Combine(resource_path, val.Item2));

                // adapt resized image.
                Button button = val.Item1;
                Bitmap resize = new Bitmap(bitmap, button.Size.Width, button.Size.Height);

                button.BackgroundImage = (Image)resize;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.ForeColor = Color.FromArgb(0, 255, 255, 255);
                button.BackColor = Color.FromArgb(0, 255, 255, 255);

                button.Click += this.ViewButtons_Click;

                // button set
                //button.BackColor = Color.Transparent;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

                // TODO : button -> round with OnPaint

                button.Update();
            }
        }

        private void InitUI_CrdsGS_Panels()
        {
            // main user control setting.
            this.MainUcs = new Dictionary<VIEWSTATE, UserControl>();
            this.MainUcs.Add(VIEWSTATE.MONITOR, new UcMonitor() { Dock = DockStyle.Fill });
            this.MainUcs.Add(VIEWSTATE.SETUP, new UcSetup() { Dock = DockStyle.Fill });
            this.MainUcs.Add(VIEWSTATE.CONFIG, new UcConfig() { Dock = DockStyle.Fill });

            // MainPanel
            this.MainPanel = new Panel();
            this.MainPanel.Dock = DockStyle.Fill;

            this.Controls.Add(this.MainPanel);
        }

        private void InitUI_CrdsGS()
        {
            this.Tops = new List<Control>()
            {
                this.LabelCrdsCI, this.ButtonMonitor, this.ButtonSetup, this.ButtonConfig, this.LabelVehicleStatus, this.ButtonConnection
            };

            this.InitUI_CrdsGS_Labels();

            this.InitUI_CrdsGS_Buttons();

            this.InitUI_CrdsGS_Panels();

            // init map.
            this.ViewButtons_Click(null, null);

        }

        #endregion

        #region Events

        /// <summary>
        /// Crds GS Main View Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrdsGS_Load(object sender, EventArgs e)
        {
            InitUI_CrdsGS();
            Console.WriteLine("start joystick");
            try
            {
                // setup joystick packet sender
                joysticksend();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Buttons Click events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewButtons_Click(object sender, EventArgs e)
        {
            string buttonName;
            try
            {
                if (sender is null)
                {
                    throw new Exception("sender is null");
                }
                buttonName = (sender as Button).Text;
                string lower = this.ViewState.ToString().ToLower();
                if (lower.Equals(buttonName.ToLower()))
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                buttonName = string.Empty;
            }

            switch (buttonName)
            {
                case "Monitor":
                    this.ViewState = VIEWSTATE.MONITOR;
                    break;
                case "Setup":
                    this.ViewState = VIEWSTATE.SETUP;
                    break;
                case "Config":
                    this.ViewState = VIEWSTATE.CONFIG;
                    break;
                default:
                    this.ViewState = VIEWSTATE.MONITOR;
                    break;
            }

            this.SetMainPanel(this.ViewState);
        }

        /// <summary>
        /// Connection buttons click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConnection_Click(object sender, EventArgs e)
        {
            FormConnection form = new FormConnection();
            form.TopMost = true;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowInTaskbar = false;
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                //this.UcVehicleStatus.Track();

                // TODO : Monitor
                UcMonitor ucMonitor = (UcMonitor)this.MainUcs[VIEWSTATE.MONITOR];
                ucMonitor.Track();
                
            }

        }
        #endregion

        private void CrdsGS_FormClosed(object sender, FormClosedEventArgs e)
        {
            // release resources.
            try
            {
                InterfaceController.Instance.GetInterface().Dispose();
                if (joystick != null)
                {
                    while (!joysendThreadExited)
                        Thread.Sleep(10);

                    joystick.Dispose(); //proper clean up of joystick.
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CrdsGS_FormClosing(object sender, FormClosingEventArgs e)
        {
            joystickthreadrun = false;
        }

        private void LoadConfig()
        {
            try
            {
                //log.Info("Loading config");

                Settings.Instance.Load();

                comPortName = Settings.Instance.ComPort;
            }
            catch (Exception ex)
            {
                //log.Error("Bad Config File", ex);
            }
        }

        private void SaveConfig()
        {
            try
            {
                //log.Info("Saving config");
                Settings.Instance.ComPort = comPortName;

                Settings.Instance.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// needs to be true by default so that exits properly if no joystick used.
        /// </summary>
        volatile private bool joysendThreadExited = true;

        /// <summary>
        /// thread used to send joystick packets to the MAV
        /// </summary>
        private async void joysticksend()
        {
            float rate = 50; // 50; // 1000 / 50 = 20 hz
            int count = 0;

            DateTime lastratechange = DateTime.Now;

            joystickthreadrun = true;


            while (joystickthreadrun)
            {
                joysendThreadExited = false;
                //so we know this thread is stil alive.
                try
                {

                    //joystick stuff

                    if (joystick != null && joystick.enabled)
                    {
                        var iface = InterfaceController.Instance.GetInterface();
                        var vehicle = InterfaceController.Instance.GetCurrentVehicle();
                        var com = iface?.ComPort ?? vehicle?.PublicComPort;

                        if (!joystick.manual_control)
                        {
                            Message_RC_CHANNELS_OVERRIDE rc = new Message_RC_CHANNELS_OVERRIDE((ushort)vehicle.rcoverridech1, (ushort)vehicle.rcoverridech2,
                                (ushort)vehicle.rcoverridech3, (ushort)vehicle.rcoverridech4, (ushort)vehicle.rcoverridech5, (ushort)vehicle.rcoverridech6,
                                (ushort)vehicle.rcoverridech7, (ushort)vehicle.rcoverridech8, (byte)vehicle.SystemId, (byte)vehicle.ComponentId,
                                (ushort)vehicle.rcoverridech9, (ushort)vehicle.rcoverridech10, (ushort)vehicle.rcoverridech11, (ushort)vehicle.rcoverridech12,
                                (ushort)vehicle.rcoverridech13, (ushort)vehicle.rcoverridech14, (ushort)vehicle.rcoverridech15, (ushort)vehicle.rcoverridech16,
                                (ushort)vehicle.rcoverridech17, (ushort)vehicle.rcoverridech18);

                            if (lastjoystick.AddMilliseconds(rate) < DateTime.UtcNow)
                            {
                                if (!com.IsOpen)
                                {
                                    Console.WriteLine("Error - ComPort is not open!");
                                    continue;
                                }

                                if (com.BytesToWrite < 50)
                                {
                                    vehicle.SendMessage(rc);
                                    System.Threading.Thread.Sleep(10);

                                    count++;
                                    lastjoystick = DateTime.UtcNow;
                                }
                                else
                                {
                                    Console.WriteLine("ComPort.BytesToWrite >= 50.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("joystick.manual_control");
                            Message_MANUAL_CONTROL rc = new Message_MANUAL_CONTROL(vehicle.rcoverridech1, vehicle.rcoverridech2,
                                vehicle.rcoverridech3, vehicle.rcoverridech4, 0, (byte)vehicle.ComponentId, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                            if (lastjoystick.AddMilliseconds(rate) < DateTime.UtcNow)
                            {
                                if (!com.IsOpen)
                                {
                                    Console.WriteLine("Error - ComPort is not open!");
                                    continue;
                                }
                                if (com.BytesToWrite < 50)
                                {

                                    //comPort.sendPacket(rc, comPort.MAV.sysid, comPort.MAV.compid);
                                    vehicle.SendMessage(rc);
                                    Console.WriteLine("Manual Control - RC_OVERRIDE message was sent!");

                                    count++;
                                    lastjoystick = DateTime.UtcNow;
                                }
                            }
                        }
                    }

                    await Task.Delay(40).ConfigureAwait(false);
                }
                catch
                {
                } // cant fall out
            }

            joysendThreadExited = true; //so we know this thread exited.
        }
    }
}

