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
using VGSoftware.CodePad.Controls;

namespace VGSoftware.CodePad.Forms
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
			this.WindowState = Properties.Settings.Default.WindowState;
			if (!(Properties.Settings.Default.WindowLocation.X == 0 &&
					Properties.Settings.Default.WindowLocation.Y == 0 &&
					Properties.Settings.Default.WindowSize.Width == 0 &&
					Properties.Settings.Default.WindowSize.Height == 0))
			{
				this.Size = Properties.Settings.Default.WindowSize;
				this.StartPosition = FormStartPosition.Manual;
				this.Location = Properties.Settings.Default.WindowLocation;
			}
		}

		private void OpenDocument()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "C# Files (*.cs)|*.cs|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileInfo file = new FileInfo(openFileDialog.FileName);
				if (file.Exists)
				{
					CodeTab tab = new CodeTab();
					tab.Open(file);
					codeTabControl.TabPages.Add(tab);
					codeTabControl.SelectedTab = tab;
					tab.Language = Build.Enums.LanguageType.CSharp;
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
			if (CurrentProcess!=null && !CurrentProcess.HasExited)
			{
				CurrentProcess.Kill();
			}
		}

		private void Run()
		{
			ResetConsoles();

			CompilerResults results = Build.Compiler.Default.Compile(((CodeTab)codeTabControl.SelectedTab).EditorText);

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
				CurrentProcess.StartInfo.FileName = results.PathToAssembly;
				if (Properties.Settings.Default.RedirectInputOutputError)
				{
					CurrentProcess.StartInfo.UseShellExecute = false;
					CurrentProcess.StartInfo.CreateNoWindow = true;
					CurrentProcess.StartInfo.RedirectStandardOutput = true;
					CurrentProcess.StartInfo.RedirectStandardInput = true;
					CurrentProcess.StartInfo.RedirectStandardError = true;
				}
				else
				{
					CurrentProcess.StartInfo.UseShellExecute = true;
				}
				CurrentProcess.Exited += new EventHandler(CurrentProcess_Exited);
				CurrentProcess.EnableRaisingEvents = true;
				CurrentProcess.Start();
				stopToolStripButton.Enabled = true;
				stopToolStripMenuItem.Enabled = true;
				if (Properties.Settings.Default.RedirectInputOutputError)
				{
					consoleConsole.OutputStream = CurrentProcess.StandardOutput;
					consoleConsole.InputStream = CurrentProcess.StandardInput;
					errorConsole.OutputStream = CurrentProcess.StandardError;
					consoleConsole.Start();
					errorConsole.Start();
					consoleTabControl.SelectedTab = consoleTabPage;
				}
			}
		}

		private void CurrentProcess_Exited(object sender, EventArgs e)
		{
			MethodInvoker method = delegate
			{
				stopToolStripButton.Enabled = false;
				stopToolStripMenuItem.Enabled = false;
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
			Base.Template.Template template = null;
			if (!Properties.Settings.Default.ShowNewFileDialog)
			{
				template = Base.Template.Template.LoadTemplate(Properties.Settings.Default.DefaultTemplateFile);
			}
			if (template == null)
			{
				NewFile newFileDialog = new NewFile();
				if (newFileDialog.ShowDialog() == DialogResult.OK)
				{
					template = newFileDialog.SelectedTemplate;
				}
			}
			if (template != null)
			{
				CodeTab codeTab = new CodeTab();
				codeTab.Language = Build.Enums.LanguageType.CSharp;
				codeTab.ContextMenuStrip = textEditorContextMenuStrip;
				codeTabControl.SelectedTab = codeTab;
				codeTab.EditorText = template.Code;
				codeTab.IsTextChanged = false;
				codeTab.TabName = template.FileNameTemplate;
				codeTabControl.TabPages.Add(codeTab);
			}
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

		private void ClearDirectory(string targetDirectory)
		{
			DirectoryInfo outputDirectory = new DirectoryInfo(targetDirectory);
			if (outputDirectory.Exists)
			{
				foreach (DirectoryInfo directory in outputDirectory.GetDirectories())
				{
					directory.Delete(true);
				}
				foreach (FileInfo file in outputDirectory.GetFiles())
				{
					file.Delete();
				}
			}
		}

		private void Cut()
		{
			codeTabControl.SelectedTab.TextEditor.ActiveTextAreaControl.TextArea.ClipboardHandler.Cut(this, new EventArgs());
		}

		private void Copy()
		{
			codeTabControl.SelectedTab.TextEditor.ActiveTextAreaControl.TextArea.ClipboardHandler.Copy(this, new EventArgs());
		}

		private void Paste()
		{
			codeTabControl.SelectedTab.TextEditor.ActiveTextAreaControl.TextArea.ClipboardHandler.Paste(this, new EventArgs());
		}

		private void Undo()
		{
			codeTabControl.SelectedTab.TextEditor.Undo();
		}

		private void Redo()
		{
			codeTabControl.SelectedTab.TextEditor.Redo();
		}

		private void SelectAll()
		{
			codeTabControl.SelectedTab.TextEditor.ActiveTextAreaControl.TextArea.ClipboardHandler.SelectAll(this, new EventArgs());
		}

		private void Delete()
		{
			codeTabControl.SelectedTab.TextEditor.ActiveTextAreaControl.TextArea.ClipboardHandler.Delete(this, new EventArgs());
		}

		private Process CurrentProcess
		{
			get;
			set;
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

		#region Tools Menu

		private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReferencesForm rf = new ReferencesForm();
			rf.ShowDialog();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Options options = new Options();
			options.ShowDialog();
		}

		#endregion

		#endregion

		#region Form Events

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
			if (Properties.Settings.Default.ClearOutputDirectoryOnExit)
			{
				ClearDirectory(Build.Properties.Settings.Default.Compiler_OutputDirectory);
			}
		}

		private void SaveTabs()
		{
			ClearDirectory(Properties.Settings.Default.AutosaveDirectory);

			foreach (CodeTab tab in codeTabControl.TabPages)
			{




			}
		}

		private void CodePad_ResizeEnd(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				Properties.Settings.Default.WindowLocation = this.Location;
				Properties.Settings.Default.WindowSize = this.Size;
				Properties.Settings.Default.Save();
			}
		}

		private void CodePad_SizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState != FormWindowState.Minimized && Properties.Settings.Default.WindowState != this.WindowState)
			{
				Properties.Settings.Default.WindowState = this.WindowState;
				Properties.Settings.Default.Save();
			}
		}

		#endregion

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cut();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Paste();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Copy();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectAll();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Delete();
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Redo();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}

		private void CodePad_Shown(object sender, EventArgs e)
		{
			NewDocument();
		}
	}
}
