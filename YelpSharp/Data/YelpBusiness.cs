using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
	public class YelpBusiness
	{
        /// <summary>
        /// Business ID.
        /// </summary>
		public string id { get; set;  }

        /// <summary>
        /// Business name.
        /// </summary>
		public string name { get; set;  }

        /// <summary>
        /// Photo of the business.
        /// </summary>
		public string image_url { get; set;  }

        /// <summary>
        /// URL for business page (on Yelp).
        /// </summary>
		public string url { get; set; }

        /// <summary>
        /// URL for mobile business page (on Yelp).
        /// </summary>
		public string mobile_url { get; set; }

        /// <summary>
        /// Phone number (includes country code).
        /// </summary>
		public string phone { get; set;  }

        /// <summary>
        /// Phone number formatted for display.
        /// </summary>
		public string display_phone { get; set;  }

        /// <summary>
        /// Number of reviews.
        /// </summary>
		public int review_count { get; set;  }

        /// <summary>
        /// Provides a list of category name, alias pairs that this business is associated with.
        /// </summary>
        /// <example>
        /// [["Local Flavor", "localflavor"], ["Active Life", "active"], ["Mass Media", "massmedia"]]. The alias is provided so you can search with the category_filter.
        /// </example>
		public string [][] categories { get; set;  }

        /// <summary>
        /// Distance that business is from search location in meters, if a latitude/longitude is specified.
        /// </summary>
		public double distance { get; set;  }

        /// <summary>
        /// Rating 1-5.
        /// </summary>
		public double rating { get; set;  }

        /// <summary>
        /// URL to star rating image for the business (size = 84x17).
        /// </summary>
		public string rating_img_url { get; set;  }

        /// <summary>
        /// URL to small version of rating image for the business (size = 50x10).
        /// </summary>
		public string rating_img_url_small { get; set; }

        /// <summary>
        /// URL to large version of rating image for the business (size = 166x30).
        /// </summary>
		public string rating_img_url_large { get; set; }

        /// <summary>
        /// Snippet text associated with the business.
        /// </summary>
		public string snippet_text { get; set;  }

        /// <summary>
        /// URL of snippet image associated with the business.
        /// </summary>
		public string snippet_image_url { get; set;  }

        /// <summary>
        /// Location of the business.
        /// </summary>
        public YelpLocation location { get; set; }

        /// <summary>
        /// Any current deals.
        /// </summary>
        public List<YelpDeal> deals { get; set; }

        /// <summary>
        /// Whether the business has an owner.
        /// </summary>
        public bool is_claimed { get; set; }

        /// <summary>
        /// Whether the business has been (permanently) closed.
        /// </summary>
        public bool is_closed { get; set; }

        /// <summary>
        /// List of up to 3 review snippets for the business.
        /// </summary>
        public List<YelpReview> reviews { get; set; }
	}
}
