using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeInstaller.Pages
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        public Information(string title, string message)
        {
            InitializeComponent();
            this.Text = title;
            this.outputText.Text = message;
            this.Capture = true;
            this.ControlBox = false; 
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void Information_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(456, 334);
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                Information form = new("Error", "You must click the continue button to proceed");
                form.Show(); 
            }
        }
    }
}
