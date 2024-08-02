using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SL_Dashboard.Models
{
	public class RealTime
	{
		public DateTime TimeTableTime { get; set; }
		public DateTime ExpectedTime { get; set; }
		public string DisplayTime { get; set; }
		public string Destination { get; set; }
		public int LineNumber { get; set; }
	}
}