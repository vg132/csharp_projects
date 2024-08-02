using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VGSoftware.GPSLogger.UI
{
	public partial class UserManagerForm : Form
	{
		public UserManagerForm()
		{
			InitializeComponent();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				UserManager.Current.CreateUser(UserNameTextBox.Text);
				MessageBox.Show("User created", "GPSLogger", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (NiceException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
