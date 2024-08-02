using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser
{
	/// <summary>
	/// Information about the copyright holder and any license governing use of this file.
	/// By linking to an appropriate license, you may place your data into the public domain
	/// or grant additional usage rights.
	/// </summary>
	public class Copyright
	{
		/// <summary>
		/// Year of copyright.
		/// </summary>
		public int Year { get; set; }

		/// <summary>
		/// Copyright holder (TopoSoft, Inc.)
		/// </summary>
		public string Author { get; set; }

		/// <summary>
		/// Link to external file containing license text.
		/// </summary>
		public string License { get; set; }
	}
}
