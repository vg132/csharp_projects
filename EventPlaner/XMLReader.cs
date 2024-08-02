using System;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Xml;
using System.Globalization;
using System.IO;
using System.Collections;

namespace EventPlaner
{
	/// <summary>
	/// Summary description for XMLReader.
	/// </summary>
	public class XMLReader
	{
		public XMLReader()
		{
		}
		
		public void WriteEventFile(ArrayList events, string filename)
		{
			events.Sort(0,events.Count,null);
			TimeZone localZone=TimeZone.CurrentTimeZone;

			XmlTextWriter xWriter=new XmlTextWriter(filename, System.Text.Encoding.Unicode);
			xWriter.Indentation = 1;
			xWriter.IndentChar= '\t';
			xWriter.Formatting = Formatting.Indented;
			xWriter.WriteStartDocument();
			xWriter.WriteStartElement("schedule");
			foreach(Event eve in events)
			{
				xWriter.WriteStartElement("event");
				xWriter.WriteAttributeString("name",eve.Name);
				xWriter.WriteAttributeString("start",localZone.ToUniversalTime(eve.Start).AddDays(1).ToString("yyyy-MM-dd"));
				xWriter.WriteAttributeString("end",localZone.ToUniversalTime(eve.End).AddDays(1).ToString("yyyy-MM-dd"));			
				eve.SortEventEnterys();
				ArrayList enterys=eve.GetEnterys();
				foreach(EventEntery entery in enterys)
				{
					xWriter.WriteStartElement("entery");
					xWriter.WriteAttributeString("event",entery.EventName);
					xWriter.WriteAttributeString("niceName",entery.NiceName);
					xWriter.WriteAttributeString("open",localZone.ToUniversalTime(entery.Open).ToString("yyyy-MM-dd HH:mm")+" UTC");
					xWriter.WriteAttributeString("close",localZone.ToUniversalTime(entery.Close).ToString("yyyy-MM-dd HH:mm")+" UTC");
					xWriter.WriteEndElement();
				}
				xWriter.WriteEndElement();
			}
			xWriter.WriteEndElement();
			xWriter.WriteEndDocument();
			xWriter.Flush();
			xWriter.Close();	
		}

		public ArrayList readEventFile(string file)
		{
			TimeZone localZone=TimeZone.CurrentTimeZone;
			TreeNode node=new TreeNode("Events");
			
			XPathDocument xmlDoc=new XPathDocument(file);
			XPathNavigator xmlNav=xmlDoc.CreateNavigator();
			XPathNodeIterator xmlIterator=xmlNav.Select("//schedule/event");
			
			ArrayList events=new ArrayList();
			Event eve=null;
			EventEntery ee=null;
			while(xmlIterator.MoveNext())
			{
				eve=new Event();
				events.Add(eve);
				xmlIterator.Current.MoveToFirstAttribute();
				eve.Name=xmlIterator.Current.Value;
				xmlIterator.Current.MoveToNextAttribute();
				eve.Start=DateTime.Parse(xmlIterator.Current.Value);
				xmlIterator.Current.MoveToNextAttribute();
				eve.End=DateTime.Parse(xmlIterator.Current.Value);

				xmlIterator.Current.MoveToParent();
				xmlIterator.Current.MoveToFirstChild();
				do
				{
					ee=new EventEntery();
					xmlIterator.Current.MoveToFirstAttribute();
					ee.EventName=xmlIterator.Current.Value;
					xmlIterator.Current.MoveToNextAttribute();
					ee.NiceName=xmlIterator.Current.Value;
					xmlIterator.Current.MoveToNextAttribute();
					ee.Open=localZone.ToLocalTime(DateTime.ParseExact(xmlIterator.Current.Value,"yyyy-MM-dd HH:mm UTC",null));
					xmlIterator.Current.MoveToNextAttribute();
					ee.Close=localZone.ToLocalTime(DateTime.ParseExact(xmlIterator.Current.Value,"yyyy-MM-dd HH:mm UTC",null));
					eve.AddEntery(ee);
					xmlIterator.Current.MoveToParent();
				}while(xmlIterator.Current.MoveToNext());
			}
			return(events);
		}
	}
}
