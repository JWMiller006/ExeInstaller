using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeInstaller.Backend
{
    public class App
    {
        public string AppVersion { get; set; } = "1.0.0";

        public string AppName { get; set; } = "not set";

        public List<string> DownloadUrls { get; set; } = ["not set"];

        public string Publisher { get; set; } = "MillerInc";

        public static List<string> GetPublishers(List<App> apps)
        {
            List<string> publishers = [];
            foreach (App app in apps)
            {
                if (!publishers.Contains(app.Publisher))
                {
                    publishers.Add(app.Publisher);
                }
            }
            return publishers;
        }
    }

}
