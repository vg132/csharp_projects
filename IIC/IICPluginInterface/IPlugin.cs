using System;
using System.Windows.Forms;

namespace IIC.Plugin
{
	/// <summary>
	/// Interface for communication between the host application and the plugin.
	/// </summary>
	public interface IPlugin
	{
		/// <summary>
		/// A reference to the host application.
		/// </summary>
		IPluginHost Host{get;set;}
		/// <summary>
		/// The name of this plugin.
		/// </summary>
		string PluginName{get;}
		/// <summary>
		/// A description of this plugin.
		/// </summary>
		string Description{get;}
		/// <summary>
		/// The author of this plugin.
		/// </summary>
		string Author{get;}
		/// <summary>
		/// The version of this plugin.
		/// </summary>
		string Version{get;}
		/// <summary>
		/// The current user control to show for this plugin.
		/// </summary>
		UserControl Form{get;}
		/// <summary>
		/// The root element for this plugins in the tree view.
		/// </summary>
		TreeNode TreeRoot{get;set;}
		/// <summary>
		/// Called by the host application when a tree node is selected.
		/// </summary>
		/// <param name="tn">The selected tree node.</param>
		void TreeNodeSelected(TreeNode tn);
		/// <summary>
		/// Called by the host application when a tree node is right clicked on.
		/// Returns the context menu that will be shown.
		/// </summary>
		/// <param name="tn">The selected tree node.</param>
		/// <returns></returns>
		ContextMenu TreeNodeMouseUp(TreeNode tn);

		/// <summary>
		/// When a alert has been seen and responded by the user this function is called
		/// with the id provided with the alert as its argument.
		/// </summary>
		/// <param name="id">The id for this alert.</param>
		void AlertResponse(object id);
		/// <summary>
		/// Called when the plugin has been loaded.
		/// </summary>
		void LoadPlugin();
		/// <summary>
		/// Called just before the plugin will be unloaded.
		/// </summary>
		void UnloadPlugin();
	}
}