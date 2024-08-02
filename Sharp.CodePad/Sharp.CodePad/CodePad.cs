using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.CodeDom.Compiler;

namespace VGSoftware.Sharp.CodePad
{
	public partial class CodePad : Form
	{
		public CodePad()
		{
			InitializeComponent();

			Setup();
		}

		private void Setup()
		{
			CodeTab ct = new CodeTab();
			ct.Language = Enums.LanguageType.CSharp;
			codeTabControl.TabPages.Add(ct);
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			CodeTab ct = new CodeTab();
			ct.Language = Enums.LanguageType.CSharp;
			codeTabControl.TabPages.Add(ct);
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileInfo file = new FileInfo(openFileDialog.FileName);
				if (file.Exists)
				{
					CodeTab tab = new CodeTab();
					tab.Open(file);
					codeTabControl.TabPages.Add(tab);
					codeTabControl.SelectedTab = tab;
					tab.Language = Enums.LanguageType.CSharp;
				}
			}
		}

		private Process CurrentProcess
		{
			get;
			set;
		}

		private void printToolStripButton_Click(object sender, EventArgs e)
		{
			CompilerResults results = Compiler.Compile(((CodeTab)codeTabControl.SelectedTab).EditorText);
			foreach (string str in results.Output)
			{
				outputConsole.Text += str + "\n";
			}

			CurrentProcess = new Process();
			CurrentProcess.StartInfo.RedirectStandardOutput = true;
			CurrentProcess.StartInfo.FileName = "TestAnka.exe";
			CurrentProcess.StartInfo.UseShellExecute = false;
			CurrentProcess.StartInfo.RedirectStandardInput = true;
			CurrentProcess.StartInfo.RedirectStandardError = true;
			CurrentProcess.Start();
			consoleConsole.OutputStream = CurrentProcess.StandardOutput;
			consoleConsole.InputStream = CurrentProcess.StandardInput;
			errorConsole.OutputStream = CurrentProcess.StandardError;                                      
			consoleConsole.Start();
			errorConsole.Start();
		}
	}
}
