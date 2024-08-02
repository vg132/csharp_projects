using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;
using mshtml;
using AxSHDocVw;
using System.Threading;

namespace XFriendsApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private AxSHDocVw.AxWebBrowser axIE;
		private int state=0;
		private Thread UpdateThread=null;
		private Hashtable Friends=new Hashtable();
		private Settings settings=new Settings();

		private System.Windows.Forms.Label lblOnline;
		private System.Windows.Forms.Label lblOffline;
		private System.Windows.Forms.ListBox lstOnline;
		private System.Windows.Forms.ListBox lstOffline;
		private System.Windows.Forms.MainMenu menuMain;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuFileOptions;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		// PlaySound()
		[DllImport( "winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
		static extern bool PlaySound( string pszSound, IntPtr hMod, SoundFlags sf );
		// Flags for playing sounds.  For this example, we are reading 
		// the sound from a filename, so we need only specify 
		// SND_FILENAME | SND_ASYNC
		[Flags]
			public enum SoundFlags : int 
		{
			SND_SYNC = 0x0000,         // play synchronously (default) 
			SND_ASYNC = 0x0001,        // play asynchronously 
			SND_NODEFAULT = 0x0002,    // silence (!default) if sound not found 
			SND_MEMORY = 0x0004,       // pszSound points to a memory file
			SND_LOOP = 0x0008,         // loop the sound until next sndPlaySound 
			SND_NOSTOP = 0x0010,       // don't stop any currently playing sound 
			SND_NOWAIT = 0x00002000,   // don't wait if the driver is busy 
			SND_ALIAS = 0x00010000,    // name is a registry alias 
			SND_ALIAS_ID = 0x00110000, // alias is a predefined ID
			SND_FILENAME = 0x00020000, // name is file name 
			SND_RESOURCE = 0x00040004  // name is resource name or atom 
		}


		public frmMain()
		{
			InitializeComponent();
			settings.Load(Application.StartupPath+"\\settings.xml");
			UpdateThread=new Thread(new ThreadStart(this.UpdateList));
			UpdateThread.Start();
		}

		private void UpdateList()
		{
			try
			{
				while(true)
				{
					state=0;
					NavigateTo(settings.MainPage);
					Thread.Sleep(int.Parse(settings.UpdateFrequency));
				}
			}
			catch(ThreadInterruptedException e)
			{
				Console.WriteLine(e.StackTrace);
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			UpdateThread.Interrupt();
			if(disposing)
			{
				if(components!=null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.axIE = new AxSHDocVw.AxWebBrowser();
			this.lblOnline = new System.Windows.Forms.Label();
			this.lblOffline = new System.Windows.Forms.Label();
			this.lstOnline = new System.Windows.Forms.ListBox();
			this.lstOffline = new System.Windows.Forms.ListBox();
			this.menuMain = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuFileOptions = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.axIE)).BeginInit();
			this.SuspendLayout();
			// 
			// axIE
			// 
			this.axIE.Enabled = true;
			this.axIE.Location = new System.Drawing.Point(432, 216);
			this.axIE.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIE.OcxState")));
			this.axIE.Size = new System.Drawing.Size(408, 328);
			this.axIE.TabIndex = 0;
			this.axIE.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.IE_DocumentComplete);
			// 
			// lblOnline
			// 
			this.lblOnline.Location = new System.Drawing.Point(8, 2);
			this.lblOnline.Name = "lblOnline";
			this.lblOnline.Size = new System.Drawing.Size(100, 16);
			this.lblOnline.TabIndex = 1;
			this.lblOnline.Text = "Online";
			// 
			// lblOffline
			// 
			this.lblOffline.Location = new System.Drawing.Point(8, 218);
			this.lblOffline.Name = "lblOffline";
			this.lblOffline.Size = new System.Drawing.Size(100, 16);
			this.lblOffline.TabIndex = 2;
			this.lblOffline.Text = "Offline";
			// 
			// lstOnline
			// 
			this.lstOnline.Location = new System.Drawing.Point(8, 18);
			this.lstOnline.Name = "lstOnline";
			this.lstOnline.Size = new System.Drawing.Size(180, 199);
			this.lstOnline.TabIndex = 3;
			// 
			// lstOffline
			// 
			this.lstOffline.Location = new System.Drawing.Point(8, 234);
			this.lstOffline.Name = "lstOffline";
			this.lstOffline.Size = new System.Drawing.Size(180, 199);
			this.lstOffline.TabIndex = 3;
			// 
			// menuMain
			// 
			this.menuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																						 this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuFileOptions,
																																							this.menuItem4,
																																							this.menuFileExit});
			this.menuItem1.Text = "File";
			// 
			// menuFileOptions
			// 
			this.menuFileOptions.Index = 0;
			this.menuFileOptions.Text = "Options...";
			this.menuFileOptions.Click += new System.EventHandler(this.menuFileOptions_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 2;
			this.menuFileExit.Text = "Exit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(195, 445);
			this.Controls.Add(this.lstOnline);
			this.Controls.Add(this.lblOffline);
			this.Controls.Add(this.lblOnline);
			this.Controls.Add(this.axIE);
			this.Controls.Add(this.lstOffline);
			this.MaximizeBox = false;
			this.Menu = this.menuMain;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XFriend - Test";
			((System.ComponentModel.ISupportInitialize)(this.axIE)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void NavigateTo(string url)
		{
			object o=null;
			axIE.Navigate(url,ref o,ref o, ref o, ref o);
		}

		private void ExtractData()
		{
			HTMLDocument doc=(HTMLDocument)axIE.Document;
			IHTMLElementCollection tables=doc.getElementsByTagName("table");

			System.Collections.IEnumerator ice = tables.GetEnumerator();
			ice.MoveNext();

			lstOffline.Items.Clear();
			lstOnline.Items.Clear();

			while(ice.MoveNext())
			{
				HTMLTable myTable=(HTMLTable)ice.Current;
				System.Collections.IEnumerator ee = myTable.rows.GetEnumerator();
				while(ee.MoveNext())
				{
					HTMLTableRow row = (HTMLTableRow) ee.Current;
					IHTMLElementCollection cells = row.cells;
					System.Collections.IEnumerator ee2 = cells.GetEnumerator();
					//Move to empty cell
					ee2.MoveNext();
					//Move to cell with information
					while(ee2.MoveNext())
					{
						IHTMLTableCell aCell=(IHTMLTableCell)ee2.Current;
						IHTMLElement el=(IHTMLElement)aCell;
					
						string str=el.innerHTML;
						int startTag=str.ToLower().IndexOf("<b>")+3;
						int endTag=str.ToLower().IndexOf("</b>");
						string user=str.Substring(startTag,endTag-startTag).Trim();
						string status=str.Substring(endTag+4).Trim();
						Friend friend=(Friend)Friends[user];
						if(friend==null)
						{
							friend=new Friend(user);
							Friends.Add(friend.Name,friend);
						}

						if(status.ToLower().Equals(settings.OfflineSuffix))
						{
							lstOffline.Items.Add(user);
							friend.CurrentGame=null;
							if(friend.Online==true)
								PlaySound(settings.OfflineSound,IntPtr.Zero,SoundFlags.SND_FILENAME|SoundFlags.SND_ASYNC);
							friend.Online=false;
						}
						else
						{
							status=status.Substring(settings.OnlineSuffix.Length).Trim();
							lstOnline.Items.Add(user+" - "+status);
							friend.CurrentGame=status;
							if(friend.Online==false)
								PlaySound(settings.OnlineSound,IntPtr.Zero,SoundFlags.SND_FILENAME|SoundFlags.SND_ASYNC);
							friend.Online=true;
						}
					}
				}
			}
		}

		private void IE_DocumentComplete(object sender, DWebBrowserEvents2_DocumentCompleteEvent e)
		{
			if((axIE.LocationURL.Equals(settings.LoginErrorPage))&&(state!=-1))
			{
				if(MessageBox.Show(this,"Unable to login to www.xbox.com.\nPlease visit http://www.xbox.com/ and make sure\nthat you have selected automatic login on the login page.","Unable to Login",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error)==DialogResult.Retry)
				{
					state=0;
					NavigateTo(settings.MainPage);
				}
				else
				{
					state=-1;
				}
				return;
			}
			switch(state)
			{
				case 0:
					IHTMLDocument2 doc=(IHTMLDocument2)axIE.Document;
					foreach(IHTMLElement link in doc.links)
					{
						if(link.outerHTML.IndexOf(settings.PassportLink,0,link.outerHTML.Length)!=-1)
						{
							if(link.outerHTML.IndexOf(settings.LoginLinkPrefix,0,link.outerHTML.Length)!=-1)
							{
								link.click();
								break;
							}
							else
							{
								state=2;
								NavigateTo(settings.FriendsPage);
								break;
							}
						}
					}
					break;
				case 1:
					state=2;
					NavigateTo(settings.FriendsPage);
					break;
				case 2:
					ExtractData();
					break;
			}
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			UpdateThread.Interrupt();
			Application.Exit();
		}

		private void menuFileOptions_Click(object sender, System.EventArgs e)
		{
			frmOptions frm=new frmOptions(settings);
			if(frm.ShowDialog()==DialogResult.OK)
				settings.Save(Application.StartupPath+"\\settings.xml");
		}
	}
}
