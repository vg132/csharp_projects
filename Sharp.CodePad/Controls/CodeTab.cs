using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.TextEditor;

namespace VGSoftware.Sharp.CodePad.Controls
{
	public class CodeTab : TabPage
	{
		private TextEditorControl _textEditor;
		private Enums.LanguageType _language;
		private static int _tabId;

		public CodeTab()
		{
			_textEditor = new ICSharpCode.TextEditor.TextEditorControl();
			_textEditor.Dock = DockStyle.Fill;
			_textEditor.Document.DocumentChanged += new ICSharpCode.TextEditor.Document.DocumentEventHandler(Document_DocumentChanged);
			_tabId++;
			_textEditor.ConvertTabsToSpaces = false;
			_textEditor.TabIndent = 2;
			CurrentFile = null;

			_textEditor.Text = LoadTemplate();
			IsTextChanged = false;

			this.Controls.Add(_textEditor);
		}

		private string LoadTemplate()
		{
			FileStream fs = new FileStream("Templates/CSharp/Console.cs", FileMode.Open);
			StreamReader tr = new StreamReader(fs);
			string text = tr.ReadToEnd();
			fs.Close();
			return text;
		}

		private void Document_DocumentChanged(object sender, ICSharpCode.TextEditor.Document.DocumentEventArgs e)
		{
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
			get { return CurrentFile != null ? CurrentFile.Name : string.Format(Properties.Resources.DefaultTabName, _tabId); }
		}

		public string EditorText
		{
			get { return _textEditor.Text; }
			set { _textEditor.Text = value; }
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
			get {  return _textEditor; }
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
