using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public class YelpSearchOptions : IYelpSearchOptions
    {
        // ===========================================================================
        // = Public Properties
        // ===========================================================================
        
        /// <summary>
        /// General search options.
        /// </summary>
        public YelpSearchOptionsGeneral GeneralOptions { get; private set; }

        /// <summary>
        /// Results will be localized in the region format and language if supported.
        /// </summary>
        public YelpSearchOptionsLocale LocaleOptions { get; private set; }

        /// <summary>
        /// Location options.
        /// </summary>
        public IYelpSearchOptionsLocation LocationOptions { get; private set; }

        // ===========================================================================
        // = Construction
        // ===========================================================================
        
        public YelpSearchOptions(YelpSearchOptionsGeneral general = null, YelpSearchOptionsLocale locale = null, IYelpSearchOptionsLocation location = null)
        {
            GeneralOptions = general;
            LocaleOptions = locale;
            LocationOptions = location;
        }

        // ===========================================================================
        // = Public Methods
        // ===========================================================================
        
        public IDictionary<string, string> GenerateParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            
            if (GeneralOptions != null)
                parameters = parameters.MergeWith(GeneralOptions.GenerateParameters());

            if (LocaleOptions != null)
                parameters = parameters.MergeWith(LocaleOptions.GenerateParameters());

            if (LocationOptions != null)
                parameters = parameters.MergeWith(LocationOptions.GenerateParameters());

            return parameters;
        }
    }
}
