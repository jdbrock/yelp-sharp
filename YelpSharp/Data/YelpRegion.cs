using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YelpSharp
{
	public class YelpRegion
	{
        /// <summary>
        /// Center position of map bounds.
        /// </summary>
		public YelpCoordinates center { get; set; }

        /// <summary>
        /// Span of map bounds.
        /// </summary>
		public YelpSpan span { get; set; }		
	}
}
