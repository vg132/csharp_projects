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
using VGSoftware.Sharp.CodePad.Controls;

namespace VGSoftware.Sharp.CodePad.Forms
{
	public partial class CodePad : Form
	{
		public CodePad()
		{
			InitializeComponent();
			SetupForm();
		}

		private void SetupForm()
		{
			CodeTab ct = new CodeTab();
			ct.Language = Enums.LanguageType.CSharp;
			codeTabControl.TabPages.Add(ct);
		}

		private void OpenDocument()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*|";
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

		private bool SaveDocument(bool forceNewFile)
		{
			CodeTab codeTab = codeTabControl.SelectedTab;
			if (codeTab != null)
			{
				if (forceNewFile || codeTab.CurrentFile == null)
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						codeTab.Save(new FileInfo(saveFileDialog.FileName));
						return true;
					}
				}
				else if (codeTab.CurrentFile != null)
				{
					codeTab.Save();
					return true;
				}
			}
			return false;
		}

		private void ResetConsoles()
		{
			outputConsole.Text = string.Empty;
			errorConsole.Text = string.Empty;
			consoleConsole.Text = string.Empty;
			errorListListView.Items.Clear();
		}

		private void Stop()
		{
			if (!CurrentProcess.HasExited)
			{
				CurrentProcess.Kill();
			}
		}

		private void Run()
		{
			ResetConsoles();

			CompilerResults results = Compiler.Compile(((CodeTab)codeTabControl.SelectedTab).EditorText);

			if (results.Output.Count > 0)
			{
				foreach (string str in results.Output)
				{
					outputConsole.Text += str + "\r\n";
				}
				consoleTabControl.SelectedTab = outputTabPage;
			}
			if (results.Errors.Count > 0)
			{
				foreach (CompilerError error in results.Errors)
				{
					ListViewItem item = new ListViewItem(error.ErrorText);
					item.SubItems.Add(error.Line.ToString());
					item.SubItems.Add(error.Column.ToString());
					item.ImageIndex = error.IsWarning ? 2 : 1;
					errorListListView.Items.Add(item);
				}
				consoleTabControl.SelectedTab = errorListTabPage;
			}
			else
			{
				CurrentProcess = new Process();
				CurrentProcess.StartInfo.RedirectStandardOutput = true;
				CurrentProcess.StartInfo.FileName = results.PathToAssembly;
				CurrentProcess.StartInfo.UseShellExecute = false;
				CurrentProcess.StartInfo.CreateNoWindow = true;
				CurrentProcess.StartInfo.RedirectStandardInput = true;
				CurrentProcess.StartInfo.RedirectStandardError = true;
				CurrentProcess.Exited += new EventHandler(CurrentProcess_Exited);
				CurrentProcess.EnableRaisingEvents = true;
				CurrentProcess.Start();
				stopToolStripButton.Enabled = true;
				consoleConsole.OutputStream = CurrentProcess.StandardOutput;
				consoleConsole.InputStream = CurrentProcess.StandardInput;
				errorConsole.OutputStream = CurrentProcess.StandardError;
				consoleConsole.Start();
				errorConsole.Start();
				consoleTabControl.SelectedTab = consoleTabPage;
			}
		}

		private void CurrentProcess_Exited(object sender, EventArgs e)
		{
			MethodInvoker method = delegate
			{
				stopToolStripButton.Enabled = false;
			};

			if (InvokeRequired)
			{
				BeginInvoke(method);
			}
			else
			{
				method.Invoke();
			}
		}

		private void NewDocument()
		{
			CodeTab codeTab = new CodeTab();
			codeTab.Language = Enums.LanguageType.CSharp;
			codeTabControl.TabPages.Add(codeTab);
			codeTabControl.SelectedTab = codeTab;
		}

		private bool CloseTab(int index)
		{
			if (codeTabControl.TabPages.Count > index)
			{
				DialogResult result = DialogResult.None;
				if (codeTabControl.TabPages[index].IsTextChanged)
				{
					result = MessageBox.Show(string.Format("Save changes to '{0}'?", codeTabControl.TabPages[index].TabName), "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						if (!SaveDocument(false))
						{
							result = DialogResult.Cancel;
						}
					}
				}
				if (result != DialogResult.Cancel)
				{
					codeTabControl.TabPages.RemoveAt(index);
					return true;
				}
			}
			return false;
		}

		#region Menubar

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			NewDocument();
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			OpenDocument();
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			SaveDocument(false);
		}

		private void stopToolStripButton_Click(object sender, EventArgs e)
		{
			Stop();
		}

		private void runToolStripButton_Click(object sender, EventArgs e)
		{
			Run();
		}

		#endregion

		private Process CurrentProcess
		{
			get;
			set;
		}

		#region Menu

		#region File Menu

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CloseTab(codeTabControl.SelectedIndex);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewDocument();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveDocument(false);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveDocument(true);
		}

		#endregion

		private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReferencesForm rf = new ReferencesForm();
			rf.ShowDialog();
		}

		#endregion

		private void CodePad_FormClosing(object sender, FormClosingEventArgs e)
		{
			for (int index = codeTabControl.TabPages.Count - 1; index >= 0; index--)
			{
				if (!CloseTab(index))
				{
					e.Cancel = true;
					break;
				}
			}
		}
	}
}
