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
	public partial class UserSelectionForm : Form
	{
		public UserSelectionForm()
		{
			InitializeComponent();
			ListUsers();
		}

		private void NewUserButton_Click(object sender, EventArgs e)
		{
			double length = 2;
			double height = 1;
			double value = height / length;
			double angle = (Math.Asin(value) * 180) / Math.PI;
			MessageBox.Show(angle.ToString());


			UserManagerForm form = new UserManagerForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				ListUsers();
			}
		}

		private void ListUsers()
		{
			UserListBox.Items.Clear();
			UserManager.Current.Users.ForEach(u => UserListBox.Items.Add(u.UserName));
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			if (UserListBox.SelectedItem != null)
			{
				User user = UserManager.Current.LoadUser(UserListBox.SelectedItem.ToString());
				if (user != null)
				{
					UserManager.Current.CurrentUser = user;
					this.Hide();
				}
			}
		}
	}
}
