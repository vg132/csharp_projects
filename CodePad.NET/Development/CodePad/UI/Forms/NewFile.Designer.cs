namespace VGSoftware.CodePad.UI.Forms
{
	partial class NewFile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFile));
			this.largeTemplateImageList = new System.Windows.Forms.ImageList(this.components);
			this.smallTemplateImageList = new System.Windows.Forms.ImageList(this.components);
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.templatesListView = new System.Windows.Forms.ListView();
			this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.authorColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.extensionColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.categoryTreeView = new System.Windows.Forms.TreeView();
			this.treeViewImageList = new System.Windows.Forms.ImageList(this.components);
			this.categoryLabel = new System.Windows.Forms.Label();
			this.templateLabel = new System.Windows.Forms.Label();
			this.buttonImageList = new System.Windows.Forms.ImageList(this.components);
			this.detailViewRadioButton = new System.Windows.Forms.RadioButton();
			this.largeIconRadioButton = new System.Windows.Forms.RadioButton();
			this.smallIconRadioButton = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// largeTemplateImageList
			// 
			this.largeTemplateImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeTemplateImageList.ImageStream")));
			this.largeTemplateImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.largeTemplateImageList.Images.SetKeyName(0, "UtilityText.ico");
			this.largeTemplateImageList.Images.SetKeyName(1, "Code_ClassCS.ico");
			this.largeTemplateImageList.Images.SetKeyName(2, "Code_ClassVB.ico");
			this.largeTemplateImageList.Images.SetKeyName(3, "Code_CodeFileCS.ico");
			this.largeTemplateImageList.Images.SetKeyName(4, "Code_CodeFileVB.ico");
			this.largeTemplateImageList.Images.SetKeyName(5, "Utility_VBScript.ico");
			this.largeTemplateImageList.Images.SetKeyName(6, "Web_HTML.ico");
			this.largeTemplateImageList.Images.SetKeyName(7, "Web_StyleSheet.ico");
			this.largeTemplateImageList.Images.SetKeyName(8, "Web_WebConfig.ico");
			this.largeTemplateImageList.Images.SetKeyName(9, "Web_XML.ico");
			// 
			// smallTemplateImageList
			// 
			this.smallTemplateImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallTemplateImageList.ImageStream")));
			this.smallTemplateImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.smallTemplateImageList.Images.SetKeyName(0, "UtilityText.ico");
			this.smallTemplateImageList.Images.SetKeyName(1, "Code_ClassCS.ico");
			this.smallTemplateImageList.Images.SetKeyName(2, "Code_ClassVB.ico");
			this.smallTemplateImageList.Images.SetKeyName(3, "Code_CodeFileCS.ico");
			this.smallTemplateImageList.Images.SetKeyName(4, "Code_CodeFileVB.ico");
			this.smallTemplateImageList.Images.SetKeyName(5, "Utility_VBScript.ico");
			this.smallTemplateImageList.Images.SetKeyName(6, "Web_HTML.ico");
			this.smallTemplateImageList.Images.SetKeyName(7, "Web_StyleSheet.ico");
			this.smallTemplateImageList.Images.SetKeyName(8, "Web_WebConfig.ico");
			this.smallTemplateImageList.Images.SetKeyName(9, "Web_XML.ico");
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(485, 360);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 0;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(404, 360);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.descriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.descriptionTextBox.Location = new System.Drawing.Point(12, 334);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ReadOnly = true;
			this.descriptionTextBox.Size = new System.Drawing.Size(548, 20);
			this.descriptionTextBox.TabIndex = 2;
			// 
			// templatesListView
			// 
			this.templatesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.templatesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.authorColumnHeader,
            this.extensionColumnHeader});
			this.templatesListView.LargeImageList = this.largeTemplateImageList;
			this.templatesListView.Location = new System.Drawing.Point(230, 42);
			this.templatesListView.Name = "templatesListView";
			this.templatesListView.Size = new System.Drawing.Size(330, 286);
			this.templatesListView.SmallImageList = this.smallTemplateImageList;
			this.templatesListView.TabIndex = 3;
			this.templatesListView.UseCompatibleStateImageBehavior = false;
			this.templatesListView.View = System.Windows.Forms.View.SmallIcon;
			this.templatesListView.DoubleClick += new System.EventHandler(this.templatesListView_DoubleClick);
			this.templatesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.templatesListView_ItemSelectionChanged);
			// 
			// nameColumnHeader
			// 
			this.nameColumnHeader.Text = "Name";
			// 
			// authorColumnHeader
			// 
			this.authorColumnHeader.Text = "Author";
			// 
			// extensionColumnHeader
			// 
			this.extensionColumnHeader.Text = "Extension";
			// 
			// categoryTreeView
			// 
			this.categoryTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)));
			this.categoryTreeView.ImageIndex = 0;
			this.categoryTreeView.ImageList = this.treeViewImageList;
			this.categoryTreeView.Location = new System.Drawing.Point(12, 42);
			this.categoryTreeView.Name = "categoryTreeView";
			this.categoryTreeView.SelectedImageIndex = 1;
			this.categoryTreeView.Size = new System.Drawing.Size(212, 286);
			this.categoryTreeView.TabIndex = 4;
			this.categoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoryTreeView_AfterSelect);
			// 
			// treeViewImageList
			// 
			this.treeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImageList.ImageStream")));
			this.treeViewImageList.TransparentColor = System.Drawing.Color.Magenta;
			this.treeViewImageList.Images.SetKeyName(0, "XPfolder_closed.bmp");
			this.treeViewImageList.Images.SetKeyName(1, "XPfolder_Open.bmp");
			// 
			// categoryLabel
			// 
			this.categoryLabel.AutoSize = true;
			this.categoryLabel.Location = new System.Drawing.Point(12, 26);
			this.categoryLabel.Name = "categoryLabel";
			this.categoryLabel.Size = new System.Drawing.Size(49, 13);
			this.categoryLabel.TabIndex = 5;
			this.categoryLabel.Text = "Category";
			// 
			// templateLabel
			// 
			this.templateLabel.AutoSize = true;
			this.templateLabel.Location = new System.Drawing.Point(230, 26);
			this.templateLabel.Name = "templateLabel";
			this.templateLabel.Size = new System.Drawing.Size(51, 13);
			this.templateLabel.TabIndex = 6;
			this.templateLabel.Text = "Template";
			// 
			// buttonImageList
			// 
			this.buttonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImageList.ImageStream")));
			this.buttonImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.buttonImageList.Images.SetKeyName(0, "Details.png");
			this.buttonImageList.Images.SetKeyName(1, "LargeIcons.png");
			this.buttonImageList.Images.SetKeyName(2, "List.png");
			// 
			// detailViewRadioButton
			// 
			this.detailViewRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.detailViewRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.detailViewRadioButton.ImageIndex = 0;
			this.detailViewRadioButton.ImageList = this.buttonImageList;
			this.detailViewRadioButton.Location = new System.Drawing.Point(528, 12);
			this.detailViewRadioButton.Name = "detailViewRadioButton";
			this.detailViewRadioButton.Size = new System.Drawing.Size(32, 23);
			this.detailViewRadioButton.TabIndex = 10;
			this.detailViewRadioButton.UseVisualStyleBackColor = true;
			this.detailViewRadioButton.CheckedChanged += new System.EventHandler(this.detailViewRadioButton_CheckedChanged);
			// 
			// largeIconRadioButton
			// 
			this.largeIconRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.largeIconRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.largeIconRadioButton.ImageIndex = 1;
			this.largeIconRadioButton.ImageList = this.buttonImageList;
			this.largeIconRadioButton.Location = new System.Drawing.Point(495, 12);
			this.largeIconRadioButton.Name = "largeIconRadioButton";
			this.largeIconRadioButton.Size = new System.Drawing.Size(32, 23);
			this.largeIconRadioButton.TabIndex = 11;
			this.largeIconRadioButton.UseVisualStyleBackColor = true;
			this.largeIconRadioButton.CheckedChanged += new System.EventHandler(this.largeIconRadioButton_CheckedChanged);
			// 
			// smallIconRadioButton
			// 
			this.smallIconRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.smallIconRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.smallIconRadioButton.Checked = true;
			this.smallIconRadioButton.ImageIndex = 2;
			this.smallIconRadioButton.ImageList = this.buttonImageList;
			this.smallIconRadioButton.Location = new System.Drawing.Point(462, 12);
			this.smallIconRadioButton.Name = "smallIconRadioButton";
			this.smallIconRadioButton.Size = new System.Drawing.Size(32, 23);
			this.smallIconRadioButton.TabIndex = 12;
			this.smallIconRadioButton.TabStop = true;
			this.smallIconRadioButton.UseVisualStyleBackColor = true;
			this.smallIconRadioButton.CheckedChanged += new System.EventHandler(this.listViewRadioButton_CheckedChanged);
			// 
			// NewFile
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(572, 395);
			this.Controls.Add(this.smallIconRadioButton);
			this.Controls.Add(this.largeIconRadioButton);
			this.Controls.Add(this.detailViewRadioButton);
			this.Controls.Add(this.templateLabel);
			this.Controls.Add(this.categoryLabel);
			this.Controls.Add(this.categoryTreeView);
			this.Controls.Add(this.templatesListView);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewFile";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New File";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList smallTemplateImageList;
		private System.Windows.Forms.ImageList largeTemplateImageList;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.ListView templatesListView;
		private System.Windows.Forms.TreeView categoryTreeView;
		private System.Windows.Forms.Label categoryLabel;
		private System.Windows.Forms.Label templateLabel;
		private System.Windows.Forms.ColumnHeader nameColumnHeader;
		private System.Windows.Forms.ColumnHeader authorColumnHeader;
		private System.Windows.Forms.ColumnHeader extensionColumnHeader;
		private System.Windows.Forms.ImageList buttonImageList;
		private System.Windows.Forms.RadioButton detailViewRadioButton;
		private System.Windows.Forms.RadioButton largeIconRadioButton;
		private System.Windows.Forms.RadioButton smallIconRadioButton;
		private System.Windows.Forms.ImageList treeViewImageList;

	}
}