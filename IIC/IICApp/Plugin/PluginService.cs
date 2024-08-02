using System;
using System.IO;
using System.Reflection;

namespace IIC.Plugin
{
	/// <summary>
	/// Summary description for PluginServices.
	/// </summary>
	public class PluginServices
	{
		private AvailablePlugins colAvailablePlugins=new AvailablePlugins();

		/// <summary>
		/// Constructor of the Class
		/// </summary>
		public PluginServices()
		{
		}

		/// <summary>
		/// A Collection of all Plugins Found and Loaded by the FindPlugins() Method
		/// </summary>
		public AvailablePlugins AvailablePlugins
		{
			get
			{
				return(colAvailablePlugins);
			}
			set
			{
				colAvailablePlugins=value;
			}
		}

		/// <summary>
		/// Searches the passed Path for Plugins.
		/// </summary>
		/// <param name="Path">Directory to search for Plugins in.</param>
		/// <param name="host">Reference to the host application.</param>
		public void FindPlugins(IPluginHost host, string Path)
		{
			colAvailablePlugins.Clear();
			foreach(string fileOn in Directory.GetFiles(Path))
			{
				FileInfo file=new FileInfo(fileOn);
				if(file.Extension.Equals(".dll"))
				{	
					this.AddPlugin(host,fileOn);				
				}
			}
		}
		
		/// <summary>
		/// Unloads and Closes all AvailablePlugins
		/// </summary>
		public void ClosePlugins()
		{
			foreach(AvailablePlugin pluginOn in colAvailablePlugins)
			{
				pluginOn.Instance=null;
			}
			colAvailablePlugins.Clear();
		}
		
		private void AddPlugin(IPluginHost host, string FileName)
		{
			Assembly pluginAssembly = Assembly.LoadFrom(FileName);
			foreach(Type pluginType in pluginAssembly.GetTypes())
			{
				if((pluginType.IsPublic)&&(!pluginType.IsAbstract))
				{
					Type typeInterface=pluginType.GetInterface("IIC.Plugin.IPlugin", true);
					if(typeInterface!=null)
					{
						try
						{
							AvailablePlugin newPlugin=new AvailablePlugin();
							newPlugin.AssemblyPath = FileName;
							newPlugin.Instance=(IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));
							newPlugin.Instance.Host=host;
							colAvailablePlugins.Add(newPlugin);
							newPlugin=null;
						}
						catch(TargetInvocationException tie)
						{
							Console.WriteLine("InvalidCastException: {0}\n{1}",tie.Message,tie.StackTrace);
						}
						catch(InvalidCastException ice)
						{
							Console.WriteLine("InvalidCastException: {0}",ice.Message);
						}
					}	
					typeInterface=null;
				}			
			}
			pluginAssembly=null;
		}
	}
}

