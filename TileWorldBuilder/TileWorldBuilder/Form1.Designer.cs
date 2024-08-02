namespace TileWorldBuilder
{
	partial class Form1
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
			this.TilesGroupBox = new System.Windows.Forms.GroupBox();
			this.TileFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.WorldGroupBox = new System.Windows.Forms.GroupBox();
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.MainMenuFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuTilesDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WorldPanel = new System.Windows.Forms.Panel();
			this.TilesGroupBox.SuspendLayout();
			this.WorldGroupBox.SuspendLayout();
			this.MainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// TilesGroupBox
			// 
			this.TilesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)));
			this.TilesGroupBox.AutoSize = true;
			this.TilesGroupBox.Controls.Add(this.TileFlowPanel);
			this.TilesGroupBox.Location = new System.Drawing.Point(12, 27);
			this.TilesGroupBox.Name = "TilesGroupBox";
			this.TilesGroupBox.Size = new System.Drawing.Size(200, 459);
			this.TilesGroupBox.TabIndex = 0;
			this.TilesGroupBox.TabStop = false;
			this.TilesGroupBox.Text = "Tiles";
			// 
			// TileFlowPanel
			// 
			this.TileFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)));
			this.TileFlowPanel.AutoScroll = true;
			this.TileFlowPanel.Location = new System.Drawing.Point(11, 20);
			this.TileFlowPanel.Name = "TileFlowPanel";
			this.TileFlowPanel.Size = new System.Drawing.Size(178, 433);
			this.TileFlowPanel.TabIndex = 0;
			// 
			// WorldGroupBox
			// 
			this.WorldGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.WorldGroupBox.Controls.Add(this.WorldPanel);
			this.WorldGroupBox.Location = new System.Drawing.Point(218, 27);
			this.WorldGroupBox.Name = "WorldGroupBox";
			this.WorldGroupBox.Size = new System.Drawing.Size(628, 459);
			this.WorldGroupBox.TabIndex = 1;
			this.WorldGroupBox.TabStop = false;
			this.WorldGroupBox.Text = "World";
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(858, 24);
			this.MainMenuStrip.TabIndex = 2;
			this.MainMenuStrip.Text = "menuStrip1";
			// 
			// MainMenuFileMenuItem
			// 
			this.MainMenuFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuTilesDirectoryMenuItem,
            this.toolStripMenuItem1,
            this.MainMenuExitMenuItem});
			this.MainMenuFileMenuItem.Name = "MainMenuFileMenuItem";
			this.MainMenuFileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.MainMenuFileMenuItem.Text = "&File";
			// 
			// MainMenuTilesDirectoryMenuItem
			// 
			this.MainMenuTilesDirectoryMenuItem.Name = "MainMenuTilesDirectoryMenuItem";
			this.MainMenuTilesDirectoryMenuItem.Size = new System.Drawing.Size(158, 22);
			this.MainMenuTilesDirectoryMenuItem.Text = "Tiles Directory...";
			this.MainMenuTilesDirectoryMenuItem.Click += new System.EventHandler(this.MainMenuTilesDirectoryMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
			// 
			// MainMenuExitMenuItem
			// 
			this.MainMenuExitMenuItem.Name = "MainMenuExitMenuItem";
			this.MainMenuExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.MainMenuExitMenuItem.Size = new System.Drawing.Size(158, 22);
			this.MainMenuExitMenuItem.Text = "E&xit";
			this.MainMenuExitMenuItem.Click += new System.EventHandler(this.MainMenuExitMenuItem_Click);
			// 
			// WorldPanel
			// 
			this.WorldPanel.AllowDrop = true;
			this.WorldPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.WorldPanel.Location = new System.Drawing.Point(6, 20);
			this.WorldPanel.Name = "WorldPanel";
			this.WorldPanel.Size = new System.Drawing.Size(616, 433);
			this.WorldPanel.TabIndex = 0;
			this.WorldPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.WorldPanel_DragDrop);
			this.WorldPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.WorldPanel_DragEnter);
			this.WorldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WorldPanel_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 498);
			this.Controls.Add(this.WorldGroupBox);
			this.Controls.Add(this.TilesGroupBox);
			this.Controls.Add(this.MainMenuStrip);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.TilesGroupBox.ResumeLayout(false);
			this.WorldGroupBox.ResumeLayout(false);
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox TilesGroupBox;
		private System.Windows.Forms.GroupBox WorldGroupBox;
		private System.Windows.Forms.FlowLayoutPanel TileFlowPanel;
		private System.Windows.Forms.MenuStrip MainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MainMenuExitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MainMenuTilesDirectoryMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.Panel WorldPanel;
	}
}

