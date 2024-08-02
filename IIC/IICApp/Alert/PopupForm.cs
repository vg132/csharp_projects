using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IIC.Alert
{
	/// <summary>
	/// Summary description for Popupthis.
	/// </summary>
	public class PopupForm : Form
	{
		private int ticksShow;
		private int ticksVisible;
		private int ticksHide;
		private int currentPixel;
		private PopupState popupState;
		private System.Threading.Timer timer=null;
		private Rectangle workAreaRectangle;
		private static PopupForm instance=null;
		private PopupData currentPopupData=null;
		private Queue popupQueue=new Queue();
		private TimerCallback timerDelegate=null;
		private System.Windows.Forms.LinkLabel llbMessage;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// 
		/// </summary>
		public enum PopupState
		{
			/// <summary>
			/// 
			/// </summary>
			Hidden = 0,
			/// <summary>
			/// 
			/// </summary>
			Appearing = 1,
			/// <summary>
			/// 
			/// </summary>
			Visible = 2,
			/// <summary>
			/// 
			/// </summary>
			Disappearing = 3
		}

		[DllImport("user32.dll")]
		private static extern Boolean ShowWindow(IntPtr hWnd,Int32 nCmdShow);

		private PopupForm()
		{
			InitializeComponent();
			timerDelegate=new TimerCallback(this.Timer_Event);
		}

		/// <summary>
		/// 
		/// </summary>
		public static PopupForm Instance
		{
			get
			{
				if(instance==null)
				{
					instance=new PopupForm();
				}
				return(instance);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pd"></param>
		public void AddPopup(PopupData pd)
		{
			lock(this)
			{
				popupQueue.Enqueue(pd);
				if(currentPopupData==null)
				{
					currentPopupData=(PopupData)popupQueue.Dequeue();
					ShowPopup();
				}
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if(disposing)
			{
				if(components!=null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PopupForm));
			this.llbMessage = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// llbMessage
			// 
			this.llbMessage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(251)), ((System.Byte)(250)), ((System.Byte)(247)));
			this.llbMessage.Location = new System.Drawing.Point(8, 8);
			this.llbMessage.Name = "llbMessage";
			this.llbMessage.Size = new System.Drawing.Size(139, 40);
			this.llbMessage.TabIndex = 0;
			this.llbMessage.TabStop = true;
			this.llbMessage.Text = "linkLabel1";
			this.llbMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMessage_LinkClicked);
			// 
			// PopupForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(156, 54);
			this.Controls.Add(this.llbMessage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PopupForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "PopupForm";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// </summary>
		private void ShowPopup()
		{
			llbMessage.Text=currentPopupData.Message;

			workAreaRectangle=Screen.GetWorkingArea(workAreaRectangle);
			SetBounds(workAreaRectangle.Right-this.Width-5, workAreaRectangle.Bottom-1, this.Width, this.Height);
			this.ticksShow=(1500/this.Height)>0?(1500/this.Height):1;
			this.ticksHide=(1500/this.Height)>0?(1500/this.Height):1;
			this.ticksVisible=3000;

			currentPixel=1;

			this.TopMost=true;
			workAreaRectangle=Screen.GetWorkingArea(workAreaRectangle);
			popupState=PopupState.Appearing;

			ShowWindow(this.Handle,4);
			timer=new System.Threading.Timer(timerDelegate,null,0,ticksShow);
		}

		private void Timer_Event(object state)
		{
			switch(popupState)
			{
				case PopupState.Appearing:
					currentPixel++;
					this.SetBounds(this.Left,workAreaRectangle.Bottom-currentPixel,this.Width,this.Height);
					if(this.Location.Y<=(workAreaRectangle.Height-this.Height))
					{
						timer.Change(ticksVisible,ticksVisible);
						popupState=PopupState.Visible;
					}
					break;
				case PopupState.Disappearing:
					currentPixel--;
					this.SetBounds(this.Left,workAreaRectangle.Bottom-currentPixel,this.Width,this.Height);
					if(this.Location.Y>=workAreaRectangle.Height)
					{
						timer.Change(0,1);
						popupState=PopupState.Hidden;
					}
					break;
				case PopupState.Hidden:
					timer.Dispose();
					timer=null;
					this.Hide();
					if(popupQueue.Count>0)
					{
						currentPopupData=(PopupData)popupQueue.Dequeue();
						ShowPopup();
					}
					else
					{
						currentPopupData=null;
					}
					break;
				case PopupState.Visible:
					timer.Change(0,ticksHide);
					popupState=PopupState.Disappearing;
					break;
			}
		}

		private void llbMessage_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			currentPopupData.Plugin.AlertResponse(currentPopupData.Id);
		}
	}
}
