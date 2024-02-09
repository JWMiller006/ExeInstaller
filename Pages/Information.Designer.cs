namespace ExeInstaller.Pages
{
    partial class Information
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
            if (this.DialogResult == DialogResult.OK)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            outputText = new RichTextBox();
            okayButton = new Button();
            SuspendLayout();
            // 
            // outputText
            // 
            outputText.BorderStyle = BorderStyle.None;
            outputText.Location = new Point(12, 12);
            outputText.Name = "outputText";
            outputText.ReadOnly = true;
            outputText.Size = new Size(416, 229);
            outputText.TabIndex = 0;
            outputText.Text = "";
            // 
            // okayButton
            // 
            okayButton.Location = new Point(149, 247);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(142, 36);
            okayButton.TabIndex = 1;
            okayButton.Text = "Continue";
            okayButton.UseVisualStyleBackColor = true;
            okayButton.Click += okayButton_Click;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 295);
            Controls.Add(okayButton);
            Controls.Add(outputText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Information";
            Text = "Information";
            FormClosed += Information_FormClosed;
            Load += Information_Load;
            Resize += Information_Resize;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox outputText;
        private Button okayButton;
    }
}