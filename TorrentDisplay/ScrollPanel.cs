using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace TorrentDisplay
{
	public delegate void TextClickedEventHandler(object sender, TextClickedEventArgs e);
	public delegate void LayoutChangedEventHandler(object sender);

	/// <summary>
	/// Summary description for ScrollPanel.
	/// </summary>
	public class ScrollPanel : System.Windows.Forms.UserControl
	{
		private string m_Title=null;
		private bool m_Open=true;
		private int m_OpenSize=240;
		private int m_ScrollPos=0;
		private int m_MaxScroll=0;
		private int m_ScrollDragStartPos=0;

		private bool m_CollapseActive=false;
		private bool m_ScrollDownActive=false;
		private bool m_ScrollUpActive=false;
		private bool m_ScrollIndicaterActive=false;
		private bool m_ScrollIndicatorDrag=false;

		private Hashtable m_TextRects=new Hashtable();
		private ArrayList m_TextItems=new ArrayList();

		private Rectangle m_TextRect=new Rectangle(5,24,200,216);
		private Rectangle m_PlusMinusRect=new Rectangle(200,6,11,11);
		private Rectangle m_TitleRect=new Rectangle(0,0,220,24);
		private Rectangle m_ScrollUpArrowRect=new Rectangle(210,25,9,5);
		private Rectangle m_ScrollDownArrowRect=new Rectangle(210,230,9,5);
		private Rectangle m_ScrollIndicatorRect=new Rectangle(211,32,6,195);
		private Rectangle m_CurrentScrollIndicatorRect;

		private Rectangle m_BackgroundSideRect;
		private Rectangle m_BackgroundRect;
		private Font m_HeaderFont=new Font("Tahoma",14.0f,FontStyle.Regular);
		private Font m_TextFont=new Font("Tahoma",8.0f,FontStyle.Regular);
		private SolidBrush m_BackgroundBrush=new SolidBrush(Color.FromArgb(250,250,250));
		private SolidBrush m_TextBrush=new SolidBrush(Color.FromArgb(94,117,151));
		private SolidBrush m_ActiveBrush=new SolidBrush(Color.FromArgb(93,118,149));
		private SolidBrush m_InactiveBrush=new SolidBrush(Color.FromArgb(174,186,200));
		private Bitmap m_ImgBackground=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.bg.png"));
		private Bitmap m_ImgTitle=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.title.png"));
		private Bitmap m_ImgActivePlus=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.activeplus.png"));
		private Bitmap m_ImgInactivePlus=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.inactiveplus.png"));
		private Bitmap m_ImgActiveMinus=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.activeminus.png"));
		private Bitmap m_ImgInactiveMinus=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.inactiveminus.png"));
		private Bitmap m_ImgActiveArrow=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.activearrow.png"));
		private Bitmap m_ImgInactiveArrow=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.inactivearrow.png"));
		private Bitmap m_ImgBackground2=new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TorrentDisplay.res.images.bg2.png"));
		private System.Windows.Forms.Timer tmrScroll;
		private System.ComponentModel.IContainer components;

		public event TextClickedEventHandler TextClicked;
		public event LayoutChangedEventHandler LayoutChanged;

		public ScrollPanel(string Title, bool Open, int OpenSize)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			this.m_Open=Open;
			this.m_Title=Title;
			this.m_OpenSize=OpenSize;
			tmrScroll.Interval=10;
			m_BackgroundSideRect=new Rectangle(this.Width-22,0,22,this.Height);
			m_BackgroundRect=new Rectangle(0,0,this.Width-22,this.Height);

			this.MouseWheel+=new System.Windows.Forms.MouseEventHandler(this.ScrollPanel_MouseWheel);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tmrScroll = new System.Windows.Forms.Timer(this.components);
			// 
			// tmrScroll
			// 
			this.tmrScroll.Interval = 10;
			this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
			// 
			// ScrollPanel
			// 
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "ScrollPanel";
			this.Size = new System.Drawing.Size(220, 240);
			this.SizeChanged += new System.EventHandler(this.ScrollPanel_SizeChanged);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScrollPanel_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScrollPanel_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScrollPanel_MouseMove);
			this.MouseLeave += new System.EventHandler(this.ScrollPanel_MouseLeave);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScrollPanel_MouseDown);

		}
		#endregion

		#region Paint Form

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		private void ScrollPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g=null;
			Bitmap buffer=new Bitmap(this.Width,this.Height,e.Graphics);
			g=Graphics.FromImage(buffer);
			g.SmoothingMode=SmoothingMode.HighQuality;

			//Draw background
			g.DrawImage(m_ImgBackground,0,0,m_ImgBackground.Width,m_ImgBackground.Height);

			//Draw text section
			if(m_TextRect.IntersectsWith(e.ClipRectangle)&&(m_Open==true))
			{
				//Calculate text matrix and transform
				int y=30;

				foreach(TextItem ti in m_TextItems)
					y+=(int)g.MeasureString(ti.Text,m_TextFont,m_TextRect.Width).Height+8;
				y-=(m_TextRect.Height+m_TitleRect.Height+6);
				if(y<0)
					m_MaxScroll=0;
				else
					m_MaxScroll=y-(y*2);

				Matrix mx=new Matrix(1, 0, 0, 1, 0,m_ScrollPos);
				g.Transform=mx;

				//Draw text
				y=30;
				Rectangle rect;
				m_TextRects.Clear();
				foreach(TextItem ti in m_TextItems)
				{
					rect=new Rectangle(10,y,m_TextRect.Width,(int)g.MeasureString(ti.Text,m_TextFont,m_TextRect.Width).Height);
					g.DrawString(ti.Text,m_TextFont,m_TextBrush,rect);
					y+=rect.Height+8;
					m_TextRects.Add(rect,ti);
				}
				g.ResetTransform();
			}

			//Draw title
			if(m_TitleRect.IntersectsWith(e.ClipRectangle))
			{
				g.TextRenderingHint=TextRenderingHint.AntiAlias;
				g.DrawImage(m_ImgTitle,m_TitleRect);
				if((m_Open==false)&&(m_CollapseActive==false))
					g.DrawImage(m_ImgInactivePlus,m_PlusMinusRect);
				else if((m_Open==false)&&(m_CollapseActive==true))
					g.DrawImage(m_ImgActivePlus,m_PlusMinusRect);
				else if((m_Open==true)&&(m_CollapseActive==false))
					g.DrawImage(m_ImgInactiveMinus,m_PlusMinusRect);
				else if((m_Open==true)&&(m_CollapseActive==true))
					g.DrawImage(m_ImgActiveMinus,m_PlusMinusRect);
				g.DrawString(m_Title,m_HeaderFont,m_TextBrush,5,0);
			}

			if(m_MaxScroll<0)
			{
				//Scroll arrows
				if(m_ScrollUpActive==true)
				{
					m_ImgActiveArrow.RotateFlip(RotateFlipType.Rotate180FlipX);
					g.DrawImage(m_ImgActiveArrow,m_ScrollUpArrowRect);
					m_ImgActiveArrow.RotateFlip(RotateFlipType.Rotate180FlipX);
				}
				else
				{
					m_ImgInactiveArrow.RotateFlip(RotateFlipType.Rotate180FlipX);
					g.DrawImage(m_ImgInactiveArrow,m_ScrollUpArrowRect);
					m_ImgInactiveArrow.RotateFlip(RotateFlipType.Rotate180FlipX);
				}
				if(m_ScrollDownActive==true)
				{
					g.DrawImage(m_ImgActiveArrow,m_ScrollDownArrowRect);
				}
				else
				{
					g.DrawImage(m_ImgInactiveArrow,m_ScrollDownArrowRect);
				}

				//Draw scroll indicator
				if(m_ScrollIndicatorRect.IntersectsWith(e.ClipRectangle))
				{
					double height=((double)m_TextRect.Height/(double)(Math.Abs(m_MaxScroll)+m_TextRect.Height))*m_ScrollIndicatorRect.Height;
					double y=0;
					if(m_ScrollPos!=0)
						y=((double)(m_ScrollIndicatorRect.Height-height)/(double)(Math.Abs(m_MaxScroll)))*(double)Math.Abs(m_ScrollPos);					
					m_CurrentScrollIndicatorRect=new Rectangle(m_ScrollIndicatorRect.X,m_ScrollIndicatorRect.Y+(int)y,m_ScrollIndicatorRect.Width,(int)height);
					if(m_ScrollIndicaterActive==true)
						g.FillRectangle(m_ActiveBrush,m_CurrentScrollIndicatorRect);  //,m_ScrollIndicatorRect.X,m_ScrollIndicatorRect.Y+(int)y,m_ScrollIndicatorRect.Width,(int)height);
					else
						g.FillRectangle(m_InactiveBrush,m_CurrentScrollIndicatorRect); //m_ScrollIndicatorRect.X,m_ScrollIndicatorRect.Y+(int)y,m_ScrollIndicatorRect.Width,(int)height);
				}
			}

			e.Graphics.DrawImageUnscaled(buffer,0,0);
			g.Dispose();
		}
		#endregion

		#region Mouse Events

		private void ScrollPanel_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if((m_PlusMinusRect.Contains(this.PointToClient(MousePosition))==true)&&(m_CollapseActive==false))
			{
				m_CollapseActive=true;
				this.Invalidate(m_PlusMinusRect);
			}
			else if((m_PlusMinusRect.Contains(this.PointToClient(MousePosition))==false)&&(m_CollapseActive==true))
			{
				m_CollapseActive=false;
				this.Invalidate(m_PlusMinusRect);
			}
			else if((m_ScrollDownArrowRect.Contains(this.PointToClient(MousePosition))==true)&&(m_ScrollDownActive==false))
			{
				m_ScrollDownActive=true;
				this.Invalidate(m_ScrollDownArrowRect);
			}
			else if((m_ScrollDownArrowRect.Contains(this.PointToClient(MousePosition))==false)&&(m_ScrollDownActive==true))
			{
				m_ScrollDownActive=false;
				this.Invalidate(m_ScrollDownArrowRect);
			}
			else if((m_ScrollUpArrowRect.Contains(this.PointToClient(MousePosition))==true)&&(m_ScrollUpActive==false))
			{
				m_ScrollUpActive=true;
				this.Invalidate(m_ScrollUpArrowRect);
			}
			else if((m_ScrollUpArrowRect.Contains(this.PointToClient(MousePosition))==false)&&(m_ScrollUpActive==true))
			{
				m_ScrollUpActive=false;
				this.Invalidate(m_ScrollUpArrowRect);
			}
			else if((m_CurrentScrollIndicatorRect.Contains(this.PointToClient(MousePosition))==true)&&(m_ScrollIndicaterActive==false))
			{
				m_ScrollIndicaterActive=true;
				this.Invalidate(m_ScrollIndicatorRect);
			}
			else if((m_CurrentScrollIndicatorRect.Contains(this.PointToClient(MousePosition))==false)&&(m_ScrollIndicaterActive==true))
			{
				m_ScrollIndicaterActive=false;
				this.Invalidate(m_ScrollIndicatorRect);
			}
			else if(m_ScrollIndicatorDrag==true)
			{
				Point mp=new Point(MousePosition.X,MousePosition.Y);
				if(m_ScrollDragStartPos>mp.Y)
				{
					m_ScrollPos+=(m_ScrollDragStartPos-mp.Y)*(int)Math.Round((((double)Math.Abs(m_MaxScroll)+m_TextRect.Height)/(double)m_TextRect.Height),0);
					if(m_ScrollPos>0)
					{
						m_ScrollPos=0;
					}
					else
					{
						this.Invalidate(m_TextRect);
						this.Invalidate(m_ScrollIndicatorRect);
					}
				}
				else
				{
					m_ScrollPos-=(mp.Y-m_ScrollDragStartPos)*(int)Math.Round((((double)Math.Abs(m_MaxScroll)+m_TextRect.Height)/(double)m_TextRect.Height),0);
					if(m_ScrollPos<m_MaxScroll)
					{
						m_ScrollPos=m_MaxScroll;
					}
					else
					{
						this.Invalidate(m_TextRect);
						this.Invalidate(m_ScrollIndicatorRect);
					}
				}
				m_ScrollDragStartPos=mp.Y;
			}
		}

		private void ScrollPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)
			{
				if(m_PlusMinusRect.Contains(this.PointToClient(MousePosition)))
				{
					m_Open=!m_Open;
					if(m_Open==false)
						this.Height=23;
					else
						this.Height=m_OpenSize;
					this.Invalidate(m_TextRect);
					this.Invalidate(m_PlusMinusRect);
					LayoutChanged(this);
				}
				else if(m_ScrollUpArrowRect.Contains(this.PointToClient(MousePosition)))
				{
					m_ScrollPos++;
					if(m_ScrollPos>0)
					{
						m_ScrollPos--;
					}
					else
					{
						this.Invalidate(m_TextRect);
						this.Invalidate(m_ScrollIndicatorRect);
					}
					tmrScroll.Start();
				}
				else if(m_ScrollDownArrowRect.Contains(this.PointToClient(MousePosition)))
				{
					m_ScrollPos--;
					if(m_ScrollPos<m_MaxScroll)
					{
						m_ScrollPos++;
					}
					else
					{
						this.Invalidate(m_TextRect);
						this.Invalidate(m_ScrollIndicatorRect);
					}
					tmrScroll.Start();
				}
				else if(m_CurrentScrollIndicatorRect.Contains(this.PointToClient(MousePosition)))
				{
					m_ScrollIndicatorDrag=true;
					m_ScrollDragStartPos=MousePosition.Y;
				}
			}
			if(m_TextRect.Contains(this.PointToClient(MousePosition)))
			{
				bool inText=false;
				Point p=new Point(MousePosition.X,MousePosition.Y+Math.Abs(m_ScrollPos));
				foreach(Rectangle rect in m_TextRects.Keys)
				{
					if(rect.Contains(this.PointToClient(p)))
					{
						TextClicked(this,new TextClickedEventArgs(e.Button,(TextItem)m_TextRects[rect]));
						inText=true;
						break;
					}
				}
				if(inText==false)
					TextClicked(this,new TextClickedEventArgs(e.Button));
			}
			else
			{
				TextClicked(this,new TextClickedEventArgs(e.Button));
			}
		}

		

		private void ScrollPanel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(m_ScrollIndicatorDrag==true)
				m_ScrollIndicatorDrag=false;
			tmrScroll.Stop();
		}

		private void ScrollPanel_MouseLeave(object sender, System.EventArgs e)
		{
			m_CollapseActive=false;
			m_ScrollDownActive=false;
			m_ScrollUpActive=false;
			m_ScrollIndicaterActive=false;
			m_ScrollIndicatorDrag=false;
			this.Invalidate();
		}

		#endregion

		public void AddTextItem(TextItem textItem)
		{
			m_TextItems.Add(textItem);
			this.Invalidate(m_TextRect);
		}

		public void RemoveTextItems()
		{
			m_TextItems.Clear();
			this.Invalidate(m_TextRect);
		}

		private void tmrScroll_Tick(object sender, System.EventArgs e)
		{
			if(m_ScrollDownActive)
			{
				m_ScrollPos--;
				if(m_ScrollPos<m_MaxScroll)
					m_ScrollPos++;
				else
				{
					this.Invalidate(m_TextRect);
					this.Invalidate(m_ScrollIndicatorRect);
				}
			}
			else if(m_ScrollUpActive)
			{
				m_ScrollPos++;
				if(m_ScrollPos>0)
				{
					m_ScrollPos--;
				}
				else
				{
					this.Invalidate(m_TextRect);
					this.Invalidate(m_ScrollIndicatorRect);
				}
			}
			else
			{
				tmrScroll.Stop();
			}
		}

		private void ScrollPanel_SizeChanged(object sender, System.EventArgs e)
		{
			m_BackgroundSideRect=new Rectangle(this.Width-22,0,22,this.Height);
			m_BackgroundRect=new Rectangle(0,0,this.Width-22,this.Height);
		}

		private void ScrollPanel_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Delta>0)
			{
				m_ScrollPos+=Math.Abs((e.Delta+SystemInformation.MouseWheelScrollLines/120));
				if(m_ScrollPos>0)
					m_ScrollPos=0;
				this.Invalidate(m_TextRect);
				this.Invalidate(m_ScrollIndicatorRect);
			}
			else
			{
				m_ScrollPos-=Math.Abs((e.Delta+SystemInformation.MouseWheelScrollLines/120));
				if(m_ScrollPos<m_MaxScroll)
					m_ScrollPos=m_MaxScroll;
				this.Invalidate(m_TextRect);
				this.Invalidate(m_ScrollIndicatorRect);
			}
		}
	}
}
