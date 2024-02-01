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

namespace ExeInstaller.Backend
{
    internal static class ApplicationFunctions
    {
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

        public static void DownloadAppData()
        {

            // Download app data from the server
            Thread downloader = new(async() =>
            {
                //Output.WriteLine(AppEnvironment.PathToAppData + @"output.txt", "download started");
                using (var client = new System.Net.Http.HttpClient()) // WebClient
                {
                    Stream stream; 
                    var fileName = AppEnvironment.PathToAppData + @"downloadedData.json";
                    var uri = new Uri(AppEnvironment.AppDataUrl);
                    System.IO.File.Delete(AppEnvironment.PathToAppData + @"downloadable.json");
                    stream = await client.GetStreamAsync(uri);
                    FileStream fs = new(AppEnvironment.PathToAppData + "downloadable.json",FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    await stream.CopyToAsync(fs);
                    fs.Flush();
                    await Task.Delay(100);
                    fs.Close();
                    stream.Close();
                    List<App>? apps = System.Text.Json.JsonSerializer.Deserialize<List<App>>(System.IO.File.ReadAllText(AppEnvironment.PathToAppData + "downloadable.json")); 

                    if (apps != null) AppEnvironment.InstallableApps = apps;
                }
                //Output.WriteLine(AppEnvironment.PathToAppData + @"output.txt", "download complete");

            });

            downloader.Start();
            

            /*using (WebClient wc = new())
            {
                wc.Headers.Add("a", "a");
                try
                {
                    wc.DownloadFile("https://github.com/github/platform-samples/blob/master/LICENSE.txt", AppEnvironment.PathToAppData + @"test.txt");
                }
                catch (Exception ex)
                {
                    Output.WriteLine(AppEnvironment.PathToAppData + @"output.txt", ex.Message);
                }
            }*/
        }
    }
}
