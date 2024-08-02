using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DynDNSService.Config
{
	public class HostElement : ConfigurationElement
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		[ConfigurationProperty("name", DefaultValue="", IsKey=true, IsRequired=true)]
		public string Name
		{
			get
			{
				return (string)this["name"];
			}
			set
			{
				this["name"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		/// <value>The password.</value>
		[ConfigurationProperty( "password", DefaultValue = "", IsKey = false, IsRequired = true )]
		public string Password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the domain.
		/// </summary>
		/// <value>The domain.</value>
		[ConfigurationProperty("domain", DefaultValue = "", IsKey = false, IsRequired = true)]
		public string Domain
		{
			get
			{
				return (string)this["domain"];
			}
			set
			{
				this["domain"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the IP.
		/// </summary>
		/// <value>The IP.</value>
		[ConfigurationProperty("ip", DefaultValue = "", IsKey = false, IsRequired = false)]
		public string IP
		{
			get
			{
				return (string)this["ip"];
			}
			set
			{
				this["ip"] = value;
			}
		}
	}
}
