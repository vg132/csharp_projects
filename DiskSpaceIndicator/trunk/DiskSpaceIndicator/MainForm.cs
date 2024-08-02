using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace DiskSpaceIndicator
{
	public partial class MainForm : Form
	{
		private bool _exitProgram;
		private Timer _timer;

		public MainForm()
		{
			InitializeComponent();
			SetupForm();
		}

		private MenuItem[] DiskInfoMenu
		{
			get
			{
				string text = string.Empty;
				ManagementScope scope = new ManagementScope();
				ObjectQuery query = new ObjectQuery("SELECT DriveLetter, Label, Capacity, Name, FreeSpace FROM Win32_Volume WHERE DriveType=3");
				ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
				ManagementObjectCollection result=searcher.Get();

				MenuItem[] menuItems = new MenuItem[result.Count];
				int counter=0;
				foreach (ManagementObject mo in result)
				{
					double freeSpace = double.Parse(mo["FreeSpace"].ToString());
					freeSpace /= 1000000000;
					freeSpace = Math.Round(freeSpace, 2);

					double capacity = double.Parse(mo["Capacity"].ToString());
					capacity /= 1000000000;
					capacity = Math.Round(capacity, 0);

					MenuItem item = new MenuItem();
					if (mo["DriveLetter"] != null)
					{
						item.Text = string.Format("{0} ({1}) {2} GB free of {3} GB", mo["Label"].ToString(), mo["DriveLetter"].ToString(), freeSpace, capacity);
					}
					else
					{
						item.Text = string.Format("{0} {1} GB free of {2} GB", mo["Label"].ToString(), freeSpace, capacity);
					}

					item.Click += new EventHandler(ContextMenu_ItemClick);
					item.Tag = mo["Name"].ToString();

					menuItems[counter++] = item;
				}
				return menuItems;
			}
		}

		private void ContextMenu_ItemClick(object sender, EventArgs e)
		{
			Process p = new Process();
			p.StartInfo.FileName = ((MenuItem)sender).Tag.ToString();
			p.Start();
		}

		private void ContextMenu_RefreshClick(object sender, EventArgs e)
		{
			notifyIcon.ContextMenu = NotifyContextMenu;
		}

		private void SetupForm()
		{
			notifyIcon.Text = "Disk Space Indicator";
			notifyIcon.ContextMenu = NotifyContextMenu;
			_timer = new Timer();
			_timer.Interval = 60000;
			_timer.Tick += new EventHandler(Timer_Tick);
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			notifyIcon.ContextMenu = NotifyContextMenu;
		}

		private ContextMenu NotifyContextMenu
		{
			get
			{
				ContextMenu menu = new ContextMenu(DiskInfoMenu);
				if (menu.MenuItems.Count > 0)
				{
					menu.MenuItems.Add(new MenuItem("-"));
				}
				MenuItem item = new MenuItem("Refresh");
				item.Click += new EventHandler(ContextMenu_RefreshClick);
				menu.MenuItems.Add(item);

				item = new MenuItem("About...");
				item.Click += new EventHandler(ContextMenu_AboutClick);
				menu.MenuItems.Add(item);
				menu.MenuItems.Add(new MenuItem("-"));
				item = new MenuItem("Exit");
				item.Click += new EventHandler(ContextMenu_ExitClick);
				menu.MenuItems.Add(item);

				return menu;
			}
		}

		private void ContextMenu_AboutClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.Show();
		}

		private void ContextMenu_ExitClick(object sender, EventArgs e)
		{
			_exitProgram = true;
			Application.Exit();
		}

		private void MainForm_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_exitProgram)
			{
				this.Hide();
				e.Cancel = true;
			}
		}
	}
}