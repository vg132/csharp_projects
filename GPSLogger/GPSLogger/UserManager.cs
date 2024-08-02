using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VGSoftware.GPSLogger
{
	public class UserManager
	{
		#region Fields

		private static UserManager _current;
		private static object _currentLock=new object();

		private List<User> _users;

		#endregion

		#region Methods

		private UserManager()
		{
			LoadUsers();
		}

		public static UserManager Current
		{
			get
			{
				if (_current == null)
				{
					lock (_currentLock)
					{
						if (_current == null)
						{
							_current = new UserManager();
						}
					}
				}
				return _current;
			}
		}

		public void CreateUser(string userName)
		{
			User user = Users.Find(u => u.UserName == userName);
			if (user != null)
			{
				throw new NiceException(string.Format("User with username '{0}' already exist", userName));
			}
			user = new User(userName);
			user.UserDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Users\{0}", user.UserName));
			CreateUserDirectories(user);
			Users.Add(user);
		}

		private void CreateUserDirectories(User user)
		{
			DirectoryInfo userDirectory = new DirectoryInfo(user.UserDirectory);
			if (!userDirectory.Exists)
			{
				userDirectory.Create();
			}
			userDirectory.CreateSubdirectory("GPX");
		}

		private void LoadUsers()
		{
			_users = new List<User>();
			DirectoryInfo userDirectory = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users"));
			if (userDirectory.Exists)
			{
				foreach (DirectoryInfo directory in userDirectory.GetDirectories())
				{
					User user = new User(directory.Name);
					user.UserDirectory = directory.FullName;
					Users.Add(user);
				}
			}
		}

		public User LoadUser(string userName)
		{
			return Users.Find(u => u.UserName == userName);
		}

		#endregion

		#region Properties

		public List<User> Users
		{
			get { return _users; }
		}

		public User CurrentUser
		{
			get;
			set;
		}

		#endregion

		#region Events

		private event EventHandler<EventArgs> _userBeginLoading;
		private event EventHandler<EventArgs> _userEndLoading;
		private event EventHandler<EventArgs> _userLoadingInformation;

		public event EventHandler<EventArgs> UserBeginLoading
		{
			add { _userBeginLoading += value; }
			remove { _userBeginLoading -= value; }
		}

		public event EventHandler<EventArgs> UserEndLoading
		{
			add { _userEndLoading+= value; }
			remove { _userEndLoading-= value; }
		}

		public event EventHandler<EventArgs> UserLoadingInformation
		{
			add { _userLoadingInformation+= value; }
			remove { _userLoadingInformation-= value; }
		}

		private void OnUserBeginLoading()
		{
			EventHandler<EventArgs> handler = _userBeginLoading;
			if (handler != null)
			{
				handler(this, new EventArgs());
			}
		}

		private void OnUserEndLoading()
		{
			EventHandler<EventArgs> handler = _userEndLoading;
			if (handler != null)
			{
				handler(this, new EventArgs());
			}
		}

		private void OnUserLoadingInformation()
		{
			EventHandler<EventArgs> handler = _userLoadingInformation;
			if (handler != null)
			{
				handler(this, new EventArgs());
			}
		}

		#endregion
	}
}
