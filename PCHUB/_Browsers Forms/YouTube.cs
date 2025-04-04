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
using PCHUB.Main;

namespace PCHUB
{
    public partial class YouTube : Form
    {
        public YouTube()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        _list list = new _list();

        private void Settings_Click(object sender, EventArgs e)
        {
            list.settings();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build();
        }


        private void whiteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void purpleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
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
    }
}
