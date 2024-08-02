namespace FileRenamer
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PathTextBox = new System.Windows.Forms.TextBox();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.FileListBox = new System.Windows.Forms.ListBox();
			this.NewFileListBox = new System.Windows.Forms.CheckedListBox();
			this.RenameButton = new System.Windows.Forms.Button();
			this.NewFileNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BrowseForFoldersDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PathTextBox
			// 
			this.PathTextBox.Location = new System.Drawing.Point(88, 28);
			this.PathTextBox.Name = "PathTextBox";
			this.PathTextBox.ReadOnly = true;
			this.PathTextBox.Size = new System.Drawing.Size(445, 20);
			this.PathTextBox.TabIndex = 0;
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(539, 27);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(25, 20);
			this.BrowseButton.TabIndex = 1;
			this.BrowseButton.Text = "...";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// FileListBox
			// 
			this.FileListBox.FormattingEnabled = true;
			this.FileListBox.Location = new System.Drawing.Point(12, 83);
			this.FileListBox.Name = "FileListBox";
			this.FileListBox.Size = new System.Drawing.Size(273, 355);
			this.FileListBox.TabIndex = 2;
			// 
			// NewFileListBox
			// 
			this.NewFileListBox.FormattingEnabled = true;
			this.NewFileListBox.Location = new System.Drawing.Point(291, 83);
			this.NewFileListBox.Name = "NewFileListBox";
			this.NewFileListBox.Size = new System.Drawing.Size(273, 349);
			this.NewFileListBox.TabIndex = 3;
			// 
			// RenameButton
			// 
			this.RenameButton.Location = new System.Drawing.Point(489, 444);
			this.RenameButton.Name = "RenameButton";
			this.RenameButton.Size = new System.Drawing.Size(75, 23);
			this.RenameButton.TabIndex = 4;
			this.RenameButton.Text = "Rename";
			this.RenameButton.UseVisualStyleBackColor = true;
			this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
			// 
			// NewFileNameTextBox
			// 
			this.NewFileNameTextBox.Location = new System.Drawing.Point(88, 54);
			this.NewFileNameTextBox.Name = "NewFileNameTextBox";
			this.NewFileNameTextBox.Size = new System.Drawing.Size(476, 20);
			this.NewFileNameTextBox.TabIndex = 5;
			this.NewFileNameTextBox.TextChanged += new System.EventHandler(this.NewFileNameTextBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "New Filename:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Directory:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(578, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "MainMenuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.Size = new System.Drawing.Size(92, 22);
			this.ExitMenuItem.Text = "E&xit";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(116, 22);
			this.AboutMenuItem.Text = "&About...";
			this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 479);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NewFileNameTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RenameButton);
			this.Controls.Add(this.NewFileListBox);
			this.Controls.Add(this.FileListBox);
			this.Controls.Add(this.BrowseButton);
			this.Controls.Add(this.PathTextBox);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Episode Renamer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PathTextBox;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.ListBox FileListBox;
		private System.Windows.Forms.CheckedListBox NewFileListBox;
		private System.Windows.Forms.Button RenameButton;
		private System.Windows.Forms.TextBox NewFileNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FolderBrowserDialog BrowseForFoldersDialog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
	}
}

