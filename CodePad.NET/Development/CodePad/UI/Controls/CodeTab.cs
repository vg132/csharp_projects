using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.TextEditor;

namespace VGSoftware.CodePad.UI.Controls
{
	public class CodeTab : TabPage
	{
		private TextEditorControl _textEditor;
		private Build.Enums.LanguageType _language;
		private static int _tabId;
		private string _tabName;

		public CodeTab()
		{
			_textEditor = new ICSharpCode.TextEditor.TextEditorControl();
			_textEditor.Dock = DockStyle.Fill;
			_textEditor.Document.DocumentChanged += new ICSharpCode.TextEditor.Document.DocumentEventHandler(Document_DocumentChanged);
			_tabId++;

			CurrentFile = null;
			IsTextChanged = false;

			Properties.Settings.Default.SettingsSaving += new System.Configuration.SettingsSavingEventHandler(SettingsChanged);
			Properties.Settings.Default.SettingsLoaded += new System.Configuration.SettingsLoadedEventHandler(SettingsChanged);
			SetupTextEditorSettings();

			this.Controls.Add(_textEditor);
		}

		private event EventHandler<EventArgs> _undoRedoChanged;

		/// <summary>
		/// 
		/// </summary>
		public event EventHandler<EventArgs> UndoRedoChanged
		{
			add { _undoRedoChanged += value; }
			remove { _undoRedoChanged -= value; }
		}

		private void OnUndoRedoChanged()
		{
			EventHandler<EventArgs> handler = _undoRedoChanged;
			if (handler != null)
			{
				handler(this, new EventArgs());
			}
		}

		private void SettingsChanged(object sender, EventArgs e)
		{
			SetupTextEditorSettings();
		}

		private void SetupTextEditorSettings()
		{
			_textEditor.ConvertTabsToSpaces = !Properties.Settings.Default.TextEditor_KeepTabs;
			_textEditor.TabIndent = Properties.Settings.Default.TextEditor_TabSize;
			_textEditor.IndentStyle = Properties.Settings.Default.TextEditor_IndentStyle;
			_textEditor.ShowTabs = Properties.Settings.Default.TextEditor_ShowTabs;
			_textEditor.ShowSpaces = Properties.Settings.Default.TextEditor_ShowSpaces;
			_textEditor.ShowEOLMarkers = Properties.Settings.Default.TextEditor_ShowEndOfLine;
			_textEditor.ShowLineNumbers = Properties.Settings.Default.TextEditor_ShowLineNumbers;
			if (Properties.Settings.Default.TextEditor_HighlightSelectedLine)
			{
				_textEditor.LineViewerStyle = ICSharpCode.TextEditor.Document.LineViewerStyle.FullRow;
			}
			else
			{
				_textEditor.LineViewerStyle = ICSharpCode.TextEditor.Document.LineViewerStyle.None;
			}
		}

		private void Document_DocumentChanged(object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e)
		{
			CanRedo = _textEditor.Document.UndoStack.RedoItemCount != 0;
			CanUndo = _textEditor.Document.UndoStack.UndoItemCount != 0;
			OnUndoRedoChanged();

			if (!IsTextChanged)
			{
				IsTextChanged = true;
				this.ResetText();
			}
		}

		public void Open(FileInfo file)
		{
			_textEditor.LoadFile(file.FullName, true, true);

			CurrentFile = file;
			IsTextChanged = false;
		}

		public bool Save()
		{
			if (CurrentFile != null)
			{
				return Save(CurrentFile);
			}
			return false;
		}

		public bool Save(FileInfo file)
		{
			if (file != null)
			{
				_textEditor.SaveFile(file.FullName);
				CurrentFile = file;
				IsTextChanged = false;
				this.Text = Text;
				return true;
			}
			return false;
		}

		public override string Text
		{
			get { return IsTextChanged ? string.Format("{0} *", TabName) : TabName; }
		}

		public string TabName
		{
			get
			{
				if (CurrentFile != null)
				{
					return CurrentFile.Name;
				}
				else if (string.IsNullOrEmpty(_tabName))
				{
					return string.Format(Properties.Resources.DefaultTabName, _tabId);
				}
				else
				{
					if (_tabName.Contains("{0}"))
					{
						try
						{
							return string.Format(_tabName, _tabId);
						}
						catch (FormatException)
						{
						}
					}
					return _tabName;
				}
			}
			set
			{
				_tabName = value; 
			}
		}

		public string EditorText
		{
			get { return _textEditor.Text; }
			set { _textEditor.Text = value; }
		}

		public bool CanUndo
		{
			get;
			set;
		}

		public bool CanRedo
		{
			get;
			set;
		}

		public FileInfo CurrentFile
		{
			get;
			set;
		}

		public bool IsTextChanged
		{
			get;
			set;
		}

		public TextEditorControl TextEditor
		{
			get { return _textEditor; }
		}

		public Build.Enums.LanguageType Language
		{
			get { return _language; }
			set
			{
				_language = value;
				switch (_language)
				{
					case Build.Enums.LanguageType.CSharp:
						_textEditor.Document.HighlightingStrategy = ICSharpCode.TextEditor.Document.HighlightingManager.Manager.FindHighlighter("C#");
						break;
					case Build.Enums.LanguageType.VisualBasic:
						_textEditor.Document.HighlightingStrategy = ICSharpCode.TextEditor.Document.HighlightingManager.Manager.FindHighlighter("VBNET");
						break;
				}
			}
		}
	}
}
