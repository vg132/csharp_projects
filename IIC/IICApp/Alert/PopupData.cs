using System;
using IIC.Alert;
using IIC.Plugin;

namespace IIC.Alert
{
	/// <summary>
	/// Summary description for PopupData.
	/// </summary>
	public class PopupData
	{
		private string message=null;
		private IPlugin plugin=null;
		private object id=null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="plugin"></param>
		/// <param name="id"></param>
		/// <param name="message"></param>
		public PopupData(IPlugin plugin, object id, string message)
		{
			this.plugin=plugin;
			this.id=id;
			this.message=message;
		}

		/// <summary>
		/// Gets and sets the string value of message.
		/// </summary>
		public string Message
		{
			get
			{
				return(this.message);
			}
			set
			{
				this.message=value;
			}
		}

		/// <summary>
		/// Gets and sets the IPlugin value of plugin.
		/// </summary>
		public IPlugin Plugin
		{
			get
			{
				return(this.plugin);
			}
			set
			{
				this.plugin=value;
			}
		}

		/// <summary>
		/// Gets and sets the object value of id.
		/// </summary>
		public object Id
		{
			get
			{
				return(this.id);
			}
			set
			{
				this.id=value;
			}
		}
	}
}
