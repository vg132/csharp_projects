using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VGSoftware.GPS.GUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			groupBox1.Paint += new PaintEventHandler(groupBox1_Paint);
			GPX.GPX gpx = GPX.GPX.Load("c:\\temp\\test.gpx");
			double distance = 0.0;
			double speed = 0.0;
			List<GPX.Waypoint> waypoints = gpx.Tracks[0].Tracks[0];
			int i = 0;
			for (; i < waypoints.Count - 1; i++)
			{
				distance += waypoints[i].Distance(waypoints[i+1]);
				speed += Geometry.Speed(waypoints[i], waypoints[i + 1]);
			}
			Console.Write("Distans: {0}", distance);
			Console.Write("Speed: {0}", speed / waypoints.Count);
			ChartTest(waypoints);
			/*
			GPS.Data.GPS g = new VGSoftware.GPS.Data.GPS("Data Source=GPS.sdf");
			Data.User user = new VGSoftware.GPS.Data.User();
			user.Name = "Viktor Gars";
			user.Created = DateTime.Now;
			g.Users.InsertOnSubmit(user);
			g.SubmitChanges();

			var user2 = from u in g.Users
								 where u.Name.StartsWith("Viktor")
								 select u;
			foreach (Data.User u in user2)
			{
				Console.Write(u.Name);
			}*/
		}

		private void ChartTest(List<GPX.Waypoint> waypoints)
		{
			double distance = 0.0;
			chart1.Series.Clear();
			chart1.Series.Add("Elevation");
			chart1.Series.Add("Speed");
			for (int i = 0; i < waypoints.Count - 1; i++)
			{
				distance += waypoints[i].Distance(waypoints[i + 1]);
				chart1.Series["Elevation"].Points.AddXY(Math.Round(distance, 1), waypoints[i].Elevation);
				chart1.Series["Speed"].Points.AddXY(Math.Round(distance, 1), Geometry.Speed(waypoints[i], waypoints[i + 1]));
			}

			// Set fast line chart type
			chart1.Series["Elevation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			chart1.Series["Speed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			chart1.MouseHover += new EventHandler(chart1_MouseHover);
			chart1.MouseMove += new MouseEventHandler(chart1_MouseMove);
			chart1.Move += new EventHandler(chart1_Move);
		}

		void chart1_Move(object sender, EventArgs e)
		{
			
			//Form1.MousePosition
			//Point p = chart1.PointToClient(Form1.MousePosition);
			//chart1.

			//chart1.Printing.PrintPaint(
		}

		void groupBox1_Paint(object sender, PaintEventArgs e)
		{
		}

		void chart1_MouseMove(object sender, MouseEventArgs e)
		{/*
			System.Windows.Forms.DataVisualization.Charting.HitTestResult htr=chart1.HitTest(e.X, e.Y);
			if (htr != null && htr.Series!=null )
			{
				Form1.ActiveForm.Text = ((DataPoint)htr.Object).XValue.ToString();
				htr.Series.Color = Color.GreenYellow;
				// = DateTime.Now.ToString();
			}
			*/
		}

		void chart1_MouseHover(object sender, EventArgs e)
		{
			Form1.ActiveForm.Text = DateTime.Now.ToString();
			//chart1.Printing.PrintPaint(groupBox1.  e.Graphics, new Rectangle(0, 0, groupBox1.Width, groupBox1.Height));
		}
	}
}
