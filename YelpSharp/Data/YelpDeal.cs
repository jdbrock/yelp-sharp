using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpDeal
    {
        /// <summary>
        /// Deal ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Deal title..
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Deal URL.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Deal image URL.
        /// </summary>
        public string image_url { get; set; }

        /// <summary>
        /// Currency code: http://en.wikipedia.org/wiki/ISO_4217.
        /// </summary>
        public string currency_code { get; set; }

        /// <summary>
        /// Start time (Unix timestamp).
        /// </summary>
        public double time_start { get; set; }

        /// <summary>
        /// End time (can be null).
        /// </summary>
        public double time_end { get; set; }

        /// <summary>
        /// Additional details.
        /// </summary>
        public string what_you_get { get; set; }

        /// <summary>
        /// Restrictions.
        /// </summary>
        public string important_restrictions { get; set; }

        /// <summary>
        /// Additional restrictions.
        /// </summary>
        public string additional_restrictions { get; set; }

        /// <summary>
        /// Options.
        /// </summary>
        public List<YelpDealOptions> options { get; set; }   
    }
}
