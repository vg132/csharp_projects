using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser
{
	/// <summary>
	/// Two lat/lon pairs defining the extent of an element.
	/// </summary>
	public class Rect
	{
		/// <summary>
		/// The minimum position.
		/// </summary>
		public Position Minimum { get; set; }

		/// <summary>
		/// The maximum position.
		/// </summary>
		public Position Maximum { get; set; }
	}
}
