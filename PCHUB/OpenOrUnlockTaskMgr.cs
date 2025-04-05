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

namespace PCHUB
{
    public partial class OpenOrUnlockTaskMgr : Form
    {
        public OpenOrUnlockTaskMgr()
        {
            InitializeComponent();
        }

        private void OpenTaskMgr_Click(object sender, EventArgs e)
        {
            OpenTaskMgrButton();
        }

        private void UnlockTaskMgr_Click(object sender, EventArgs e)
        {
            UnlockTaskMgrButton();
        }



        public void OpenTaskMgrButton()
        {
            try
            {
                Process.Start("taskmgr.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening taskmgr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnlockTaskMgrButton()
        {
            try
            {
                new TaskMgrControl().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening TaskMgrControl: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
