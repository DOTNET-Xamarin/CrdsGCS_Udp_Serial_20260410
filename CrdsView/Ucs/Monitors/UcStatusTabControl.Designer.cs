using System;
using System.Windows.Forms;

namespace CrdsView.Ucs.Monitors
{
    partial class UcStatusTabControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMainMotorPower = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMainMotorRpm = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblControlMotor4Power = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblControlMotor4Rpm = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblControlMotor2Power = new System.Windows.Forms.Label();
            this.lblControlMotor2Rpm = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listboxMessage = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblControlMotor3Power = new System.Windows.Forms.Label();
            this.lblControlMotor3Rpm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblControlMotor1Power = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblControlMotor1Rpm = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.labelShipBaroTemerature = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblShipBaroAltitude = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblShipBaroPressure = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShipPitch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblShipRoll = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblShipHeading = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblHhipTurnRate = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblShipAcceleration = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblShipTrueNorth = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblShipMagNorth = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblShipNorth = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.lblFailsafe = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblRCInputStatus = new System.Windows.Forms.Label();
            this.lblArmingSatus = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblFlightMode = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCompassStatus = new System.Windows.Forms.Label();
            this.lblImuTemperature = new System.Windows.Forms.Label();
            this.lblVibrationStatus = new System.Windows.Forms.Label();
            this.lblAccelGyroStatus = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.lblEKFStatus = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.lblBattery2 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.lblBatteryRemaining = new System.Windows.Forms.Label();
            this.lblBatteryConsumed = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.lblBatteryVoltageAndCurrent = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExtBytesReceived = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.lblExtComBytesSent = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.lblExtComBaudrate = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lblExtComStatus = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ItemSize = new System.Drawing.Size(108, 32);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 470);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(517, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "드론 상태";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listboxMessage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 426);
            this.tableLayoutPanel1.TabIndex = 59;
            // 
            // groupBox7
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox7, 2);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.lblMainMotorPower);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.lblMainMotorRpm);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox7.Size = new System.Drawing.Size(507, 72);
            this.groupBox7.TabIndex = 60;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "메인 모터";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "kW";
            // 
            // lblMainMotorPower
            // 
            this.lblMainMotorPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblMainMotorPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainMotorPower.Location = new System.Drawing.Point(182, 42);
            this.lblMainMotorPower.Name = "lblMainMotorPower";
            this.lblMainMotorPower.Size = new System.Drawing.Size(126, 28);
            this.lblMainMotorPower.TabIndex = 21;
            this.lblMainMotorPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "RPM";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblMainMotorRpm
            // 
            this.lblMainMotorRpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblMainMotorRpm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainMotorRpm.Location = new System.Drawing.Point(182, 12);
            this.lblMainMotorRpm.Name = "lblMainMotorRpm";
            this.lblMainMotorRpm.Size = new System.Drawing.Size(126, 28);
            this.lblMainMotorRpm.TabIndex = 18;
            this.lblMainMotorRpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.lblControlMotor4Power);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.lblControlMotor4Rpm);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(258, 79);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox9.Size = new System.Drawing.Size(252, 86);
            this.groupBox9.TabIndex = 61;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "제어 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "kW";
            // 
            // lblControlMotor4Power
            // 
            this.lblControlMotor4Power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor4Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor4Power.Location = new System.Drawing.Point(16, 52);
            this.lblControlMotor4Power.Name = "lblControlMotor4Power";
            this.lblControlMotor4Power.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor4Power.TabIndex = 46;
            this.lblControlMotor4Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "RPM";
            // 
            // lblControlMotor4Rpm
            // 
            this.lblControlMotor4Rpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor4Rpm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor4Rpm.Location = new System.Drawing.Point(16, 22);
            this.lblControlMotor4Rpm.Name = "lblControlMotor4Rpm";
            this.lblControlMotor4Rpm.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor4Rpm.TabIndex = 44;
            this.lblControlMotor4Rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblControlMotor2Power);
            this.groupBox5.Controls.Add(this.lblControlMotor2Rpm);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 169);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox5.Size = new System.Drawing.Size(251, 86);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "제어 2";
            // 
            // lblControlMotor2Power
            // 
            this.lblControlMotor2Power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor2Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor2Power.Location = new System.Drawing.Point(16, 52);
            this.lblControlMotor2Power.Name = "lblControlMotor2Power";
            this.lblControlMotor2Power.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor2Power.TabIndex = 51;
            this.lblControlMotor2Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlMotor2Rpm
            // 
            this.lblControlMotor2Rpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor2Rpm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor2Rpm.Location = new System.Drawing.Point(16, 22);
            this.lblControlMotor2Rpm.Name = "lblControlMotor2Rpm";
            this.lblControlMotor2Rpm.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor2Rpm.TabIndex = 49;
            this.lblControlMotor2Rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(136, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "RPM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "kW";
            // 
            // listboxMessage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listboxMessage, 2);
            this.listboxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxMessage.FormattingEnabled = true;
            this.listboxMessage.ItemHeight = 20;
            this.listboxMessage.Location = new System.Drawing.Point(3, 259);
            this.listboxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.listboxMessage.Name = "listboxMessage";
            this.listboxMessage.Size = new System.Drawing.Size(507, 164);
            this.listboxMessage.TabIndex = 58;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblControlMotor3Power);
            this.groupBox6.Controls.Add(this.lblControlMotor3Rpm);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 79);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox6.Size = new System.Drawing.Size(251, 86);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "제어 3";
            // 
            // lblControlMotor3Power
            // 
            this.lblControlMotor3Power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor3Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor3Power.Location = new System.Drawing.Point(16, 54);
            this.lblControlMotor3Power.Name = "lblControlMotor3Power";
            this.lblControlMotor3Power.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor3Power.TabIndex = 41;
            this.lblControlMotor3Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlMotor3Rpm
            // 
            this.lblControlMotor3Rpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor3Rpm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor3Rpm.Location = new System.Drawing.Point(16, 24);
            this.lblControlMotor3Rpm.Name = "lblControlMotor3Rpm";
            this.lblControlMotor3Rpm.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor3Rpm.TabIndex = 39;
            this.lblControlMotor3Rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "RPM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "kW";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.lblControlMotor1Power);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.lblControlMotor1Rpm);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(258, 169);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox8.Size = new System.Drawing.Size(252, 86);
            this.groupBox8.TabIndex = 61;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "제어 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "kW";
            // 
            // lblControlMotor1Power
            // 
            this.lblControlMotor1Power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor1Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor1Power.Location = new System.Drawing.Point(16, 52);
            this.lblControlMotor1Power.Name = "lblControlMotor1Power";
            this.lblControlMotor1Power.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor1Power.TabIndex = 56;
            this.lblControlMotor1Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "RPM";
            // 
            // lblControlMotor1Rpm
            // 
            this.lblControlMotor1Rpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblControlMotor1Rpm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlMotor1Rpm.Location = new System.Drawing.Point(16, 22);
            this.lblControlMotor1Rpm.Name = "lblControlMotor1Rpm";
            this.lblControlMotor1Rpm.Size = new System.Drawing.Size(110, 28);
            this.lblControlMotor1Rpm.TabIndex = 54;
            this.lblControlMotor1Rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(517, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "선박 상태";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox14, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox11, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox12, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox13, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 426);
            this.tableLayoutPanel2.TabIndex = 56;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label28);
            this.groupBox14.Controls.Add(this.labelShipBaroTemerature);
            this.groupBox14.Controls.Add(this.label30);
            this.groupBox14.Controls.Add(this.lblShipBaroAltitude);
            this.groupBox14.Controls.Add(this.label32);
            this.groupBox14.Controls.Add(this.lblShipBaroPressure);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(258, 285);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox14.Size = new System.Drawing.Size(252, 138);
            this.groupBox14.TabIndex = 55;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "기압계";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 96);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 20);
            this.label28.TabIndex = 50;
            this.label28.Text = "온도";
            // 
            // labelShipBaroTemerature
            // 
            this.labelShipBaroTemerature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.labelShipBaroTemerature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShipBaroTemerature.Location = new System.Drawing.Point(92, 92);
            this.labelShipBaroTemerature.Name = "labelShipBaroTemerature";
            this.labelShipBaroTemerature.Size = new System.Drawing.Size(118, 28);
            this.labelShipBaroTemerature.TabIndex = 49;
            this.labelShipBaroTemerature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 58);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(69, 20);
            this.label30.TabIndex = 48;
            this.label30.Text = "기압고도";
            // 
            // lblShipBaroAltitude
            // 
            this.lblShipBaroAltitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipBaroAltitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipBaroAltitude.Location = new System.Drawing.Point(92, 54);
            this.lblShipBaroAltitude.Name = "lblShipBaroAltitude";
            this.lblShipBaroAltitude.Size = new System.Drawing.Size(118, 28);
            this.lblShipBaroAltitude.TabIndex = 47;
            this.lblShipBaroAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 20);
            this.label32.TabIndex = 46;
            this.label32.Text = "기압";
            // 
            // lblShipBaroPressure
            // 
            this.lblShipBaroPressure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipBaroPressure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipBaroPressure.Location = new System.Drawing.Point(92, 16);
            this.lblShipBaroPressure.Name = "lblShipBaroPressure";
            this.lblShipBaroPressure.Size = new System.Drawing.Size(118, 28);
            this.lblShipBaroPressure.TabIndex = 45;
            this.lblShipBaroPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.lblShipPitch);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.lblShipRoll);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.lblShipHeading);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.tableLayoutPanel2.SetRowSpan(this.groupBox10, 2);
            this.groupBox10.Size = new System.Drawing.Size(251, 278);
            this.groupBox10.TabIndex = 51;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "자세 정보";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Pitch";
            // 
            // lblShipPitch
            // 
            this.lblShipPitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipPitch.Location = new System.Drawing.Point(102, 108);
            this.lblShipPitch.Name = "lblShipPitch";
            this.lblShipPitch.Size = new System.Drawing.Size(118, 28);
            this.lblShipPitch.TabIndex = 28;
            this.lblShipPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Roll";
            // 
            // lblShipRoll
            // 
            this.lblShipRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipRoll.Location = new System.Drawing.Point(102, 68);
            this.lblShipRoll.Name = "lblShipRoll";
            this.lblShipRoll.Size = new System.Drawing.Size(118, 28);
            this.lblShipRoll.TabIndex = 26;
            this.lblShipRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 20);
            this.label19.TabIndex = 25;
            this.label19.Text = "Heading";
            // 
            // lblShipHeading
            // 
            this.lblShipHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipHeading.Location = new System.Drawing.Point(102, 28);
            this.lblShipHeading.Name = "lblShipHeading";
            this.lblShipHeading.Size = new System.Drawing.Size(118, 28);
            this.lblShipHeading.TabIndex = 24;
            this.lblShipHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.lblHhipTurnRate);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(258, 3);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox11.Size = new System.Drawing.Size(252, 137);
            this.groupBox11.TabIndex = 52;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "자이로 정보";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "선회율";
            // 
            // lblHhipTurnRate
            // 
            this.lblHhipTurnRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblHhipTurnRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHhipTurnRate.Location = new System.Drawing.Point(92, 46);
            this.lblHhipTurnRate.Name = "lblHhipTurnRate";
            this.lblHhipTurnRate.Size = new System.Drawing.Size(118, 28);
            this.lblHhipTurnRate.TabIndex = 38;
            this.lblHhipTurnRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.lblShipAcceleration);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(258, 144);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox12.Size = new System.Drawing.Size(252, 137);
            this.groupBox12.TabIndex = 53;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "가속도계";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 20);
            this.label22.TabIndex = 42;
            this.label22.Text = "가속도";
            // 
            // lblShipAcceleration
            // 
            this.lblShipAcceleration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipAcceleration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipAcceleration.Location = new System.Drawing.Point(92, 44);
            this.lblShipAcceleration.Name = "lblShipAcceleration";
            this.lblShipAcceleration.Size = new System.Drawing.Size(118, 28);
            this.lblShipAcceleration.TabIndex = 41;
            this.lblShipAcceleration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.lblShipTrueNorth);
            this.groupBox13.Controls.Add(this.label20);
            this.groupBox13.Controls.Add(this.lblShipMagNorth);
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.lblShipNorth);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(3, 285);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox13.Size = new System.Drawing.Size(251, 138);
            this.groupBox13.TabIndex = 54;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "자력계";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "진북";
            // 
            // lblShipTrueNorth
            // 
            this.lblShipTrueNorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipTrueNorth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipTrueNorth.Location = new System.Drawing.Point(102, 92);
            this.lblShipTrueNorth.Name = "lblShipTrueNorth";
            this.lblShipTrueNorth.Size = new System.Drawing.Size(118, 28);
            this.lblShipTrueNorth.TabIndex = 35;
            this.lblShipTrueNorth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShipTrueNorth.Click += new System.EventHandler(this.lblShipTrueNorth_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "자북";
            // 
            // lblShipMagNorth
            // 
            this.lblShipMagNorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipMagNorth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipMagNorth.Location = new System.Drawing.Point(102, 54);
            this.lblShipMagNorth.Name = "lblShipMagNorth";
            this.lblShipMagNorth.Size = new System.Drawing.Size(118, 28);
            this.lblShipMagNorth.TabIndex = 33;
            this.lblShipMagNorth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShipMagNorth.Click += new System.EventHandler(this.lblShipMagNorth_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 20);
            this.label23.TabIndex = 32;
            this.label23.Text = "정북";
            // 
            // lblShipNorth
            // 
            this.lblShipNorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblShipNorth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipNorth.Location = new System.Drawing.Point(102, 16);
            this.lblShipNorth.Name = "lblShipNorth";
            this.lblShipNorth.Size = new System.Drawing.Size(118, 28);
            this.lblShipNorth.TabIndex = 31;
            this.lblShipNorth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShipNorth.Click += new System.EventHandler(this.lblShipNorth_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 20);
            this.label27.TabIndex = 40;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(517, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "상태 정보";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(513, 426);
            this.tableLayoutPanel3.TabIndex = 49;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.lblFailsafe);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.lblRCInputStatus);
            this.groupBox4.Controls.Add(this.lblArmingSatus);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.lblFlightMode);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(258, 189);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox4.Size = new System.Drawing.Size(252, 234);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "비행 상태";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 111);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(67, 20);
            this.label33.TabIndex = 49;
            this.label33.Text = "RC Input";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // lblFailsafe
            // 
            this.lblFailsafe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblFailsafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFailsafe.Location = new System.Drawing.Point(137, 147);
            this.lblFailsafe.Name = "lblFailsafe";
            this.lblFailsafe.Size = new System.Drawing.Size(112, 28);
            this.lblFailsafe.TabIndex = 46;
            this.lblFailsafe.Text = "0";
            this.lblFailsafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFailsafe.Click += new System.EventHandler(this.lblFailsafe_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(12, 151);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 20);
            this.label36.TabIndex = 45;
            this.label36.Text = "Failsafe";
            this.label36.Click += new System.EventHandler(this.label36_Click);
            // 
            // lblRCInputStatus
            // 
            this.lblRCInputStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblRCInputStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRCInputStatus.Location = new System.Drawing.Point(137, 107);
            this.lblRCInputStatus.Name = "lblRCInputStatus";
            this.lblRCInputStatus.Size = new System.Drawing.Size(112, 28);
            this.lblRCInputStatus.TabIndex = 43;
            this.lblRCInputStatus.Text = "0";
            this.lblRCInputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRCInputStatus.Click += new System.EventHandler(this.lblRCInputStatus_Click);
            // 
            // lblArmingSatus
            // 
            this.lblArmingSatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblArmingSatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmingSatus.Location = new System.Drawing.Point(137, 67);
            this.lblArmingSatus.Name = "lblArmingSatus";
            this.lblArmingSatus.Size = new System.Drawing.Size(112, 28);
            this.lblArmingSatus.TabIndex = 40;
            this.lblArmingSatus.Text = "0";
            this.lblArmingSatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArmingSatus.Click += new System.EventHandler(this.lblArmingSatus_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 71);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(126, 20);
            this.label39.TabIndex = 39;
            this.label39.Text = "Armed/Disarmed";
            this.label39.Click += new System.EventHandler(this.label39_Click);
            // 
            // lblFlightMode
            // 
            this.lblFlightMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblFlightMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlightMode.Location = new System.Drawing.Point(137, 27);
            this.lblFlightMode.Name = "lblFlightMode";
            this.lblFlightMode.Size = new System.Drawing.Size(112, 28);
            this.lblFlightMode.TabIndex = 20;
            this.lblFlightMode.Text = "0";
            this.lblFlightMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFlightMode.Click += new System.EventHandler(this.lblFlightMode_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 31);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(49, 20);
            this.label41.TabIndex = 19;
            this.label41.Text = "Mode";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCompassStatus);
            this.groupBox2.Controls.Add(this.lblImuTemperature);
            this.groupBox2.Controls.Add(this.lblVibrationStatus);
            this.groupBox2.Controls.Add(this.lblAccelGyroStatus);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label60);
            this.groupBox2.Controls.Add(this.label63);
            this.groupBox2.Controls.Add(this.label66);
            this.groupBox2.Controls.Add(this.lblEKFStatus);
            this.groupBox2.Controls.Add(this.label68);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox2.Size = new System.Drawing.Size(251, 234);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "센서(EKF/IMU/Compass)";
            // 
            // lblCompassStatus
            // 
            this.lblCompassStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblCompassStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompassStatus.Location = new System.Drawing.Point(102, 64);
            this.lblCompassStatus.Name = "lblCompassStatus";
            this.lblCompassStatus.Size = new System.Drawing.Size(112, 28);
            this.lblCompassStatus.TabIndex = 50;
            this.lblCompassStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImuTemperature
            // 
            this.lblImuTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblImuTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImuTemperature.Location = new System.Drawing.Point(102, 176);
            this.lblImuTemperature.Name = "lblImuTemperature";
            this.lblImuTemperature.Size = new System.Drawing.Size(112, 28);
            this.lblImuTemperature.TabIndex = 49;
            this.lblImuTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVibrationStatus
            // 
            this.lblVibrationStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblVibrationStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVibrationStatus.Location = new System.Drawing.Point(102, 139);
            this.lblVibrationStatus.Name = "lblVibrationStatus";
            this.lblVibrationStatus.Size = new System.Drawing.Size(112, 28);
            this.lblVibrationStatus.TabIndex = 48;
            this.lblVibrationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccelGyroStatus
            // 
            this.lblAccelGyroStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblAccelGyroStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccelGyroStatus.Location = new System.Drawing.Point(102, 102);
            this.lblAccelGyroStatus.Name = "lblAccelGyroStatus";
            this.lblAccelGyroStatus.Size = new System.Drawing.Size(112, 28);
            this.lblAccelGyroStatus.TabIndex = 47;
            this.lblAccelGyroStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(8, 180);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 20);
            this.label31.TabIndex = 46;
            this.label31.Text = "IMU Temp";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 143);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(73, 20);
            this.label60.TabIndex = 45;
            this.label60.Text = "Vibration";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(8, 106);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(92, 20);
            this.label63.TabIndex = 42;
            this.label63.Text = "Accel / Gyro";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(8, 68);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(69, 20);
            this.label66.TabIndex = 39;
            this.label66.Text = "Compass";
            // 
            // lblEKFStatus
            // 
            this.lblEKFStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblEKFStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEKFStatus.Location = new System.Drawing.Point(102, 26);
            this.lblEKFStatus.Name = "lblEKFStatus";
            this.lblEKFStatus.Size = new System.Drawing.Size(112, 28);
            this.lblEKFStatus.TabIndex = 20;
            this.lblEKFStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(8, 30);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(68, 20);
            this.label68.TabIndex = 19;
            this.label68.Text = "EKF 상태";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.lblBattery2);
            this.groupBox3.Controls.Add(this.label65);
            this.groupBox3.Controls.Add(this.lblBatteryRemaining);
            this.groupBox3.Controls.Add(this.lblBatteryConsumed);
            this.groupBox3.Controls.Add(this.label73);
            this.groupBox3.Controls.Add(this.lblBatteryVoltageAndCurrent);
            this.groupBox3.Controls.Add(this.label75);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(258, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox3.Size = new System.Drawing.Size(252, 182);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "배터리/전원";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 104);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(99, 20);
            this.label29.TabIndex = 49;
            this.label29.Text = "Remaining %";
            // 
            // lblBattery2
            // 
            this.lblBattery2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblBattery2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattery2.Location = new System.Drawing.Point(137, 142);
            this.lblBattery2.Name = "lblBattery2";
            this.lblBattery2.Size = new System.Drawing.Size(112, 28);
            this.lblBattery2.TabIndex = 46;
            this.lblBattery2.Text = "0";
            this.lblBattery2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(10, 146);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(81, 20);
            this.label65.TabIndex = 45;
            this.label65.Text = "(Battery 2)";
            // 
            // lblBatteryRemaining
            // 
            this.lblBatteryRemaining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblBatteryRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBatteryRemaining.Location = new System.Drawing.Point(137, 102);
            this.lblBatteryRemaining.Name = "lblBatteryRemaining";
            this.lblBatteryRemaining.Size = new System.Drawing.Size(112, 28);
            this.lblBatteryRemaining.TabIndex = 43;
            this.lblBatteryRemaining.Text = "0";
            this.lblBatteryRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatteryConsumed
            // 
            this.lblBatteryConsumed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblBatteryConsumed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBatteryConsumed.Location = new System.Drawing.Point(137, 62);
            this.lblBatteryConsumed.Name = "lblBatteryConsumed";
            this.lblBatteryConsumed.Size = new System.Drawing.Size(112, 28);
            this.lblBatteryConsumed.TabIndex = 40;
            this.lblBatteryConsumed.Text = "0";
            this.lblBatteryConsumed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(10, 66);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(81, 20);
            this.label73.TabIndex = 39;
            this.label73.Text = "Consumed";
            // 
            // lblBatteryVoltageAndCurrent
            // 
            this.lblBatteryVoltageAndCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblBatteryVoltageAndCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBatteryVoltageAndCurrent.Location = new System.Drawing.Point(137, 22);
            this.lblBatteryVoltageAndCurrent.Name = "lblBatteryVoltageAndCurrent";
            this.lblBatteryVoltageAndCurrent.Size = new System.Drawing.Size(112, 28);
            this.lblBatteryVoltageAndCurrent.TabIndex = 20;
            this.lblBatteryVoltageAndCurrent.Text = "0";
            this.lblBatteryVoltageAndCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(10, 26);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(127, 20);
            this.label75.TabIndex = 19;
            this.label75.Text = "Voltage / Current";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExtBytesReceived);
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.lblExtComBytesSent);
            this.groupBox1.Controls.Add(this.label56);
            this.groupBox1.Controls.Add(this.lblExtComBaudrate);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.lblExtComStatus);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 6);
            this.groupBox1.Size = new System.Drawing.Size(251, 182);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "외부 통신";
            // 
            // lblExtBytesReceived
            // 
            this.lblExtBytesReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblExtBytesReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtBytesReceived.Location = new System.Drawing.Point(104, 143);
            this.lblExtBytesReceived.Name = "lblExtBytesReceived";
            this.lblExtBytesReceived.Size = new System.Drawing.Size(112, 28);
            this.lblExtBytesReceived.TabIndex = 46;
            this.lblExtBytesReceived.Text = "0";
            this.lblExtBytesReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(10, 147);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(66, 20);
            this.label58.TabIndex = 45;
            this.label58.Text = "Rx Bytes";
            // 
            // lblExtComBytesSent
            // 
            this.lblExtComBytesSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblExtComBytesSent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtComBytesSent.Location = new System.Drawing.Point(104, 103);
            this.lblExtComBytesSent.Name = "lblExtComBytesSent";
            this.lblExtComBytesSent.Size = new System.Drawing.Size(112, 28);
            this.lblExtComBytesSent.TabIndex = 43;
            this.lblExtComBytesSent.Text = "0";
            this.lblExtComBytesSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(10, 107);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(64, 20);
            this.label56.TabIndex = 42;
            this.label56.Text = "Tx Bytes";
            // 
            // lblExtComBaudrate
            // 
            this.lblExtComBaudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblExtComBaudrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtComBaudrate.Location = new System.Drawing.Point(104, 63);
            this.lblExtComBaudrate.Name = "lblExtComBaudrate";
            this.lblExtComBaudrate.Size = new System.Drawing.Size(112, 28);
            this.lblExtComBaudrate.TabIndex = 40;
            this.lblExtComBaudrate.Text = "0";
            this.lblExtComBaudrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(10, 67);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(71, 20);
            this.label54.TabIndex = 39;
            this.label54.Text = "Baudrate";
            // 
            // lblExtComStatus
            // 
            this.lblExtComStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.lblExtComStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtComStatus.Location = new System.Drawing.Point(104, 23);
            this.lblExtComStatus.Name = "lblExtComStatus";
            this.lblExtComStatus.Size = new System.Drawing.Size(112, 28);
            this.lblExtComStatus.TabIndex = 20;
            this.lblExtComStatus.Text = "0";
            this.lblExtComStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(10, 27);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(50, 20);
            this.label52.TabIndex = 19;
            this.label52.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 474);
            this.panel1.TabIndex = 1;
            // 
            // UcStatusTabControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(524, 474);
            this.MinimumSize = new System.Drawing.Size(524, 474);
            this.Name = "UcStatusTabControl";
            this.Size = new System.Drawing.Size(524, 474);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMainMotorPower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMainMotorRpm;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblControlMotor4Power;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblControlMotor4Rpm;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblControlMotor2Power;
        private System.Windows.Forms.Label lblControlMotor2Rpm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listboxMessage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblControlMotor3Power;
        private System.Windows.Forms.Label lblControlMotor3Rpm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblControlMotor1Power;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblControlMotor1Rpm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelShipBaroTemerature;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblShipBaroAltitude;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblShipBaroPressure;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShipPitch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblShipRoll;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblShipHeading;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblHhipTurnRate;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblShipAcceleration;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblShipTrueNorth;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblShipMagNorth;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblShipNorth;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblFailsafe;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblRCInputStatus;
        private System.Windows.Forms.Label lblArmingSatus;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblFlightMode;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCompassStatus;
        private System.Windows.Forms.Label lblImuTemperature;
        private System.Windows.Forms.Label lblVibrationStatus;
        private System.Windows.Forms.Label lblAccelGyroStatus;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label lblEKFStatus;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblBattery2;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lblBatteryRemaining;
        private System.Windows.Forms.Label lblBatteryConsumed;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label lblBatteryVoltageAndCurrent;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblExtBytesReceived;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label lblExtComBytesSent;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label lblExtComBaudrate;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label lblExtComStatus;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel panel1;
    }
}