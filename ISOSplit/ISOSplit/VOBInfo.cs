using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ISOSplit
{
	public class VOBInfo
	{
		private List<FileInfo> _files;
		private string _name;

		public VOBInfo(string name)
		{
			_files = new List<FileInfo>();
			_name = name;
		}

		public List<FileInfo> Files
		{
			get { return _files; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public long FileSize
		{
			get
			{
				long size = 0;
				foreach (FileInfo file in Files)
				{
					size += file.Length;
				}
				return size;
			}
		}
	}
}
