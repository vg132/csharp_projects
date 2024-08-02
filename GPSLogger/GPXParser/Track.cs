using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser
{
	/// <summary>
	/// trk represents a track - an ordered list of points describing a path.
	/// </summary>
	public class Track
	{
		/// <summary>
		/// GPS name of track.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// GPS comment for track.
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// User description of track.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Source of data. Included to give user some idea of reliability and accuracy of data.
		/// </summary>
		public string Source { get; set; }

		/// <summary>
		/// Links to external information about track.
		/// </summary>
		public List<Link> Links { get; set; }

		/// <summary>
		/// GPS track number.
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// Type (classification) of track.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// A Track Segment holds a list of Track Points which are logically connected in order.
		/// To represent a single GPS track where GPS reception was lost, or the GPS receiver was turned off,
		/// start a new Track Segment for each continuous span of track data.
		/// </summary>
		public List<List<Waypoint>> Segments { get; set; }
	}
}
