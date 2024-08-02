using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VGSoftware.CodePad.Forms
{
	public partial class NewFile : Form
	{
		public NewFile()
		{
			InitializeComponent();
			SetupControls();
		}

		private void SetupControls()
		{
			switch (Properties.Settings.Default.TemplateListView_View)
			{
				case View.LargeIcon:
					largeIconRadioButton.Checked = true;
					templatesListView.View = View.LargeIcon;
					break;
				case View.Details:
					detailViewRadioButton.Checked = true;
					templatesListView.View = View.Details;
					break;
				default:
					smallIconRadioButton.Checked = true;
					templatesListView.View = View.SmallIcon;
					break;
			}
			foreach (string category in Base.Template.TemplateManager.Instance.Categories)
			{
				TreeNode node = new TreeNode(category);
				node.Tag = category;
				categoryTreeView.Nodes.Add(node);
			}
			if (categoryTreeView.Nodes.Count > 0)
			{
				categoryTreeView.SelectedNode = categoryTreeView.Nodes[0];
			}
		}

		private void ListFiles(TreeNode node)
		{
			templatesListView.Items.Clear();
			foreach (Base.Template.Template template in Base.Template.TemplateManager.Instance.GetTemplates(node.Tag.ToString()))
			{
				ListViewItem listItem = new ListViewItem(template.Name);
				listItem.SubItems.Add(template.Author);
				listItem.SubItems.Add(template.FileNameTemplate);
				if (template.IconIndex >= 0 && template.IconIndex < smallTemplateImageList.Images.Count)
				{
					listItem.ImageIndex = template.IconIndex;
				}
				else if (smallTemplateImageList.Images.Count > 0)
				{
					listItem.ImageIndex = 0;
				}
				listItem.Tag = template;
				templatesListView.Items.Add(listItem);
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void categoryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			ListFiles(e.Node);
		}

		public Base.Template.Template SelectedTemplate
		{
			get
			{
				if (templatesListView.SelectedItems.Count > 0)
				{
					return (Base.Template.Template)templatesListView.SelectedItems[0].Tag;
				}
				return null;
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (SelectedTemplate != null)
			{
				Properties.Settings.Default.TemplateListView_View = templatesListView.View;
				this.Close();
			}
		}

		private void templatesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (SelectedTemplate != null)
			{
				descriptionTextBox.Text = SelectedTemplate.Description;
			}
		}

		private void listViewRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			templatesListView.View = View.SmallIcon;
		}

		private void largeIconRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			templatesListView.View = View.LargeIcon;
		}

		private void detailViewRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			templatesListView.View = System.Windows.Forms.View.Details;
		}
	}
}
