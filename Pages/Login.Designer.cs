namespace ExeInstaller.Pages
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            enterCredentials = new Button();
            passBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // enterCredentials
            // 
            enterCredentials.Location = new Point(126, 212);
            enterCredentials.Name = "enterCredentials";
            enterCredentials.Size = new Size(122, 42);
            enterCredentials.TabIndex = 0;
            enterCredentials.Text = "Login";
            enterCredentials.UseVisualStyleBackColor = true;
            enterCredentials.Click += enterCredentials_Click;
            // 
            // passBox
            // 
            passBox.Location = new Point(117, 179);
            passBox.Mask = "aaaa.0000.0000.0000.0000";
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(156, 27);
            passBox.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 364);
            Controls.Add(passBox);
            Controls.Add(enterCredentials);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterCredentials;
        private MaskedTextBox passBox;
    }
}