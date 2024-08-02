using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RSS
{
	/// <summary>
	/// Summary description for AddFeed.
	/// </summary>
	public class FeedProperties : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grpFeed;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FeedProperties()
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
			this.grpFeed = new System.Windows.Forms.GroupBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpFeed.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpFeed
			// 
			this.grpFeed.Controls.Add(this.txtTitle);
			this.grpFeed.Controls.Add(this.txtURL);
			this.grpFeed.Controls.Add(this.label2);
			this.grpFeed.Controls.Add(this.label1);
			this.grpFeed.Location = new System.Drawing.Point(8, 8);
			this.grpFeed.Name = "grpFeed";
			this.grpFeed.Size = new System.Drawing.Size(224, 80);
			this.grpFeed.TabIndex = 0;
			this.grpFeed.TabStop = false;
			this.grpFeed.Text = "Feed Settings";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(48, 22);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(168, 20);
			this.txtTitle.TabIndex = 1;
			this.txtTitle.Text = "";
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(48, 46);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(168, 20);
			this.txtURL.TabIndex = 3;
			this.txtURL.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "URL:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title:";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(157, 96);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(8, 96);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			// 
			// AddFeed
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 125);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.grpFeed);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddFeed";
			this.ShowInTaskbar = false;
			this.Text = "RSS Feed";
			this.grpFeed.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if((txtURL.Text.Trim().Length==0)||(txtTitle.Text.Trim().Length==0))
			{
				MessageBox.Show("You have to enter a URL and a title.");
			}
			else
			{
				this.DialogResult=DialogResult.OK;
				this.Hide();
			}
		}

		public string Title
		{
			get
			{
				return(txtTitle.Text);
			}
			set
			{
				txtTitle.Text=value;
			}
		}

		public string URL
		{
			get
			{
				return(txtURL.Text);
			}
			set
			{
				txtURL.Text=value;
			}
		}
	}
}
