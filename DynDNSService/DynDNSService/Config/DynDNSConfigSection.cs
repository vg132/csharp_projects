using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DynDNSService.Config
{
	public class DynDNSConfigSection : ConfigurationSection
	{
		/// <summary>
		/// Gets the host items.
		/// </summary>
		/// <value>The host items.</value>
		[ConfigurationProperty("hosts")]
		public HostsCollection HostItems
		{
			get
			{
				return ((HostsCollection)(base["hosts"]));
			}
		}

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>The URL.</value>
		[ConfigurationProperty("url",DefaultValue="http://dynamicdns.park-your-domain.com/update")]
		public string URL
		{
			get
			{
				return (string)this["url"];
			}
			set
			{
				this["url"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the host parameter.
		/// </summary>
		/// <value>The name of the host parameter.</value>
		[ConfigurationProperty("hostParameterName", DefaultValue = "host", IsRequired = false)]
		public string HostParameterName
		{
			get
			{
				return (string)this["hostParameterName"];
			}
			set
			{
				this["hostParameterName"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the domain parameter.
		/// </summary>
		/// <value>The name of the domain parameter.</value>
		[ConfigurationProperty("domainParameterName", DefaultValue = "domain", IsRequired = false)]
		public string DomainParameterName
		{
			get
			{
				return (string)this["domainParameterName"];
			}
			set
			{
				this["domainParameterName"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the password parameter.
		/// </summary>
		/// <value>The name of the password parameter.</value>
		[ConfigurationProperty("passwordParameterName", DefaultValue = "password", IsRequired = false)]
		public string PasswordParameterName
		{
			get
			{
				return (string)this["passwordParameterName"];
			}
			set
			{
				this["passwordParameterName"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the name of the IP parameter.
		/// </summary>
		/// <value>The name of the IP parameter.</value>
		[ConfigurationProperty("ipParameterName", DefaultValue = "ip", IsRequired = false)]
		public string IPParameterName
		{
			get
			{
				return (string)this["ipParameterName"];
			}
			set
			{
				this["ipParameterName"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the update interval.
		/// </summary>
		/// <value>The update interval.</value>
		[ConfigurationProperty("updateInterval",DefaultValue=15,IsRequired=true)]
		[IntegerValidator(MinValue=1, MaxValue=1440)]
		public int UpdateInterval
		{
			get
			{
				return (int)this["updateInterval"];
			}
			set
			{
				this["updateInterval"] = value;
			}
		}
	}
}
