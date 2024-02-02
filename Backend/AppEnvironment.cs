using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using MillerInc.UI.OutputFile;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ExeInstaller.Backend
{
    internal static class AppEnvironment
    {
        public static string AppVersion { get; private set; } = "1.0.0";

        public static string PathToAppData { get; private set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
            @"\MillerInc\Installer\";

        public static string AppDataUrl { get; private set; } = @"https://raw.githubusercontent.com/JWMiller006/ExeInstaller/master/downloadableContent.json";

        public static List<App> InstallableApps { get; set; } = []; 

        public static string InstallLocation { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\MillerInc\Installer\";

        public static void Initialize()
        {

            if (!System.IO.Directory.Exists(PathToAppData))
            {
                System.IO.Directory.CreateDirectory(PathToAppData);
            }
            try
            {
                File.Create(PathToAppData + @"output.txt");
                Output.WriteLine(PathToAppData + @"output.txt", "starting initialization");

            }
            catch { }
            if (!ApplicationFunctions.IsNetworkAvailable(1000))
            {
                //Output.WriteLine(PathToAppData + @"output.txt", "network available");
                ApplicationFunctions.DownloadAppData(); 
            }
            
        }

    }
}
