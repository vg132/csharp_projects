using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPS.GPX
{
	/// <summary>
	/// A link to an external resource (Web page, digital photo, video clip, etc) with additional information.
	/// </summary>
	public class Link
	{
		/// <summary>
		/// Text of hyperlink.
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Mime type of content (image/jpeg)
		/// </summary>
		public string MimeType { get; set; }

		/// <summary>
		/// URL of hyperlink.
		/// </summary>
		public string Href { get; set; }
	}
}
