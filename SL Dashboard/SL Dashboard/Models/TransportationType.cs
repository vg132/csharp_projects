using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SL_Dashboard.Models
{
	public class TransportationType
	{
		public TransportationType(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public int Id { get; set; }
		public string Name { get; set; }
	}
}