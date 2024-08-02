using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace DynDNSService
{
	[RunInstaller(true)]
	public class DynDNSInstaller : Installer
	{
		public DynDNSInstaller()
		{
			ServiceProcessInstaller spi = new ServiceProcessInstaller();
			spi.Account = ServiceAccount.LocalSystem;
			ServiceInstaller si = new ServiceInstaller();
			si.ServiceName = "DynDNS";
			si.StartType = ServiceStartMode.Automatic;
			Installers.AddRange(new Installer[] { spi, si });
		}
	}
}
