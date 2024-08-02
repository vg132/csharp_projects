using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TorrentDisplay
{
	/// <summary>
	/// Summary description for About.
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public About()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			// 
			// About
			// 
			this.AutoScaleDimensions=new SizeF(5, 13);
			this.ClientSize = new System.Drawing.Size(418, 375);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.Text = "About Torrent Display";
			this.Load += new System.EventHandler(this.About_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.About_Paint);

		}
		#endregion

		private void About_Load(object sender, System.EventArgs e)
		{
		}

		private void About_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g=e.Graphics;
			string str="Kalle Anka Heter Jag";
			Font myFont=new Font("Arial",16);
			Rectangle rect=new Rectangle(0,0,350,150);
			SolidBrush myBrush=new SolidBrush(Color.Red);
			Pen myPen=new Pen(myBrush,1);

			Console.WriteLine(g.MeasureString(str,myFont,rect.Width).Height);


			g.DrawString(str,myFont,myBrush,rect);
			g.DrawRectangle(myPen,rect);

			/*
				// Set up string.
				string measureString = "Measure String";
				Font stringFont = new Font("Arial", 16);
				// Set maximum layout size.
				SizeF layoutSize = new SizeF(100.0F, 100.0F);
				// Set string format.
				StringFormat newStringFormat = new StringFormat();
				newStringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
				// Measure string.
				int charactersFitted;
				int linesFilled;
				SizeF stringSize = new SizeF();
				stringSize = e.Graphics.MeasureString(measureString,stringFont,layoutSize,newStringFormat,out charactersFitted,out linesFilled);
				// Draw rectangle representing size of string.
				e.Graphics.DrawRectangle(new Pen(Color.Red, 1),0.0F, 0.0F, stringSize.Width, stringSize.Height);
				// Draw string to screen.
				e.Graphics.DrawString(measureString,stringFont,Brushes.Black, new PointF(0, 0), newStringFormat);
				// Draw output parameters to screen.
				string outString = "chars " + charactersFitted + ", lines " + linesFilled;
				e.Graphics.DrawString(
					outString,
					stringFont,
					Brushes.Black,
					new PointF(100, 0));
					*/
		}
	}
}
