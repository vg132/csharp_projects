using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace VGSoftware.CodePad.Forms
{
	public partial class ReferencesForm : Form
	{
		public ReferencesForm()
		{
			InitializeComponent();
			SetupForm();
		}

		private void SetupForm()
		{
			if (Build.Properties.Settings.Default.References != null)
			{
				foreach (string path in Build.Properties.Settings.Default.References)
				{
					AddAssembly(path);
				}
			}
		}

		private bool AddAssembly(string path)
		{
			try
			{
				Assembly assembly = Assembly.ReflectionOnlyLoadFrom(path);
				ListViewItem item = new ListViewItem(assembly.GetName().Name);
				item.SubItems.Add(assembly.GetName().Version.ToString());
				item.SubItems.Add(assembly.Location);
				referencesListView.Items.Add(item);
			}
			catch
			{
				return false;
			}
			return true;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if ( Build.Properties.Settings.Default.References != null)
			{
				Build.Properties.Settings.Default.References.Clear();
			}
			else
			{
				Build.Properties.Settings.Default.References = new System.Collections.Specialized.StringCollection();
			}
			foreach (ListViewItem item in referencesListView.Items)
			{
				Build.Properties.Settings.Default.References.Add(item.SubItems[2].Text);
			}
			Build.Properties.Settings.Default.Save();
			this.Close();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Add Reference";
			openFileDialog.Filter = "Dll Files (*.dll)|*.dll|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				AddAssembly(openFileDialog.FileName);
			}
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in referencesListView.SelectedItems)
			{
				item.Remove();
			}
		}
	}
}
