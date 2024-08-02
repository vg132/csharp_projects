using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace GPXHeatmap.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult UploadZip(HttpPostedFileBase zipFile)
		{
			if (zipFile != null && zipFile.ContentLength > 0)
			{
				XNamespace ns = "http://www.topografix.com/GPX/1/1";
				var sb = new StringBuilder();
				var midPoint = string.Empty;
				var zip = ZipFile.Read(zipFile.InputStream);
				foreach (var file in zip.Entries)
				{
					if (file.FileName.EndsWith(".gpx"))
					{
						var root = XElement.Load(file.OpenReader());
						var elements = root.Descendants(ns + "trkpt");
						var counter = 0;
						foreach (var el in elements)
						{
							counter++;
							if ((counter % 10) == 0)
							{
								if (string.IsNullOrEmpty(midPoint))
								{
									midPoint = string.Format("{0},{1}", el.Attribute("lat").Value.Replace(',', '.'), el.Attribute("lon").Value.Replace(',', '.'));
								}
								sb.AppendLine(string.Format("new google.maps.LatLng({0}, {1}),", el.Attribute("lat").Value.Replace(',', '.'), el.Attribute("lon").Value.Replace(',', '.')));
							}
						}
					}
				}
				return View(viewName: "Heatmap", model: new Tuple<string, string>(sb.ToString().Trim().TrimEnd(','), midPoint));
			}
			return RedirectToAction("index");
		}
	}
}