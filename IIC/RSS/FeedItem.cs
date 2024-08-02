using System;
using System.Xml;
using System.Xml.XPath;
using System.Collections;

namespace RSS
{
	/// <summary>
	/// Summary description for FeedItem.
	/// </summary>
	public class FeedItem : IComparable
	{
		private string title=null;
		private string description=null;
		private string link=null;
		private DateTime date=DateTime.Now;

		public FeedItem()
		{
		}

		public FeedItem(string title, string description, string link, string date)
		{
			this.title=title;
			this.description=description;
			this.link=link;
			try
			{
				this.date=DateTime.Parse(date);
			}
			catch(FormatException fe)
			{
				
			}
		}

		public FeedItem(XPathNavigator nav)
		{
			nav.MoveToFirstAttribute();
			title=nav.Value;
			nav.MoveToNextAttribute();
			link=nav.Value;
			nav.MoveToNextAttribute();
			date=DateTime.Parse(nav.Value);
			nav.MoveToParent();
			nav.MoveToFirstChild();
			description=nav.Value;
		}

		public void SaveState(XmlTextWriter writer)
		{
			writer.WriteStartElement("item");
			writer.WriteAttributeString("title",title);
			writer.WriteAttributeString("link",link);
			writer.WriteAttributeString("date",date.ToString());
			writer.WriteStartElement("desc");
			writer.WriteString(description);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		/// <summary>
		/// Gets and sets the string value of title.
		/// </summary>
		public string Title
		{
			get
			{
				return(this.title);
			}
			set
			{
				this.title=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of description.
		/// </summary>
		public string Description
		{
			get
			{
				return(this.description);
			}
			set
			{
				this.description=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of link.
		/// </summary>
		public string Link
		{
			get
			{
				return(this.link);
			}
			set
			{
				this.link=value;
			}
		}

		/// <summary>
		/// Gets and sets the DateTime value of date.
		/// </summary>
		public DateTime Date
		{
			get
			{
				return(this.date);
			}
			set
			{
				this.date=value;
			}
		}

		public string ID
		{
			get
			{
				return(title+date.ToString());
			}
		}

		public int CompareTo(object obj) 
		{
			if(obj is FeedItem)
				return(date.CompareTo(((FeedItem)obj).Date));
			throw new ArgumentException("object is not a FeedItem");
		}
	}
}
