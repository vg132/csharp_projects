using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VGSoftware.Sharp.CodePad.Controls
{
	public class Console : TextBox
	{
		public Console()
			: base()
		{
			this.Multiline = true;
			this.KeyPress += new KeyPressEventHandler(Console_KeyPress);
		}

		private void Console_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (InputStream != null)
			{
				if ((int)e.KeyChar == 13)
				{
					InputStream.WriteLine();
				}
				else
				{
					InputStream.Write(e.KeyChar);
				}
				InputStream.Flush();
			}
		}

		public void Start()
		{
			this.Text = string.Empty;
			if (OutputStream != null)
			{
				MethodInvoker readOutputStream = new MethodInvoker(ReadOutput);
				readOutputStream.BeginInvoke(null, null);
			}
		}

		public void ReadOutput()
		{
			int value;
			while ((value = OutputStream.Read()) != -1)
			{
				Invoke((MethodInvoker)delegate
				{
					this.Text += (char)value;
				});
			}
		}

		public StreamWriter InputStream
		{
			get;
			set;
		}

		public StreamReader OutputStream
		{
			get;
			set;
		}
	}
}
