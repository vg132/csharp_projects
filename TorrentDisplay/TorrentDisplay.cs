using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Reflection;

namespace TorrentDisplay
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TorrentDisplay : System.Windows.Forms.Form
	{
		private static string TV_FOLDER="w:\\torrent\\";
		private static string FILM_FOLDER="v:\\torrent\\";

		string m_RegPattern="\"(?<name>[^\"]+)\"\\s*:\\s*\"(?<status>[^\"]*)\"\\s*\\((?<progress>[a-zA-Z0-9.%]*)\\)\\s*-\\s*(?<peers>[0-9]*)[pP](?<seeders>[0-9]*)[0-9a-zA-Z.]*\\s*[uU](?<upSpeed>[0-9a-zA-Z.\\/]*)[-dD]*(?<downSpeed>[0-9a-zA-Z.\\/]*)\\s*[uU](?<totalUpload>[0-9]*)[a-zA-Zd-]*(?<totalDownload>[0-9]*)[a-zA-Z]*\\s*\"(?<message>[^\"]*)";

		private ScrollPanel m_Downloading=new ScrollPanel("Downloading",true,240);
		private ScrollPanel m_Seeding=new ScrollPanel("Seeding",true,240);
		private ScrollPanel m_Other=new ScrollPanel("Other",true,240);

		private System.Windows.Forms.Timer tmrUpdate;
		private System.ComponentModel.IContainer components;
		private Hashtable rects=new Hashtable();
		private System.Windows.Forms.ContextMenu mnuPopup;
		private System.Windows.Forms.MenuItem mnuPopupRefresh;
		private System.Windows.Forms.MenuItem mnuPopupAbout;
		private System.Windows.Forms.MenuItem mnuPopupPause;
		private System.Windows.Forms.MenuItem mnuPopupSep;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuPopupFinish;
		private Stat currentStat=null;
	
		[DllImport("User32.dll")]
		public static extern Int32 FindWindow(String lpClassName,String lpWindowName);
		[DllImport("user32.dll")]
		static extern int SetParent(int hWndChild, int hWndNewParent);

		public TorrentDisplay()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.SendToBack();
			int pWnd=FindWindow("Progman",null);
			int tWnd=this.Handle.ToInt32();
			SetParent(tWnd, pWnd);
			this.Height=SystemInformation.WorkingArea.Height;
			this.Top=0;
			this.Left=0;
			this.Width=220;
			this.BackgroundImage=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.bg.png"));

			m_Downloading.TextClicked+=new TextClickedEventHandler(this.TextClicked);
			m_Downloading.LayoutChanged+=new LayoutChangedEventHandler(this.LayoutChanged);
			m_Seeding.TextClicked+=new TextClickedEventHandler(this.TextClicked);
			m_Seeding.LayoutChanged+=new LayoutChangedEventHandler(this.LayoutChanged);
			m_Other.TextClicked+=new TextClickedEventHandler(this.TextClicked);
			m_Other.LayoutChanged+=new LayoutChangedEventHandler(this.LayoutChanged);
			this.Controls.Add(m_Downloading);
			this.Controls.Add(m_Seeding);
			this.Controls.Add(m_Other);
			LayoutPanels();

			tmrUpdate.Start();
			UpdateData();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.mnuPopup = new System.Windows.Forms.ContextMenu();
			this.mnuPopupPause = new System.Windows.Forms.MenuItem();
			this.mnuPopupSep = new System.Windows.Forms.MenuItem();
			this.mnuPopupRefresh = new System.Windows.Forms.MenuItem();
			this.mnuPopupAbout = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.mnuPopupFinish = new System.Windows.Forms.MenuItem();
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
			this.tmrUpdate.Interval = 60000;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
			// 
			// mnuPopup
			// 
			this.mnuPopup.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																						 this.mnuPopupPause,
																																						 this.mnuPopupSep,
																																						 this.mnuPopupRefresh,
																																						 this.mnuPopupAbout,
																																						 this.mnuExit,
																																						 this.mnuPopupFinish});
			// 
			// mnuPopupPause
			// 
			this.mnuPopupPause.Index = 0;
			this.mnuPopupPause.Text = "Pause torrent";
			this.mnuPopupPause.Click += new System.EventHandler(this.mnuPopupPause_Click);
			// 
			// mnuPopupSep
			// 
			this.mnuPopupSep.Index = 1;
			this.mnuPopupSep.Text = "-";
			// 
			// mnuPopupRefresh
			// 
			this.mnuPopupRefresh.Index = 2;
			this.mnuPopupRefresh.Text = "Refresh list";
			this.mnuPopupRefresh.Click += new System.EventHandler(this.mnuPopupRefresh_Click);
			// 
			// mnuPopupAbout
			// 
			this.mnuPopupAbout.Index = 3;
			this.mnuPopupAbout.Text = "About...";
			this.mnuPopupAbout.Click += new System.EventHandler(this.mnuPopupAbout_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 4;
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuPopupFinish
			// 
			this.mnuPopupFinish.Index = 5;
			this.mnuPopupFinish.Text = "Finish torrent...";
			this.mnuPopupFinish.Click += new System.EventHandler(this.mnuPopupFinish_Click);
			// 
			// TorrentDisplay
			// 
			this.AutoScaleDimensions=new SizeF(5, 13);
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(220, 440);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TorrentDisplay";
			this.ShowInTaskbar = false;
			this.Text = "Form1";
			this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TorrentDisplay());
		}

		private void Form1_SizeChanged(object sender, System.EventArgs e)
		{
		}

		private void ParseTorrentLog(string file)
		{
			Stat stat=null;
			string content=GetLogContent(file);
			String[] torrents=Regex.Split(content,"\n");
			foreach(String torrent in torrents)
			{
				Match match = Regex.Match(torrent,m_RegPattern);
				if(match.Success)
				{
					stat=new Stat();
					stat.Filename=match.Groups["name"].Value;
					stat.Status=match.Groups["status"].Value;
					stat.Progress=match.Groups["progress"].Value;
					stat.Peers=match.Groups["peers"].Value;
					stat.Seeders=match.Groups["seeders"].Value;
					stat.UploadSpeed=match.Groups["upSpeed"].Value;
					stat.DownloadSpeed=match.Groups["downSpeed"].Value;
					stat.TotalUpload=match.Groups["totalUpload"].Value;
					stat.TotalDownload=match.Groups["totalDownload"].Value;
					stat.Message=match.Groups["message"].Value;
					if(stat.Status.ToLower().Equals("seeding"))
						m_Seeding.AddTextItem(new TextItem(stat.Info,stat));
					else if(stat.Status.ToLower().Equals("downloading"))
						m_Downloading.AddTextItem(new TextItem(stat.Info,stat));
					else
						m_Other.AddTextItem(new TextItem(stat.Info,stat));
				}
			}
		}

		private string GetLogContent(String file)
		{
			string tmp="";
			string line="";
			string content="";
			try
			{
				TextReader tr=new StreamReader(file);
			
				while((line=tr.ReadLine())!=null)
				{
					tmp+=line+"\n";
					if(line.Equals(""))
					{
						content=tmp;
						tmp="";
					}
				}
				if(!tmp.Trim().Equals(""))
					content=tmp;
				tr.Close();
			}
			catch(IOException io)
			{
				Console.WriteLine("IO Error: "+io.Message);
			}
			return(content);
		}

		private void UpdateData()
		{
			m_Downloading.RemoveTextItems();
			m_Seeding.RemoveTextItems();
			m_Other.RemoveTextItems();
			ParseTorrentLog("z:\\.bittorrent\\torrent.log");
		}

		private void tmrUpdate_Tick(object sender, System.EventArgs e)
		{
			UpdateData();
		}

		private void LayoutPanels()
		{
			m_Downloading.Left=m_Seeding.Left=m_Other.Left=0;
			m_Downloading.Top=0;
			m_Seeding.Top=m_Downloading.Top+m_Downloading.Height+5;
			m_Other.Top=m_Seeding.Top+m_Seeding.Height+5;
		}

		private void mnuPopupRefresh_Click(object sender, System.EventArgs e)
		{
			UpdateData();
		}

		private void mnuPopupPause_Click(object sender, System.EventArgs e)
		{
			if(currentStat!=null)
			{
				FileInfo fi=new FileInfo(currentStat.WindowsFilename);
				fi.MoveTo(fi.FullName+".pause");
			}
		}

		private MenuItem CreateResumeMenu()
		{
			MenuItem menuResume=new MenuItem("Resume");
			string[] files=Directory.GetFiles(FILM_FOLDER,"*.pause");
			foreach(String file in files)
			{
				FileInfo fi=new FileInfo(file);
				menuResume.MenuItems.Add(new FileMenuItem(fi.Name.Substring(0,fi.Name.IndexOf(".torrent")),fi,new EventHandler(this.mnuResume_Click)));
			}
			files=Directory.GetFiles(TV_FOLDER,"*.pause");
			foreach(String file in files)
			{
				FileInfo fi=new FileInfo(file);
				menuResume.MenuItems.Add(new FileMenuItem(fi.Name.Substring(0,fi.Name.IndexOf(".torrent")),fi,new EventHandler(this.mnuResume_Click)));
			}
			return(menuResume);
		}

		private void mnuResume_Click(object sender, System.EventArgs e)
		{
			if(sender is FileMenuItem)
			{
				FileMenuItem fmi=(FileMenuItem)sender;
				fmi.File.MoveTo(fmi.File.FullName.Substring(0,fmi.File.FullName.IndexOf(".pause")));
			}
		}

		public void TextClicked(object sender, TextClickedEventArgs e)
		{
			if((e.TextItem!=null)&&(e.MouseButton==MouseButtons.Right))
			{
				Point p=new Point(MousePosition.X,MousePosition.Y);
				currentStat=(Stat)e.TextItem.Tag;
				ContextMenu cm=new ContextMenu();
				cm.MenuItems.Add(mnuPopupPause);
				cm.MenuItems.Add(mnuPopupFinish);
				cm.MenuItems.Add(new MenuItem("-"));
				cm.MenuItems.Add(CreateResumeMenu());
				if(cm.MenuItems[cm.MenuItems.Count-1].MenuItems.Count==0)
					cm.MenuItems[cm.MenuItems.Count-1].Enabled=false;
				cm.MenuItems.Add(new MenuItem("-"));
				cm.MenuItems.Add(mnuPopupRefresh);
				cm.MenuItems.Add(mnuPopupAbout);
				cm.MenuItems.Add(new MenuItem("-"));
				cm.MenuItems.Add(mnuExit);
				cm.Show(this,MousePosition);
			}
			else if(e.MouseButton==MouseButtons.Right)
			{
				Console.WriteLine("TextClicked: "+sender);
				currentStat=null;
				ContextMenu cm=new ContextMenu();
				cm.MenuItems.Add(CreateResumeMenu());
				if(cm.MenuItems[cm.MenuItems.Count-1].MenuItems.Count==0)
					cm.MenuItems[cm.MenuItems.Count-1].Enabled=false;
				cm.MenuItems.Add(new MenuItem("-"));
				cm.MenuItems.Add(mnuPopupRefresh);
				cm.MenuItems.Add(mnuPopupAbout);
				cm.MenuItems.Add(new MenuItem("-"));
				cm.MenuItems.Add(mnuExit);
				cm.Show(this,MousePosition);
			}
		}

		public void LayoutChanged(object sender)
		{
			LayoutPanels();
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void mnuPopupAbout_Click(object sender, System.EventArgs e)
		{
			About a=new About();
			a.ShowDialog(this);
		}

		private void mnuPopupFinish_Click(object sender, System.EventArgs e)
		{
			if(currentStat!=null)
			{
				DirectoryInfo di=new DirectoryInfo(currentStat.WindowsDirectory);
				if(MessageBox.Show("Are you sure you want to delete '"+currentStat.Name+"' and move the data to '"+di.Parent.Parent.FullName+"'?","Confirm Torrent Finish",MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					File.Delete(currentStat.WindowsFilename);
					di.MoveTo(di.Parent.Parent.FullName+"\\"+currentStat.DirectoryName);
				}
			}
		}
	}
}
