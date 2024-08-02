using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SL_Dashboard.Models
{
	public class TrafficSituationModel
	{
		public string Name { get; set; }
		public string Status { get; set; }
		public List<TrafficEventModel> TrafficEvent { get; set; }
	}
}