using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using MillerInc.UI.OutputFile;

namespace ExeInstallerBuilder.Backend
{
    internal static class AppEnvironment
    {
        public static string AppVersion { get; private set; } = "1.0.0";

        public static string PathToAppData { get; private set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
            @"\MillerInc\Installer\";

        public static string AppDataUrl { get; private set; } = @"https://raw.githubusercontent.com/JWMiller006/MillerInc/master/README.md";


        public static void Initialize()
        {

            Output.WriteLine(PathToAppData + @"output.txt", "starting initialization");
            if (!System.IO.Directory.Exists(PathToAppData))
            {
                System.IO.Directory.CreateDirectory(PathToAppData);
            }
            
            if (!ApplicationFunctions.IsNetworkAvailable(1000))
            {
                Output.WriteLine(PathToAppData + @"output.txt", "network available");
                ApplicationFunctions.DownloadAppData(); 
            }
        }

    }
}
