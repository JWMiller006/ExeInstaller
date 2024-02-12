using ExeInstaller.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeInstaller.Pages
{
    public partial class Administrative : Form
    {
        public Administrative()
        {
            InitializeComponent();
            this.UpdateUI();
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menu.Items[2].Enabled = false;
        }

        private string SavePath { get; set; } = "";

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 900);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.menu.Items[2].Enabled = true;
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Windows\system32\taskmgr.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.Verb = "runas";
            p.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void whatIsThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information information = new("Admin Info", "Question: \n\t\"What is this?\"\n" +
                "\nAnswer:\n\tYou are currently looking at the worlds best state of the art, piece of junk. ");
            information.ShowDialog();
        }

        private void whyAmISeeingThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information information = new("Admin Info", "Question: \n\t\"Why am I seeing this?\"\n" +
                "\nAnswer:\n\tMy question to you is: \n\t\t\"Are you?\"\n\n\tYou may very well be imagining things. ");
            information.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddApplicationButton_Click(object sender, EventArgs e)
        {
            App app = new()
            {
                AppName = this.appNameIn.Text,
                AppVersion = this.appVersionInput.Text,
                DownloadUrls = this.links.Lines.ToList(),
                Publisher = this.publisherInput.Text
            };
            AppEnvironment.InstallableApps.Add(app);
            List<App>? apps = JsonSerializer.Deserialize<List<App>>(System.IO.File.ReadAllText(AppEnvironment.UsersApps));
            apps ??= [];
            apps.Add(app);
            File.WriteAllText(AppEnvironment.UsersApps, JsonSerializer.Serialize(apps));
            this.Clear();
            this.statusText.Text = "App Added";
        }

        private void Clear()
        {
            this.appNameIn.Text = "";
            this.appVersionInput.Text = "";
            this.links.Text = "";
            this.publisherInput.Text = "";
        }

        private void mainContainer_TabIndexChanged(object sender, EventArgs e)
        {
            this.UpdateUI();
        }

        private void UpdateUI()
        {
            this.installedApps.Items.Clear();
            List<App>? apps = JsonSerializer.Deserialize<List<App>>(System.IO.File.ReadAllText(AppEnvironment.UsersApps));
            apps ??= [];
            foreach (App app in apps)
            {
                this.installedApps.Items.Add(app.AppName);
            }
            if (apps.Count() <= 0)
            {
                this.installedApps.Items.Add("No apps installed");
            }
            this.versionOut.Text = AppEnvironment.AppVersion;
            this.directoryOut.Text = AppEnvironment.PathToAppData;
        }

        private void uninstall_Click(object sender, EventArgs e)
        {
            List<string> items = GetCheckedItems();
            this.statusText.Text = "Uninstalling " + items.Count + " apps";
            foreach (string item in items)
            {
                AppEnvironment.InstallableApps.Remove(AppEnvironment.InstallableApps.Find(x => x.AppName == item));
            }
            List<App>? apps = JsonSerializer.Deserialize<List<App>>(System.IO.File.ReadAllText(AppEnvironment.UsersApps));
            apps ??= [];
            foreach (string item in items)
            {
                try
                {
                    apps.Remove(apps.Find(x => x.AppName == item));
                }
                catch (Exception) { }
            }
            File.WriteAllText(AppEnvironment.UsersApps, JsonSerializer.Serialize(apps));
            this.statusText.Text = "Cleaning Up...";
            Thread.Sleep(250);
            this.UpdateUI();
            this.statusText.Text = "Done";
        }

        private List<string> GetCheckedItems()
        {
            List<string> items = [];
            for (int i = 0; i <= (this.installedApps.Items.Count - 1); i++)
            {
                if (this.installedApps.GetItemChecked(i))
                {
                    if (installedApps.Items[i] != null)
                    {
                        items.Add(installedApps.Items[i].ToString());
                    }
                }
            }

            return items;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UpdateUI();
        }

        private void refreshPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UpdateUI();
        }

        private void directoryOut_Click(object sender, EventArgs e)
        {
            Process process = new()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "explorer.exe",
                    Arguments = AppEnvironment.PathToAppData
                }
            };
            process.Start();
        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFile.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                string file = this.openFile.FileName;
                string json = System.IO.File.ReadAllText(file);
                try
                {
                    App app = JsonSerializer.Deserialize<App>(json);
                    this.appNameIn.Text = app.AppName;
                    this.appVersionInput.Text = app.AppVersion;
                    this.links.Text = string.Join("\n", app.DownloadUrls);
                    this.publisherInput.Text = app.Publisher;
                }
                catch { }
                this.UpdateUI();
            }
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFile.Filter = "JSON Files|*.json";
            App app = new()
            {
                AppName = this.appNameIn.Text,
                AppVersion = this.appVersionInput.Text,
                DownloadUrls = this.links.Lines.ToList(),
                Publisher = this.publisherInput.Text
            };
            if (this.SavePath == "")
            {
                DialogResult result = this.saveFile.ShowDialog();
                if (result.Equals(DialogResult.OK))
                {
                    this.SavePath = this.saveFile.FileName;

                    System.IO.File.WriteAllText(this.SavePath, JsonSerializer.Serialize(app));
                }
            }
            else
            {
                System.IO.File.WriteAllText(this.SavePath, JsonSerializer.Serialize(app));
            }
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App app = new()
            {
                AppName = this.appNameIn.Text,
                AppVersion = this.appVersionInput.Text,
                DownloadUrls = this.links.Lines.ToList(),
                Publisher = this.publisherInput.Text
            };
            this.saveFile.Filter = "JSON Files|*.json";
            DialogResult result = this.saveFile.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                this.SavePath = this.saveFile.FileName;
                System.IO.File.WriteAllText(this.SavePath, JsonSerializer.Serialize(app));
            }
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App app = new()
            {
                AppName = this.appNameIn.Text,
                AppVersion = this.appVersionInput.Text,
                DownloadUrls = this.links.Lines.ToList(),
                Publisher = this.publisherInput.Text
            };
            this.saveFile.Filter = "Text Files|*.txt";
            DialogResult result = this.saveFile.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                this.SavePath = this.saveFile.FileName;
                System.IO.File.WriteAllText(this.SavePath, JsonSerializer.Serialize(app));
            }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            App app = new()
            {
                AppName = this.appNameIn.Text,
                AppVersion = this.appVersionInput.Text,
                DownloadUrls = this.links.Lines.ToList(),
                Publisher = this.publisherInput.Text
            };
            this.saveFile.Filter = "All Files|*.*";
            DialogResult result = this.saveFile.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                this.SavePath = this.saveFile.FileName;
                System.IO.File.WriteAllText(this.SavePath, JsonSerializer.Serialize(app));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Close the form
        }
    }
}
