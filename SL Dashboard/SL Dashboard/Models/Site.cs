using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SL_Dashboard.Models
{
	public class Site
	{
		public Site(string name, int id, double longitude, double latitude, int typeId)
		{
			Name = name;
			Id = id;
			Longitude = longitude;
			Latitude = latitude;
			TypeId = typeId;
		}

		public string Name { get; set; }
		public int Id { get; set; }
		public double Longitude { get; set; }
		public double Latitude { get; set; }
		public int TypeId { get; set; }
	}
}