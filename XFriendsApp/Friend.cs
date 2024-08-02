using System;
using System.Collections;

namespace XFriendsApp
{
	/// <summary>
	/// Summary description for Friend.
	/// </summary>
	public class Friend
	{
		private string name=null;
		private bool online=false;
		private string currentGame=null;

		public Friend(string name)
		{
			this.name=name;
		}

		public string Name
		{
			get
			{
				return(name);
			}
			set
			{
				name=value;
			}
		}

		public bool Online
		{
			get
			{
				return(online);
			}
			set
			{
				online=value;
			}
		}

		public string CurrentGame
		{
			get
			{
				return(currentGame);
			}
			set
			{
				currentGame=value;
			}
		}
	}
}
