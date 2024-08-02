using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;

namespace VGSoftware.Sharp.CodePad
{
	public static class Compiler
	{
		public static CompilerResults Compile(string code)
		{
			CSharpCodeProvider codeProvider = new CSharpCodeProvider();
			ICodeCompiler compiler = codeProvider.CreateCompiler();
			CompilerParameters parameters = new CompilerParameters();

			parameters.GenerateExecutable = true;
			parameters.OutputAssembly = "TestAnka.exe";
			parameters.IncludeDebugInformation = true;

			return compiler.CompileAssemblyFromSource(parameters, code);
/*			if (mainClass.Text.ToString() == "")
			{
				System.Windows.Forms.MessageBox.Show(this,
															 "Main Class Name cannot be empty");
				return;
			}

			parameters.MainClass = mainClass.Text.ToString();
			parameters.IncludeDebugInformation = includeDebug.Checked;

			// Add available assemblies - this should be enough for the simplest

			// applications.

			foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
			{
				parameters.ReferencedAssemblies.Add(asm.Location);
			}

			String code = textBox1.Text.ToString();
			//System.Windows.Forms.MessageBox.Show(this, code);


			CompilerResults results = compiler.CompileAssemblyFromSource(parameters,
																																	 code);

			if (results.Errors.Count > 0)
			{
				string errors = "Compilation failed:\n";
				foreach (CompilerError err in results.Errors)
				{
					errors += err.ToString() + "\n";
				}
				System.Windows.Forms.MessageBox.Show(this, errors,
															 "There were compilation errors");
			}
			else
			{
				#region Executing generated executable
				// try to execute application

				try
				{
					if (!System.IO.File.Exists(appName.Text.ToString()))
					{
						MessageBox.Show(String.Format("Can't find {0}", appName),
														"Can't execute.", MessageBoxButtons.OK,
														MessageBoxIcon.Error);
						return;
					}
					ProcessStartInfo pInfo = new ProcessStartInfo(appName.Text.ToString());
					Process.Start(pInfo);
				}
				catch (Exception ex)
				{
					MessageBox.Show(String.Format("Error while executing {0}",
									appName) + ex.ToString(), "Can't execute.",
									MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				#endregion

			}
			*/


		}



	}
}
