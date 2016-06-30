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
using WpfApplication1;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for ObservationTab.xaml
    /// </summary>
    public partial class ObservationTab : Grid
    {
        
        public ObservationTab()
        {
           
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow)._tabControl.SelectedItem = ((MainWindow)System.Windows.Application.Current.MainWindow)._debrisFlowTab;
            

        }
        
        private void Tile_TouchDown(object sender, TouchEventArgs e)
        {
            Tile2.Title = "hi";
        }
    }
}
