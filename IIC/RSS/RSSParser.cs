using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace RSS
{
	/// <summary>
	/// Summary description for RSSParser.
	/// </summary>
	public class RSSParser
	{
		public RSSParser()
		{
		}

		public int UpdateFeed(Feed feed)
		{
			int newItems=0;
			
			XPathNavigator nav2=new XPathDocument(feed.Url).CreateNavigator();
			XPathNodeIterator iter=nav2.Select("//channel/item");
			if(iter.Count<=0)
			{
				XmlNamespaceManager nm=new XmlNamespaceManager(nav2.NameTable);
				nm.AddNamespace("rss","http://purl.org/rss/1.0/");
				nm.AddNamespace("dc","http://purl.org/dc/elements/1.1/");
				nm.AddNamespace("rdf","http://www.w3.org/1999/02/22-rdf-syntax-ns#");

				XPathExpression expr=nav2.Compile("rdf:RDF/rss:item");
				expr.SetContext(nm) ;
				iter=nav2.Select(expr);
			}
			while(iter.MoveNext())
			{
				XPathNavigator nav=iter.Current.Clone();
				if(nav.MoveToFirstChild())
				{
					FeedItem item=new FeedItem();
					do
					{
						switch(nav.LocalName)
						{
							case "title":
								item.Title=nav.Value;
								break;
							case "description":
								item.Description=nav.Value;
								break;
							case "link":
								item.Link=nav.Value;
								break;
							case "pubDate":
								item.Date=DateTime.Parse(nav.Value);
								break;
							case "date":
								item.Date=DateTime.Parse(nav.Value);
								break;
						}
					}while(nav.MoveToNext());
					if(feed.AddItem(item))
						newItems++;
				}
			}
			return(newItems);
		}
	}
}
