namespace ExeInstaller
{
    partial class LandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("From Miller Inc");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            chooseInstallationDirectory = new FolderBrowserDialog();
            updateSource = new System.ComponentModel.BackgroundWorker();
            checkForUpdates = new Button();
            landingPageStatus = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            updateStatus = new ToolStripProgressBar();
            availableAppsPanel = new Panel();
            appList = new TreeView();
            installSelected = new Button();
            landingPageStatus.SuspendLayout();
            availableAppsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // chooseInstallationDirectory
            // 
            chooseInstallationDirectory.Description = "Choose Installation Directory";
            chooseInstallationDirectory.RootFolder = Environment.SpecialFolder.ProgramFilesX86;
            chooseInstallationDirectory.ShowHiddenFiles = true;
            // 
            // updateSource
            // 
            updateSource.WorkerReportsProgress = true;
            updateSource.DoWork += updateSource_DoWork;
            updateSource.ProgressChanged += updateSource_ProgressChanged;
            // 
            // checkForUpdates
            // 
            checkForUpdates.Location = new Point(12, 12);
            checkForUpdates.Name = "checkForUpdates";
            checkForUpdates.Size = new Size(131, 36);
            checkForUpdates.TabIndex = 0;
            checkForUpdates.Text = "Check For Updates";
            checkForUpdates.UseVisualStyleBackColor = true;
            checkForUpdates.Click += checkForUpdates_Click;
            // 
            // landingPageStatus
            // 
            landingPageStatus.Items.AddRange(new ToolStripItem[] { statusLabel, updateStatus });
            landingPageStatus.Location = new Point(0, 428);
            landingPageStatus.Name = "landingPageStatus";
            landingPageStatus.Size = new Size(800, 22);
            landingPageStatus.TabIndex = 1;
            landingPageStatus.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.BackColor = SystemColors.Control;
            statusLabel.Name = "statusLabel";
            statusLabel.Padding = new Padding(100, 0, 0, 0);
            statusLabel.Size = new Size(145, 17);
            statusLabel.Text = "Status: ";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateStatus
            // 
            updateStatus.Name = "updateStatus";
            updateStatus.Size = new Size(100, 16);
            updateStatus.Style = ProgressBarStyle.Continuous;
            updateStatus.Visible = false;
            // 
            // availableAppsPanel
            // 
            availableAppsPanel.Controls.Add(appList);
            availableAppsPanel.Location = new Point(12, 54);
            availableAppsPanel.Name = "availableAppsPanel";
            availableAppsPanel.Size = new Size(776, 329);
            availableAppsPanel.TabIndex = 2;
            // 
            // appList
            // 
            appList.Dock = DockStyle.Fill;
            appList.Location = new Point(0, 0);
            appList.Name = "appList";
            treeNode1.Name = "millerincapps";
            treeNode1.Text = "From Miller Inc";
            appList.Nodes.AddRange(new TreeNode[] { treeNode1 });
            appList.Size = new Size(776, 329);
            appList.TabIndex = 0;
            // 
            // installSelected
            // 
            installSelected.Location = new Point(636, 389);
            installSelected.Name = "installSelected";
            installSelected.Size = new Size(152, 36);
            installSelected.TabIndex = 3;
            installSelected.Text = "Install Selected App";
            installSelected.UseVisualStyleBackColor = true;
            installSelected.Click += installSelected_Click;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(installSelected);
            Controls.Add(availableAppsPanel);
            Controls.Add(landingPageStatus);
            Controls.Add(checkForUpdates);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LandingPage";
            Text = "LandingPage";
            landingPageStatus.ResumeLayout(false);
            landingPageStatus.PerformLayout();
            availableAppsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog chooseInstallationDirectory;
        private System.ComponentModel.BackgroundWorker updateSource;
        private Button checkForUpdates;
        private StatusStrip landingPageStatus;
        private ToolStripStatusLabel statusLabel;
        private ToolStripProgressBar updateStatus;
        private Panel availableAppsPanel;
        private TreeView appList;
        private Button installSelected;
    }
}