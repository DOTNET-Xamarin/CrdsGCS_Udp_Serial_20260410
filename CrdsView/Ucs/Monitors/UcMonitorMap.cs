using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using System.IO;
using CrdsView.Ucs.Monitors.Marker;
using CrdsController.Controllers;
using CrdsView.Ucs.Common;
using GMap.NET.MapProviders.Custom;

namespace CrdsView.Ucs.Monitors
{
    public partial class UcMonitorMap : UserControl, IUcTops, IUcTop
    {
        public UcMonitorMap()
        {
            InitializeComponent();
        }

        protected Timer Timer { get; set; }
        protected double Longitude { get; set; }
        protected double Latitude { get; set; }

        protected double delta = 0;

        private const int MainTabPanelWidth = 860;
        private const int MainTabPanelExpandedHeight = 205;

        private const int StatusPanelExpandedWidth = 591;
        private const int StatusPanelTop = 65;
        private const int StatusPanelRightMargin = 0;

        private const int SlideTriggerSize = 20;
        private const int SlideInterval = 15;
        private const int SlideStep = 60;

        private int tabMinHeight = 0;
        private int tabMaxHeight = MainTabPanelExpandedHeight;

        private int statusMinWidth = 0;
        private int statusMaxWidth = StatusPanelExpandedWidth;

        private bool isShowing = false;
        private bool isHiding = false;

        private bool isStatusShowing = false;
        private bool isStatusHiding = false;

        public void Track()
        {
            this.Timer.Start();
        }

        public void UnTrack()
        {
            this.Timer.Stop();
        }

        public void SetTops(List<Control> controls)
        {
            foreach (Control c in controls)
            {
                if (this.gMapControl.Controls.Contains(c)) continue;
                this.gMapControl.Controls.Add(c);
            }
        }

        public void SetTop(Control control)
        {
            if (this.gMapControl.Controls.Contains(control)) return;
            this.gMapControl.Controls.Add(control);
        }

        public void SetBottomHud(Label label)
        {
            label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.gMapControl.Controls.Add(label);
        }

        public void SetMapServerCustomUrl(string url)
        {
            CustomMapProviders.VectorMap.ServerUrlCustom = url;
            this.gMapControl.Zoom = (this.gMapControl.Zoom) * -1;
            this.gMapControl.Zoom = (this.gMapControl.Zoom) * -1;
        }

        public void SetMapProvider(int mapIndex)
        {
            switch (mapIndex)
            {
                case 0:
                    gMapControl.MapProvider = CustomMapProviders.ImageMap;
                    break;
                case 1:
                    gMapControl.MapProvider = CustomMapProviders.ImageMap;
                    break;
                case 2:
                    gMapControl.MapProvider = CustomMapProviders.VectorMap;
                    break;
                case 3:
                    gMapControl.MapProvider = CustomMapProviders.VectorMap;
                    break;
                default:
                    break;
            }
        }

        #region Init UI

        private void InitUI_UcMonitorMap_NoJapanSea()
        {
            PointLatLng ptEastSeaPos = new PointLatLng();
            ptEastSeaPos.Lat = 39.8;
            ptEastSeaPos.Lng = 134.3;

            List<PointLatLng> points = new List<PointLatLng>();
            double lat = 0.15, lng = 0.4;
            points.Add(new PointLatLng(ptEastSeaPos.Lat - lat, ptEastSeaPos.Lng - lng));
            points.Add(new PointLatLng(ptEastSeaPos.Lat - lat, ptEastSeaPos.Lng + lng));
            points.Add(new PointLatLng(ptEastSeaPos.Lat + lat, ptEastSeaPos.Lng + lng));
            points.Add(new PointLatLng(ptEastSeaPos.Lat + lat, ptEastSeaPos.Lng - lng));

            GMapOverlay noJapanOverlay = new GMapOverlay();

            GMapPolygon polygon = new GMapPolygon(points, "No JapanSea");
            polygon.Fill = new SolidBrush(Color.FromArgb(255, 75, 98, 165));
            polygon.Stroke = new Pen(Brushes.Transparent);
            polygon.Tag = "NoJapanSea";
            noJapanOverlay.Polygons.Add(polygon);
            gMapControl.Overlays.Add(noJapanOverlay);

            Label text = new Label();
            text.Text = "East Sea";
            text.TextAlign = ContentAlignment.MiddleCenter;
            text.Width = 200;
            text.Height = 80;
        }

        private void InitUI_UcMonitorMap_Default()
        {
            gMapControl.EmptyMapBackground = Color.Navy;
            gMapControl.MouseWheelZoomEnabled = true;
            gMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.MapProvider = CustomMapProviders.VectorMap;

            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            string strPath = @"C:\CrdsGcs_MapCache";
            if (!Directory.Exists(strPath))
            {
                Directory.CreateDirectory(strPath);
            }
            gMapControl.CacheLocation = strPath;

            gMapControl.MaxZoom = 15;
            gMapControl.MinZoom = 5;
            gMapControl.Zoom = 8;
            gMapControl.Position = new PointLatLng(36.432441, 127.395067);

            gMapControl.ShowCenter = false;
            gMapControl.IgnoreMarkerOnMouseWheel = true;
        }

        private void InitUI_Timer()
        {
            this.Timer = new Timer();
            this.Timer.Interval = 250;
            this.Timer.Tick += Timer_Tick;
        }

        private void InitUI_UcMonitorMap()
        {
            isHiding = true;
            isShowing = false;

            tabMaxHeight = Math.Max(ucMainTabControl1.Height, MainTabPanelExpandedHeight);
            wrapperPanel.Width = Math.Min(MainTabPanelWidth, this.ClientSize.Width);
            wrapperPanel.Height = 0;

            isStatusHiding = true;
            isStatusShowing = false;

            statusMaxWidth = Math.Max(ucStatusTabControl1.Width + ucStatusTabControl1.Left + 1, StatusPanelExpandedWidth);
            wrapperPanel2.Width = 0;

            timerSlide.Interval = SlideInterval;
            timerSlide.Tick -= timerSlide_Tick;
            timerSlide.Tick += timerSlide_Tick;

            timerSlide2.Interval = SlideInterval;
            timerSlide2.Tick -= timerSlide2_Tick;
            timerSlide2.Tick += timerSlide2_Tick;

            UpdateMainTabLayout();
            UpdateStatusPanelLayout();

            wrapperPanel.BringToFront();
            wrapperPanel2.BringToFront();

            this.InitUI_UcMonitorMap_Default();
            this.InitUI_Timer();

            wrapperPanel.BringToFront();
            wrapperPanel2.BringToFront();

            ucStatusTabControl1.MainMotorRpm = 1800F;
            ucStatusTabControl1.MainMotorPower = 3.5F;
            this.UavPosition = new PointLatLng(36.5, 127.2);
            this.SetCenter(this.UavPosition);
        }

        private void UpdateMainTabLayout()
        {
            wrapperPanel.Width = Math.Min(MainTabPanelWidth, this.ClientSize.Width);
            wrapperPanel.Left = 0;
            wrapperPanel.Top = this.ClientSize.Height - wrapperPanel.Height;
        }

        private void UpdateStatusPanelLayout()
        {
            wrapperPanel2.Height = ucStatusTabControl1.Height + ucStatusTabControl1.Top + 1;

            int right = this.ClientSize.Width - wrapperPanel2.Width - StatusPanelRightMargin;
            if (right < 0) right = 0;

            wrapperPanel2.Left = right;
            wrapperPanel2.Top = StatusPanelTop;
        }

        private bool IsMouseInsideWrapper()
        {
            Rectangle rect = wrapperPanel.RectangleToScreen(wrapperPanel.ClientRectangle);
            return rect.Contains(Cursor.Position);
        }

        private bool IsMouseInsideWrapper2()
        {
            Rectangle rect = wrapperPanel2.RectangleToScreen(wrapperPanel2.ClientRectangle);
            return rect.Contains(Cursor.Position);
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (isShowing)
            {
                wrapperPanel.Height += SlideStep;

                if (wrapperPanel.Height >= tabMaxHeight)
                {
                    wrapperPanel.Height = tabMaxHeight;
                    isShowing = false;
                }

                UpdateMainTabLayout();
                return;
            }

            if (!isHiding && wrapperPanel.Height == tabMaxHeight)
            {
                bool mouseInWrapper = IsMouseInsideWrapper();
                bool mouseNearBottom =
                    Cursor.Position.Y >= this.PointToScreen(Point.Empty).Y + this.ClientSize.Height - SlideTriggerSize;
                bool mouseOverRight =
                    Cursor.Position.X >= this.PointToScreen(Point.Empty).X + wrapperPanel.Width + SlideTriggerSize;

                if (!mouseInWrapper && !mouseNearBottom)
                {
                    isHiding = true;
                }

                if (mouseOverRight)
                {
                    isHiding = true;
                }
            }

            if (isHiding)
            {
                wrapperPanel.Height -= SlideStep;

                if (wrapperPanel.Height <= tabMinHeight)
                {
                    wrapperPanel.Height = tabMinHeight;
                    isHiding = false;
                    timerSlide.Stop();
                }

                UpdateMainTabLayout();
            }
        }

        private void timerSlide2_Tick(object sender, EventArgs e)
        {
            if (isStatusShowing)
            {
                wrapperPanel2.Width += SlideStep;

                if (wrapperPanel2.Width >= statusMaxWidth)
                {
                    wrapperPanel2.Width = statusMaxWidth;
                    isStatusShowing = false;
                }

                UpdateStatusPanelLayout();
                return;
            }

            if (!isStatusHiding && wrapperPanel2.Width == statusMaxWidth)
            {
                bool mouseInWrapper2 = IsMouseInsideWrapper2();
                bool mouseNearRight =
                    Cursor.Position.X >= this.PointToScreen(Point.Empty).X + this.ClientSize.Width - SlideTriggerSize;

                if (!mouseInWrapper2 && !mouseNearRight)
                {
                    isStatusHiding = true;
                }
            }

            if (isStatusHiding)
            {
                wrapperPanel2.Width -= SlideStep;

                if (wrapperPanel2.Width <= statusMinWidth)
                {
                    wrapperPanel2.Width = statusMinWidth;
                    isStatusHiding = false;
                    timerSlide2.Stop();
                }

                UpdateStatusPanelLayout();
            }
        }

        #endregion

        #region Events

        public event EventHandler<VehiclePosEventArgs> VehiclePosChanged;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (InterfaceController.Instance.GetCurrentVehicle() == null)
            {
                return;
            }

            this.Longitude = InterfaceController.Instance.GetCurrentVehicle().Longitude;
            this.Latitude = InterfaceController.Instance.GetCurrentVehicle().Latitude;

            delta += 0.1;
            VehiclePosEventArgs vehiclePosEventArgs = new VehiclePosEventArgs();
            vehiclePosEventArgs.Longitude = 127.2 + delta;
            vehiclePosEventArgs.Latitude = 36.5 + delta;
            VehiclePosChanged?.Invoke(this, vehiclePosEventArgs);

            this.UavPosition = new PointLatLng(Latitude, Longitude);

            this.UavPosition = new PointLatLng(36.5, 127.2);
            this.SetCenter(this.UavPosition);
        }

        private void UcMap_Load(object sender, EventArgs e)
        {
            this.InitUI_UcMonitorMap();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            UpdateMainTabLayout();
            UpdateStatusPanelLayout();

            wrapperPanel.BringToFront();
            wrapperPanel2.BringToFront();
        }

        #endregion

        #region Draw Uav

        private string flightname = "flight";

        private void DrawUAV(PointLatLng point)
        {
            GMapOverlay overlay = this.gMapControl.Overlays.Where(uav => uav.Id == this.flightname).FirstOrDefault();

            if (overlay is null)
            {
                GMapOverlay t_overlay = new GMapOverlay(this.flightname);

                string bitmapPath = Path.Combine(Application.StartupPath, "Resources", "drone32.png");
                Bitmap drone_image = new Bitmap(bitmapPath);

                GMapDrone t_drone = new GMapDrone(point, this.flightname, drone_image);
                t_overlay.Markers.Add(t_drone);
                this.gMapControl.Overlays.Add(t_overlay);
                return;
            }

            var drone = overlay.Markers.Where(marker => (string)marker.Tag == this.flightname).FirstOrDefault();

            if (drone is null)
            {
                return;
            }

            (drone as GMapDrone).SetPosition(point);
        }

        private PointLatLng UavPosition { get; set; }

        private void SetCenter(PointLatLng center)
        {
            this.Invoke((Action)delegate
            {
                this.gMapControl.Position = center;
                this.DrawUAV(center);
            });
        }

        #endregion

        private void gMapControl_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y >= this.ClientSize.Height - SlideTriggerSize) &&
                (wrapperPanel.Height == 0) &&
                (e.X <= wrapperPanel.Width))
            {
                isShowing = true;
                isHiding = false;
                timerSlide.Start();
            }

            if ((e.X >= this.ClientSize.Width - SlideTriggerSize) &&
                (wrapperPanel2.Width == 0))
            {
                isStatusShowing = true;
                isStatusHiding = false;
                timerSlide2.Start();
            }
        }
    }

    public class VehiclePosEventArgs : EventArgs
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}