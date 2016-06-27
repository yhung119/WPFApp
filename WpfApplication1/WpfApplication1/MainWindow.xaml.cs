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
using MahApps.Metro.Controls;
using GMap.NET;
using System.Device.Location;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using WpfApplication1.MapControl;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow 
    {

        GMapMarker currentMarker;

        
        public MainWindow()
        {
            InitializeComponent();
            
            //config map
            MainMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            MainMap.Position = new PointLatLng(23.6978, 120.9650);
            MainMap.OnPositionChanged += new PositionChanged(MainMap_PositionChanged);
            MainMap.Zoom = 8;
            MainMap.TouchEnabled = true;
            MainMap.TouchDown += new EventHandler<TouchEventArgs>(MainMap_TouchDown);

            //marker
            currentMarker = new GMapMarker(MainMap.Position);
            {
                
                currentMarker.Shape = new RedMarker(this,currentMarker,"Marker");
                currentMarker.Offset = new Point(-15, -15);
                currentMarker.ZIndex = int.MaxValue;
                MainMap.Markers.Add(currentMarker);
            }

            
        }

        private void MainMap_TouchMove(object sender, TouchEventArgs e)
        {
            Point currentPoint = e.GetTouchPoint(this).Position;
            PointLatLng currentLatLng = MainMap.FromLocalToLatLng((int)currentPoint.X, (int)currentPoint.Y);

        }

        private void MainMap_TouchDown(object sender, TouchEventArgs e)
        {
            TouchPoint t = e.GetTouchPoint(MainMap);
            Point p = t.Position;
            currentMarker.Position = MainMap.FromLocalToLatLng((int)p.X, (int)p.Y);
            if (MainMap.TouchesCaptured.Count() == 2)
            {
                _mapTab.Header = "Hi";
            }
            

        }
        private void MainMap_PositionChanged(PointLatLng point)
        {

        }

        private async void _mapTab_TouchDown(object sender, TouchEventArgs e)
        {
            //position
            GeoCoordinateWatcher geoCoordinateWatcher;
            geoCoordinateWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            geoCoordinateWatcher.MovementThreshold = 100;
            geoCoordinateWatcher.PositionChanged += (watcherSender, eventArgs) => { };

            geoCoordinateWatcher.TryStart(false, TimeSpan.FromMilliseconds(2000));

            GeoPosition<GeoCoordinate> geoPosition = geoCoordinateWatcher.Position;
            await Task.Delay(5000);
            if (geoPosition == null)
            {
                _observationTab.Header = String.Format("{0}+{1}", geoPosition.Location.Altitude, geoPosition.Location.Latitude);
            }
        }
    }
}
