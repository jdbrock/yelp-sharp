using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpSearchOptionsMapLocation : IYelpSearchOptionsLocation
    {
        // ===========================================================================
        // = Public Properties
        // ===========================================================================
        
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double? Accuracy { get; private set; }
        public double? Altitude { get; private set; }
        public double? AltitudeAccuracy { get; private set; }

        // ===========================================================================
        // = Construction
        // ===========================================================================

        public YelpSearchOptionsMapLocation(double latitude, double longitude, double? accuracy = null, double? altitude = null, double? altitudeAccuracy = null)
        {
            Latitude = latitude;
            Longitude = longitude;
            Accuracy = accuracy;
            Altitude = altitude;
            AltitudeAccuracy = altitudeAccuracy;
        }

        // ===========================================================================
        // = Public Methods
        // ===========================================================================
        
        public IDictionary<string, string> GenerateParameters()
        {
            var location = String.Join(",", new double?[] { Latitude, Longitude, Accuracy, Altitude, AltitudeAccuracy }.Where(X => X != null));

            return new Dictionary<string, string>
            {
                { "ll", location }
            };
        }
    }
}
