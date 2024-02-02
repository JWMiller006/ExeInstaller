using ExeInstaller.Backend;
using ExeInstaller.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExeInstaller
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        public static volatile List<string> Applications = [];

        private void checkForUpdates_Click(object sender, EventArgs e)
        {
            this.updateStatus.Value = 0;
            this.updateStatus.Maximum = 100;
            this.updateStatus.Visible = true;
            this.statusLabel.Text = "Status: Checking for updates...";
            updateSource.RunWorkerAsync();
        }

        private void updateSource_DoWork(object sender, DoWorkEventArgs e)
        {
            ApplicationFunctions.DownloadAppData();
            Thread.Sleep(200);
            updateSource.ReportProgress(25);
            Applications = ApplicationFunctions.GetAppNames();
            Thread.Sleep(200);
            updateSource.ReportProgress(100);
        }

        private void updateSource_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.updateStatus.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 100)
            {
                this.updateStatus.Visible = false;
                this.statusLabel.Text = "Status: All Up to Date";
                this.appList.Nodes[0].Nodes.Clear();
                foreach (string app in Applications)
                {
                    this.appList.Nodes[0].Nodes.Add(app);
                }
            }

        }

        private void installSelected_Click(object sender, EventArgs e)
        {
            TreeNode node = this.appList.SelectedNode;
            App? app = AppEnvironment.InstallableApps.Find(x => x.AppName == node.Text);
            if (app == null)
            {
                MessageBox.Show("Error: App not found");
            }
            else
            {
                DialogResult result = this.chooseInstallationDirectory.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AppEnvironment.InstallLocation = this.chooseInstallationDirectory.SelectedPath;

                    InstallApp install = new(app);
                    install.ShowDialog();

                }
            }
        }
    }
}
