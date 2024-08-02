using System;
using System.Collections;

namespace EventPlaner
{
	/// <summary>
	/// Summary description for Event.
	/// </summary>
	public class Event : IComparable
	{
		private string name=null;
		private DateTime start=DateTime.Now;
		private DateTime end=DateTime.Now;
		private ArrayList enterys=new ArrayList();

		public Event()
		{
		}

		public Event(string name)
		{
			this.Name=name;
		}

		public Event(string countryName, string eventName, string eventDate, bool fillEnterys)
		{
			this.Name=countryName+"s Grand Prix, "+eventName;
			this.Start=DateTime.Parse(eventDate+" 00:00").AddDays(1);
			this.End=Start.AddDays(2);
			if(fillEnterys)
			{
				this.Start=DateTime.Parse(eventDate+" 00:00");

				DateTime dt=DateTime.Parse(eventDate);
				EventEntery ee=new EventEntery("New Event");
				ee.NiceName=eventName+" - Fredagsträning 1";
				ee.EventName="fredagsträning 1";
				ee.Open=DateTime.Parse(dt.Date+" 08:50");
				ee.Close=DateTime.Parse(dt.Date+" 10:10");
				enterys.Add(ee);

				ee=new EventEntery("New Event");
				ee.NiceName=eventName+" - Fredagsträning 2";
				ee.EventName="fredagsträning 2";
				ee.Open=DateTime.Parse(dt.Date+" 11:50");
				ee.Close=DateTime.Parse(dt.Date+" 13:10");
				enterys.Add(ee);
				dt=dt.AddDays(1);
				ee=new EventEntery("New Event");
				ee.NiceName=eventName+" - Lördagsträning 1";
				ee.EventName="lördagsträning 1";
				ee.Open=DateTime.Parse(dt.Date+" 06:50");
				ee.Close=DateTime.Parse(dt.Date+" 07:59");
				enterys.Add(ee);

				ee=new EventEntery("New Event");
				ee.NiceName=eventName+" - Lördagsträning 2";
				ee.EventName="lördagsträning 2";
				ee.Open=DateTime.Parse(dt.Date+" 08:00");
				ee.Close=DateTime.Parse(dt.Date+" 09:10");
				enterys.Add(ee);

				ee=new EventEntery("New Event");
				ee.NiceName=eventName+" - Lördagskval";
				ee.EventName="lördagskval";
				ee.Open=DateTime.Parse(dt.Date+" 10:50");
				ee.Close=DateTime.Parse(dt.Date+" 12:20");
				enterys.Add(ee);
				dt=dt.AddDays(1);
				ee=new EventEntery("New Event");
				ee.NiceName=eventName+" - Söndagskval";
				ee.EventName="söndagskval";
				ee.Open=DateTime.Parse(dt.Date+" 07:50");
				ee.Close=DateTime.Parse(dt.Date+" 09:20");
				enterys.Add(ee);

				ee=new EventEntery("New Event");
				ee.NiceName=countryName+"s Grand Prix";
				ee.EventName=countryName+"s Grand Prix";
				ee.Open=DateTime.Parse(dt.Date+" 11:50");
				ee.Close=DateTime.Parse(dt.Date+" 14:30");
				enterys.Add(ee);
			}
		}

		public void SortEventEnterys()
		{
			enterys.Sort(0,enterys.Count,null);
		}

		public int CompareTo(object obj)
		{
			if(obj is Event)
				return(this.Start.CompareTo(((Event)obj).Start));
			throw new ArgumentException("Object is not Event");
		}

		public ArrayList GetEnterys()
		{
			return(enterys);
		}

		public void AddEntery(EventEntery entery)
		{
			enterys.Add(entery);
		}

		public DateTime Start
		{
			get
			{
				return(start);
			}
			set
			{
				start=value;
			}

		}

		public DateTime End
		{
			get
			{
				return(end);
			}
			set
			{
				end=value;
			}
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
	}
}
