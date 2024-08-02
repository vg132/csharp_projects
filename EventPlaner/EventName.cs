using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EventPlaner
{
	/// <summary>
	/// Summary description for EventName.
	/// </summary>
	public class EventName : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEventName;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCountryName;
		private System.Windows.Forms.TextBox txtEventDate;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EventName()
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtEventName = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCountryName = new System.Windows.Forms.TextBox();
			this.txtEventDate = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Event Name";
			// 
			// txtEventName
			// 
			this.txtEventName.Location = new System.Drawing.Point(16, 64);
			this.txtEventName.Name = "txtEventName";
			this.txtEventName.Size = new System.Drawing.Size(208, 20);
			this.txtEventName.TabIndex = 3;
			this.txtEventName.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(149, 136);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(16, 136);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Country Name";
			// 
			// txtCountryName
			// 
			this.txtCountryName.Location = new System.Drawing.Point(16, 24);
			this.txtCountryName.Name = "txtCountryName";
			this.txtCountryName.Size = new System.Drawing.Size(208, 20);
			this.txtCountryName.TabIndex = 1;
			this.txtCountryName.Text = "";
			// 
			// txtEventDate
			// 
			this.txtEventDate.Location = new System.Drawing.Point(16, 104);
			this.txtEventDate.Name = "txtEventDate";
			this.txtEventDate.Size = new System.Drawing.Size(208, 20);
			this.txtEventDate.TabIndex = 5;
			this.txtEventDate.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Event Date";
			// 
			// EventName
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 167);
			this.ControlBox = false;
			this.Controls.Add(this.txtCountryName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtEventName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEventDate);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "EventName";
			this.Text = "EventName";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			DialogResult=DialogResult.OK;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
		}
		
		public String GetEventName()
		{
			return(txtEventName.Text);
		}
		
		public String GetEventCountry()
		{
			return(txtCountryName.Text);
		}
		
		public String GetEventDate()
		{
			return(txtEventDate.Text);
		}
	}
}
