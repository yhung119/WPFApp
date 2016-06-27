using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace WpfApplication1.MapControl
{
    
    public class UserLocation
    {
        private GeoCoordinateWatcher geoCoordinateWatcher;

        public void StartTracking()
        {
            if(this.geoCoordinateWatcher != null)
            {
                return;
            }
            this.geoCoordinateWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            this.geoCoordinateWatcher.MovementThreshold = 100;
            this.geoCoordinateWatcher.PositionChanged += (watcherSender, eventArgs) => { };
            
            geoCoordinateWatcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
                
            
        }

        public void StopTracking()
        {
            if(this.geoCoordinateWatcher == null)
            {
                return;
            }
            geoCoordinateWatcher.Stop();
            geoCoordinateWatcher.Dispose();
            geoCoordinateWatcher = null;
        }

        public GeoPosition<GeoCoordinate> getPosition()
        {
            if (geoCoordinateWatcher == null)
            {
                StartTracking();
            }
            return geoCoordinateWatcher.Position;
        }
    }
}
