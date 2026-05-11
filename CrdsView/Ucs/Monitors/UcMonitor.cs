using CrdsController.Controllers;
using CrdsModel.CommunicationPort;
using CrdsModel.Mavlink;
using CrdsView.Ucs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrdsView.Ucs.Monitors
{
    public partial class UcMonitor : UserControl, IUcTops, IUcTop
    {
        public UcMonitor()
        {
            InitializeComponent();
            //ucBasePosition.BackColor = Color.Transparent;
            //ucVehiclePosition.BackColor = Color.Transparent;

            
            /*
            if (label4.Image != null)
            {
                // 현재 이미지 가져오기
                Image originalImage = label4.Image;

                // 새로운 크기 설정 (예: 너비 100, 높이 50)
                Size newSize = new Size(label4.Width, label4.Height);

                // 새로운 크기의 이미지 생성 (가장 간단한 방법)
                Bitmap resizedBitmap = new Bitmap(originalImage, newSize); // 또는 new Bitmap(originalImage).GetThumbnailImage(newSize.Width, newSize.Height, null, IntPtr.Zero).ToBitmap();

                // 라벨에 새로운 이미지 할당
                label4.Image = resizedBitmap;

                // 원본 Image 객체 Dispose 해야 할 수 있음 (메모리 관리)
                originalImage.Dispose(); // 필요에 따라 주석 해제
            }
            if (label5.Image != null)
            {
                // 현재 이미지 가져오기
                Image originalImage = label5.Image;

                // 새로운 크기 설정 (예: 너비 100, 높이 50)
                Size newSize = new Size(label5.Width, label5.Height);

                // 새로운 크기의 이미지 생성 (가장 간단한 방법)
                Bitmap resizedBitmap = new Bitmap(originalImage, newSize); // 또는 new Bitmap(originalImage).GetThumbnailImage(newSize.Width, newSize.Height, null, IntPtr.Zero).ToBitmap();

                // 라벨에 새로운 이미지 할당
                label5.Image = resizedBitmap;

                // 원본 Image 객체 Dispose 해야 할 수 있음 (메모리 관리)
                originalImage.Dispose(); // 필요에 따라 주석 해제
            }
            */
        }

        protected Panel PanelMap { get; private set; }
        protected UcMonitorMap UcMonitorMap { get; private set; }
        protected UcHud UcHud { get; private set; }

        protected bool bUcSearchLight_Visible = true;
        protected bool bUcCameraControl_Visible = false;
        protected bool bUcSpeakerControl_Visible = true;
        protected bool bUcCctvControl_Visible = false;
        protected bool bUcParachuteControl_Visible = false;
        protected bool bUcVirtualJoystickControl_Visible = false;

        

        public UcMonitorMap GetUcMonitorMap()
        {
            return this.UcMonitorMap;
        }

        // TODO 
        public void Track()
        {
            MonitorController.Instance.SetMonitoringDataStream();

            this.UcMonitorMap.Track();
            this.UcHud.Track();
        }
        // TODO 
        public void UnTrack()
        {
            this.UcMonitorMap.UnTrack();
            this.UcHud.UnTrack();
        }

        #region Init UI
        /// <summary>
        /// setting for buttons
        /// </summary>
        private void InitUI_UcMonitor_Buttons()
        {
            List<System.Windows.Forms.Button> buttons = new List<System.Windows.Forms.Button>()
            {
                this.ButtonArm, this.ButtonTakeOff, this.ButtonTargetFollow, this.ButtonLand, this.ButtonAltHold,
            };

            foreach(System.Windows.Forms.Button button in buttons)
            {

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 4;
                button.Visible = true; //20260123 - added

                //if((button == this.ButtonTakeOff) || (button == this.ButtonTargetFollow))
                //    button.FlatAppearance.BorderColor = Color.Aqua; // .FromArgb(0, 255, 255, 255);
                //else
                    button.FlatAppearance.BorderColor = Color.DarkGoldenrod; // .FromArgb(0, 255, 255, 255);
            }
        }

        protected UcCommandTest UcCommand { get; set; }
        protected bool IsCommandVIsible { get; set; } = true; //false;

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, Keys keyData)
        {
            if (keyData.Equals(Keys.F3))
            {
                if(this.UcCommand is null)
                {
                    this.UcCommand = new UcCommandTest()
                    {
                        Height = 300,
                        Dock = DockStyle.Bottom,
                    };
                }

                if (IsCommandVIsible)
                {
                    this.Controls.Remove(this.UcCommand);
                }
                else
                {
                    this.Controls.Add(this.UcCommand);
                }
                this.IsCommandVIsible = !this.IsCommandVIsible;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// setting for panels
        /// </summary>
        private void InitUI_UcMonitor_Panels()
        {
            // Panel Map
            this.PanelMap = new Panel();
            this.PanelMap.Dock = DockStyle.Fill;
            this.Controls.Add(this.PanelMap);
            this.UcMonitorMap = new UcMonitorMap()
            {
                Dock = DockStyle.Fill
            };
            this.PanelMap.Controls.Add(this.UcMonitorMap);
            //BOB - 20250921 - inserted to test vehicle pos update
            this.UcMonitorMap.VehiclePosChanged += UcMonitorMap_VehiclePosChanged;

            // Huds
            this.UcHud = new UcHud()
            {
                Dock = DockStyle.Fill
            };
            this.LabelHud.Controls.Add(this.UcHud);
            this.LabelHud.Text = "";
            this.UcMonitorMap.SetBottomHud(this.LabelHud);

            //this.LabelHud.Location = new Point(this.Width / 2 - this.LabelHud.Width / 2, this.Height - this.LabelHud.Height - 10);
            this.LabelHud.Location = new Point(this.Width / 2 - this.LabelHud.Width, this.Height - this.LabelHud.Height - 10);
            this.UcHud.HudHidedEvent += UcHud_HudHidedEvent;
            this.UcHud.Visible = false;

            // Flight plan
            this.LabelFlightPlan.Visible = true;
            Point newPoint = new Point(this.Location.X + this.Size.Width, this.LabelFlightPlan.Location.Y);
            this.LabelFlightPlan.Location = newPoint;

            // Flight plan invoking label
            this.LabelPlanTab.Text = "P\nL\nA\nN";
            this.LabelPlanTab.Visible = true;

        }

        private void UcHud_HudHidedEvent(object sender, EventArgs e)
        {
            this.lblHudShow.Visible = true;
        }

        private void UcMonitorMap_VehiclePosChanged(object sender, VehiclePosEventArgs e)
        {
            //this.ucVehiclePosition.tbLat.Text = e.Latitude.ToString();
            //this.ucVehiclePosition.tbLon.Text = e.Longitude.ToString();
            //this.ucVehiclePosition.tbAlt.Text = "150.0";
        }

        /// <summary>
        /// Init ui for all.
        /// </summary>
        private void InitUI_UcMonitor()
        {

            this.InitUI_UcMonitor_Buttons();
            
            this.InitUI_UcMonitor_Panels();
        }

        #endregion

        #region Events
        
        private void UcMonitor_Load(object sender, EventArgs e)
        {
            this.InitUI_UcMonitor();
        }
        #endregion

        public void SetTops(List<Control> controls)
        {
            int mapIndex = ConfigController.Instance.GetCustomMapIndex();
            this.UcMonitorMap.SetMapProvider(mapIndex);
            this.GetUcMonitorMap().SetTops(controls);
            
            //string custom_url = ConfigController.Instance.GetCustomMapUrl();
            //this.UcMonitorMap.SetMapServerCustomUrl(custom_url);
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
           // MessageBox.Show(custom_url); //20240905-test

            EnableDoubleBuffering(this.flowLayoutPanel1);

            this.GetUcMonitorMap().SetTop(this.flowLayoutPanel1);
        }

        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        public void SetTop(Control control)
        {
            this.GetUcMonitorMap().SetTop(control);
        }

        private void ButtonArm_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                return;
            }

            FormInputText f = new FormInputText(InputType.ALT);
            f.TopMost = true;
            // 메인폼 위에 위치

            // 메인폼 가운데 위치
            f.StartPosition = FormStartPosition.Manual;


            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (f.Value == null)
            {
                // invalid value.
                MessageBox.Show("Invalid value");
                return;
            }

            float alt = (float)f.Value;

            if (!InterfaceController.Instance.GetCurrentVehicle().IsArmed)
            {
                // set mode to stabilize for arming.
                var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_STABILIZE);

                bool arm = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(400, 1, 21196, 0, 0, 0, 0, 0);
            }

            // set mode to guided for take off.
            var guided = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_GUIDED);

            bool r = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(22, 0, 0, 0, 0, 0, 0, alt);
        }
        private void ButtonTakeOff_Click(object sender, EventArgs e)
        {
            //BOB - 20260402 - inserted for debugging take off command
            Console.WriteLine("Take off button clicked");
            //EOB - 20260402 - inserted for debugging take off command
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                //BOB - 20260402 - inserted for debugging take off command
                Console.WriteLine("Take off - Error: no vehicles");
                //EOB - 20260402 - inserted for debugging take off command
                return;
            }

            FormInputText f = new FormInputText(InputType.ALT);

            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (f.Value == null)
            {
                // invalid value.
                MessageBox.Show("Invalid value");
                return;
            }

            float alt = (float)f.Value;

            if (!InterfaceController.Instance.GetCurrentVehicle().IsArmed)
            {
                // set mode to stabilize for arming.
                var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_STABILIZE);

                bool arm = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(400, 1, 21196, 0, 0, 0, 0, 0);
            }

            // set mode to guided for take off.
            var guided = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_GUIDED);

            bool r = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(22, 0, 0, 0, 0, 0, 0, alt);
        }
        private void ButtonTargetFollow_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                return;
            }

            FormInputText f = new FormInputText(InputType.ALT);

            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (f.Value == null)
            {
                // invalid value.
                MessageBox.Show("Invalid value");
                return;
            }

            float alt = (float)f.Value;

            if (!InterfaceController.Instance.GetCurrentVehicle().IsArmed)
            {
                // set mode to stabilize for arming.
                var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_STABILIZE);

                bool arm = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(400, 1, 21196, 0, 0, 0, 0, 0);
            }

            // set mode to guided for take off.
            var guided = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_GUIDED);

            bool r = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(22, 0, 0, 0, 0, 0, 0, alt);
        }

        private void ButtonLand_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                return;
            }

            // set mode to LAND for landing
            var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_LAND);

            float lat = (float)InterfaceController.Instance.GetCurrentVehicle().Latitude;
            float lon = (float)InterfaceController.Instance.GetCurrentVehicle().Longitude;
            float alt = 0;

            bool r = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(21, 0, 0, 0, 0, lat, lon, alt);
        }

        private void ucCameraControl1_Load(object sender, EventArgs e)
        {

        }

        private void UcMonitor_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void ButtonDisArm_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAltHold_Click(object sender, EventArgs e)
        {

        }

        private void lblHudShow_Click(object sender, EventArgs e)
        {
            this.lblHudShow.Visible = false;
            this.UcHud.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        /*  FOR GCS TEST BY YONGBEEAT 20260506 */

        private void btn_Stabilizer_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                return;
            }

            var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_STABILIZE);
        }

        private void btn_Hold_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                return;
            }

            var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_ALT_HOLD);
        }

        private void btn_Arm_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                return;
            }

            // set mode to stabilize for arming.
            var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_STABILIZE);
            bool arm = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(400, 1, 21196, 0, 0, 0, 0, 0);
        }

        private void btn_DisArm_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                return;
            }

            // set mode to stabilize for arming.
            var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_STABILIZE);
            bool arm = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(400, 0, 21196, 0, 0, 0, 0, 0);
        }

        private void btn_TakeOff_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                Console.WriteLine("Take off - Error: no vehicles");
                return;
            }

            if (!InterfaceController.Instance.GetCurrentVehicle().IsArmed)
            {
                // set mode to stabilize for arming.
                var mode = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_STABILIZE);

                bool arm = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(400, 1, 21196, 0, 0, 0, 0, 0);
            }

            // set mode to guided for take off.
            var guided = InterfaceController.Instance.GetCurrentVehicle().SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_GUIDED);

            bool r = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(22, 0, 0, 0, 0, 0, 0, 5.0f);
        }

        private void btn_Altitude_Click(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() is null)
            {
                Console.WriteLine("Take off - Error: no vehicles");
                return;

            }
            float lat = (float)InterfaceController.Instance.GetCurrentVehicle().Latitude;
            float lon = (float)InterfaceController.Instance.GetCurrentVehicle().Longitude;
            float alt = float.Parse(tb_Altitude.Text);

            bool r = InterfaceController.Instance.GetCurrentVehicle().SendCommandLong(192, -1.0f, 0, 0, float.NaN, lat, lon, alt);
        }

        private void btn_Land_Click(object sender, EventArgs e)
        {
            // 1. 기기 연결 확인
            var vehicle = InterfaceController.Instance.GetCurrentVehicle();
            if (vehicle is null)
            {
                Console.WriteLine("Land - Error: no vehicles");
                return;
            }

            // 2. 착륙 모드(LAND)로 변경
            // ArduPilot Copter에서 LAND 모드는 기체가 현재 위치에서 수직으로 하강하여 착륙하게 합니다.
            var mode = vehicle.SetCopterMode(CrdsModel.Mavlink.Ardupilotmega.MavEnums.COPTER_MODE.COPTER_MODE_LAND);

            // 3. (옵션) 직접 LAND 명령을 날리고 싶은 경우 아래 코드 사용 (ID: 21)
            // bool r = vehicle.SendCommandLong(21, 0, 0, 0, 0, 0, 0, 0); 
        }

        private bool _isFollowEnabled = false; // param1 제어용 (0 또는 1)
        private CancellationTokenSource _loopCts; // 스레드 종료 제어용

        private void btn_NoCon_Click(object sender, EventArgs e)
        {
            // 1. 값 토글 (ON <-> OFF)
            _isFollowEnabled = false;

            // UI 버튼 텍스트 변경 (옵션)
            //btn_NoCon.Text = "추종 중지";
            btn_NoCon.BackColor = _isFollowEnabled ? Color.LightGreen : Color.Transparent;

            // 2. 루프가 실행 중이 아니라면 스레드 시작
            if (_isFollowEnabled && (_loopCts == null || _loopCts.IsCancellationRequested))
            {
                float p1  = 0f;
                float lat = (float)InterfaceController.Instance.GetCurrentVehicle().Latitude;
                float lon = (float)InterfaceController.Instance.GetCurrentVehicle().Longitude;
                float alt = 10.0f;

                StartCommandLoop(p1, lat, lon, alt);
            }
        }

        private void btn_AP1_Click(object sender, EventArgs e)
        {
            // 1. 값 토글 (ON <-> OFF)
            _isFollowEnabled = true;

            // UI 버튼 텍스트 변경 (옵션)
            //btn_NoCon.Text = "추종 중...";
            btn_NoCon.BackColor = _isFollowEnabled ? Color.LightGreen : Color.Transparent;

            // 2. 루프가 실행 중이 아니라면 스레드 시작
            if (_isFollowEnabled && (_loopCts == null || _loopCts.IsCancellationRequested))
            {
                float p1 = 1.0f;
                float lat = (float)37.5646167;      // 인천드론시험장 중앙값
                float lon = (float)126.6256917;
                float alt = 10.0f;

                StartCommandLoop(p1, lat, lon, alt);
            }
        }

        private void btn_AP2_Click(object sender, EventArgs e)
        {
            // 1. 값 토글 (ON <-> OFF)
            _isFollowEnabled = true;

            // UI 버튼 텍스트 변경 (옵션)
            //btn_NoCon.Text = "추종 중...";
            btn_NoCon.BackColor = _isFollowEnabled ? Color.LightGreen : Color.Transparent;

            // 2. 루프가 실행 중이 아니라면 스레드 시작
            if (_isFollowEnabled && (_loopCts == null || _loopCts.IsCancellationRequested))
            {
                float p1 = 1.0f;
                float lat = (float)37.5646167;
                float lon = (float)126.6256917;
                float alt = 10.0f;

                StartCommandLoop(p1, lat, lon, alt);
            }
        }

        private void btn_AP3_Click(object sender, EventArgs e)
        {
            // 1. 값 토글 (ON <-> OFF)
            _isFollowEnabled = true;

            // UI 버튼 텍스트 변경 (옵션)
            //btn_NoCon.Text = "추종 중...";
            btn_NoCon.BackColor = _isFollowEnabled ? Color.LightGreen : Color.Transparent;

            // 2. 루프가 실행 중이 아니라면 스레드 시작
            if (_isFollowEnabled && (_loopCts == null || _loopCts.IsCancellationRequested))
            {
                float p1 = 1.0f;
                float lat = (float)37.5646167;
                float lon = (float)126.6256917;
                float alt = 10.0f;

                StartCommandLoop(p1, lat, lon, alt);
            }
        }

        private void btn_AP4_Click(object sender, EventArgs e)
        {

        }

        private void StartCommandLoop(float pa1, float Latitude, float Longitude, float Altitude)
        {
            _loopCts = new CancellationTokenSource();
            var token = _loopCts.Token;

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    var vehicle = InterfaceController.Instance.GetCurrentVehicle();
                    if (vehicle != null)
                    {
                        // 이미지 사양에 따른 파라미터 매핑
                        float p1 = pa1;
                        float lat = Latitude;       // param2
                        float lon = Longitude;      // param3
                        float alt = Altitude;       // param4 (필요 시 tb_Altitude.Text에서 가져옴)

                        // MAV_CMD_USER_1 (31010) 전송
                        // 파라미터 순서: commandID, p1, p2, p3, p4, p5, p6, p7
                        vehicle.SendCommandLong(31010, p1, lat, lon, alt, 0, 0, 0);
                    }

                    // 2Hz 주기를 위해 500ms 대기 (1000ms / 2 = 500ms)
                    await Task.Delay(500, token);
                }
            }, token);

        }

    }
}
