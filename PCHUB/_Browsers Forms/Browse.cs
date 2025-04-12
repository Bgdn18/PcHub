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
            _list.ProcessOpen.ProcessRun("explorer.exe", "ms-settings:");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            if (!string.IsNullOrWhiteSpace(query))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(query) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening browser: " + ex.Message);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Build(); // информация о приложении
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
