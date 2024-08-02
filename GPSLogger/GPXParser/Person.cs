using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser
{
	/// <summary>
	/// A person or organization.
	/// </summary>
	public class Person
	{
		/// <summary>
		/// Name of person or organization.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Email address.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Link to Web site or other external information about person.
		/// </summary>
		public Link Link { get; set; }
	}
}
