using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
	public class YelpCoordinates
	{
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
		public double Longitude { get; set; }
	}
}
