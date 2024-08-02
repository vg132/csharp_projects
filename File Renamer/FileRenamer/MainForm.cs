using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace FileRenamer
{
	public partial class MainForm : Form
	{
		private static Regex reg1 = new Regex("[s|S]{0,1}[\\d]{1,2}[e|E|X|x|\\.]{0,1}[\\d]{2}");
		private static Regex reg2 = new Regex("\\D");
		private AboutForm _aboutForm;

		public MainForm()
		{
			InitializeComponent();
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			if (BrowseForFoldersDialog.ShowDialog() == DialogResult.OK)
			{
				PathTextBox.Text = BrowseForFoldersDialog.SelectedPath;
				ListFiles();
			}
		}

		private void ListFiles()
		{
			FileListBox.Items.Clear();
			NewFileListBox.Items.Clear();
			DirectoryInfo di = new DirectoryInfo(PathTextBox.Text);
			foreach (FileInfo fi in di.GetFiles())
			{
				if(Properties.Settings.Default.FileExtensions.Contains(fi.Extension))
				{
					FileListBox.Items.Add(fi.Name);
					string newFileName = GetNewFileName(fi.Name);
					if (string.IsNullOrEmpty(newFileName))
					{
						NewFileListBox.Items.Add("Unable to rename", false);
					}
					else if (NewFileListBox.Items.Contains(newFileName))
					{
						NewFileListBox.Items.Add(newFileName, false);
					}
					else if (string.Compare(newFileName, fi.Name, false) == 0)
					{
						NewFileListBox.Items.Add(newFileName, false);
					}
					else
					{
						NewFileListBox.Items.Add(newFileName, true);
					}
				}
			}
		}

		private void NewFileNameTextBox_TextChanged(object sender, EventArgs e)
		{
			ListFiles();
		}

		private string GetNewFileName(string name)
		{
			Match m = reg1.Match(name);
			if (m.Success)
			{
				string number = m.Value;
				number = reg2.Replace(number, "");
				number = number.TrimStart(new char[1] { '0' });
				if (number.Length == 3)
				{
					return NewFileNameTextBox.Text + " s0" + number[0] + "e" + number[1] + number[2] + name.Substring(name.LastIndexOf('.'));
				}
				else
				{
					return NewFileNameTextBox.Text + " s" + number[0] + number[1] + "e" + number[2] + number[3] + name.Substring(name.LastIndexOf('.'));
				}
			}
			return string.Empty;
		}

		private void RenameButton_Click(object sender, EventArgs e)
		{
			this.UseWaitCursor = true;
			try
			{
				foreach (int i in NewFileListBox.CheckedIndices)
				{
					FileInfo fi = new FileInfo(PathTextBox.Text + "\\" + FileListBox.Items[i].ToString());
					fi.MoveTo(fi.DirectoryName + "\\" + NewFileListBox.Items[i].ToString());
				}
				MessageBox.Show("All files have been renamed", "File renaming", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
			}
			finally
			{
				this.UseWaitCursor = false;
			}
		}

		private void ExitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AboutMenuItem_Click(object sender, EventArgs e)
		{
			if (_aboutForm == null)
			{
				_aboutForm = new AboutForm();
			}
			_aboutForm.ShowDialog();
		}
	}
}