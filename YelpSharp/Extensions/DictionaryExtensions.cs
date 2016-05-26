using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Create a new dictionary as a result of merging the provided dictionaries.
        /// The right-most dictionary with a duplicate entry "wins".
        /// </summary>
        public static IDictionary<TKey, TValue> MergeWith<TKey, TValue>(this IDictionary<TKey, TValue> baseDictionary, 
            params IDictionary<TKey, TValue>[] dictionariesToMerge)
        {
            // Create a new dictionary (we don't want to mutate the base dictionary).
            var x = new Dictionary<TKey, TValue>();

            // Copy base dictionary.
            foreach (var kvp in baseDictionary)
                x[kvp.Key] = kvp.Value;

            // Copy dictionaries to be merged.
            foreach (var dictionaryToMerge in dictionariesToMerge)
                foreach (var kvp in dictionaryToMerge)
                    x[kvp.Key] = kvp.Value;

            // Return the new dictionary.
            return x;
        }
    }
}
