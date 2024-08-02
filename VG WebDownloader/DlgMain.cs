using Microsoft.Win32;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using AxSHDocVw;
using System.IO;
using System.Net;
using System.Net.Sockets;
using mshtml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace VGSoftware.PageSaver
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class DlgMain : System.Windows.Forms.Form
	{
		#region Global Declarations

		private System.Windows.Forms.Panel panToolBar;
		private System.Windows.Forms.Panel panMain;
		private System.Windows.Forms.Panel panInfo;
		private System.Windows.Forms.Panel panRight;
		private System.Windows.Forms.Panel panProjectInfo;
		private System.Windows.Forms.Panel panBrowser;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private AxSHDocVw.AxWebBrowser axIE;
		private System.Windows.Forms.Panel panStatus;
		private System.Windows.Forms.Panel panBrowser2;
		private System.Windows.Forms.StatusBar stbBrowser;
		private System.Windows.Forms.TreeView trvItems;
		private System.Windows.Forms.ImageList imlTree;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.TreeNode RootNode;
		private System.Windows.Forms.TreeNode LinkNode;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TreeNode ImageNode;
		private System.Windows.Forms.MainMenu mnuMainMenu;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuFileNewProject;
		private System.Windows.Forms.MenuItem mnuFileSep1;
		private System.Windows.Forms.MenuItem mnuFileSaveProject;
		private System.Windows.Forms.MenuItem mnuFileOpenProject;
		private System.Windows.Forms.MenuItem mnuFileSep2;
		private Project m_CurrentProject;
		private string m_CurrentProjectFileName;
		private System.Windows.Forms.MenuItem mnuProject;
		private System.Windows.Forms.MenuItem mnuProjectOptions;
		private Thread m_Thread;
		private System.Windows.Forms.MenuItem mnuProjectSetDownDir;
		private System.Windows.Forms.MenuItem mnuProjectSep1;
		private DlgProject m_DlgProject=new DlgProject();
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnuFileSaveProjectAs;
		private System.Windows.Forms.ToolBar tlbMain;
		private System.Windows.Forms.ToolBarButton tlbButtonSave;
		private System.Windows.Forms.Button btnGO;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.ImageList imlToolbar;
		private System.Windows.Forms.MenuItem mnuFavorites;
		private string m_DownloadDirectory="";
		private System.Windows.Forms.ToolBarButton tlbSep1;
		private System.Windows.Forms.ToolBarButton tlbButtonMultiSave;
		private string m_Favorites="";
		private bool m_MultiSave;

		#endregion //Global Declarations

		#region Constructor
		///<summary>
		///Default empty constructor
		///</summary>
		public DlgMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			
			RegistryKey Key=Registry.CurrentUser.OpenSubKey("Software\\VG Software\\Downloader",true);
			if(Key==null)
				Key=Registry.CurrentUser.CreateSubKey("Software\\VG Software\\Downloader");
			m_DownloadDirectory=(string)Key.GetValue("Download Directory");
			if(m_DownloadDirectory==null)
			{
				VGSoftware.Win32.FolderBrowser fb=new VGSoftware.Win32.FolderBrowser();
				fb.Description="Select download directory";
				while(DialogResult.OK!=fb.ShowDialog());
				m_DownloadDirectory=fb.DirectoryPath;
				Key.SetValue("Download Directory",m_DownloadDirectory);
			}

			Key=Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders");
			if(Key!=null)
				m_Favorites=(string)Key.GetValue("Favorites");

			imlTree.Images.Add(Bitmap.FromFile("icons\\close.bmp"));
			imlTree.Images.Add(Bitmap.FromFile("icons\\open.bmp"));
			imlTree.Images.Add(Bitmap.FromFile("icons\\link.bmp"));
			trvItems.ImageList=imlTree;
			trvItems.ShowLines=true;
			trvItems.ShowPlusMinus=true;
			trvItems.ShowRootLines=true;
			
			RootNode=new TreeNode();
			RootNode.ImageIndex=0;
			RootNode.SelectedImageIndex=1;
			RootNode.Text="Webpage Content";
			
			LinkNode=new TreeNode();
			LinkNode.ImageIndex=0;
			LinkNode.SelectedImageIndex=1;
			LinkNode.Text="Links";
			RootNode.Nodes.Add(LinkNode);

			ImageNode=new TreeNode();
			ImageNode.ImageIndex=0;
			ImageNode.SelectedImageIndex=1;
			ImageNode.Text="Images";

			RootNode.Nodes.Add(ImageNode);
			trvItems.Nodes.Add(RootNode);
			trvItems.ExpandAll();
			mnuProjectOptions.Enabled=false;
			mnuFileSaveProject.Enabled=false;
			mnuFileSaveProjectAs.Enabled=false;
			tlbMain.Buttons[0].Enabled=false;
			m_CurrentProjectFileName="";
			BuildFavoritesMenu(mnuFavorites);
			m_MultiSave=false;
		}
		#endregion //Constructor

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DlgMain));
			this.panToolBar = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tlbMain = new System.Windows.Forms.ToolBar();
			this.tlbButtonSave = new System.Windows.Forms.ToolBarButton();
			this.imlToolbar = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGO = new System.Windows.Forms.Button();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.panMain = new System.Windows.Forms.Panel();
			this.panRight = new System.Windows.Forms.Panel();
			this.panBrowser = new System.Windows.Forms.Panel();
			this.panStatus = new System.Windows.Forms.Panel();
			this.stbBrowser = new System.Windows.Forms.StatusBar();
			this.panBrowser2 = new System.Windows.Forms.Panel();
			this.axIE = new AxSHDocVw.AxWebBrowser();
			this.panProjectInfo = new System.Windows.Forms.Panel();
			this.panInfo = new System.Windows.Forms.Panel();
			this.trvItems = new System.Windows.Forms.TreeView();
			this.mnuMainMenu = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuFileNewProject = new System.Windows.Forms.MenuItem();
			this.mnuFileOpenProject = new System.Windows.Forms.MenuItem();
			this.mnuFileSep2 = new System.Windows.Forms.MenuItem();
			this.mnuFileSaveProject = new System.Windows.Forms.MenuItem();
			this.mnuFileSaveProjectAs = new System.Windows.Forms.MenuItem();
			this.mnuFileSep1 = new System.Windows.Forms.MenuItem();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.mnuProject = new System.Windows.Forms.MenuItem();
			this.mnuProjectSetDownDir = new System.Windows.Forms.MenuItem();
			this.mnuProjectSep1 = new System.Windows.Forms.MenuItem();
			this.mnuProjectOptions = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.imlTree = new System.Windows.Forms.ImageList(this.components);
			this.mnuFavorites = new System.Windows.Forms.MenuItem();
			this.tlbSep1 = new System.Windows.Forms.ToolBarButton();
			this.tlbButtonMultiSave = new System.Windows.Forms.ToolBarButton();
			this.panToolBar.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panMain.SuspendLayout();
			this.panRight.SuspendLayout();
			this.panBrowser.SuspendLayout();
			this.panStatus.SuspendLayout();
			this.panBrowser2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axIE)).BeginInit();
			this.panInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// panToolBar
			// 
			this.panToolBar.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						 this.panel2,
																																						 this.panel1});
			this.panToolBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panToolBar.Name = "panToolBar";
			this.panToolBar.Size = new System.Drawing.Size(544, 32);
			this.panToolBar.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.tlbMain});
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(240, 32);
			this.panel2.TabIndex = 1;
			// 
			// tlbMain
			// 
			this.tlbMain.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tlbMain.AutoSize = false;
			this.tlbMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																																							 this.tlbButtonSave,
																																							 this.tlbSep1,
																																							 this.tlbButtonMultiSave});
			this.tlbMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlbMain.DropDownArrows = true;
			this.tlbMain.ImageList = this.imlToolbar;
			this.tlbMain.Name = "tlbMain";
			this.tlbMain.ShowToolTips = true;
			this.tlbMain.Size = new System.Drawing.Size(240, 25);
			this.tlbMain.TabIndex = 1;
			this.tlbMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tlbMain_ButtonClick);
			// 
			// tlbButtonSave
			// 
			this.tlbButtonSave.ImageIndex = 0;
			// 
			// imlToolbar
			// 
			this.imlToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imlToolbar.ImageSize = new System.Drawing.Size(16, 16);
			this.imlToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlToolbar.ImageStream")));
			this.imlToolbar.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel1
			// 
			this.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.btnGO,
																																				 this.txtURL,
																																				 this.lblAddress});
			this.panel1.Location = new System.Drawing.Point(240, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(304, 32);
			this.panel1.TabIndex = 0;
			// 
			// btnGO
			// 
			this.btnGO.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnGO.Location = new System.Drawing.Point(256, 6);
			this.btnGO.Name = "btnGO";
			this.btnGO.Size = new System.Drawing.Size(40, 20);
			this.btnGO.TabIndex = 13;
			this.btnGO.Text = "GO!";
			this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
			// 
			// txtURL
			// 
			this.txtURL.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.txtURL.Location = new System.Drawing.Point(56, 6);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(200, 20);
			this.txtURL.TabIndex = 12;
			this.txtURL.Text = "";
			this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.URL_KeyDown);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(0, 10);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(49, 13);
			this.lblAddress.TabIndex = 11;
			this.lblAddress.Text = "Address:";
			// 
			// panMain
			// 
			this.panMain.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					this.panRight,
																																					this.panInfo});
			this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panMain.Location = new System.Drawing.Point(0, 32);
			this.panMain.Name = "panMain";
			this.panMain.Size = new System.Drawing.Size(544, 334);
			this.panMain.TabIndex = 1;
			// 
			// panRight
			// 
			this.panRight.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					 this.panBrowser,
																																					 this.panProjectInfo});
			this.panRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panRight.Location = new System.Drawing.Point(16, 0);
			this.panRight.Name = "panRight";
			this.panRight.Size = new System.Drawing.Size(528, 334);
			this.panRight.TabIndex = 1;
			// 
			// panBrowser
			// 
			this.panBrowser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panBrowser.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						 this.panStatus,
																																						 this.panBrowser2});
			this.panBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panBrowser.Location = new System.Drawing.Point(0, 152);
			this.panBrowser.Name = "panBrowser";
			this.panBrowser.Size = new System.Drawing.Size(528, 182);
			this.panBrowser.TabIndex = 1;
			// 
			// panStatus
			// 
			this.panStatus.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.stbBrowser});
			this.panStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panStatus.Location = new System.Drawing.Point(0, 154);
			this.panStatus.Name = "panStatus";
			this.panStatus.Size = new System.Drawing.Size(524, 24);
			this.panStatus.TabIndex = 1;
			// 
			// stbBrowser
			// 
			this.stbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stbBrowser.Name = "stbBrowser";
			this.stbBrowser.Size = new System.Drawing.Size(524, 24);
			this.stbBrowser.TabIndex = 0;
			// 
			// panBrowser2
			// 
			this.panBrowser2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panBrowser2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																							this.axIE});
			this.panBrowser2.Name = "panBrowser2";
			this.panBrowser2.Size = new System.Drawing.Size(528, 152);
			this.panBrowser2.TabIndex = 0;
			// 
			// axIE
			// 
			this.axIE.ContainingControl = this;
			this.axIE.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axIE.Enabled = true;
			this.axIE.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIE.OcxState")));
			this.axIE.Size = new System.Drawing.Size(528, 152);
			this.axIE.TabIndex = 3;
			this.axIE.StatusTextChange += new AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler(this.IE_StatusTextChange);
			this.axIE.TitleChange += new AxSHDocVw.DWebBrowserEvents2_TitleChangeEventHandler(this.IE_TitleChange);
			this.axIE.DocumentComplete += new AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler(this.IE_DocumentComplete);
			// 
			// panProjectInfo
			// 
			this.panProjectInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panProjectInfo.Name = "panProjectInfo";
			this.panProjectInfo.Size = new System.Drawing.Size(528, 152);
			this.panProjectInfo.TabIndex = 0;
			// 
			// panInfo
			// 
			this.panInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panInfo.Controls.AddRange(new System.Windows.Forms.Control[] {
																																					this.trvItems});
			this.panInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.panInfo.Name = "panInfo";
			this.panInfo.Size = new System.Drawing.Size(16, 334);
			this.panInfo.TabIndex = 0;
			// 
			// trvItems
			// 
			this.trvItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvItems.ImageIndex = -1;
			this.trvItems.Name = "trvItems";
			this.trvItems.SelectedImageIndex = -1;
			this.trvItems.Size = new System.Drawing.Size(12, 330);
			this.trvItems.TabIndex = 0;
			// 
			// mnuMainMenu
			// 
			this.mnuMainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																								this.mnuFile,
																																								this.mnuProject,
																																								this.mnuFavorites,
																																								this.menuItem1});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																						this.mnuFileNewProject,
																																						this.mnuFileOpenProject,
																																						this.mnuFileSep2,
																																						this.mnuFileSaveProject,
																																						this.mnuFileSaveProjectAs,
																																						this.mnuFileSep1,
																																						this.mnuFileExit});
			this.mnuFile.Text = "&File";
			// 
			// mnuFileNewProject
			// 
			this.mnuFileNewProject.Index = 0;
			this.mnuFileNewProject.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.mnuFileNewProject.Text = "&New Project...";
			this.mnuFileNewProject.Click += new System.EventHandler(this.mnuFileNewProject_Click);
			// 
			// mnuFileOpenProject
			// 
			this.mnuFileOpenProject.Index = 1;
			this.mnuFileOpenProject.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.mnuFileOpenProject.Text = "&Open Project...";
			this.mnuFileOpenProject.Click += new System.EventHandler(this.mnuFileOpenProject_Click);
			// 
			// mnuFileSep2
			// 
			this.mnuFileSep2.Index = 2;
			this.mnuFileSep2.Text = "-";
			// 
			// mnuFileSaveProject
			// 
			this.mnuFileSaveProject.Index = 3;
			this.mnuFileSaveProject.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.mnuFileSaveProject.Text = "&Save Project";
			this.mnuFileSaveProject.Click += new System.EventHandler(this.mnuFileSaveProject_Click);
			// 
			// mnuFileSaveProjectAs
			// 
			this.mnuFileSaveProjectAs.Index = 4;
			this.mnuFileSaveProjectAs.Text = "Save Project &As...";
			this.mnuFileSaveProjectAs.Click += new System.EventHandler(this.mnuFileSaveProjectAs_Click);
			// 
			// mnuFileSep1
			// 
			this.mnuFileSep1.Index = 5;
			this.mnuFileSep1.Text = "-";
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Index = 6;
			this.mnuFileExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.mnuFileExit.Text = "E&xit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuProject
			// 
			this.mnuProject.Index = 1;
			this.mnuProject.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							 this.mnuProjectSetDownDir,
																																							 this.mnuProjectSep1,
																																							 this.mnuProjectOptions});
			this.mnuProject.Text = "&Project";
			// 
			// mnuProjectSetDownDir
			// 
			this.mnuProjectSetDownDir.Index = 0;
			this.mnuProjectSetDownDir.Text = "Set Download Directory...";
			this.mnuProjectSetDownDir.Click += new System.EventHandler(this.mnuProjectSetDownDir_Click);
			// 
			// mnuProjectSep1
			// 
			this.mnuProjectSep1.Index = 1;
			this.mnuProjectSep1.Text = "-";
			// 
			// mnuProjectOptions
			// 
			this.mnuProjectOptions.Index = 2;
			this.mnuProjectOptions.Text = "Options";
			this.mnuProjectOptions.Click += new System.EventHandler(this.mnuProjectOptions_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 3;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem2});
			this.menuItem1.Text = "&Help";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "About...";
			// 
			// imlTree
			// 
			this.imlTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imlTree.ImageSize = new System.Drawing.Size(16, 16);
			this.imlTree.TransparentColor = System.Drawing.Color.Silver;
			// 
			// mnuFavorites
			// 
			this.mnuFavorites.Index = 2;
			this.mnuFavorites.Text = "F&avorites";
			// 
			// tlbSep1
			// 
			this.tlbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tlbButtonMultiSave
			// 
			this.tlbButtonMultiSave.ImageIndex = 1;
			// 
			// DlgMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 366);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.panMain,
																																	this.panToolBar});
			this.Menu = this.mnuMainMenu;
			this.Name = "DlgMain";
			this.Text = "Page Saver - VG Software";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DlgMain_Load);
			this.panToolBar.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panMain.ResumeLayout(false);
			this.panRight.ResumeLayout(false);
			this.panBrowser.ResumeLayout(false);
			this.panStatus.ResumeLayout(false);
			this.panBrowser2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axIE)).EndInit();
			this.panInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Main

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new DlgMain());
		}

		#endregion //Main

		#region Controls

		private void DlgMain_Load(object sender, System.EventArgs e)
		{
			mnuFileNewProject_Click(sender,e);
		}

		private void btnGO_Click(object sender, System.EventArgs e)
		{
			object o=null;
			axIE.Navigate(txtURL.Text,ref o,ref o, ref o, ref o);
		}

		private void URL_KeyDown(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar==(Char)13)
			{
				object o=null;
				axIE.Navigate(txtURL.Text,ref o, ref o, ref o, ref o);
			}
		}

		private void tlbMain_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button.Equals(tlbButtonSave))
			{
				SavePage();
			}
			else if(e.Button.Equals(tlbButtonMultiSave))
			{
				if(m_MultiSave)
				{
					tlbButtonMultiSave.ImageIndex = 1;
					tlbButtonMultiSave.ToolTipText="Start Multi Save";
				}
				else
				{
					tlbButtonMultiSave.ImageIndex = 2;
					tlbButtonMultiSave.ToolTipText="Stop Multi Save";
				}
				m_MultiSave=!m_MultiSave;
			}
		}
		
		#endregion //Controls
		
		#region Browser Functions

		private void IE_TitleChange(object sender, DWebBrowserEvents2_TitleChangeEvent e)
		{
			this.Text="VG Software Page Saver - " + e.text;
		}

		private void IE_StatusTextChange(object sender, DWebBrowserEvents2_StatusTextChangeEvent e)
		{
			stbBrowser.Text=e.text;
		}

		private void IE_DocumentComplete(object sender, DWebBrowserEvents2_DocumentCompleteEvent e)
		{
			txtURL.Text=(string)e.uRL;
			if(m_MultiSave)
				SavePage();
		}
		#endregion	//Browser Functions

		#region Menu Control Functions

		private void mnuProjectSetDownDir_Click(object sender, System.EventArgs e)
		{
			VGSoftware.Win32.FolderBrowser fb=new VGSoftware.Win32.FolderBrowser();
			fb.Description="Select download directory";
			if(DialogResult.OK==fb.ShowDialog())
			{
				RegistryKey key=Registry.CurrentUser.OpenSubKey("Software\\VG Software\\Downloader",true);
				if(key==null)
					key=Registry.CurrentUser.CreateSubKey("Software\\VG Software\\Downloader");
				m_DownloadDirectory=fb.DirectoryPath;
				key.SetValue("Download Directory",m_DownloadDirectory);
			}
		}

		private void mnuProjectOptions_Click(object sender, System.EventArgs e)
		{
			m_DlgProject.SetProjectFile(ref m_CurrentProject);
			m_DlgProject.UpdateControls();
			m_DlgProject.ShowDialog(this);
		}

		private void mnuFileNewProject_Click(object sender, System.EventArgs e)
		{
			if(m_CurrentProject!=null)
			{
				DialogResult RetVal=MessageBox.Show(this,"Save current project?","Save Project",MessageBoxButtons.YesNoCancel);
				if(RetVal==DialogResult.Yes)
					mnuFileSaveProject_Click(sender,e);
				else if(RetVal==DialogResult.Cancel)
					return;
			}
			Project TmpProject=new Project();
			TmpProject=new Project();
			TmpProject.Folder=m_DownloadDirectory;
			m_DlgProject.SetProjectFile(ref TmpProject);
			m_DlgProject.UpdateControls();
			if(m_DlgProject.ShowDialog(this)==DialogResult.OK)
			{
				m_CurrentProject=TmpProject;
				mnuFileSaveProject.Enabled=true;
				mnuFileSaveProjectAs.Enabled=true;
				mnuProjectOptions.Enabled=true;
				tlbMain.Buttons[0].Enabled=true;
			}
		}

		private void mnuFileSaveProject_Click(object sender, System.EventArgs e)
		{
			if(m_CurrentProjectFileName.Equals(""))
			{
				mnuFileSaveProjectAs_Click(sender,e);
			}
			else
			{
				FileInfo f=new FileInfo(m_CurrentProjectFileName);
				Stream s=f.Open(FileMode.Create);
				BinaryFormatter b=new BinaryFormatter();
				b.Serialize(s,m_CurrentProject);
				s.Close();
			}
		}

		private void mnuFileSaveProjectAs_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd=new SaveFileDialog();
			sfd.Filter = "Downloader project files (*.vpr)|*.vpr|All files (*.*)|*.*";  
			if(sfd.ShowDialog()==DialogResult.OK)
			{
				FileInfo f=new FileInfo(sfd.FileName);
				Stream s=f.Open(FileMode.Create);
				BinaryFormatter b=new BinaryFormatter();
				b.Serialize(s,m_CurrentProject);
				s.Close();
				m_CurrentProjectFileName=sfd.FileName;
			}
		}

		private void mnuFileOpenProject_Click(object sender, System.EventArgs e)
		{
			if(m_CurrentProject!=null)
			{
				DialogResult RetVal=MessageBox.Show(this,"Save current project?","Save Project",MessageBoxButtons.YesNoCancel);
				if(RetVal==DialogResult.Yes)
					mnuFileSaveProject_Click(sender,e);
				else if(RetVal==DialogResult.Cancel)
					return;
			}
			OpenFileDialog ofd=new OpenFileDialog();
			if(ofd.ShowDialog()==DialogResult.OK)
			{
				m_CurrentProject = new Project();
				FileInfo f=new FileInfo(ofd.FileName);
				Stream s=f.Open(FileMode.Open);
				BinaryFormatter b=new BinaryFormatter();
				m_CurrentProject=(Project)b.Deserialize(s);
				s.Close();
				mnuFileSaveProject.Enabled=true;
				mnuFileSaveProjectAs.Enabled=true;
				mnuProjectOptions.Enabled=true;
				tlbMain.Buttons[0].Enabled=true;
				m_CurrentProjectFileName=ofd.FileName;
			}
		}
		
		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		#region Other Functions

		private void SavePage()
		{
			m_Thread=new Thread(new ThreadStart(this.StartDownload));
			m_Thread.Start();
		}

		private void StartDownload()
		{
			Uri uri=new Uri(txtURL.Text);
			Download d=new Download(ref m_CurrentProject,uri);
			d.Run();
		}

		private void BuildFavoritesMenu(MenuItem Parent)
		{
			BuildMenu(Parent,new DirectoryInfo(m_Favorites));
		}

		private void BuildMenu(MenuItem Parent, DirectoryInfo di)
		{
			
			MenuItem mi;
			DirectoryInfo[] Dirs=di.GetDirectories();
			for(int i=0;i<Dirs.Length;i++)
			{
				mi=new MenuItem(Dirs[i].Name);
				Parent.MenuItems.Add(mi);
				BuildMenu(mi,Dirs[i]);
			}
			FileInfo[] Files=di.GetFiles("*.url");
			for(int ii=0;ii<Files.Length;ii++)
			{
				mi=new MenuItem(Files[ii].Name.Substring(0,Files[ii].Name.LastIndexOf(".")));
				mi.Click +=new System.EventHandler(this.mnuFavoriteItem_Click);
				Parent.MenuItems.Add(mi);
			}
		}

		private void mnuFavoriteItem_Click(object sender, EventArgs e)
		{
			string Path="";
			MenuItem mi=(MenuItem)sender;
			Path=mi.Text+".url";
			while(mi.Parent!=mnuFavorites)
			{
				mi=(MenuItem)mi.Parent;
				Path=mi.Text+"\\"+Path;
			};
			Path=m_Favorites+"\\"+Path;
			if(new FileInfo(Path).Exists)
			{
				VGSoftware.Win32.IniFile ini=new VGSoftware.Win32.IniFile(Path);
				txtURL.Text=ini.IniReadValue("InternetShortcut","URL");
				btnGO_Click(sender,e);
			}
		}

		#endregion Other Functions
	}
}