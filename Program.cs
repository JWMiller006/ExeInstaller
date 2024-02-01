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
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppEnvironment.Initialize();
            Application.Run(new LandingPage());
            /*
            AppEnvironment.InstallableApps.Add(new());
            AppEnvironment.InstallableApps[0].AppName = "DataExtractionEngine";
            AppEnvironment.InstallableApps[0].AppVersion = "1.0.0";
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/DataExtractionEngine.deps.json");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/DataExtractionEngine.dll");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/DataExtractionEngine.exe");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/DataExtractionEngine.pdb");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/DataExtractionEngine.runtimeconfig.json");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/MillerInc.ML.NeuralNetwork.dll");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/MillerInc.dll");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/NeuralNetowrk.dll");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/Newtonsoft.Json.dll");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/count.txt");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/output.ex.txt");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/output.txt");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/output0.txt");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/output1.txt");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/output2.txt");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/output3.txt");
            AppEnvironment.InstallableApps[0].DownloadUrls.Add("https://raw.githubusercontent.com/JWMiller006/DataExtractionEngine/main/bin/Debug/net8.0-windows/trained%20network.json");
            string output = System.Text.Json.JsonSerializer.Serialize(AppEnvironment.InstallableApps);
            File.WriteAllText(AppEnvironment.PathToAppData + "downloadable.json", output);*/
        }
    }
}