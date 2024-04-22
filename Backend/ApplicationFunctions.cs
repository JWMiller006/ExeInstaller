using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Net;
using MillerInc.UI.OutputFile;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Configuration;
using System.Security.Policy;
using System.Diagnostics;

namespace ExeInstaller.Backend
{
    internal static class ApplicationFunctions
    {
        /// <summary>
        /// Is supposed to check if there access to the network, doesn't work currently
        /// </summary>
        /// <returns></returns>
        public static bool IsNetworkAvailable()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                string host = @"http://google.com";  
                bool result = false;
                Ping p = new();
                try
                {
                    PingReply reply = p.Send(host, 10000);
                    if (reply.Status == IPStatus.Success)
                        return true;
                }
                catch { }
                return result; 
            }
            return false; 
        }
        
        /// <summary>
        /// Is supposed to check if there access to the network, doesn't work currently
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static bool IsNetworkAvailable(int timeout)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                string host = @"http://google.com";  
                bool result = false;
                Ping p = new();
                try
                {
                    PingReply reply = p.Send(host, timeout);
                    if (reply.Status == IPStatus.Success)
                        return true;
                }
                catch {

                    //Output.WriteLine(AppEnvironment.PathToAppData + @"output.txt", "network not available");
                }
                return result; 
            }
            return false; 
        }

        /// <summary>
        /// Downloads the application data from the server
        /// </summary>
        public static void DownloadAppData()
        {

            // Download app data from the server
            Thread downloader = new(async() =>
            {
                //Output.WriteLine(AppEnvironment.PathToAppData + @"output.txt", "download started");
                using var client = new System.Net.Http.HttpClient(); // WebClient
                Stream stream;
                var fileName = AppEnvironment.PathToAppData + @"downloadedData.json";
                var uri = new Uri(AppEnvironment.AppDataUrl);
                System.IO.File.Delete(AppEnvironment.PathToAppData + @"downloadable.json");
                stream = await client.GetStreamAsync(uri);
                FileStream fs = new(AppEnvironment.PathToAppData + "downloadable.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                await stream.CopyToAsync(fs);
                fs.Flush();
                await Task.Delay(100);
                fs.Close();
                stream.Close();
                if (!System.IO.File.Exists(AppEnvironment.UsersApps))
                {
                    FileStream fstream = System.IO.File.Create(AppEnvironment.UsersApps);
                    fstream.Flush();
                    fstream.Close(); 
                    System.IO.File.WriteAllText(AppEnvironment.UsersApps, "{}");
                }
                List<App>? apps = System.Text.Json.JsonSerializer.Deserialize<List<App>>(System.IO.File.ReadAllText(AppEnvironment.PathToAppData + "downloadable.json"));
                List<App>? userApps;
                try
                {
                    userApps = System.Text.Json.JsonSerializer.Deserialize<List<App>>(System.IO.File.ReadAllText(AppEnvironment.UsersApps));
                }
                catch
                {
                    userApps = []; 
                }
                if (apps != null)
                {
                    AppEnvironment.InstallableApps = apps;
                }

                if (userApps != null)
                {
                    AppEnvironment.InstallableApps.AddRange(userApps);
                }

            });

            downloader.Start();
        }

        /// <summary>
        /// Downloads the application from the server
        /// </summary>
        /// <param name="app"></param>
        public static void DownloadApp(App app)
        {
            Parallel.ForEach(app.DownloadUrls, (url) => 
            {
                DownloadFile(url, AppEnvironment.InstallLocation + app.AppName + url.Substring(url.LastIndexOf("/")));
            });

        }
        
        public static void DownloadApp(App app, string installationLocation)
        {
            Parallel.ForEach(app.DownloadUrls, (url) => 
            {
                DownloadFile(url, installationLocation + "\\" + app.AppName + url.Substring(url.LastIndexOf("/")));
            });

        }

        /// <summary>
        /// Downloads a specific file from the server
        /// </summary>
        /// <param name="url">the url to the file</param>
        /// <param name="path">the path to save the file to</param>
        public static void DownloadFile(string url, string path)
        {
            Thread downloader = new(async() =>
            {
                using var client = new System.Net.Http.HttpClient(); // WebClient
                Stream stream;
                var fileName = path;
                fileName = fileName.Replace("%20", " "); 
                var uri = new Uri(url);
                if (System.IO.File.Exists(path))System.IO.File.Delete(path);
                if (!Directory.Exists(Path.GetFullPath(path.Replace(Path.GetFileName(path), "")))) 
                    Directory.CreateDirectory(Path.GetFullPath(path).Replace(Path.GetFileName(path), ""));
                stream = await client.GetStreamAsync(uri);
                FileStream fs = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                await stream.CopyToAsync(fs);
                fs.Flush();
                await Task.Delay(100);
                fs.Close();
                stream.Close();
            });

            downloader.Start();
        }

        /// <summary>
        /// Gets a list of application names from the installable apps
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAppNames()
        {
            List<string> names = []; 
            foreach (App app in AppEnvironment.InstallableApps)
            {
                names.Add(app.AppName);
            }
            return names; 
        }

        public static List<App> GetUpdates() 
        {
            List<App> updates = [];
            List<App>? installed = System.Text.Json.JsonSerializer.Deserialize<List<App>>(System.IO.File.ReadAllText(AppEnvironment.UsersApps));
            foreach (App app in AppEnvironment.InstallableApps)
            {
                if (app.SupportsMillerInc)
                {
                    if (app.DownloadUrls[app.DownloadUrls.Count - 1] != app.AppVersion)
                    {
                        updates.Add(app);
                    }
                }
            }
            return updates;
        }

        /// <summary>
        /// Gets the download from the server and relpaces the current version with the new version, 
        /// assumes that there is access to the network
        /// </summary>
        public static void UpdateInstaller()
        {
            Thread thread = new(() =>
            {
                DownloadApp(AppEnvironment.InstallableApps[GetAppNames().IndexOf("ExeInstaller")], AppEnvironment.PathToAppData + "\\Update");
                Thread.Sleep(10000);
                Process proc = new()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = @"C:\Windows\System32\cmd.exe", //+ "ExeInstaller\\Update\\updater.bat",
                        Arguments = "/C updater.bat " + Application.StartupPath +  " " +
                        AppEnvironment.PathToAppData + "\\Update\\ExeInstaller & cd " + Application.StartupPath + 
                        " &ExeInstaller.exe & exit",
                        UseShellExecute = true,
                        CreateNoWindow = false,
                        WorkingDirectory = AppEnvironment.PathToAppData + "Update\\ExeInstaller"
                    }
                };

                proc.Start();
            });
            thread.Start();
        }
    }
}
