using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser
{
	/// <summary>
	/// GPX documents contain a metadata header, followed by waypoints, routes, and tracks. 
	/// You can add your own elements to the extensions section of the GPX document.
	/// </summary>
	public class GPX
	{
		/// <summary>
		/// Metadata about the file.
		/// </summary>
		public Metadata Metadata { get; set; }

		/// <summary>
		/// A list of waypoints.
		/// </summary>
		public List<Waypoint> Waypoints { get; set; }

		/// <summary>
		/// A list of routes.
		/// </summary>
		public List<Route> Routes { get; set; }

		/// <summary>
		/// A list of tracks.
		/// </summary>
		public List<Track> Tracks { get; set; }

		/// <summary>
		/// You must include the version number in your GPX document.
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// You must include the name or URL of the software that created your GPX document.
		/// This allows others to inform the creator of a GPX instance document that fails to validate.
		/// </summary>
		public string Creator { get; set; }

		public static GPX Load(string file)
		{
			return Parser.Instance.ParseFile(file); ;
		}
	}
}
