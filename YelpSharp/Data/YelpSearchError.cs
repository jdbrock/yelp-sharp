
namespace YelpSharp
{
    public class YelpSearchError
    {
        /// <summary>
        /// Short description of the error.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Enumeration of error IDs.
        /// </summary>
        public YelpErrorId id { get; set; }

        /// <summary>
        /// Long description of the error.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The field which has the error (can be null).
        /// </summary>
        public string field { get; set; }
    }
}
