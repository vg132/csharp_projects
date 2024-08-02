using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CSettings = VGSoftware.CodePad.Controls.Properties.Settings;

namespace VGSoftware.CodePad.Forms
{
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
			SetupForm();
			LoadSettings();
		}

		private void SetupForm()
		{
			indentStyleComboBox.Items.Clear();
			foreach (string name in Enum.GetNames(typeof(ICSharpCode.TextEditor.Document.IndentStyle)))
			{
				indentStyleComboBox.Items.Add(name);
			}
			netVersionComboBox.Items.Clear();
			foreach (string name in Enum.GetNames(typeof(Build.Enums.CompilerVersionType)))
			{
				netVersionComboBox.Items.Add(name.Replace("_", "."));
			}
			defaultTemplateComboBox.Items.Clear();
			foreach (Base.Template.Template template in Base.Template.TemplateManager.Instance.Templates)
			{
				defaultTemplateComboBox.Items.Add(template);
			}
		}

		#region Load Settings

		private void LoadSettings()
		{
			LoadProgramSettings();
			LoadTextEditorSettings();
			LoadCompilerSettings();
		}

		private void LoadProgramSettings()
		{
			showNewFileDialogCheckBox.Checked = Properties.Settings.Default.ShowNewFileDialog;
			Base.Template.Template template = Base.Template.Template.LoadTemplate(Properties.Settings.Default.DefaultTemplateFile);
			if (template != null)
			{
				for(int i=0;i<defaultTemplateComboBox.Items.Count;i++)
				{
					Base.Template.Template innerTemplate = defaultTemplateComboBox.Items[i] as Base.Template.Template;
					if (innerTemplate != null)
					{
						if (innerTemplate.Name == template.Name)
						{
							defaultTemplateComboBox.SelectedIndex = i;
							break;
						}
					}
				}
			}
			clearOutputOnExitCheckBox.Checked = Properties.Settings.Default.ClearOutputDirectoryOnExit;
			redirectInputOutputErrorCheckBox.Checked = Properties.Settings.Default.RedirectInputOutputError;
		}

		private void LoadTextEditorSettings()
		{
			indentStyleComboBox.SelectedItem = Enum.GetName(typeof(ICSharpCode.TextEditor.Document.IndentStyle), CSettings.Default.TextEditor_IndentStyle);
			showTabCheckBox.Checked = CSettings.Default.TextEditor_ShowTabs;
			showSpacesCheckBox.Checked = CSettings.Default.TextEditor_ShowSpaces;
			showEndOfLineCheckBox.Checked = CSettings.Default.TextEditor_ShowEndOfLine;
			showLineNumbersCheckBox.Checked = CSettings.Default.TextEditor_ShowLineNumbers;
			highlightSelectedLineCheckBox.Checked = CSettings.Default.TextEditor_HighlightSelectedLine;
			tabSizeTextBox.Text = CSettings.Default.TextEditor_TabSize.ToString();
			if (CSettings.Default.TextEditor_KeepTabs)
			{
				keepTabsRadioButton.Checked = true;
			}
			else
			{
				insertSpacesRadioButton.Checked = true;
			}
		}

		private void LoadCompilerSettings()
		{
			netVersionComboBox.SelectedItem = Enum.GetName(typeof(Build.Enums.CompilerVersionType), Build.Properties.Settings.Default.Compiler_NetVersion).Replace("_", ".");
			warningLevelComboBox.SelectedItem = Build.Properties.Settings.Default.Compiler_WarningLevel.ToString();
			warningsAsErrorCheckBox.Checked = Build.Properties.Settings.Default.Compiler_WarningsAsError;
			debugCheckBox.Checked = Build.Properties.Settings.Default.Compiler_DebugAssembly;
			outputDirectoryTextBox.Text = Build.Properties.Settings.Default.Compiler_OutputDirectory;
		}

		#endregion

		#region Save Settings

		private void SaveSettings()
		{
			SaveProgramSettings();
			SaveTextEditorSettings();
			SaveCompilerSettings();
		}

		private void SaveProgramSettings()
		{
			Properties.Settings.Default.ShowNewFileDialog = showNewFileDialogCheckBox.Checked;
			if (showNewFileDialogCheckBox.Checked)
			{
				Properties.Settings.Default.DefaultTemplateFile = string.Empty;
			}
			else
			{
				Properties.Settings.Default.DefaultTemplateFile = ((Base.Template.Template)defaultTemplateComboBox.SelectedItem).FileName;
			}
			Properties.Settings.Default.ClearOutputDirectoryOnExit = clearOutputOnExitCheckBox.Checked;
			Properties.Settings.Default.RedirectInputOutputError = redirectInputOutputErrorCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void SaveTextEditorSettings()
		{
			CSettings.Default.TextEditor_IndentStyle = (ICSharpCode.TextEditor.Document.IndentStyle)Enum.Parse(typeof(ICSharpCode.TextEditor.Document.IndentStyle), Convert.ToString(indentStyleComboBox.SelectedItem));
			CSettings.Default.TextEditor_ShowTabs = showTabCheckBox.Checked;
			CSettings.Default.TextEditor_ShowSpaces = showSpacesCheckBox.Checked;
			CSettings.Default.TextEditor_ShowEndOfLine = showEndOfLineCheckBox.Checked;
			CSettings.Default.TextEditor_ShowLineNumbers = showLineNumbersCheckBox.Checked;
			CSettings.Default.TextEditor_HighlightSelectedLine = highlightSelectedLineCheckBox.Checked;
			CSettings.Default.TextEditor_TabSize = Convert.ToInt32(tabSizeTextBox.Text);
			CSettings.Default.TextEditor_KeepTabs = keepTabsRadioButton.Checked;
		}

		private void SaveCompilerSettings()
		{
			Build.Properties.Settings.Default.Compiler_NetVersion = (Build.Enums.CompilerVersionType)Enum.Parse(typeof(Build.Enums.CompilerVersionType), Convert.ToString(netVersionComboBox.SelectedItem).Replace(".", "_"));
			Build.Properties.Settings.Default.Compiler_WarningLevel = Convert.ToInt32(warningLevelComboBox.SelectedItem);
			Build.Properties.Settings.Default.Compiler_WarningsAsError = warningsAsErrorCheckBox.Checked;
			Build.Properties.Settings.Default.Compiler_DebugAssembly = debugCheckBox.Checked;
			Build.Properties.Settings.Default.Compiler_OutputDirectory = outputDirectoryTextBox.Text;
			Build.Properties.Settings.Default.Save();
		}

		#endregion

		#region Event Handlers

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			SaveSettings();
			this.Close();
		}

		private void outputDirectoryBrowseButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			folderBrowserDialog.SelectedPath = outputDirectoryTextBox.Text;
			folderBrowserDialog.Description = "Select output directory";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				outputDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
			}
		}

		#endregion

		private void showNewFileDialogCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			defaultTemplateLabel.Enabled = !showNewFileDialogCheckBox.Checked;
			defaultTemplateComboBox.Enabled = !showNewFileDialogCheckBox.Checked;
		}
	}
}
