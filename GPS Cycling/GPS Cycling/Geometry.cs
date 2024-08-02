using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPS.GUI
{
	public static class Geometry
	{
		public enum DistanceType { Miles, Kilometers };

		/// <summary>
		/// Returns the distance in miles or kilometers of any two
		/// latitude / longitude points.
		/// </summary>
		/// <param name=”pos1?></param>
		/// <param name=”pos2?></param>
		/// <param name=”type”></param>
		/// <returns></returns>
		private static double Distance(GPX.Position position1, GPX.Position position2, DistanceType type)
		{
			double earthRadius = (type == DistanceType.Miles) ? 3963 : 6378.7;
			double distanceLatitude = ConvertToRadian(position2.Latitude - position1.Latitude);
			double distanceLongitude = ConvertToRadian(position2.Longitude - position1.Longitude);
			double a = Math.Sin(distanceLatitude / 2) * Math.Sin(distanceLatitude / 2) +
					Math.Cos(ConvertToRadian(position1.Latitude)) * Math.Cos(ConvertToRadian(position2.Latitude)) *
					Math.Sin(distanceLongitude / 2) * Math.Sin(distanceLongitude / 2);
			double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
			double distance = earthRadius * c;
			return distance;
		}

		public static double Distance(this GPX.Waypoint myWaypoint, GPX.Waypoint waypoint)
		{
			double distance = Distance(myWaypoint.Position, waypoint.Position, DistanceType.Kilometers);
			//double altDifference = 0;
			double altDifference = Math.Abs(myWaypoint.Elevation - waypoint.Elevation);
			return PytagorasTheorem(distance, (altDifference / 1000));
		}

		private static double PytagorasTheorem(double a, double b)
		{
			double c2 = Math.Pow(a, 2) + Math.Pow(b, 2);
			double c = Math.Sqrt(c2);
			return c;
		}
		
		private static double Angle(GPX.Waypoint waypoint1, GPX.Waypoint waypoint2)
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
		public static double Speed(GPX.Waypoint waypoint1, GPX.Waypoint waypoint2)
		{
			double distance = Distance(waypoint1, waypoint2);
			TimeSpan time = waypoint2.Time - waypoint1.Time;
			return distance / time.TotalHours;
		}


		public static double Angle(GPX.Waypoint waypoint1, GPX.Waypoint waypoint2)
		{
			return 0.0;
		}





	}
}