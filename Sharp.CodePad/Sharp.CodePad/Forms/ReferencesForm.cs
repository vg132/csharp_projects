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

namespace VGSoftware.Sharp.CodePad.Forms
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
			foreach (string path in Settings.Instance.References)
			{
				AddAssembly(path);
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
			Settings.Instance.References.Clear();
			foreach (ListViewItem item in referencesListView.Items)
			{
				Settings.Instance.References.Add(item.SubItems[2].Text);
			}
			Settings.Instance.Save();
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
