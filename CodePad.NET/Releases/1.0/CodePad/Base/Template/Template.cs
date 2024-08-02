using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace VGSoftware.CodePad.Base.Template
{
	public class Template
	{
		private Template(string filename)
		{
			FileName = filename;
			XPathDocument xDoc = new XPathDocument(filename);
			XPathNavigator xNav = xDoc.CreateNavigator();
			Name = ReadStringValue(xNav, "/CodePadTemplate/Description/Name");
			Author = ReadStringValue(xNav, "/CodePadTemplate/Description/Author");
			Description = ReadStringValue(xNav, "/CodePadTemplate/Description/Description");
			Category = ReadStringValue(xNav, "/CodePadTemplate/Description/Category");
			FileNameTemplate = ReadStringValue(xNav, "/CodePadTemplate/Description/FileNameTemplate");
			int index;
			if (int.TryParse(ReadStringValue(xNav, "/CodePadTemplate/Description/IconIndex"), out index))
			{
				IconIndex = index;
			}
			else
			{
				IconIndex = 0;
			}
			Code = ReadStringValue(xNav, "/CodePadTemplate/Template");
		}

		#region  Methods

		public static Template LoadTemplate(string fileName)
		{
			if (File.Exists(fileName))
			{
				return new Template(fileName);
			}
			return null;
		}

		private string ReadStringValue(XPathNavigator xNav, string path)
		{
			XPathNavigator tmpNode = xNav.SelectSingleNode(path);
			if (tmpNode != null && !string.IsNullOrEmpty(tmpNode.Value))
			{
				return tmpNode.Value.Trim();
			}
			return string.Empty;
		}

		#endregion

		#region Properties

		public string FileName
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Author
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public string Category
		{
			get;
			set;
		}

		public string FileNameTemplate
		{
			get;
			set;
		}

		public int IconIndex
		{
			get;
			set;
		}

		public string Code
		{
			get;
			set;
		}

		#endregion
	}
}
