using System;
using System.IO;
using System.Windows.Forms;

namespace TorrentDisplay
{
	/// <summary>
	/// Summary description for FileMenuItem.
	/// </summary>
	public class FileMenuItem : MenuItem
	{
		private FileInfo file=null;

		public FileMenuItem(string text, FileInfo file, System.EventHandler onClick)
		{
			this.Text=text;
			this.file=file;
			this.Click+=onClick;
		}

		public FileInfo File
		{
			get
			{
				return(this.file);
			}
			set
			{
				this.file=value;
			}
		}
	}
}
