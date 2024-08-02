using System;

namespace TorrentDisplay
{
	/// <summary>
	/// Summary description for TextItem.
	/// </summary>
	public class TextItem
	{
		private string m_Text=null;
		private object m_Tag=null;

		public TextItem()
		{
			this.Text=null;
			this.Tag=null;
		}

		public TextItem(string text)
		{
			this.Text=text;
			this.Tag=null;
		}

		public TextItem(string text, object tag)
		{
			this.Text=text;
			this.Tag=tag;
		}

		/// <summary>
		/// Gets and sets the string value of m_Text.
		/// </summary>
		public string Text
		{
			get
			{
				return(this.m_Text);
			}
			set
			{
				this.m_Text=value;
			}
		}

		/// <summary>
		/// Gets and sets the object value of m_Tag.
		/// </summary>
		public object Tag
		{
			get
			{
				return(this.m_Tag);
			}
			set
			{
				this.m_Tag=value;
			}
		}
	}
}
