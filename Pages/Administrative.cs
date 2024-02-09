using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeInstaller.Pages
{
    public partial class Administrative : Form
    {
        public Administrative()
        {
            InitializeComponent();
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menu.Items[2].Enabled = false;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 900);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.menu.Items[2].Enabled = true;
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Windows\system32\taskmgr.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.Verb = "runas";
            p.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void whatIsThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information information = new("Admin Info", "Question: \n\t\"What is this?\"\n" +
                "\nAnswer:\n\tYou are currently looking at the worlds best state of the art, piece of junk. ");
            information.ShowDialog();
        }

        private void whyAmISeeingThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information information = new("Admin Info", "Question: \n\t\"Why am I seeing this?\"\n" +
                "\nAnswer:\n\tMy question to you is: \n\t\t\"Are you?\"\n\n\tYou may very well be imagining things. ");
            information.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
