using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SL_Dashboard.Controllers
{
	public class TestController : Controller
	{
		public ActionResult Index()
		{
			return Json(SL.TrafficSituationParser.Kalle());
		}

		public ActionResult RealTime(int typeId, int siteId)
		{
			if (typeId == 1)
			{
				return Json(SL.RealTimeParser.GetTrain(siteId));
			}
			else if (typeId == 2)
			{
				return Json(SL.RealTimeParser.GetTram(siteId));
			}
			else if (typeId == 3)
			{
				return Json(SL.RealTimeParser.GetMetro(siteId));
			}
			else if (typeId == 4)
			{
				return Json(SL.RealTimeParser.GetTram(siteId));
			}
			return null;
		}

		public ActionResult Sites(int typeId)
		{
			return Json(SL.SiteData.GetSites(typeId));
		}

		public ActionResult TransportationTypes()
		{
			return Json(SL.SiteData.TransportationTypes);
		}
	}
}
