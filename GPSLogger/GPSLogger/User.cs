using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VGSoftware.GPSLogger
{
	[Serializable]
	public class User
	{
		private List<GPXParser.GPX> _trips;

		public User(string userName)
		{
			UserName = userName;
		}

		#region Methods

		private void LoadTrips()
		{
			_trips = new List<VGSoftware.GPSLogger.GPXParser.GPX>();
			DirectoryInfo gpxDirectory = new DirectoryInfo(GPXDirectory);
			if (gpxDirectory.Exists)
			{
				foreach (FileInfo file in gpxDirectory.GetFiles("*.gpx"))
				{
					GPXParser.GPX gpx = GPXParser.Parser.Instance.ParseFile(file.FullName);
					if (gpx != null)
					{
						_trips.Add(gpx);
					}
				}
			}
		}

		#endregion

		#region Properties

		public string UserName
		{
			get;
			set;
		}

		public string UserDirectory
		{
			get;
			set;
		}

		public string GPXDirectory
		{
			get { return Path.Combine(UserDirectory, "GPX"); }
		}

		public List<GPXParser.GPX> Trips
		{
			get
			{
				if (_trips == null)
				{
					LoadTrips();
				}
				return _trips; 
			}
		}

		#endregion
	}
}
