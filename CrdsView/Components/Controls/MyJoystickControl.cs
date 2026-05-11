using Joystick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoystickTest.MyJoystickControl
{
    public partial class MyJoystickControl : UserControl
    {
        public MyJoystickControl()
        {
            InitializeComponent();

            joyBack1.JoystickMoveEvent += new Joystick.JoystickMoveEventHandler(doAction);
        }

        public void doAction(string message)
        {
            textBox1.Text = message;
        }
    }
}

namespace Joystick
{

    public delegate void NotifyParentDelegate(CustomEventArgs customEventArgs);
    public delegate void JoystickMoveEventHandler(string message);
    public class JoyBack : PictureBox
    {

        public CentreStick Joystick;
        public event EventHandler JoyReleased;
        public string joystickPosition = string.Empty;

        public event JoystickMoveEventHandler JoystickMoveEvent;

        public JoyBack()
        {
            this.DoubleBuffered = true;
            Size s = new Size(150, 150);
            this.MaximumSize = s;
            this.MinimumSize = s;
            this.Size = s;
            AttachStick();
        }

        private void _child_NotifyParentEvent(CustomEventArgs customEventArgs)
        {
            joystickPosition = customEventArgs.Msg;
            if (JoystickMoveEvent != null) JoystickMoveEvent(joystickPosition);
        }

        async Task AttachStick()
        {
            await Task.Delay(100);
            Joystick = new CentreStick(this);
            Joystick.NotifyParentEvent += new NotifyParentDelegate(_child_NotifyParentEvent);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.DrawImage(global::CrdsView.Properties.Resources.back1, 0, 0);

            base.OnPaint(pe);
        }

        private Rectangle MakeRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        public void CallReleased()
        {
            if (JoyReleased != null)
                JoyReleased(null, null);
        }
    }

    public class CentreStick : PictureBox
    {

        public bool active;
        private Point eOriginalPos;
        private Point defaultPos;

        public int angle = 0;
        public int distance = 0;
        public Point coords = new Point(0, 0);
        private Image image = null;

        public float maxDist = 63;

        JoyBack b;

        public event NotifyParentDelegate NotifyParentEvent;

        public CentreStick(JoyBack myBack)
        {
            b = myBack;
            this.Parent = b;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.BackColor = Color.Transparent;
            image = global::CrdsView.Properties.Resources.circle;
            //this.Size = new Size((int)Math.Round(Parent.Width / 3f), (int)Math.Round(Parent.Height / 3f));
            this.Size = image.Size;

            SetDefaultPos();
        }

        async Task SetDefaultPos()
        {
            await Task.Delay(100);
            defaultPos = new Point((int)Math.Round(Parent.Width / 2f - Width / 2f), (int)Math.Round(Parent.Height / 2f - Height / 2f));
            Centre();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //pe.Graphics.DrawImage(global::CrdsView.Properties.Resources.circle, new Point(0, 0));
            pe.Graphics.DrawImage(image, new Point(0, 0));

            base.OnPaint(pe);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Cursor = Cursors.SizeAll;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            Cursor = Cursors.Default;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            active = true;
            eOriginalPos = e.Location;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            Centre();
            b.CallReleased();
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var newLocation = Location;
            if (active)
            {
                newLocation.Offset(e.Location.X - eOriginalPos.X, e.Location.Y - eOriginalPos.Y);

                float dist = Distance(defaultPos, newLocation);
                Point dir = new Point(newLocation.X - defaultPos.X, newLocation.Y - defaultPos.Y);

                if (dist > maxDist)
                {
                    dir = new Point(Convert.ToInt32(dir.X * (maxDist / dist)), Convert.ToInt32(dir.Y * (maxDist / dist)));
                }

                Location = new Point(defaultPos.X + dir.X, defaultPos.Y + dir.Y);
                angle = Convert.ToInt32((float)Math.Atan2(dir.Y, dir.X) * (180f / 3.1415926535f) + 180);
                distance = Distance(defaultPos, Location);

                coords = new Point(Location.X - defaultPos.X, defaultPos.Y - Location.Y);

                NotifyParent(coords.ToString());
            }

            base.OnMouseMove(e);
        }


        public void UpdateJoystickCentre()
        {
            defaultPos = Location;
        }

        public void Centre()
        {
            active = false;
            Location = defaultPos;
            angle = 0;
            distance = 0;
            coords = new Point(0, 0);
        }

        int Distance(Point p1, Point p2)
        {
            return Convert.ToInt32((float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)));
        }

        public void NotifyParent(string msg)
        {
            if (NotifyParentEvent != null)
            {
                CustomEventArgs customEventArgs = new CustomEventArgs(msg);
                // Raise event. All the listeners of this event will get a call.
                customEventArgs.Msg = "Moving to " + msg;
                NotifyParentEvent(customEventArgs);
            }
        }
    }
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string msg)
        {
            _msg = msg;
        }

        private string _msg;

        public string Msg
        {
            get { return _msg; }
            set { _msg = value; }
        }
    }

}
