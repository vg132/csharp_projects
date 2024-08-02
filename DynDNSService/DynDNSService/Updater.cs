using System;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace DynDNSService
{
	public class Updater
	{
		private Config.DynDNSConfigSection _configuration;
		private static Updater _instance;

		/// <summary>
		/// Initializes a new instance of the <see cref="Updater"/> class.
		/// </summary>
		private Updater()
		{
			Configuration = (Config.DynDNSConfigSection)ConfigurationManager.GetSection("DynDNS");
		}

		#region Properties

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>The instance.</value>
		public static Updater Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Updater();
				return _instance;
			}
		}

		public Config.DynDNSConfigSection Configuration
		{
			get
			{
				return _configuration;
			}
			set
			{
				_configuration = value;
			}
		}

		#endregion

		public void Update()
		{
			foreach (Config.HostElement element in Configuration.HostItems)
			{
				List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
				list.Add(new KeyValuePair<string, string>(Configuration.HostParameterName, element.Name));
				list.Add(new KeyValuePair<string, string>(Configuration.DomainParameterName, element.Domain));
				list.Add(new KeyValuePair<string, string>(Configuration.PasswordParameterName, element.Password));
				if (!string.IsNullOrEmpty(element.IP))
					list.Add(new KeyValuePair<string, string>(Configuration.IPParameterName, element.IP));
				SendUpdate(string.Format("{0}{1}", Configuration.URL, BuildQueryString(list)));
			}
		}

		private string BuildQueryString(IList<KeyValuePair<string,string>> values)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < values.Count; i++)
				sb.Append(string.Format("{0}{1}={2}", (i == 0 ? "?" : "&"), values[i].Key, HttpUtility.UrlEncode(values[i].Value)));
			return sb.ToString();
		}

		private void SendUpdate(string url)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				response.Close();
			}
			catch
			{
			}
		}
	}
}
