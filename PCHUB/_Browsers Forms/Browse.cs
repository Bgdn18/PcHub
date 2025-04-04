using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCHUB.Main;

namespace PCHUB
{
    public partial class Browse : Form
    {
        public Browse()
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

                string url = "https://" +  Uri.EscapeDataString(query);

                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening browser: " + ex.Message);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build(); // информация о приложении
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // белая тема
        }

        private void purpleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet; // фиолетовая тема
        }
    }
}
