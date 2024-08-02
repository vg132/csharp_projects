namespace VGSoftware.CodePad.Forms
{
	partial class ReferencesForm
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
			this.removeButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.referencesListView = new System.Windows.Forms.ListView();
			this.nameColumn = new System.Windows.Forms.ColumnHeader();
			this.versionColumn = new System.Windows.Forms.ColumnHeader();
			this.pathColumn = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(495, 354);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 2;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.CausesValidation = false;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(495, 383);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(414, 354);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveButton.Location = new System.Drawing.Point(414, 383);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "OK";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// referencesListView
			// 
			this.referencesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.versionColumn,
            this.pathColumn});
			this.referencesListView.FullRowSelect = true;
			this.referencesListView.GridLines = true;
			this.referencesListView.Location = new System.Drawing.Point(12, 12);
			this.referencesListView.Name = "referencesListView";
			this.referencesListView.Size = new System.Drawing.Size(558, 336);
			this.referencesListView.TabIndex = 0;
			this.referencesListView.UseCompatibleStateImageBehavior = false;
			this.referencesListView.View = System.Windows.Forms.View.Details;
			// 
			// nameColumn
			// 
			this.nameColumn.Text = "Name";
			this.nameColumn.Width = 150;
			// 
			// versionColumn
			// 
			this.versionColumn.Text = "Version";
			// 
			// pathColumn
			// 
			this.pathColumn.Text = "Path";
			this.pathColumn.Width = 320;
			// 
			// ReferencesForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(583, 419);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.referencesListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReferencesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "References";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ListView referencesListView;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader versionColumn;
		private System.Windows.Forms.ColumnHeader pathColumn;


	}
}