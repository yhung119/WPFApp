using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using WpfApplication1.MapControl;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for GMAP.xaml
    /// </summary>
    public partial class GMAP : UserControl
    {
        private GMapMarker currentMarker;
        private PointLatLng lastPoint;
        public GMAP()
        {
            InitializeComponent();
            Map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            Map.Position = new PointLatLng(23.6978, 120.9650);
            Map.Zoom = 8;

            //touch events
            Map.TouchDown += new EventHandler<TouchEventArgs>(Map_TouchDown);
        }
        private void Map_TouchDown(object sender, TouchEventArgs e)
        {
            TouchPoint tp = e.GetTouchPoint(this);
            Point p = tp.Position;
            lastPoint = new PointLatLng((int)p.X, (int)p.Y);
        }
        private void ZoomIn_Click(object sender, EventArgs e)
        {
            Map.Zoom++;
        }
        private void ZoomOut_Click(object sender, EventArgs e)
        {
            Map.Zoom--;
        }

        private void Add_Marker_Click(object sender, EventArgs e)
        {
            if (lastPoint != null)
            {
                PointLatLng p = lastPoint;
                GMapMarker marker = new GMapMarker(Map.Position);
                {
                    marker.Shape = new RedMarker(this, marker, "Marker");
                    marker.Offset = new Point(-15, -15);
                    marker.ZIndex = int.MaxValue;
                    this.Map.Markers.Add(marker);
                }
            }
        }

    }
}
