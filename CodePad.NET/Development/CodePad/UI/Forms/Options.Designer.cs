namespace VGSoftware.CodePad.UI.Forms
{
	partial class Options
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
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.generalTabPage = new System.Windows.Forms.TabPage();
			this.fileGroupBox = new System.Windows.Forms.GroupBox();
			this.defaultTemplateLabel = new System.Windows.Forms.Label();
			this.defaultTemplateComboBox = new System.Windows.Forms.ComboBox();
			this.showNewFileDialogCheckBox = new System.Windows.Forms.CheckBox();
			this.codeExecutionGroupBox = new System.Windows.Forms.GroupBox();
			this.redirectInputOutputErrorCheckBox = new System.Windows.Forms.CheckBox();
			this.textEditorTabPage = new System.Windows.Forms.TabPage();
			this.settingsGroupBox = new System.Windows.Forms.GroupBox();
			this.keepTabsRadioButton = new System.Windows.Forms.RadioButton();
			this.insertSpacesRadioButton = new System.Windows.Forms.RadioButton();
			this.tabSizeTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.indentStyleComboBox = new System.Windows.Forms.ComboBox();
			this.indentStyleLabel = new System.Windows.Forms.Label();
			this.displayGroupBox = new System.Windows.Forms.GroupBox();
			this.showSpacesCheckBox = new System.Windows.Forms.CheckBox();
			this.showTabCheckBox = new System.Windows.Forms.CheckBox();
			this.showEndOfLineCheckBox = new System.Windows.Forms.CheckBox();
			this.highlightSelectedLineCheckBox = new System.Windows.Forms.CheckBox();
			this.showLineNumbersCheckBox = new System.Windows.Forms.CheckBox();
			this.compilerTabPage = new System.Windows.Forms.TabPage();
			this.compilerSettingsGroupBox = new System.Windows.Forms.GroupBox();
			this.clearOutputOnExitCheckBox = new System.Windows.Forms.CheckBox();
			this.outputDirectoryLabel = new System.Windows.Forms.Label();
			this.outputDirectoryBrowseButton = new System.Windows.Forms.Button();
			this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.warningLevelComboBox = new System.Windows.Forms.ComboBox();
			this.warningLevelLabel = new System.Windows.Forms.Label();
			this.debugCheckBox = new System.Windows.Forms.CheckBox();
			this.netVersionLabel = new System.Windows.Forms.Label();
			this.netVersionComboBox = new System.Windows.Forms.ComboBox();
			this.warningsAsErrorCheckBox = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.generalTabPage.SuspendLayout();
			this.fileGroupBox.SuspendLayout();
			this.codeExecutionGroupBox.SuspendLayout();
			this.textEditorTabPage.SuspendLayout();
			this.settingsGroupBox.SuspendLayout();
			this.displayGroupBox.SuspendLayout();
			this.compilerTabPage.SuspendLayout();
			this.compilerSettingsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.CausesValidation = false;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(277, 388);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(196, 388);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.generalTabPage);
			this.tabControl1.Controls.Add(this.textEditorTabPage);
			this.tabControl1.Controls.Add(this.compilerTabPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(340, 370);
			this.tabControl1.TabIndex = 0;
			// 
			// generalTabPage
			// 
			this.generalTabPage.Controls.Add(this.fileGroupBox);
			this.generalTabPage.Controls.Add(this.codeExecutionGroupBox);
			this.generalTabPage.Location = new System.Drawing.Point(4, 22);
			this.generalTabPage.Name = "generalTabPage";
			this.generalTabPage.Size = new System.Drawing.Size(332, 344);
			this.generalTabPage.TabIndex = 2;
			this.generalTabPage.Text = "General";
			this.generalTabPage.UseVisualStyleBackColor = true;
			// 
			// fileGroupBox
			// 
			this.fileGroupBox.Controls.Add(this.defaultTemplateLabel);
			this.fileGroupBox.Controls.Add(this.defaultTemplateComboBox);
			this.fileGroupBox.Controls.Add(this.showNewFileDialogCheckBox);
			this.fileGroupBox.Location = new System.Drawing.Point(11, 12);
			this.fileGroupBox.Name = "fileGroupBox";
			this.fileGroupBox.Size = new System.Drawing.Size(310, 77);
			this.fileGroupBox.TabIndex = 1;
			this.fileGroupBox.TabStop = false;
			this.fileGroupBox.Text = "File";
			// 
			// defaultTemplateLabel
			// 
			this.defaultTemplateLabel.AutoSize = true;
			this.defaultTemplateLabel.Location = new System.Drawing.Point(6, 42);
			this.defaultTemplateLabel.Name = "defaultTemplateLabel";
			this.defaultTemplateLabel.Size = new System.Drawing.Size(80, 13);
			this.defaultTemplateLabel.TabIndex = 2;
			this.defaultTemplateLabel.Text = "Default new file";
			// 
			// defaultTemplateComboBox
			// 
			this.defaultTemplateComboBox.DisplayMember = "Name";
			this.defaultTemplateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.defaultTemplateComboBox.FormattingEnabled = true;
			this.defaultTemplateComboBox.Location = new System.Drawing.Point(92, 39);
			this.defaultTemplateComboBox.Name = "defaultTemplateComboBox";
			this.defaultTemplateComboBox.Size = new System.Drawing.Size(212, 21);
			this.defaultTemplateComboBox.TabIndex = 1;
			this.defaultTemplateComboBox.ValueMember = "FileName";
			// 
			// showNewFileDialogCheckBox
			// 
			this.showNewFileDialogCheckBox.AutoSize = true;
			this.showNewFileDialogCheckBox.Location = new System.Drawing.Point(6, 19);
			this.showNewFileDialogCheckBox.Name = "showNewFileDialogCheckBox";
			this.showNewFileDialogCheckBox.Size = new System.Drawing.Size(128, 17);
			this.showNewFileDialogCheckBox.TabIndex = 0;
			this.showNewFileDialogCheckBox.Text = "Show New File dialog";
			this.showNewFileDialogCheckBox.UseVisualStyleBackColor = true;
			this.showNewFileDialogCheckBox.CheckedChanged += new System.EventHandler(this.showNewFileDialogCheckBox_CheckedChanged);
			// 
			// codeExecutionGroupBox
			// 
			this.codeExecutionGroupBox.Controls.Add(this.redirectInputOutputErrorCheckBox);
			this.codeExecutionGroupBox.Location = new System.Drawing.Point(11, 93);
			this.codeExecutionGroupBox.Name = "codeExecutionGroupBox";
			this.codeExecutionGroupBox.Size = new System.Drawing.Size(310, 46);
			this.codeExecutionGroupBox.TabIndex = 0;
			this.codeExecutionGroupBox.TabStop = false;
			this.codeExecutionGroupBox.Text = "Code execution";
			// 
			// redirectInputOutputErrorCheckBox
			// 
			this.redirectInputOutputErrorCheckBox.AutoSize = true;
			this.redirectInputOutputErrorCheckBox.Location = new System.Drawing.Point(6, 19);
			this.redirectInputOutputErrorCheckBox.Name = "redirectInputOutputErrorCheckBox";
			this.redirectInputOutputErrorCheckBox.Size = new System.Drawing.Size(212, 17);
			this.redirectInputOutputErrorCheckBox.TabIndex = 0;
			this.redirectInputOutputErrorCheckBox.Text = "Redirect input/output/error to CodePad";
			this.redirectInputOutputErrorCheckBox.UseVisualStyleBackColor = true;
			// 
			// textEditorTabPage
			// 
			this.textEditorTabPage.Controls.Add(this.settingsGroupBox);
			this.textEditorTabPage.Controls.Add(this.displayGroupBox);
			this.textEditorTabPage.Location = new System.Drawing.Point(4, 22);
			this.textEditorTabPage.Name = "textEditorTabPage";
			this.textEditorTabPage.Padding = new System.Windows.Forms.Padding(8);
			this.textEditorTabPage.Size = new System.Drawing.Size(332, 344);
			this.textEditorTabPage.TabIndex = 0;
			this.textEditorTabPage.Text = "Text editor";
			this.textEditorTabPage.UseVisualStyleBackColor = true;
			// 
			// settingsGroupBox
			// 
			this.settingsGroupBox.Controls.Add(this.keepTabsRadioButton);
			this.settingsGroupBox.Controls.Add(this.insertSpacesRadioButton);
			this.settingsGroupBox.Controls.Add(this.tabSizeTextBox);
			this.settingsGroupBox.Controls.Add(this.label1);
			this.settingsGroupBox.Controls.Add(this.indentStyleComboBox);
			this.settingsGroupBox.Controls.Add(this.indentStyleLabel);
			this.settingsGroupBox.Location = new System.Drawing.Point(11, 11);
			this.settingsGroupBox.Name = "settingsGroupBox";
			this.settingsGroupBox.Size = new System.Drawing.Size(310, 155);
			this.settingsGroupBox.TabIndex = 0;
			this.settingsGroupBox.TabStop = false;
			this.settingsGroupBox.Text = "Settings";
			// 
			// keepTabsRadioButton
			// 
			this.keepTabsRadioButton.AutoSize = true;
			this.keepTabsRadioButton.Location = new System.Drawing.Point(9, 92);
			this.keepTabsRadioButton.Name = "keepTabsRadioButton";
			this.keepTabsRadioButton.Size = new System.Drawing.Size(73, 17);
			this.keepTabsRadioButton.TabIndex = 5;
			this.keepTabsRadioButton.TabStop = true;
			this.keepTabsRadioButton.Text = "Keep tabs";
			this.keepTabsRadioButton.UseVisualStyleBackColor = true;
			// 
			// insertSpacesRadioButton
			// 
			this.insertSpacesRadioButton.AutoSize = true;
			this.insertSpacesRadioButton.Location = new System.Drawing.Point(9, 69);
			this.insertSpacesRadioButton.Name = "insertSpacesRadioButton";
			this.insertSpacesRadioButton.Size = new System.Drawing.Size(88, 17);
			this.insertSpacesRadioButton.TabIndex = 4;
			this.insertSpacesRadioButton.TabStop = true;
			this.insertSpacesRadioButton.Text = "Insert spaces";
			this.insertSpacesRadioButton.UseVisualStyleBackColor = true;
			// 
			// tabSizeTextBox
			// 
			this.tabSizeTextBox.Location = new System.Drawing.Point(109, 40);
			this.tabSizeTextBox.MaxLength = 2;
			this.tabSizeTextBox.Name = "tabSizeTextBox";
			this.tabSizeTextBox.Size = new System.Drawing.Size(76, 20);
			this.tabSizeTextBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tab size:";
			// 
			// indentStyleComboBox
			// 
			this.indentStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.indentStyleComboBox.FormattingEnabled = true;
			this.indentStyleComboBox.Items.AddRange(new object[] {
            "Auto",
            "Smart",
            "None"});
			this.indentStyleComboBox.Location = new System.Drawing.Point(109, 13);
			this.indentStyleComboBox.Name = "indentStyleComboBox";
			this.indentStyleComboBox.Size = new System.Drawing.Size(195, 21);
			this.indentStyleComboBox.TabIndex = 1;
			// 
			// indentStyleLabel
			// 
			this.indentStyleLabel.AutoSize = true;
			this.indentStyleLabel.Location = new System.Drawing.Point(6, 16);
			this.indentStyleLabel.Name = "indentStyleLabel";
			this.indentStyleLabel.Size = new System.Drawing.Size(64, 13);
			this.indentStyleLabel.TabIndex = 0;
			this.indentStyleLabel.Text = "Indent style:";
			// 
			// displayGroupBox
			// 
			this.displayGroupBox.Controls.Add(this.showSpacesCheckBox);
			this.displayGroupBox.Controls.Add(this.showTabCheckBox);
			this.displayGroupBox.Controls.Add(this.showEndOfLineCheckBox);
			this.displayGroupBox.Controls.Add(this.highlightSelectedLineCheckBox);
			this.displayGroupBox.Controls.Add(this.showLineNumbersCheckBox);
			this.displayGroupBox.Location = new System.Drawing.Point(11, 172);
			this.displayGroupBox.Name = "displayGroupBox";
			this.displayGroupBox.Size = new System.Drawing.Size(310, 149);
			this.displayGroupBox.TabIndex = 1;
			this.displayGroupBox.TabStop = false;
			this.displayGroupBox.Text = "Display";
			// 
			// showSpacesCheckBox
			// 
			this.showSpacesCheckBox.AutoSize = true;
			this.showSpacesCheckBox.Location = new System.Drawing.Point(6, 45);
			this.showSpacesCheckBox.Name = "showSpacesCheckBox";
			this.showSpacesCheckBox.Size = new System.Drawing.Size(90, 17);
			this.showSpacesCheckBox.TabIndex = 1;
			this.showSpacesCheckBox.Text = "Show spaces";
			this.showSpacesCheckBox.UseVisualStyleBackColor = true;
			// 
			// showTabCheckBox
			// 
			this.showTabCheckBox.AutoSize = true;
			this.showTabCheckBox.Location = new System.Drawing.Point(6, 22);
			this.showTabCheckBox.Name = "showTabCheckBox";
			this.showTabCheckBox.Size = new System.Drawing.Size(71, 17);
			this.showTabCheckBox.TabIndex = 0;
			this.showTabCheckBox.Text = "Show tab";
			this.showTabCheckBox.UseVisualStyleBackColor = true;
			// 
			// showEndOfLineCheckBox
			// 
			this.showEndOfLineCheckBox.AutoSize = true;
			this.showEndOfLineCheckBox.Location = new System.Drawing.Point(6, 68);
			this.showEndOfLineCheckBox.Name = "showEndOfLineCheckBox";
			this.showEndOfLineCheckBox.Size = new System.Drawing.Size(105, 17);
			this.showEndOfLineCheckBox.TabIndex = 2;
			this.showEndOfLineCheckBox.Text = "Show end of line";
			this.showEndOfLineCheckBox.UseVisualStyleBackColor = true;
			// 
			// highlightSelectedLineCheckBox
			// 
			this.highlightSelectedLineCheckBox.AutoSize = true;
			this.highlightSelectedLineCheckBox.Location = new System.Drawing.Point(6, 114);
			this.highlightSelectedLineCheckBox.Name = "highlightSelectedLineCheckBox";
			this.highlightSelectedLineCheckBox.Size = new System.Drawing.Size(129, 17);
			this.highlightSelectedLineCheckBox.TabIndex = 4;
			this.highlightSelectedLineCheckBox.Text = "Highlight selected line";
			this.highlightSelectedLineCheckBox.UseVisualStyleBackColor = true;
			// 
			// showLineNumbersCheckBox
			// 
			this.showLineNumbersCheckBox.AutoSize = true;
			this.showLineNumbersCheckBox.Location = new System.Drawing.Point(6, 91);
			this.showLineNumbersCheckBox.Name = "showLineNumbersCheckBox";
			this.showLineNumbersCheckBox.Size = new System.Drawing.Size(115, 17);
			this.showLineNumbersCheckBox.TabIndex = 3;
			this.showLineNumbersCheckBox.Text = "Show line numbers";
			this.showLineNumbersCheckBox.UseVisualStyleBackColor = true;
			// 
			// compilerTabPage
			// 
			this.compilerTabPage.Controls.Add(this.compilerSettingsGroupBox);
			this.compilerTabPage.Location = new System.Drawing.Point(4, 22);
			this.compilerTabPage.Name = "compilerTabPage";
			this.compilerTabPage.Padding = new System.Windows.Forms.Padding(8);
			this.compilerTabPage.Size = new System.Drawing.Size(332, 344);
			this.compilerTabPage.TabIndex = 1;
			this.compilerTabPage.Text = "Compiler";
			this.compilerTabPage.UseVisualStyleBackColor = true;
			// 
			// compilerSettingsGroupBox
			// 
			this.compilerSettingsGroupBox.Controls.Add(this.clearOutputOnExitCheckBox);
			this.compilerSettingsGroupBox.Controls.Add(this.outputDirectoryLabel);
			this.compilerSettingsGroupBox.Controls.Add(this.outputDirectoryBrowseButton);
			this.compilerSettingsGroupBox.Controls.Add(this.outputDirectoryTextBox);
			this.compilerSettingsGroupBox.Controls.Add(this.warningLevelComboBox);
			this.compilerSettingsGroupBox.Controls.Add(this.warningLevelLabel);
			this.compilerSettingsGroupBox.Controls.Add(this.debugCheckBox);
			this.compilerSettingsGroupBox.Controls.Add(this.netVersionLabel);
			this.compilerSettingsGroupBox.Controls.Add(this.netVersionComboBox);
			this.compilerSettingsGroupBox.Controls.Add(this.warningsAsErrorCheckBox);
			this.compilerSettingsGroupBox.Location = new System.Drawing.Point(11, 11);
			this.compilerSettingsGroupBox.Name = "compilerSettingsGroupBox";
			this.compilerSettingsGroupBox.Size = new System.Drawing.Size(310, 322);
			this.compilerSettingsGroupBox.TabIndex = 0;
			this.compilerSettingsGroupBox.TabStop = false;
			this.compilerSettingsGroupBox.Text = "Settings";
			// 
			// clearOutputOnExitCheckBox
			// 
			this.clearOutputOnExitCheckBox.AutoSize = true;
			this.clearOutputOnExitCheckBox.Location = new System.Drawing.Point(9, 139);
			this.clearOutputOnExitCheckBox.Name = "clearOutputOnExitCheckBox";
			this.clearOutputOnExitCheckBox.Size = new System.Drawing.Size(201, 17);
			this.clearOutputOnExitCheckBox.TabIndex = 9;
			this.clearOutputOnExitCheckBox.Text = "Clear output directory on program exit";
			this.clearOutputOnExitCheckBox.UseVisualStyleBackColor = true;
			// 
			// outputDirectoryLabel
			// 
			this.outputDirectoryLabel.AutoSize = true;
			this.outputDirectoryLabel.Location = new System.Drawing.Point(6, 71);
			this.outputDirectoryLabel.Name = "outputDirectoryLabel";
			this.outputDirectoryLabel.Size = new System.Drawing.Size(82, 13);
			this.outputDirectoryLabel.TabIndex = 4;
			this.outputDirectoryLabel.Text = "Ouput directory:";
			// 
			// outputDirectoryBrowseButton
			// 
			this.outputDirectoryBrowseButton.Location = new System.Drawing.Point(278, 67);
			this.outputDirectoryBrowseButton.Name = "outputDirectoryBrowseButton";
			this.outputDirectoryBrowseButton.Size = new System.Drawing.Size(26, 20);
			this.outputDirectoryBrowseButton.TabIndex = 6;
			this.outputDirectoryBrowseButton.Text = "...";
			this.outputDirectoryBrowseButton.UseVisualStyleBackColor = true;
			this.outputDirectoryBrowseButton.Click += new System.EventHandler(this.outputDirectoryBrowseButton_Click);
			// 
			// outputDirectoryTextBox
			// 
			this.outputDirectoryTextBox.Location = new System.Drawing.Point(109, 67);
			this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
			this.outputDirectoryTextBox.Size = new System.Drawing.Size(168, 20);
			this.outputDirectoryTextBox.TabIndex = 5;
			// 
			// warningLevelComboBox
			// 
			this.warningLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.warningLevelComboBox.FormattingEnabled = true;
			this.warningLevelComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
			this.warningLevelComboBox.Location = new System.Drawing.Point(109, 40);
			this.warningLevelComboBox.Name = "warningLevelComboBox";
			this.warningLevelComboBox.Size = new System.Drawing.Size(97, 21);
			this.warningLevelComboBox.TabIndex = 3;
			// 
			// warningLevelLabel
			// 
			this.warningLevelLabel.AutoSize = true;
			this.warningLevelLabel.Location = new System.Drawing.Point(6, 43);
			this.warningLevelLabel.Name = "warningLevelLabel";
			this.warningLevelLabel.Size = new System.Drawing.Size(75, 13);
			this.warningLevelLabel.TabIndex = 2;
			this.warningLevelLabel.Text = "Warning level:";
			// 
			// debugCheckBox
			// 
			this.debugCheckBox.AutoSize = true;
			this.debugCheckBox.Location = new System.Drawing.Point(9, 116);
			this.debugCheckBox.Name = "debugCheckBox";
			this.debugCheckBox.Size = new System.Drawing.Size(149, 17);
			this.debugCheckBox.TabIndex = 8;
			this.debugCheckBox.Text = "Generate debug assembly";
			this.debugCheckBox.UseVisualStyleBackColor = true;
			// 
			// netVersionLabel
			// 
			this.netVersionLabel.AutoSize = true;
			this.netVersionLabel.Location = new System.Drawing.Point(6, 16);
			this.netVersionLabel.Name = "netVersionLabel";
			this.netVersionLabel.Size = new System.Drawing.Size(73, 13);
			this.netVersionLabel.TabIndex = 0;
			this.netVersionLabel.Text = ".NET Version:";
			// 
			// netVersionComboBox
			// 
			this.netVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.netVersionComboBox.FormattingEnabled = true;
			this.netVersionComboBox.Items.AddRange(new object[] {
            "v2.0",
            "v3.5",
            "v4.0"});
			this.netVersionComboBox.Location = new System.Drawing.Point(109, 13);
			this.netVersionComboBox.Name = "netVersionComboBox";
			this.netVersionComboBox.Size = new System.Drawing.Size(195, 21);
			this.netVersionComboBox.TabIndex = 1;
			// 
			// warningsAsErrorCheckBox
			// 
			this.warningsAsErrorCheckBox.AutoSize = true;
			this.warningsAsErrorCheckBox.Location = new System.Drawing.Point(9, 93);
			this.warningsAsErrorCheckBox.Name = "warningsAsErrorCheckBox";
			this.warningsAsErrorCheckBox.Size = new System.Drawing.Size(114, 17);
			this.warningsAsErrorCheckBox.TabIndex = 7;
			this.warningsAsErrorCheckBox.Text = "Warnings as errors";
			this.warningsAsErrorCheckBox.UseVisualStyleBackColor = true;
			// 
			// Options
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(363, 423);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Options";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.tabControl1.ResumeLayout(false);
			this.generalTabPage.ResumeLayout(false);
			this.fileGroupBox.ResumeLayout(false);
			this.fileGroupBox.PerformLayout();
			this.codeExecutionGroupBox.ResumeLayout(false);
			this.codeExecutionGroupBox.PerformLayout();
			this.textEditorTabPage.ResumeLayout(false);
			this.settingsGroupBox.ResumeLayout(false);
			this.settingsGroupBox.PerformLayout();
			this.displayGroupBox.ResumeLayout(false);
			this.displayGroupBox.PerformLayout();
			this.compilerTabPage.ResumeLayout(false);
			this.compilerSettingsGroupBox.ResumeLayout(false);
			this.compilerSettingsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage textEditorTabPage;
		private System.Windows.Forms.TabPage compilerTabPage;
		private System.Windows.Forms.CheckBox showLineNumbersCheckBox;
		private System.Windows.Forms.CheckBox showEndOfLineCheckBox;
		private System.Windows.Forms.CheckBox showTabCheckBox;
		private System.Windows.Forms.CheckBox showSpacesCheckBox;
		private System.Windows.Forms.CheckBox highlightSelectedLineCheckBox;
		private System.Windows.Forms.Label indentStyleLabel;
		private System.Windows.Forms.ComboBox indentStyleComboBox;
		private System.Windows.Forms.GroupBox displayGroupBox;
		private System.Windows.Forms.GroupBox settingsGroupBox;
		private System.Windows.Forms.GroupBox compilerSettingsGroupBox;
		private System.Windows.Forms.CheckBox warningsAsErrorCheckBox;
		private System.Windows.Forms.Label netVersionLabel;
		private System.Windows.Forms.ComboBox netVersionComboBox;
		private System.Windows.Forms.CheckBox debugCheckBox;
		private System.Windows.Forms.Label warningLevelLabel;
		private System.Windows.Forms.ComboBox warningLevelComboBox;
		private System.Windows.Forms.TextBox tabSizeTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton keepTabsRadioButton;
		private System.Windows.Forms.RadioButton insertSpacesRadioButton;
		private System.Windows.Forms.Label outputDirectoryLabel;
		private System.Windows.Forms.Button outputDirectoryBrowseButton;
		private System.Windows.Forms.TextBox outputDirectoryTextBox;
		private System.Windows.Forms.CheckBox clearOutputOnExitCheckBox;
		private System.Windows.Forms.TabPage generalTabPage;
		private System.Windows.Forms.GroupBox codeExecutionGroupBox;
		private System.Windows.Forms.CheckBox redirectInputOutputErrorCheckBox;
		private System.Windows.Forms.GroupBox fileGroupBox;
		private System.Windows.Forms.CheckBox showNewFileDialogCheckBox;
		private System.Windows.Forms.Label defaultTemplateLabel;
		private System.Windows.Forms.ComboBox defaultTemplateComboBox;
	}
}