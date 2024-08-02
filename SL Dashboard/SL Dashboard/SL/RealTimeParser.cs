using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SL_Dashboard.SL
{
	public enum TransportationType
	{
		Buses,
		Trains,
		Trams
	}

	public class RealTimeParser
	{
		public static List<Models.RealTime> GetTrain(int siteId)
		{
			var url = "https://api.trafiklab.se/sl/realtid/GetDpsDepartures.XML?key=&siteId=" + siteId;
			var xDoc = XElement.Load(url);

			XNamespace xmlns = "http://www1.sl.se/realtidws/";
			var q = (from item in xDoc.Descendants(xmlns + "DpsTrain")
							 select new Models.RealTime
							 {
								 Destination = item.Element(xmlns + "Destination").Value,
								 DisplayTime = item.Element(xmlns + "DisplayTime").Value,
								 LineNumber = int.Parse(item.Element(xmlns + "LineNumber").Value),
								 TimeTableTime=DateTime.Parse(item.Element(xmlns+"TimeTabledDateTime").Value),
								 ExpectedTime = DateTime.Parse(item.Element(xmlns + "ExpectedDateTime").Value),
							 });
			return q.ToList();
		}

		public static List<Models.RealTime> GetMetro(int siteId)
		{
			return null;
		}

		public static List<Models.RealTime> GetTram(int siteId)
		{
			var url = "https://api.trafiklab.se/sl/realtid/GetDpsDepartures.XML?key=&siteId=" + siteId;
			var xDoc = XElement.Load(url);

			XNamespace xmlns = "http://www1.sl.se/realtidws/";
			var q = (from item in xDoc.Descendants(xmlns + "DpsTram")
							 select new Models.RealTime
							 {
								 Destination = item.Element(xmlns + "Destination").Value,
								 DisplayTime = item.Element(xmlns + "DisplayTime").Value,
								 LineNumber = int.Parse(item.Element(xmlns + "LineNumber").Value),
								 TimeTableTime = DateTime.Parse(item.Element(xmlns + "TimeTabledDateTime").Value),
								 ExpectedTime = DateTime.Parse(item.Element(xmlns + "ExpectedDateTime").Value),
							 });
			return q.ToList();
		}


		public static List<Models.RealTime> GetBus(int siteId)
		{
			var url = "https://api.trafiklab.se/sl/realtid/GetDpsDepartures.XML?key=&siteId=" + siteId;
			var xDoc = XElement.Load(url);

			XNamespace xmlns = "http://www1.sl.se/realtidws/";
			var q = (from item in xDoc.Descendants(xmlns + "DpsBus")
							 select new Models.RealTime
							 {
								 Destination = item.Element(xmlns + "Destination").Value,
								 DisplayTime = item.Element(xmlns + "DisplayTime").Value,
								 LineNumber = int.Parse(item.Element(xmlns + "LineNumber").Value),
								 TimeTableTime = DateTime.Parse(item.Element(xmlns + "TimeTabledDateTime").Value),
								 ExpectedTime = DateTime.Parse(item.Element(xmlns + "ExpectedDateTime").Value),
							 });
			return q.ToList();
		}
	}
}