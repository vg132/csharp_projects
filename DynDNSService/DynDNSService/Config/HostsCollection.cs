using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DynDNSService.Config
{
	[ConfigurationCollection(typeof(HostElement))]
	public class HostsCollection : ConfigurationElementCollection
	{
		/// <summary>
		/// When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement"></see>.
		/// </summary>
		/// <returns>
		/// A new <see cref="T:System.Configuration.ConfigurationElement"></see>.
		/// </returns>
		protected override ConfigurationElement CreateNewElement()
		{
			return new HostElement();
		}

		/// <summary>
		/// Gets the element key for a specified configuration element when overridden in a derived class.
		/// </summary>
		/// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement"></see> to return the key for.</param>
		/// <returns>
		/// An <see cref="T:System.Object"></see> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement"></see>.
		/// </returns>
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((HostElement)element).Name;
		}

		/// <summary>
		/// Gets the <see cref="ConfigTest.HostElement"/> at the specified index.
		/// </summary>
		/// <value></value>
		public HostElement this[int index]
		{
			get
			{
				return (HostElement)BaseGet(index);
			}
		}
	}
}
