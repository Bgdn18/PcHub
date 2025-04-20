using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCHUB.Main;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PCHUB.HostsEdit
{
    public partial class BlockWebSite : Form
    {
        public BlockWebSite()
        {
            InitializeComponent();
        }

        void BlockWebsite(string url)
        {
            string hostsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");
            string redirectLine = $"127.0.0.1 {url}";

            try
            {
                File.AppendAllText(hostsPath, $"\n{redirectLine}");
                MessageBox.Show($"Site \"{url}\" blocked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            string block = TextBoxBlock.Text;
            try
            {
                BlockWebsite($"{block}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Open.ShowForm<About>();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hostFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Open.ShowForm<HostsFile>();
        }
    }
}
