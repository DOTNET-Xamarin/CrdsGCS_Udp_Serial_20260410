using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CrdsController.Controllers;
using System.Runtime.CompilerServices;
using MyControl;

namespace CrdsView.Ucs.Monitors
{
    public partial class UcHud : UserControl
    {
        public event EventHandler HudHidedEvent;
        public UcHud()
        {
            InitializeComponent();
        }

        protected Timer Timer { get; set; }

        protected MyTabCon attitudeControl1 { get; set; }

        public void Track()
        {
            this.Timer.Start();

        }

        public void UnTrack()
        {
            this.Timer.Stop();
        }

        #region Init UI

        private void InitUI_UcHud_Timer()
        {
            this.Timer = new Timer();
            this.Timer.Interval = 250;
            this.Timer.Tick += Timer_Tick;
        }

        private void InitUI_UcHud_Label()
        {
            this.attitudeControl1 = new MyTabCon();
            {
                Dock = DockStyle.Fill;
            };

            this.Controls.Add(this.attitudeControl1);
            this.attitudeControl1.MouseDoubleClick += AttitudeControl1_MouseDoubleClick;
        }

        private void AttitudeControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("attitudeControl1 of UcHud mouse double clicked!");
            this.Visible = false;
            HudHidedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void InitUI_UcHud()
        {
            this.InitUI_UcHud_Timer();

            this.InitUI_UcHud_Label();
        }

        #endregion

        #region Events

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invoke((Action)delegate
            {
                if (InterfaceController.Instance.GetCurrentVehicle() == null)
                {
                    // not connected.
                    Console.WriteLine("No vehicle is connected yet!");

                    return;
                }

                attitudeControl1.Set_Yaw((int)InterfaceController.Instance.GetCurrentVehicle().yaw);
                attitudeControl1.Set_Pitch((int)InterfaceController.Instance.GetCurrentVehicle().pitch);
                attitudeControl1.Set_Roll((int)InterfaceController.Instance.GetCurrentVehicle().roll);
                attitudeControl1.SetAlt((int)InterfaceController.Instance.GetCurrentVehicle().VFR_HUD_Alt);
            });
        }

        private void UcHud__Load(object sender, EventArgs e)
        {
            this.InitUI_UcHud();
        }

        #endregion

        private void UcHud__Resize(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

            if(this.attitudeControl1 != null) 
                this.attitudeControl1.Size = new Size(width, height);
        }

        private void UcHud_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("LabelHud mouse double clicked!");
        }
    }
}
