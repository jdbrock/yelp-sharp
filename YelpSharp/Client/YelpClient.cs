using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable.Authenticators;
using RestSharp.Portable;

namespace YelpSharp
{
    public class YelpClient
    {
        // ===========================================================================
        // = Constants
        // ===========================================================================

        private const string _rootUri = "http://api.yelp.com/v2/";

        // ===========================================================================
        // = Private Fields
        // ===========================================================================
        
        private readonly RestClient _client;

        // ===========================================================================
        // = Construction
        // ===========================================================================
        
        public YelpClient(string accessToken, string accessTokenSecret, string consumerKey, string consumerSecret)
        {
            _client = new RestClient(_rootUri);
            _client.Authenticator = OAuth1Authenticator.ForProtectedResource(consumerKey, consumerSecret, accessToken, accessTokenSecret);
        }

        // ===========================================================================
        // = Public Methods
        // ===========================================================================

        public async Task<YelpSearchResults> Search(string query, string location)
        {
            return await Query<YelpSearchResults>("search", null, new Dictionary<string, string>
            {
                { "term", query },
                { "location", location }
            });
        }

        public async Task<YelpSearchResults> SearchWithOptions(YelpSearchOptions options)
        {
            return await Query<YelpSearchResults>("search", null, options.GenerateParameters());
        }

        public async Task<YelpBusiness> SearchByBusinessName(string name)
        {
            return await Query<YelpBusiness>("business", name, null);
        }

        public async Task<YelpSearchResults> SearchByPhone(string phone)
        {
            var parameters = new Dictionary<string, string>()
            { 
                { "phone", phone } 
            };

            return await Query<YelpSearchResults>("phone_search", null, parameters);
        }

        // ===========================================================================
        // = Private Methods
        // ===========================================================================

        private async Task<T> Query<T>(string area, string id, IDictionary<string, string> parameters)
            where T : class
        {
            var uri = area;

            if (!String.IsNullOrEmpty(id))
                uri += "/" + Uri.EscapeDataString(id);

            var request = new RestRequest(uri, Method.GET);

            if (parameters != null)
                foreach (var kvp in parameters)
                    request.AddParameter(kvp.Key, kvp.Value);

            var response = await _client.Execute(request);

            if (response.StatusCode == HttpStatusCode.NotFound)
                return null;
            else
                return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
