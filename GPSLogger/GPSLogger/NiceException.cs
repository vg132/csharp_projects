using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger
{
	public class NiceException : Exception
	{
		public NiceException(string message)
			: base(message)
		{
		}

		public NiceException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
