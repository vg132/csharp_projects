namespace TileWorldBuilder
{
	partial class NewWorld
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
			this.OkButton = new System.Windows.Forms.Button();
			this.RowsLabel = new System.Windows.Forms.Label();
			this.ColsLabel = new System.Windows.Forms.Label();
			this.RowsTextBox = new System.Windows.Forms.TextBox();
			this.ColsTextBox = new System.Windows.Forms.TextBox();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Location = new System.Drawing.Point(90, 67);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 4;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			// 
			// RowsLabel
			// 
			this.RowsLabel.AutoSize = true;
			this.RowsLabel.Location = new System.Drawing.Point(12, 13);
			this.RowsLabel.Name = "RowsLabel";
			this.RowsLabel.Size = new System.Drawing.Size(37, 13);
			this.RowsLabel.TabIndex = 0;
			this.RowsLabel.Text = "Rows:";
			// 
			// ColsLabel
			// 
			this.ColsLabel.AutoSize = true;
			this.ColsLabel.Location = new System.Drawing.Point(12, 39);
			this.ColsLabel.Name = "ColsLabel";
			this.ColsLabel.Size = new System.Drawing.Size(30, 13);
			this.ColsLabel.TabIndex = 2;
			this.ColsLabel.Text = "Cols:";
			// 
			// RowsTextBox
			// 
			this.RowsTextBox.Location = new System.Drawing.Point(53, 9);
			this.RowsTextBox.Name = "RowsTextBox";
			this.RowsTextBox.Size = new System.Drawing.Size(112, 20);
			this.RowsTextBox.TabIndex = 1;
			// 
			// ColsTextBox
			// 
			this.ColsTextBox.Location = new System.Drawing.Point(53, 35);
			this.ColsTextBox.Name = "ColsTextBox";
			this.ColsTextBox.Size = new System.Drawing.Size(112, 20);
			this.ColsTextBox.TabIndex = 3;
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(9, 67);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// NewWorld
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelButton;
			this.ClientSize = new System.Drawing.Size(177, 102);
			this.ControlBox = false;
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ColsTextBox);
			this.Controls.Add(this.RowsTextBox);
			this.Controls.Add(this.ColsLabel);
			this.Controls.Add(this.RowsLabel);
			this.Controls.Add(this.OkButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "NewWorld";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Setup New World";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Label RowsLabel;
		private System.Windows.Forms.Label ColsLabel;
		private System.Windows.Forms.TextBox RowsTextBox;
		private System.Windows.Forms.TextBox ColsTextBox;
		private System.Windows.Forms.Button CancelButton;
	}
}