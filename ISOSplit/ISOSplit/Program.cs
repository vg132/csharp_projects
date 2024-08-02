using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace ISOSplit
{
	public class Program
	{
		private DirectoryInfo _tempDirectory;
		private FileInfo _inputFile;

		public static void Main(string[] args)
		{
			if (args.Length == 1)
			{
				
				Program p = new Program();
				p.ProcessFile(args[0]);
			}
		}

		private void ProcessFile(string fileName)
		{
			string internalFileName = fileName;
			if (internalFileName.IndexOf("\\") == -1)
			{
				internalFileName = string.Format("{0}\\{1}", Directory.GetCurrentDirectory(), fileName);
			}
			InputFile = new FileInfo(internalFileName);
			if (InputFile.Exists)
			{
				SetupDirectories(InputFile);
				Extract(InputFile);
				DeleteUnwantedFiles();
				CreateVOBFiles();
				Cleanup();
			}
		}

		private void SetupDirectories(FileInfo fileInfo)
		{
			Directory.SetCurrentDirectory(fileInfo.Directory.FullName);
			TempDirectory.Create();
		}

		private void Extract(FileInfo fileInfo)
		{
			Process process = new Process();
			process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
			process.StartInfo.Arguments = string.Format("-y -o- e \"{0}\" \"{1}\"", fileInfo.FullName, TempDirectory);
			process.StartInfo.FileName = WinRAR;
			process.Start();
			process.WaitForExit();
		}

		private void DeleteUnwantedFiles()
		{
			foreach (FileInfo fileInfo in TempDirectory.GetFilesEx("*.bup|*.ifo"))
			{
				fileInfo.Delete();
			}
			foreach (FileInfo fileInfo in TempDirectory.GetFiles("*.vob"))
			{
				if (fileInfo.Length < 50000000)
				{
					fileInfo.Delete();
				}
			}
		}

		private void CreateVOBFiles()
		{
			Regex fileNameRegEx = new Regex("VTS_([0-9]{1,2})_([0-9]{1,2}).VOB", RegexOptions.Compiled | RegexOptions.Singleline);
			Dictionary<string, VOBInfo> files = new Dictionary<string, VOBInfo>();
			foreach (FileInfo file in TempDirectory.GetFiles("VTS_*_*.vob"))
			{
				MatchCollection mc = fileNameRegEx.Matches(file.Name);
				if (mc.Count > 0)
				{
					if (!files.ContainsKey(mc[0].Groups[1].Value))
					{
						files.Add(mc[0].Groups[1].Value, new VOBInfo(mc[0].Groups[1].Value));
					}
					files[mc[0].Groups[1].Value].Files.Add(file);
				}
			}
			string baseFileName = InputFile.Name.Remove(InputFile.Name.Length - InputFile.Extension.Length);
			List<VOBInfo> info = new List<VOBInfo>(files.Values);
			for (int i = 0; i < info.Count; i++)
			{
				Console.WriteLine(string.Format("{0} {1}.vob", baseFileName, info[i].Name));
				string parameters=string.Empty;
				foreach (FileInfo file in info[i].Files)
				{
					parameters += string.Format("{0} + ", file.Name);
				}
				if (!string.IsNullOrEmpty(parameters))
				{
					parameters = parameters.RemoveFromEnd(2);
					if (info[i].Files.Count > 1)
					{
						parameters = string.Format("/c copy /b {0} \"../{1} {2}.vob\"", parameters, baseFileName, info[i].Name);
					}
					else
					{
						parameters = string.Format("/c move {0} \"../{1} {2}.vob\"", parameters, baseFileName, info[i].Name);
					}
					CopyFiles(parameters);
				}
			}
		}

		private void CopyFiles(string parameters)
		{
			Process process = new Process();
			process.StartInfo.WorkingDirectory = TempDirectory.FullName;
			process.StartInfo.Arguments = parameters;
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
		}

		private string WinRAR
		{
			get { return string.Format(@"{0}\WinRar.exe", Properties.Settings.Default.WinRarProgramFolder); }
		}

		private DirectoryInfo TempDirectory
		{
			get
			{
				if (_tempDirectory == null)
				{
					_tempDirectory = new DirectoryInfo(string.Format("{0}\\{1}", Directory.GetCurrentDirectory(), Guid.NewGuid().ToString()));
				}
				return _tempDirectory;
			}
		}

		private FileInfo InputFile
		{
			get { return _inputFile; }
			set { _inputFile = value; }
		}

		private void Cleanup()
		{
			TempDirectory.Delete(true);
		}
	}
}
