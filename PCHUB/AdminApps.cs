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

namespace PCHUB
{
    public partial class AdminApps : Form
    {
        public AdminApps()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        _list list = new _list();


        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build();
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            list.writer();

        }

        private void RESOURCEMONITOR_Click(object sender, EventArgs e)
        {
            list.taskmgr();
        }

        private void EXPLORER_Click(object sender, EventArgs e)
        {
            list.fileexplorer();
        }

        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            list.controlpanel();
        }

        private void REGEDIT_Click(object sender, EventArgs e)
        {
            list.regedit();
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            list.cmd();
        }



        private void ExplorerPP_Click(object sender, EventArgs e)
        {
            list.explorerpp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.procceshacker();
        }

        private void IObitUnlocker_Click(object sender, EventArgs e)
        {
            list.unlocker();
        }

        public void LocalUser_Click(object? sender, EventArgs e)
        {
            list.localuser();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskMgrUnlocker_Click(object sender, EventArgs e)
        {
            list.taskmgrunlocker();
        }
    }
}