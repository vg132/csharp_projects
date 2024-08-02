using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGSoftware.GPSLogger.GPXParser.Enums
{
	/// <summary>
	/// Type of GPS fix.  none means GPS had no fix.
	/// To signify "the fix info is unknown, leave out fixType entirely. pps = military signal used
	/// </summary>
	public enum GPSFixType
	{
		None,
		TwoD,
		ThreeD,
		Dgps,
		Pps
	}
}
