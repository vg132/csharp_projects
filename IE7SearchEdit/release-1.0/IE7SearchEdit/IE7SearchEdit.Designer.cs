namespace IE7SearchEdit
{
	partial class IE7SearchEdit
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
			this.components=new System.ComponentModel.Container();
			this.grpSettings=new System.Windows.Forms.GroupBox();
			this.txtSortIndex=new System.Windows.Forms.TextBox();
			this.lblSortIndex=new System.Windows.Forms.Label();
			this.txtURL=new System.Windows.Forms.TextBox();
			this.txtDisplayName=new System.Windows.Forms.TextBox();
			this.txtName=new System.Windows.Forms.TextBox();
			this.lblUrl=new System.Windows.Forms.Label();
			this.lblDisplayName=new System.Windows.Forms.Label();
			this.lblName=new System.Windows.Forms.Label();
			this.chkSameAsName=new System.Windows.Forms.CheckBox();
			this.grpInstalled=new System.Windows.Forms.GroupBox();
			this.cmdRemove=new System.Windows.Forms.Button();
			this.cmdNew=new System.Windows.Forms.Button();
			this.cmdDefault=new System.Windows.Forms.Button();
			this.cmdMoveDown=new System.Windows.Forms.Button();
			this.cmdMoveUp=new System.Windows.Forms.Button();
			this.lstSearchEngines=new System.Windows.Forms.ListBox();
			this.cmdSaveAndExit=new System.Windows.Forms.Button();
			this.cmdExit=new System.Windows.Forms.Button();
			this.toolTip1=new System.Windows.Forms.ToolTip(this.components);
			this.grpSettings.SuspendLayout();
			this.grpInstalled.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpSettings
			// 
			this.grpSettings.Controls.Add(this.txtSortIndex);
			this.grpSettings.Controls.Add(this.lblSortIndex);
			this.grpSettings.Controls.Add(this.txtURL);
			this.grpSettings.Controls.Add(this.txtDisplayName);
			this.grpSettings.Controls.Add(this.txtName);
			this.grpSettings.Controls.Add(this.lblUrl);
			this.grpSettings.Controls.Add(this.lblDisplayName);
			this.grpSettings.Controls.Add(this.lblName);
			this.grpSettings.Controls.Add(this.chkSameAsName);
			this.grpSettings.Enabled=false;
			this.grpSettings.Location=new System.Drawing.Point(11, 195);
			this.grpSettings.Name="grpSettings";
			this.grpSettings.Size=new System.Drawing.Size(366, 132);
			this.grpSettings.TabIndex=11;
			this.grpSettings.TabStop=false;
			this.grpSettings.Text="Search Engine Settings";
			// 
			// txtSortIndex
			// 
			this.txtSortIndex.Location=new System.Drawing.Point(96, 99);
			this.txtSortIndex.Name="txtSortIndex";
			this.txtSortIndex.Size=new System.Drawing.Size(164, 20);
			this.txtSortIndex.TabIndex=16;
			this.txtSortIndex.TextChanged+=new System.EventHandler(this.txtSortIndex_TextChanged);
			// 
			// lblSortIndex
			// 
			this.lblSortIndex.AutoSize=true;
			this.lblSortIndex.Location=new System.Drawing.Point(10, 102);
			this.lblSortIndex.Name="lblSortIndex";
			this.lblSortIndex.Size=new System.Drawing.Size(55, 14);
			this.lblSortIndex.TabIndex=15;
			this.lblSortIndex.Text="Sort Index:";
			// 
			// txtURL
			// 
			this.txtURL.Location=new System.Drawing.Point(96, 73);
			this.txtURL.Name="txtURL";
			this.txtURL.Size=new System.Drawing.Size(164, 20);
			this.txtURL.TabIndex=14;
			this.toolTip1.SetToolTip(this.txtURL, "Search engine URL, %s indicates where the search text will be inserted");
			this.txtURL.TextChanged+=new System.EventHandler(this.txtURL_TextChanged);
			// 
			// txtDisplayName
			// 
			this.txtDisplayName.Location=new System.Drawing.Point(96, 46);
			this.txtDisplayName.Name="txtDisplayName";
			this.txtDisplayName.Size=new System.Drawing.Size(164, 20);
			this.txtDisplayName.TabIndex=13;
			this.toolTip1.SetToolTip(this.txtDisplayName, "This is the name that is shown inside Internet Explorer");
			this.txtDisplayName.TextChanged+=new System.EventHandler(this.txtDisplayName_TextChanged);
			// 
			// txtName
			// 
			this.txtName.Location=new System.Drawing.Point(96, 19);
			this.txtName.Name="txtName";
			this.txtName.Size=new System.Drawing.Size(164, 20);
			this.txtName.TabIndex=12;
			this.toolTip1.SetToolTip(this.txtName, "Internal name for this search engine");
			this.txtName.TextChanged+=new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize=true;
			this.lblUrl.Location=new System.Drawing.Point(10, 76);
			this.lblUrl.Name="lblUrl";
			this.lblUrl.Size=new System.Drawing.Size(26, 14);
			this.lblUrl.TabIndex=11;
			this.lblUrl.Text="URL:";
			// 
			// lblDisplayName
			// 
			this.lblDisplayName.AutoSize=true;
			this.lblDisplayName.Location=new System.Drawing.Point(10, 49);
			this.lblDisplayName.Name="lblDisplayName";
			this.lblDisplayName.Size=new System.Drawing.Size(71, 14);
			this.lblDisplayName.TabIndex=10;
			this.lblDisplayName.Text="Display Name:";
			// 
			// lblName
			// 
			this.lblName.AutoSize=true;
			this.lblName.Location=new System.Drawing.Point(10, 22);
			this.lblName.Name="lblName";
			this.lblName.Size=new System.Drawing.Size(33, 14);
			this.lblName.TabIndex=9;
			this.lblName.Text="Name:";
			// 
			// chkSameAsName
			// 
			this.chkSameAsName.AutoSize=true;
			this.chkSameAsName.Location=new System.Drawing.Point(263, 47);
			this.chkSameAsName.Name="chkSameAsName";
			this.chkSameAsName.Size=new System.Drawing.Size(94, 18);
			this.chkSameAsName.TabIndex=8;
			this.chkSameAsName.Text="Same as Name";
			this.toolTip1.SetToolTip(this.chkSameAsName, "Use same name and display name for this search engine");
			this.chkSameAsName.CheckedChanged+=new System.EventHandler(this.chkSameAsName_CheckedChanged);
			// 
			// grpInstalled
			// 
			this.grpInstalled.Controls.Add(this.cmdRemove);
			this.grpInstalled.Controls.Add(this.cmdNew);
			this.grpInstalled.Controls.Add(this.cmdDefault);
			this.grpInstalled.Controls.Add(this.cmdMoveDown);
			this.grpInstalled.Controls.Add(this.cmdMoveUp);
			this.grpInstalled.Controls.Add(this.lstSearchEngines);
			this.grpInstalled.Location=new System.Drawing.Point(11, 12);
			this.grpInstalled.Name="grpInstalled";
			this.grpInstalled.Size=new System.Drawing.Size(366, 177);
			this.grpInstalled.TabIndex=12;
			this.grpInstalled.TabStop=false;
			this.grpInstalled.Text="Installed Search Engines";
			// 
			// cmdRemove
			// 
			this.cmdRemove.Location=new System.Drawing.Point(272, 79);
			this.cmdRemove.Name="cmdRemove";
			this.cmdRemove.Size=new System.Drawing.Size(75, 23);
			this.cmdRemove.TabIndex=18;
			this.cmdRemove.Text="Remove";
			this.toolTip1.SetToolTip(this.cmdRemove, "Remove search engine");
			this.cmdRemove.Click+=new System.EventHandler(this.cmdRemove_Click);
			// 
			// cmdNew
			// 
			this.cmdNew.Location=new System.Drawing.Point(272, 50);
			this.cmdNew.Name="cmdNew";
			this.cmdNew.Size=new System.Drawing.Size(75, 23);
			this.cmdNew.TabIndex=17;
			this.cmdNew.Text="Add New";
			this.toolTip1.SetToolTip(this.cmdNew, "Add new search engine");
			this.cmdNew.Click+=new System.EventHandler(this.cmdNew_Click);
			// 
			// cmdDefault
			// 
			this.cmdDefault.Location=new System.Drawing.Point(272, 108);
			this.cmdDefault.Name="cmdDefault";
			this.cmdDefault.Size=new System.Drawing.Size(75, 23);
			this.cmdDefault.TabIndex=15;
			this.cmdDefault.Text="Default";
			this.toolTip1.SetToolTip(this.cmdDefault, "Set as default search engine");
			this.cmdDefault.Click+=new System.EventHandler(this.cmdDefault_Click);
			// 
			// cmdMoveDown
			// 
			this.cmdMoveDown.Location=new System.Drawing.Point(272, 140);
			this.cmdMoveDown.Name="cmdMoveDown";
			this.cmdMoveDown.Size=new System.Drawing.Size(75, 23);
			this.cmdMoveDown.TabIndex=13;
			this.cmdMoveDown.Text="Move Down";
			this.toolTip1.SetToolTip(this.cmdMoveDown, "Move engine down one step");
			this.cmdMoveDown.Click+=new System.EventHandler(this.cmdMoveDown_Click);
			// 
			// cmdMoveUp
			// 
			this.cmdMoveUp.Location=new System.Drawing.Point(272, 19);
			this.cmdMoveUp.Name="cmdMoveUp";
			this.cmdMoveUp.Size=new System.Drawing.Size(75, 23);
			this.cmdMoveUp.TabIndex=12;
			this.cmdMoveUp.Text="Move Up";
			this.toolTip1.SetToolTip(this.cmdMoveUp, "Move engine up one step");
			this.cmdMoveUp.Click+=new System.EventHandler(this.cmdMoveUp_Click);
			// 
			// lstSearchEngines
			// 
			this.lstSearchEngines.FormattingEnabled=true;
			this.lstSearchEngines.ItemHeight=14;
			this.lstSearchEngines.Location=new System.Drawing.Point(6, 19);
			this.lstSearchEngines.Name="lstSearchEngines";
			this.lstSearchEngines.Size=new System.Drawing.Size(260, 144);
			this.lstSearchEngines.TabIndex=11;
			this.toolTip1.SetToolTip(this.lstSearchEngines, "Installed search engines");
			this.lstSearchEngines.SelectedIndexChanged+=new System.EventHandler(this.lstSearchEngines_SelectedIndexChanged);
			// 
			// cmdSaveAndExit
			// 
			this.cmdSaveAndExit.Location=new System.Drawing.Point(283, 333);
			this.cmdSaveAndExit.Name="cmdSaveAndExit";
			this.cmdSaveAndExit.Size=new System.Drawing.Size(94, 23);
			this.cmdSaveAndExit.TabIndex=13;
			this.cmdSaveAndExit.Text="Save and Exit";
			this.toolTip1.SetToolTip(this.cmdSaveAndExit, "Save changes and exit");
			this.cmdSaveAndExit.Click+=new System.EventHandler(this.cmdSaveAndExit_Click);
			// 
			// cmdExit
			// 
			this.cmdExit.Location=new System.Drawing.Point(11, 333);
			this.cmdExit.Name="cmdExit";
			this.cmdExit.Size=new System.Drawing.Size(94, 23);
			this.cmdExit.TabIndex=14;
			this.cmdExit.Text="Exit";
			this.toolTip1.SetToolTip(this.cmdExit, "Exit without saving changes");
			this.cmdExit.Click+=new System.EventHandler(this.cmdExit_Click);
			// 
			// IE7SearchEdit
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize=new System.Drawing.Size(392, 367);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.cmdSaveAndExit);
			this.Controls.Add(this.grpInstalled);
			this.Controls.Add(this.grpSettings);
			this.MaximizeBox=false;
			this.Name="IE7SearchEdit";
			this.Text="IE7 Search Engine Editor - www.vgsoftware.com";
			this.grpSettings.ResumeLayout(false);
			this.grpSettings.PerformLayout();
			this.grpInstalled.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpSettings;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.TextBox txtDisplayName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.Label lblDisplayName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.CheckBox chkSameAsName;
		private System.Windows.Forms.GroupBox grpInstalled;
		private System.Windows.Forms.Button cmdMoveDown;
		private System.Windows.Forms.Button cmdMoveUp;
		private System.Windows.Forms.ListBox lstSearchEngines;
		private System.Windows.Forms.Button cmdDefault;
		private System.Windows.Forms.TextBox txtSortIndex;
		private System.Windows.Forms.Label lblSortIndex;
		private System.Windows.Forms.Button cmdNew;
		private System.Windows.Forms.Button cmdRemove;
		private System.Windows.Forms.Button cmdSaveAndExit;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.ToolTip toolTip1;



	}
}

