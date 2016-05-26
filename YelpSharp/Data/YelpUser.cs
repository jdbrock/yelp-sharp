using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    /// <summary>
    /// Yelp user.
    /// </summary>
    public class YelpUser
    {
        /// <summary>
        /// User ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// User profile image URL.
        /// </summary>
        public string image_url { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        public string name { get; set; }
    }
}
