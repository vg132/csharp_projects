using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger
{
	public class GPXInformation
	{
		public GPXInformation(GPXParser.GPX gpx)
		{
			if (gpx == null)
			{
				throw new ArgumentNullException("gpx");
			}
			GPX = gpx;
		}

		#region Properties

		public GPXParser.GPX GPX
		{
			get;
			private set;
		}

		public int Tracks
		{
			get { return GPX.Tracks.Count; }
		}

		public DateTime GetStartTime(int track)
		{
			return GPX.Tracks[track].Segments[0].First<GPXParser.Waypoint>().Time;
		}

		public DateTime GetEndTime(int track)
		{
			return GPX.Tracks[track].Segments.Last<List<GPXParser.Waypoint>>().Last().Time;
		}

		public TimeSpan GetTotalTime(int track)
		{
			return GetEndTime(track) - GetStartTime(track);
		}

		public double GetAverageSpeed(int track)
		{
			double speed = 0.0;
			int loops = 0;
			foreach (List<GPXParser.Waypoint> waypoints in GPX.Tracks[track].Segments)
			{
				int i = 0;
				for (; i < waypoints.Count - 1; i++)
				{
					speed += Geometry.Speed(waypoints[i], waypoints[i + 1], UnitType.Kilometers);
					loops++;
				}
			}
			return Math.Round(speed / loops, 2);
		}

		public double GetDistance(int track)
		{
			double distance = 0.0;
			foreach (List<GPXParser.Waypoint> waypoints in GPX.Tracks[track].Segments)
			{
				int i = 0;
				for (; i < waypoints.Count - 1; i++)
				{
					distance+= Geometry.Distance(waypoints[i], waypoints[i + 1], UnitType.Kilometers);
				}
			}
			return Math.Round(distance, 2);
		}

		#endregion
	}
}
