﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace WpfApplication1
{
    class Position
    {
        GeoCoordinateWatcher watcher;

        public void GetLocationEvent()
        {
            this.watcher = new GeoCoordinateWatcher();
            this.watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            bool started = this.watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));
            if (!started)
            {
                Console.WriteLine("GeoCoordinateWatcher timed out on start.");
            }
       } 

        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            PrintPosition(e.Position.Location.Latitude, e.Position.Location.Longitude);
        }

        void PrintPosition(double Latitude, double Longitude)
        {
            Console.WriteLine("Latitude: {0}, Longitude {1}", Latitude, Longitude);
        }
    }
}
