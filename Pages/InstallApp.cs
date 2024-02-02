using ExeInstaller.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeInstaller.Pages
{
    public partial class InstallApp : Form
    {
        public InstallApp()
        {
            InitializeComponent();
            this.Dispose();
        }

        public InstallApp(App app)
        {
            InitializeComponent();
            this.app = app;
            this.installationThread.RunWorkerAsync();
        }

        private App app = new();

        private void installationThread_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = app.DownloadUrls.Count;
            Parallel.ForEach(app.DownloadUrls, (url) =>
            {
                ApplicationFunctions.DownloadFile(url, AppEnvironment.InstallLocation + "\\"+ app.AppName + url.Substring(url.LastIndexOf("/")));
                total++;
                if (total < app.DownloadUrls.Count) 
                    installationThread.ReportProgress((int)((float)total * 100f / (float)app.DownloadUrls.Count));
            });
            installationThread.ReportProgress(100);
        }

        private void installationThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Text = "Installing " + app.AppName + ", Progress: " + e.ProgressPercentage + "%";
            this.installationProgress.Value = e.ProgressPercentage;
        }

        private void installationThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Finshed form = new Finshed();
            form.Show(); 
            this.Close();
        }
    }
}
