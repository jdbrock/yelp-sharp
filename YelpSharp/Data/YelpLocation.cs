using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
	public class YelpLocation
	{
        /// <summary>
        /// Coordinates of the business.
        /// </summary>
        public YelpCoordinates coordinate { get; set; }

        /// <summary>
        /// Street address of the business.
        /// </summary>
		public string[] address { get; set; }

        /// <summary>
        /// Address of the business formatted for display. Includes all address fields, cross streets and city, state_code, etc.
        /// </summary>
		public string[] display_address { get; set; }

        /// <summary>
        /// City of the business.
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// ISO 3166-2 state code for the business (http://en.wikipedia.org/wiki/ISO_3166-2).
        /// </summary>
        public string state_code { get; set; }

        /// <summary>
        /// Postal code of the business (http://en.wikipedia.org/wiki/Postal_code).
        /// </summary>
        public string postal_code { get; set; }

        /// <summary>
        /// ISO 3166-1 country code for the business (http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).
        /// </summary>
        public string country_code { get; set; }

        /// <summary>
        /// Cross streets of the business.
        /// </summary>
        public string cross_streets { get; set; }

        /// <summary>
        /// List that provides neighborhood information for the business.
        /// </summary>
        public string[] neighborhoods { get; set; }

        /// <summary>
        /// Contains a value that corresponds to the accuracy with which the latitude / longitude was determined in the geocoder. These correspond to Google's GGeoAddressAccuracy field. (http://code.google.com/apis/maps/documentation/javascript/v2/reference.html#GGeoAddressAccuracy).
        /// </summary>
        public double geo_accuracy { get; set; }

        [JsonIgnore]
        public String DisplayAddress => address != null ? String.Join(", ", address.Where(X => !String.IsNullOrWhiteSpace(X))) : "Unknown";

        public override string ToString()
        {
            return DisplayAddress;
        }
    }
}
