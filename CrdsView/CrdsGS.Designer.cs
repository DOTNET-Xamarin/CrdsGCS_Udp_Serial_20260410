using MyControl;
using System.Drawing;
using System.Windows.Forms;

namespace CrdsView
{
    partial class CrdsGS
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSetup = new System.Windows.Forms.Button();
            this.ButtonConfig = new System.Windows.Forms.Button();
            this.ButtonMonitor = new System.Windows.Forms.Button();
            this.ButtonConnection = new System.Windows.Forms.Button();
            this.LabelCrdsCI = new System.Windows.Forms.Label();
            this.LabelVehicleStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSetup
            // 
            this.ButtonSetup.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSetup.Location = new System.Drawing.Point(307, 15);
            this.ButtonSetup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSetup.Name = "ButtonSetup";
            this.ButtonSetup.Size = new System.Drawing.Size(91, 94);
            this.ButtonSetup.TabIndex = 2;
            this.ButtonSetup.Text = "Setup";
            this.ButtonSetup.UseVisualStyleBackColor = true;
            // 
            // ButtonConfig
            // 
            this.ButtonConfig.Location = new System.Drawing.Point(422, 15);
            this.ButtonConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonConfig.Name = "ButtonConfig";
            this.ButtonConfig.Size = new System.Drawing.Size(91, 94);
            this.ButtonConfig.TabIndex = 5;
            this.ButtonConfig.Text = "Config";
            this.ButtonConfig.UseVisualStyleBackColor = true;
            // 
            // ButtonMonitor
            // 
            this.ButtonMonitor.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonMonitor.ForeColor = System.Drawing.Color.Black;
            this.ButtonMonitor.Location = new System.Drawing.Point(193, 15);
            this.ButtonMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonMonitor.Name = "ButtonMonitor";
            this.ButtonMonitor.Size = new System.Drawing.Size(91, 94);
            this.ButtonMonitor.TabIndex = 1;
            this.ButtonMonitor.Text = "Monitor";
            this.ButtonMonitor.UseVisualStyleBackColor = false;
            // 
            // ButtonConnection
            // 
            this.ButtonConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnection.Location = new System.Drawing.Point(907, 15);
            this.ButtonConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonConnection.Name = "ButtonConnection";
            this.ButtonConnection.Size = new System.Drawing.Size(91, 94);
            this.ButtonConnection.TabIndex = 3;
            this.ButtonConnection.Text = "Connection";
            this.ButtonConnection.UseVisualStyleBackColor = true;
            this.ButtonConnection.Click += new System.EventHandler(this.ButtonConnection_Click);
            // 
            // LabelCrdsCI
            // 
            this.LabelCrdsCI.BackColor = System.Drawing.SystemColors.Control;
            this.LabelCrdsCI.Location = new System.Drawing.Point(0, 0);
            this.LabelCrdsCI.Name = "LabelCrdsCI";
            this.LabelCrdsCI.Size = new System.Drawing.Size(136, 50);
            this.LabelCrdsCI.TabIndex = 1;
            // 
            // LabelVehicleStatus
            // 
            this.LabelVehicleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVehicleStatus.Location = new System.Drawing.Point(569, 15);
            this.LabelVehicleStatus.Name = "LabelVehicleStatus";
            this.LabelVehicleStatus.Size = new System.Drawing.Size(331, 94);
            this.LabelVehicleStatus.TabIndex = 6;
            this.LabelVehicleStatus.Text = "VehicleStatus";
            this.LabelVehicleStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrdsGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1014, 908);
            this.Controls.Add(this.LabelCrdsCI);
            this.Controls.Add(this.LabelVehicleStatus);
            this.Controls.Add(this.ButtonMonitor);
            this.Controls.Add(this.ButtonSetup);
            this.Controls.Add(this.ButtonConnection);
            this.Controls.Add(this.ButtonConfig);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrdsGS";
            this.Text = "TDCN GCS Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrdsGS_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrdsGS_FormClosed);
            this.Load += new System.EventHandler(this.CrdsGS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSetup;
        private System.Windows.Forms.Button ButtonConfig;
        private System.Windows.Forms.Button ButtonMonitor;
        private System.Windows.Forms.Button ButtonConnection;
        private System.Windows.Forms.Label LabelCrdsCI;
        private System.Windows.Forms.Label LabelVehicleStatus;
    }
}