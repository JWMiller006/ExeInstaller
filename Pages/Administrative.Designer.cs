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
            statusStrip1 = new StatusStrip();
            mainContainer = new TabControl();
            InstallPage = new TabPage();
            VersionPage = new TabPage();
            menu.SuspendLayout();
            mainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1090, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtToolStripMenuItem1, jsonToolStripMenuItem1, otherToolStripMenuItem1 });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open...";
            // 
            // txtToolStripMenuItem1
            // 
            txtToolStripMenuItem1.Name = "txtToolStripMenuItem1";
            txtToolStripMenuItem1.Size = new Size(180, 22);
            txtToolStripMenuItem1.Text = ".txt";
            // 
            // jsonToolStripMenuItem1
            // 
            jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            jsonToolStripMenuItem1.Size = new Size(180, 22);
            jsonToolStripMenuItem1.Text = ".json";
            // 
            // otherToolStripMenuItem1
            // 
            otherToolStripMenuItem1.Name = "otherToolStripMenuItem1";
            otherToolStripMenuItem1.Size = new Size(180, 22);
            otherToolStripMenuItem1.Text = "Other...";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jsonToolStripMenuItem, txtToolStripMenuItem, otherToolStripMenuItem });
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // jsonToolStripMenuItem
            // 
            jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            jsonToolStripMenuItem.Size = new Size(104, 22);
            jsonToolStripMenuItem.Text = ".json";
            // 
            // txtToolStripMenuItem
            // 
            txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            txtToolStripMenuItem.Size = new Size(104, 22);
            txtToolStripMenuItem.Text = ".txt";
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(104, 22);
            otherToolStripMenuItem.Text = "Other";
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(180, 22);
            closeToolStripMenuItem1.Text = "Close";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallWindowToolStripMenuItem, taskManagerToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // smallWindowToolStripMenuItem
            // 
            smallWindowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallToolStripMenuItem, mediumToolStripMenuItem, largeToolStripMenuItem });
            smallWindowToolStripMenuItem.Name = "smallWindowToolStripMenuItem";
            smallWindowToolStripMenuItem.Size = new Size(146, 22);
            smallWindowToolStripMenuItem.Text = "Window";
            smallWindowToolStripMenuItem.Click += smallWindowToolStripMenuItem_Click;
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(119, 22);
            smallToolStripMenuItem.Text = "Small";
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(119, 22);
            mediumToolStripMenuItem.Text = "Medium";
            // 
            // largeToolStripMenuItem
            // 
            largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            largeToolStripMenuItem.Size = new Size(119, 22);
            largeToolStripMenuItem.Text = "Large";
            // 
            // taskManagerToolStripMenuItem
            // 
            taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            taskManagerToolStripMenuItem.Size = new Size(146, 22);
            taskManagerToolStripMenuItem.Text = "Task Manager";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whatIsThisToolStripMenuItem, whyAmISeeingThisToolStripMenuItem, closeToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // whatIsThisToolStripMenuItem
            // 
            whatIsThisToolStripMenuItem.Name = "whatIsThisToolStripMenuItem";
            whatIsThisToolStripMenuItem.Size = new Size(188, 22);
            whatIsThisToolStripMenuItem.Text = "What is this?";
            // 
            // whyAmISeeingThisToolStripMenuItem
            // 
            whyAmISeeingThisToolStripMenuItem.Name = "whyAmISeeingThisToolStripMenuItem";
            whyAmISeeingThisToolStripMenuItem.Size = new Size(188, 22);
            whyAmISeeingThisToolStripMenuItem.Text = "Why am I seeing this?";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(188, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 528);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1090, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // mainContainer
            // 
            mainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainContainer.Controls.Add(InstallPage);
            mainContainer.Controls.Add(VersionPage);
            mainContainer.Location = new Point(0, 27);
            mainContainer.Name = "mainContainer";
            mainContainer.SelectedIndex = 0;
            mainContainer.Size = new Size(1090, 498);
            mainContainer.TabIndex = 2;
            // 
            // InstallPage
            // 
            InstallPage.BackColor = Color.PaleVioletRed;
            InstallPage.Location = new Point(4, 24);
            InstallPage.Name = "InstallPage";
            InstallPage.Padding = new Padding(3);
            InstallPage.Size = new Size(1082, 470);
            InstallPage.TabIndex = 0;
            InstallPage.Text = "Register Application";
            // 
            // VersionPage
            // 
            VersionPage.BackColor = Color.LightPink;
            VersionPage.Location = new Point(4, 24);
            VersionPage.Name = "VersionPage";
            VersionPage.Padding = new Padding(3);
            VersionPage.Size = new Size(1082, 470);
            VersionPage.TabIndex = 1;
            VersionPage.Text = "Current Version Info";
            // 
            // Administrative
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1090, 550);
            Controls.Add(mainContainer);
            Controls.Add(statusStrip1);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "Administrative";
            Text = "Admin Page";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            mainContainer.ResumeLayout(false);
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
        private StatusStrip statusStrip1;
        private TabControl mainContainer;
        private TabPage InstallPage;
        private TabPage VersionPage;
    }
}