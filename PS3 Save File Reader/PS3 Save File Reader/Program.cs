using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PS3_Save_File_Reader
{
	public class Program
	{
		static void Main(string[] args)
		{
			var saveFile=new PS3SaveFile("\\PARAM.SFO");
			Console.ReadLine();
		}
	}

	public class PS3SaveFile
	{

		public int Sign { get; set; }
		public int Unknown { get; set; }
		public int TagOffset { get; set; }
		public int ValueOffset { get; set; }
		public int Count { get; set; }

		public PS3SaveFile(string fileName)
		{
			var directories = Directory.GetDirectories("D:\\Saves\\PS3\\SAVEDATA");
			foreach(var dir in directories)
			{
				using (var fileReader = new BinaryReader(new FileStream(dir + fileName, FileMode.Open)))
				{
					try
					{
						fileReader.BaseStream.Seek(2608, SeekOrigin.Begin);
						var title = fileReader.ReadString();
						if(title.ToLower().Contains("2010"))
						{
							Console.WriteLine(dir + ": " + title);
						}
					}
					catch(Exception ex)
					{
						Console.WriteLine(dir + ": Error!");
					}
				}
			}
		}
	}
}
