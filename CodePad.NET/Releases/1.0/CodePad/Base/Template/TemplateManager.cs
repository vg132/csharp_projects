using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VGSoftware.CodePad.Base.Template
{
	public class TemplateManager
	{
		private static TemplateManager _instance;
		private static object _instanceLock = new object();
		private List<Template> _templates;
		private object _templatesLock = new object();

		private TemplateManager()
		{
		}

		public static TemplateManager Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_instanceLock)
					{
						if (_instance == null)
						{
							_instance = new TemplateManager();
						}
					}
				}
				return _instance;
			}
		}

		public List<Template> Templates
		{
			get
			{
				if (_templates == null)
				{
					lock (_templatesLock)
					{
						if (_templates == null)
						{
							_templates = new List<Template>();
							DirectoryInfo templateDirectory = new DirectoryInfo(Properties.Settings.Default.TemplateDirectory);
							foreach (FileInfo file in templateDirectory.GetFiles("*.xml"))
							{
								_templates.Add(Template.LoadTemplate(file.FullName));
							}
						}
					}
				}
				return _templates;
			}
		}

		public IEnumerable<string> Categories
		{
			get
			{
				return (from template in Templates
								select template.Category).Distinct();
			}
		}

		public IEnumerable<Template> GetTemplates(string category)
		{
			return from template in Templates
						 where template.Category == category
						 select template;
		}

		public Template GetTemplate(string name)
		{
			return (from template in Templates
							where template.Name == name
							select template).First();
		}
	}
}
