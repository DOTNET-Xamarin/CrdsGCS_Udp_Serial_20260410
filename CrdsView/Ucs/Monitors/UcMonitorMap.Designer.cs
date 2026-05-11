namespace CrdsView.Ucs.Monitors
{
    partial class UcMonitorMap
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.wrapperPanel = new System.Windows.Forms.Panel();
            this.ucMainTabControl1 = new CrdsView.Ucs.Monitors.UcMainTabControl();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.timerSlide2 = new System.Windows.Forms.Timer(this.components);
            this.wrapperPanel2 = new System.Windows.Forms.Panel();
            this.ucStatusTabControl1 = new CrdsView.Ucs.Monitors.UcStatusTabControl();
            this.wrapperPanel.SuspendLayout();
            this.wrapperPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(0, 0);
            this.gMapControl.Margin = new System.Windows.Forms.Padding(5);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(1149, 662);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseMove);
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.Controls.Add(this.ucMainTabControl1);
            this.wrapperPanel.Location = new System.Drawing.Point(0, 457);
            this.wrapperPanel.Margin = new System.Windows.Forms.Padding(0);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Size = new System.Drawing.Size(860, 205);
            this.wrapperPanel.TabIndex = 2;
            // 
            // ucMainTabControl1
            // 
            this.ucMainTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainTabControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucMainTabControl1.Location = new System.Drawing.Point(0, 0);
            this.ucMainTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.ucMainTabControl1.Name = "ucMainTabControl1";
            this.ucMainTabControl1.Size = new System.Drawing.Size(860, 205);
            this.ucMainTabControl1.TabIndex = 1;
            // 
            // wrapperPanel2
            // 
            this.wrapperPanel2.Controls.Add(this.ucStatusTabControl1);
            this.wrapperPanel2.Location = new System.Drawing.Point(558, 65);
            this.wrapperPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.wrapperPanel2.Name = "wrapperPanel2";
            this.wrapperPanel2.Size = new System.Drawing.Size(591, 480);
            this.wrapperPanel2.TabIndex = 4;
            // 
            // ucStatusTabControl1
            // 
            this.ucStatusTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ucStatusTabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucStatusTabControl1.Location = new System.Drawing.Point(4, 5);
            this.ucStatusTabControl1.MainMotorPower = 0F;
            this.ucStatusTabControl1.MainMotorRpm = 0F;
            this.ucStatusTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.ucStatusTabControl1.MaximumSize = new System.Drawing.Size(586, 474);
            this.ucStatusTabControl1.MinimumSize = new System.Drawing.Size(586, 474);
            this.ucStatusTabControl1.Name = "ucStatusTabControl1";
            this.ucStatusTabControl1.Size = new System.Drawing.Size(586, 474);
            this.ucStatusTabControl1.TabIndex = 3;
            // 
            // UcMonitorMap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.wrapperPanel);
            this.Controls.Add(this.wrapperPanel2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UcMonitorMap";
            this.Size = new System.Drawing.Size(1149, 662);
            this.Load += new System.EventHandler(this.UcMap_Load);
            this.wrapperPanel.ResumeLayout(false);
            this.wrapperPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private UcMainTabControl ucMainTabControl1;
        private System.Windows.Forms.Panel wrapperPanel;
        private System.Windows.Forms.Timer timerSlide;
        private UcStatusTabControl ucStatusTabControl1;
        private System.Windows.Forms.Timer timerSlide2;
        private System.Windows.Forms.Panel wrapperPanel2;
    }
}