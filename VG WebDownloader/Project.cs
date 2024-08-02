using System;
using System.Collections;
using System.Collections.Specialized;

namespace VGSoftware.PageSaver
{
	/// <summary>
	/// Project class for VG WebDownloader
	/// </summary>
	[Serializable]
	public class Project
	{
		///<summary>
		///Default empty constructor
		///</summary>
		public Project()
		{
		}
		
		private string name="";
		/// <summary>
		/// Gets or sets the project name.
		/// </summary>
		public string Name
		{
			get
			{
				return(name);
			}
			set
			{
				name = value;
			}
		}

		private string folder="";
		/// <summary>
		/// Gets or sets the projects target folder.
		/// </summary>
		public string Folder
		{
			get
			{
				return(folder);
			}
			set
			{
				folder=value;
			}
		}

		private bool cookie=true;
		/// <summary>
		/// Gets or sets if the project uses Internet Explorer Cookies
		/// </summary>
		public bool Cookie
		{
			get
			{
				return(cookie);
			}
			set
			{
				cookie=value;
			}
		}

		private bool cache=true;
		/// <summary>
		/// Gets or sets if the project uses Internet Explorer Temporary Internet Files
		/// </summary>
		public bool Cache
		{
			get
			{
				return(cache);
			}
			set
			{
				cache=value;
			}
		}

		private int dir=0;
		///<summary>
		///Gets or sets the directory structure
		///</summary>
		///<remarks>Here are the valid values
		///<list type="bullet">
		///<item><description>Server Layout = 0</description></item>
		///<item><description>Single Directory = 1</description></item>
		///<item><description>Separate Directories=2</description></item>
		///</list>
		///</remarks>
		public int DirectoryStructure
		{
			get
			{
				return(dir);
			}
			set
			{
				dir=value;
			}
		}

		private Hashtable ht=new Hashtable();
		///<summary>
		///Add a url->path item to the project. The path shuld be relative to the project folder.
		///</summary>
		///<param name="url">The URL</param>
		///<param name="path">The relative path for the URL</param>
		public void AddPage(string url, string path)
		{
			try
			{
				ht.Add(url,path);
			}
			catch(Exception e)
			{
			}
		}

		///<summary>
		///Get the file system path matching the URL.
		///The file system path is relative to the project folder.
		///</summary>
		///<param name="url">The URL</param>
		///<returns>Relative file system path</returns>
		public string GetPath(string url)
		{
			return((string)ht[url]);
		}

		///<summary>
		///Clear the page catch.
		///</summary>
		public void ClearPageCatch()
		{
			ht.Clear();
		}

		private string DirName="Files";
		///<summary>
		///Gets or sets the directory name.
		///</summary>
		public string DirectoryName
		{
			get
			{
				return(DirName);
			}
			set
			{
				DirName=value;
			}
		}
	}
}
