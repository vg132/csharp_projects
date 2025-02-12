﻿namespace VGSoftware.GPSLogger.UI
{
	partial class UserSelectionForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.UserListBox = new System.Windows.Forms.ListBox();
			this.NewUserButton = new System.Windows.Forms.Button();
			this.LoginButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.UserListBox);
			this.groupBox1.Controls.Add(this.NewUserButton);
			this.groupBox1.Controls.Add(this.LoginButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 155);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select user";
			// 
			// UserListBox
			// 
			this.UserListBox.FormattingEnabled = true;
			this.UserListBox.Location = new System.Drawing.Point(6, 19);
			this.UserListBox.Name = "UserListBox";
			this.UserListBox.Size = new System.Drawing.Size(139, 121);
			this.UserListBox.TabIndex = 2;
			// 
			// NewUserButton
			// 
			this.NewUserButton.Location = new System.Drawing.Point(151, 88);
			this.NewUserButton.Name = "NewUserButton";
			this.NewUserButton.Size = new System.Drawing.Size(75, 23);
			this.NewUserButton.TabIndex = 1;
			this.NewUserButton.Text = "New user";
			this.NewUserButton.UseVisualStyleBackColor = true;
			this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
			// 
			// LoginButton
			// 
			this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.LoginButton.Location = new System.Drawing.Point(151, 117);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 0;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// UserSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 179);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UserSelectionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GPS Logger ";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button NewUserButton;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.ListBox UserListBox;
	}
}