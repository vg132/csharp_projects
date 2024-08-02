using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RSS
{
	/// <summary>
	/// Summary description for Properties.
	/// </summary>
	public class Properties : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMinutes;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Properties()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMinutes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtMinutes);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(182, 56);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Update Intervall";
			// 
			// txtMinutes
			// 
			this.txtMinutes.Location = new System.Drawing.Point(108, 22);
			this.txtMinutes.MaxLength = 2;
			this.txtMinutes.Name = "txtMinutes";
			this.txtMinutes.Size = new System.Drawing.Size(19, 20);
			this.txtMinutes.TabIndex = 0;
			this.txtMinutes.Text = "textBox1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Update feeds every";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(129, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "minute(s)";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(115, 72);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(8, 72);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			// 
			// Properties
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(200, 103);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Properties";
			this.ShowInTaskbar = false;
			this.Text = "Properties";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.OK;
		}

		public int Minutes
		{
			get
			{
				return(Int32.Parse(txtMinutes.Text));
			}
			set
			{
				txtMinutes.Text=value.ToString();
			}
		}
	}
}
