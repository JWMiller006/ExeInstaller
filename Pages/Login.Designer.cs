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
            enterCredentials.Location = new Point(110, 159);
            enterCredentials.Margin = new Padding(3, 2, 3, 2);
            enterCredentials.Name = "enterCredentials";
            enterCredentials.Size = new Size(107, 32);
            enterCredentials.TabIndex = 0;
            enterCredentials.Text = "Login";
            enterCredentials.UseVisualStyleBackColor = true;
            enterCredentials.Click += enterCredentials_Click;
            // 
            // passBox
            // 
            passBox.Location = new Point(102, 134);
            passBox.Margin = new Padding(3, 2, 3, 2);
            passBox.Mask = "aaaa.0000.0000.0000.0000";
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(137, 23);
            passBox.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 273);
            Controls.Add(passBox);
            Controls.Add(enterCredentials);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.NoControl;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterCredentials;
        private MaskedTextBox passBox;
    }
}