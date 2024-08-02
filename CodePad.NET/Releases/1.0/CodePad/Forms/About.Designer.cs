namespace VGSoftware.CodePad.Forms
{
	partial class About
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.productNameLabel = new System.Windows.Forms.Label();
			this.productVersionLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.companyNameLabel = new System.Windows.Forms.Label();
			this.webPageLinkLabel = new System.Windows.Forms.LinkLabel();
			this.okButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::VGSoftware.CodePad.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(404, 73);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.descriptionTextBox.Location = new System.Drawing.Point(9, 198);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ReadOnly = true;
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(385, 156);
			this.descriptionTextBox.TabIndex = 5;
			// 
			// productNameLabel
			// 
			this.productNameLabel.AutoSize = true;
			this.productNameLabel.Location = new System.Drawing.Point(12, 95);
			this.productNameLabel.Margin = new System.Windows.Forms.Padding(3);
			this.productNameLabel.Name = "productNameLabel";
			this.productNameLabel.Size = new System.Drawing.Size(35, 13);
			this.productNameLabel.TabIndex = 0;
			this.productNameLabel.Text = "label1";
			// 
			// productVersionLabel
			// 
			this.productVersionLabel.AutoSize = true;
			this.productVersionLabel.Location = new System.Drawing.Point(12, 114);
			this.productVersionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.productVersionLabel.Name = "productVersionLabel";
			this.productVersionLabel.Size = new System.Drawing.Size(35, 13);
			this.productVersionLabel.TabIndex = 1;
			this.productVersionLabel.Text = "label2";
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Location = new System.Drawing.Point(12, 133);
			this.copyrightLabel.Margin = new System.Windows.Forms.Padding(3);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(35, 13);
			this.copyrightLabel.TabIndex = 2;
			this.copyrightLabel.Text = "label3";
			// 
			// companyNameLabel
			// 
			this.companyNameLabel.AutoSize = true;
			this.companyNameLabel.Location = new System.Drawing.Point(12, 152);
			this.companyNameLabel.Margin = new System.Windows.Forms.Padding(3);
			this.companyNameLabel.Name = "companyNameLabel";
			this.companyNameLabel.Size = new System.Drawing.Size(35, 13);
			this.companyNameLabel.TabIndex = 3;
			this.companyNameLabel.Text = "label4";
			// 
			// webPageLinkLabel
			// 
			this.webPageLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
			this.webPageLinkLabel.AutoSize = true;
			this.webPageLinkLabel.LinkColor = System.Drawing.Color.Blue;
			this.webPageLinkLabel.Location = new System.Drawing.Point(12, 171);
			this.webPageLinkLabel.Margin = new System.Windows.Forms.Padding(3);
			this.webPageLinkLabel.Name = "webPageLinkLabel";
			this.webPageLinkLabel.Size = new System.Drawing.Size(169, 13);
			this.webPageLinkLabel.TabIndex = 4;
			this.webPageLinkLabel.TabStop = true;
			this.webPageLinkLabel.Text = "http://codepadnet.codeplex.com/";
			this.webPageLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
			this.webPageLinkLabel.Click += new System.EventHandler(this.webPageLinkLabel_Click);
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(319, 367);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 6;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// About
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.okButton;
			this.ClientSize = new System.Drawing.Size(403, 402);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.webPageLinkLabel);
			this.Controls.Add(this.companyNameLabel);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.productVersionLabel);
			this.Controls.Add(this.productNameLabel);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Label productNameLabel;
		private System.Windows.Forms.Label productVersionLabel;
		private System.Windows.Forms.Label copyrightLabel;
		private System.Windows.Forms.Label companyNameLabel;
		private System.Windows.Forms.LinkLabel webPageLinkLabel;
		private System.Windows.Forms.Button okButton;


	}
}
