using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor;

namespace VGSoftware.CodePad.UI.Controls
{
	public class CodeCompletionEventArgs : EventArgs
	{
		private char _key;
		private TextEditorControl _textEditor;

		public CodeCompletionEventArgs(TextEditorControl textEditor, char key)
		{
			_key = key;
			_textEditor = textEditor;
		}

		public char Key
		{
			get { return _key; }
		}

		public TextEditorControl TextEditor
		{
			get { return _textEditor; }
		}
	}
}
