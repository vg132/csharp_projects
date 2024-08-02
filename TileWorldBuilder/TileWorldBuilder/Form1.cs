using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TileWorldBuilder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadTiles();
		}

		private void LoadTiles()
		{
			var directory=new DirectoryInfo(Properties.Settings.Default.TilesDirectory);
			foreach (var file in directory.GetFiles("*.png"))
			{
				var image = new PictureBox();
				image.ImageLocation = file.FullName;
				TileFlowPanel.Controls.Add(image);
				image.SizeMode = PictureBoxSizeMode.StretchImage;
				image.Width = 101;
				image.Height = 171;
				image.BorderStyle = BorderStyle.Fixed3D;
				image.Cursor = Cursors.Hand;
				image.MouseDown += new MouseEventHandler(image_MouseDown);
			}
		}

		void image_MouseDown(object sender, MouseEventArgs e)
		{
			if (sender is PictureBox)
			{
				((PictureBox)sender).DoDragDrop(sender, DragDropEffects.Copy);
			}
		}

		private void MainMenuExitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainMenuTilesDirectoryMenuItem_Click(object sender, EventArgs e)
		{
			var dialog = new FolderBrowserDialog();
			dialog.ShowNewFolderButton = true;
			dialog.Description = "Select tiles directory";
			dialog.SelectedPath = Properties.Settings.Default.TilesDirectory;
			if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Properties.Settings.Default.TilesDirectory = dialog.SelectedPath;
				Properties.Settings.Default.Save();
				LoadTiles();
			}
		}

		private void WorldPanel_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void WorldPanel_DragDrop(object sender, DragEventArgs e)
		{
			var pictureBox = e.Data.GetData(typeof(PictureBox)) as PictureBox;
			if (pictureBox != null)
			{
				var graphics = WorldPanel.CreateGraphics();
				var point = WorldPanel.PointToClient(new Point(e.X, e.Y));
				int x = point.X / 101;
				int y = point.Y / 40;
				graphics.DrawImage(pictureBox.Image, new Point(x * 101, y * 40));
			}
		}

		private void WorldPanel_Paint(object sender, PaintEventArgs e)
		{
			var pen = new Pen(Color.Black);
			for (int i = 1; i < WorldPanel.Width / 101; i++)
			{
				e.Graphics.DrawLine(pen, new Point(101 * i, 0), new Point(101 * i, WorldPanel.Height));
			}
			for (int i = 1; i < WorldPanel.Height / 40; i++)
			{
				e.Graphics.DrawLine(pen, new Point(0, 40 * i), new Point(WorldPanel.Width, 40*i));
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var newWorldForm = new NewWorld();
			if (newWorldForm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
			{
				Application.Exit();
			}
		}
	}
}
