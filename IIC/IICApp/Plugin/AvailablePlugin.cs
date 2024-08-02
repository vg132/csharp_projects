using System;
using IIC.Plugin;

namespace IIC.Plugin
{
		/// <summary>
		/// Data Class for Available Plugin. Holds and instance of the loaded Plugin, as well as the Plugin's Assembly Path
		/// </summary>
	public class AvailablePlugin
	{
		private IPlugin myInstance=null;
		private string myAssemblyPath="";

		/// <summary>
		/// Gets and sets the plugin instance.
		/// </summary>
		public IPlugin Instance
		{
			get
			{
				return(myInstance);
			}
			set
			{
				myInstance = value;
			}
		}

		/// <summary>
		/// Gets and sets the plugin assembly path.
		/// </summary>
		public string AssemblyPath
		{
			get
			{
				return(myAssemblyPath);
			}
			set
			{
				myAssemblyPath = value;
			}
		}
	}
}