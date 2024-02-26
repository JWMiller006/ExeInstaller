namespace ExeInstaller.Pages
{
    partial class Administrative
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrative));
            menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            txtToolStripMenuItem1 = new ToolStripMenuItem();
            jsonToolStripMenuItem1 = new ToolStripMenuItem();
            otherToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            jsonToolStripMenuItem = new ToolStripMenuItem();
            txtToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            smallWindowToolStripMenuItem = new ToolStripMenuItem();
            smallToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            largeToolStripMenuItem = new ToolStripMenuItem();
            taskManagerToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            whatIsThisToolStripMenuItem = new ToolStripMenuItem();
            whyAmISeeingThisToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            refreshPageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            statusText = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            mainContainer = new TabControl();
            InstallPage = new TabPage();
            URLInstructions = new Label();
            publisherInput = new TextBox();
            PublisherLabel = new Label();
            appVersionInput = new TextBox();
            AppVersionLabel = new Label();
            appNameIn = new TextBox();
            appNameLabel = new Label();
            AddApplicationButton = new Button();
            links = new RichTextBox();
            VersionPage = new TabPage();
            label2 = new Label();
            directoryOut = new Label();
            DirectoryLbl = new Label();
            versionOut = new Label();
            AppVersionLbl = new Label();
            unregisterPage = new TabPage();
            uninstall = new Button();
            installedApps = new CheckedListBox();
            notification = new NotifyIcon(components);
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            menu.SuspendLayout();
            statusBar.SuspendLayout();
            mainContainer.SuspendLayout();
            InstallPage.SuspendLayout();
            VersionPage.SuspendLayout();
            unregisterPage.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem, refreshToolStripMenuItem, exitToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 3, 0, 3);
            menu.Size = new Size(1239, 30);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtToolStripMenuItem1, jsonToolStripMenuItem1, otherToolStripMenuItem1 });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(143, 26);
            openToolStripMenuItem.Text = "Open...";
            // 
            // txtToolStripMenuItem1
            // 
            txtToolStripMenuItem1.Name = "txtToolStripMenuItem1";
            txtToolStripMenuItem1.Size = new Size(138, 26);
            txtToolStripMenuItem1.Text = ".txt";
            // 
            // jsonToolStripMenuItem1
            // 
            jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            jsonToolStripMenuItem1.Size = new Size(138, 26);
            jsonToolStripMenuItem1.Text = ".json";
            jsonToolStripMenuItem1.Click += jsonToolStripMenuItem1_Click;
            // 
            // otherToolStripMenuItem1
            // 
            otherToolStripMenuItem1.Name = "otherToolStripMenuItem1";
            otherToolStripMenuItem1.Size = new Size(138, 26);
            otherToolStripMenuItem1.Text = "Other...";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(143, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jsonToolStripMenuItem, txtToolStripMenuItem, otherToolStripMenuItem });
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(143, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // jsonToolStripMenuItem
            // 
            jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            jsonToolStripMenuItem.Size = new Size(129, 26);
            jsonToolStripMenuItem.Text = ".json";
            jsonToolStripMenuItem.Click += jsonToolStripMenuItem_Click;
            // 
            // txtToolStripMenuItem
            // 
            txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            txtToolStripMenuItem.Size = new Size(129, 26);
            txtToolStripMenuItem.Text = ".txt";
            txtToolStripMenuItem.Click += txtToolStripMenuItem_Click;
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(129, 26);
            otherToolStripMenuItem.Text = "Other";
            otherToolStripMenuItem.Click += otherToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(143, 26);
            closeToolStripMenuItem1.Text = "Close";
            closeToolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallWindowToolStripMenuItem, taskManagerToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // smallWindowToolStripMenuItem
            // 
            smallWindowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallToolStripMenuItem, mediumToolStripMenuItem, largeToolStripMenuItem });
            smallWindowToolStripMenuItem.Name = "smallWindowToolStripMenuItem";
            smallWindowToolStripMenuItem.Size = new Size(182, 26);
            smallWindowToolStripMenuItem.Text = "Window";
            smallWindowToolStripMenuItem.Click += windowToolStripMenuItem_Click;
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(147, 26);
            smallToolStripMenuItem.Text = "Small";
            smallToolStripMenuItem.Click += smallToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(147, 26);
            mediumToolStripMenuItem.Text = "Medium";
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            // 
            // largeToolStripMenuItem
            // 
            largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            largeToolStripMenuItem.Size = new Size(147, 26);
            largeToolStripMenuItem.Text = "Large";
            largeToolStripMenuItem.Click += largeToolStripMenuItem_Click;
            // 
            // taskManagerToolStripMenuItem
            // 
            taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            taskManagerToolStripMenuItem.Size = new Size(182, 26);
            taskManagerToolStripMenuItem.Text = "Task Manager";
            taskManagerToolStripMenuItem.Click += taskManagerToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whatIsThisToolStripMenuItem, whyAmISeeingThisToolStripMenuItem, closeToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // whatIsThisToolStripMenuItem
            // 
            whatIsThisToolStripMenuItem.Name = "whatIsThisToolStripMenuItem";
            whatIsThisToolStripMenuItem.Size = new Size(235, 26);
            whatIsThisToolStripMenuItem.Text = "What is this?";
            whatIsThisToolStripMenuItem.Click += whatIsThisToolStripMenuItem_Click;
            // 
            // whyAmISeeingThisToolStripMenuItem
            // 
            whyAmISeeingThisToolStripMenuItem.Name = "whyAmISeeingThisToolStripMenuItem";
            whyAmISeeingThisToolStripMenuItem.Size = new Size(235, 26);
            whyAmISeeingThisToolStripMenuItem.Text = "Why am I seeing this?";
            whyAmISeeingThisToolStripMenuItem.Click += whyAmISeeingThisToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(235, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshPageToolStripMenuItem });
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(72, 24);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // refreshPageToolStripMenuItem
            // 
            refreshPageToolStripMenuItem.Name = "refreshPageToolStripMenuItem";
            refreshPageToolStripMenuItem.Size = new Size(177, 26);
            refreshPageToolStripMenuItem.Text = "Refresh Page";
            refreshPageToolStripMenuItem.Click += refreshPageToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { statusText, toolStripProgressBar1 });
            statusBar.Location = new Point(0, 788);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 16, 0);
            statusBar.Size = new Size(1239, 27);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            statusText.BackColor = SystemColors.Control;
            statusText.Name = "statusText";
            statusText.Padding = new Padding(0, 0, 30, 0);
            statusText.Size = new Size(218, 21);
            statusText.Text = "Status: Nothing Happening";
            statusText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(101, 19);
            toolStripProgressBar1.Visible = false;
            // 
            // mainContainer
            // 
            mainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainContainer.Controls.Add(InstallPage);
            mainContainer.Controls.Add(VersionPage);
            mainContainer.Controls.Add(unregisterPage);
            mainContainer.Location = new Point(0, 35);
            mainContainer.Margin = new Padding(3, 4, 3, 4);
            mainContainer.Name = "mainContainer";
            mainContainer.SelectedIndex = 0;
            mainContainer.Size = new Size(1239, 751);
            mainContainer.TabIndex = 2;
            mainContainer.TabIndexChanged += mainContainer_TabIndexChanged;
            // 
            // InstallPage
            // 
            InstallPage.BackColor = Color.PaleVioletRed;
            InstallPage.Controls.Add(URLInstructions);
            InstallPage.Controls.Add(publisherInput);
            InstallPage.Controls.Add(PublisherLabel);
            InstallPage.Controls.Add(appVersionInput);
            InstallPage.Controls.Add(AppVersionLabel);
            InstallPage.Controls.Add(appNameIn);
            InstallPage.Controls.Add(appNameLabel);
            InstallPage.Controls.Add(AddApplicationButton);
            InstallPage.Controls.Add(links);
            InstallPage.Location = new Point(4, 29);
            InstallPage.Margin = new Padding(3, 4, 3, 4);
            InstallPage.Name = "InstallPage";
            InstallPage.Padding = new Padding(3, 4, 3, 4);
            InstallPage.Size = new Size(1231, 718);
            InstallPage.TabIndex = 0;
            InstallPage.Text = "Register Application";
            // 
            // URLInstructions
            // 
            URLInstructions.Anchor = AnchorStyles.Top;
            URLInstructions.AutoSize = true;
            URLInstructions.Location = new Point(29, 173);
            URLInstructions.Name = "URLInstructions";
            URLInstructions.Size = new Size(538, 60);
            URLInstructions.TabIndex = 8;
            URLInstructions.Text = "Enter the Downloadable URLs for the application\r\nExample: \r\nhttps://raw.githubusercontent.com/JWMiller006/ExeInstaller/master/updater.bat";
            // 
            // publisherInput
            // 
            publisherInput.Anchor = AnchorStyles.Top;
            publisherInput.BackColor = Color.FromArgb(64, 64, 64);
            publisherInput.BorderStyle = BorderStyle.None;
            publisherInput.ForeColor = SystemColors.Window;
            publisherInput.Location = new Point(736, 197);
            publisherInput.Margin = new Padding(3, 4, 3, 4);
            publisherInput.Name = "publisherInput";
            publisherInput.Size = new Size(471, 20);
            publisherInput.TabIndex = 7;
            // 
            // PublisherLabel
            // 
            PublisherLabel.Anchor = AnchorStyles.Top;
            PublisherLabel.AutoSize = true;
            PublisherLabel.Location = new Point(736, 173);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(101, 20);
            PublisherLabel.TabIndex = 6;
            PublisherLabel.Text = "App Publisher";
            // 
            // appVersionInput
            // 
            appVersionInput.Anchor = AnchorStyles.Top;
            appVersionInput.BackColor = Color.FromArgb(64, 64, 64);
            appVersionInput.BorderStyle = BorderStyle.None;
            appVersionInput.ForeColor = SystemColors.Window;
            appVersionInput.Location = new Point(736, 124);
            appVersionInput.Margin = new Padding(3, 4, 3, 4);
            appVersionInput.Name = "appVersionInput";
            appVersionInput.Size = new Size(471, 20);
            appVersionInput.TabIndex = 5;
            // 
            // AppVersionLabel
            // 
            AppVersionLabel.Anchor = AnchorStyles.Top;
            AppVersionLabel.AutoSize = true;
            AppVersionLabel.Location = new Point(736, 100);
            AppVersionLabel.Name = "AppVersionLabel";
            AppVersionLabel.Size = new Size(89, 20);
            AppVersionLabel.TabIndex = 4;
            AppVersionLabel.Text = "App Version";
            // 
            // appNameIn
            // 
            appNameIn.Anchor = AnchorStyles.Top;
            appNameIn.BackColor = Color.FromArgb(64, 64, 64);
            appNameIn.BorderStyle = BorderStyle.None;
            appNameIn.ForeColor = SystemColors.Window;
            appNameIn.Location = new Point(29, 124);
            appNameIn.Margin = new Padding(3, 4, 3, 4);
            appNameIn.Name = "appNameIn";
            appNameIn.Size = new Size(701, 20);
            appNameIn.TabIndex = 3;
            // 
            // appNameLabel
            // 
            appNameLabel.Anchor = AnchorStyles.Top;
            appNameLabel.AutoSize = true;
            appNameLabel.Location = new Point(29, 100);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(81, 20);
            appNameLabel.TabIndex = 2;
            appNameLabel.Text = "App Name";
            // 
            // AddApplicationButton
            // 
            AddApplicationButton.Anchor = AnchorStyles.Top;
            AddApplicationButton.Location = new Point(561, 597);
            AddApplicationButton.Margin = new Padding(3, 4, 3, 4);
            AddApplicationButton.Name = "AddApplicationButton";
            AddApplicationButton.Size = new Size(126, 51);
            AddApplicationButton.TabIndex = 1;
            AddApplicationButton.Text = "Add App";
            AddApplicationButton.UseVisualStyleBackColor = true;
            AddApplicationButton.Click += AddApplicationButton_Click;
            // 
            // links
            // 
            links.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            links.BackColor = Color.FromArgb(64, 64, 64);
            links.BorderStyle = BorderStyle.None;
            links.ForeColor = SystemColors.Window;
            links.Location = new Point(32, 256);
            links.Name = "links";
            links.Size = new Size(1171, 335);
            links.TabIndex = 0;
            links.Text = "";
            // 
            // VersionPage
            // 
            VersionPage.BackColor = Color.LightPink;
            VersionPage.Controls.Add(label2);
            VersionPage.Controls.Add(directoryOut);
            VersionPage.Controls.Add(DirectoryLbl);
            VersionPage.Controls.Add(versionOut);
            VersionPage.Controls.Add(AppVersionLbl);
            VersionPage.Location = new Point(4, 29);
            VersionPage.Margin = new Padding(3, 4, 3, 4);
            VersionPage.Name = "VersionPage";
            VersionPage.Padding = new Padding(3, 4, 3, 4);
            VersionPage.Size = new Size(1231, 718);
            VersionPage.TabIndex = 1;
            VersionPage.Text = "Current Version Info";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(499, 668);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 4;
            label2.Text = "Copyright 2024 J Miller; Miller Inc";
            // 
            // directoryOut
            // 
            directoryOut.Anchor = AnchorStyles.Top;
            directoryOut.AutoSize = true;
            directoryOut.Location = new Point(555, 207);
            directoryOut.Name = "directoryOut";
            directoryOut.Size = new Size(27, 20);
            directoryOut.TabIndex = 3;
            directoryOut.Text = "C:\\";
            directoryOut.Click += directoryOut_Click;
            // 
            // DirectoryLbl
            // 
            DirectoryLbl.Anchor = AnchorStyles.Top;
            DirectoryLbl.AutoSize = true;
            DirectoryLbl.Location = new Point(429, 207);
            DirectoryLbl.Name = "DirectoryLbl";
            DirectoryLbl.Size = new Size(145, 20);
            DirectoryLbl.TabIndex = 2;
            DirectoryLbl.Text = "App Data Directory: ";
            // 
            // versionOut
            // 
            versionOut.Anchor = AnchorStyles.Top;
            versionOut.AutoSize = true;
            versionOut.Location = new Point(553, 187);
            versionOut.Name = "versionOut";
            versionOut.Size = new Size(42, 20);
            versionOut.TabIndex = 1;
            versionOut.Text = "*.*.*.*";
            // 
            // AppVersionLbl
            // 
            AppVersionLbl.Anchor = AnchorStyles.Top;
            AppVersionLbl.AutoSize = true;
            AppVersionLbl.Location = new Point(499, 187);
            AppVersionLbl.Name = "AppVersionLbl";
            AppVersionLbl.Size = new Size(64, 20);
            AppVersionLbl.TabIndex = 0;
            AppVersionLbl.Text = "Version: ";
            // 
            // unregisterPage
            // 
            unregisterPage.BackColor = Color.Gray;
            unregisterPage.Controls.Add(uninstall);
            unregisterPage.Controls.Add(installedApps);
            unregisterPage.Location = new Point(4, 29);
            unregisterPage.Margin = new Padding(3, 4, 3, 4);
            unregisterPage.Name = "unregisterPage";
            unregisterPage.Padding = new Padding(3, 4, 3, 4);
            unregisterPage.Size = new Size(1231, 718);
            unregisterPage.TabIndex = 2;
            unregisterPage.Text = "Unregister App";
            // 
            // uninstall
            // 
            uninstall.Anchor = AnchorStyles.None;
            uninstall.Location = new Point(487, 552);
            uninstall.Margin = new Padding(3, 4, 3, 4);
            uninstall.Name = "uninstall";
            uninstall.Size = new Size(193, 61);
            uninstall.TabIndex = 1;
            uninstall.Text = "Uninstall Selected Apps";
            uninstall.UseVisualStyleBackColor = true;
            uninstall.Click += uninstall_Click;
            // 
            // installedApps
            // 
            installedApps.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            installedApps.FormattingEnabled = true;
            installedApps.Items.AddRange(new object[] { "no user installed apps are available" });
            installedApps.Location = new Point(277, 176);
            installedApps.Margin = new Padding(3, 4, 3, 4);
            installedApps.Name = "installedApps";
            installedApps.Size = new Size(622, 334);
            installedApps.TabIndex = 0;
            // 
            // notification
            // 
            notification.Icon = (Icon)resources.GetObject("notification.Icon");
            notification.Text = "Notification This Is\r\nYou are a fool to read this\r\nBye Bye";
            notification.Visible = true;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            openFile.FileOk += openFile_FileOk;
            // 
            // Administrative
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1239, 815);
            Controls.Add(mainContainer);
            Controls.Add(statusBar);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1255, 851);
            Name = "Administrative";
            Text = "Admin Page";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            mainContainer.ResumeLayout(false);
            InstallPage.ResumeLayout(false);
            InstallPage.PerformLayout();
            VersionPage.ResumeLayout(false);
            VersionPage.PerformLayout();
            unregisterPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem txtToolStripMenuItem1;
        private ToolStripMenuItem jsonToolStripMenuItem1;
        private ToolStripMenuItem otherToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem jsonToolStripMenuItem;
        private ToolStripMenuItem txtToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private ToolStripMenuItem smallWindowToolStripMenuItem;
        private ToolStripMenuItem whatIsThisToolStripMenuItem;
        private ToolStripMenuItem whyAmISeeingThisToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem largeToolStripMenuItem;
        private ToolStripMenuItem taskManagerToolStripMenuItem;
        private StatusStrip statusBar;
        private TabControl mainContainer;
        private TabPage InstallPage;
        private TabPage VersionPage;
        private ToolStripStatusLabel statusText;
        private ToolStripProgressBar toolStripProgressBar1;
        private RichTextBox links;
        private Button AddApplicationButton;
        private TextBox appNameIn;
        private Label appNameLabel;
        private TextBox appVersionInput;
        private Label AppVersionLabel;
        private Label URLInstructions;
        private TextBox publisherInput;
        private Label PublisherLabel;
        private NotifyIcon notification;
        private TabPage unregisterPage;
        private CheckedListBox installedApps;
        private Button uninstall;
        private Label directoryOut;
        private Label DirectoryLbl;
        private Label versionOut;
        private Label AppVersionLbl;
        private Label label2;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem refreshPageToolStripMenuItem;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}