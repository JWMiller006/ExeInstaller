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
    public partial class Finshed : Form
    {
        public Finshed()
        {
            InitializeComponent();
        }

        private void closeDialouge_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
