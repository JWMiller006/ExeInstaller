using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeInstallerBuilder.Backend
{
    public class App
    {
        public string AppVersion { get; private set; } = "1.0.0";

        public string AppName { get; private set; } = "not set";

        public List<string> DownloadUrls { get; private set; } = ["not set"];


    }
}
