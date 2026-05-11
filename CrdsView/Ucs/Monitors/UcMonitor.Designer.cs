namespace CrdsView.Ucs.Monitors
{
    partial class UcMonitor
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
            this.ButtonArm = new System.Windows.Forms.Button();
            this.ButtonTakeOff = new System.Windows.Forms.Button();
            this.ButtonTargetFollow = new System.Windows.Forms.Button();
            this.LabelFlightPlan = new System.Windows.Forms.Label();
            this.ButtonLand = new System.Windows.Forms.Button();
            this.LabelPlanTab = new System.Windows.Forms.Label();
            this.LabelHud = new System.Windows.Forms.Label();
            this.ButtonAltHold = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonDisArm = new System.Windows.Forms.Button();
            this.btn_Stabilizer = new System.Windows.Forms.Button();
            this.btn_Hold = new System.Windows.Forms.Button();
            this.btn_Arm = new System.Windows.Forms.Button();
            this.btn_DisArm = new System.Windows.Forms.Button();
            this.btn_TakeOff = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tb_Altitude = new System.Windows.Forms.TextBox();
            this.btn_Altitude = new System.Windows.Forms.Button();
            this.btn_Land = new System.Windows.Forms.Button();
            this.btn_NoCon = new System.Windows.Forms.Button();
            this.btn_AP1 = new System.Windows.Forms.Button();
            this.btn_AP2 = new System.Windows.Forms.Button();
            this.btn_AP3 = new System.Windows.Forms.Button();
            this.btn_AP4 = new System.Windows.Forms.Button();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.lblHudShow = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonArm
            // 
            this.ButtonArm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonArm.AutoSize = true;
            this.ButtonArm.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonArm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonArm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonArm.Location = new System.Drawing.Point(106, 2);
            this.ButtonArm.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonArm.Name = "ButtonArm";
            this.ButtonArm.Size = new System.Drawing.Size(112, 113);
            this.ButtonArm.TabIndex = 0;
            this.ButtonArm.Text = "Arm";
            this.ButtonArm.UseVisualStyleBackColor = false;
            this.ButtonArm.Click += new System.EventHandler(this.ButtonArm_Click);
            // 
            // ButtonTakeOff
            // 
            this.ButtonTakeOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTakeOff.AutoSize = true;
            this.ButtonTakeOff.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonTakeOff.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonTakeOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonTakeOff.Location = new System.Drawing.Point(575, 2);
            this.ButtonTakeOff.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonTakeOff.Name = "ButtonTakeOff";
            this.ButtonTakeOff.Size = new System.Drawing.Size(150, 113);
            this.ButtonTakeOff.TabIndex = 0;
            this.ButtonTakeOff.Text = "Take off";
            this.ButtonTakeOff.UseVisualStyleBackColor = false;
            this.ButtonTakeOff.Click += new System.EventHandler(this.ButtonTakeOff_Click);
            // 
            // ButtonTargetFollow
            // 
            this.ButtonTargetFollow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTargetFollow.AutoSize = true;
            this.ButtonTargetFollow.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonTargetFollow.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonTargetFollow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonTargetFollow.Location = new System.Drawing.Point(346, 2);
            this.ButtonTargetFollow.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonTargetFollow.Name = "ButtonTargetFollow";
            this.ButtonTargetFollow.Size = new System.Drawing.Size(225, 113);
            this.ButtonTargetFollow.TabIndex = 0;
            this.ButtonTargetFollow.Text = "Target Follow";
            this.ButtonTargetFollow.UseVisualStyleBackColor = false;
            this.ButtonTargetFollow.Click += new System.EventHandler(this.ButtonTargetFollow_Click);
            // 
            // LabelFlightPlan
            // 
            this.LabelFlightPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFlightPlan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelFlightPlan.Location = new System.Drawing.Point(2365, 535);
            this.LabelFlightPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFlightPlan.Name = "LabelFlightPlan";
            this.LabelFlightPlan.Size = new System.Drawing.Size(242, 1355);
            this.LabelFlightPlan.TabIndex = 7;
            this.LabelFlightPlan.Text = "Fight Plan";
            // 
            // ButtonLand
            // 
            this.ButtonLand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLand.AutoSize = true;
            this.ButtonLand.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonLand.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonLand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonLand.Location = new System.Drawing.Point(2, 2);
            this.ButtonLand.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLand.Name = "ButtonLand";
            this.ButtonLand.Size = new System.Drawing.Size(100, 113);
            this.ButtonLand.TabIndex = 8;
            this.ButtonLand.Text = "Land";
            this.ButtonLand.UseVisualStyleBackColor = false;
            this.ButtonLand.Click += new System.EventHandler(this.ButtonLand_Click);
            // 
            // LabelPlanTab
            // 
            this.LabelPlanTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPlanTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelPlanTab.Location = new System.Drawing.Point(2571, 211);
            this.LabelPlanTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPlanTab.Name = "LabelPlanTab";
            this.LabelPlanTab.Size = new System.Drawing.Size(51, 1532);
            this.LabelPlanTab.TabIndex = 11;
            this.LabelPlanTab.Text = "flight plan";
            this.LabelPlanTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelHud
            // 
            this.LabelHud.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelHud.BackColor = System.Drawing.Color.Transparent;
            this.LabelHud.Location = new System.Drawing.Point(435, 1721);
            this.LabelHud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHud.Name = "LabelHud";
            this.LabelHud.Size = new System.Drawing.Size(579, 348);
            this.LabelHud.TabIndex = 12;
            this.LabelHud.Text = "label1";
            // 
            // ButtonAltHold
            // 
            this.ButtonAltHold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAltHold.AutoSize = true;
            this.ButtonAltHold.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonAltHold.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAltHold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonAltHold.Location = new System.Drawing.Point(729, 2);
            this.ButtonAltHold.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAltHold.Name = "ButtonAltHold";
            this.ButtonAltHold.Size = new System.Drawing.Size(150, 113);
            this.ButtonAltHold.TabIndex = 47;
            this.ButtonAltHold.Text = "Alt Hold";
            this.ButtonAltHold.UseVisualStyleBackColor = false;
            this.ButtonAltHold.Click += new System.EventHandler(this.ButtonAltHold_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.ButtonLand);
            this.flowLayoutPanel1.Controls.Add(this.ButtonArm);
            this.flowLayoutPanel1.Controls.Add(this.ButtonDisArm);
            this.flowLayoutPanel1.Controls.Add(this.ButtonTargetFollow);
            this.flowLayoutPanel1.Controls.Add(this.ButtonTakeOff);
            this.flowLayoutPanel1.Controls.Add(this.ButtonAltHold);
            this.flowLayoutPanel1.Controls.Add(this.btn_Stabilizer);
            this.flowLayoutPanel1.Controls.Add(this.btn_Hold);
            this.flowLayoutPanel1.Controls.Add(this.btn_Arm);
            this.flowLayoutPanel1.Controls.Add(this.btn_DisArm);
            this.flowLayoutPanel1.Controls.Add(this.btn_TakeOff);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.tb_Altitude);
            this.flowLayoutPanel1.Controls.Add(this.btn_Altitude);
            this.flowLayoutPanel1.Controls.Add(this.btn_Land);
            this.flowLayoutPanel1.Controls.Add(this.btn_NoCon);
            this.flowLayoutPanel1.Controls.Add(this.btn_AP1);
            this.flowLayoutPanel1.Controls.Add(this.btn_AP2);
            this.flowLayoutPanel1.Controls.Add(this.btn_AP3);
            this.flowLayoutPanel1.Controls.Add(this.btn_AP4);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1159, 1363);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(893, 360);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // ButtonDisArm
            // 
            this.ButtonDisArm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDisArm.AutoSize = true;
            this.ButtonDisArm.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonDisArm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonDisArm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButtonDisArm.Location = new System.Drawing.Point(222, 2);
            this.ButtonDisArm.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDisArm.Name = "ButtonDisArm";
            this.ButtonDisArm.Size = new System.Drawing.Size(120, 113);
            this.ButtonDisArm.TabIndex = 48;
            this.ButtonDisArm.Text = "DisArm";
            this.ButtonDisArm.UseVisualStyleBackColor = false;
            this.ButtonDisArm.Click += new System.EventHandler(this.ButtonDisArm_Click);
            // 
            // btn_Stabilizer
            // 
            this.btn_Stabilizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stabilizer.AutoSize = true;
            this.btn_Stabilizer.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Stabilizer.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Stabilizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Stabilizer.Location = new System.Drawing.Point(2, 121);
            this.btn_Stabilizer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Stabilizer.Name = "btn_Stabilizer";
            this.btn_Stabilizer.Size = new System.Drawing.Size(72, 113);
            this.btn_Stabilizer.TabIndex = 49;
            this.btn_Stabilizer.Text = "Stab";
            this.btn_Stabilizer.UseVisualStyleBackColor = false;
            this.btn_Stabilizer.Click += new System.EventHandler(this.btn_Stabilizer_Click);
            // 
            // btn_Hold
            // 
            this.btn_Hold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Hold.AutoSize = true;
            this.btn_Hold.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Hold.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Hold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Hold.Location = new System.Drawing.Point(78, 121);
            this.btn_Hold.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Hold.Name = "btn_Hold";
            this.btn_Hold.Size = new System.Drawing.Size(70, 113);
            this.btn_Hold.TabIndex = 50;
            this.btn_Hold.Text = "Hold";
            this.btn_Hold.UseVisualStyleBackColor = false;
            this.btn_Hold.Click += new System.EventHandler(this.btn_Hold_Click);
            // 
            // btn_Arm
            // 
            this.btn_Arm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Arm.AutoSize = true;
            this.btn_Arm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Arm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Arm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Arm.Location = new System.Drawing.Point(152, 121);
            this.btn_Arm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Arm.Name = "btn_Arm";
            this.btn_Arm.Size = new System.Drawing.Size(112, 113);
            this.btn_Arm.TabIndex = 51;
            this.btn_Arm.Text = "Arm";
            this.btn_Arm.UseVisualStyleBackColor = false;
            this.btn_Arm.Click += new System.EventHandler(this.btn_Arm_Click);
            // 
            // btn_DisArm
            // 
            this.btn_DisArm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DisArm.AutoSize = true;
            this.btn_DisArm.BackColor = System.Drawing.Color.Gray;
            this.btn_DisArm.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DisArm.ForeColor = System.Drawing.Color.White;
            this.btn_DisArm.Location = new System.Drawing.Point(268, 121);
            this.btn_DisArm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DisArm.Name = "btn_DisArm";
            this.btn_DisArm.Size = new System.Drawing.Size(100, 113);
            this.btn_DisArm.TabIndex = 52;
            this.btn_DisArm.Text = "DisArm";
            this.btn_DisArm.UseVisualStyleBackColor = false;
            this.btn_DisArm.Click += new System.EventHandler(this.btn_DisArm_Click);
            // 
            // btn_TakeOff
            // 
            this.btn_TakeOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TakeOff.AutoSize = true;
            this.btn_TakeOff.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_TakeOff.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TakeOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_TakeOff.Location = new System.Drawing.Point(372, 121);
            this.btn_TakeOff.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TakeOff.Name = "btn_TakeOff";
            this.btn_TakeOff.Size = new System.Drawing.Size(112, 113);
            this.btn_TakeOff.TabIndex = 53;
            this.btn_TakeOff.Text = "TakeOff";
            this.btn_TakeOff.UseVisualStyleBackColor = false;
            this.btn_TakeOff.Click += new System.EventHandler(this.btn_TakeOff_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(488, 121);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 113);
            this.button6.TabIndex = 54;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_Altitude
            // 
            this.tb_Altitude.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Altitude.Location = new System.Drawing.Point(553, 120);
            this.tb_Altitude.Multiline = true;
            this.tb_Altitude.Name = "tb_Altitude";
            this.tb_Altitude.Size = new System.Drawing.Size(80, 113);
            this.tb_Altitude.TabIndex = 58;
            this.tb_Altitude.Text = "10";
            this.tb_Altitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Altitude
            // 
            this.btn_Altitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Altitude.AutoSize = true;
            this.btn_Altitude.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Altitude.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Altitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Altitude.Location = new System.Drawing.Point(638, 121);
            this.btn_Altitude.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Altitude.Name = "btn_Altitude";
            this.btn_Altitude.Size = new System.Drawing.Size(112, 113);
            this.btn_Altitude.TabIndex = 59;
            this.btn_Altitude.Text = "Alt";
            this.btn_Altitude.UseVisualStyleBackColor = false;
            this.btn_Altitude.Click += new System.EventHandler(this.btn_Altitude_Click);
            // 
            // btn_Land
            // 
            this.btn_Land.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Land.AutoSize = true;
            this.btn_Land.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Land.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Land.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Land.Location = new System.Drawing.Point(754, 121);
            this.btn_Land.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Land.Name = "btn_Land";
            this.btn_Land.Size = new System.Drawing.Size(112, 113);
            this.btn_Land.TabIndex = 60;
            this.btn_Land.Text = "Land";
            this.btn_Land.UseVisualStyleBackColor = false;
            this.btn_Land.Click += new System.EventHandler(this.btn_Land_Click);
            // 
            // btn_NoCon
            // 
            this.btn_NoCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NoCon.AutoSize = true;
            this.btn_NoCon.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_NoCon.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_NoCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_NoCon.Location = new System.Drawing.Point(2, 238);
            this.btn_NoCon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NoCon.Name = "btn_NoCon";
            this.btn_NoCon.Size = new System.Drawing.Size(129, 113);
            this.btn_NoCon.TabIndex = 61;
            this.btn_NoCon.Text = "추종 중지";
            this.btn_NoCon.UseVisualStyleBackColor = false;
            this.btn_NoCon.Click += new System.EventHandler(this.btn_NoCon_Click);
            // 
            // btn_AP1
            // 
            this.btn_AP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AP1.AutoSize = true;
            this.btn_AP1.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_AP1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_AP1.Location = new System.Drawing.Point(135, 238);
            this.btn_AP1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AP1.Name = "btn_AP1";
            this.btn_AP1.Size = new System.Drawing.Size(112, 113);
            this.btn_AP1.TabIndex = 62;
            this.btn_AP1.Text = "AP1";
            this.btn_AP1.UseVisualStyleBackColor = false;
            this.btn_AP1.Click += new System.EventHandler(this.btn_AP1_Click);
            // 
            // btn_AP2
            // 
            this.btn_AP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AP2.AutoSize = true;
            this.btn_AP2.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_AP2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_AP2.Location = new System.Drawing.Point(251, 238);
            this.btn_AP2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AP2.Name = "btn_AP2";
            this.btn_AP2.Size = new System.Drawing.Size(112, 113);
            this.btn_AP2.TabIndex = 63;
            this.btn_AP2.Text = "AP2";
            this.btn_AP2.UseVisualStyleBackColor = false;
            this.btn_AP2.Click += new System.EventHandler(this.btn_AP2_Click);
            // 
            // btn_AP3
            // 
            this.btn_AP3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AP3.AutoSize = true;
            this.btn_AP3.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_AP3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AP3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_AP3.Location = new System.Drawing.Point(367, 238);
            this.btn_AP3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AP3.Name = "btn_AP3";
            this.btn_AP3.Size = new System.Drawing.Size(112, 113);
            this.btn_AP3.TabIndex = 64;
            this.btn_AP3.Text = "AP3";
            this.btn_AP3.UseVisualStyleBackColor = false;
            this.btn_AP3.Click += new System.EventHandler(this.btn_AP3_Click);
            // 
            // btn_AP4
            // 
            this.btn_AP4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AP4.AutoSize = true;
            this.btn_AP4.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_AP4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AP4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_AP4.Location = new System.Drawing.Point(483, 238);
            this.btn_AP4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AP4.Name = "btn_AP4";
            this.btn_AP4.Size = new System.Drawing.Size(112, 113);
            this.btn_AP4.TabIndex = 65;
            this.btn_AP4.Text = "AP4";
            this.btn_AP4.UseVisualStyleBackColor = false;
            this.btn_AP4.Click += new System.EventHandler(this.btn_AP4_Click);
            // 
            // lblHudShow
            // 
            this.lblHudShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHudShow.BackColor = System.Drawing.Color.GreenYellow;
            this.lblHudShow.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHudShow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHudShow.Location = new System.Drawing.Point(891, 1679);
            this.lblHudShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHudShow.Name = "lblHudShow";
            this.lblHudShow.Size = new System.Drawing.Size(241, 42);
            this.lblHudShow.TabIndex = 61;
            this.lblHudShow.Text = "HUD";
            this.lblHudShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHudShow.Click += new System.EventHandler(this.lblHudShow_Click);
            // 
            // UcMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblHudShow);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LabelHud);
            this.Controls.Add(this.LabelPlanTab);
            this.Controls.Add(this.LabelFlightPlan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcMonitor";
            this.Size = new System.Drawing.Size(2041, 1723);
            this.Load += new System.EventHandler(this.UcMonitor_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UcMonitor_MouseMove);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonArm;
        private System.Windows.Forms.Button ButtonTakeOff;
        private System.Windows.Forms.Button ButtonTargetFollow;
        private System.Windows.Forms.Label LabelFlightPlan;
        private System.Windows.Forms.Button ButtonLand;
        private System.Windows.Forms.Label LabelPlanTab;
        private System.Windows.Forms.Label LabelHud;
        private System.Windows.Forms.Button ButtonAltHold;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timerSlide;
        private System.Windows.Forms.Label lblHudShow;
        private System.Windows.Forms.Button ButtonDisArm;
        private System.Windows.Forms.Button btn_Stabilizer;
        private System.Windows.Forms.Button btn_Hold;
        private System.Windows.Forms.Button btn_Arm;
        private System.Windows.Forms.Button btn_DisArm;
        private System.Windows.Forms.Button btn_TakeOff;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tb_Altitude;
        private System.Windows.Forms.Button btn_Altitude;
        private System.Windows.Forms.Button btn_Land;
        private System.Windows.Forms.Button btn_NoCon;
        private System.Windows.Forms.Button btn_AP1;
        private System.Windows.Forms.Button btn_AP2;
        private System.Windows.Forms.Button btn_AP3;
        private System.Windows.Forms.Button btn_AP4;
    }
}
