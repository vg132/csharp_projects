using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VGSoftware.Sharp.CodePad
{
	public class CodeTab : TabPage
	{
		private ICSharpCode.TextEditor.TextEditorControl _textEditor;
		private Enums.LanguageType _language;
		private static int _tabId;
		private FileInfo _file;
		private bool _changed;

		public CodeTab()
		{
			_textEditor = new ICSharpCode.TextEditor.TextEditorControl();
			_textEditor.Dock = DockStyle.Fill;
			_textEditor.Document.DocumentChanged += new ICSharpCode.TextEditor.Document.DocumentEventHandler(Document_DocumentChanged);
			_tabId++;
			_textEditor.ConvertTabsToSpaces = false;
			_textEditor.TabIndent = 2;
			this.Controls.Add(_textEditor);
		}

		private void Document_DocumentChanged(object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e)
		{
			if (!_changed)
			{
				_changed = true;
				this.ResetText();
			}
		}

		public void Open(FileInfo file)
		{
			_textEditor.LoadFile(file.FullName, true, true);

			_file = file;
			_changed = false;
		}

		public void Save()
		{
			if (_file != null)
			{
				Save(_file);
			}
		}

		public void Save(FileInfo file)
		{
			if (file != null)
			{
				_textEditor.SaveFile(file.FullName);

				_file = file;
				_changed = false;
			}
		}

		public override string Text
		{
			get
			{
				string text = _file != null ? _file.Name : string.Format(CodeTabResources.DefaultTabName, _tabId);
				return _changed ? string.Format("{0} *", text) : text;
			}
		}

		public string EditorText
		{
			get { return _textEditor.Text; }
			set { _textEditor.Text = value; }
		}

		public Enums.LanguageType Language
		{
			get
			{
				return _language;
			}
			set
			{
				_language = value;
				switch (_language)
				{
					case Enums.LanguageType.CSharp:
						_textEditor.Document.HighlightingStrategy = ICSharpCode.TextEditor.Document.HighlightingManager.Manager.FindHighlighter("C#");
						break;
					case Enums.LanguageType.VisualBasic:
						_textEditor.Document.HighlightingStrategy = ICSharpCode.TextEditor.Document.HighlightingManager.Manager.FindHighlighter("VBNET");
						break;
				}
			}
		}
	}
}
