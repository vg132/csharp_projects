using System;
using System.Drawing;

namespace IIC.Alert
{
	/// <summary>
	/// Summary description for Alert.
	/// </summary>
	public class Alert
	{
		/// <summary>
		/// There are three differenct types of alerts, corner popup is just a small box
		/// that is shown in one of the screen corners. Border popup is a thin border that
		/// stretch to the size of the screen. Middle of screen popup is a popup that just
		/// shows the alert box in the middle of the screen.
		/// </summary>
		public enum AlertType
		{
			/// <summary>
			/// 
			/// </summary>
			CornerPopup=0,
			/// <summary>
			/// 
			/// </summary>
			BorderPopup=1,
			/// <summary>
			/// 
			/// </summary>
			MiddleOfScreenPopup=2
		}

		/// <summary>
		/// There are 2 different types of visual alert windows, normal dialog window or
		/// a normal window with a skin, custom or predefined.
		/// </summary>
		public enum AlertVisualizationType
		{
			/// <summary>
			/// 
			/// </summary>
			DialogWindow=0,
			/// <summary>
			/// 
			/// </summary>
			BlueSkin=1,
			/// <summary>
			/// 
			/// </summary>
			WhiteSkin=2,
			/// <summary>
			/// 
			/// </summary>
			CustomSkin=3
		}

		/// <summary>
		/// The type of alert this is.
		/// </summary>
		private AlertType alertType;
		/// <summary>
		/// The type of alert visualization this is.
		/// </summary>
		private AlertVisualizationType alertVisualization;
		/// <summary>
		/// Rectangle for the area where the title text can be displayed.
		/// </summary>
		private Rectangle titleRectangle;
		/// <summary>
		/// Rectangle for the area where the content text can be displayed.
		/// </summary>
		private Rectangle contentRectangle;
		/// <summary>
		/// Color of the title text.
		/// </summary>
		private Color titleColor;
		/// <summary>
		/// Color of the content text.
		/// </summary>
		private Color contentColor;
		/// <summary>
		/// The side of the screen the popup will popup from.
		/// </summary>
		private Popup.Origin origin;
		/// <summary>
		/// The corner of the side that the popup will popup from.
		/// </summary>
		private Popup.Origin orientation;
		/// <summary>
		/// The title.
		/// </summary>
		private string title;
		/// <summary>
		/// The content.
		/// </summary>
		private string content;
		/// <summary>
		/// Time (in ms) that it will take to show this alert.
		/// </summary>
		private int timeToShow;
		/// <summary>
		/// Time (in ms) that it will take to hide this alert.
		/// </summary>
		private int timeToHide;
		/// <summary>
		/// Time (in ms) that this alert will be visible on screen.
		/// </summary>
		private int timeToStay;
		/// <summary>
		/// A bitmap skin for this alert.
		/// </summary>
		private Bitmap skin;
		/// <summary>
		/// Callback event when the content text is clicked.
		/// </summary>
		public event EventHandler contentClick=null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="alertType"></param>
		/// <param name="alertVisualization"></param>
		/// <param name="origin"></param>
		/// <param name="title"></param>
		/// <param name="content"></param>
		public Alert(AlertType alertType, AlertVisualizationType alertVisualization, Popup.Origin origin,string title, string content)
		{
			this.alertType=alertType;
			this.alertVisualization=alertVisualization;
			this.origin=origin;
			this.title=title;
			this.content=content;
		}

		/// <summary>
		/// Gets and sets the Rectangle value of titleRectangle.
		/// </summary>
		public Rectangle TitleRectangle
		{
			get
			{
				return(this.titleRectangle);
			}
			set
			{
				this.titleRectangle=value;
			}
		}

		/// <summary>
		/// Gets and sets the Rectangle value of contentRectangle.
		/// </summary>
		public Rectangle ContentRectangle
		{
			get
			{
				return(this.contentRectangle);
			}
			set
			{
				this.contentRectangle=value;
			}
		}

		/// <summary>
		/// Gets and sets the Color value of titleColor.
		/// </summary>
		public Color TitleColor
		{
			get
			{
				return(this.titleColor);
			}
			set
			{
				this.titleColor=value;
			}
		}

		/// <summary>
		/// Gets and sets the Color value of contentColor.
		/// </summary>
		public Color ContentColor
		{
			get
			{
				return(this.contentColor);
			}
			set
			{
				this.contentColor=value;
			}
		}

		/// <summary>
		/// Gets and sets the Popup.Origin value of origin.
		/// </summary>
		public Popup.Origin Origin
		{
			get
			{
				return(this.origin);
			}
			set
			{
				this.origin=value;
			}
		}

		/// <summary>
		/// Gets and sets the Popup.Origin value of orientation.
		/// </summary>
		public Popup.Origin Orientation
		{
			get
			{
				return(this.orientation);
			}
			set
			{
				this.orientation=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of title.
		/// </summary>
		public string Title
		{
			get
			{
				return(this.title);
			}
			set
			{
				this.title=value;
			}
		}

		/// <summary>
		/// Gets and sets the string value of content.
		/// </summary>
		public string Content
		{
			get
			{
				return(this.content);
			}
			set
			{
				this.content=value;
			}
		}

		/// <summary>
		/// Gets and sets the int value of timeToShow.
		/// </summary>
		public int TimeToShow
		{
			get
			{
				return(this.timeToShow);
			}
			set
			{
				this.timeToShow=value;
			}
		}

		/// <summary>
		/// Gets and sets the int value of timeToHide.
		/// </summary>
		public int TimeToHide
		{
			get
			{
				return(this.timeToHide);
			}
			set
			{
				this.timeToHide=value;
			}
		}

		/// <summary>
		/// Gets and sets the int value of timeToStay.
		/// </summary>
		public int TimeToStay
		{
			get
			{
				return(this.timeToStay);
			}
			set
			{
				this.timeToStay=value;
			}
		}

		/// <summary>
		/// Gets and sets the Bitmap value of skin.
		/// </summary>
		public Bitmap Skin
		{
			get
			{
				return(this.skin);
			}
			set
			{
				this.skin=value;
			}
		}

		/// <summary>
		/// Gets and sets the Alert value of alertType.
		/// </summary>
		public AlertType Alert2
		{
			get
			{
				return(this.alertType);
			}
			set
			{
				this.alertType=value;
			}
		}

		/// <summary>
		/// Gets and sets the AlertVisualization value of alertVisualization.
		/// </summary>
		public AlertVisualizationType AlertVisualization
		{
			get
			{
				return(this.alertVisualization);
			}
			set
			{
				this.alertVisualization=value;
			}
		}
	}
}
