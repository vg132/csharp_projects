using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace XFriendsApp
{
	/// <summary>
	/// Summary description for frmOptions.
	/// </summary>
	public class frmOptions : System.Windows.Forms.Form
	{
		private Settings settings=null;

		private System.Windows.Forms.GroupBox grpSounds;
		private System.Windows.Forms.Label lblOfflineSound;
		private System.Windows.Forms.Label lblOnlineSound;
		private System.Windows.Forms.TextBox txtOfflineSound;
		private System.Windows.Forms.TextBox txtOnlineSound;
		private System.Windows.Forms.Label lblErrorPage;
		private System.Windows.Forms.Label lblFriendPage;
		private System.Windows.Forms.Label lblMainPage;
		private System.Windows.Forms.Label lblUpdate;
		private System.Windows.Forms.TrackBar sliUpdate;
		private System.Windows.Forms.GroupBox grpBehavior;
		private System.Windows.Forms.Button btnBrowseOffline;
		private System.Windows.Forms.Button btnBrowseOnline;
		private System.Windows.Forms.TextBox txtPassportLink;
		private System.Windows.Forms.Label lblPassportLink;
		private System.Windows.Forms.Label lblOnlineSuffix;
		private System.Windows.Forms.TextBox txtOnlineSuffix;
		private System.Windows.Forms.TextBox txtOfflineSuffix;
		private System.Windows.Forms.Label lblOfflineSuffix;
		private System.Windows.Forms.TextBox txtLoginErrorPage;
		private System.Windows.Forms.TextBox txtFriendsPage;
		private System.Windows.Forms.TextBox txtMainPage;
		private System.Windows.Forms.Label lblLoginLinkPrefix;
		private System.Windows.Forms.TextBox txtLoginLinkPrefix;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox grpXBoxCom;
		private System.Windows.Forms.CheckBox chkXBoxCom;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmOptions(Settings settings)
		{
			InitializeComponent();

			this.settings=settings;

			txtFriendsPage.Text=settings.FriendsPage;
			txtLoginErrorPage.Text=settings.LoginErrorPage;
			txtLoginLinkPrefix.Text=settings.LoginLinkPrefix;
			txtMainPage.Text=settings.MainPage;
			txtOfflineSound.Text=settings.OfflineSound;
			txtOnlineSound.Text=settings.OnlineSound;
			txtOfflineSuffix.Text=settings.OfflineSuffix;
			txtOnlineSuffix.Text=settings.OnlineSuffix;
			txtPassportLink.Text=settings.PassportLink;
			sliUpdate.Value=((int.Parse(settings.UpdateFrequency)/1000)-30)/10;
			lblUpdate.Text="Update every "+((sliUpdate.Value*10)+30)+" seconds";
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
			this.grpSounds = new System.Windows.Forms.GroupBox();
			this.btnBrowseOffline = new System.Windows.Forms.Button();
			this.btnBrowseOnline = new System.Windows.Forms.Button();
			this.lblOfflineSound = new System.Windows.Forms.Label();
			this.lblOnlineSound = new System.Windows.Forms.Label();
			this.txtOfflineSound = new System.Windows.Forms.TextBox();
			this.txtOnlineSound = new System.Windows.Forms.TextBox();
			this.grpXBoxCom = new System.Windows.Forms.GroupBox();
			this.txtLoginLinkPrefix = new System.Windows.Forms.TextBox();
			this.lblLoginLinkPrefix = new System.Windows.Forms.Label();
			this.txtPassportLink = new System.Windows.Forms.TextBox();
			this.lblPassportLink = new System.Windows.Forms.Label();
			this.lblOnlineSuffix = new System.Windows.Forms.Label();
			this.txtOnlineSuffix = new System.Windows.Forms.TextBox();
			this.txtOfflineSuffix = new System.Windows.Forms.TextBox();
			this.lblOfflineSuffix = new System.Windows.Forms.Label();
			this.lblErrorPage = new System.Windows.Forms.Label();
			this.lblFriendPage = new System.Windows.Forms.Label();
			this.lblMainPage = new System.Windows.Forms.Label();
			this.txtLoginErrorPage = new System.Windows.Forms.TextBox();
			this.txtFriendsPage = new System.Windows.Forms.TextBox();
			this.txtMainPage = new System.Windows.Forms.TextBox();
			this.grpBehavior = new System.Windows.Forms.GroupBox();
			this.lblUpdate = new System.Windows.Forms.Label();
			this.sliUpdate = new System.Windows.Forms.TrackBar();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.chkXBoxCom = new System.Windows.Forms.CheckBox();
			this.grpSounds.SuspendLayout();
			this.grpXBoxCom.SuspendLayout();
			this.grpBehavior.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliUpdate)).BeginInit();
			this.SuspendLayout();
			// 
			// grpSounds
			// 
			this.grpSounds.Controls.Add(this.btnBrowseOffline);
			this.grpSounds.Controls.Add(this.btnBrowseOnline);
			this.grpSounds.Controls.Add(this.lblOfflineSound);
			this.grpSounds.Controls.Add(this.lblOnlineSound);
			this.grpSounds.Controls.Add(this.txtOfflineSound);
			this.grpSounds.Controls.Add(this.txtOnlineSound);
			this.grpSounds.Location = new System.Drawing.Point(8, 148);
			this.grpSounds.Name = "grpSounds";
			this.grpSounds.Size = new System.Drawing.Size(320, 88);
			this.grpSounds.TabIndex = 12;
			this.grpSounds.TabStop = false;
			this.grpSounds.Text = "Sounds";
			// 
			// btnBrowseOffline
			// 
			this.btnBrowseOffline.Location = new System.Drawing.Point(240, 56);
			this.btnBrowseOffline.Name = "btnBrowseOffline";
			this.btnBrowseOffline.TabIndex = 11;
			this.btnBrowseOffline.Text = "Browse...";
			this.btnBrowseOffline.Click += new System.EventHandler(this.btnBrowseOffline_Click);
			// 
			// btnBrowseOnline
			// 
			this.btnBrowseOnline.Location = new System.Drawing.Point(240, 24);
			this.btnBrowseOnline.Name = "btnBrowseOnline";
			this.btnBrowseOnline.TabIndex = 10;
			this.btnBrowseOnline.Text = "Browse...";
			this.btnBrowseOnline.Click += new System.EventHandler(this.btnBrowseOnline_Click);
			// 
			// lblOfflineSound
			// 
			this.lblOfflineSound.Location = new System.Drawing.Point(9, 54);
			this.lblOfflineSound.Name = "lblOfflineSound";
			this.lblOfflineSound.Size = new System.Drawing.Size(100, 16);
			this.lblOfflineSound.TabIndex = 9;
			this.lblOfflineSound.Text = "Friend goes offline:";
			// 
			// lblOnlineSound
			// 
			this.lblOnlineSound.Location = new System.Drawing.Point(9, 22);
			this.lblOnlineSound.Name = "lblOnlineSound";
			this.lblOnlineSound.Size = new System.Drawing.Size(100, 16);
			this.lblOnlineSound.TabIndex = 8;
			this.lblOnlineSound.Text = "Friend goes online:";
			// 
			// txtOfflineSound
			// 
			this.txtOfflineSound.BackColor = System.Drawing.SystemColors.Control;
			this.txtOfflineSound.Enabled = false;
			this.txtOfflineSound.Location = new System.Drawing.Point(112, 54);
			this.txtOfflineSound.Name = "txtOfflineSound";
			this.txtOfflineSound.Size = new System.Drawing.Size(120, 20);
			this.txtOfflineSound.TabIndex = 7;
			this.txtOfflineSound.Text = "";
			// 
			// txtOnlineSound
			// 
			this.txtOnlineSound.BackColor = System.Drawing.SystemColors.Control;
			this.txtOnlineSound.Enabled = false;
			this.txtOnlineSound.Location = new System.Drawing.Point(112, 24);
			this.txtOnlineSound.Name = "txtOnlineSound";
			this.txtOnlineSound.Size = new System.Drawing.Size(120, 20);
			this.txtOnlineSound.TabIndex = 6;
			this.txtOnlineSound.Text = "";
			// 
			// grpXBoxCom
			// 
			this.grpXBoxCom.Controls.Add(this.txtLoginLinkPrefix);
			this.grpXBoxCom.Controls.Add(this.lblLoginLinkPrefix);
			this.grpXBoxCom.Controls.Add(this.txtPassportLink);
			this.grpXBoxCom.Controls.Add(this.lblPassportLink);
			this.grpXBoxCom.Controls.Add(this.lblOnlineSuffix);
			this.grpXBoxCom.Controls.Add(this.txtOnlineSuffix);
			this.grpXBoxCom.Controls.Add(this.txtOfflineSuffix);
			this.grpXBoxCom.Controls.Add(this.lblOfflineSuffix);
			this.grpXBoxCom.Controls.Add(this.lblErrorPage);
			this.grpXBoxCom.Controls.Add(this.lblFriendPage);
			this.grpXBoxCom.Controls.Add(this.lblMainPage);
			this.grpXBoxCom.Controls.Add(this.txtLoginErrorPage);
			this.grpXBoxCom.Controls.Add(this.txtFriendsPage);
			this.grpXBoxCom.Controls.Add(this.txtMainPage);
			this.grpXBoxCom.Enabled = false;
			this.grpXBoxCom.Location = new System.Drawing.Point(8, 248);
			this.grpXBoxCom.Name = "grpXBoxCom";
			this.grpXBoxCom.Size = new System.Drawing.Size(320, 200);
			this.grpXBoxCom.TabIndex = 13;
			this.grpXBoxCom.TabStop = false;
			this.grpXBoxCom.Text = "XBox.com         .";
			// 
			// txtLoginLinkPrefix
			// 
			this.txtLoginLinkPrefix.Location = new System.Drawing.Point(105, 48);
			this.txtLoginLinkPrefix.Name = "txtLoginLinkPrefix";
			this.txtLoginLinkPrefix.Size = new System.Drawing.Size(207, 20);
			this.txtLoginLinkPrefix.TabIndex = 32;
			this.txtLoginLinkPrefix.Text = "textBox7";
			// 
			// lblLoginLinkPrefix
			// 
			this.lblLoginLinkPrefix.Location = new System.Drawing.Point(9, 50);
			this.lblLoginLinkPrefix.Name = "lblLoginLinkPrefix";
			this.lblLoginLinkPrefix.Size = new System.Drawing.Size(90, 16);
			this.lblLoginLinkPrefix.TabIndex = 31;
			this.lblLoginLinkPrefix.Text = "Login link prefix:";
			// 
			// txtPassportLink
			// 
			this.txtPassportLink.Location = new System.Drawing.Point(105, 24);
			this.txtPassportLink.Name = "txtPassportLink";
			this.txtPassportLink.Size = new System.Drawing.Size(207, 20);
			this.txtPassportLink.TabIndex = 30;
			this.txtPassportLink.Text = "textBox6";
			// 
			// lblPassportLink
			// 
			this.lblPassportLink.Location = new System.Drawing.Point(9, 26);
			this.lblPassportLink.Name = "lblPassportLink";
			this.lblPassportLink.Size = new System.Drawing.Size(90, 16);
			this.lblPassportLink.TabIndex = 29;
			this.lblPassportLink.Text = "Passport link:";
			// 
			// lblOnlineSuffix
			// 
			this.lblOnlineSuffix.Location = new System.Drawing.Point(9, 74);
			this.lblOnlineSuffix.Name = "lblOnlineSuffix";
			this.lblOnlineSuffix.Size = new System.Drawing.Size(90, 16);
			this.lblOnlineSuffix.TabIndex = 28;
			this.lblOnlineSuffix.Text = "Online suffix:";
			// 
			// txtOnlineSuffix
			// 
			this.txtOnlineSuffix.Location = new System.Drawing.Point(105, 72);
			this.txtOnlineSuffix.Name = "txtOnlineSuffix";
			this.txtOnlineSuffix.Size = new System.Drawing.Size(207, 20);
			this.txtOnlineSuffix.TabIndex = 27;
			this.txtOnlineSuffix.Text = "textBox2";
			// 
			// txtOfflineSuffix
			// 
			this.txtOfflineSuffix.Location = new System.Drawing.Point(105, 96);
			this.txtOfflineSuffix.Name = "txtOfflineSuffix";
			this.txtOfflineSuffix.Size = new System.Drawing.Size(207, 20);
			this.txtOfflineSuffix.TabIndex = 26;
			this.txtOfflineSuffix.Text = "textBox1";
			// 
			// lblOfflineSuffix
			// 
			this.lblOfflineSuffix.Location = new System.Drawing.Point(9, 98);
			this.lblOfflineSuffix.Name = "lblOfflineSuffix";
			this.lblOfflineSuffix.Size = new System.Drawing.Size(90, 16);
			this.lblOfflineSuffix.TabIndex = 25;
			this.lblOfflineSuffix.Text = "Offline suffix:";
			// 
			// lblErrorPage
			// 
			this.lblErrorPage.Location = new System.Drawing.Point(9, 170);
			this.lblErrorPage.Name = "lblErrorPage";
			this.lblErrorPage.Size = new System.Drawing.Size(90, 16);
			this.lblErrorPage.TabIndex = 24;
			this.lblErrorPage.Text = "Login error page:";
			// 
			// lblFriendPage
			// 
			this.lblFriendPage.Location = new System.Drawing.Point(9, 146);
			this.lblFriendPage.Name = "lblFriendPage";
			this.lblFriendPage.Size = new System.Drawing.Size(90, 16);
			this.lblFriendPage.TabIndex = 23;
			this.lblFriendPage.Text = "Friends page:";
			// 
			// lblMainPage
			// 
			this.lblMainPage.Location = new System.Drawing.Point(9, 122);
			this.lblMainPage.Name = "lblMainPage";
			this.lblMainPage.Size = new System.Drawing.Size(90, 16);
			this.lblMainPage.TabIndex = 22;
			this.lblMainPage.Text = "Main page:";
			// 
			// txtLoginErrorPage
			// 
			this.txtLoginErrorPage.Location = new System.Drawing.Point(105, 168);
			this.txtLoginErrorPage.Name = "txtLoginErrorPage";
			this.txtLoginErrorPage.Size = new System.Drawing.Size(207, 20);
			this.txtLoginErrorPage.TabIndex = 21;
			this.txtLoginErrorPage.Text = "textBox5";
			// 
			// txtFriendsPage
			// 
			this.txtFriendsPage.Location = new System.Drawing.Point(105, 144);
			this.txtFriendsPage.Name = "txtFriendsPage";
			this.txtFriendsPage.Size = new System.Drawing.Size(207, 20);
			this.txtFriendsPage.TabIndex = 20;
			this.txtFriendsPage.Text = "textBox4";
			// 
			// txtMainPage
			// 
			this.txtMainPage.Location = new System.Drawing.Point(105, 120);
			this.txtMainPage.Name = "txtMainPage";
			this.txtMainPage.Size = new System.Drawing.Size(207, 20);
			this.txtMainPage.TabIndex = 19;
			this.txtMainPage.Text = "textBox3";
			// 
			// grpBehavior
			// 
			this.grpBehavior.Controls.Add(this.lblUpdate);
			this.grpBehavior.Controls.Add(this.sliUpdate);
			this.grpBehavior.Location = new System.Drawing.Point(8, 8);
			this.grpBehavior.Name = "grpBehavior";
			this.grpBehavior.Size = new System.Drawing.Size(320, 128);
			this.grpBehavior.TabIndex = 14;
			this.grpBehavior.TabStop = false;
			this.grpBehavior.Text = "Behavior";
			// 
			// lblUpdate
			// 
			this.lblUpdate.Location = new System.Drawing.Point(8, 24);
			this.lblUpdate.Name = "lblUpdate";
			this.lblUpdate.Size = new System.Drawing.Size(160, 16);
			this.lblUpdate.TabIndex = 3;
			this.lblUpdate.Text = "label1";
			// 
			// sliUpdate
			// 
			this.sliUpdate.Location = new System.Drawing.Point(8, 40);
			this.sliUpdate.Maximum = 60;
			this.sliUpdate.Name = "sliUpdate";
			this.sliUpdate.Size = new System.Drawing.Size(160, 37);
			this.sliUpdate.TabIndex = 2;
			this.sliUpdate.TickFrequency = 6;
			this.sliUpdate.Scroll += new System.EventHandler(this.sliUpdate_Scroll);
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(253, 456);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(8, 456);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "Cancel";
			// 
			// chkXBoxCom
			// 
			this.chkXBoxCom.Location = new System.Drawing.Point(80, 248);
			this.chkXBoxCom.Name = "chkXBoxCom";
			this.chkXBoxCom.Size = new System.Drawing.Size(160, 16);
			this.chkXBoxCom.TabIndex = 35;
			this.chkXBoxCom.Text = "Yes, I know what I\'m doing!";
			this.chkXBoxCom.CheckedChanged += new System.EventHandler(this.chkXBoxCom_CheckedChanged);
			// 
			// frmOptions
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 487);
			this.Controls.Add(this.chkXBoxCom);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.grpBehavior);
			this.Controls.Add(this.grpXBoxCom);
			this.Controls.Add(this.grpSounds);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmOptions";
			this.Text = "XFriend Settings";
			this.grpSounds.ResumeLayout(false);
			this.grpXBoxCom.ResumeLayout(false);
			this.grpBehavior.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sliUpdate)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			settings.FriendsPage=txtFriendsPage.Text;
			settings.LoginErrorPage=txtLoginErrorPage.Text;
			settings.LoginLinkPrefix=txtLoginLinkPrefix.Text;
			settings.MainPage=txtMainPage.Text;
			settings.OfflineSound=txtOfflineSound.Text;
			settings.OnlineSound=txtOnlineSound.Text;
			settings.OfflineSuffix=txtOfflineSuffix.Text;
			settings.OnlineSuffix=txtOnlineSuffix.Text;
			settings.PassportLink=txtPassportLink.Text;
			settings.UpdateFrequency=(((sliUpdate.Value*10)+30)*1000)+"";
		}

		private void chkXBoxCom_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkXBoxCom.Checked)
				grpXBoxCom.Enabled=true;
			else
				grpXBoxCom.Enabled=false;
		}

		private void sliUpdate_Scroll(object sender, System.EventArgs e)
		{
			lblUpdate.Text="Update every "+((sliUpdate.Value*10)+30)+" seconds";
		}

		private void btnBrowseOnline_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd=new OpenFileDialog();
			ofd.Filter="Wave files (*.wav)|*.wav";
			if(ofd.ShowDialog()==DialogResult.OK)
			{
				txtOnlineSound.Text=ofd.FileName;
			}
		}

		private void btnBrowseOffline_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd=new OpenFileDialog();
			ofd.Filter="Wave files (*.wav)|*.wav";
			if(ofd.ShowDialog()==DialogResult.OK)
			{
				txtOfflineSound.Text=ofd.FileName;
			}
		}
	}
}
