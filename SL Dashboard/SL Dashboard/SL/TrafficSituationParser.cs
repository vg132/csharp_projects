using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace SL_Dashboard.SL
{
	public class TrafficSituationParser
	{



		public static List<Models.TrafficSituationModel> Kalle()
		{
			var url = "https://api.trafiklab.se/sl/trafikenjustnu?key=";
			var xDoc = XElement.Load(url);

			XNamespace xmlns = "http://sl.se/TrafficStatus.xsd";
			var q = (from type in xDoc.Descendants(xmlns + "TrafficType")
							 select new Models.TrafficSituationModel
							 {
								 Name = type.Attribute("Name").Value,
								 Status = type.Attribute("TrafficStatus").Value,
								 TrafficEvent = type.Descendants(xmlns + "TrafficEvent").Select(item => new Models.TrafficEventModel
								 {
									 InfoUrl = item.Element(xmlns + "EventInfoURL").Value,
									 Line = item.Element(xmlns + "TrafficLine").Value,
									 Message = item.Element(xmlns + "Message").Value,
									 Status = item.Element(xmlns + "Status").Value,
								 }).ToList(),
							 }).ToList();
			return q.ToList();
		}
	}
}