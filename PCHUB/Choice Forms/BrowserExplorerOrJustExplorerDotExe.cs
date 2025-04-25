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
using PCHUB.Main;
using PCHUB.WindowsTool.Class;

namespace PCHUB
{
    public partial class BrowserExplorerOrJustExplorerDotExe : Form
    {
        public BrowserExplorerOrJustExplorerDotExe()
        {
            InitializeComponent();
        }

        _list list = new _list();

        private void btnFileExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe"); // пробуем открыть
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening File Explorer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //ошибка
            }

            this.Close(); // Закрываем форму
        }


        private void btnBrowseFileExplorer_Click(object sender, EventArgs e)
        {
            WinToolClass.Open.OpenBrowserExplorer();

            this.Close(); // Закрываем форму
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutClass.Open.Build();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}