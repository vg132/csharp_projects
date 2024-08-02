using System;
using System.Collections;
using System.Windows.Forms;

namespace IIC.Plugin
{
	/// <summary>
	/// Interface for communication between the plugin and the host application.
	/// </summary>
	public interface IPluginHost
	{
		/// <summary>
		/// Tells the host application that it should alert the user of events in this plugin
		/// </summary>
		/// <param name="plugin">Reference to the calling plugin.</param>
		/// <param name="message">Text in the alert window.</param>
		/// <param name="id">Id value that will be sent back to the plugin when the user awnsers a alert.</param>
		void ShowAlert(IPlugin plugin, object id, string message);
		/// <summary>
		/// Sets a message in the programs statusbar.
		/// </summary>
		string StatusBarMessage{set;}
		/// <summary>
		/// Gets a list of all loaded plugins in the host application.
		/// </summary>
		IList Plugins{get;}
		/// <summary>
		/// Called by the plugin when the host appliction must get a new
		/// user control from the plugin.
		/// </summary>
		void UpdateForm(IPlugin plugin);
		/// <summary>
		/// Gets the users selected data directory.
		/// </summary>
		string DataDirectory{get;}
		/// <summary>
		/// Gets the directory where all plugins are loaded from.
		/// </summary>
		string PluginDirectory{get;}
		/// <summary>
		/// Gets the application directory root.
		/// </summary>
		string ApplicationDirectory{get;}
	}
}
