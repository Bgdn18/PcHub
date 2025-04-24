using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using PCHUB.Main;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace PCHUB
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            BuildLabel.Text = ("Version: ") + _list.BuildInfo;
        }

        private void PCHUBlabel_Click(object sender, EventArgs e)
        {
            this.Text = _list.BuildInfo + (" !!!"); // меняю название формы

            Random rand = new Random();

            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            ABOUTTEXT.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            label2.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            ABOUTTEXT.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            label2.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void TelegrammChannel_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/bgdnchannel";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening telegramm channel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Bgdn18";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening GitHub: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
