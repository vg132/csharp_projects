using System.Windows.Forms;
using System;

namespace TorrentDisplay
{
	/// <summary>
	/// Summary description for TextClickedEventArgs.
	/// </summary>
	public class TextClickedEventArgs
	{
		private TextItem m_TextItem=null;
		private MouseButtons m_MouseButton;

		public TextClickedEventArgs(MouseButtons mb)
		{
			this.m_MouseButton=mb;
			this.m_TextItem=null;
		}

		public TextClickedEventArgs(MouseButtons mb, TextItem ti)
		{
			this.m_MouseButton=mb;
			this.m_TextItem=ti;
		}

		/// <summary>
		/// Gets and sets the TextItem value of TextItem.
		/// </summary>
		public TextItem TextItem
		{
			get
			{
				return(this.m_TextItem);
			}
			set
			{
				this.m_TextItem=value;
			}
		}

		/// <summary>
		/// Gets and sets the MouseButtons value of MouseButton.
		/// </summary>
		public MouseButtons MouseButton
		{
			get
			{
				return(this.m_MouseButton);
			}
			set
			{
				this.m_MouseButton=value;
			}
		}
	}
}
