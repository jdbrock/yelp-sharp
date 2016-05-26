using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpDealOptions
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// URL for purchase.
        /// </summary>
        public string purchase_url { get; set; }

        /// <summary>
        /// Deal price (in cents).
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// Deal price (formatted, e.g. "$6").
        /// </summary>
        public string formatted_price { get; set; }

        /// <summary>
        /// Original price (in cents).
        /// </summary>
        public double original_price { get; set; }

        /// <summary>
        /// Original price (formatted, e.g. "$12").
        /// </summary>
        public string formatted_original_price { get; set; }

        /// <summary>
        /// Whether the deal is limited or unlimited.
        /// </summary>
        public bool is_quantity_limited { get; set; }

        /// <summary>
        /// The remaining deals available for purchase (valid only if the deal is limited).
        /// </summary>
        public double remaining_count { get; set; }
    }
}
