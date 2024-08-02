using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GPXHeatmap.Models
{
	public class Heatmap
	{
		public List<Tuple<string, string>> Points { get; set; }
	}
}