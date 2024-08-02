using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger
{
	public static class Geometry
	{
		public static double Distance(GPXParser.Waypoint waypoint1, GPXParser.Waypoint waypoint2, UnitType type)
		{
			double distance = Distance(waypoint1.Position, waypoint2.Position, type);
			//double altDifference = 0;
			double altDifference = Math.Abs(waypoint1.Elevation - waypoint2.Elevation);
			return PytagorasTheorem(distance, (altDifference / 1000));
		}

		/// <summary>
		/// Returns the distance in miles or kilometers of any two
		/// latitude / longitude points.
		/// </summary>
		/// <param name=”pos1?></param>
		/// <param name=”pos2?></param>
		/// <param name=”type”></param>
		/// <returns></returns>
		private static double Distance(GPXParser.Position position1, GPXParser.Position position2, UnitType type)
		{
			double earthRadius = (type == UnitType.Miles) ? 3963 : 6378.7;
			double distanceLatitude = ConvertToRadian(position2.Latitude - position1.Latitude);
			double distanceLongitude = ConvertToRadian(position2.Longitude - position1.Longitude);
			double a = Math.Sin(distanceLatitude / 2) * Math.Sin(distanceLatitude / 2) +
					Math.Cos(ConvertToRadian(position1.Latitude)) * Math.Cos(ConvertToRadian(position2.Latitude)) *
					Math.Sin(distanceLongitude / 2) * Math.Sin(distanceLongitude / 2);
			double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
			double distance = earthRadius * c;
			return distance;
		}

		private static double PytagorasTheorem(double baseLength, double height)
		{
			return Math.Sqrt(Math.Pow(baseLength, 2) + Math.Pow(height, 2));
		}

		private static double Angle(GPXParser.Waypoint waypoint1, GPXParser.Waypoint waypoint2)
		{
			double length = 2;
			double height = 1;
			double value = height / length;
			double angle = (Math.Asin(value) * 180) / Math.PI;
			return angle;
		}

		/// <summary>
		/// Convert to Radians.
		/// </summary>
		/// <param name=”val”></param>
		/// <returns></returns>
		private static double ConvertToRadian(double val)
		{
			return (Math.PI / 180) * val;
		}

		//Kilometers per hour =Kilometers/elapsed time in hours
		public static double Speed(GPXParser.Waypoint waypoint1, GPXParser.Waypoint waypoint2, UnitType units)
		{
			double distance = Distance(waypoint1, waypoint2, units);
			TimeSpan time = waypoint2.Time - waypoint1.Time;
			return distance / time.TotalHours;
		}
	}
}