namespace VGSoftware.CodePad.UI.Forms
{
	partial class GoToLine
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.gotoLineLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.goToLineMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// gotoLineLabel
			// 
			this.gotoLineLabel.AutoSize = true;
			this.gotoLineLabel.Location = new System.Drawing.Point(12, 9);
			this.gotoLineLabel.Name = "gotoLineLabel";
			this.gotoLineLabel.Size = new System.Drawing.Size(106, 13);
			this.gotoLineLabel.TabIndex = 0;
			this.gotoLineLabel.Text = "Line number (1 - {0}):";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(208, 52);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(127, 52);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 2;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// goToLineMaskedTextBox
			// 
			this.goToLineMaskedTextBox.AllowPromptAsInput = false;
			this.goToLineMaskedTextBox.Location = new System.Drawing.Point(12, 25);
			this.goToLineMaskedTextBox.Mask = "0000000000000000000000";
			this.goToLineMaskedTextBox.Name = "goToLineMaskedTextBox";
			this.goToLineMaskedTextBox.PromptChar = ' ';
			this.goToLineMaskedTextBox.Size = new System.Drawing.Size(271, 20);
			this.goToLineMaskedTextBox.TabIndex = 1;
			// 
			// GoToLine
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(295, 87);
			this.Controls.Add(this.goToLineMaskedTextBox);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.gotoLineLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GoToLine";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Go To Line";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label gotoLineLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.MaskedTextBox goToLineMaskedTextBox;
	}
}