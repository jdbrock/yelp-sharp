using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpSearchOptionsLocation : IYelpSearchOptionsLocation
    {
        // ===========================================================================
        // = Public Properties
        // ===========================================================================

        /// <summary>
        /// Location search terms, e.g. neighbourhood, city, etc.
        /// </summary>
        public string Location { get; private set; }

        /// <summary>
        /// Hint to the geocoder to disambiguate the location text.
        /// </summary>
        public YelpCoordinates Coordinates { get; private set; }

        // ===========================================================================
        // = Construction
        // ===========================================================================
        
        public YelpSearchOptionsLocation(string location, YelpCoordinates coordinates = null)
        {
            // Verify the location has been specified.
            if (location == null)
                throw new ArgumentNullException(nameof(location));

            if (String.IsNullOrWhiteSpace(location))
                throw new ArgumentException($"The {nameof(location)} parameter must be specified.", nameof(location));

            // Store parameters.
            Location = location;
            Coordinates = coordinates;
        }

        // ===========================================================================
        // = Public Methods
        // ===========================================================================

        public IDictionary<string, string> GenerateParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "location", Location }
            };

            // Include coordinates if specified.
            if (Coordinates?.Longitude != null && Coordinates?.Latitude != null)
                parameters.Add("cll", $"{Coordinates.Latitude},{Coordinates.Longitude}");
            
            return parameters;
        }
    }
}
