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
            statusBar = new StatusStrip();
            mainContainer = new TabControl();
            InstallPage = new TabPage();
            VersionPage = new TabPage();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            links = new RichTextBox();
            menu.SuspendLayout();
            statusBar.SuspendLayout();
            mainContainer.SuspendLayout();
            InstallPage.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 3, 0, 3);
            menu.Size = new Size(1246, 30);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
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
            // 
            // txtToolStripMenuItem
            // 
            txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            txtToolStripMenuItem.Size = new Size(129, 26);
            txtToolStripMenuItem.Text = ".txt";
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(129, 26);
            otherToolStripMenuItem.Text = "Other";
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
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusBar.Location = new Point(0, 707);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 16, 0);
            statusBar.Size = new Size(1246, 26);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // mainContainer
            // 
            mainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainContainer.Controls.Add(InstallPage);
            mainContainer.Controls.Add(VersionPage);
            mainContainer.Location = new Point(0, 34);
            mainContainer.Margin = new Padding(3, 4, 3, 4);
            mainContainer.Name = "mainContainer";
            mainContainer.SelectedIndex = 0;
            mainContainer.Size = new Size(1246, 669);
            mainContainer.TabIndex = 2;
            // 
            // InstallPage
            // 
            InstallPage.BackColor = Color.PaleVioletRed;
            InstallPage.Controls.Add(links);
            InstallPage.Location = new Point(4, 29);
            InstallPage.Margin = new Padding(3, 4, 3, 4);
            InstallPage.Name = "InstallPage";
            InstallPage.Padding = new Padding(3, 4, 3, 4);
            InstallPage.Size = new Size(1238, 636);
            InstallPage.TabIndex = 0;
            InstallPage.Text = "Register Application";
            // 
            // VersionPage
            // 
            VersionPage.BackColor = Color.LightPink;
            VersionPage.Location = new Point(4, 29);
            VersionPage.Margin = new Padding(3, 4, 3, 4);
            VersionPage.Name = "VersionPage";
            VersionPage.Padding = new Padding(3, 4, 3, 4);
            VersionPage.Size = new Size(1238, 631);
            VersionPage.TabIndex = 1;
            VersionPage.Text = "Current Version Info";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Padding = new Padding(0, 0, 30, 0);
            toolStripStatusLabel1.Size = new Size(218, 20);
            toolStripStatusLabel1.Text = "Status: Nothing Happening";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 18);
            toolStripProgressBar1.Visible = false;
            // 
            // links
            // 
            links.Location = new Point(8, 114);
            links.Name = "links";
            links.Size = new Size(1222, 401);
            links.TabIndex = 0;
            links.Text = "";
            // 
            // Administrative
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1246, 733);
            Controls.Add(mainContainer);
            Controls.Add(statusBar);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Administrative";
            Text = "Admin Page";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            mainContainer.ResumeLayout(false);
            InstallPage.ResumeLayout(false);
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
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private RichTextBox links;
    }
}