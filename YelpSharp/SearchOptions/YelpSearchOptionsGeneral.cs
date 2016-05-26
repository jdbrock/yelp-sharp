using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpSearchOptionsGeneral : IYelpSearchOptions
    {
        // ===========================================================================
        // = Public Properties
        // ===========================================================================
        
        /// <summary>
        /// Search term (e.g. "food", "restaurants").
        /// </summary>
        public string Query { get; private set; }

        /// <summary>
        /// Maximum number of results to return.
        /// </summary>
        public int? ResultsPerPage { get; private set; }

        /// <summary>
        /// Offset for paginating the results.
        /// </summary>
        public int? PageOffset { get; private set; }

        /// <summary>
        /// Sort mode.
        /// </summary>
        public YelpSortMode SortMode { get; private set; }

        /// <summary>
        /// Category ID(s) to filter search results with. Comma delimited.
        /// </summary>
        public string CategoryFilter { get; private set; }

        /// <summary>
        /// Search radius in meters. If the value is too large, a AREA_TOO_LARGE error may be returned. The max value is 25 miles.
        /// </summary>
        public double? RadiusFilter { get; private set; }

        /// <summary>
        /// Whether to exclusively search for businesses with deals.
        /// </summary>
        public bool? DealsFilter { get; private set; }

        // ===========================================================================
        // = Construction
        // ===========================================================================
        
        public YelpSearchOptionsGeneral(string query = null, int? resultsPerPage = null, int? pageOffset = null, YelpSortMode sortMode = YelpSortMode.BestMatched,
            string categoryFilter = null, double? radiusFilter = null, bool? dealsFilter = null)
        {
            Query          = query;
            ResultsPerPage = resultsPerPage;
            PageOffset     = pageOffset;
            SortMode       = sortMode;
            CategoryFilter = categoryFilter;
            RadiusFilter   = radiusFilter;
            DealsFilter    = dealsFilter;
        }

        // ===========================================================================
        // = Public Methods
        // ===========================================================================
        
        public IDictionary<string, string> GenerateParameters()
        {
            var properties = new Dictionary<string, string>();
            properties.Add("sort", ((int)SortMode).ToString());

            if (!String.IsNullOrEmpty(Query))
                properties.Add("term", Query);

            if (ResultsPerPage.HasValue)
                properties.Add("limit", ResultsPerPage.Value.ToString());

            if (PageOffset.HasValue)
                properties.Add("offset", PageOffset.Value.ToString());

            if (!String.IsNullOrEmpty(CategoryFilter))
                properties.Add("category_filter", CategoryFilter);

            if (RadiusFilter.HasValue)
                properties.Add("radius_filter", RadiusFilter.Value.ToString());

            if (DealsFilter.HasValue)
                properties.Add("deals_filter", DealsFilter.Value.ToString());     
                   
            return properties;
        }
    }
}
