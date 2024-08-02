namespace VGSoftware.Sharp.CodePad.Forms
{
	partial class CodePad
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodePad));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuTabStrip = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.runToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.codeTabControl = new VGSoftware.Sharp.CodePad.Controls.CodeTabControl();
			this.consoleTabControl = new System.Windows.Forms.TabControl();
			this.errorListTabPage = new System.Windows.Forms.TabPage();
			this.errorListListView = new System.Windows.Forms.ListView();
			this.descriptionColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.lineColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.columnColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.outputTabPage = new System.Windows.Forms.TabPage();
			this.outputConsole = new VGSoftware.Sharp.CodePad.Controls.Console();
			this.consoleTabPage = new System.Windows.Forms.TabPage();
			this.consoleConsole = new VGSoftware.Sharp.CodePad.Controls.Console();
			this.errorTabPage = new System.Windows.Forms.TabPage();
			this.errorConsole = new VGSoftware.Sharp.CodePad.Controls.Console();
			this.errorListImageList = new System.Windows.Forms.ImageList(this.components);
			this.mainMenuStrip.SuspendLayout();
			this.MainMenuTabStrip.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.consoleTabControl.SuspendLayout();
			this.errorListTabPage.SuspendLayout();
			this.outputTabPage.SuspendLayout();
			this.consoleTabPage.SuspendLayout();
			this.errorTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 520);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(882, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem13,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(882, 24);
			this.mainMenuStrip.TabIndex = 1;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem5,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem8,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem10,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripButton_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(152, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveAsToolStripMenuItem.Text = "Save as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(152, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referencesToolStripMenuItem});
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(61, 20);
			this.toolStripMenuItem13.Text = "Settings";
			// 
			// referencesToolStripMenuItem
			// 
			this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
			this.referencesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.referencesToolStripMenuItem.Text = "References...";
			this.referencesToolStripMenuItem.Click += new System.EventHandler(this.referencesToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			// 
			// MainMenuTabStrip
			// 
			this.MainMenuTabStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.stopToolStripButton,
            this.runToolStripButton});
			this.MainMenuTabStrip.Location = new System.Drawing.Point(0, 24);
			this.MainMenuTabStrip.Name = "MainMenuTabStrip";
			this.MainMenuTabStrip.Size = new System.Drawing.Size(882, 25);
			this.MainMenuTabStrip.TabIndex = 2;
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = global::VGSoftware.Sharp.CodePad.Properties.Resources.NewDocumentHS;
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "New";
			this.newToolStripButton.ToolTipText = "New";
			this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = global::VGSoftware.Sharp.CodePad.Properties.Resources.openHS;
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "Open";
			this.openToolStripButton.ToolTipText = "Open";
			this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = global::VGSoftware.Sharp.CodePad.Properties.Resources.saveHS;
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "Save";
			this.saveToolStripButton.ToolTipText = "Save";
			this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// stopToolStripButton
			// 
			this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stopToolStripButton.Enabled = false;
			this.stopToolStripButton.Image = global::VGSoftware.Sharp.CodePad.Properties.Resources.StopHS;
			this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.stopToolStripButton.Name = "stopToolStripButton";
			this.stopToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.stopToolStripButton.Text = "Stop";
			this.stopToolStripButton.ToolTipText = "Stop";
			this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButton_Click);
			// 
			// runToolStripButton
			// 
			this.runToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.runToolStripButton.Image = global::VGSoftware.Sharp.CodePad.Properties.Resources.PlayHS;
			this.runToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.runToolStripButton.Name = "runToolStripButton";
			this.runToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.runToolStripButton.Text = "Run";
			this.runToolStripButton.ToolTipText = "Run";
			this.runToolStripButton.Click += new System.EventHandler(this.runToolStripButton_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.codeTabControl);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.consoleTabControl);
			this.splitContainer1.Size = new System.Drawing.Size(882, 471);
			this.splitContainer1.SplitterDistance = 321;
			this.splitContainer1.TabIndex = 3;
			// 
			// codeTabControl
			// 
			this.codeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codeTabControl.Location = new System.Drawing.Point(0, 0);
			this.codeTabControl.Name = "codeTabControl";
			this.codeTabControl.SelectedIndex = 0;
			this.codeTabControl.SelectedTab = null;
			this.codeTabControl.Size = new System.Drawing.Size(882, 321);
			this.codeTabControl.TabIndex = 0;
			// 
			// consoleTabControl
			// 
			this.consoleTabControl.Controls.Add(this.errorListTabPage);
			this.consoleTabControl.Controls.Add(this.outputTabPage);
			this.consoleTabControl.Controls.Add(this.consoleTabPage);
			this.consoleTabControl.Controls.Add(this.errorTabPage);
			this.consoleTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleTabControl.Location = new System.Drawing.Point(0, 0);
			this.consoleTabControl.Multiline = true;
			this.consoleTabControl.Name = "consoleTabControl";
			this.consoleTabControl.SelectedIndex = 0;
			this.consoleTabControl.Size = new System.Drawing.Size(882, 146);
			this.consoleTabControl.TabIndex = 0;
			// 
			// errorListTabPage
			// 
			this.errorListTabPage.Controls.Add(this.errorListListView);
			this.errorListTabPage.Location = new System.Drawing.Point(4, 22);
			this.errorListTabPage.Name = "errorListTabPage";
			this.errorListTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.errorListTabPage.Size = new System.Drawing.Size(874, 120);
			this.errorListTabPage.TabIndex = 3;
			this.errorListTabPage.Text = "Error List";
			this.errorListTabPage.UseVisualStyleBackColor = true;
			// 
			// errorListListView
			// 
			this.errorListListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descriptionColumnHeader,
            this.lineColumnHeader,
            this.columnColumnHeader});
			this.errorListListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.errorListListView.FullRowSelect = true;
			this.errorListListView.GridLines = true;
			this.errorListListView.Location = new System.Drawing.Point(3, 3);
			this.errorListListView.Name = "errorListListView";
			this.errorListListView.Size = new System.Drawing.Size(868, 114);
			this.errorListListView.SmallImageList = this.errorListImageList;
			this.errorListListView.TabIndex = 0;
			this.errorListListView.UseCompatibleStateImageBehavior = false;
			this.errorListListView.View = System.Windows.Forms.View.Details;
			// 
			// descriptionColumnHeader
			// 
			this.descriptionColumnHeader.Text = "Description";
			this.descriptionColumnHeader.Width = 500;
			// 
			// lineColumnHeader
			// 
			this.lineColumnHeader.Text = "Line";
			// 
			// columnColumnHeader
			// 
			this.columnColumnHeader.Text = "Column";
			// 
			// outputTabPage
			// 
			this.outputTabPage.Controls.Add(this.outputConsole);
			this.outputTabPage.Location = new System.Drawing.Point(4, 22);
			this.outputTabPage.Name = "outputTabPage";
			this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.outputTabPage.Size = new System.Drawing.Size(874, 120);
			this.outputTabPage.TabIndex = 0;
			this.outputTabPage.Text = "Output";
			this.outputTabPage.UseVisualStyleBackColor = true;
			// 
			// outputConsole
			// 
			this.outputConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputConsole.InputStream = null;
			this.outputConsole.Location = new System.Drawing.Point(3, 3);
			this.outputConsole.Multiline = true;
			this.outputConsole.Name = "outputConsole";
			this.outputConsole.OutputStream = null;
			this.outputConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.outputConsole.Size = new System.Drawing.Size(868, 114);
			this.outputConsole.TabIndex = 0;
			this.outputConsole.WordWrap = false;
			// 
			// consoleTabPage
			// 
			this.consoleTabPage.Controls.Add(this.consoleConsole);
			this.consoleTabPage.Location = new System.Drawing.Point(4, 22);
			this.consoleTabPage.Name = "consoleTabPage";
			this.consoleTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.consoleTabPage.Size = new System.Drawing.Size(874, 120);
			this.consoleTabPage.TabIndex = 1;
			this.consoleTabPage.Text = "Console";
			this.consoleTabPage.UseVisualStyleBackColor = true;
			// 
			// consoleConsole
			// 
			this.consoleConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleConsole.InputStream = null;
			this.consoleConsole.Location = new System.Drawing.Point(3, 3);
			this.consoleConsole.Multiline = true;
			this.consoleConsole.Name = "consoleConsole";
			this.consoleConsole.OutputStream = null;
			this.consoleConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.consoleConsole.Size = new System.Drawing.Size(868, 114);
			this.consoleConsole.TabIndex = 0;
			this.consoleConsole.WordWrap = false;
			// 
			// errorTabPage
			// 
			this.errorTabPage.Controls.Add(this.errorConsole);
			this.errorTabPage.Location = new System.Drawing.Point(4, 22);
			this.errorTabPage.Name = "errorTabPage";
			this.errorTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.errorTabPage.Size = new System.Drawing.Size(874, 120);
			this.errorTabPage.TabIndex = 2;
			this.errorTabPage.Text = "Error";
			this.errorTabPage.UseVisualStyleBackColor = true;
			// 
			// errorConsole
			// 
			this.errorConsole.BackColor = System.Drawing.SystemColors.Window;
			this.errorConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.errorConsole.InputStream = null;
			this.errorConsole.Location = new System.Drawing.Point(3, 3);
			this.errorConsole.Multiline = true;
			this.errorConsole.Name = "errorConsole";
			this.errorConsole.OutputStream = null;
			this.errorConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.errorConsole.Size = new System.Drawing.Size(868, 114);
			this.errorConsole.TabIndex = 0;
			this.errorConsole.WordWrap = false;
			// 
			// errorListImageList
			// 
			this.errorListImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("errorListImageList.ImageStream")));
			this.errorListImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.errorListImageList.Images.SetKeyName(0, "Warning.png");
			this.errorListImageList.Images.SetKeyName(1, "Error.png");
			// 
			// CodePad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 542);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.MainMenuTabStrip);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "CodePad";
			this.Text = "CodePad";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodePad_FormClosing);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.MainMenuTabStrip.ResumeLayout(false);
			this.MainMenuTabStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.consoleTabControl.ResumeLayout(false);
			this.errorListTabPage.ResumeLayout(false);
			this.outputTabPage.ResumeLayout(false);
			this.outputTabPage.PerformLayout();
			this.consoleTabPage.ResumeLayout(false);
			this.consoleTabPage.PerformLayout();
			this.errorTabPage.ResumeLayout(false);
			this.errorTabPage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStrip MainMenuTabStrip;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private Controls.CodeTabControl codeTabControl;
		private System.Windows.Forms.TabControl consoleTabControl;
		private System.Windows.Forms.TabPage outputTabPage;
		private System.Windows.Forms.TabPage consoleTabPage;
		private System.Windows.Forms.TabPage errorTabPage;
		private Controls.Console errorConsole;
		private Controls.Console consoleConsole;
		private Controls.Console outputConsole;
		private System.Windows.Forms.TabPage errorListTabPage;
		private System.Windows.Forms.ListView errorListListView;
		private System.Windows.Forms.ColumnHeader descriptionColumnHeader;
		private System.Windows.Forms.ColumnHeader lineColumnHeader;
		private System.Windows.Forms.ColumnHeader columnColumnHeader;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
		private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton stopToolStripButton;
		private System.Windows.Forms.ToolStripButton runToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ImageList errorListImageList;

	}
}