using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using System.Windows.Forms;

namespace VGSoftware.CodePad.Base.CodeAnalyzing.CSharp
{
	public class CodeCompletionProvider : ICompletionDataProvider
	{
		private ImageList _imageList;

		public CodeCompletionProvider(ImageList imageList)
		{
			_imageList = imageList;
		}

		#region ICompletionDataProvider Members

		public int DefaultIndex
		{
			get { return -1; }
		}

		public ICompletionData[] GenerateCompletionData(string fileName, ICSharpCode.TextEditor.TextArea textArea, char charTyped)
		{
			return new ICompletionData[] {
             new DefaultCompletionData("Text", "Description", 0),
             new DefaultCompletionData("Text2", "Description2", 1)
        };
		}

		public ImageList ImageList
		{
			get { return _imageList; }
		}

		public bool InsertAction(ICompletionData data, ICSharpCode.TextEditor.TextArea textArea, int insertionOffset, char key)
		{
			textArea.Caret.Position = textArea.Document.OffsetToPosition(
									Math.Min(insertionOffset, textArea.Document.TextLength)
									);
			return data.InsertAction(textArea, key);
		}

		public string PreSelection
		{
			get { return null; }
		}

		public CompletionDataProviderKeyResult ProcessKey(char key)
		{
			if (char.IsLetterOrDigit(key) || key == '_')
			{
				return CompletionDataProviderKeyResult.NormalKey;
			}
			return CompletionDataProviderKeyResult.InsertionKey;
		}

		#endregion
	}
}
