using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CrdsView.Ucs.Monitors
{
    public partial class UcStatusTabControl : UserControl
    {
        private readonly Color _rootBackColor = Color.FromArgb(240, 244, 248);
        private readonly Color _panelBackColor = Color.FromArgb(232, 239, 247);
        private readonly Color _pageBackColor = Color.FromArgb(245, 248, 252);
        private readonly Color _groupBackColor = Color.White;
        private readonly Color _groupForeColor = Color.FromArgb(41, 54, 73);
        private readonly Color _labelForeColor = Color.FromArgb(60, 70, 82);
        private readonly Color _valueBackColor = Color.FromArgb(255, 248, 220);
        private readonly Color _valueForeColor = Color.FromArgb(55, 55, 55);
        private readonly Color _buttonBackColor = Color.FromArgb(52, 120, 246);
        private readonly Color _tabBorderColor = Color.FromArgb(210, 220, 230);

        private readonly Font _baseFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        private readonly Font _groupFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        private readonly Font _valueFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        private readonly Font _tabFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        private readonly Font _buttonFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);

        private float _main_motor_power = 0;
        private float _main_motor_rpm = 0;

        public UcStatusTabControl()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            ApplyModernUiStyle();

            tabControl1.DrawItem -= TabControl1_DrawItem;
            tabControl1.DrawItem += TabControl1_DrawItem;
        }

        public float MainMotorRpm
        {
            get { return _main_motor_rpm; }
            set
            {
                _main_motor_rpm = value;
                lblMainMotorRpm.Text = _main_motor_rpm.ToString("0.##");
            }
        }

        public float MainMotorPower
        {
            get { return _main_motor_power; }
            set
            {
                _main_motor_power = value;
                lblMainMotorPower.Text = _main_motor_power.ToString("0.##");
            }
        }

        private void ApplyModernUiStyle()
        {
            this.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();

            this.Font = _baseFont;
            this.BackColor = _rootBackColor;
            this.Size = new Size(586, 474);
            this.MinimumSize = new Size(586, 474);
            this.MaximumSize = new Size(586, 474);

            panel1.BackColor = _panelBackColor;
            panel1.BorderStyle = BorderStyle.None;
            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(586, 474);
            panel1.Padding = new Padding(2);

            tabControl1.Location = new Point(2, 2);
            tabControl1.Size = new Size(582, 470);
            tabControl1.Font = _tabFont;
            tabControl1.ItemSize = new Size(108, 32);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.Padding = new Point(6, 3);
            tabControl1.Margin = new Padding(0);

            foreach (TabPage page in tabControl1.TabPages)
            {
                page.BackColor = _pageBackColor;
                page.Padding = new Padding(1);
                page.Margin = new Padding(0);
            }

            StyleTableLayout(tableLayoutPanel1);
            StyleTableLayout(tableLayoutPanel2);
            StyleTableLayout(tableLayoutPanel3);

            foreach (Control control in GetAllControls(this))
            {
                if (control is GroupBox gb)
                {
                    gb.Font = _groupFont;
                    gb.ForeColor = _groupForeColor;
                    gb.BackColor = _groupBackColor;
                    gb.Padding = new Padding(6, 4, 6, 5);
                    gb.Margin = new Padding(1);
                }
                else if (control is Label lbl)
                {
                    if (lbl.BorderStyle == BorderStyle.Fixed3D || lbl.BorderStyle == BorderStyle.FixedSingle)
                    {
                        StyleValueLabel(lbl);
                    }
                    else
                    {
                        lbl.Font = _baseFont;
                        lbl.ForeColor = _labelForeColor;
                        lbl.Margin = new Padding(0);
                        lbl.AutoSize = true;
                    }
                }
                else if (control is ListBox lb)
                {
                    lb.Font = _baseFont;
                    lb.BackColor = Color.White;
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    lb.ItemHeight = 18;
                    lb.Margin = new Padding(1);
                }
                else if (control is Button btn)
                {
                    StyleButton(btn);
                }
            }

            FineTuneDroneTab();
            FineTuneShipTab();
            FineTuneStatusTab();

            tabControl1.ResumeLayout(true);
            panel1.ResumeLayout(true);
            this.ResumeLayout(true);
        }

        private void StyleTableLayout(TableLayoutPanel tlp)
        {
            tlp.Dock = DockStyle.Fill;
            tlp.BackColor = Color.Transparent;
            tlp.Padding = new Padding(0);
            tlp.Margin = new Padding(0);
            tlp.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        }

        private void StyleValueLabel(Label label)
        {
            label.Font = _valueFont;
            label.BackColor = _valueBackColor;
            label.ForeColor = _valueForeColor;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(0);
            label.Padding = new Padding(2, 1, 2, 1);
            label.AutoEllipsis = true;

            if (label.Width < 108) label.Width = 108;
            if (label.Height < 28) label.Height = 28;
        }

        private void StyleButton(Button btn)
        {
            btn.Font = _buttonFont;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = _buttonBackColor;
            btn.ForeColor = Color.White;
            btn.Height = 30;
            btn.Margin = new Padding(1);
            btn.Padding = new Padding(0);
            btn.Cursor = Cursors.Hand;
        }

        private void FineTuneDroneTab()
        {
            tableLayoutPanel1.Padding = new Padding(0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            groupBox7.Margin = new Padding(1);
            groupBox6.Margin = new Padding(1);
            groupBox5.Margin = new Padding(1);
            groupBox8.Margin = new Padding(1);
            groupBox9.Margin = new Padding(1);

            listboxMessage.Margin = new Padding(1);
            listboxMessage.Dock = DockStyle.Fill;

            ResizeValueLabel(lblMainMotorRpm, 150, 28);
            ResizeValueLabel(lblMainMotorPower, 150, 28);

            lblMainMotorRpm.Location = new Point(150, 12);
            label9.Location = new Point(308, 16);
            lblMainMotorPower.Location = new Point(150, 40);
            label10.Location = new Point(308, 44);

            CompactMotorGroupWide(groupBox6, lblControlMotor3Rpm, lblControlMotor3Power, label3, label1);
            CompactMotorGroupWide(groupBox9, lblControlMotor4Rpm, lblControlMotor4Power, label5, label2);
            CompactMotorGroupWide(groupBox5, lblControlMotor2Rpm, lblControlMotor2Power, label16, label14);
            CompactMotorGroupWide(groupBox8, lblControlMotor1Rpm, lblControlMotor1Power, label7, label4);
        }

        private void FineTuneShipTab()
        {
            tableLayoutPanel2.Padding = new Padding(0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanel2.RowStyles.Clear();
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));

            groupBox10.Margin = new Padding(1);
            groupBox11.Margin = new Padding(1);
            groupBox12.Margin = new Padding(1);
            groupBox13.Margin = new Padding(1);
            groupBox14.Margin = new Padding(1);

            ResizeValueLabel(lblShipHeading, 132, 28);
            ResizeValueLabel(lblShipRoll, 132, 28);
            ResizeValueLabel(lblShipPitch, 132, 28);
            ResizeValueLabel(lblHhipTurnRate, 132, 28);
            ResizeValueLabel(lblShipAcceleration, 132, 28);
            ResizeValueLabel(lblShipNorth, 132, 28);
            ResizeValueLabel(lblShipMagNorth, 132, 28);
            ResizeValueLabel(lblShipTrueNorth, 132, 28);
            ResizeValueLabel(lblShipBaroPressure, 132, 28);
            ResizeValueLabel(lblShipBaroAltitude, 132, 28);
            ResizeValueLabel(labelShipBaroTemerature, 132, 28);

            AlignKeyValueWide(label19, lblShipHeading, 12, 28, 92);
            AlignKeyValueWide(label11, lblShipRoll, 12, 66, 92);
            AlignKeyValueWide(label6, lblShipPitch, 12, 104, 92);

            AlignKeyValueWide(label17, lblHhipTurnRate, 12, 48, 92);
            AlignKeyValueWide(label22, lblShipAcceleration, 12, 48, 92);

            AlignKeyValueWide(label23, lblShipNorth, 12, 16, 92);
            AlignKeyValueWide(label20, lblShipMagNorth, 12, 54, 92);
            AlignKeyValueWide(label15, lblShipTrueNorth, 12, 92, 92);

            AlignKeyValueWide(label32, lblShipBaroPressure, 12, 16, 92);
            AlignKeyValueWide(label30, lblShipBaroAltitude, 12, 54, 92);
            AlignKeyValueWide(label28, labelShipBaroTemerature, 12, 92, 92);
        }

        private void FineTuneStatusTab()
        {
            tableLayoutPanel3.Padding = new Padding(0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.ColumnStyles.Clear();
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanel3.RowStyles.Clear();
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57F));

            groupBox1.Margin = new Padding(1);
            groupBox2.Margin = new Padding(1);
            groupBox3.Margin = new Padding(1);
            groupBox4.Margin = new Padding(1);

            ResizeValueLabel(lblExtComStatus, 118, 28);
            ResizeValueLabel(lblExtComBaudrate, 118, 28);
            ResizeValueLabel(lblExtComBytesSent, 118, 28);
            ResizeValueLabel(lblExtBytesReceived, 118, 28);

            ResizeValueLabel(lblBatteryVoltageAndCurrent, 118, 28);
            ResizeValueLabel(lblBatteryConsumed, 118, 28);
            ResizeValueLabel(lblBatteryRemaining, 118, 28);
            ResizeValueLabel(lblBattery2, 118, 28);

            ResizeValueLabel(lblEKFStatus, 118, 28);
            ResizeValueLabel(lblCompassStatus, 118, 28);
            ResizeValueLabel(lblAccelGyroStatus, 118, 28);
            ResizeValueLabel(lblVibrationStatus, 118, 28);
            ResizeValueLabel(lblImuTemperature, 118, 28);

            ResizeValueLabel(lblFlightMode, 118, 28);
            ResizeValueLabel(lblArmingSatus, 118, 28);
            ResizeValueLabel(lblRCInputStatus, 118, 28);
            ResizeValueLabel(lblFailsafe, 118, 28);

            AlignKeyValueWide(label52, lblExtComStatus, 8, 18, 120);
            AlignKeyValueWide(label54, lblExtComBaudrate, 8, 54, 120);
            AlignKeyValueWide(label56, lblExtComBytesSent, 8, 90, 120);
            AlignKeyValueWide(label58, lblExtBytesReceived, 8, 126, 120);

            AlignKeyValueWide(label75, lblBatteryVoltageAndCurrent, 8, 18, 120);
            AlignKeyValueWide(label73, lblBatteryConsumed, 8, 54, 120);
            AlignKeyValueWide(label29, lblBatteryRemaining, 8, 90, 120);
            AlignKeyValueWide(label65, lblBattery2, 8, 126, 120);

            AlignKeyValueWide(label68, lblEKFStatus, 8, 18, 120);
            AlignKeyValueWide(label66, lblCompassStatus, 8, 54, 120);
            AlignKeyValueWide(label63, lblAccelGyroStatus, 8, 90, 120);
            AlignKeyValueWide(label60, lblVibrationStatus, 8, 126, 120);
            AlignKeyValueWide(label31, lblImuTemperature, 8, 162, 120);

            AlignKeyValueWide(label41, lblFlightMode, 8, 18, 120);
            AlignKeyValueWide(label39, lblArmingSatus, 8, 54, 120);
            AlignKeyValueWide(label33, lblRCInputStatus, 8, 90, 120);
            AlignKeyValueWide(label36, lblFailsafe, 8, 126, 120);
        }

        private void CompactMotorGroupWide(GroupBox groupBox, Label rpmValue, Label powerValue, Label rpmUnit, Label powerUnit)
        {
            groupBox.Padding = new Padding(6, 4, 6, 5);

            ResizeValueLabel(rpmValue, 132, 28);
            ResizeValueLabel(powerValue, 132, 28);

            rpmValue.Location = new Point(10, 16);
            powerValue.Location = new Point(10, 46);

            rpmUnit.Location = new Point(148, 20);
            powerUnit.Location = new Point(148, 50);
        }

        private void AlignKeyValueWide(Label titleLabel, Label valueLabel, int titleX, int top, int valueX)
        {
            titleLabel.Location = new Point(titleX, top + 4);
            valueLabel.Location = new Point(valueX, top);
        }

        private void ResizeValueLabel(Label label, int width, int height)
        {
            label.Size = new Size(width, height);
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color backColor;
            Color textColor = Color.White;

            switch (e.Index)
            {
                case 0:
                    backColor = Color.FromArgb(70, 130, 180);
                    break;
                case 1:
                    backColor = Color.FromArgb(0, 139, 139);
                    break;
                case 2:
                    backColor = Color.FromArgb(184, 134, 11);
                    break;
                default:
                    backColor = Color.SlateGray;
                    break;
            }

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Rectangle bounds = e.Bounds;

            using (SolidBrush bg = new SolidBrush(isSelected ? backColor : ControlPaint.Light(backColor, 0.35f)))
            {
                e.Graphics.FillRectangle(bg, bounds);
            }

            using (Pen borderPen = new Pen(_tabBorderColor))
            {
                e.Graphics.DrawRectangle(borderPen, bounds);
            }

            TextRenderer.DrawText(
                e.Graphics,
                tabControl1.TabPages[e.Index].Text,
                tabControl1.Font,
                bounds,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                foreach (Control grandChild in GetAllControls(child))
                    yield return grandChild;

                yield return child;
            }
        }

        private void lblShipTrueNorth_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void lblShipNorth_Click(object sender, EventArgs e) { }
        private void lblShipMagNorth_Click(object sender, EventArgs e) { }
        private void lblShipTrueNorth_Click_1(object sender, EventArgs e) { }
        private void label41_Click(object sender, EventArgs e) { }
        private void label39_Click(object sender, EventArgs e) { }
        private void label33_Click(object sender, EventArgs e) { }
        private void label36_Click(object sender, EventArgs e) { }
        private void lblFailsafe_Click(object sender, EventArgs e) { }
        private void lblRCInputStatus_Click(object sender, EventArgs e) { }
        private void lblArmingSatus_Click(object sender, EventArgs e) { }
        private void lblFlightMode_Click(object sender, EventArgs e) { }
    }
}