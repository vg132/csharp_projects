using System;
using System.Windows.Forms;
using IIC.Plugin;

namespace IIC
{
	/// <summary>
	/// Extended <c>TreeNode</c> that also holed a reference to the plugin and folder objects.
	/// </summary>
	public class TreeInfoNode : TreeNode
	{
		private IPlugin plugin=null;

		/// <summary>
		/// Default constructor, takes the plugin, folder and the name.
		/// </summary>
		/// <param name="plugin">Reference to the plugin that this folder is part of.</param>
		/// <param name="name">Name of this folder.</param>
		public TreeInfoNode(IPlugin plugin, string name)
		{
			base.Text=name;
			this.plugin=plugin;
		}

		/// <summary>
		/// Gets and sets the plugin.
		/// </summary>
		public IPlugin Plugin
		{
			get
			{
				return(plugin);
			}
		}
	}
}
