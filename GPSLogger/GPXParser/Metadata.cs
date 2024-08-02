using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser
{
	/// <summary>
	/// Information about the GPX file, author, and copyright restrictions goes in the metadata section.
	/// Providing rich, meaningful information about your GPX files allows others to search for and use your GPS data.
	/// </summary>
	public class Metadata
	{
		/// <summary>
		/// The name of the GPX file.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// A description of the contents of the GPX file.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The person or organization who created the GPX file.
		/// </summary>
		public Person Author { get; set; }

		/// <summary>
		/// Copyright and license information governing use of the file.
		/// </summary>
		public Copyright Copyright { get; set; }

		/// <summary>
		/// URLs associated with the location described in the file.
		/// </summary>
		public List<Link> Links { get; set; }

		/// <summary>
		/// The creation date of the file.
		/// </summary>
		public DateTime Time { get; set; }

		/// <summary>
		/// Keywords associated with the file. Search engines or databases can use this information to classify the data.
		/// </summary>
		public string Keywords { get; set; }

		/// <summary>
		/// Minimum and maximum coordinates which describe the extent of the coordinates in the file.
		/// </summary>
		public Rect Rect { get; set; }
	}
}
