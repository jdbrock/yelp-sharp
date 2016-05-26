using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpSearchOptionsMapExtent : IYelpSearchOptionsLocation
    {
        // ===========================================================================
        // = Public Properties
        // ===========================================================================
        
        public double LatitudeSouthWest { get; set; }
        public double LongitudeSouthWest { get; set; }
        public double LatitudeNorthEast { get; set; }
        public double LongitudeNorthEast { get; set; }

        // ===========================================================================
        // = Construction
        // ===========================================================================

        public YelpSearchOptionsMapExtent(double latitudeSouthWest, double longitudeSouthWest,
                                   double latitudeNorthEast, double longitudeNorthEast)
        {
            LatitudeSouthWest  = latitudeSouthWest;
            LongitudeSouthWest = longitudeSouthWest;
            LatitudeNorthEast  = latitudeNorthEast;
            LongitudeNorthEast = longitudeNorthEast;
        }

        // ===========================================================================
        // = Public Methods
        // ===========================================================================

        public IDictionary<string, string> GenerateParameters()
        {
            return new Dictionary<string, string>
            {
                { "bounds", $"{LatitudeSouthWest},{LongitudeSouthWest}|{LatitudeNorthEast},{LongitudeNorthEast}" }
            };
        }
    }
}
