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
            updateInstaller = new Button();
            adminButton = new Button();
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
            checkForUpdates.Location = new Point(14, 16);
            checkForUpdates.Margin = new Padding(3, 4, 3, 4);
            checkForUpdates.Name = "checkForUpdates";
            checkForUpdates.Size = new Size(150, 48);
            checkForUpdates.TabIndex = 0;
            checkForUpdates.Text = "Check For Updates";
            checkForUpdates.UseVisualStyleBackColor = true;
            checkForUpdates.Click += checkForUpdates_Click;
            // 
            // landingPageStatus
            // 
            landingPageStatus.ImageScalingSize = new Size(20, 20);
            landingPageStatus.Items.AddRange(new ToolStripItem[] { statusLabel, updateStatus });
            landingPageStatus.Location = new Point(0, 589);
            landingPageStatus.Name = "landingPageStatus";
            landingPageStatus.Padding = new Padding(1, 0, 16, 0);
            landingPageStatus.Size = new Size(553, 26);
            landingPageStatus.TabIndex = 1;
            landingPageStatus.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.BackColor = SystemColors.Control;
            statusLabel.Name = "statusLabel";
            statusLabel.Padding = new Padding(100, 0, 0, 0);
            statusLabel.Size = new Size(156, 20);
            statusLabel.Text = "Status: ";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // updateStatus
            // 
            updateStatus.Name = "updateStatus";
            updateStatus.Size = new Size(114, 19);
            updateStatus.Style = ProgressBarStyle.Continuous;
            updateStatus.Visible = false;
            // 
            // availableAppsPanel
            // 
            availableAppsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            availableAppsPanel.Controls.Add(appList);
            availableAppsPanel.Location = new Point(14, 72);
            availableAppsPanel.Margin = new Padding(3, 4, 3, 4);
            availableAppsPanel.Name = "availableAppsPanel";
            availableAppsPanel.Size = new Size(526, 453);
            availableAppsPanel.TabIndex = 2;
            // 
            // appList
            // 
            appList.Dock = DockStyle.Fill;
            appList.Location = new Point(0, 0);
            appList.Margin = new Padding(3, 4, 3, 4);
            appList.Name = "appList";
            treeNode1.Name = "millerincapps";
            treeNode1.Text = "From Miller Inc";
            appList.Nodes.AddRange(new TreeNode[] { treeNode1 });
            appList.Size = new Size(526, 453);
            appList.TabIndex = 0;
            // 
            // installSelected
            // 
            installSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            installSelected.Location = new Point(366, 533);
            installSelected.Margin = new Padding(3, 4, 3, 4);
            installSelected.Name = "installSelected";
            installSelected.Size = new Size(174, 48);
            installSelected.TabIndex = 3;
            installSelected.Text = "Install Selected App";
            installSelected.UseVisualStyleBackColor = true;
            installSelected.Click += installSelected_Click;
            // 
            // updateInstaller
            // 
            updateInstaller.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateInstaller.Location = new Point(390, 16);
            updateInstaller.Margin = new Padding(3, 4, 3, 4);
            updateInstaller.Name = "updateInstaller";
            updateInstaller.Size = new Size(150, 48);
            updateInstaller.TabIndex = 4;
            updateInstaller.Text = "Update Installer";
            updateInstaller.UseVisualStyleBackColor = true;
            updateInstaller.Click += updateInstaller_Click;
            // 
            // adminButton
            // 
            adminButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            adminButton.BackColor = Color.Transparent;
            adminButton.FlatAppearance.BorderSize = 0;
            adminButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            adminButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.ForeColor = Color.LightSkyBlue;
            adminButton.Location = new Point(12, 533);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(84, 48);
            adminButton.TabIndex = 5;
            adminButton.Text = "Admin Mode";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(553, 615);
            Controls.Add(adminButton);
            Controls.Add(updateInstaller);
            Controls.Add(installSelected);
            Controls.Add(availableAppsPanel);
            Controls.Add(landingPageStatus);
            Controls.Add(checkForUpdates);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(569, 651);
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
        private Button updateInstaller;
        private Button adminButton;
    }
}