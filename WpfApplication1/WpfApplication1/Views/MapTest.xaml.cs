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

            TestMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            TestMap.Position = new PointLatLng(23.6978, 120.9650);
            TestMap.OnPositionChanged += new PositionChanged(TestMap_PositionChanged);
            ZoomIn.TouchDown += new EventHandler<TouchEventArgs>(ZoomIn_Button_Touch);
            ZoomOut.TouchDown += new EventHandler<TouchEventArgs>(ZoomOut_Button_Touch);

        }

        private void ZoomIn_Button_Touch(object sender, TouchEventArgs t)
        {
            TestMap.Zoom ++;
        }
        private void ZoomOut_Button_Touch(object sender, TouchEventArgs t)
        {
            TestMap.Zoom--;
        }

        private void TestMap_PositionChanged(PointLatLng point)
        {

        }
    }
}
