namespace CrdsView.Ucs.Configs
{
    partial class UcGSConfig
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
            this.SearchLight_Enable = new System.Windows.Forms.CheckBox();
            this.SpeakerControl_Enable = new System.Windows.Forms.CheckBox();
            this.CCTV_Enable = new System.Windows.Forms.CheckBox();
            this.ParachuteControl_Enable = new System.Windows.Forms.CheckBox();
            this.cbMap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbRTCMSourceSelect = new System.Windows.Forms.ComboBox();
            this.cbRTCMSourceBaudrate = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.udpClientPortTextBox = new System.Windows.Forms.TextBox();
            this.udpClientTextBox = new System.Windows.Forms.TextBox();
            this.udpClientCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sinkSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.sinkBaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.serialCheckBox = new System.Windows.Forms.CheckBox();
            this.overrideIDTextBox = new System.Windows.Forms.TextBox();
            this.overrideIDCheckBox = new System.Windows.Forms.CheckBox();
            this.m8pCheckBox = new System.Windows.Forms.CheckBox();
            this.m8pGroupBox = new System.Windows.Forms.GroupBox();
            this.dg_basepos = new System.Windows.Forms.DataGridView();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseposName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.savePositionButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.accTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.movingBaseCheckBox = new System.Windows.Forms.CheckBox();
            this.m8pFw130CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_svin5 = new System.Windows.Forms.Label();
            this.lbl_svin4 = new System.Windows.Forms.Label();
            this.lbl_svin3 = new System.Windows.Forms.Label();
            this.lbl_svin2 = new System.Windows.Forms.Label();
            this.lbl_svin1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16Galileo = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14BDS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_status3 = new System.Windows.Forms.Label();
            this.labelbase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelgps = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelglonass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signalStrengthHeaderLabel = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_status1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelmsgseen = new System.Windows.Forms.Label();
            this.lbl_status2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.m8pGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_basepos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchLight_Enable
            // 
            this.SearchLight_Enable.AutoSize = true;
            this.SearchLight_Enable.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchLight_Enable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SearchLight_Enable.Location = new System.Drawing.Point(30, 123);
            this.SearchLight_Enable.Name = "SearchLight_Enable";
            this.SearchLight_Enable.Size = new System.Drawing.Size(199, 21);
            this.SearchLight_Enable.TabIndex = 2;
            this.SearchLight_Enable.Text = "Search Light Control";
            this.SearchLight_Enable.UseVisualStyleBackColor = true;
            this.SearchLight_Enable.CheckedChanged += new System.EventHandler(this.SearchLight_Enable_CheckedChanged);
            // 
            // SpeakerControl_Enable
            // 
            this.SpeakerControl_Enable.AutoSize = true;
            this.SpeakerControl_Enable.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SpeakerControl_Enable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SpeakerControl_Enable.Location = new System.Drawing.Point(30, 27);
            this.SpeakerControl_Enable.Name = "SpeakerControl_Enable";
            this.SpeakerControl_Enable.Size = new System.Drawing.Size(162, 21);
            this.SpeakerControl_Enable.TabIndex = 4;
            this.SpeakerControl_Enable.Text = "Speaker Control";
            this.SpeakerControl_Enable.UseVisualStyleBackColor = true;
            this.SpeakerControl_Enable.CheckedChanged += new System.EventHandler(this.SpeakerControl_Enable_CheckedChanged);
            // 
            // CCTV_Enable
            // 
            this.CCTV_Enable.AutoSize = true;
            this.CCTV_Enable.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CCTV_Enable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CCTV_Enable.Location = new System.Drawing.Point(30, 54);
            this.CCTV_Enable.Name = "CCTV_Enable";
            this.CCTV_Enable.Size = new System.Drawing.Size(141, 21);
            this.CCTV_Enable.TabIndex = 5;
            this.CCTV_Enable.Text = "CCTV Control";
            this.CCTV_Enable.UseVisualStyleBackColor = true;
            this.CCTV_Enable.CheckedChanged += new System.EventHandler(this.CCTV_Enable_CheckedChanged);
            // 
            // ParachuteControl_Enable
            // 
            this.ParachuteControl_Enable.AutoSize = true;
            this.ParachuteControl_Enable.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ParachuteControl_Enable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ParachuteControl_Enable.Location = new System.Drawing.Point(30, 81);
            this.ParachuteControl_Enable.Name = "ParachuteControl_Enable";
            this.ParachuteControl_Enable.Size = new System.Drawing.Size(179, 21);
            this.ParachuteControl_Enable.TabIndex = 6;
            this.ParachuteControl_Enable.Text = "Parachute Control";
            this.ParachuteControl_Enable.UseVisualStyleBackColor = true;
            this.ParachuteControl_Enable.CheckedChanged += new System.EventHandler(this.ParachuteControl_Enable_CheckedChanged);
            // 
            // cbMap
            // 
            this.cbMap.FormattingEnabled = true;
            this.cbMap.Items.AddRange(new object[] {
            "기본",
            "종이해도",
            "전자해도",
            "해안경계선"});
            this.cbMap.Location = new System.Drawing.Point(376, 72);
            this.cbMap.Name = "cbMap";
            this.cbMap.Size = new System.Drawing.Size(212, 23);
            this.cbMap.TabIndex = 8;
            this.cbMap.SelectedIndexChanged += new System.EventHandler(this.cbMap_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "지도 선택";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "WGS-84";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(603, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "좌표계 선택";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "UTM-K";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbRTCMSourceSelect
            // 
            this.cbRTCMSourceSelect.FormattingEnabled = true;
            this.cbRTCMSourceSelect.Location = new System.Drawing.Point(21, 17);
            this.cbRTCMSourceSelect.Name = "cbRTCMSourceSelect";
            this.cbRTCMSourceSelect.Size = new System.Drawing.Size(212, 23);
            this.cbRTCMSourceSelect.TabIndex = 13;
            // 
            // cbRTCMSourceBaudrate
            // 
            this.cbRTCMSourceBaudrate.FormattingEnabled = true;
            this.cbRTCMSourceBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cbRTCMSourceBaudrate.Location = new System.Drawing.Point(21, 46);
            this.cbRTCMSourceBaudrate.Name = "cbRTCMSourceBaudrate";
            this.cbRTCMSourceBaudrate.Size = new System.Drawing.Size(212, 23);
            this.cbRTCMSourceBaudrate.TabIndex = 14;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(254, 28);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 27);
            this.buttonConnect.TabIndex = 36;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Controls.Add(this.cbRTCMSourceBaudrate);
            this.groupBox2.Controls.Add(this.cbRTCMSourceSelect);
            this.groupBox2.Location = new System.Drawing.Point(30, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 86);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RTCM Source";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(227, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 47;
            this.label14.Text = "Port:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 46;
            this.label13.Text = "Host IP:";
            // 
            // udpClientPortTextBox
            // 
            this.udpClientPortTextBox.Location = new System.Drawing.Point(231, 41);
            this.udpClientPortTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udpClientPortTextBox.Name = "udpClientPortTextBox";
            this.udpClientPortTextBox.Size = new System.Drawing.Size(67, 25);
            this.udpClientPortTextBox.TabIndex = 45;
            this.udpClientPortTextBox.Text = "14550";
            // 
            // udpClientTextBox
            // 
            this.udpClientTextBox.Location = new System.Drawing.Point(15, 41);
            this.udpClientTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udpClientTextBox.Name = "udpClientTextBox";
            this.udpClientTextBox.Size = new System.Drawing.Size(207, 25);
            this.udpClientTextBox.TabIndex = 43;
            this.udpClientTextBox.Text = "192.168.10.110";
            // 
            // udpClientCheckBox
            // 
            this.udpClientCheckBox.AutoSize = true;
            this.udpClientCheckBox.Location = new System.Drawing.Point(306, 45);
            this.udpClientCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.udpClientCheckBox.Name = "udpClientCheckBox";
            this.udpClientCheckBox.Size = new System.Drawing.Size(160, 19);
            this.udpClientCheckBox.TabIndex = 44;
            this.udpClientCheckBox.Text = "Use UDP client sink";
            this.udpClientCheckBox.UseVisualStyleBackColor = true;
            this.udpClientCheckBox.CheckedChanged += new System.EventHandler(this.udpClientCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sinkSelectorComboBox);
            this.groupBox3.Controls.Add(this.sinkBaudRateComboBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.serialCheckBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.udpClientPortTextBox);
            this.groupBox3.Controls.Add(this.udpClientTextBox);
            this.groupBox3.Controls.Add(this.udpClientCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(424, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 144);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RTCM Sink";
            // 
            // sinkSelectorComboBox
            // 
            this.sinkSelectorComboBox.FormattingEnabled = true;
            this.sinkSelectorComboBox.Location = new System.Drawing.Point(14, 86);
            this.sinkSelectorComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sinkSelectorComboBox.Name = "sinkSelectorComboBox";
            this.sinkSelectorComboBox.Size = new System.Drawing.Size(283, 23);
            this.sinkSelectorComboBox.TabIndex = 55;
            // 
            // sinkBaudRateComboBox
            // 
            this.sinkBaudRateComboBox.FormattingEnabled = true;
            this.sinkBaudRateComboBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "500000",
            "1000000"});
            this.sinkBaudRateComboBox.Location = new System.Drawing.Point(14, 117);
            this.sinkBaudRateComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sinkBaudRateComboBox.Name = "sinkBaudRateComboBox";
            this.sinkBaudRateComboBox.Size = new System.Drawing.Size(283, 23);
            this.sinkBaudRateComboBox.TabIndex = 56;
            // 
            // serialCheckBox
            // 
            this.serialCheckBox.AutoSize = true;
            this.serialCheckBox.Location = new System.Drawing.Point(306, 91);
            this.serialCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serialCheckBox.Name = "serialCheckBox";
            this.serialCheckBox.Size = new System.Drawing.Size(125, 19);
            this.serialCheckBox.TabIndex = 57;
            this.serialCheckBox.Text = "Use serial sink";
            this.serialCheckBox.UseVisualStyleBackColor = true;
            this.serialCheckBox.CheckedChanged += new System.EventHandler(this.serialCheckBox_CheckedChanged);
            // 
            // overrideIDTextBox
            // 
            this.overrideIDTextBox.Enabled = false;
            this.overrideIDTextBox.Location = new System.Drawing.Point(690, 504);
            this.overrideIDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.overrideIDTextBox.Name = "overrideIDTextBox";
            this.overrideIDTextBox.Size = new System.Drawing.Size(71, 25);
            this.overrideIDTextBox.TabIndex = 52;
            this.overrideIDTextBox.Text = "1";
            // 
            // overrideIDCheckBox
            // 
            this.overrideIDCheckBox.AutoSize = true;
            this.overrideIDCheckBox.Location = new System.Drawing.Point(448, 510);
            this.overrideIDCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overrideIDCheckBox.Name = "overrideIDCheckBox";
            this.overrideIDCheckBox.Size = new System.Drawing.Size(235, 19);
            this.overrideIDCheckBox.TabIndex = 51;
            this.overrideIDCheckBox.Text = "Override Station ID (max 4095)";
            this.overrideIDCheckBox.UseVisualStyleBackColor = true;
            this.overrideIDCheckBox.CheckedChanged += new System.EventHandler(this.overrideIDCheckBox_CheckedChanged);
            // 
            // m8pCheckBox
            // 
            this.m8pCheckBox.AutoSize = true;
            this.m8pCheckBox.Checked = true;
            this.m8pCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m8pCheckBox.Location = new System.Drawing.Point(40, 509);
            this.m8pCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m8pCheckBox.Name = "m8pCheckBox";
            this.m8pCheckBox.Size = new System.Drawing.Size(165, 19);
            this.m8pCheckBox.TabIndex = 50;
            this.m8pCheckBox.Text = "M8P/F9P autoconfig";
            this.m8pCheckBox.UseVisualStyleBackColor = true;
            this.m8pCheckBox.CheckedChanged += new System.EventHandler(this.m8pCheckBox_CheckedChanged);
            // 
            // m8pGroupBox
            // 
            this.m8pGroupBox.Controls.Add(this.dg_basepos);
            this.m8pGroupBox.Controls.Add(this.savePositionButton);
            this.m8pGroupBox.Controls.Add(this.restartButton);
            this.m8pGroupBox.Controls.Add(this.timeTextBox);
            this.m8pGroupBox.Controls.Add(this.label12);
            this.m8pGroupBox.Controls.Add(this.accTextBox);
            this.m8pGroupBox.Controls.Add(this.label11);
            this.m8pGroupBox.Controls.Add(this.movingBaseCheckBox);
            this.m8pGroupBox.Controls.Add(this.m8pFw130CheckBox);
            this.m8pGroupBox.Controls.Add(this.groupBox4);
            this.m8pGroupBox.Location = new System.Drawing.Point(38, 552);
            this.m8pGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m8pGroupBox.Name = "m8pGroupBox";
            this.m8pGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m8pGroupBox.Size = new System.Drawing.Size(831, 219);
            this.m8pGroupBox.TabIndex = 49;
            this.m8pGroupBox.TabStop = false;
            this.m8pGroupBox.Text = "M8P/F9P";
            this.m8pGroupBox.Visible = false;
            // 
            // dg_basepos
            // 
            this.dg_basepos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_basepos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lat,
            this.Lng,
            this.Alt,
            this.BaseposName,
            this.Use,
            this.Delete});
            this.dg_basepos.Location = new System.Drawing.Point(8, 80);
            this.dg_basepos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_basepos.Name = "dg_basepos";
            this.dg_basepos.RowHeadersWidth = 51;
            this.dg_basepos.Size = new System.Drawing.Size(613, 121);
            this.dg_basepos.TabIndex = 40;
            this.dg_basepos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dg_basepos_RowsRemoved);
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Lat/ECEFX";
            this.Lat.MinimumWidth = 6;
            this.Lat.Name = "Lat";
            this.Lat.Width = 70;
            // 
            // Lng
            // 
            this.Lng.HeaderText = "Lng/ECEFY";
            this.Lng.MinimumWidth = 6;
            this.Lng.Name = "Lng";
            this.Lng.Width = 70;
            // 
            // Alt
            // 
            this.Alt.HeaderText = "Alt/ECEFZ";
            this.Alt.MinimumWidth = 6;
            this.Alt.Name = "Alt";
            this.Alt.Width = 70;
            // 
            // BaseposName
            // 
            this.BaseposName.HeaderText = "Name";
            this.BaseposName.MinimumWidth = 6;
            this.BaseposName.Name = "BaseposName";
            this.BaseposName.Width = 125;
            // 
            // Use
            // 
            this.Use.HeaderText = "Use";
            this.Use.MinimumWidth = 6;
            this.Use.Name = "Use";
            this.Use.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // savePositionButton
            // 
            this.savePositionButton.Location = new System.Drawing.Point(409, 33);
            this.savePositionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savePositionButton.Name = "savePositionButton";
            this.savePositionButton.Size = new System.Drawing.Size(117, 39);
            this.savePositionButton.TabIndex = 39;
            this.savePositionButton.Text = "Save Current Position";
            this.savePositionButton.UseVisualStyleBackColor = true;
            this.savePositionButton.Click += new System.EventHandler(this.savePositionButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(301, 33);
            this.restartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(100, 39);
            this.restartButton.TabIndex = 38;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(251, 48);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(41, 25);
            this.timeTextBox.TabIndex = 37;
            this.timeTextBox.Text = "60";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 52);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Time(s)";
            // 
            // accTextBox
            // 
            this.accTextBox.Location = new System.Drawing.Point(129, 48);
            this.accTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accTextBox.Name = "accTextBox";
            this.accTextBox.Size = new System.Drawing.Size(49, 25);
            this.accTextBox.TabIndex = 35;
            this.accTextBox.Text = "2.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "SurveyIn Acc(m)";
            // 
            // movingBaseCheckBox
            // 
            this.movingBaseCheckBox.AutoSize = true;
            this.movingBaseCheckBox.Location = new System.Drawing.Point(165, 22);
            this.movingBaseCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.movingBaseCheckBox.Name = "movingBaseCheckBox";
            this.movingBaseCheckBox.Size = new System.Drawing.Size(116, 19);
            this.movingBaseCheckBox.TabIndex = 33;
            this.movingBaseCheckBox.Text = "Moving Base";
            this.movingBaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // m8pFw130CheckBox
            // 
            this.m8pFw130CheckBox.AutoSize = true;
            this.m8pFw130CheckBox.Checked = true;
            this.m8pFw130CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m8pFw130CheckBox.Location = new System.Drawing.Point(8, 22);
            this.m8pFw130CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m8pFw130CheckBox.Name = "m8pFw130CheckBox";
            this.m8pFw130CheckBox.Size = new System.Drawing.Size(147, 19);
            this.m8pFw130CheckBox.TabIndex = 32;
            this.m8pFw130CheckBox.Text = "M8P fw 130+/F9P";
            this.m8pFw130CheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_svin5);
            this.groupBox4.Controls.Add(this.lbl_svin4);
            this.groupBox4.Controls.Add(this.lbl_svin3);
            this.groupBox4.Controls.Add(this.lbl_svin2);
            this.groupBox4.Controls.Add(this.lbl_svin1);
            this.groupBox4.Location = new System.Drawing.Point(629, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(196, 198);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Survey In";
            // 
            // lbl_svin5
            // 
            this.lbl_svin5.AutoSize = true;
            this.lbl_svin5.Location = new System.Drawing.Point(8, 78);
            this.lbl_svin5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_svin5.Name = "lbl_svin5";
            this.lbl_svin5.Size = new System.Drawing.Size(53, 15);
            this.lbl_svin5.TabIndex = 4;
            this.lbl_svin5.Text = "label11";
            this.lbl_svin5.Visible = false;
            // 
            // lbl_svin4
            // 
            this.lbl_svin4.AutoSize = true;
            this.lbl_svin4.Location = new System.Drawing.Point(8, 63);
            this.lbl_svin4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_svin4.Name = "lbl_svin4";
            this.lbl_svin4.Size = new System.Drawing.Size(53, 15);
            this.lbl_svin4.TabIndex = 3;
            this.lbl_svin4.Text = "label11";
            this.lbl_svin4.Visible = false;
            // 
            // lbl_svin3
            // 
            this.lbl_svin3.AutoSize = true;
            this.lbl_svin3.Location = new System.Drawing.Point(8, 48);
            this.lbl_svin3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_svin3.Name = "lbl_svin3";
            this.lbl_svin3.Size = new System.Drawing.Size(53, 15);
            this.lbl_svin3.TabIndex = 2;
            this.lbl_svin3.Text = "label11";
            this.lbl_svin3.Visible = false;
            // 
            // lbl_svin2
            // 
            this.lbl_svin2.AutoSize = true;
            this.lbl_svin2.Location = new System.Drawing.Point(8, 33);
            this.lbl_svin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_svin2.Name = "lbl_svin2";
            this.lbl_svin2.Size = new System.Drawing.Size(53, 15);
            this.lbl_svin2.TabIndex = 1;
            this.lbl_svin2.Text = "label11";
            this.lbl_svin2.Visible = false;
            // 
            // lbl_svin1
            // 
            this.lbl_svin1.AutoSize = true;
            this.lbl_svin1.Location = new System.Drawing.Point(8, 18);
            this.lbl_svin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_svin1.Name = "lbl_svin1";
            this.lbl_svin1.Size = new System.Drawing.Size(53, 15);
            this.lbl_svin1.TabIndex = 0;
            this.lbl_svin1.Text = "label11";
            this.lbl_svin1.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox5.Controls.Add(this.label16Galileo);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label14BDS);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lbl_status3);
            this.groupBox5.Controls.Add(this.labelbase);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.labelgps);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.labelglonass);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(39, 398);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(830, 97);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RTCM";
            // 
            // label16Galileo
            // 
            this.label16Galileo.BackColor = System.Drawing.Color.Red;
            this.label16Galileo.ForeColor = System.Drawing.Color.White;
            this.label16Galileo.Location = new System.Drawing.Point(440, 30);
            this.label16Galileo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16Galileo.Name = "label16Galileo";
            this.label16Galileo.Size = new System.Drawing.Size(27, 23);
            this.label16Galileo.TabIndex = 31;
            this.label16Galileo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(379, 38);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 30;
            this.label17.Text = "Galileo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "RTCM Base";
            // 
            // label14BDS
            // 
            this.label14BDS.BackColor = System.Drawing.Color.Red;
            this.label14BDS.ForeColor = System.Drawing.Color.White;
            this.label14BDS.Location = new System.Drawing.Point(337, 30);
            this.label14BDS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14BDS.Name = "label14BDS";
            this.label14BDS.Size = new System.Drawing.Size(27, 23);
            this.label14BDS.TabIndex = 21;
            this.label14BDS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Base";
            // 
            // lbl_status3
            // 
            this.lbl_status3.AutoSize = true;
            this.lbl_status3.Location = new System.Drawing.Point(111, 66);
            this.lbl_status3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status3.Name = "lbl_status3";
            this.lbl_status3.Size = new System.Drawing.Size(328, 15);
            this.lbl_status3.TabIndex = 28;
            this.lbl_status3.Text = "-00.000000000 000.000000000 0000.000000000";
            // 
            // labelbase
            // 
            this.labelbase.BackColor = System.Drawing.Color.Red;
            this.labelbase.ForeColor = System.Drawing.Color.White;
            this.labelbase.Location = new System.Drawing.Point(61, 30);
            this.labelbase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbase.Name = "labelbase";
            this.labelbase.Size = new System.Drawing.Size(27, 23);
            this.labelbase.TabIndex = 15;
            this.labelbase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gps";
            // 
            // labelgps
            // 
            this.labelgps.BackColor = System.Drawing.Color.Red;
            this.labelgps.ForeColor = System.Drawing.Color.White;
            this.labelgps.Location = new System.Drawing.Point(139, 30);
            this.labelgps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelgps.Name = "labelgps";
            this.labelgps.Size = new System.Drawing.Size(27, 23);
            this.labelgps.TabIndex = 17;
            this.labelgps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Glonass";
            // 
            // labelglonass
            // 
            this.labelglonass.BackColor = System.Drawing.Color.Red;
            this.labelglonass.ForeColor = System.Drawing.Color.White;
            this.labelglonass.Location = new System.Drawing.Point(241, 30);
            this.labelglonass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelglonass.Name = "labelglonass";
            this.labelglonass.Size = new System.Drawing.Size(27, 23);
            this.labelglonass.TabIndex = 19;
            this.labelglonass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Beidou";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.signalStrengthHeaderLabel);
            this.panel1.Location = new System.Drawing.Point(881, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 735);
            this.panel1.TabIndex = 54;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // signalStrengthHeaderLabel
            // 
            this.signalStrengthHeaderLabel.AutoSize = true;
            this.signalStrengthHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signalStrengthHeaderLabel.Location = new System.Drawing.Point(17, 12);
            this.signalStrengthHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signalStrengthHeaderLabel.Name = "signalStrengthHeaderLabel";
            this.signalStrengthHeaderLabel.Size = new System.Drawing.Size(184, 20);
            this.signalStrengthHeaderLabel.TabIndex = 0;
            this.signalStrengthHeaderLabel.Text = "Satellite signal strength";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.lbl_status1);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.labelmsgseen);
            this.groupBox6.Controls.Add(this.lbl_status2);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(42, 296);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(836, 88);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Link Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Input data rate";
            // 
            // lbl_status1
            // 
            this.lbl_status1.Location = new System.Drawing.Point(127, 20);
            this.lbl_status1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status1.Name = "lbl_status1";
            this.lbl_status1.Size = new System.Drawing.Size(93, 15);
            this.lbl_status1.TabIndex = 23;
            this.lbl_status1.Text = "label6";
            this.lbl_status1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Output data rate (per channel)";
            // 
            // labelmsgseen
            // 
            this.labelmsgseen.Location = new System.Drawing.Point(131, 45);
            this.labelmsgseen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmsgseen.Name = "labelmsgseen";
            this.labelmsgseen.Size = new System.Drawing.Size(696, 39);
            this.labelmsgseen.TabIndex = 27;
            this.labelmsgseen.Text = "label10";
            // 
            // lbl_status2
            // 
            this.lbl_status2.Location = new System.Drawing.Point(449, 18);
            this.lbl_status2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status2.Name = "lbl_status2";
            this.lbl_status2.Size = new System.Drawing.Size(93, 15);
            this.lbl_status2.TabIndex = 25;
            this.lbl_status2.Text = "label6";
            this.lbl_status2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Messages Seen";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UcGSConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.overrideIDTextBox);
            this.Controls.Add(this.overrideIDCheckBox);
            this.Controls.Add(this.m8pCheckBox);
            this.Controls.Add(this.m8pGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMap);
            this.Controls.Add(this.ParachuteControl_Enable);
            this.Controls.Add(this.CCTV_Enable);
            this.Controls.Add(this.SpeakerControl_Enable);
            this.Controls.Add(this.SearchLight_Enable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcGSConfig";
            this.Size = new System.Drawing.Size(1153, 788);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.m8pGroupBox.ResumeLayout(false);
            this.m8pGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_basepos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox SearchLight_Enable;
        private System.Windows.Forms.CheckBox SpeakerControl_Enable;
        private System.Windows.Forms.CheckBox CCTV_Enable;
        private System.Windows.Forms.CheckBox ParachuteControl_Enable;
        private System.Windows.Forms.ComboBox cbMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbRTCMSourceSelect;
        private System.Windows.Forms.ComboBox cbRTCMSourceBaudrate;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox udpClientPortTextBox;
        private System.Windows.Forms.TextBox udpClientTextBox;
        private System.Windows.Forms.CheckBox udpClientCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox overrideIDTextBox;
        private System.Windows.Forms.CheckBox overrideIDCheckBox;
        private System.Windows.Forms.CheckBox m8pCheckBox;
        private System.Windows.Forms.GroupBox m8pGroupBox;
        private System.Windows.Forms.DataGridView dg_basepos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseposName;
        private System.Windows.Forms.DataGridViewButtonColumn Use;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button savePositionButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox accTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox movingBaseCheckBox;
        private System.Windows.Forms.CheckBox m8pFw130CheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_svin5;
        private System.Windows.Forms.Label lbl_svin4;
        private System.Windows.Forms.Label lbl_svin3;
        private System.Windows.Forms.Label lbl_svin2;
        private System.Windows.Forms.Label lbl_svin1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16Galileo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14BDS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_status3;
        private System.Windows.Forms.Label labelbase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelgps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelglonass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signalStrengthHeaderLabel;
        private System.Windows.Forms.ComboBox sinkSelectorComboBox;
        private System.Windows.Forms.ComboBox sinkBaudRateComboBox;
        private System.Windows.Forms.CheckBox serialCheckBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_status1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelmsgseen;
        private System.Windows.Forms.Label lbl_status2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}
