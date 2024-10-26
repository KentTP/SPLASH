using System.Diagnostics;

namespace AppRunner.Runners
{
	public class RhinoRunner : IRunner
	{
		public void RunProcess()
		{
			LaunchRhino();
		}

		public void LaunchRhino()
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