using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;

namespace VGSoftware.CodePad.Build
{
	public class Compiler
	{
		private static Compiler _instance;
		private static object _instanceLock = new object();

		private Compiler()
		{
		}

		public static Compiler Default
		{
			get
			{
				if (_instance == null)
				{
					lock (_instanceLock)
					{
						if (_instance == null)
						{
							_instance = new Compiler();
						}
					}
				}
				return _instance;
			}
		}

		public CompilerResults Compile(string code)
		{
			Dictionary<string, string> providerOptions = new Dictionary<string, string>();
			string compilerVersion = Enum.GetName(typeof(Enums.CompilerVersionType), Properties.Settings.Default.Compiler_NetVersion).Replace('_', '.');
			providerOptions.Add("CompilerVersion", compilerVersion);
			CodeDomProvider compiler = new CSharpCodeProvider(providerOptions);
			return compiler.CompileAssemblyFromSource(Parameters, code);
		}

		private CompilerParameters Parameters
		{
			get
			{
				CompilerParameters parameters = new CompilerParameters();
				parameters.WarningLevel = Properties.Settings.Default.Compiler_WarningLevel;
				parameters.TreatWarningsAsErrors = Properties.Settings.Default.Compiler_WarningsAsError;
				parameters.IncludeDebugInformation = Properties.Settings.Default.Compiler_DebugAssembly;
				parameters.GenerateExecutable = true;
				parameters.OutputAssembly = GetOutputFile();


				var assemblies = AppDomain.CurrentDomain
														.GetAssemblies()
														.Where(a => !a.IsDynamic)
														.Select(a => a.Location);
				foreach(var assembly in assemblies)
				{
					parameters.ReferencedAssemblies.Add(assembly);
				}
				//parameters.ReferencedAssemblies.AddRange(.ToArray());



				if (Properties.Settings.Default.References != null)
				{
					foreach (string path in Properties.Settings.Default.References)
					{
						parameters.ReferencedAssemblies.Add(path);
					}
				}
				return parameters;
			}
		}

		private string GetOutputFile()
		{
			DirectoryInfo directory = new DirectoryInfo(Properties.Settings.Default.Compiler_OutputDirectory);
			if (!directory.Exists)
			{
				directory.Create();
			}

			FileInfo file = null;
			do
			{
				file = new FileInfo(Path.Combine(directory.FullName, Path.ChangeExtension(Path.GetRandomFileName(), ".exe")));
			} while (file.Exists);
			return file.FullName;
		}
	}
}
