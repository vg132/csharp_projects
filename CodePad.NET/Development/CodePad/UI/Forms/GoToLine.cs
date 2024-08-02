using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VGSoftware.CodePad.UI.Forms
{
	public partial class GoToLine : Form
	{
		public GoToLine(int lines)
		{
			InitializeComponent();
			gotoLineLabel.Text = string.Format("Line number (1 - {0}):", lines);
		}

		public int Line
		{
			get;
			set;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			int line;
			if (int.TryParse(goToLineMaskedTextBox.Text, out line))
			{
				Line = line;
			}
		}
	}
}
