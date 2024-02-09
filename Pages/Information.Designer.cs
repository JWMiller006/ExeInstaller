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
            outputText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputText.BorderStyle = BorderStyle.None;
            outputText.Location = new Point(14, 16);
            outputText.Margin = new Padding(3, 4, 3, 4);
            outputText.Name = "outputText";
            outputText.ReadOnly = true;
            outputText.Size = new Size(475, 305);
            outputText.TabIndex = 0;
            outputText.Text = "";
            // 
            // okayButton
            // 
            okayButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            okayButton.Location = new Point(170, 329);
            okayButton.Margin = new Padding(3, 4, 3, 4);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(162, 48);
            okayButton.TabIndex = 1;
            okayButton.Text = "Continue";
            okayButton.UseVisualStyleBackColor = true;
            okayButton.Click += okayButton_Click;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 393);
            Controls.Add(okayButton);
            Controls.Add(outputText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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