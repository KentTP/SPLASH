using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRunner.Runners
{
	public class RhinoComputeRunner : IRunner
	{
		public void RunProcess()
		{
			LaunchRhinoCompute();
		}

		public void LaunchRhinoCompute()
		{
			//string rhinoPath = @"C:\Program Files\Rhino 8\System\Rhino.exe";
			string rhinoPath = @"C:\repos\compute.rhino3d\src\bin\Debug\rhino.compute\rhino.compute.exe";

			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = rhinoPath,
				Arguments = "", // Add any command-line arguments here if needed
                UseShellExecute = true // Use the operating system shell to start the process
            };

			try
			{
				Process rhinoProcess = Process.Start(startInfo);
				Console.WriteLine("Rhino has been started.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An error occurred while starting Rhino: {ex.Message}");
			}
		}
	}
}