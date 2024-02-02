namespace ExeInstaller.Pages
{
    partial class Finshed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finshed));
            label1 = new Label();
            closeDialouge = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 95);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Finished Installation";
            // 
            // closeDialouge
            // 
            closeDialouge.Location = new Point(147, 139);
            closeDialouge.Name = "closeDialouge";
            closeDialouge.Size = new Size(89, 32);
            closeDialouge.TabIndex = 1;
            closeDialouge.Text = "Finish";
            closeDialouge.UseVisualStyleBackColor = true;
            closeDialouge.Click += closeDialouge_Click;
            // 
            // Finshed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(384, 224);
            Controls.Add(closeDialouge);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Finshed";
            Text = "Finshed";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button closeDialouge;
    }
}