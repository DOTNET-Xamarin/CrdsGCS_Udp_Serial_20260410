using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CrdsView.Ucs.Monitors
{
    partial class UcMainTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMainTabControl));
            this.panelFrame = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.lblWinchDrumRpm = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTensionTarget = new System.Windows.Forms.Label();
            this.btnTensionDecrease = new System.Windows.Forms.Button();
            this.btnTensionIncrease = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCableRemained = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCableTension = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCableSpeed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCableReleased = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSeaState = new System.Windows.Forms.Label();
            this.lblSontrolOnOff = new System.Windows.Forms.Label();
            this.lblWowOnOff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAntiLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTensionControl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAutoLevelOnOff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWindUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWindOut = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.lblDrumTemperature = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblCableLossPower = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.lblCableLossCurrent = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.lblCableLossVoltage = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblAcDcInPower = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblAcDcInCurrent = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.lblAcDcInVoltage = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblAcDcOutPower = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblAcDcOutCurrent = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblAcDcOutVoltage = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblDcDcBInPower = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDcDcBInCurrent = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblDcDcBInVoltage = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblDcDcAInPower = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblDcDcAInCurrent = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblDcDcAInVoltage = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblDcDcBOutPower = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblDcDcBOutCurrent = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblDcDcBOutVoltage = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblDcDcAOutPower = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblDcDcAOutCurrent = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblDcDcAOutVoltage = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblComTimeout = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.lblComLatency = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.lblComHeartbeatCount = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.lblComStreamRate = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.lblComPacketLoss = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.lblGcsBytesReceived = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.lblGcsComBytesSent = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lblGcsComBaudrate = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.lblGcsComStatus = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.lblExtBytesReceived = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.lblExtComBytesSent = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.lblExtComBaudrate = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lblExtComStatus = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAltDown = new System.Windows.Forms.Button();
            this.btnAltUp = new System.Windows.Forms.Button();
            this.btnAutoReturn = new System.Windows.Forms.Button();
            this.btnHoverAt100m = new System.Windows.Forms.Button();
            this.btnAutoStart = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMotionSyncToDrone = new System.Windows.Forms.Button();
            this.btnMotionSyncToSea = new System.Windows.Forms.Button();
            this.btnMotionSyncToLand = new System.Windows.Forms.Button();
            this.label59 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnCLoseStation = new System.Windows.Forms.Button();
            this.btnLandAndStore = new System.Windows.Forms.Button();
            this.btnLandSync = new System.Windows.Forms.Button();
            this.btnStandbyLand = new System.Windows.Forms.Button();
            this.btnFollowShip = new System.Windows.Forms.Button();
            this.btnHovering = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnTakeOff = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStandby = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenStation = new System.Windows.Forms.Button();
            this.panelFrame.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFrame
            // 
            this.panelFrame.Controls.Add(this.tabControl1);
            this.panelFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrame.Location = new System.Drawing.Point(0, 0);
            this.panelFrame.Margin = new System.Windows.Forms.Padding(0);
            this.panelFrame.Padding = new System.Windows.Forms.Padding(0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelFrame.Size = new System.Drawing.Size(860, 200);
            this.panelFrame.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.ItemSize = new System.Drawing.Size(108, 32);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.Padding = new System.Drawing.Point(6, 3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 200);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.lblWinchDrumRpm);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.lblTensionTarget);
            this.tabPage1.Controls.Add(this.btnTensionDecrease);
            this.tabPage1.Controls.Add(this.btnTensionIncrease);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.lblCableRemained);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.lblCableTension);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lblCableSpeed);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblCableReleased);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblSeaState);
            this.tabPage1.Controls.Add(this.lblSontrolOnOff);
            this.tabPage1.Controls.Add(this.lblWowOnOff);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnAntiLoad);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnTensionControl);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnAutoLevelOnOff);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnWindUp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnWindOut);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(0);
            this.tabPage1.Size = new System.Drawing.Size(852, 156);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "윈치";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(1344, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 32);
            this.label19.TabIndex = 38;
            this.label19.Text = "RPM";
            // 
            // lblWinchDrumRpm
            // 
            this.lblWinchDrumRpm.BackColor = System.Drawing.Color.Wheat;
            this.lblWinchDrumRpm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinchDrumRpm.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblWinchDrumRpm.Location = new System.Drawing.Point(1201, 132);
            this.lblWinchDrumRpm.Name = "lblWinchDrumRpm";
            this.lblWinchDrumRpm.Size = new System.Drawing.Size(137, 35);
            this.lblWinchDrumRpm.TabIndex = 37;
            this.lblWinchDrumRpm.Text = "2";
            this.lblWinchDrumRpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(986, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(159, 32);
            this.label21.TabIndex = 36;
            this.label21.Text = "Winch Drum";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(1078, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 32);
            this.label17.TabIndex = 35;
            this.label17.Text = "N/m";
            // 
            // lblTensionTarget
            // 
            this.lblTensionTarget.BackColor = System.Drawing.Color.Wheat;
            this.lblTensionTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTensionTarget.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblTensionTarget.Location = new System.Drawing.Point(989, 90);
            this.lblTensionTarget.Name = "lblTensionTarget";
            this.lblTensionTarget.Size = new System.Drawing.Size(83, 35);
            this.lblTensionTarget.TabIndex = 34;
            this.lblTensionTarget.Text = "0.5";
            this.lblTensionTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTensionDecrease
            // 
            this.btnTensionDecrease.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnTensionDecrease.Location = new System.Drawing.Point(1267, 83);
            this.btnTensionDecrease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTensionDecrease.Name = "btnTensionDecrease";
            this.btnTensionDecrease.Size = new System.Drawing.Size(107, 38);
            this.btnTensionDecrease.TabIndex = 33;
            this.btnTensionDecrease.Text = "감소";
            this.btnTensionDecrease.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTensionDecrease.UseVisualStyleBackColor = true;
            // 
            // btnTensionIncrease
            // 
            this.btnTensionIncrease.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnTensionIncrease.Location = new System.Drawing.Point(1154, 83);
            this.btnTensionIncrease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTensionIncrease.Name = "btnTensionIncrease";
            this.btnTensionIncrease.Size = new System.Drawing.Size(107, 38);
            this.btnTensionIncrease.TabIndex = 32;
            this.btnTensionIncrease.Text = "증가";
            this.btnTensionIncrease.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTensionIncrease.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1348, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "m";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Wheat;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1200, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 35);
            this.label11.TabIndex = 30;
            this.label11.Text = "2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(978, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 32);
            this.label14.TabIndex = 29;
            this.label14.Text = "Wave Amplitude +-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(916, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 32);
            this.label16.TabIndex = 28;
            this.label16.Text = "m";
            // 
            // lblCableRemained
            // 
            this.lblCableRemained.BackColor = System.Drawing.Color.Wheat;
            this.lblCableRemained.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCableRemained.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCableRemained.Location = new System.Drawing.Point(774, 196);
            this.lblCableRemained.Name = "lblCableRemained";
            this.lblCableRemained.Size = new System.Drawing.Size(137, 35);
            this.lblCableRemained.TabIndex = 27;
            this.lblCableRemained.Text = "30";
            this.lblCableRemained.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(619, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 32);
            this.label18.TabIndex = 26;
            this.label18.Text = "케이블 여분";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(916, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 32);
            this.label13.TabIndex = 25;
            this.label13.Text = "N/m";
            // 
            // lblCableTension
            // 
            this.lblCableTension.BackColor = System.Drawing.Color.Wheat;
            this.lblCableTension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCableTension.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCableTension.Location = new System.Drawing.Point(774, 136);
            this.lblCableTension.Name = "lblCableTension";
            this.lblCableTension.Size = new System.Drawing.Size(137, 35);
            this.lblCableTension.TabIndex = 24;
            this.lblCableTension.Text = "2";
            this.lblCableTension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(619, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 32);
            this.label15.TabIndex = 23;
            this.label15.Text = "케이블 장력";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(916, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "m/s";
            // 
            // lblCableSpeed
            // 
            this.lblCableSpeed.BackColor = System.Drawing.Color.Wheat;
            this.lblCableSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCableSpeed.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCableSpeed.Location = new System.Drawing.Point(774, 88);
            this.lblCableSpeed.Name = "lblCableSpeed";
            this.lblCableSpeed.Size = new System.Drawing.Size(137, 35);
            this.lblCableSpeed.TabIndex = 21;
            this.lblCableSpeed.Text = "2";
            this.lblCableSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(619, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 32);
            this.label12.TabIndex = 20;
            this.label12.Text = "케이블 속도";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(916, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "m";
            // 
            // lblCableReleased
            // 
            this.lblCableReleased.BackColor = System.Drawing.Color.Wheat;
            this.lblCableReleased.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCableReleased.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCableReleased.Location = new System.Drawing.Point(774, 38);
            this.lblCableReleased.Name = "lblCableReleased";
            this.lblCableReleased.Size = new System.Drawing.Size(137, 35);
            this.lblCableReleased.TabIndex = 18;
            this.lblCableReleased.Text = "120";
            this.lblCableReleased.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(619, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "케이블 길이";
            // 
            // lblSeaState
            // 
            this.lblSeaState.BackColor = System.Drawing.Color.Wheat;
            this.lblSeaState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeaState.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblSeaState.Location = new System.Drawing.Point(465, 196);
            this.lblSeaState.Name = "lblSeaState";
            this.lblSeaState.Size = new System.Drawing.Size(137, 35);
            this.lblSeaState.TabIndex = 16;
            this.lblSeaState.Text = "3";
            this.lblSeaState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSontrolOnOff
            // 
            this.lblSontrolOnOff.BackColor = System.Drawing.Color.Wheat;
            this.lblSontrolOnOff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSontrolOnOff.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblSontrolOnOff.Location = new System.Drawing.Point(133, 138);
            this.lblSontrolOnOff.Name = "lblSontrolOnOff";
            this.lblSontrolOnOff.Size = new System.Drawing.Size(126, 35);
            this.lblSontrolOnOff.TabIndex = 15;
            this.lblSontrolOnOff.Text = "On";
            this.lblSontrolOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWowOnOff
            // 
            this.lblWowOnOff.BackColor = System.Drawing.Color.Wheat;
            this.lblWowOnOff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWowOnOff.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblWowOnOff.Location = new System.Drawing.Point(133, 94);
            this.lblWowOnOff.Name = "lblWowOnOff";
            this.lblWowOnOff.Size = new System.Drawing.Size(126, 35);
            this.lblWowOnOff.TabIndex = 14;
            this.lblWowOnOff.Text = "Off";
            this.lblWowOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(279, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sea State Level";
            // 
            // btnAntiLoad
            // 
            this.btnAntiLoad.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnAntiLoad.Location = new System.Drawing.Point(465, 134);
            this.btnAntiLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAntiLoad.Name = "btnAntiLoad";
            this.btnAntiLoad.Size = new System.Drawing.Size(137, 45);
            this.btnAntiLoad.TabIndex = 11;
            this.btnAntiLoad.Text = "On/Off";
            this.btnAntiLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAntiLoad.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(279, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Anti Load";
            // 
            // btnTensionControl
            // 
            this.btnTensionControl.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnTensionControl.Location = new System.Drawing.Point(465, 85);
            this.btnTensionControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTensionControl.Name = "btnTensionControl";
            this.btnTensionControl.Size = new System.Drawing.Size(137, 45);
            this.btnTensionControl.TabIndex = 9;
            this.btnTensionControl.Text = "On/Off";
            this.btnTensionControl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTensionControl.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(279, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tension Control";
            // 
            // btnAutoLevelOnOff
            // 
            this.btnAutoLevelOnOff.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnAutoLevelOnOff.Location = new System.Drawing.Point(465, 34);
            this.btnAutoLevelOnOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutoLevelOnOff.Name = "btnAutoLevelOnOff";
            this.btnAutoLevelOnOff.Size = new System.Drawing.Size(137, 47);
            this.btnAutoLevelOnOff.TabIndex = 7;
            this.btnAutoLevelOnOff.Text = "On/Off";
            this.btnAutoLevelOnOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAutoLevelOnOff.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(279, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Auto Leveling";
            // 
            // btnWindUp
            // 
            this.btnWindUp.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnWindUp.Location = new System.Drawing.Point(12, 189);
            this.btnWindUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWindUp.Name = "btnWindUp";
            this.btnWindUp.Size = new System.Drawing.Size(246, 50);
            this.btnWindUp.TabIndex = 5;
            this.btnWindUp.Text = "감기";
            this.btnWindUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWindUp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "WOW";
            // 
            // btnWindOut
            // 
            this.btnWindOut.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnWindOut.Location = new System.Drawing.Point(12, 38);
            this.btnWindOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWindOut.Name = "btnWindOut";
            this.btnWindOut.Size = new System.Drawing.Size(246, 50);
            this.btnWindOut.TabIndex = 0;
            this.btnWindOut.Text = "풀기";
            this.btnWindOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWindOut.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tabPage2.Controls.Add(this.label44);
            this.tabPage2.Controls.Add(this.lblDrumTemperature);
            this.tabPage2.Controls.Add(this.label50);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.lblCableLossPower);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.lblCableLossCurrent);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.lblCableLossVoltage);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.lblAcDcInPower);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.lblAcDcInCurrent);
            this.tabPage2.Controls.Add(this.label45);
            this.tabPage2.Controls.Add(this.lblAcDcInVoltage);
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.lblAcDcOutPower);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.lblAcDcOutCurrent);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.lblAcDcOutVoltage);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.lblDcDcBInPower);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.lblDcDcBInCurrent);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.lblDcDcBInVoltage);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.lblDcDcAInPower);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.lblDcDcAInCurrent);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.lblDcDcAInVoltage);
            this.tabPage2.Controls.Add(this.label42);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.lblDcDcBOutPower);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.lblDcDcBOutCurrent);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.lblDcDcBOutVoltage);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.lblDcDcAOutPower);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.lblDcDcAOutCurrent);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.lblDcDcAOutVoltage);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(0);
            this.tabPage2.Size = new System.Drawing.Size(852, 156);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "전원";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label44.Location = new System.Drawing.Point(1036, 189);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(37, 32);
            this.label44.TabIndex = 71;
            this.label44.Text = "℃";
            // 
            // lblDrumTemperature
            // 
            this.lblDrumTemperature.BackColor = System.Drawing.Color.Wheat;
            this.lblDrumTemperature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDrumTemperature.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDrumTemperature.Location = new System.Drawing.Point(956, 181);
            this.lblDrumTemperature.Name = "lblDrumTemperature";
            this.lblDrumTemperature.Size = new System.Drawing.Size(77, 35);
            this.lblDrumTemperature.TabIndex = 70;
            this.lblDrumTemperature.Text = "38";
            this.lblDrumTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label50.Location = new System.Drawing.Point(709, 189);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(254, 32);
            this.label50.TabIndex = 69;
            this.label50.Text = "윈치 케이블 드럼 온도";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label37.Location = new System.Drawing.Point(1289, 141);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(51, 32);
            this.label37.TabIndex = 68;
            this.label37.Text = "kW";
            // 
            // lblCableLossPower
            // 
            this.lblCableLossPower.BackColor = System.Drawing.Color.Wheat;
            this.lblCableLossPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCableLossPower.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCableLossPower.Location = new System.Drawing.Point(1209, 133);
            this.lblCableLossPower.Name = "lblCableLossPower";
            this.lblCableLossPower.Size = new System.Drawing.Size(77, 35);
            this.lblCableLossPower.TabIndex = 67;
            this.lblCableLossPower.Text = "1.25";
            this.lblCableLossPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label46.Location = new System.Drawing.Point(1167, 141);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(31, 32);
            this.label46.TabIndex = 66;
            this.label46.Text = "A";
            // 
            // lblCableLossCurrent
            // 
            this.lblCableLossCurrent.BackColor = System.Drawing.Color.Wheat;
            this.lblCableLossCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCableLossCurrent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCableLossCurrent.Location = new System.Drawing.Point(1088, 133);
            this.lblCableLossCurrent.Name = "lblCableLossCurrent";
            this.lblCableLossCurrent.Size = new System.Drawing.Size(77, 35);
            this.lblCableLossCurrent.TabIndex = 65;
            this.lblCableLossCurrent.Text = "25";
            this.lblCableLossCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label49.Location = new System.Drawing.Point(1030, 140);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(57, 32);
            this.label49.TabIndex = 64;
            this.label49.Text = "Vdc";
            // 
            // lblCableLossVoltage
            // 
            this.lblCableLossVoltage.BackColor = System.Drawing.Color.Wheat;
            this.lblCableLossVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCableLossVoltage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCableLossVoltage.Location = new System.Drawing.Point(951, 132);
            this.lblCableLossVoltage.Name = "lblCableLossVoltage";
            this.lblCableLossVoltage.Size = new System.Drawing.Size(77, 35);
            this.lblCableLossVoltage.TabIndex = 63;
            this.lblCableLossVoltage.Text = "50";
            this.lblCableLossVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label51.Location = new System.Drawing.Point(703, 140);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(254, 32);
            this.label51.TabIndex = 62;
            this.label51.Text = "윈치 케이블 손실 전력";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(601, 190);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 32);
            this.label32.TabIndex = 61;
            this.label32.Text = "kW";
            // 
            // lblAcDcInPower
            // 
            this.lblAcDcInPower.BackColor = System.Drawing.Color.Wheat;
            this.lblAcDcInPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcDcInPower.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblAcDcInPower.Location = new System.Drawing.Point(522, 183);
            this.lblAcDcInPower.Name = "lblAcDcInPower";
            this.lblAcDcInPower.Size = new System.Drawing.Size(77, 35);
            this.lblAcDcInPower.TabIndex = 60;
            this.lblAcDcInPower.Text = "15.0";
            this.lblAcDcInPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label41.Location = new System.Drawing.Point(479, 190);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 32);
            this.label41.TabIndex = 59;
            this.label41.Text = "A";
            // 
            // lblAcDcInCurrent
            // 
            this.lblAcDcInCurrent.BackColor = System.Drawing.Color.Wheat;
            this.lblAcDcInCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcDcInCurrent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblAcDcInCurrent.Location = new System.Drawing.Point(401, 183);
            this.lblAcDcInCurrent.Name = "lblAcDcInCurrent";
            this.lblAcDcInCurrent.Size = new System.Drawing.Size(77, 35);
            this.lblAcDcInCurrent.TabIndex = 58;
            this.lblAcDcInCurrent.Text = "40";
            this.lblAcDcInCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label45.Location = new System.Drawing.Point(343, 190);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 32);
            this.label45.TabIndex = 57;
            this.label45.Text = "Vdc";
            // 
            // lblAcDcInVoltage
            // 
            this.lblAcDcInVoltage.BackColor = System.Drawing.Color.Wheat;
            this.lblAcDcInVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcDcInVoltage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblAcDcInVoltage.Location = new System.Drawing.Point(263, 182);
            this.lblAcDcInVoltage.Name = "lblAcDcInVoltage";
            this.lblAcDcInVoltage.Size = new System.Drawing.Size(77, 35);
            this.lblAcDcInVoltage.TabIndex = 56;
            this.lblAcDcInVoltage.Text = "380";
            this.lblAcDcInVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label47.Location = new System.Drawing.Point(16, 190);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(226, 32);
            this.label47.TabIndex = 55;
            this.label47.Text = "AC/DC 컨버터 입력";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(601, 140);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 32);
            this.label28.TabIndex = 54;
            this.label28.Text = "kW";
            // 
            // lblAcDcOutPower
            // 
            this.lblAcDcOutPower.BackColor = System.Drawing.Color.Wheat;
            this.lblAcDcOutPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcDcOutPower.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblAcDcOutPower.Location = new System.Drawing.Point(522, 132);
            this.lblAcDcOutPower.Name = "lblAcDcOutPower";
            this.lblAcDcOutPower.Size = new System.Drawing.Size(77, 35);
            this.lblAcDcOutPower.TabIndex = 53;
            this.lblAcDcOutPower.Text = "10.0";
            this.lblAcDcOutPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(479, 140);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(31, 32);
            this.label34.TabIndex = 52;
            this.label34.Text = "A";
            // 
            // lblAcDcOutCurrent
            // 
            this.lblAcDcOutCurrent.BackColor = System.Drawing.Color.Wheat;
            this.lblAcDcOutCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcDcOutCurrent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblAcDcOutCurrent.Location = new System.Drawing.Point(401, 132);
            this.lblAcDcOutCurrent.Name = "lblAcDcOutCurrent";
            this.lblAcDcOutCurrent.Size = new System.Drawing.Size(77, 35);
            this.lblAcDcOutCurrent.TabIndex = 51;
            this.lblAcDcOutCurrent.Text = "25";
            this.lblAcDcOutCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label39.Location = new System.Drawing.Point(343, 139);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(57, 32);
            this.label39.TabIndex = 50;
            this.label39.Text = "Vdc";
            // 
            // lblAcDcOutVoltage
            // 
            this.lblAcDcOutVoltage.BackColor = System.Drawing.Color.Wheat;
            this.lblAcDcOutVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcDcOutVoltage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblAcDcOutVoltage.Location = new System.Drawing.Point(263, 132);
            this.lblAcDcOutVoltage.Name = "lblAcDcOutVoltage";
            this.lblAcDcOutVoltage.Size = new System.Drawing.Size(77, 35);
            this.lblAcDcOutVoltage.TabIndex = 49;
            this.lblAcDcOutVoltage.Text = "400";
            this.lblAcDcOutVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label43.Location = new System.Drawing.Point(16, 139);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(226, 32);
            this.label43.TabIndex = 48;
            this.label43.Text = "AC/DC 컨버터 출력";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(1289, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 32);
            this.label26.TabIndex = 47;
            this.label26.Text = "kW";
            // 
            // lblDcDcBInPower
            // 
            this.lblDcDcBInPower.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcBInPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcBInPower.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcBInPower.Location = new System.Drawing.Point(1209, 66);
            this.lblDcDcBInPower.Name = "lblDcDcBInPower";
            this.lblDcDcBInPower.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcBInPower.TabIndex = 46;
            this.lblDcDcBInPower.Text = "8.75";
            this.lblDcDcBInPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(1167, 74);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(31, 32);
            this.label30.TabIndex = 45;
            this.label30.Text = "A";
            // 
            // lblDcDcBInCurrent
            // 
            this.lblDcDcBInCurrent.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcBInCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcBInCurrent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcBInCurrent.Location = new System.Drawing.Point(1088, 66);
            this.lblDcDcBInCurrent.Name = "lblDcDcBInCurrent";
            this.lblDcDcBInCurrent.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcBInCurrent.TabIndex = 44;
            this.lblDcDcBInCurrent.Text = "25";
            this.lblDcDcBInCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(1030, 74);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 32);
            this.label33.TabIndex = 43;
            this.label33.Text = "Vdc";
            // 
            // lblDcDcBInVoltage
            // 
            this.lblDcDcBInVoltage.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcBInVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcBInVoltage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcBInVoltage.Location = new System.Drawing.Point(951, 66);
            this.lblDcDcBInVoltage.Name = "lblDcDcBInVoltage";
            this.lblDcDcBInVoltage.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcBInVoltage.TabIndex = 42;
            this.lblDcDcBInVoltage.Text = "350";
            this.lblDcDcBInVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label35.Location = new System.Drawing.Point(703, 74);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(260, 32);
            this.label35.TabIndex = 41;
            this.label35.Text = "DC/DC 컨버터(B) 입력";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label36.Location = new System.Drawing.Point(601, 74);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(51, 32);
            this.label36.TabIndex = 40;
            this.label36.Text = "kW";
            // 
            // lblDcDcAInPower
            // 
            this.lblDcDcAInPower.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcAInPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcAInPower.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcAInPower.Location = new System.Drawing.Point(522, 66);
            this.lblDcDcAInPower.Name = "lblDcDcAInPower";
            this.lblDcDcAInPower.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcAInPower.TabIndex = 39;
            this.lblDcDcAInPower.Text = "8.75";
            this.lblDcDcAInPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label38.Location = new System.Drawing.Point(479, 74);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(31, 32);
            this.label38.TabIndex = 38;
            this.label38.Text = "A";
            // 
            // lblDcDcAInCurrent
            // 
            this.lblDcDcAInCurrent.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcAInCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcAInCurrent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcAInCurrent.Location = new System.Drawing.Point(401, 66);
            this.lblDcDcAInCurrent.Name = "lblDcDcAInCurrent";
            this.lblDcDcAInCurrent.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcAInCurrent.TabIndex = 37;
            this.lblDcDcAInCurrent.Text = "25";
            this.lblDcDcAInCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label40.Location = new System.Drawing.Point(343, 74);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 32);
            this.label40.TabIndex = 36;
            this.label40.Text = "Vdc";
            // 
            // lblDcDcAInVoltage
            // 
            this.lblDcDcAInVoltage.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcAInVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcAInVoltage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcAInVoltage.Location = new System.Drawing.Point(263, 66);
            this.lblDcDcAInVoltage.Name = "lblDcDcAInVoltage";
            this.lblDcDcAInVoltage.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcAInVoltage.TabIndex = 35;
            this.lblDcDcAInVoltage.Text = "350";
            this.lblDcDcAInVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label42.Location = new System.Drawing.Point(16, 74);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(262, 32);
            this.label42.TabIndex = 34;
            this.label42.Text = "DC/DC 컨버터(A) 입력";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(1289, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 32);
            this.label25.TabIndex = 33;
            this.label25.Text = "kW";
            // 
            // lblDcDcBOutPower
            // 
            this.lblDcDcBOutPower.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcBOutPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcBOutPower.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcBOutPower.Location = new System.Drawing.Point(1209, 18);
            this.lblDcDcBOutPower.Name = "lblDcDcBOutPower";
            this.lblDcDcBOutPower.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcBOutPower.TabIndex = 32;
            this.lblDcDcBOutPower.Text = "4.5";
            this.lblDcDcBOutPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(1167, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 32);
            this.label27.TabIndex = 31;
            this.label27.Text = "A";
            // 
            // lblDcDcBOutCurrent
            // 
            this.lblDcDcBOutCurrent.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcBOutCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcBOutCurrent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcBOutCurrent.Location = new System.Drawing.Point(1088, 18);
            this.lblDcDcBOutCurrent.Name = "lblDcDcBOutCurrent";
            this.lblDcDcBOutCurrent.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcBOutCurrent.TabIndex = 30;
            this.lblDcDcBOutCurrent.Text = "90";
            this.lblDcDcBOutCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(1030, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 32);
            this.label29.TabIndex = 29;
            this.label29.Text = "Vdc";
            // 
            // lblDcDcBOutVoltage
            // 
            this.lblDcDcBOutVoltage.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcBOutVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcBOutVoltage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcBOutVoltage.Location = new System.Drawing.Point(951, 18);
            this.lblDcDcBOutVoltage.Name = "lblDcDcBOutVoltage";
            this.lblDcDcBOutVoltage.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcBOutVoltage.TabIndex = 28;
            this.lblDcDcBOutVoltage.Text = "50";
            this.lblDcDcBOutVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(703, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(260, 32);
            this.label31.TabIndex = 27;
            this.label31.Text = "DC/DC 컨버터(B) 출력";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(601, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 32);
            this.label24.TabIndex = 26;
            this.label24.Text = "kW";
            // 
            // lblDcDcAOutPower
            // 
            this.lblDcDcAOutPower.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcAOutPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcAOutPower.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcAOutPower.Location = new System.Drawing.Point(522, 18);
            this.lblDcDcAOutPower.Name = "lblDcDcAOutPower";
            this.lblDcDcAOutPower.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcAOutPower.TabIndex = 25;
            this.lblDcDcAOutPower.Text = "4.5";
            this.lblDcDcAOutPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(479, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 32);
            this.label22.TabIndex = 24;
            this.label22.Text = "A";
            // 
            // lblDcDcAOutCurrent
            // 
            this.lblDcDcAOutCurrent.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcAOutCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcAOutCurrent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcAOutCurrent.Location = new System.Drawing.Point(401, 18);
            this.lblDcDcAOutCurrent.Name = "lblDcDcAOutCurrent";
            this.lblDcDcAOutCurrent.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcAOutCurrent.TabIndex = 23;
            this.lblDcDcAOutCurrent.Text = "90";
            this.lblDcDcAOutCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(343, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 32);
            this.label20.TabIndex = 22;
            this.label20.Text = "Vdc";
            // 
            // lblDcDcAOutVoltage
            // 
            this.lblDcDcAOutVoltage.BackColor = System.Drawing.Color.Wheat;
            this.lblDcDcAOutVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDcDcAOutVoltage.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblDcDcAOutVoltage.Location = new System.Drawing.Point(263, 18);
            this.lblDcDcAOutVoltage.Name = "lblDcDcAOutVoltage";
            this.lblDcDcAOutVoltage.Size = new System.Drawing.Size(77, 35);
            this.lblDcDcAOutVoltage.TabIndex = 21;
            this.lblDcDcAOutVoltage.Text = "50";
            this.lblDcDcAOutVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(16, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(262, 32);
            this.label23.TabIndex = 20;
            this.label23.Text = "DC/DC 컨버터(A) 출력";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(0);
            this.tabPage3.Size = new System.Drawing.Size(852, 156);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "통신";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblComTimeout);
            this.groupBox3.Controls.Add(this.label62);
            this.groupBox3.Controls.Add(this.lblComLatency);
            this.groupBox3.Controls.Add(this.label65);
            this.groupBox3.Controls.Add(this.lblComHeartbeatCount);
            this.groupBox3.Controls.Add(this.label70);
            this.groupBox3.Controls.Add(this.label71);
            this.groupBox3.Controls.Add(this.lblComStreamRate);
            this.groupBox3.Controls.Add(this.label73);
            this.groupBox3.Controls.Add(this.lblComPacketLoss);
            this.groupBox3.Controls.Add(this.label75);
            this.groupBox3.Location = new System.Drawing.Point(1032, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(360, 221);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GCS-지상체";
            // 
            // lblComTimeout
            // 
            this.lblComTimeout.BackColor = System.Drawing.Color.Wheat;
            this.lblComTimeout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComTimeout.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblComTimeout.Location = new System.Drawing.Point(199, 181);
            this.lblComTimeout.Name = "lblComTimeout";
            this.lblComTimeout.Size = new System.Drawing.Size(102, 35);
            this.lblComTimeout.TabIndex = 48;
            this.lblComTimeout.Text = "0";
            this.lblComTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label62.Location = new System.Drawing.Point(26, 188);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(101, 32);
            this.label62.TabIndex = 47;
            this.label62.Text = "Latency";
            // 
            // lblComLatency
            // 
            this.lblComLatency.BackColor = System.Drawing.Color.Wheat;
            this.lblComLatency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComLatency.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblComLatency.Location = new System.Drawing.Point(199, 144);
            this.lblComLatency.Name = "lblComLatency";
            this.lblComLatency.Size = new System.Drawing.Size(102, 35);
            this.lblComLatency.TabIndex = 46;
            this.lblComLatency.Text = "0";
            this.lblComLatency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label65.Location = new System.Drawing.Point(26, 150);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(101, 32);
            this.label65.TabIndex = 45;
            this.label65.Text = "Latency";
            // 
            // lblComHeartbeatCount
            // 
            this.lblComHeartbeatCount.BackColor = System.Drawing.Color.Wheat;
            this.lblComHeartbeatCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComHeartbeatCount.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblComHeartbeatCount.Location = new System.Drawing.Point(199, 106);
            this.lblComHeartbeatCount.Name = "lblComHeartbeatCount";
            this.lblComHeartbeatCount.Size = new System.Drawing.Size(102, 35);
            this.lblComHeartbeatCount.TabIndex = 43;
            this.lblComHeartbeatCount.Text = "0";
            this.lblComHeartbeatCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label70.Location = new System.Drawing.Point(26, 113);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(126, 32);
            this.label70.TabIndex = 42;
            this.label70.Text = "Heartbeat";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label71.Location = new System.Drawing.Point(306, 38);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(35, 32);
            this.label71.TabIndex = 41;
            this.label71.Text = "%";
            // 
            // lblComStreamRate
            // 
            this.lblComStreamRate.BackColor = System.Drawing.Color.Wheat;
            this.lblComStreamRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComStreamRate.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblComStreamRate.Location = new System.Drawing.Point(199, 69);
            this.lblComStreamRate.Name = "lblComStreamRate";
            this.lblComStreamRate.Size = new System.Drawing.Size(102, 35);
            this.lblComStreamRate.TabIndex = 40;
            this.lblComStreamRate.Text = "0";
            this.lblComStreamRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label73.Location = new System.Drawing.Point(26, 76);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(153, 32);
            this.label73.TabIndex = 39;
            this.label73.Text = "Stream Rate";
            // 
            // lblComPacketLoss
            // 
            this.lblComPacketLoss.BackColor = System.Drawing.Color.Wheat;
            this.lblComPacketLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComPacketLoss.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblComPacketLoss.Location = new System.Drawing.Point(199, 32);
            this.lblComPacketLoss.Name = "lblComPacketLoss";
            this.lblComPacketLoss.Size = new System.Drawing.Size(102, 35);
            this.lblComPacketLoss.TabIndex = 20;
            this.lblComPacketLoss.Text = "0";
            this.lblComPacketLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label75.Location = new System.Drawing.Point(26, 38);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(146, 32);
            this.label75.TabIndex = 19;
            this.label75.Text = "Packet Loss";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label57);
            this.groupBox2.Controls.Add(this.lblGcsBytesReceived);
            this.groupBox2.Controls.Add(this.label60);
            this.groupBox2.Controls.Add(this.label61);
            this.groupBox2.Controls.Add(this.lblGcsComBytesSent);
            this.groupBox2.Controls.Add(this.label63);
            this.groupBox2.Controls.Add(this.label64);
            this.groupBox2.Controls.Add(this.lblGcsComBaudrate);
            this.groupBox2.Controls.Add(this.label66);
            this.groupBox2.Controls.Add(this.lblGcsComStatus);
            this.groupBox2.Controls.Add(this.label68);
            this.groupBox2.Location = new System.Drawing.Point(522, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(489, 221);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GCS-지상체";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label57.Location = new System.Drawing.Point(401, 176);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(75, 32);
            this.label57.TabIndex = 47;
            this.label57.Text = "bytes";
            // 
            // lblGcsBytesReceived
            // 
            this.lblGcsBytesReceived.BackColor = System.Drawing.Color.Wheat;
            this.lblGcsBytesReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGcsBytesReceived.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblGcsBytesReceived.Location = new System.Drawing.Point(199, 169);
            this.lblGcsBytesReceived.Name = "lblGcsBytesReceived";
            this.lblGcsBytesReceived.Size = new System.Drawing.Size(187, 35);
            this.lblGcsBytesReceived.TabIndex = 46;
            this.lblGcsBytesReceived.Text = "1,478,309,530";
            this.lblGcsBytesReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label60.Location = new System.Drawing.Point(26, 176);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(174, 32);
            this.label60.TabIndex = 45;
            this.label60.Text = "받은 바이트 수";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label61.Location = new System.Drawing.Point(401, 131);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(75, 32);
            this.label61.TabIndex = 44;
            this.label61.Text = "bytes";
            // 
            // lblGcsComBytesSent
            // 
            this.lblGcsComBytesSent.BackColor = System.Drawing.Color.Wheat;
            this.lblGcsComBytesSent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGcsComBytesSent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblGcsComBytesSent.Location = new System.Drawing.Point(199, 124);
            this.lblGcsComBytesSent.Name = "lblGcsComBytesSent";
            this.lblGcsComBytesSent.Size = new System.Drawing.Size(187, 35);
            this.lblGcsComBytesSent.TabIndex = 43;
            this.lblGcsComBytesSent.Text = "1,478,309,530";
            this.lblGcsComBytesSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label63.Location = new System.Drawing.Point(26, 131);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(174, 32);
            this.label63.TabIndex = 42;
            this.label63.Text = "보낸 바이트 수";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label64.Location = new System.Drawing.Point(366, 86);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(78, 32);
            this.label64.TabIndex = 41;
            this.label64.Text = "Mbps";
            // 
            // lblGcsComBaudrate
            // 
            this.lblGcsComBaudrate.BackColor = System.Drawing.Color.Wheat;
            this.lblGcsComBaudrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGcsComBaudrate.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblGcsComBaudrate.Location = new System.Drawing.Point(199, 79);
            this.lblGcsComBaudrate.Name = "lblGcsComBaudrate";
            this.lblGcsComBaudrate.Size = new System.Drawing.Size(137, 35);
            this.lblGcsComBaudrate.TabIndex = 40;
            this.lblGcsComBaudrate.Text = "100/1000";
            this.lblGcsComBaudrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label66.Location = new System.Drawing.Point(26, 86);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(118, 32);
            this.label66.TabIndex = 39;
            this.label66.Text = "연결 속도";
            // 
            // lblGcsComStatus
            // 
            this.lblGcsComStatus.BackColor = System.Drawing.Color.Wheat;
            this.lblGcsComStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGcsComStatus.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblGcsComStatus.Location = new System.Drawing.Point(199, 32);
            this.lblGcsComStatus.Name = "lblGcsComStatus";
            this.lblGcsComStatus.Size = new System.Drawing.Size(187, 35);
            this.lblGcsComStatus.TabIndex = 20;
            this.lblGcsComStatus.Text = "연결됨";
            this.lblGcsComStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label68.Location = new System.Drawing.Point(26, 38);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(118, 32);
            this.label68.TabIndex = 19;
            this.label68.Text = "통신 상태";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label55);
            this.groupBox1.Controls.Add(this.lblExtBytesReceived);
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.lblExtComBytesSent);
            this.groupBox1.Controls.Add(this.label56);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.lblExtComBaudrate);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.lblExtComStatus);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(489, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "외부망-GCS";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label55.Location = new System.Drawing.Point(401, 176);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(75, 32);
            this.label55.TabIndex = 47;
            this.label55.Text = "bytes";
            // 
            // lblExtBytesReceived
            // 
            this.lblExtBytesReceived.BackColor = System.Drawing.Color.Wheat;
            this.lblExtBytesReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtBytesReceived.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblExtBytesReceived.Location = new System.Drawing.Point(199, 169);
            this.lblExtBytesReceived.Name = "lblExtBytesReceived";
            this.lblExtBytesReceived.Size = new System.Drawing.Size(187, 35);
            this.lblExtBytesReceived.TabIndex = 46;
            this.lblExtBytesReceived.Text = "1,478,309,530";
            this.lblExtBytesReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label58.Location = new System.Drawing.Point(26, 176);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(174, 32);
            this.label58.TabIndex = 45;
            this.label58.Text = "받은 바이트 수";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label53.Location = new System.Drawing.Point(401, 131);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(75, 32);
            this.label53.TabIndex = 44;
            this.label53.Text = "bytes";
            // 
            // lblExtComBytesSent
            // 
            this.lblExtComBytesSent.BackColor = System.Drawing.Color.Wheat;
            this.lblExtComBytesSent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtComBytesSent.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblExtComBytesSent.Location = new System.Drawing.Point(199, 124);
            this.lblExtComBytesSent.Name = "lblExtComBytesSent";
            this.lblExtComBytesSent.Size = new System.Drawing.Size(187, 35);
            this.lblExtComBytesSent.TabIndex = 43;
            this.lblExtComBytesSent.Text = "1,478,309,530";
            this.lblExtComBytesSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label56.Location = new System.Drawing.Point(26, 131);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(174, 32);
            this.label56.TabIndex = 42;
            this.label56.Text = "보낸 바이트 수";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label48.Location = new System.Drawing.Point(366, 86);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(78, 32);
            this.label48.TabIndex = 41;
            this.label48.Text = "Mbps";
            // 
            // lblExtComBaudrate
            // 
            this.lblExtComBaudrate.BackColor = System.Drawing.Color.Wheat;
            this.lblExtComBaudrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtComBaudrate.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblExtComBaudrate.Location = new System.Drawing.Point(199, 79);
            this.lblExtComBaudrate.Name = "lblExtComBaudrate";
            this.lblExtComBaudrate.Size = new System.Drawing.Size(137, 35);
            this.lblExtComBaudrate.TabIndex = 40;
            this.lblExtComBaudrate.Text = "100/1000";
            this.lblExtComBaudrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label54.Location = new System.Drawing.Point(26, 86);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(118, 32);
            this.label54.TabIndex = 39;
            this.label54.Text = "연결 속도";
            // 
            // lblExtComStatus
            // 
            this.lblExtComStatus.BackColor = System.Drawing.Color.Wheat;
            this.lblExtComStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtComStatus.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblExtComStatus.Location = new System.Drawing.Point(199, 32);
            this.lblExtComStatus.Name = "lblExtComStatus";
            this.lblExtComStatus.Size = new System.Drawing.Size(187, 35);
            this.lblExtComStatus.TabIndex = 20;
            this.lblExtComStatus.Text = "연결됨";
            this.lblExtComStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label52.Location = new System.Drawing.Point(26, 38);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(118, 32);
            this.label52.TabIndex = 19;
            this.label52.Text = "통신 상태";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(0);
            this.tabPage4.Size = new System.Drawing.Size(852, 156);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "작동";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAltDown);
            this.groupBox5.Controls.Add(this.btnAltUp);
            this.groupBox5.Controls.Add(this.btnAutoReturn);
            this.groupBox5.Controls.Add(this.btnHoverAt100m);
            this.groupBox5.Controls.Add(this.btnAutoStart);
            this.groupBox5.Location = new System.Drawing.Point(916, 22);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(480, 225);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "자동 작동";
            // 
            // btnAltDown
            // 
            this.btnAltDown.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnAltDown.Location = new System.Drawing.Point(180, 163);
            this.btnAltDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltDown.Name = "btnAltDown";
            this.btnAltDown.Size = new System.Drawing.Size(130, 52);
            this.btnAltDown.TabIndex = 18;
            this.btnAltDown.Text = "고도 하강";
            this.btnAltDown.UseVisualStyleBackColor = true;
            // 
            // btnAltUp
            // 
            this.btnAltUp.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnAltUp.Location = new System.Drawing.Point(180, 35);
            this.btnAltUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltUp.Name = "btnAltUp";
            this.btnAltUp.Size = new System.Drawing.Size(130, 52);
            this.btnAltUp.TabIndex = 17;
            this.btnAltUp.Text = "고도 상승";
            this.btnAltUp.UseVisualStyleBackColor = true;
            // 
            // btnAutoReturn
            // 
            this.btnAutoReturn.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnAutoReturn.Location = new System.Drawing.Point(316, 78);
            this.btnAutoReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutoReturn.Name = "btnAutoReturn";
            this.btnAutoReturn.Size = new System.Drawing.Size(136, 88);
            this.btnAutoReturn.TabIndex = 16;
            this.btnAutoReturn.Text = "유선드론 수납";
            this.btnAutoReturn.UseVisualStyleBackColor = true;
            // 
            // btnHoverAt100m
            // 
            this.btnHoverAt100m.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnHoverAt100m.Location = new System.Drawing.Point(180, 98);
            this.btnHoverAt100m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoverAt100m.Name = "btnHoverAt100m";
            this.btnHoverAt100m.Size = new System.Drawing.Size(130, 54);
            this.btnHoverAt100m.TabIndex = 15;
            this.btnHoverAt100m.Text = "100m";
            this.btnHoverAt100m.UseVisualStyleBackColor = true;
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnAutoStart.Location = new System.Drawing.Point(31, 78);
            this.btnAutoStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(132, 88);
            this.btnAutoStart.TabIndex = 14;
            this.btnAutoStart.Text = "유선드론 기동";
            this.btnAutoStart.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.pictureBox8);
            this.groupBox4.Controls.Add(this.pictureBox7);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.pictureBox6);
            this.groupBox4.Controls.Add(this.btnCLoseStation);
            this.groupBox4.Controls.Add(this.btnLandAndStore);
            this.groupBox4.Controls.Add(this.btnLandSync);
            this.groupBox4.Controls.Add(this.btnStandbyLand);
            this.groupBox4.Controls.Add(this.btnFollowShip);
            this.groupBox4.Controls.Add(this.btnHovering);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.btnTakeOff);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.btnStandby);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.btnOpenStation);
            this.groupBox4.Location = new System.Drawing.Point(18, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(861, 243);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "수동 작동";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMotionSyncToDrone);
            this.panel1.Controls.Add(this.btnMotionSyncToSea);
            this.panel1.Controls.Add(this.btnMotionSyncToLand);
            this.panel1.Controls.Add(this.label59);
            this.panel1.Location = new System.Drawing.Point(19, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 74);
            this.panel1.TabIndex = 18;
            // 
            // btnMotionSyncToDrone
            // 
            this.btnMotionSyncToDrone.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnMotionSyncToDrone.Location = new System.Drawing.Point(478, 13);
            this.btnMotionSyncToDrone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMotionSyncToDrone.Name = "btnMotionSyncToDrone";
            this.btnMotionSyncToDrone.Size = new System.Drawing.Size(120, 52);
            this.btnMotionSyncToDrone.TabIndex = 13;
            this.btnMotionSyncToDrone.Text = "기체";
            this.btnMotionSyncToDrone.UseVisualStyleBackColor = true;
            // 
            // btnMotionSyncToSea
            // 
            this.btnMotionSyncToSea.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnMotionSyncToSea.Location = new System.Drawing.Point(346, 13);
            this.btnMotionSyncToSea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMotionSyncToSea.Name = "btnMotionSyncToSea";
            this.btnMotionSyncToSea.Size = new System.Drawing.Size(120, 52);
            this.btnMotionSyncToSea.TabIndex = 12;
            this.btnMotionSyncToSea.Text = "해상";
            this.btnMotionSyncToSea.UseVisualStyleBackColor = true;
            // 
            // btnMotionSyncToLand
            // 
            this.btnMotionSyncToLand.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnMotionSyncToLand.Location = new System.Drawing.Point(205, 13);
            this.btnMotionSyncToLand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMotionSyncToLand.Name = "btnMotionSyncToLand";
            this.btnMotionSyncToLand.Size = new System.Drawing.Size(120, 52);
            this.btnMotionSyncToLand.TabIndex = 11;
            this.btnMotionSyncToLand.Text = "육상";
            this.btnMotionSyncToLand.UseVisualStyleBackColor = true;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label59.Location = new System.Drawing.Point(3, 26);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(198, 32);
            this.label59.TabIndex = 10;
            this.label59.Text = "모션 동기화 모드";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(697, 163);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(46, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(697, 84);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(594, 194);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(388, 194);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(174, 194);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // btnCLoseStation
            // 
            this.btnCLoseStation.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnCLoseStation.Location = new System.Drawing.Point(17, 189);
            this.btnCLoseStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCLoseStation.Name = "btnCLoseStation";
            this.btnCLoseStation.Size = new System.Drawing.Size(151, 43);
            this.btnCLoseStation.TabIndex = 12;
            this.btnCLoseStation.Text = "격납함 닫기";
            this.btnCLoseStation.UseVisualStyleBackColor = true;
            // 
            // btnLandAndStore
            // 
            this.btnLandAndStore.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnLandAndStore.Location = new System.Drawing.Point(226, 189);
            this.btnLandAndStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLandAndStore.Name = "btnLandAndStore";
            this.btnLandAndStore.Size = new System.Drawing.Size(151, 45);
            this.btnLandAndStore.TabIndex = 11;
            this.btnLandAndStore.Text = "착륙 수납";
            this.btnLandAndStore.UseVisualStyleBackColor = true;
            // 
            // btnLandSync
            // 
            this.btnLandSync.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnLandSync.Location = new System.Drawing.Point(439, 189);
            this.btnLandSync.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLandSync.Name = "btnLandSync";
            this.btnLandSync.Size = new System.Drawing.Size(151, 45);
            this.btnLandSync.TabIndex = 10;
            this.btnLandSync.Text = "착륙 동기";
            this.btnLandSync.UseVisualStyleBackColor = true;
            // 
            // btnStandbyLand
            // 
            this.btnStandbyLand.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnStandbyLand.Location = new System.Drawing.Point(645, 189);
            this.btnStandbyLand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStandbyLand.Name = "btnStandbyLand";
            this.btnStandbyLand.Size = new System.Drawing.Size(151, 43);
            this.btnStandbyLand.TabIndex = 9;
            this.btnStandbyLand.Text = "착륙 대기";
            this.btnStandbyLand.UseVisualStyleBackColor = true;
            // 
            // btnFollowShip
            // 
            this.btnFollowShip.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnFollowShip.Location = new System.Drawing.Point(645, 111);
            this.btnFollowShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFollowShip.Name = "btnFollowShip";
            this.btnFollowShip.Size = new System.Drawing.Size(151, 54);
            this.btnFollowShip.TabIndex = 8;
            this.btnFollowShip.Text = "추종 비행";
            this.btnFollowShip.UseVisualStyleBackColor = true;
            // 
            // btnHovering
            // 
            this.btnHovering.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnHovering.Location = new System.Drawing.Point(645, 34);
            this.btnHovering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHovering.Name = "btnHovering";
            this.btnHovering.Size = new System.Drawing.Size(151, 51);
            this.btnHovering.TabIndex = 7;
            this.btnHovering.Text = "비행 대기";
            this.btnHovering.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(594, 40);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btnTakeOff
            // 
            this.btnTakeOff.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnTakeOff.Location = new System.Drawing.Point(439, 34);
            this.btnTakeOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeOff.Name = "btnTakeOff";
            this.btnTakeOff.Size = new System.Drawing.Size(151, 51);
            this.btnTakeOff.TabIndex = 5;
            this.btnTakeOff.Text = "이륙 사출";
            this.btnTakeOff.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(388, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnStandby
            // 
            this.btnStandby.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnStandby.Location = new System.Drawing.Point(226, 34);
            this.btnStandby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(157, 51);
            this.btnStandby.TabIndex = 3;
            this.btnStandby.Text = "이륙 대기";
            this.btnStandby.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenStation
            // 
            this.btnOpenStation.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.btnOpenStation.Location = new System.Drawing.Point(16, 34);
            this.btnOpenStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenStation.Name = "btnOpenStation";
            this.btnOpenStation.Size = new System.Drawing.Size(153, 51);
            this.btnOpenStation.TabIndex = 1;
            this.btnOpenStation.Text = "격납함 열기";
            this.btnOpenStation.UseVisualStyleBackColor = true;
            // 
            // UcMainTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panelFrame);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Name = "UcMainTabControl";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(860, 200);
            this.panelFrame.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFrame;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnWindOut;
        private Label label2;
        private Label label1;
        private Button btnWindUp;
        private Button btnTensionControl;
        private Label label4;
        private Button btnAutoLevelOnOff;
        private Label label3;
        private Label label6;
        private Button btnAntiLoad;
        private Label label5;
        private Label lblSeaState;
        private Label lblSontrolOnOff;
        private Label lblWowOnOff;
        private Label label16;
        private Label lblCableRemained;
        private Label label18;
        private Label label13;
        private Label lblCableTension;
        private Label label15;
        private Label label10;
        private Label lblCableSpeed;
        private Label label12;
        private Label label9;
        private Label lblCableReleased;
        private Label label8;
        private Button btnTensionIncrease;
        private Label label7;
        private Label label11;
        private Label label14;
        private Label label17;
        private Label lblTensionTarget;
        private Button btnTensionDecrease;
        private Label label19;
        private Label lblWinchDrumRpm;
        private Label label21;
        private Label label20;
        private Label lblDcDcAOutVoltage;
        private Label label23;
        private Label label24;
        private Label lblDcDcAOutPower;
        private Label label22;
        private Label lblDcDcAOutCurrent;
        private Label label25;
        private Label lblDcDcBOutPower;
        private Label label27;
        private Label lblDcDcBOutCurrent;
        private Label label29;
        private Label lblDcDcBOutVoltage;
        private Label label31;
        private Label label26;
        private Label lblDcDcBInPower;
        private Label label30;
        private Label lblDcDcBInCurrent;
        private Label label33;
        private Label lblDcDcBInVoltage;
        private Label label35;
        private Label label36;
        private Label lblDcDcAInPower;
        private Label label38;
        private Label lblDcDcAInCurrent;
        private Label label40;
        private Label lblDcDcAInVoltage;
        private Label label42;
        private Label label37;
        private Label lblCableLossPower;
        private Label label46;
        private Label lblCableLossCurrent;
        private Label label49;
        private Label lblCableLossVoltage;
        private Label label51;
        private Label label32;
        private Label lblAcDcInPower;
        private Label label41;
        private Label lblAcDcInCurrent;
        private Label label45;
        private Label lblAcDcInVoltage;
        private Label label47;
        private Label label28;
        private Label lblAcDcOutPower;
        private Label label34;
        private Label lblAcDcOutCurrent;
        private Label label39;
        private Label lblAcDcOutVoltage;
        private Label label43;
        private Label label44;
        private Label lblDrumTemperature;
        private Label label50;
        private GroupBox groupBox1;
        private Label label48;
        private Label lblExtComBaudrate;
        private Label label54;
        private Label lblExtComStatus;
        private Label label52;
        private Label label53;
        private Label lblExtComBytesSent;
        private Label label56;
        private Label label55;
        private Label lblExtBytesReceived;
        private Label label58;
        private GroupBox groupBox2;
        private Label label57;
        private Label lblGcsBytesReceived;
        private Label label60;
        private Label label61;
        private Label lblGcsComBytesSent;
        private Label label63;
        private Label label64;
        private Label lblGcsComBaudrate;
        private Label label66;
        private Label lblGcsComStatus;
        private Label label68;
        private GroupBox groupBox3;
        private Label lblComLatency;
        private Label label65;
        private Label lblComHeartbeatCount;
        private Label label70;
        private Label label71;
        private Label lblComStreamRate;
        private Label label73;
        private Label lblComPacketLoss;
        private Label label75;
        private Label lblComTimeout;
        private Label label62;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private PictureBox pictureBox1;
        private Button btnOpenStation;
        private Button btnStandby;
        private Button btnFollowShip;
        private Button btnHovering;
        private PictureBox pictureBox3;
        private Button btnTakeOff;
        private PictureBox pictureBox2;
        private Button btnLandAndStore;
        private Button btnLandSync;
        private Button btnStandbyLand;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnCLoseStation;
        private Panel panel1;
        private Button btnMotionSyncToDrone;
        private Button btnMotionSyncToSea;
        private Button btnMotionSyncToLand;
        private Label label59;
        private Button btnAltDown;
        private Button btnAltUp;
        private Button btnAutoReturn;
        private Button btnHoverAt100m;
        private Button btnAutoStart;
    }
}
