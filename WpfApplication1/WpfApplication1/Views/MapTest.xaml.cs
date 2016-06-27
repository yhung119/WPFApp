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
        public MapTest()
        {
            InitializeComponent();

            Map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            Map.Position = new PointLatLng(23.6978, 120.9650);
            Map.OnPositionChanged += new PositionChanged(TestMap_PositionChanged);
            ZoomIn.TouchDown += new EventHandler<TouchEventArgs>(ZoomIn_Button_Touch);
            ZoomOut.TouchDown += new EventHandler<TouchEventArgs>(ZoomOut_Button_Touch);
            ZoomIn.Click += new System.Windows.RoutedEventHandler(ZoomIn_Click);
            ZoomOut.Click += new System.Windows.RoutedEventHandler(ZoomOut_Click);
        }

        private void ZoomIn_Button_Touch(object sender, TouchEventArgs t)
        {
            Map.Zoom++;
        }
        private void ZoomOut_Button_Touch(object sender, TouchEventArgs t)
        {
            Map.Zoom--;
        }
        private void ZoomIn_Click(object sender, RoutedEventArgs m)
        {
            ZoomIn_Button_Touch(sender, null);
        }
        private void ZoomOut_Click(object sender, RoutedEventArgs m)
        {
            ZoomOut_Button_Touch(sender, null);
        }



        private void TestMap_PositionChanged(PointLatLng point)
        {

        }
    }
}
