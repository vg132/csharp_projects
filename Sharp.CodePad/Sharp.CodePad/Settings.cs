using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace VGSoftware.Sharp.CodePad
{
	[XmlRootAttribute("Settings")]
	public class Settings
	{
		private List<string> _references;

		private static Settings _instance;
		private static object _instanceLock = new object();

		private Settings()
		{
		}

		public static Settings Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_instanceLock)
					{
						if (_instance == null)
						{
							_instance = Load();
						}
					}
				}
				return _instance;
			}
		}

		[XmlArray("References")]
		public List<string> References
		{
			get
			{
				if (_references == null)
				{
					_references = new List<string>();
				}
				return _references;
			}
			set
			{
				_references = value;
			}
		}

		public bool Save()
		{
			try
			{
				XmlWriter xmlWriter = XmlWriter.Create("Settings.xml");
				System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
				x.Serialize(xmlWriter, this);
				xmlWriter.Close();
			}
			catch
			{
				return false;
			}
			return true;
		}

		private static Settings Load()
		{
			if (File.Exists("Settings.xml"))
			{
				System.Xml.Serialization.XmlSerializer x = new XmlSerializer(typeof(Settings));
				object obj = x.Deserialize(XmlReader.Create("Settings.xml"));
				if (obj is Settings)
				{
					return obj as Settings;
				}
			}
			return new Settings();
		}
	}
}
