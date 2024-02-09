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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel; 
        }

        private void enterCredentials_Click(object sender, EventArgs e)
        {
            if (this.passBox.Text.Contains("abcd")) 
            {
                this.DialogResult = DialogResult.Yes;
                this.Dispose(); 
                return;
            }
            else
            {
                this.DialogResult = DialogResult.TryAgain;
                this.Dispose();
                return; 
            }
        }
    }
}
