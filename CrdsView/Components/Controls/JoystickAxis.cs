using System;
using System.Drawing;

//using System.Reflection.Emit;
using System.Windows.Forms;
using CrdsView.Controls;

namespace CrdsView.Joystick
{
    public class JoystickAxis : UserControl
    {
        public JoystickAxis()
        {
            InitializeComponent();
        }

        private MyButton BUT_detch;
        private CheckBox revCH;
        private Label label13;
        private TextBox expo_ch;
        private ProgressBar ProgressBarCH;
        public System.Windows.Forms.ComboBox CMB_CH;

        public Func<string> Detect;
        public Action SetAxis;
        public Action Reverse;
        public Action Expo;
        public Func<int> GetValue;

        private System.Windows.Forms.Timer timer1;

        public int ChannelNo
        {
            get;
            set;
        }

        public string Label
        {
            get { return label13.Text; }
            set { label13.Text = value; }
        }

        public Array AxisArray
        {
            get { return (Array)CMB_CH.DataSource; }
            set { CMB_CH.DataSource = value; }
        }

        public string ChannelValue
        {
            get { return CMB_CH.Text; }
            set { CMB_CH.Text = value; }
        }

        public string ExpoValue
        {
            get { return expo_ch.Text; }
            set { expo_ch.Text = value; }
        }

        public bool ReverseValue
        {
            get { return revCH.Checked; }
            set { revCH.Checked = value; }
        }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BUT_detch = new CrdsView.Controls.MyButton();
            this.revCH = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.expo_ch = new System.Windows.Forms.TextBox();
            this.ProgressBarCH = new System.Windows.Forms.ProgressBar();
            this.CMB_CH = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BUT_detch
            // 
            this.BUT_detch.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.BUT_detch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_detch.Location = new System.Drawing.Point(209, 1);
            this.BUT_detch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BUT_detch.Name = "BUT_detch";
            this.BUT_detch.Size = new System.Drawing.Size(73, 49);
            this.BUT_detch.TabIndex = 62;
            this.BUT_detch.Text = "Auto Detect";
            this.BUT_detch.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_detch.UseVisualStyleBackColor = true;
            this.BUT_detch.Click += new System.EventHandler(this.BUT_detch_Click);
            // 
            // revCH
            // 
            this.revCH.AutoSize = true;
            this.revCH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.revCH.Location = new System.Drawing.Point(614, 16);
            this.revCH.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.revCH.Name = "revCH";
            this.revCH.Size = new System.Drawing.Size(22, 21);
            this.revCH.TabIndex = 61;
            this.revCH.UseVisualStyleBackColor = true;
            this.revCH.CheckedChanged += new System.EventHandler(this.revCH_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(6, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 21);
            this.label13.TabIndex = 60;
            this.label13.Text = "RC";
            // 
            // expo_ch
            // 
            this.expo_ch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.expo_ch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expo_ch.Location = new System.Drawing.Point(460, 11);
            this.expo_ch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.expo_ch.Name = "expo_ch";
            this.expo_ch.Size = new System.Drawing.Size(142, 32);
            this.expo_ch.TabIndex = 59;
            this.expo_ch.Text = "0";
            this.expo_ch.TextChanged += new System.EventHandler(this.expo_ch_TextChanged);
            // 
            // ProgressBarCH
            // 
            this.ProgressBarCH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressBarCH.Location = new System.Drawing.Point(285, 9);
            this.ProgressBarCH.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProgressBarCH.Maximum = 2200;
            this.ProgressBarCH.Minimum = 800;
            this.ProgressBarCH.Name = "ProgressBarCH";
            this.ProgressBarCH.Size = new System.Drawing.Size(167, 27);
            this.ProgressBarCH.TabIndex = 58;
            this.ProgressBarCH.Value = 800;
            // 
            // CMB_CH
            // 
            this.CMB_CH.FormattingEnabled = true;
            this.CMB_CH.Items.AddRange(new object[] {
            "RZ",
            "X",
            "Y",
            "SL1"});
            this.CMB_CH.Location = new System.Drawing.Point(73, 12);
            this.CMB_CH.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CMB_CH.Name = "CMB_CH";
            this.CMB_CH.Size = new System.Drawing.Size(125, 29);
            this.CMB_CH.TabIndex = 57;
            this.CMB_CH.SelectedIndexChanged += new System.EventHandler(this.CMB_CH_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JoystickAxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BUT_detch);
            this.Controls.Add(this.revCH);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.expo_ch);
            this.Controls.Add(this.ProgressBarCH);
            this.Controls.Add(this.CMB_CH);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "JoystickAxis";
            this.Size = new System.Drawing.Size(649, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void CMB_CH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SetAxis != null)
            {
                SetAxis.Invoke();
            }
            else
            {
                //Console.WriteLine("Error - SetAxis() is null.");
            }
        }

        private void BUT_detch_Click(object sender, EventArgs e)
        {
            ChannelValue = Detect?.Invoke();
        }

        private void expo_ch_TextChanged(object sender, EventArgs e)
        {
            Expo?.Invoke();
        }

        private void revCH_CheckedChanged(object sender, EventArgs e)
        {
            Reverse?.Invoke();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int value = 800;
            if (GetValue == null)
                return;

            //ProgressBarCH.maxline = GetValue();
            value = GetValue();
            //Console.WriteLine("timer1 loop: ch_value = " + value); //20260119 - test code
            if ((value >= 800) && (value <= 2200))
            {
                //Console.WriteLine("ch_value = " + value);
                ProgressBarCH.Value = value; // GetValue();
            }
        }
    }
}
