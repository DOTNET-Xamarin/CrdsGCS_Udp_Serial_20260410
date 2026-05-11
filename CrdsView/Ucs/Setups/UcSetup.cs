using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CrdsView.Ucs.Setups.Calibrations;
using CrdsView.Ucs.Common;

namespace CrdsView.Ucs.Setups
{
    public enum SETUPSTEP
    {
        INSTALLFIRMWARE = 0,
        CALIBRATION = 1,
    }

    public partial class UcSetup : UserControl, IUcTops, IUcTop
    {
        public UcSetup()
        {
            InitializeComponent();
        }

        protected SETUPSTEP SetupSetp { get; set; }

        private void InitUI_UcSetup()
        {
            // add event to buttons.
            this.ButtonFirmwareInstall.Click += this.Buttons_Click;
            this.ButtonCalibration.Click += this.Buttons_Click;

            // invoke init ui -> Install Firmware.
            this.Buttons_Click(null, null);

        }

        public void SetTops(List<Control> controls)
        {
            foreach(Control c in controls)
            {
                if (!this.PanelTop.Controls.Contains(c))
                {
                    this.PanelTop.Controls.Add(c);
                }
            }
        }

        public void SetTop(Control control)
        {
            if (this.PanelTop.Controls.Contains(control)) return;
            this.PanelTop.Controls.Add(control);
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            string buttonName;
            try
            {
                if (sender is null)
                {
                    throw new Exception("sender is null");
                }
                buttonName = (sender as Button).Text.Replace(" ", "");
                string lower = this.SetupSetp.ToString().ToLower();
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
                case "InstallFirmware":
                    this.SetupSetp = SETUPSTEP.INSTALLFIRMWARE;
                    this.PanelAction.Controls.Clear();
                    this.PanelAction.Controls.Add(new UcFirmwareInstall()
                    {
                        Dock = DockStyle.Fill
                    });
                    break;
                case "Calibration":
                    this.SetupSetp = SETUPSTEP.CALIBRATION;
                    this.PanelAction.Controls.Clear();
                    this.PanelAction.Controls.Add(new UcCalibration()
                    {
                        Dock = DockStyle.Fill
                    });
                    break;
                default:
                    this.SetupSetp = SETUPSTEP.INSTALLFIRMWARE;
                    this.PanelAction.Controls.Clear();
                    this.PanelAction.Controls.Add(new UcFirmwareInstall()
                    {
                        Dock = DockStyle.Fill
                    });
                    break;
            }
        }


        private void UcSetup_Load(object sender, EventArgs e)
        {
            this.InitUI_UcSetup();
        }

       
    }
}
