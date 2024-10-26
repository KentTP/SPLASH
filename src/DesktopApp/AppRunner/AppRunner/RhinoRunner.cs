using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRunner
{
	public static class RhinoRunner
	{
		public static void LaunchRhino()
		{
			string rhinoPath = @"C:\Program Files\Rhino 8\System\Rhino.exe";

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