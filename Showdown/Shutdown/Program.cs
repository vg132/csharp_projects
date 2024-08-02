using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutdown
{
	class Program
	{
		static void Main(string[] args)
		{

			if (args.Length > 0)
			{
				switch (args[0].ToLower())
				{
					case "-h":
					case "-hibernate":
						System.Windows.Forms.Application.SetSuspendState(System.Windows.Forms.PowerState.Hibernate, true, false);
						break;
					case "-s":
					case "-suspend":
						System.Windows.Forms.Application.SetSuspendState(System.Windows.Forms.PowerState.Suspend, true, false);
						break;
					default:
						Console.WriteLine("Unknown command");
						break;
				}
			}
			else
			{
				Console.WriteLine("Syntax: shutdown -s[uspend] -h[hibernate]");
			}
		}
	}
}
