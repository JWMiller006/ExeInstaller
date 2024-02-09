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
            updateGUI();
            checkForUpdates.Hide();
            updateInstaller.Hide();
        }

        public static volatile List<string> Applications = [];

        private void checkForUpdates_Click(object sender, EventArgs e)
        {
            updateGUI();
            checkForUpdates.Hide();
        }

        private void updateSource_DoWork(object sender, DoWorkEventArgs e)
        {
            ApplicationFunctions.DownloadAppData();
            Thread.Sleep(200);
            updateSource.ReportProgress(25);
            Applications = ApplicationFunctions.GetAppNames();
            Thread.Sleep(750);
            updateSource.ReportProgress(100);
        }

        private void updateSource_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.updateStatus.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 100)
            {
                this.updateStatus.Visible = false;
                this.statusLabel.Text = "Status: All Up to Date";
                this.appList.Nodes.Clear();
                List<string> publishers = App.GetPublishers(AppEnvironment.InstallableApps);
                foreach (string publisher in publishers)
                {
                    this.appList.Nodes.Add(publisher);
                }
                foreach (App app in AppEnvironment.InstallableApps)
                {
                    if (app.AppName != "ExeInstaller")
                    {
                        this.appList.Nodes[publishers.IndexOf(app.Publisher)].Nodes.Add(app.AppName);
                    }
                }
                Applications = ApplicationFunctions.GetAppNames();
                if (AppEnvironment.InstallableApps.Count == 0)
                {
                    this.statusLabel.Text = "Status: Error: No apps found";
                }
                try
                {
                    if (AppEnvironment.InstallableApps[Applications.IndexOf("ExeInstaller")].AppVersion != AppEnvironment.AppVersion)
                    {
                        if (!AppEnvironment.DebugMode)
                        {
                            this.statusLabel.Text = "Status: Update Available";
                            updateInstaller.Show();
                        }
                    }
                }
                catch (ArgumentOutOfRangeException) { }
                this.checkForUpdates.Show();
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
        private void updateGUI()
        {
            this.updateStatus.Value = 0;
            this.updateStatus.Maximum = 100;
            this.updateStatus.Visible = true;
            this.statusLabel.Text = "Status: Checking for updates...";
            updateSource.RunWorkerAsync();
        }

        private void updateInstaller_Click(object sender, EventArgs e)
        {
            ApplicationFunctions.UpdateInstaller();
            this.Dispose();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Login login = new();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.Yes)
            {
                // Go to admin mode
                Administrative admin = new();
                admin.Show();
            }
            else if (result == DialogResult.TryAgain)
            {
                adminButton_Click(new object(), new EventArgs());
            }
        }
    }
}
