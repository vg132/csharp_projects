using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EventPlaner
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.GroupBox grpEvents;
		private System.Windows.Forms.TreeView trvEvents;
		private System.Windows.Forms.GroupBox grpEvent;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.GroupBox grpEntery;
		private System.Windows.Forms.TextBox txtEvent;
		private System.Windows.Forms.TextBox txtNiceName;
		private System.Windows.Forms.TextBox txtOpen;
		private System.Windows.Forms.TextBox txtClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.MenuItem menuItem10;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox txtEventEvent;
		private System.Windows.Forms.TextBox txtEventOpen;
		private System.Windows.Forms.TextBox txtEventClose;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnEventSave;
		private ArrayList CurrentEvents=null;
		private System.Windows.Forms.MenuItem menuItem11;
		private string CurrentFilename=null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.grpEvents = new System.Windows.Forms.GroupBox();
			this.trvEvents = new System.Windows.Forms.TreeView();
			this.grpEvent = new System.Windows.Forms.GroupBox();
			this.btnEventSave = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEventClose = new System.Windows.Forms.TextBox();
			this.txtEventOpen = new System.Windows.Forms.TextBox();
			this.txtEventEvent = new System.Windows.Forms.TextBox();
			this.grpEntery = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtClose = new System.Windows.Forms.TextBox();
			this.txtOpen = new System.Windows.Forms.TextBox();
			this.txtNiceName = new System.Windows.Forms.TextBox();
			this.txtEvent = new System.Windows.Forms.TextBox();
			this.grpEvents.SuspendLayout();
			this.grpEvent.SuspendLayout();
			this.grpEntery.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem1,
																																							this.menuItem8});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem2,
																																							this.menuItem5,
																																							this.menuItem3,
																																							this.menuItem4,
																																							this.menuItem6,
																																							this.menuItem7});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Open...";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "Save &As...";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "&Save";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "E&xit";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem9,
																																							this.menuItem11,
																																							this.menuItem10});
			this.menuItem8.Text = "Edit";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "Add Event";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.Text = "Add Empty Event";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "Add Event Entery";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// grpEvents
			// 
			this.grpEvents.Controls.Add(this.trvEvents);
			this.grpEvents.Dock = System.Windows.Forms.DockStyle.Left;
			this.grpEvents.Location = new System.Drawing.Point(0, 0);
			this.grpEvents.Name = "grpEvents";
			this.grpEvents.Size = new System.Drawing.Size(226, 317);
			this.grpEvents.TabIndex = 1;
			this.grpEvents.TabStop = false;
			this.grpEvents.Text = "Events";
			// 
			// trvEvents
			// 
			this.trvEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.trvEvents.ImageIndex = -1;
			this.trvEvents.Location = new System.Drawing.Point(8, 16);
			this.trvEvents.Name = "trvEvents";
			this.trvEvents.SelectedImageIndex = -1;
			this.trvEvents.Size = new System.Drawing.Size(208, 288);
			this.trvEvents.TabIndex = 1;
			this.trvEvents.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvEvents_AfterSelect);
			// 
			// grpEvent
			// 
			this.grpEvent.Controls.Add(this.btnEventSave);
			this.grpEvent.Controls.Add(this.label7);
			this.grpEvent.Controls.Add(this.label6);
			this.grpEvent.Controls.Add(this.label5);
			this.grpEvent.Controls.Add(this.txtEventClose);
			this.grpEvent.Controls.Add(this.txtEventOpen);
			this.grpEvent.Controls.Add(this.txtEventEvent);
			this.grpEvent.Location = new System.Drawing.Point(232, 0);
			this.grpEvent.Name = "grpEvent";
			this.grpEvent.Size = new System.Drawing.Size(240, 312);
			this.grpEvent.TabIndex = 2;
			this.grpEvent.TabStop = false;
			this.grpEvent.Text = "Event";
			// 
			// btnEventSave
			// 
			this.btnEventSave.Location = new System.Drawing.Point(96, 104);
			this.btnEventSave.Name = "btnEventSave";
			this.btnEventSave.Size = new System.Drawing.Size(136, 23);
			this.btnEventSave.TabIndex = 6;
			this.btnEventSave.Text = "Save";
			this.btnEventSave.Click += new System.EventHandler(this.btnEventSave_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Close:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = "Open:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "Event:";
			// 
			// txtEventClose
			// 
			this.txtEventClose.Location = new System.Drawing.Point(96, 80);
			this.txtEventClose.Name = "txtEventClose";
			this.txtEventClose.Size = new System.Drawing.Size(136, 20);
			this.txtEventClose.TabIndex = 2;
			this.txtEventClose.Text = "";
			// 
			// txtEventOpen
			// 
			this.txtEventOpen.Location = new System.Drawing.Point(96, 56);
			this.txtEventOpen.Name = "txtEventOpen";
			this.txtEventOpen.Size = new System.Drawing.Size(136, 20);
			this.txtEventOpen.TabIndex = 1;
			this.txtEventOpen.Text = "";
			// 
			// txtEventEvent
			// 
			this.txtEventEvent.Location = new System.Drawing.Point(96, 30);
			this.txtEventEvent.Name = "txtEventEvent";
			this.txtEventEvent.Size = new System.Drawing.Size(136, 20);
			this.txtEventEvent.TabIndex = 0;
			this.txtEventEvent.Text = "";
			// 
			// grpEntery
			// 
			this.grpEntery.Controls.Add(this.btnSave);
			this.grpEntery.Controls.Add(this.label4);
			this.grpEntery.Controls.Add(this.label3);
			this.grpEntery.Controls.Add(this.label2);
			this.grpEntery.Controls.Add(this.label1);
			this.grpEntery.Controls.Add(this.txtClose);
			this.grpEntery.Controls.Add(this.txtOpen);
			this.grpEntery.Controls.Add(this.txtNiceName);
			this.grpEntery.Controls.Add(this.txtEvent);
			this.grpEntery.Location = new System.Drawing.Point(232, 0);
			this.grpEntery.Name = "grpEntery";
			this.grpEntery.Size = new System.Drawing.Size(242, 312);
			this.grpEntery.TabIndex = 3;
			this.grpEntery.TabStop = false;
			this.grpEntery.Text = "Entery";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(120, 120);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Close:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Open:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nice Name:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Event:";
			// 
			// txtClose
			// 
			this.txtClose.Location = new System.Drawing.Point(104, 96);
			this.txtClose.Name = "txtClose";
			this.txtClose.Size = new System.Drawing.Size(112, 20);
			this.txtClose.TabIndex = 3;
			this.txtClose.Text = "";
			// 
			// txtOpen
			// 
			this.txtOpen.Location = new System.Drawing.Point(104, 72);
			this.txtOpen.Name = "txtOpen";
			this.txtOpen.Size = new System.Drawing.Size(112, 20);
			this.txtOpen.TabIndex = 2;
			this.txtOpen.Text = "";
			// 
			// txtNiceName
			// 
			this.txtNiceName.Location = new System.Drawing.Point(104, 48);
			this.txtNiceName.Name = "txtNiceName";
			this.txtNiceName.Size = new System.Drawing.Size(112, 20);
			this.txtNiceName.TabIndex = 1;
			this.txtNiceName.Text = "";
			// 
			// txtEvent
			// 
			this.txtEvent.Location = new System.Drawing.Point(104, 24);
			this.txtEvent.Name = "txtEvent";
			this.txtEvent.Size = new System.Drawing.Size(112, 20);
			this.txtEvent.TabIndex = 0;
			this.txtEvent.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 317);
			this.Controls.Add(this.grpEvent);
			this.Controls.Add(this.grpEvents);
			this.Controls.Add(this.grpEntery);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.grpEvents.ResumeLayout(false);
			this.grpEvent.ResumeLayout(false);
			this.grpEntery.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd=new OpenFileDialog();
			ofd.Filter="XML Event Files (*.xml)|*.xml";
			if(ofd.ShowDialog()==DialogResult.OK)
			{
				XMLReader xml=new XMLReader();
				CurrentFilename=ofd.FileName;
				CurrentEvents=xml.readEventFile(CurrentFilename);
				RebuildTree();
			}
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			EventName en=new EventName();
			if(en.ShowDialog()==DialogResult.OK)
			{
				CurrentEvents.Add(new Event(en.GetEventCountry(),en.GetEventName(),en.GetEventDate(),true));
				RebuildTree();
			}
		}

		private void trvEvents_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			TreeNode node=trvEvents.SelectedNode;
			if(node!=null)
			{
				if(node.Tag is EventEntery)
				{
					grpEvent.Visible=false;
					grpEntery.Visible=true;
					EventEntery ee=(EventEntery)node.Tag;
					txtNiceName.Text=ee.NiceName;
					txtEvent.Text=ee.EventName;
					txtOpen.Text=ee.Open.ToString();
					txtClose.Text=ee.Close.ToString();
				}
				else if(node.Tag is Event)
				{
					grpEvent.Visible=true;
					grpEntery.Visible=false;
					Event eve=(Event)node.Tag;
					txtEventEvent.Text=eve.Name;
					txtEventOpen.Text=eve.Start.ToString();
					txtEventClose.Text=eve.End.ToString();
				}
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			EventEntery ee=(EventEntery)trvEvents.SelectedNode.Tag;
			ee.NiceName=txtNiceName.Text;
			ee.EventName=txtEvent.Text;
			ee.Open=DateTime.Parse(txtOpen.Text);
			ee.Close=DateTime.Parse(txtClose.Text);
			RebuildTree();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			TreeNode node=trvEvents.SelectedNode;
			if(node.Tag is Event)
			{
				((Event)node.Tag).AddEntery(new EventEntery("New Event Entery"));
				RebuildTree();
			}
		}

		private void RebuildTree()
		{
			TreeNode root=new TreeNode("Events");
			foreach(Event eve in CurrentEvents)
			{
				TreeNode node=new TreeNode();
				node.Text=eve.Name;
				root.Nodes.Add(node);
				node.Tag=eve;
				ArrayList enterys=eve.GetEnterys();
				foreach(EventEntery ee in enterys)
				{
					TreeNode node2=new TreeNode();
					node2.Text=ee.NiceName;
					node.Nodes.Add(node2);
					node2.Tag=ee;
				}
			}
			trvEvents.Nodes.Clear();
			trvEvents.Nodes.Add(root);
			trvEvents.Nodes[0].Expand();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void btnEventSave_Click(object sender, System.EventArgs e)
		{
			if(trvEvents.SelectedNode.Tag is Event)
			{
				Event eve=(Event)trvEvents.SelectedNode.Tag;
				eve.Name=txtEventEvent.Text;
				eve.Start=DateTime.Parse(txtEventOpen.Text);
				eve.End=DateTime.Parse(txtEventClose.Text);
				RebuildTree();
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if(CurrentFilename!=null)
			{
				XMLReader x=new XMLReader();
				x.WriteEventFile(CurrentEvents,CurrentFilename);
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			EventName en=new EventName();
			if(en.ShowDialog()==DialogResult.OK)
			{
				CurrentEvents.Add(new Event(en.GetEventCountry(),en.GetEventName(),en.GetEventDate(),false));
				RebuildTree();
			}		
		}
	}
}
