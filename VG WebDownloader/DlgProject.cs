using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace VGSoftware.PageSaver
{
	/// <summary>
	/// Summary description for NewProject.
	/// </summary>
	public class DlgProject : System.Windows.Forms.Form
	{
		private Project m_Project;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtProjectFolder;
		private System.Windows.Forms.Label lblProjectFolder;
		private System.Windows.Forms.Label lblProjectName;
		private System.Windows.Forms.TextBox txtProjectName;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox grpProjectSettings;
		private System.Windows.Forms.CheckBox chkCookie;
		private System.Windows.Forms.LinkLabel llbCatch;
		private System.Windows.Forms.CheckBox chkCache;
		private System.Windows.Forms.RadioButton chkServerLayout;
		private System.Windows.Forms.RadioButton chkSingle;
		private System.Windows.Forms.RadioButton chkSeparate;
		private System.Windows.Forms.TextBox txtDirectoryName;
		private System.Windows.Forms.Label lblDirectoryName;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Dialog for project settings.
		/// </summary>
		public DlgProject()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.grpProjectSettings = new System.Windows.Forms.GroupBox();
			this.chkSeparate = new System.Windows.Forms.RadioButton();
			this.chkSingle = new System.Windows.Forms.RadioButton();
			this.chkServerLayout = new System.Windows.Forms.RadioButton();
			this.llbCatch = new System.Windows.Forms.LinkLabel();
			this.chkCache = new System.Windows.Forms.CheckBox();
			this.chkCookie = new System.Windows.Forms.CheckBox();
			this.txtProjectFolder = new System.Windows.Forms.TextBox();
			this.lblProjectFolder = new System.Windows.Forms.Label();
			this.lblProjectName = new System.Windows.Forms.Label();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtDirectoryName = new System.Windows.Forms.TextBox();
			this.lblDirectoryName = new System.Windows.Forms.Label();
			this.grpProjectSettings.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(336, 440);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 24);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(432, 440);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(88, 24);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// grpProjectSettings
			// 
			this.grpProjectSettings.Controls.AddRange(new System.Windows.Forms.Control[] {
																																										 this.lblDirectoryName,
																																										 this.txtDirectoryName,
																																										 this.chkSeparate,
																																										 this.chkSingle,
																																										 this.chkServerLayout,
																																										 this.llbCatch,
																																										 this.chkCache,
																																										 this.chkCookie,
																																										 this.txtProjectFolder,
																																										 this.lblProjectFolder,
																																										 this.lblProjectName,
																																										 this.txtProjectName});
			this.grpProjectSettings.Location = new System.Drawing.Point(16, 8);
			this.grpProjectSettings.Name = "grpProjectSettings";
			this.grpProjectSettings.Size = new System.Drawing.Size(504, 424);
			this.grpProjectSettings.TabIndex = 0;
			this.grpProjectSettings.TabStop = false;
			this.grpProjectSettings.Text = "Project Settings";
			// 
			// chkSeparate
			// 
			this.chkSeparate.Location = new System.Drawing.Point(32, 168);
			this.chkSeparate.Name = "chkSeparate";
			this.chkSeparate.Size = new System.Drawing.Size(224, 16);
			this.chkSeparate.TabIndex = 10;
			this.chkSeparate.Text = "Create seperet directorys for every page";
			this.chkSeparate.CheckedChanged += new System.EventHandler(this.chkSeparate_CheckedChanged);
			// 
			// chkSingle
			// 
			this.chkSingle.Location = new System.Drawing.Point(32, 152);
			this.chkSingle.Name = "chkSingle";
			this.chkSingle.Size = new System.Drawing.Size(224, 16);
			this.chkSingle.TabIndex = 9;
			this.chkSingle.Text = "Save all into one directory";
			this.chkSingle.CheckedChanged += new System.EventHandler(this.chkSingle_CheckedChanged);
			// 
			// chkServerLayout
			// 
			this.chkServerLayout.Location = new System.Drawing.Point(32, 136);
			this.chkServerLayout.Name = "chkServerLayout";
			this.chkServerLayout.Size = new System.Drawing.Size(224, 16);
			this.chkServerLayout.TabIndex = 8;
			this.chkServerLayout.Text = "Recreate Server Layout";
			this.chkServerLayout.CheckedChanged += new System.EventHandler(this.chkServerLayout_CheckedChanged);
			// 
			// llbCatch
			// 
			this.llbCatch.AutoSize = true;
			this.llbCatch.Location = new System.Drawing.Point(24, 240);
			this.llbCatch.Name = "llbCatch";
			this.llbCatch.Size = new System.Drawing.Size(0, 13);
			this.llbCatch.TabIndex = 7;
			// 
			// chkCache
			// 
			this.chkCache.Location = new System.Drawing.Point(32, 112);
			this.chkCache.Name = "chkCache";
			this.chkCache.Size = new System.Drawing.Size(264, 16);
			this.chkCache.TabIndex = 5;
			this.chkCache.Text = "Use Microsoft Internet Explorer Cache Directory";
			// 
			// chkCookie
			// 
			this.chkCookie.Location = new System.Drawing.Point(32, 96);
			this.chkCookie.Name = "chkCookie";
			this.chkCookie.Size = new System.Drawing.Size(264, 16);
			this.chkCookie.TabIndex = 4;
			this.chkCookie.Text = "Use Microsoft Internet Explorer Cookies";
			// 
			// txtProjectFolder
			// 
			this.txtProjectFolder.Location = new System.Drawing.Point(96, 56);
			this.txtProjectFolder.Name = "txtProjectFolder";
			this.txtProjectFolder.Size = new System.Drawing.Size(296, 20);
			this.txtProjectFolder.TabIndex = 1;
			this.txtProjectFolder.Text = "txtProjectFolder";
			// 
			// lblProjectFolder
			// 
			this.lblProjectFolder.AutoSize = true;
			this.lblProjectFolder.Location = new System.Drawing.Point(16, 56);
			this.lblProjectFolder.Name = "lblProjectFolder";
			this.lblProjectFolder.Size = new System.Drawing.Size(78, 13);
			this.lblProjectFolder.TabIndex = 3;
			this.lblProjectFolder.Text = "Project Folder:";
			// 
			// lblProjectName
			// 
			this.lblProjectName.AutoSize = true;
			this.lblProjectName.Location = new System.Drawing.Point(16, 24);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(76, 13);
			this.lblProjectName.TabIndex = 2;
			this.lblProjectName.Text = "Project Name:";
			// 
			// txtProjectName
			// 
			this.txtProjectName.Location = new System.Drawing.Point(96, 24);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(296, 20);
			this.txtProjectName.TabIndex = 0;
			this.txtProjectName.Text = "txtProjectName";
			this.txtProjectName.TextChanged += new System.EventHandler(this.ProjectName_TextChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.btnCancel,
																																				 this.btnOK,
																																				 this.grpProjectSettings});
			this.panel2.Location = new System.Drawing.Point(-8, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(600, 496);
			this.panel2.TabIndex = 1;
			// 
			// txtDirectoryName
			// 
			this.txtDirectoryName.Location = new System.Drawing.Point(72, 192);
			this.txtDirectoryName.Name = "txtDirectoryName";
			this.txtDirectoryName.Size = new System.Drawing.Size(184, 20);
			this.txtDirectoryName.TabIndex = 11;
			this.txtDirectoryName.Text = "";
			// 
			// lblDirectoryName
			// 
			this.lblDirectoryName.AutoSize = true;
			this.lblDirectoryName.Location = new System.Drawing.Point(32, 196);
			this.lblDirectoryName.Name = "lblDirectoryName";
			this.lblDirectoryName.Size = new System.Drawing.Size(38, 13);
			this.lblDirectoryName.TabIndex = 12;
			this.lblDirectoryName.Text = "Name:";
			// 
			// DlgProject
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(522, 470);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.panel2});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "DlgProject";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Project";
			this.grpProjectSettings.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Set the current project file.
		/// </summary>
		/// <param name="project">Reference to current project file</param>
		public void SetProjectFile(ref Project project)
		{
			m_Project=project;
		}

		/// <summary>
		/// Update controls with data from the current project file.
		/// </summary>
		public void UpdateControls()
		{
			txtProjectFolder.Text=m_Project.Folder;
			txtProjectName.Text=m_Project.Name;
			chkCookie.Checked=m_Project.Cookie;
			chkCache.Checked=m_Project.Cache;
			txtDirectoryName.Text=m_Project.DirectoryName;
			if(m_Project.DirectoryStructure==0)
			{
				txtDirectoryName.Enabled=false;
				chkServerLayout.Checked=true;
			}
			else if(m_Project.DirectoryStructure==1)
			{
				txtDirectoryName.Enabled=true;
				chkSingle.Checked=true;
			}
			else if(m_Project.DirectoryStructure==2)
			{
				txtDirectoryName.Enabled=true;
				chkSeparate.Checked=true;
			}
		}

		/// <summary>
		/// Save changes to project file.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(((!txtProjectName.Text.Equals(""))&&(!txtProjectFolder.Text.Equals("")))
				&&((chkServerLayout.Checked)||(!txtDirectoryName.Text.Equals(""))))
			{
				m_Project.Folder=txtProjectFolder.Text;
				m_Project.Name=txtProjectName.Text;
				m_Project.Cache=chkCache.Checked;
				m_Project.Cookie=chkCookie.Checked;
				if(chkServerLayout.Checked)
					m_Project.DirectoryStructure=0;
				else if(chkSingle.Checked)
					m_Project.DirectoryStructure=1;
				else
					m_Project.DirectoryStructure=2;
				m_Project.DirectoryName=txtDirectoryName.Text;
				m_Project.ClearPageCatch();
				this.DialogResult=DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show(this,"You have not enterd all required data, please go back and enter all the missing data.","Missing Data",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			Close();
		}

		private void ProjectName_TextChanged(object sender, System.EventArgs e)
		{
			txtProjectFolder.Text=m_Project.Folder + "\\" + txtProjectName.Text;
		}

		private void chkServerLayout_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkServerLayout.Checked==true)
			{
				txtDirectoryName.Enabled=false;
				lblDirectoryName.Enabled=false;
			}
			else
			{
				txtDirectoryName.Enabled=true;
				lblDirectoryName.Enabled=true;
			}
		}

		private void chkSingle_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkServerLayout.Checked==true)
			{
				txtDirectoryName.Enabled=false;
				lblDirectoryName.Enabled=false;
			}
			else
			{
				txtDirectoryName.Enabled=true;
				lblDirectoryName.Enabled=true;
			}
			if(chkSingle.Checked)
				lblDirectoryName.Text="Name:";
		}

		private void chkSeparate_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkServerLayout.Checked==true)
			{
				txtDirectoryName.Enabled=false;
				lblDirectoryName.Enabled=false;
			}
			else
			{
				txtDirectoryName.Enabled=true;
				lblDirectoryName.Enabled=true;
			}
			if(chkSeparate.Checked)
				lblDirectoryName.Text="Sufix:";
		}
	}
}
