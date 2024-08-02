using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;

namespace VGSoftware.GPSLogger.GPXParser
{
	public class Parser
	{
		#region Fields

		private static XNamespace Namespace_1_0 = "http://www.topografix.com/GPX/1/0";
		private static XNamespace Namespace_1_1 = "http://www.topografix.com/GPX/1/1";

		private static Parser _instance;
		private static object _instanceLock = new object();

		#endregion

		private Parser()
		{
		}

		public static Parser Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_instanceLock)
					{
						if (_instance == null)
						{
							_instance = new Parser();
						}
					}
				}
				return _instance;
			}
		}

		public GPX ParseFile(string file)
		{
			GPX gpx = null;
			try
			{
				XDocument xDoc = XDocument.Load(file);
				gpx = new GPX();
				XNamespace currentNamespace = DetectNamespace(xDoc);
				if (currentNamespace != null)
				{
					gpx.Metadata = ParseMetadata(xDoc, currentNamespace);
					gpx.Waypoints = ParseWaypoints(xDoc, currentNamespace);
					gpx.Routes = ParseRoutes(xDoc, currentNamespace);
					gpx.Tracks = ParseTracks(xDoc, currentNamespace);
				}
			}
			catch (XmlException ex)
			{
			}
			return gpx;
		}

		private XNamespace DetectNamespace(XDocument xDoc)
		{
			if (xDoc.Descendants(Namespace_1_0 + "gpx").Count() > 0)
			{
				return Namespace_1_0;
			}
			else if (xDoc.Descendants(Namespace_1_1 + "gpx").Count() > 0)
			{
				return Namespace_1_1;
			}
			return null;
		}

		private Metadata ParseMetadata(XDocument xDoc, XNamespace gpxNamespace)
		{
			Metadata metadata = new Metadata();
			XElement element = xDoc.Element(gpxNamespace + "metadata");
			if (element != null)
			{
				metadata.Name = GetStringValue(element, gpxNamespace, "name");
				metadata.Description = GetStringValue(element, gpxNamespace, "desc");
				metadata.Author = GetPersonValue(element, gpxNamespace, "author");
				metadata.Copyright = GetCopyrightValue(element, gpxNamespace, "copyright");
				metadata.Links = new List<Link>(GetLinks(element, gpxNamespace));
				metadata.Time = GetDateTimeValue(element, gpxNamespace, "time");
				metadata.Keywords = GetStringValue(element, gpxNamespace, "keywords");
				metadata.Rect = GetRectValue(element, gpxNamespace, "bounds");
			}
			return metadata;
		}

		private List<Track> ParseTracks(XDocument xDoc, XNamespace gpxNamespace)
		{
			List<Track> tracks = new List<Track>();
			foreach (XElement element in xDoc.Descendants(gpxNamespace + "trk"))
			{
				Track track = new Track();

				track.Name = GetStringValue(element, gpxNamespace, "name");
				track.Comment = GetStringValue(element, gpxNamespace, "cmt");
				track.Description = GetStringValue(element, gpxNamespace, "desc");
				track.Source = GetStringValue(element, gpxNamespace, "src");
				track.Links = new List<Link>(GetLinks(element, gpxNamespace));
				track.Number = GetIntegerValue(element, gpxNamespace, "number");
				track.Type = GetStringValue(element, gpxNamespace, "type");
				track.Segments = new List<List<Waypoint>>();
				foreach (XElement trackSeq in element.Descendants(gpxNamespace + "trkseg"))
				{
					track.Segments.Add(new List<Waypoint>(ExtractWaypoints(element, gpxNamespace, "trkpt")));
				}
				tracks.Add(track);
			}

			return tracks;
		}

		private List<Route> ParseRoutes(XDocument xDoc, XNamespace gpxNamespace)
		{
			List<Route> routes = new List<Route>();
			foreach (XElement element in xDoc.Descendants(gpxNamespace + "rte"))
			{
				Route route = new Route();
				route.Name = GetStringValue(element,gpxNamespace, "name");
				route.Comment = GetStringValue(element,gpxNamespace, "cmt");
				route.Description = GetStringValue(element, gpxNamespace, "desc");
				route.Source = GetStringValue(element, gpxNamespace, "src");
				route.Links = new List<Link>(GetLinks(element, gpxNamespace));
				route.Number = GetIntegerValue(element, gpxNamespace, "number");
				route.Type = GetStringValue(element, gpxNamespace, "type");
				route.Points = new List<Waypoint>(ExtractWaypoints(element, gpxNamespace,"rtept"));
				routes.Add(route);
			}
			return routes;
		}

		private List<Waypoint> ParseWaypoints(XDocument xDoc, XNamespace gpxNamespace)
		{
			return new List<Waypoint>(ExtractWaypoints(xDoc.Element(gpxNamespace + "gpx"), gpxNamespace, "wpt"));
		}

		private IEnumerable<Waypoint> ExtractWaypoints(XElement element, XNamespace gpxNamespace,string tag)
		{
			foreach (XElement waypointElement in element.Descendants(gpxNamespace + tag))
			{
				Waypoint waypoint = new Waypoint();
				waypoint.Position = new Position(GetDoubleAttribte(waypointElement, "lat"), GetDoubleAttribte(waypointElement, "lon"));
				waypoint.Elevation = GetDoubleValue(waypointElement, gpxNamespace, "ele");
				waypoint.Time = GetDateTimeValue(waypointElement, gpxNamespace, "time");
				waypoint.MagneticVariation = GetDoubleValue(waypointElement, gpxNamespace, "magvar");
				waypoint.GeoIdHeight = GetDoubleValue(waypointElement, gpxNamespace, "geoidheight");
				waypoint.Name = GetStringValue(waypointElement, gpxNamespace, "name");
				waypoint.Comment = GetStringValue(waypointElement, gpxNamespace, "cmt");
				waypoint.Description = GetStringValue(waypointElement, gpxNamespace, "desc");
				waypoint.Source = GetStringValue(waypointElement, gpxNamespace, "src");
				waypoint.Links = new List<Link>(GetLinks(waypointElement, gpxNamespace));
				waypoint.SymbolName = GetStringValue(waypointElement, gpxNamespace, "sym");
				waypoint.Type = GetStringValue(waypointElement, gpxNamespace, "type");
				waypoint.GPSFix = GetGPSFixValue(waypointElement, gpxNamespace, "fix");
				waypoint.Satelites = GetIntegerValue(waypointElement, gpxNamespace, "sat");
				waypoint.HorizontalDilution = GetDoubleValue(waypointElement, gpxNamespace, "hdop");
				waypoint.VerticalDilution = GetDoubleValue(waypointElement, gpxNamespace, "vdop");
				waypoint.PositionDilution = GetDoubleValue(waypointElement, gpxNamespace, "pdop");
				waypoint.AgeOfGPSData = GetDoubleValue(waypointElement, gpxNamespace, "ageofdgpsdata");
				waypoint.DGPSId = GetIntegerValue(waypointElement, gpxNamespace, "dgpsid");
				yield return waypoint;
			}
		}

		private string GetStringValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			return element.Element(gpxNamespace + tag) == null ? null : element.Element(gpxNamespace + tag).Value.Trim();
		}

		private string GetStringAttribute(XElement element, string attribute)
		{
			return element.Attribute(attribute) == null ? null : element.Attribute(attribute).Value.Trim();
		}

		private int GetIntegerValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			return element.Element(gpxNamespace + tag) == null ? 0 : int.Parse(element.Element(gpxNamespace + tag).Value.Trim());
		}

		public DateTime GetDateTimeValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			return element.Element(gpxNamespace+ tag) == null ? DateTime.MinValue : DateTime.Parse(element.Element(gpxNamespace+ tag).Value.Trim());
		}

		private double GetDoubleValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			return element.Element(gpxNamespace + tag) == null ? 0 : GetDoubleValue(element.Element(gpxNamespace + tag).Value.Trim());
		}

		private double GetDoubleAttribte(XElement element, string attribute)
		{
			return element.Attribute(attribute) == null ? 0 : GetDoubleValue(element.Attribute(attribute).Value.Trim());
		}

		private Person GetPersonValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			XElement personElement = element.Element(gpxNamespace + tag);
			if (personElement != null)
			{
				Person person = new Person();
				person.Name = GetStringValue(personElement, gpxNamespace, "name");
				person.Email = GetEmailValue(personElement, gpxNamespace, "email");
				List<Link> links = new List<Link>(GetLinks(personElement, gpxNamespace));
				if (links.Count() > 0)
				{
					person.Link = links[0];
				}
			}
			return null;
		}

		private string GetEmailValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			XElement email = element.Element(gpxNamespace + tag);
			if (email != null && email.Attribute("id") != null && email.Attribute("domain") != null)
			{
				return string.Format("{0}@{1}", email.Attribute("id").Value.Trim(), email.Attribute("domain").Value.Trim());
			}
			return null;
		}

		private Copyright GetCopyrightValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			XElement copyrightElement = element.Element(gpxNamespace + tag);
			if (copyrightElement != null)
			{
				Copyright copyright = new Copyright();
				copyright.Author = GetStringAttribute(copyrightElement, "author");
				copyright.License = GetStringValue(copyrightElement, gpxNamespace, "license");
				copyright.Year = GetIntegerValue(copyrightElement, gpxNamespace, "year");
				return copyright;
			}
			return null;
		}

		private Enums.GPSFixType GetGPSFixValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			if (element.Element(gpxNamespace + tag) != null)
			{
				switch (element.Element(gpxNamespace + tag).Value.ToLower())
				{
					case "2d":
						return Enums.GPSFixType.TwoD;
					case "3d":
						return Enums.GPSFixType.ThreeD;
					case "dgps":
						return Enums.GPSFixType.Dgps;
					case "pps":
						return Enums.GPSFixType.Pps;
				}
			}
			return Enums.GPSFixType.None;
		}

		private double GetDoubleValue(string text)
		{
			return double.Parse(text, System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat);
		}

		private Rect GetRectValue(XElement element, XNamespace gpxNamespace, string tag)
		{
			XElement bounds = element.Element(gpxNamespace + tag);
			if (bounds != null)
			{
				Rect rect = new Rect();
				rect.Minimum = new Position(GetDoubleAttribte(bounds, "minlat"), GetDoubleAttribte(bounds, "minlon"));
				rect.Maximum = new Position(GetDoubleAttribte(bounds, "maxlat"), GetDoubleAttribte(bounds, "maxlon"));
				return rect;
			}
			return null;
		}

		private IEnumerable<Link> GetLinks(XElement element, XNamespace gpxNamespace)
		{
			return from link in element.Descendants("link")
						 select new Link() { Href = link.Attribute("href").Value.Trim(), MimeType = GetStringValue(link,gpxNamespace ,"type"), Text = GetStringValue(link,gpxNamespace, "text") };
		}
	}
}