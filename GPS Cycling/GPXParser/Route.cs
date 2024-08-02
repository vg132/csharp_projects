using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPS.GPX
{
	/// <summary>
	/// rte represents route - an ordered list of waypoints representing a series of turn points leading to a destination.
	/// </summary>
	public class Route
	{
		/// <summary>
		/// GPS name of route.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// GPS comment for route.
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// Text description of route for user.  Not sent to GPS.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Source of data. Included to give user some idea of reliability and accuracy of data.
		/// </summary>
		public string Source { get; set; }

		/// <summary>
		/// Links to external information about the route.
		/// </summary>
		public List<Link> Links { get; set; }

		/// <summary>
		/// GPS route number.
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// Type (classification) of route.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// A list of route points.
		/// </summary>
		public List<Waypoint> Points { get; set; }
	}
}
