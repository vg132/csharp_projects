using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections;

namespace VGSoftware.GPSLogger.UI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			TripsTreeView.TreeViewNodeSorter = new TreeNodeSorter();

			this.Hide();
			UserSelectionForm userSelectionForm = new UserSelectionForm();
			if (userSelectionForm.ShowDialog() == DialogResult.OK && UserManager.Current.CurrentUser != null)
			{
				this.Text = string.Format("GPS Logger - {0}", UserManager.Current.CurrentUser.UserName);
				BuildTree();
			}
			else
			{
				Application.Exit();
			}
		}

		private TreeNode CreateGPXNode(GPXInformation gpx)
		{
			TreeNode node = null;
			if (gpx != null)
			{
				node = new TreeNode(gpx.GetStartTime(0).ToString("yyyy-MM-dd HH:mm"));
				node.Tag = gpx;
				node.Name = node.Text;
				node.ImageIndex = 2;
				node.SelectedImageIndex = 2;
			}
			return node;
		}

		private TreeNode FindOrCreateParentNode(TreeNode root, GPXInformation gpx)
		{
			TreeNode node = null;
			if (gpx != null)
			{
				node = root.Nodes.FindFirstNode(gpx.GetStartTime(0).ToString("yyyy-MM"), true);
				if (node == null)
				{
					TreeNode newNode = null;
					node = root.Nodes.FindFirstNode(gpx.GetStartTime(0).ToString("yyyy"), true);
					if (node == null)
					{
						newNode = new TreeNode(gpx.GetStartTime(0).ToString("yyyy"));
						newNode.Name = newNode.Text;
						newNode.ImageIndex = 0;
						newNode.SelectedImageIndex = 1;
						root.Nodes.Add(newNode);
						node = newNode;
					}
					newNode = new TreeNode(gpx.GetStartTime(0).ToString("MMMM"));
					newNode.Name = gpx.GetStartTime(0).ToString("yyyy-MM");
					newNode.ImageIndex = 0;
					newNode.SelectedImageIndex = 1;
					node.Nodes.Add(newNode);
					node = newNode;
				}
			}
			return node;
		}

		private void AddGPXNode(TreeNode root, GPXInformation gpx)
		{
			if (gpx != null)
			{
				TreeNode parent= FindOrCreateParentNode(root, gpx);
				if (parent != null)
				{
					TreeNode gpxNode = CreateGPXNode(gpx);
					if (gpxNode != null)
					{
						parent.Nodes.Add(gpxNode);
					}
				}
			}
		}

		private void BuildTree()
		{
			TripsTreeView.Nodes.Clear();
			TreeNode root = new TreeNode(UserManager.Current.CurrentUser.UserName);
			root.ImageIndex = 0;
			root.SelectedImageIndex = 1;
			TripsTreeView.Nodes.Add(root);
			
			foreach (GPXParser.GPX gpx in UserManager.Current.CurrentUser.Trips)
			{
				GPXInformation gpxInformation = new GPXInformation(gpx);
				AddGPXNode(root, gpxInformation);
			}
			root.Expand();
		}

		private DateTime GetDateFromGPX(GPXParser.GPX gpx)
		{
			DateTime date = DateTime.Now;
			if (gpx.Metadata.Time != DateTime.MinValue)
			{
				date = gpx.Metadata.Time;
			}
			else if (gpx.Tracks.Count() > 0 && gpx.Tracks[0].Segments.Count > 0 && gpx.Tracks[0].Segments[0].Count()>0 &&
				gpx.Tracks[0].Segments[0][0].Time != DateTime.MinValue)
			{
				date = gpx.Tracks[0].Segments[0][0].Time;
			}
			return date;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void TripsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			GPXInformation gpx = e.Node.Tag as GPXInformation;
			if (gpx != null)
			{
				StartTimeLabel.Text = gpx.GetStartTime(0).ToString();
				EndTimeLabel.Text = gpx.GetEndTime(0).ToString();
				TotalTimeLabel.Text = string.Format("{0}:{1}.{2}", gpx.GetTotalTime(0).Hours, gpx.GetTotalTime(0).Minutes, gpx.GetTotalTime(0).Seconds);
				DistanceLabel.Text = string.Format("{0} kilometers", gpx.GetDistance(0));
				AverageSpeedLabel.Text = string.Format("{0} km/h", gpx.GetAverageSpeed(0));
			}
			else
			{
				List<GPXInformation> gpxInformation = new List<GPXInformation>();
				FindGPXInformation(e.Node, gpxInformation);
				double speed = 0.0;
				double distance = 0.0;
				TimeSpan ts = new TimeSpan(0);
				foreach (GPXInformation gpxInfo in gpxInformation)
				{
					distance += gpxInfo.GetDistance(0);
					speed += gpxInfo.GetAverageSpeed(0);
					ts += gpxInfo.GetTotalTime(0);
				}
				TotalTimeLabel.Text = string.Format("{0}:{1}.{2}", ts.Hours, ts.Minutes, ts.Seconds);
				DistanceLabel.Text = string.Format("{0} kilometers", distance);
				AverageSpeedLabel.Text = string.Format("{0} km/h", (speed / gpxInformation.Count));
			}
		}

		private void FindGPXInformation(TreeNode node, List<GPXInformation> gpxInformation)
		{
			GPXInformation gpx = node.Tag as GPXInformation;
			if (gpx != null)
			{
				gpxInformation.Add(gpx);
			}
			else
			{
				foreach (TreeNode child in node.Nodes)
				{
					FindGPXInformation(child, gpxInformation);
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserSelectionForm userSelectionForm = new UserSelectionForm();
			if (userSelectionForm.ShowDialog() == DialogResult.OK)
			{
				this.Text = string.Format("GPS Logger - {0}", UserManager.Current.CurrentUser.UserName);
				BuildTree();
			}
		}

		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "GPX file (*.gpx)|*.gpx";
			openFileDialog.Title = "Add GPX files";
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string fileName in openFileDialog.FileNames)
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (fileInfo.Exists)
					{
						FileInfo newFileInfo = new FileInfo(string.Format("{0}\\{1}", UserManager.Current.CurrentUser.GPXDirectory, fileInfo.Name));
						if (newFileInfo.Exists)
						{
							if (MessageBox.Show(string.Format("File \"{0}\" already exists in the destination folder, overwrite the file?", fileInfo.Name), "Overwrite file", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
							{
								fileInfo.CopyTo(newFileInfo.FullName, true);
								AddGPXNode(TripsTreeView.TopNode, new GPXInformation(GPXParser.Parser.Instance.ParseFile(newFileInfo.FullName)));
							}
						}
						else
						{
							fileInfo.CopyTo(newFileInfo.FullName, false);
							AddGPXNode(TripsTreeView.TopNode, new GPXInformation(GPXParser.Parser.Instance.ParseFile(newFileInfo.FullName)));
						}
					}
				}
				TripsTreeView.Sort();
			}
		}
	}

	internal static class TreeNodeCollectionExtensions
	{
		public static TreeNode FindFirstNode(this TreeNodeCollection collection, string name, bool searchChildren)
		{
			TreeNode[] nodes = collection.Find(name, searchChildren);
			if (nodes != null && nodes.Count() > 0)
			{
				return nodes[0];
			}
			return null;
		}
	}

	class TreeNodeSorter : IComparer
	{
		public int Compare(object x, object y)
		{
			TreeNode node1 = x as TreeNode;
			TreeNode node2 = y as TreeNode;
			if (node1 != null && node2 != null)
			{
				return node1.Name.CompareTo(node2.Name);
			}
			return 0;
		}
	}
}
