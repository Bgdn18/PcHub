using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCHUB._Main.Class;
using PCHUB.Main;

namespace PCHUB
{
    public partial class YouTube : Form
    {
        public YouTube()
        {
            InitializeComponent();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ProcessRun("explorer.exe", "ms-settings:");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            if (!string.IsNullOrWhiteSpace(query))
            {
                string url = "https://www.youtube.com/results?search_query=" + Uri.EscapeDataString(query);

                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening youtube: " + ex.Message);
                }
            }
        }

        private void rickroll_Click(object sender, EventArgs e)
        {
            {
                string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening youtube: " + ex.Message);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
