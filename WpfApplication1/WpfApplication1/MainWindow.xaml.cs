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
using System.ComponentModel;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow 
    {

        //GMapMarker currentMarker;

        
        public MainWindow()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(MainWindow_Closing);
            

            
        }
        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GMaps.Instance.DisableTileHost();
            GMaps.Instance.CancelTileCaching();
        }

        //private void MainMap_TouchMove(object sender, TouchEventArgs e)
        //{
        //    Point currentPoint = e.GetTouchPoint(this).Position;
        //    PointLatLng currentLatLng = MainMap.FromLocalToLatLng((int)currentPoint.X, (int)currentPoint.Y);

        //}

        //private void MainMap_TouchDown(object sender, TouchEventArgs e)
        //{
        //    TouchPoint t = e.GetTouchPoint(MainMap);
        //    Point p = t.Position;
        //    currentMarker.Position = MainMap.FromLocalToLatLng((int)p.X, (int)p.Y);
        //    if (MainMap.TouchesCaptured.Count() == 2)
        //    {
        //        _mapTab.Header = "Hi";
        //    }


        //}
        //private void MainMap_PositionChanged(PointLatLng point)
        //{

        //}
    }
}
