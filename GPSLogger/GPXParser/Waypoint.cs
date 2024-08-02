using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser
{
	public class Waypoint
	{
		#region Properties

		/// <summary>
		/// The latidude and longitude of the point. Decimal degrees, WGS84 datum.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// The GPS name of the waypoint. This field will be transferred to and from the GPS.
		/// GPX does not place restrictions on the length of this field or the characters contained in it.
		/// It is up to the receiving application to validate the field before sending it to the GPS.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Text of GPS symbol name. For interchange with other programs, use the exact spelling of the
		/// symbol as displayed on the GPS.  If the GPS abbreviates words, spell them out.
		/// </summary>
		public string SymbolName { get; set; }

		/// <summary>
		/// Link to additional information about the waypoint.
		/// </summary>
		public List<Link> Links { get; set; }

		/// <summary>
		/// Source of data. Included to give user some idea of reliability and accuracy of data.
		/// "Garmin eTrex", "USGS quad Boston North", e.g.
		/// </summary>
		public string Source { get; set; }

		/// <summary>
		/// A text description of the element. Holds additional information about the element intended for the user, not the GPS.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// GPS waypoint comment. Sent to GPS as comment.
		/// </summary>
		public string Comment { get; set; }

		/// <summary>
		/// Elevation (in meters) of the point.
		/// </summary>
		public double Elevation { get; set; }

		/// <summary>
		/// Creation/modification timestamp for element. Date and time in are in Univeral Coordinated Time (UTC),
		/// not local time! Conforms to ISO 8601 specification for date/time representation. Fractional seconds
		/// are allowed for millisecond timing in tracklogs.
		/// </summary>
		public DateTime Time { get; set; }

		/// <summary>
		/// Magnetic variation (in degrees) at the point
		/// </summary>
		public double MagneticVariation { get; set; }

		/// <summary>
		/// Height (in meters) of geoid (mean sea level) above WGS84 earth ellipsoid.  As defined in NMEA GGA message.
		/// </summary>
		public double GeoIdHeight { get; set; }

		/// <summary>
		/// Type (classification) of the waypoint.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Type of GPX fix.
		/// </summary>
		public Enums.GPSFixType GPSFix { get; set; }

		/// <summary>
		/// Number of satellites used to calculate the GPX fix.
		/// </summary>
		public int Satelites { get; set; }

		/// <summary>
		/// Horizontal dilution of precision.
		/// </summary>
		public double HorizontalDilution { get; set; }

		/// <summary>
		/// Vertical dilution of precision.
		/// </summary>
		public double VerticalDilution { get; set; }

		/// <summary>
		/// Position dilution of precision.
		/// </summary>
		public double PositionDilution { get; set; }

		/// <summary>
		/// Number of seconds since last DGPS update.
		/// </summary>
		public double AgeOfGPSData { get; set; }

		/// <summary>
		/// ID of DGPS station used in differential correction.
		/// </summary>
		public int DGPSId { get; set; }

		#endregion
	}
}
