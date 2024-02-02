namespace ExeInstaller.Pages
{
    partial class InstallApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallApp));
            installationProgress = new ProgressBar();
            cancelInstallation = new Button();
            installationThread = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // installationProgress
            // 
            installationProgress.Location = new Point(110, 114);
            installationProgress.Name = "installationProgress";
            installationProgress.Size = new Size(234, 38);
            installationProgress.TabIndex = 0;
            // 
            // cancelInstallation
            // 
            cancelInstallation.Location = new Point(180, 170);
            cancelInstallation.Name = "cancelInstallation";
            cancelInstallation.Size = new Size(105, 34);
            cancelInstallation.TabIndex = 1;
            cancelInstallation.Text = "Cancel";
            cancelInstallation.UseVisualStyleBackColor = true;
            // 
            // installationThread
            // 
            installationThread.WorkerReportsProgress = true;
            installationThread.WorkerSupportsCancellation = true;
            installationThread.DoWork += installationThread_DoWork;
            installationThread.ProgressChanged += installationThread_ProgressChanged;
            installationThread.RunWorkerCompleted += installationThread_RunWorkerCompleted;
            // 
            // InstallApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(466, 262);
            Controls.Add(cancelInstallation);
            Controls.Add(installationProgress);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InstallApp";
            Text = "Installing App, Progress: 0%";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar installationProgress;
        private Button cancelInstallation;
        private System.ComponentModel.BackgroundWorker installationThread;
    }
}