using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ISOSplit
{
	public static class Extentions
	{
		public static List<FileInfo> GetFilesEx(this DirectoryInfo directory, string patterns)
		{
			List<FileInfo> files = new List<FileInfo>();
			foreach (string pattern in patterns.Split('|'))
			{
				files.AddRange(directory.GetFiles(pattern));
			}
			return files;
		}

		public static string RemoveFromEnd(this string str, int count)
		{
			if (str.Length < count)
			{
				throw new ArgumentOutOfRangeException("count must be less then length of string");
			}
			return str.Remove(str.Length - count);
		}
	}
}
