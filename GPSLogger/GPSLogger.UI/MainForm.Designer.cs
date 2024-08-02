namespace VGSoftware.GPSLogger.UI
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.switchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.MainToolStrip = new System.Windows.Forms.ToolStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TripsTreeView = new System.Windows.Forms.TreeView();
			this.MainImageList = new System.Windows.Forms.ImageList(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.GPXInfoTabPage = new System.Windows.Forms.TabPage();
			this.TrackInformationGroupBox = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TotalTimeLabel = new System.Windows.Forms.Label();
			this.StartTimeLabel = new System.Windows.Forms.Label();
			this.EndTimeLabel = new System.Windows.Forms.Label();
			this.DistanceLabel = new System.Windows.Forms.Label();
			this.AverageSpeedLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GPXInformationGroupBox = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.MainMenuStrip.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.GPXInfoTabPage.SuspendLayout();
			this.TrackInformationGroupBox.SuspendLayout();
			this.GPXInformationGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(1029, 24);
			this.MainMenuStrip.TabIndex = 0;
			this.MainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.toolStripMenuItem2,
            this.switchUserToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.importToolStripMenuItem.Text = "Add GPX file...";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
			// 
			// switchUserToolStripMenuItem
			// 
			this.switchUserToolStripMenuItem.Name = "switchUserToolStripMenuItem";
			this.switchUserToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.switchUserToolStripMenuItem.Text = "Switch user...";
			this.switchUserToolStripMenuItem.Click += new System.EventHandler(this.switchUserToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// MainStatusStrip
			// 
			this.MainStatusStrip.Location = new System.Drawing.Point(0, 543);
			this.MainStatusStrip.Name = "MainStatusStrip";
			this.MainStatusStrip.Size = new System.Drawing.Size(1029, 22);
			this.MainStatusStrip.TabIndex = 1;
			this.MainStatusStrip.Text = "statusStrip1";
			// 
			// MainToolStrip
			// 
			this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
			this.MainToolStrip.Name = "MainToolStrip";
			this.MainToolStrip.Size = new System.Drawing.Size(1029, 25);
			this.MainToolStrip.TabIndex = 2;
			this.MainToolStrip.Text = "toolStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.TripsTreeView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(1029, 494);
			this.splitContainer1.SplitterDistance = 343;
			this.splitContainer1.TabIndex = 3;
			// 
			// TripsTreeView
			// 
			this.TripsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TripsTreeView.ImageIndex = 0;
			this.TripsTreeView.ImageList = this.MainImageList;
			this.TripsTreeView.Location = new System.Drawing.Point(0, 0);
			this.TripsTreeView.Name = "TripsTreeView";
			this.TripsTreeView.SelectedImageIndex = 0;
			this.TripsTreeView.Size = new System.Drawing.Size(343, 494);
			this.TripsTreeView.TabIndex = 0;
			this.TripsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TripsTreeView_AfterSelect);
			// 
			// MainImageList
			// 
			this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
			this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.MainImageList.Images.SetKeyName(0, "Folder_Close.png");
			this.MainImageList.Images.SetKeyName(1, "Folder_Open.png");
			this.MainImageList.Images.SetKeyName(2, "document.ico");
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.GPXInfoTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(682, 494);
			this.tabControl1.TabIndex = 0;
			// 
			// GPXInfoTabPage
			// 
			this.GPXInfoTabPage.Controls.Add(this.GPXInformationGroupBox);
			this.GPXInfoTabPage.Controls.Add(this.TrackInformationGroupBox);
			this.GPXInfoTabPage.Location = new System.Drawing.Point(4, 22);
			this.GPXInfoTabPage.Name = "GPXInfoTabPage";
			this.GPXInfoTabPage.Size = new System.Drawing.Size(674, 468);
			this.GPXInfoTabPage.TabIndex = 0;
			this.GPXInfoTabPage.Text = "Info";
			this.GPXInfoTabPage.UseVisualStyleBackColor = true;
			// 
			// TrackInformationGroupBox
			// 
			this.TrackInformationGroupBox.Controls.Add(this.label6);
			this.TrackInformationGroupBox.Controls.Add(this.TotalTimeLabel);
			this.TrackInformationGroupBox.Controls.Add(this.StartTimeLabel);
			this.TrackInformationGroupBox.Controls.Add(this.EndTimeLabel);
			this.TrackInformationGroupBox.Controls.Add(this.DistanceLabel);
			this.TrackInformationGroupBox.Controls.Add(this.AverageSpeedLabel);
			this.TrackInformationGroupBox.Controls.Add(this.label4);
			this.TrackInformationGroupBox.Controls.Add(this.label3);
			this.TrackInformationGroupBox.Controls.Add(this.label2);
			this.TrackInformationGroupBox.Controls.Add(this.label1);
			this.TrackInformationGroupBox.Location = new System.Drawing.Point(3, 290);
			this.TrackInformationGroupBox.Name = "TrackInformationGroupBox";
			this.TrackInformationGroupBox.Size = new System.Drawing.Size(204, 124);
			this.TrackInformationGroupBox.TabIndex = 4;
			this.TrackInformationGroupBox.TabStop = false;
			this.TrackInformationGroupBox.Text = "Trip data";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Total time:";
			// 
			// TotalTimeLabel
			// 
			this.TotalTimeLabel.AutoSize = true;
			this.TotalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalTimeLabel.Location = new System.Drawing.Point(117, 48);
			this.TotalTimeLabel.Name = "TotalTimeLabel";
			this.TotalTimeLabel.Size = new System.Drawing.Size(45, 16);
			this.TotalTimeLabel.TabIndex = 12;
			this.TotalTimeLabel.Text = "label9";
			// 
			// StartTimeLabel
			// 
			this.StartTimeLabel.AutoSize = true;
			this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartTimeLabel.Location = new System.Drawing.Point(117, 16);
			this.StartTimeLabel.Name = "StartTimeLabel";
			this.StartTimeLabel.Size = new System.Drawing.Size(45, 16);
			this.StartTimeLabel.TabIndex = 11;
			this.StartTimeLabel.Text = "label8";
			// 
			// EndTimeLabel
			// 
			this.EndTimeLabel.AutoSize = true;
			this.EndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EndTimeLabel.Location = new System.Drawing.Point(117, 32);
			this.EndTimeLabel.Name = "EndTimeLabel";
			this.EndTimeLabel.Size = new System.Drawing.Size(45, 16);
			this.EndTimeLabel.TabIndex = 10;
			this.EndTimeLabel.Text = "label7";
			// 
			// DistanceLabel
			// 
			this.DistanceLabel.AutoSize = true;
			this.DistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DistanceLabel.Location = new System.Drawing.Point(117, 64);
			this.DistanceLabel.Name = "DistanceLabel";
			this.DistanceLabel.Size = new System.Drawing.Size(45, 16);
			this.DistanceLabel.TabIndex = 9;
			this.DistanceLabel.Text = "label6";
			// 
			// AverageSpeedLabel
			// 
			this.AverageSpeedLabel.AutoSize = true;
			this.AverageSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AverageSpeedLabel.Location = new System.Drawing.Point(117, 80);
			this.AverageSpeedLabel.Name = "AverageSpeedLabel";
			this.AverageSpeedLabel.Size = new System.Drawing.Size(45, 16);
			this.AverageSpeedLabel.TabIndex = 8;
			this.AverageSpeedLabel.Text = "label5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Average speed:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Distance:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "End:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Start:";
			// 
			// GPXInformationGroupBox
			// 
			this.GPXInformationGroupBox.Controls.Add(this.label14);
			this.GPXInformationGroupBox.Controls.Add(this.label13);
			this.GPXInformationGroupBox.Controls.Add(this.label12);
			this.GPXInformationGroupBox.Controls.Add(this.label11);
			this.GPXInformationGroupBox.Controls.Add(this.label10);
			this.GPXInformationGroupBox.Controls.Add(this.label9);
			this.GPXInformationGroupBox.Controls.Add(this.label8);
			this.GPXInformationGroupBox.Controls.Add(this.label7);
			this.GPXInformationGroupBox.Controls.Add(this.label5);
			this.GPXInformationGroupBox.Location = new System.Drawing.Point(3, 3);
			this.GPXInformationGroupBox.Name = "GPXInformationGroupBox";
			this.GPXInformationGroupBox.Size = new System.Drawing.Size(663, 281);
			this.GPXInformationGroupBox.TabIndex = 5;
			this.GPXInformationGroupBox.TabStop = false;
			this.GPXInformationGroupBox.Text = "GPX Information";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "Description:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "Author:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(290, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 16);
			this.label9.TabIndex = 3;
			this.label9.Text = "label9";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 154);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 16);
			this.label10.TabIndex = 4;
			this.label10.Text = "Routs:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(290, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 16);
			this.label11.TabIndex = 5;
			this.label11.Text = "label11";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 170);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 16);
			this.label12.TabIndex = 6;
			this.label12.Text = "Tracks:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label13.Location = new System.Drawing.Point(6, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(54, 17);
			this.label13.TabIndex = 7;
			this.label13.Text = "label13";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label14.Location = new System.Drawing.Point(6, 206);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(78, 17);
			this.label14.TabIndex = 8;
			this.label14.Text = "Waypoints:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1029, 565);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.MainToolStrip);
			this.Controls.Add(this.MainStatusStrip);
			this.Controls.Add(this.MainMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.GPXInfoTabPage.ResumeLayout(false);
			this.TrackInformationGroupBox.ResumeLayout(false);
			this.TrackInformationGroupBox.PerformLayout();
			this.GPXInformationGroupBox.ResumeLayout(false);
			this.GPXInformationGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenuStrip;
		private System.Windows.Forms.StatusStrip MainStatusStrip;
		private System.Windows.Forms.ToolStrip MainToolStrip;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView TripsTreeView;
		private System.Windows.Forms.ImageList MainImageList;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage GPXInfoTabPage;
		private System.Windows.Forms.GroupBox TrackInformationGroupBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label StartTimeLabel;
		private System.Windows.Forms.Label EndTimeLabel;
		private System.Windows.Forms.Label DistanceLabel;
		private System.Windows.Forms.Label AverageSpeedLabel;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem switchUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.Label TotalTimeLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox GPXInformationGroupBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
	}
}

