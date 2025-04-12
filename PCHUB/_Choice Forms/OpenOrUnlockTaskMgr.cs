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

namespace PCHUB
{
    public partial class OpenOrUnlockTaskMgr : Form
    {
        public OpenOrUnlockTaskMgr()
        {
            InitializeComponent();
        }
        _list list = new _list();

        private void OpenTaskMgr_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("taskmgr");
                this.Close();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show($"Error opening taskmgr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void UnlockTaskMgr_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<TaskMgrControl>();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Build();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
