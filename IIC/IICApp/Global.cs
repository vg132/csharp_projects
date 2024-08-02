using System;
using IIC.Plugin;

namespace IIC
{
	/// <summary>
	/// Class to give global access to the static variable <c>Plugins</c>.
	/// </summary>
	public class Global
	{
		/// <summary>
		/// Static variable to a <c>PluginServices</c> object, only one needed for this application.
		/// </summary>
		public static PluginServices Plugins=new PluginServices();

		/// <summary>
		/// Default empty constructor.
		/// </summary>
		public Global()
		{
		}
	}
}
