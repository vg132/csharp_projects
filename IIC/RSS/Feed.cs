using System;
using System.Xml;
using System.Xml.XPath;
using System.Collections;

namespace RSS
{

	/// <summary>
	/// Summary description for Feed.
	/// </summary>
	public class Feed
	{
		private string title=null;
		private string url=null;
		private Hashtable items=new Hashtable();

		public Feed()
		{
		}

		public Feed(string url, string title)
		{
			this.url=url;
			this.title=title;
		}

		public Feed(XPathNavigator nav)
		{
			nav.MoveToFirstAttribute();
			title=nav.Value;
			nav.MoveToNextAttribute();
			url=nav.Value;
			XPathNodeIterator iter=nav.Select("//item");
			while(iter.MoveNext())
			{
				FeedItem fe=new FeedItem(iter.Current.Clone());
				items.Add(fe.ID,fe);
			}
		}

		public void SaveState(XmlTextWriter writer)
		{
			writer.WriteStartElement("feed");
			writer.WriteAttributeString("title",title);
			writer.WriteAttributeString("url",url);
			foreach(FeedItem item in items.Values)
				item.SaveState(writer);
			writer.WriteEndElement();
		}

		public bool AddItem(FeedItem fe)
		{
			if(items.ContainsKey(fe.ID))
				return(false);
      items.Add(fe.ID,fe);
			return(true);
			
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
		/// Gets and sets the string value of url.
		/// </summary>
		public string Url
		{
			get
			{
				return(this.url);
			}
			set
			{
				this.url=value;
			}
		}

		/// <summary>
		/// Gets and sets the Hashtable value of items.
		/// </summary>
		public Hashtable Items
		{
			get
			{
				return(this.items);
			}
			set
			{
				this.items=value;
			}
		}
	}
}
