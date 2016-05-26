using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpSearchOptionsLocale : IYelpSearchOptions
    {
        // ===========================================================================
        // = Public Properties
        // ===========================================================================
        
        /// <summary>
        /// ISO 3166-1 alpha-2 country code. Default country to use when parsing the location field. United States = US, Canada = CA, United Kingdom = GB (not UK).
        /// </summary>
        public string CountryCode { get; private set; }

        /// <summary>
        /// ISO 639 language code (default=en). Reviews written in the specified language will be shown.
        /// </summary>
        public string Language { get; private set; }

        // ===========================================================================
        // = Construction
        // ===========================================================================
        
        public YelpSearchOptionsLocale(string countryCode = null, string languageCode = null)
        {
            CountryCode = countryCode;
            Language = languageCode;
        }

        // ===========================================================================
        // = Public Methods
        // ===========================================================================
        
        public IDictionary<string, string> GenerateParameters()
        {
            var parameters = new Dictionary<string, string>();

            if (!String.IsNullOrEmpty(CountryCode))
                parameters.Add("cc", CountryCode);

            if (!String.IsNullOrEmpty(Language))
                parameters.Add("lang", Language);

            return parameters;
        }
    }
}
