using CrdsController.Controllers;
using CrdsModel.CommunicationPort;
using CrdsModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrdsView.Ucs.Common
{
    public partial class FormConnection : Form
    {
        private List<string> portNames = new List<string>()
        {
            "AUTO", "TCP", "UDP",
        };

        private List<string> baudrates = new List<string>()
        {
            "4800", "9600", "19200", "38400", "57600", "115200", "460800", "921600", "1500000"
        };

        protected ListUserControl ListUserControl { get; set; }

        public FormConnection()
        {
            InitializeComponent();
        }

        #region Init UI
        private void Init_FormConnection_Comboboxes()
        {
            this.ComboComPort.Items.Clear();
            this.ComboComPort.Items.AddRange(portNames.ToArray());
            List<string> devices = ComPort.GetDevicePorts(true);
            this.ComboComPort.Items.AddRange(devices.ToArray());

            this.ComboBaudrates.Items.Clear();
            this.ComboBaudrates.Items.AddRange(this.baudrates.ToArray());
        }

        private void Init_FormConnection_Connected()
        {
            this.ListUserControl = new ListUserControl()
            {
                Dock = DockStyle.Fill,
            };
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(this.ListUserControl);
            
            List<Tuple<int, int, string, string>> list = InterfaceController.Instance.GetConnectedList();
            //list = new List<Tuple<int, int, string>>();
            //list.Add(new Tuple<int, int, string>(10, 10, "Ardupilot"));
            //list.Add(new Tuple<int, int, string>(15, 15, "PX4"));
            //list.Add(new Tuple<int, int, string>(20, 20, "ARdupilot Copter dfasdfasdfasdfasfdasdfsdfasdfsd"));
            //list.Add(new Tuple<int, int, string>(20, 20, "ARdupilot Copter"));
            //list.Add(new Tuple<int, int, string>(20, 20, "ARdupilot Copter"));


            if (list == null)
            {
                return;
            }

            foreach (Tuple<int, int, string, string> item in list)
            {
                int sys = item.Item1;
                int comp = item.Item2;
                string auto = item.Item3;
                string type = item.Item4;
                this.ListUserControl.AddUserControl(new UcConnectedVehicle(sys, comp, auto, type));
            }
        }

        private void InitUI_FormConnection()
        {
            this.Init_FormConnection_Comboboxes();
            this.Init_FormConnection_Connected();

        }
        #endregion
        #region Events
        private void FormConnection_Load(object sender, EventArgs e)
        {
            this.InitUI_FormConnection();
            this.Visible = true;
        }

        private void ComboComPort_MouseClick(object sender, MouseEventArgs e)
        {
            this.Init_FormConnection_Comboboxes();
        }

        /// <summary>
        /// Connect Button Click Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string portName = ComboComPort.Text == null ? string.Empty : ComboComPort.Text.Trim();
                string baudText = ComboBaudrates.Text == null ? string.Empty : ComboBaudrates.Text.Trim();

                if (string.IsNullOrEmpty(portName))
                {
                    MessageBox.Show("Please select a port.");
                    return;
                }

                if (portName.Equals("AUTO", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("AUTO connection is not implemented yet.");
                    return;
                }

                if (portName.Equals("TCP", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("TCP connection is not implemented yet.");
                    return;
                }

                int baudrate = 57600;

                // UDP는 내부 입력창에서 listen port를 받으므로 baudrate는 실질적으로 사용되지 않음
                if (!portName.Equals("UDP", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(baudText, out baudrate))
                    {
                        MessageBox.Show("Invalid baudrate.");
                        return;
                    }
                }

                bool result = InterfaceController.Instance
                    .GetInterface()
                    .ConnectUAV(portName, baudrate);

                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connection failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DisConnect Button Click Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDisConnect_Click(object sender, EventArgs e)
        {

            int index = this.ListUserControl.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("please select connected vehicle");
                return;
            }

            var uc = (UcConnectedVehicle)this.ListUserControl.GetUc(index);
            int sys = uc.SystemId;
            int comp = uc.ComponentId;

            InterfaceController.Instance.GetInterface().DisConnectUAV(sys, comp);
            this.Init_FormConnection_Connected();
        }
        #endregion

    }
        
}
