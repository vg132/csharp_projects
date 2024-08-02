using System;
using IIC.Plugin;
using IIC.Alert;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace IIC
{
	/// <summary>
	/// Summary description for Host.
	/// </summary>
	public class Host : IPluginHost
	{
		private string applicationDirectory=null;
		private IIC form=null;
		private IPlugin activePlugin=null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="form"></param>
		public Host(IIC form)
		{
			this.form=form;
		}

		/// <summary>
		/// Activates a alert for ths user with the specified information.
		/// </summary>
		/// <param name="plugin">Reference to the calling plugin.</param>
		/// <param name="id">Id for this alert, sent back to plugin when user awnsers alert call.</param>
		/// <param name="message">The message in the alert window.</param>
		public void ShowAlert(IPlugin plugin, object id, string message)
		{
			PopupForm.Instance.AddPopup(new PopupData(plugin,id,message));
		}

		/// <summary>
		/// Called when the plugin wants to update the user control.
		/// Only updates the view if the calling plugin is the active plugin.
		/// </summary>
		/// <param name="plugin">The calling plugin</param>
		public void UpdateForm(IPlugin plugin)
		{
			if(plugin==activePlugin)
				form.SetForm(plugin.Form);
		}

		/// <summary>
		/// Returns a list of all loaded plugins.
		/// </summary>
		public IList Plugins
		{
			get
			{
				return(null);
			}
			set
			{
			}
		}

		/// <summary>
		/// Sets the statusbar text.
		/// </summary>
		public string StatusBarMessage
		{
			set
			{
				form.setStatusInformation(value);
			}
		}

		/// <summary>
		/// Gets and sets the IPlugin value of activePlugin.
		/// </summary>
		public IPlugin ActivePlugin
		{
			get
			{
				return(this.activePlugin);
			}
			set
			{
				this.activePlugin=value;
			}
		}

		/// <summary>
		/// Gets the users data directory.
		/// </summary>
		public string DataDirectory
		{
			get
			{
				return(applicationDirectory+"\\data");
			}
		}

		/// <summary>
		/// Gets the plugin directory.
		/// </summary>
		public string PluginDirectory
		{
			get
			{
				return(applicationDirectory+"\\plugins");
			}
		}

		/// <summary>
		/// Gets the application directory.
		/// </summary>
		public string ApplicationDirectory
		{
			get
			{
				return(applicationDirectory);
			}
			set
			{
				applicationDirectory=value;
				if(applicationDirectory.EndsWith("\\"))
					applicationDirectory=applicationDirectory.Substring(0,applicationDirectory.Length-1);
			}
		}
	}
}
