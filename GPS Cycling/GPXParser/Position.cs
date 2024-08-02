using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPS.GPX
{
	public class Position
	{
		public Position()
		{
		}

		public Position(double latitude, double longitude)
		{
			Latitude = latitude;
			Longitude = longitude;
		}

		public double Latitude { get; set; }
		public double Longitude { get; set; }
	}
}
