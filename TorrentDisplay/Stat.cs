using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace TorrentDisplay
{
	/// <summary>
	/// Summary description for Stat.
	/// </summary>
	public class Stat
	{
		private string status=null;
		private string message=null;
		private double totalUpload=0.0;
		private double totalDownload=0.0;
		private string uploadSpeed=null;
		private string downloadSpeed=null;
		private string peers=null;
		private string seeders=null;
		private string progress=null;
		private string filename=null;

		public Stat()
		{
		}

		public string OtherInfo
		{
			get
			{
				string tmp=filename;
				tmp=filename.Substring(filename.LastIndexOf("/")+1);
				tmp=tmp.Substring(0,tmp.LastIndexOf("."));
				tmp=tmp.Replace("."," ").Replace("_"," ").Replace("[1]","");
				String[] str=Regex.Split(tmp,"[A-Z]{2,}");
				if(str.Length>1)
				{
					if(str[0].Length>5)
						tmp=str[0];
				}
				tmp+="\nStatus: "+status+" ("+progress+")";
				if(!message.Trim().Equals(""))
					tmp+="\nMessage: "+message;
				return(tmp);
			}
		}

		public string Info
		{
			get
			{
				string tmp=filename;
				tmp=filename.Substring(filename.LastIndexOf("/")+1);
				tmp=tmp.Substring(0,tmp.LastIndexOf("."));
				tmp=tmp.Replace("."," ").Replace("_"," ").Replace("[1]","");
				String[] str=Regex.Split(tmp,"[A-Z]{2,}");
				if(str.Length>1)
				{
					if(str[0].Length>5)
						tmp=str[0];
				}
				tmp+="\nStatus: "+status+" ("+progress+")";
				tmp+="\nSpeed up: "+uploadSpeed+" down: "+downloadSpeed;
				tmp+="\nTotal up: "+TotalUpload+" down: "+TotalDownload;
				tmp+="\nSeeders: "+Seeders+" Peers: "+Peers;
				if(!message.Trim().Equals(""))
					tmp+="\nMessage: "+message;
				return(tmp);
			}
		}

		public string Name
		{
			get
			{
				return(filename.Substring(filename.LastIndexOf("/")+1));
			}
		}

		/// <summary>
		/// Gets and sets the string value of filename.
		/// </summary>
		public string Filename
		{
			get
			{
				return(this.filename);
			}
			set
			{
				this.filename=value;
			}
		}

		public string WindowsFilename
		{
			get
			{
				string tmp=filename;
				tmp=tmp.Replace("/","\\").Replace("\\home\\viktor\\.bittorrent\\torrents\\","");
				return((tmp.StartsWith("tv")?"w:\\torrent\\":"v:\\torrent\\")+tmp.Substring(tmp.IndexOf("\\")+1));
			}
		}

		public string WindowsDirectory
		{
			get
			{
				string tmp=WindowsFilename;
				return(tmp.Substring(0,tmp.Length-".torrent".Length));
			}
		}

		public string DirectoryName
		{
			get
			{
				return(Name.Substring(0,Name.Length-".torrent".Length));
			}
		}

		/// <summary>
		/// Gets and sets the string value of status.
		/// </summary>
		public string Status
		{
			get
			{
				return(this.status);
			}
			set
			{
				this.status=value;
			}
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
		/// Gets and sets the string value of totalUpload.
		/// </summary>
		public string TotalUpload
		{
			get
			{
				if(totalUpload>1000000)
					return(((Double)Math.Round(this.totalUpload/1024000,2)).ToString()+"Gb");
				else
					return(((Double)Math.Round(this.totalUpload/1024,2)).ToString()+"Mb");
			}
			set
			{
				this.totalUpload=Double.Parse(value);
			}
		}

		/// <summary>
		/// Gets and sets the string value of totalDownload.
		/// </summary>
		public string TotalDownload
		{
			get
			{
				if(totalDownload>1000000)
					return(((Double)Math.Round(this.totalDownload/1024000,2)).ToString()+"Gb");
				else
					return(((Double)Math.Round(this.totalDownload/1024,2)).ToString()+"Mb");
			}
			set
			{
				this.totalDownload=Double.Parse(value);
			}
		}

		/// <summary>
		/// Gets and sets the string value of uploadSpeed.
		/// </summary>
		public string UploadSpeed
		{
			get
			{
				return(this.uploadSpeed);
			}
			set
			{
				this.uploadSpeed=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of downloadSpeed.
		/// </summary>
		public string DownloadSpeed
		{
			get
			{
				return(this.downloadSpeed);
			}
			set
			{
				this.downloadSpeed=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of peers.
		/// </summary>
		public string Peers
		{
			get
			{
				return(this.peers);
			}
			set
			{
				this.peers=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of seeders.
		/// </summary>
		public string Seeders
		{
			get
			{
				return(this.seeders);
			}
			set
			{
				this.seeders=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of progress.
		/// </summary>
		public string Progress
		{
			get
			{
				return(this.progress);
			}
			set
			{
				this.progress=value;
			}
		}
	}
}
