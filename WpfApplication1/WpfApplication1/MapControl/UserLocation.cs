using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
//using Windows.Devices.Geolocation;

namespace WpfApplication1
{
    
    public class UserLocation
    {
        private GeoCoordinateWatcher geoCoordinateWatcher;
        
        private double _latitude;
        public double Latitude {
            get
            {
                return _latitude;
            }
            set
            {
                this._latitude = value;
            }
        }
        private double _longitude;
        public double Longitude {
            get
            {
                return _longitude;
            }
            set
            {
                _longitude = value;
            }
        }
        private string _status;
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public void StartTracking()
        {
            if(this.geoCoordinateWatcher != null)
            {
                return;
            }
            this.geoCoordinateWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            this.geoCoordinateWatcher.MovementThreshold = 100;
            

            geoCoordinateWatcher.Start();
            this.geoCoordinateWatcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged);


        }
        public void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case GeoPositionStatus.Initializing:
                    this.Status = "Initializing";
                    break;
                case GeoPositionStatus.Ready:
                    this.Status ="Ready";
                    this.Longitude = this.geoCoordinateWatcher.Position.Location.Longitude;
                    this.Latitude = this.geoCoordinateWatcher.Position.Location.Latitude;
                    break;
                case GeoPositionStatus.NoData:
                    this.Status = "NoData";
                    break;
                case GeoPositionStatus.Disabled:
                    this.Status = "Disabled";
                    break;
            }
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
            _latitude = 0;
            _longitude = 0;
            _status = null;

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
