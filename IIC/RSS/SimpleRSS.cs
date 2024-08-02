using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using IIC.Plugin;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Diagnostics;
using System.Threading;

namespace RSS
{
	public delegate void DelegateShowAlert(object id, string message);

	/// <summary>
	/// Summary description for RSS.
	/// </summary>
	public class RSS : System.Windows.Forms.UserControl, IPlugin
	{
		private static string AUTHOR="Viktor Gars";
		private static string DESCRIPTION="Simple RSS reading plugin for Internet Information Center";
		private static string PLUGIN_NAME="Simple RSS";
		private static string VERSION="1.0";

		private TreeNode treeRoot=null;
		private IPluginHost host=null;

		private ContextMenu contextMenu=new ContextMenu();
		private MenuItem addFeed=null;
		private MenuItem removeFeed=null;
		private MenuItem feedProperties=null;
		private ArrayList feeds=new ArrayList();
		private RSSParser rssParser=new RSSParser();
		private Feed currentFeed=null;
		private Thread updateThread=null;
		private bool updateRunning=true;
		private int updateInterval=60000;
		private DelegateShowAlert m_DelegateShowAlert;

		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ListView lstList;
		private System.Windows.Forms.ColumnHeader cohHeadline;
		private System.Windows.Forms.ColumnHeader cohDate;
		private System.Windows.Forms.LinkLabel llbLink;
		private System.Windows.Forms.TextBox txtDesc;

		private System.ComponentModel.Container components = null;

		public RSS()
		{
			InitializeComponent();
			this.Dock=DockStyle.Fill;

			addFeed=new MenuItem("Add...",new EventHandler(this.AddFeed_Event));
			removeFeed=new MenuItem("Remove...",new EventHandler(this.RemoveFeed_Event));
			feedProperties=new MenuItem("Properties...",new EventHandler(this.FeedProperties_Event));
			
			contextMenu.MenuItems.Add(addFeed);
			contextMenu.MenuItems.Add(removeFeed);
			contextMenu.MenuItems.Add(feedProperties);
			updateThread=new Thread(new ThreadStart(this.UpdateFeeds));
			m_DelegateShowAlert=new DelegateShowAlert(this.ShowAlert);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstList = new System.Windows.Forms.ListView();
			this.cohHeadline = new System.Windows.Forms.ColumnHeader();
			this.cohDate = new System.Windows.Forms.ColumnHeader();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.llbLink = new System.Windows.Forms.LinkLabel();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lstList
			// 
			this.lstList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																																							this.cohHeadline,
																																							this.cohDate});
			this.lstList.Dock = System.Windows.Forms.DockStyle.Top;
			this.lstList.FullRowSelect = true;
			this.lstList.Location = new System.Drawing.Point(0, 0);
			this.lstList.MultiSelect = false;
			this.lstList.Name = "lstList";
			this.lstList.Size = new System.Drawing.Size(472, 97);
			this.lstList.TabIndex = 0;
			this.lstList.View = System.Windows.Forms.View.Details;
			this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
			// 
			// cohHeadline
			// 
			this.cohHeadline.Text = "Headline";
			// 
			// cohDate
			// 
			this.cohDate.Text = "Date";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 97);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(472, 3);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// llbLink
			// 
			this.llbLink.ActiveLinkColor = System.Drawing.Color.Blue;
			this.llbLink.DisabledLinkColor = System.Drawing.Color.Blue;
			this.llbLink.Dock = System.Windows.Forms.DockStyle.Top;
			this.llbLink.Location = new System.Drawing.Point(0, 100);
			this.llbLink.Name = "llbLink";
			this.llbLink.Size = new System.Drawing.Size(472, 16);
			this.llbLink.TabIndex = 2;
			this.llbLink.VisitedLinkColor = System.Drawing.Color.Blue;
			this.llbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLink_LinkClicked);
			// 
			// txtDesc
			// 
			this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDesc.Location = new System.Drawing.Point(0, 116);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new System.Drawing.Size(472, 228);
			this.txtDesc.TabIndex = 3;
			this.txtDesc.Text = "textBox1";
			// 
			// RSS
			// 
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.llbLink);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.lstList);
			this.Name = "RSS";
			this.Size = new System.Drawing.Size(472, 344);
			this.ResumeLayout(false);

		}
		#endregion

		public void LoadPlugin()
		{
			if(File.Exists(host.DataDirectory+"\\"+PluginName+".xml"))
			{
				XmlTextReader reader=new XmlTextReader(host.DataDirectory+"\\"+PluginName+".xml");
				XPathDocument doc=new XPathDocument(reader);
				XPathNavigator nav=doc.CreateNavigator();
				XPathNodeIterator iter=nav.Select("//settings");
				while(iter.MoveNext())
				{
					XPathNavigator nav2=iter.Current.Clone();
					nav2.MoveToFirstAttribute();
					lstList.Columns[0].Width=Int32.Parse(nav2.Value);
					nav2.MoveToNextAttribute();
					lstList.Columns[1].Width=Int32.Parse(nav2.Value);
				}
				iter=nav.Select("//feed");
				while(iter.MoveNext())
					feeds.Add(new Feed(iter.Current.Clone()));
				reader.Close();
			}
			if(feeds==null)
				feeds=new ArrayList();
			foreach(Feed feed in feeds)
			{
				TreeNode tn=new TreeNode(feed.Title);
				tn.Tag=feed;
				treeRoot.Nodes.Add(tn);
			}
			updateThread.Start();
		}

		private void ShowAlert(object id, string message)
		{
			host.ShowAlert(this,id,message);
		}

		public void UnloadPlugin()
		{
			XmlTextWriter writer=new XmlTextWriter(host.DataDirectory+"\\"+PluginName+".xml",System.Text.Encoding.Unicode);
			writer.IndentChar='\t';
			writer.Indentation=1;
			writer.Formatting=Formatting.Indented;
			writer.WriteStartDocument();
			writer.WriteStartElement("simplerss");

			writer.WriteStartElement("settings");
			writer.WriteAttributeString("headline",lstList.Columns[0].Width.ToString());
			writer.WriteAttributeString("date",lstList.Columns[1].Width.ToString());
			writer.WriteAttributeString("update",updateInterval.ToString());
			writer.WriteEndElement();
			
			foreach(Feed f in feeds)
				f.SaveState(writer);
			writer.WriteEndElement();
			writer.WriteEndDocument();
			writer.Flush();
			writer.Close();
			updateRunning=false;
			updateThread.Interrupt();
		}

		private void UpdateFeeds()
		{
			int newItems=0;
			Thread.Sleep(1000);
			while(updateRunning)
			{
				try
				{
					foreach(Feed feed in feeds)
					{
						newItems=rssParser.UpdateFeed(feed);
						if(newItems>0)
							Invoke(m_DelegateShowAlert,new Object[]{feed,newItems+" new items."});
					}
					Thread.Sleep(updateInterval);
				}
				catch(ThreadInterruptedException tie)
				{
				}
			}
		}

		public ContextMenu TreeNodeMouseUp(TreeNode node)
		{
			if(node!=treeRoot)
				removeFeed.Enabled=true;
			else if(node==treeRoot)
				removeFeed.Enabled=false;
			return(contextMenu);
		}

		public void TreeNodeSelected(TreeNode node)
		{
			if((node.Tag!=null)&&(node.Tag!=currentFeed)&&(node!=treeRoot))
			{
				currentFeed=(Feed)node.Tag;
				lstList.Items.Clear();
				if(currentFeed.Items!=null)
				{
					ArrayList al=new ArrayList(currentFeed.Items.Values);
					al.Sort();
					foreach(FeedItem item in al)
					{
						ListViewItem lvi=new ListViewItem(item.Title);
						lvi.SubItems.Add(item.Date.ToString());
						lvi.Tag=item;
						lstList.Items.Add(lvi);
					}
				}
			}
			else
			{
				lstList.Items.Clear();
				llbLink.Text="";
				txtDesc.Text="";
				currentFeed=null;
			}
			host.UpdateForm(this);
		}

		public void AlertResponse(object id)
		{
		}

		/// <summary>
		/// Gets and sets the IPluginHost value of host.
		/// </summary>
		public IPluginHost Host
		{
			get
			{
				return(this.host);
			}
			set
			{
				this.host=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of author.
		/// </summary>
		public string Author
		{
			get
			{
				return(AUTHOR);
			}
		}

		/// <summary>
		/// Gets and sets the string value of description.
		/// </summary>
		public string Description
		{
			get
			{
				return(DESCRIPTION);
			}
		}

		/// <summary>
		/// Gets and sets the string value of name.
		/// </summary>
		public string PluginName
		{
			get
			{
				return(PLUGIN_NAME);
			}
		}

		/// <summary>
		/// Gets and sets the string value of version.
		/// </summary>
		public string Version
		{
			get
			{
				return(VERSION);
			}
		}

		/// <summary>
		/// Gets and sets the TreeNode value of treeRoot.
		/// </summary>
		public TreeNode TreeRoot
		{
			get
			{
				return(this.treeRoot);
			}
			set
			{
				this.treeRoot=value;
			}
		}

		public UserControl Form
		{
			get
			{
				return(this);
			}
		}

		private void RemoveFeed_Event(object sender, System.EventArgs e)
		{
			if(currentFeed!=null)
			{
				if(MessageBox.Show(this,"Remove "+currentFeed.Title+"?","Remove Feed",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					feeds.Remove(currentFeed);
					foreach(TreeNode node in treeRoot.Nodes)
					{
						if(node.Tag==currentFeed)
						{
							treeRoot.Nodes.Remove(node);
							break;
						}
					}
					currentFeed=null;
				}
			}
		}

		private void AddFeed_Event(object sender, System.EventArgs e)
		{
			FeedProperties fp=new FeedProperties();
			if(fp.ShowDialog(this)==DialogResult.OK)
			{
				Feed f=new Feed(fp.URL,fp.Title);
				feeds.Add(f);
				TreeNode tn=new TreeNode(f.Title);
				tn.Tag=f;
				treeRoot.Nodes.Add(tn);
				updateThread.Interrupt();
			}
		}

		private void FeedProperties_Event(object sender, System.EventArgs e)
		{
			if(currentFeed==null)
			{
				Properties prop=new Properties();
				prop.Minutes=updateInterval/60000;
				if(prop.ShowDialog()==DialogResult.OK)
				{
					updateInterval=prop.Minutes*60000;
					updateThread.Interrupt();
				}
			}
			else
			{
				FeedProperties fp=new FeedProperties();
				fp.Title=currentFeed.Title;
				fp.URL=currentFeed.Url;
				if(fp.ShowDialog()==DialogResult.OK)
				{
					currentFeed.Title=fp.Title;
					currentFeed.Url=fp.URL;
					updateThread.Interrupt();
					foreach(TreeNode node in treeRoot.Nodes)
					{
						if(node.Tag==currentFeed)
						{
							node.Text=currentFeed.Title;
							break;
						}
					}
				}
			}
		}

		private void lstList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lstList.SelectedItems.Count>0)
			{
				ListViewItem lvi=lstList.SelectedItems[0];
				llbLink.Text=((FeedItem)lvi.Tag).Link;
				txtDesc.Text=((FeedItem)lvi.Tag).Description;
			}
			else
			{
				llbLink.Text="";
				txtDesc.Text="";
			}
		}

		private void llbLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(llbLink.Text);
		}
	}
}
