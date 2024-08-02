using System;
using System.IO;
using System.Xml;
using System.Reflection;

namespace XFriendsApp
{
	/// <summary>
	/// Summary description for Settings.
	/// </summary>
	public class Settings
	{
		public Settings()
		{
		}

		private string m_UpdateFrequency;
		public string UpdateFrequency
		{
			get
			{
				return(this.m_UpdateFrequency);
			}
			set
			{
				this.m_UpdateFrequency=value;
			}
		}

		private string m_OfflineSound;
		public string OfflineSound
		{
			get
			{
				return(this.m_OfflineSound);
			}
			set
			{
				this.m_OfflineSound=value;
			}
		}

		private string m_OnlineSound;
		public string OnlineSound
		{
			get
			{
				return(this.m_OnlineSound);
			}
			set
			{
				this.m_OnlineSound=value;
			}
		}

		private string m_PassportLink;
		public string PassportLink
		{
			get
			{
				return(this.m_PassportLink);
			}
			set
			{
				this.m_PassportLink=value;
			}
		}


		private string m_LoginLinkPrefix;
		public string LoginLinkPrefix
		{
			get
			{
				return(this.m_LoginLinkPrefix);
			}
			set
			{
				this.m_LoginLinkPrefix=value;
			}
		}

		private string m_OnlineSuffix;
		public string OnlineSuffix
		{
			get
			{
				return(this.m_OnlineSuffix);
			}
			set
			{
				this.m_OnlineSuffix=value;
			}
		}

		private string m_OfflineSuffix;
		public string OfflineSuffix
		{
			get
			{
				return(this.m_OfflineSuffix);
			}
			set
			{
				this.m_OfflineSuffix=value;
			}
		}

		private string m_MainPage;
		public string MainPage
		{
			get
			{
				return(this.m_MainPage);
			}
			set
			{
				this.m_MainPage=value;
			}
		}

		private string m_FriendsPage;
		public string FriendsPage
		{
			get
			{
				return(this.m_FriendsPage);
			}
			set
			{
				this.m_FriendsPage=value;
			}
		}

		private string m_LoginErrorPage;
		public string LoginErrorPage
		{
			get
			{
				return(this.m_LoginErrorPage);
			}
			set
			{
				this.m_LoginErrorPage=value;
			}
		}

		public void Save(string file)
		{
			XmlTextWriter xWriter=new XmlTextWriter(file,System.Text.Encoding.Unicode);
			xWriter.Indentation=1;
			xWriter.Formatting=Formatting.Indented;
			xWriter.IndentChar='\t';
			xWriter.WriteStartDocument();
			xWriter.WriteStartElement("settings");
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","UpdateFrequency");
			xWriter.WriteAttributeString("value", m_UpdateFrequency);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","OfflineSound");
			xWriter.WriteAttributeString("value", m_OfflineSound);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","OnlineSound");
			xWriter.WriteAttributeString("value", m_OnlineSound);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","PassportLink");
			xWriter.WriteAttributeString("value", m_PassportLink);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","LoginLinkPrefix");
			xWriter.WriteAttributeString("value", m_LoginLinkPrefix);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","OnlineSuffix");
			xWriter.WriteAttributeString("value", m_OnlineSuffix);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","OfflineSuffix");
			xWriter.WriteAttributeString("value", m_OfflineSuffix);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","MainPage");
			xWriter.WriteAttributeString("value", m_MainPage);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","FriendsPage");
			xWriter.WriteAttributeString("value", m_FriendsPage);
			xWriter.WriteEndElement();
			xWriter.WriteStartElement("setting");
			xWriter.WriteAttributeString("option","LoginErrorPage");
			xWriter.WriteAttributeString("value", m_LoginErrorPage);
			xWriter.WriteEndElement();
			xWriter.WriteEndElement();
			xWriter.WriteEndDocument();

			xWriter.Flush();
			xWriter.Close();
		}

		public void Load(string file)
		{
			Type t=typeof(Settings);
			XmlTextReader xReader=new XmlTextReader(file);
			xReader.NameTable.Add("setting");

			while(xReader.Read())
			{
				if((xReader.NodeType==XmlNodeType.Element)&&(xReader.Name.Equals("setting")))
					t.InvokeMember(xReader.GetAttribute("option"),BindingFlags.DeclaredOnly|BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.SetProperty,null,this,new object[]{xReader.GetAttribute("value")});
			}
			xReader.Close();
		}
	}
}
