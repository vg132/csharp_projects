using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using IIC.Plugin;
using IIC.Alert;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace IIC
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class IIC : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.TreeView trvNav;
		private System.Windows.Forms.Panel pnlMain;
		private System.ComponentModel.IContainer components;
		private MenuItem menuSep=new MenuItem("-");
		private MenuItem menuAboutPlugin=null;
		private frmAboutPlugin aboutPlugin=new frmAboutPlugin();
		private System.Windows.Forms.StatusBar stbPluginInformation;
		private System.Windows.Forms.StatusBarPanel stbPanelName;
		private System.Windows.Forms.StatusBarPanel stbPanelInformation;
		private Host host=null;

		/// <summary>
		/// Default constructor, loades all plugins when called.
		/// </summary>
		public IIC()
		{
			InitializeComponent();
			host=new Host(this);
			host.ApplicationDirectory=Application.ExecutablePath.Substring(0,Application.ExecutablePath.LastIndexOf("\\"));
			menuAboutPlugin=new MenuItem("About",new EventHandler(menuAboutPlugin_Click));
			LoadPlugins();
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.stbPluginInformation = new System.Windows.Forms.StatusBar();
			this.stbPanelName = new System.Windows.Forms.StatusBarPanel();
			this.stbPanelInformation = new System.Windows.Forms.StatusBarPanel();
			this.trvNav = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnlMain = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.stbPanelName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stbPanelInformation)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuFile});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																						 this.menuFileExit});
			this.menuFile.Text = "File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// stbPluginInformation
			// 
			this.stbPluginInformation.Location = new System.Drawing.Point(0, 359);
			this.stbPluginInformation.Name = "stbPluginInformation";
			this.stbPluginInformation.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																																														this.stbPanelName,
																																														this.stbPanelInformation});
			this.stbPluginInformation.ShowPanels = true;
			this.stbPluginInformation.Size = new System.Drawing.Size(568, 22);
			this.stbPluginInformation.TabIndex = 1;
			// 
			// stbPanelName
			// 
			this.stbPanelName.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.stbPanelName.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.stbPanelName.Width = 10;
			// 
			// stbPanelInformation
			// 
			this.stbPanelInformation.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.stbPanelInformation.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.stbPanelInformation.Width = 542;
			// 
			// trvNav
			// 
			this.trvNav.Dock = System.Windows.Forms.DockStyle.Left;
			this.trvNav.HideSelection = false;
			this.trvNav.ImageIndex = -1;
			this.trvNav.Location = new System.Drawing.Point(0, 0);
			this.trvNav.Name = "trvNav";
			this.trvNav.SelectedImageIndex = -1;
			this.trvNav.Size = new System.Drawing.Size(121, 359);
			this.trvNav.TabIndex = 2;
			this.trvNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trvNav_MouseUp);
			this.trvNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvNav_AfterSelect);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(121, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(5, 359);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// pnlMain
			// 
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(126, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(442, 359);
			this.pnlMain.TabIndex = 7;
			// 
			// IIC
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(568, 381);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.trvNav);
			this.Controls.Add(this.stbPluginInformation);
			this.Menu = this.mainMenu1;
			this.Name = "IIC";
			this.Text = "Internet Information Center";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.IIC_Closing);
			((System.ComponentModel.ISupportInitialize)(this.stbPanelName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stbPanelInformation)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new IIC());
		}
		
		private void LoadPlugins()
		{
			Global.Plugins.FindPlugins(host,host.PluginDirectory);
			foreach(AvailablePlugin plugin in Global.Plugins.AvailablePlugins)
			{
				TreeInfoNode tin=new TreeInfoNode(plugin.Instance,plugin.Instance.PluginName);
				trvNav.Nodes.Add(tin);
				plugin.Instance.TreeRoot=tin;
				plugin.Instance.LoadPlugin();
			}
		}

		private void trvNav_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			TreeNode root=e.Node;
			while(root.Parent!=null)
				root=root.Parent;
			host.ActivePlugin=((TreeInfoNode)root).Plugin;
			host.ActivePlugin.TreeNodeSelected(e.Node);
		}

		private void trvNav_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Right)
			{
				TreeNode root=trvNav.SelectedNode;

				ContextMenu pluginMenu=new ContextMenu();
				pluginMenu.MergeMenu(host.ActivePlugin.TreeNodeMouseUp(trvNav.SelectedNode));
				pluginMenu.MenuItems.Add(menuSep);
				menuAboutPlugin.Text="About "+host.ActivePlugin.PluginName+"...";
				pluginMenu.MenuItems.Add(menuAboutPlugin);
				pluginMenu.Show(trvNav,new Point(e.X,e.Y));
			}
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			foreach(AvailablePlugin plugin in Global.Plugins.AvailablePlugins)
				plugin.Instance.UnloadPlugin();
			Application.Exit();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="form"></param>
		public void SetForm(UserControl form)
		{
			if(!pnlMain.Controls.Contains(form))
			{
				pnlMain.Controls.Clear();
				pnlMain.Controls.Add(form);
			}
		}

		private void menuAboutPlugin_Click(object sender, System.EventArgs e)
		{
			aboutPlugin.SetPlugin(host.ActivePlugin);
			aboutPlugin.ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="information"></param>
		public void setStatusInformation(string information)
		{
			stbPanelInformation.Text=information;
		}

		private void IIC_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			menuFileExit_Click(sender,e);
		}
	}
}