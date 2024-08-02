using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Configuration;

namespace DynDNSService
{
	partial class DynDNS : ServiceBase
	{
		private static Thread _thread;

		public DynDNS()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			_thread = new Thread(new ThreadStart(Run));
			_thread.Start();
		}

		protected override void OnStop()
		{
			if (_thread != null)
			{
				_thread.Interrupt();
			}
		}

		private static void Run()
		{
			try
			{
				while (true)
				{
					Updater.Instance.Update();
					Thread.Sleep(Updater.Instance.Configuration.UpdateInterval * 1000);
				}
			}
			catch
			{
			}
		}
	}
}
