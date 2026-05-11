using System.Drawing;

namespace JoystickTest.MyJoystickControl
{
    partial class MyJoystickControl
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
            this.joyBack1 = new Joystick.JoyBack();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.joyBack1)).BeginInit();
            this.SuspendLayout();
            // 
            // joyBack1
            // 
            this.joyBack1.Location = new System.Drawing.Point(3, 3);
            this.joyBack1.MaximumSize = new System.Drawing.Size(150, 150);
            this.joyBack1.MinimumSize = new System.Drawing.Size(150, 150);
            this.joyBack1.Name = "joyBack1";
            this.joyBack1.Size = new System.Drawing.Size(150, 150);
            this.joyBack1.TabIndex = 0;
            this.joyBack1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(joyBack1.Location.X,
                                               joyBack1.Location.Y + joyBack1.Size.Height - 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 25);
            this.textBox1.TabIndex = 1;
            // 
            // MyJoystickControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.joyBack1);
            this.Name = "JoystickControl1";
            this.Size = new System.Drawing.Size(300, 250);
            this.BackColor = Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.joyBack1)).EndInit();
            this.DoubleBuffered = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Joystick.JoyBack joyBack1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
