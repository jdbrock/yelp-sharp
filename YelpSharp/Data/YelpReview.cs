using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    /// <summary>
    /// Customer review of the business.
    /// </summary>
    public class YelpReview
    {
        /// <summary>
        /// Review ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Rating from 1-5.
        /// </summary>
        public double rating { get; set; }

        /// <summary>
        /// URL to star rating image for this business (size = 84x17).
        /// </summary>
        public string rating_img_url { get; set; }

        /// <summary>
        /// URL to small version of rating image for this business (size = 50x10).
        /// </summary>
        public string rating_img_url_small { get; set; }

        /// <summary>
        /// URL to large version of rating image for this business (size = 166x30).
        /// </summary>
        public string rating_img_url_large { get; set; }

        /// <summary>
        /// Time created (Unix timestamp)
        /// </summary>
        public double time_created { get; set; }

        /// <summary>
        /// User which wrote the review.
        /// </summary>
        public YelpUser user { get; set; }

        /// <summary>
        /// Excerpt of the review.
        /// </summary>
        public string excerpt { get; set; }
    }
}
