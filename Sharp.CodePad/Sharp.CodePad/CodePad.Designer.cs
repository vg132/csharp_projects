namespace VGSoftware.Sharp.CodePad
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MainTabStrip = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.IconsMenuList = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.codeTabControl = new System.Windows.Forms.TabControl();
			this.consoleTabControl = new System.Windows.Forms.TabControl();
			this.outputTabPage = new System.Windows.Forms.TabPage();
			this.outputConsole = new VGSoftware.Sharp.CodePad.Console();
			this.consoleTabPage = new System.Windows.Forms.TabPage();
			this.consoleConsole = new VGSoftware.Sharp.CodePad.Console();
			this.errorTabPage = new System.Windows.Forms.TabPage();
			this.errorConsole = new VGSoftware.Sharp.CodePad.Console();
			this.MainTabStrip.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.consoleTabControl.SuspendLayout();
			this.outputTabPage.SuspendLayout();
			this.consoleTabPage.SuspendLayout();
			this.errorTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 459);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1074, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MainTabStrip
			// 
			this.MainTabStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1});
			this.MainTabStrip.Location = new System.Drawing.Point(0, 24);
			this.MainTabStrip.Name = "MainTabStrip";
			this.MainTabStrip.Size = new System.Drawing.Size(1074, 25);
			this.MainTabStrip.TabIndex = 2;
			this.MainTabStrip.Text = "Language";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "&New";
			this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "&Open";
			this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "&Save";
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "&Print";
			this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// cutToolStripButton
			// 
			this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
			this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripButton.Name = "cutToolStripButton";
			this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.cutToolStripButton.Text = "C&ut";
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "&Copy";
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name = "pasteToolStripButton";
			this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text = "&Paste";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// IconsMenuList
			// 
			this.IconsMenuList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsMenuList.ImageStream")));
			this.IconsMenuList.TransparentColor = System.Drawing.Color.Transparent;
			this.IconsMenuList.Images.SetKeyName(0, "Note.ico");
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
			this.splitContainer1.Size = new System.Drawing.Size(1074, 410);
			this.splitContainer1.SplitterDistance = 280;
			this.splitContainer1.TabIndex = 3;
			// 
			// codeTabControl
			// 
			this.codeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codeTabControl.Location = new System.Drawing.Point(0, 0);
			this.codeTabControl.Name = "codeTabControl";
			this.codeTabControl.SelectedIndex = 0;
			this.codeTabControl.Size = new System.Drawing.Size(1074, 280);
			this.codeTabControl.TabIndex = 0;
			// 
			// consoleTabControl
			// 
			this.consoleTabControl.Controls.Add(this.outputTabPage);
			this.consoleTabControl.Controls.Add(this.consoleTabPage);
			this.consoleTabControl.Controls.Add(this.errorTabPage);
			this.consoleTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleTabControl.Location = new System.Drawing.Point(0, 0);
			this.consoleTabControl.Multiline = true;
			this.consoleTabControl.Name = "consoleTabControl";
			this.consoleTabControl.SelectedIndex = 0;
			this.consoleTabControl.Size = new System.Drawing.Size(1074, 126);
			this.consoleTabControl.TabIndex = 0;
			// 
			// outputTabPage
			// 
			this.outputTabPage.Controls.Add(this.outputConsole);
			this.outputTabPage.Location = new System.Drawing.Point(4, 22);
			this.outputTabPage.Name = "outputTabPage";
			this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.outputTabPage.Size = new System.Drawing.Size(1066, 100);
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
			this.outputConsole.Size = new System.Drawing.Size(1060, 94);
			this.outputConsole.TabIndex = 0;
			// 
			// consoleTabPage
			// 
			this.consoleTabPage.Controls.Add(this.consoleConsole);
			this.consoleTabPage.Location = new System.Drawing.Point(4, 22);
			this.consoleTabPage.Name = "consoleTabPage";
			this.consoleTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.consoleTabPage.Size = new System.Drawing.Size(1066, 100);
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
			this.consoleConsole.Size = new System.Drawing.Size(1060, 94);
			this.consoleConsole.TabIndex = 0;
			// 
			// errorTabPage
			// 
			this.errorTabPage.Controls.Add(this.errorConsole);
			this.errorTabPage.Location = new System.Drawing.Point(4, 22);
			this.errorTabPage.Name = "errorTabPage";
			this.errorTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.errorTabPage.Size = new System.Drawing.Size(1066, 100);
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
			this.errorConsole.Size = new System.Drawing.Size(1060, 94);
			this.errorConsole.TabIndex = 0;
			// 
			// CodePad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 481);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.MainTabStrip);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CodePad";
			this.Text = "Form1";
			this.MainTabStrip.ResumeLayout(false);
			this.MainTabStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.consoleTabControl.ResumeLayout(false);
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip MainTabStrip;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl codeTabControl;
		private System.Windows.Forms.ImageList IconsMenuList;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton cutToolStripButton;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TabControl consoleTabControl;
		private System.Windows.Forms.TabPage outputTabPage;
		private System.Windows.Forms.TabPage consoleTabPage;
		private System.Windows.Forms.TabPage errorTabPage;
		private Console errorConsole;
		private Console consoleConsole;
		private Console outputConsole;

	}
}

