using System.Collections.Generic;

namespace YelpSharp
{
    public class YelpSearchResults
    {
        /// <summary>
        /// Businesses found.
        /// </summary>
        public List<YelpBusiness> businesses { get; set; }

        /// <summary>
        /// Suggested bounds of the map.
        /// </summary>
        public YelpRegion region { get; set; }

        /// <summary>
        /// Number of businesses found.
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// Yelp error message or null.
        /// </summary>
        public YelpSearchError error { get; set; }
    }
}
