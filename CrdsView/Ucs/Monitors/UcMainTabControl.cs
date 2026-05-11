using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrdsView.Ucs.Monitors
{
    public partial class UcMainTabControl : UserControl
    {
        private const float OriginalPageWidth = 1416f;
        private const float OriginalPageHeight = 243f;
        private bool _contentScaled = false;
        private bool _themeApplied = false;

        public UcMainTabControl()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            this.Margin = new Padding(0);
            this.Padding = new Padding(0);

            ApplyOuterLayout();
            ScaleTabPageContentsOnce();
            ApplyModernTheme();

            tabControl1.DrawItem -= TabControl1_DrawItem;
            tabControl1.DrawItem += TabControl1_DrawItem;
        }

        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || this.DesignMode;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ApplyOuterLayout();
            ScaleTabPageContentsOnce();
            ApplyModernTheme();
        }

        private void ApplyOuterLayout()
        {
            panelFrame.Margin = new Padding(0);
            panelFrame.Padding = new Padding(0);
            panelFrame.Dock = DockStyle.Fill;

            tabControl1.Margin = new Padding(0);
            tabControl1.Dock = DockStyle.Fill;
        }

        private void ScaleTabPageContentsOnce()
        {
            if (_contentScaled) return;
            if (tabControl1.TabPages.Count == 0) return;

            float sx = tabControl1.TabPages[0].Width / OriginalPageWidth;
            float sy = tabControl1.TabPages[0].Height / OriginalPageHeight;

            if (sx <= 0f || sy <= 0f) return;

            foreach (TabPage page in tabControl1.TabPages)
            {
                page.Margin = new Padding(0);
                page.Padding = new Padding(0);
                ScaleChildrenRecursive(page, sx, sy);
            }

            _contentScaled = true;
        }

        private void ScaleChildrenRecursive(Control parent, float sx, float sy)
        {
            foreach (Control c in parent.Controls)
            {
                if (!(c is TabControl) && !(c is TabPage))
                {
                    int newX = (int)Math.Round(c.Left * sx);
                    int newY = (int)Math.Round(c.Top * sy);
                    int newW = Math.Max(1, (int)Math.Round(c.Width * sx));
                    int newH = Math.Max(1, (int)Math.Round(c.Height * sy));
                    c.SetBounds(newX, newY, newW, newH);

                    int left = (int)Math.Round(c.Margin.Left * sx);
                    int top = (int)Math.Round(c.Margin.Top * sy);
                    int right = (int)Math.Round(c.Margin.Right * sx);
                    int bottom = (int)Math.Round(c.Margin.Bottom * sy);
                    c.Margin = new Padding(left, top, right, bottom);

                    int pleft = (int)Math.Round(c.Padding.Left * sx);
                    int ptop = (int)Math.Round(c.Padding.Top * sy);
                    int pright = (int)Math.Round(c.Padding.Right * sx);
                    int pbottom = (int)Math.Round(c.Padding.Bottom * sy);
                    c.Padding = new Padding(pleft, ptop, pright, pbottom);

                    if (!(c is PictureBox))
                    {
                        float fontScale = Math.Min(sx, sy);
                        float newSize = Math.Max(7.0f, c.Font.Size * fontScale);
                        if (Math.Abs(newSize - c.Font.Size) > 0.1f)
                        {
                            c.Font = new Font("Segoe UI", newSize, c.Font.Style, c.Font.Unit, c.Font.GdiCharSet, c.Font.GdiVerticalFont);
                        }
                    }
                }

                if (c.HasChildren)
                {
                    ScaleChildrenRecursive(c, sx, sy);
                }
            }
        }


        private void ApplyModernTheme()
        {
            if (_themeApplied) return;

            this.BackColor = Color.FromArgb(240, 244, 248);
            panelFrame.BackColor = Color.FromArgb(240, 244, 248);
            tabControl1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);

            foreach (TabPage page in tabControl1.TabPages)
            {
                page.BackColor = Color.FromArgb(235, 245, 255);
                page.ForeColor = Color.FromArgb(36, 48, 66);
            }

            StyleControlsRecursive(this);

            _themeApplied = true;
        }

        private void StyleControlsRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is GroupBox gb)
                {
                    gb.Font = new Font("Segoe UI Semibold", Math.Max(8.0F, gb.Font.Size), FontStyle.Bold);
                    gb.ForeColor = Color.FromArgb(41, 54, 73);
                    gb.BackColor = Color.FromArgb(248, 251, 255);
                    gb.Padding = new Padding(
                        Math.Max(4, gb.Padding.Left),
                        Math.Max(4, gb.Padding.Top),
                        Math.Max(4, gb.Padding.Right),
                        Math.Max(4, gb.Padding.Bottom)
                    );
                }
                else if (c is Button btn)
                {
                    btn.Font = new Font("Segoe UI Semibold", Math.Max(8.0F, btn.Font.Size), FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 136, 255);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 104, 214);
                    btn.BackColor = Color.FromArgb(52, 120, 246);
                    btn.ForeColor = Color.White;
                    btn.UseVisualStyleBackColor = false;
                }
                else if (c is Label lbl)
                {
                    if (lbl.Name.StartsWith("lbl"))
                    {
                        lbl.BackColor = Color.FromArgb(255, 252, 245);
                        lbl.ForeColor = Color.FromArgb(42, 42, 42);
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        lbl.ForeColor = Color.FromArgb(54, 65, 79);
                        if (lbl.BackColor == Color.Transparent)
                        {
                            lbl.BackColor = Color.Transparent;
                        }
                    }
                }
                else if (c is Panel pnl && c != panelFrame)
                {
                    pnl.BackColor = Color.FromArgb(243, 248, 253);
                }

                if (c.HasChildren)
                {
                    StyleControlsRecursive(c);
                }
            }
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color backColor;
            Color textColor = Color.White;

            switch (e.Index)
            {
                case 0:
                    backColor = Color.FromArgb(58, 125, 216);
                    break;
                case 1:
                    backColor = Color.FromArgb(0, 139, 139);
                    break;
                case 2:
                    backColor = Color.FromArgb(201, 140, 0);
                    break;
                case 3:
                    backColor = Color.FromArgb(129, 68, 207);
                    break;
                case 4:
                    backColor = Color.FromArgb(94, 145, 72);
                    break;
                default:
                    backColor = Color.SlateGray;
                    break;
            }

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Rectangle bounds = e.Bounds;

            using (SolidBrush bg = new SolidBrush(isSelected ? backColor : ControlPaint.Light(backColor, 0.25f)))
            {
                e.Graphics.FillRectangle(bg, bounds);
            }

            using (Pen borderPen = new Pen(Color.FromArgb(220, 228, 237)))
            {
                e.Graphics.DrawRectangle(borderPen, bounds);
            }

            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-6, -2);
            TextRenderer.DrawText(
                e.Graphics,
                tabControl1.TabPages[e.Index].Text,
                tabControl1.Font,
                paddedBounds,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnWindOut_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Wind Out button clicked");
        }

        private void btnWindUp_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Wind Up button clicked");
        }

        private void btnAutoLevelOnOff_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Auto Level On/Off button clicked");
        }

        private void btnTensionControl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Tension Control button clicked");
        }

        private void btnAntiLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Anti Load button clicked");
        }
    }
}
