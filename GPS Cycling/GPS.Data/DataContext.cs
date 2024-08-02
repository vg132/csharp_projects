using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPS.Data
{
	public class DataContext
	{
		private static DataContext _instance;
		private static object _instanceLock = new object();

		private GPS _gps;

		private DataContext()
		{
			_gps = new GPS(string.Format("Data Source={0}", Properties.Settings.Default.DataFilePath));
		}

		public static DataContext Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_instanceLock)
					{
						if (_instance == null)
						{
							_instance = new DataContext();
						}
					}
				}
				return _instance;
			}
		}

		public IEnumerable<User> Users
		{
			get
			{
				return from u in _gps.Users
							 select u;
			}
		}

		public void CreateUser(string userName)
		{
			if (!_gps.Users.Any(user => string.Compare(user.Name, userName, true) == 0))
			{
				User user = new User();
				user.Name = userName;
				user.Created = DateTime.Now;
				_gps.Users.InsertOnSubmit(user);
				_gps.SubmitChanges();
			}
		}

		public IEnumerable<Track> ListTracks(User user)
		{
			return from t in _gps.Tracks
						 where t.UserId == user.Id
						 select t;
		}

		public void SaveTrack(Track track)
		{
			_gps.Tracks.InsertOnSubmit(track);
			_gps.SubmitChanges();
		}
	}
}
