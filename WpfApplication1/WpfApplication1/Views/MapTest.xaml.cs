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
using System.Device.Location;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using WpfApplication1.MapControl;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DebrisFlowPage.xaml
    /// </summary>
    public partial class MapTest
    {

        //GMapMarker currentMarker;
        public MapTest()
        {
            InitializeComponent();

            //Map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //Map.Position = new PointLatLng(23.6978, 120.9650);
            //Map.OnPositionChanged += new PositionChanged(TestMap_PositionChanged);
            //Map.Zoom = 8;
            //Map.TouchDown += new EventHandler<TouchEventArgs>(Map_Single_TouchDown);
           
            


            //ZoomIn.Click += new System.Windows.RoutedEventHandler(ZoomIn_Click);
            //ZoomOut.Click += new System.Windows.RoutedEventHandler(ZoomOut_Click);


            //currentMarker = new GMapMarker(Map.Position);
            //{

            //    currentMarker.Shape = new RedMarker(this, currentMarker, "Marker");
            //    currentMarker.Offset = new Point(-15, -15);
            //    currentMarker.ZIndex = int.MaxValue;
            //    Map.Markers.Add(currentMarker);
            //}
        }

        //private void ZoomIn_Click(object sender, RoutedEventArgs m)
        //{
        //    Map.Zoom++;
        //}
        //private void ZoomOut_Click(object sender, RoutedEventArgs m)
        //{
        //    Map.Zoom--;
        //}
        
        //private void Map_Single_TouchDown(object sender, TouchEventArgs t)
        //{
        //    TouchPoint first = t.GetTouchPoint(Map);

        //    if (Map.TouchesCaptured.Count() == 1)
        //    {
                
        //        //Map.CanDragMap = false;
        //        Map_Double_TouchDown(first,  t);
                
                
        //    }else
        //    {
               
        //        Map.CanDragMap = true;
        //    }
        //}
        //private void Map_Double_TouchDown(TouchPoint first_touch, TouchEventArgs t)
        //{
        //    Point p1 = first_touch.Position;
        //    Point p2 = t.GetTouchPoint(Map).Position;

        //}
        //private void Query_Funct(object sender,QueryContinueDragEventArgs q)
        //{
        //    if (Map.AreAnyTouchesOver == true)
        //    {
        //        Map.CanDragMap = false;
        //    }
        //}

        //private void TestMap_PositionChanged(PointLatLng point)
        //{

        //}

        //private void _mapCanvas_ManipulationInertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
        //{

        //}

        //private void _mapCanvas_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        //{
        //    this.Map.Zoom = e.DeltaManipulation.Scale.X;
        //    e.Handled = true;
        //}
    }
}
