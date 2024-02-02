using ExeInstaller.Backend;
using System.Text.Json;

namespace ExeInstaller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            if (args.Length > 0)
            {
                if (args[0] == "finish update")
                {
                    string path = Application.StartupPath;
                    List<string> files = System.IO.Directory.GetFiles(path).ToList();
                    foreach (string file in files)
                    {
                        if (file.Contains("update"))
                        {
                            System.IO.File.Delete(file);
                        }
                    }
                }
            }

            ApplicationConfiguration.Initialize();
            AppEnvironment.Initialize();
            Application.Run(new LandingPage());
        }
    }
}