using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IIC.Plugin;

namespace IIC
{
	/// <summary>
	/// Summary description for AboutPlugin.
	/// </summary>
	public class frmAboutPlugin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpInfo;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components=null;

		/// <summary>
		/// Default Constructor
		/// </summary>
		public frmAboutPlugin()
		{
			InitializeComponent();
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpInfo = new System.Windows.Forms.GroupBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.grpInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpInfo
			// 
			this.grpInfo.Controls.Add(this.lblDescription);
			this.grpInfo.Controls.Add(this.label7);
			this.grpInfo.Controls.Add(this.lblAuthor);
			this.grpInfo.Controls.Add(this.label5);
			this.grpInfo.Controls.Add(this.lblVersion);
			this.grpInfo.Controls.Add(this.label3);
			this.grpInfo.Controls.Add(this.lblName);
			this.grpInfo.Controls.Add(this.label1);
			this.grpInfo.Location = new System.Drawing.Point(8, 8);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new System.Drawing.Size(248, 192);
			this.grpInfo.TabIndex = 0;
			this.grpInfo.TabStop = false;
			this.grpInfo.Text = "Plugin Information";
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(80, 96);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(160, 88);
			this.lblDescription.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Description:";
			// 
			// lblAuthor
			// 
			this.lblAuthor.Location = new System.Drawing.Point(80, 72);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(160, 16);
			this.lblAuthor.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Author:";
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(80, 48);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(160, 16);
			this.lblVersion.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Version:";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(80, 24);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(160, 16);
			this.lblName.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Name:";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(176, 208);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "&OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmAboutPlugin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 239);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.grpInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAboutPlugin";
			this.Text = "About...";
			this.grpInfo.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Sets the current plugin and gets the information from that one.
		/// </summary>
		/// <param name="plugin">A reference to the plugin.</param>
		public void SetPlugin(IPlugin plugin)
		{
			lblName.Text=plugin.PluginName;
			lblAuthor.Text=plugin.Author;
			lblDescription.Text=plugin.Description;
			lblVersion.Text=plugin.Version;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}
	}
}
