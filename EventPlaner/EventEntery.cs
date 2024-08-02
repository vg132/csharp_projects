using System;

namespace EventPlaner
{
	/// <summary>
	/// Summary description for EventEntery.
	/// </summary>
	public class EventEntery : IComparable
	{
		private string eventName=null;
		private string niceName=null;
		private DateTime open=DateTime.Now;
		private DateTime close=DateTime.Now;

		public EventEntery()
		{
		}
		
		public EventEntery(string name)
		{
			this.NiceName=name;
		}

		public int CompareTo(object obj)
		{
			if(obj is EventEntery)
				return(this.Open.CompareTo(((EventEntery)obj).Open));
			throw new ArgumentException("Object is not EventEntery");
		}

		public string EventName
		{
			get
			{
				return(eventName);
			}
			set
			{
				eventName=value;
			}
		}

		public string NiceName
		{
			get
			{
				return(niceName);
			}
			set
			{
				niceName=value;
			}
		}

		public DateTime Open
		{
			get
			{
				return(open);
			}
			set
			{
				open=value;
			}
		}

		public DateTime Close
		{
			get
			{
				return(close);
			}
			set
			{
				close=value;
			}
		}
	}
}
