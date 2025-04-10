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
    public partial class otherTools : Form
    {
        public otherTools()
        {
            InitializeComponent();

            BuildLabel.Text = list.buildinfo;
        }

        _list list = new _list();


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build();
        }


        private void EXPLORER_Click(object sender, EventArgs e)
        {
            list.fileexplorer();
        }

        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            list.controlpanel();
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


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildLabel_Click(object sender, EventArgs e) // информация о билде
        {
            list.build();
        }

        private void btnZapret_Click(object sender, EventArgs e) // Запрет для YouTube и Discord
        {
            string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string Zapretpath = Path.Combine(hubDirectory, "ZAPRET");
            string ZAPRET = Path.Combine(Zapretpath, "ZAPRET.bat");

            try
            {
                Process.Start(ZAPRET);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error opening Zapret: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaskMgr_Click(object sender, EventArgs e)
        {
            list.taskmgr();
        }

        private void btnRegedit_Click(object sender, EventArgs e)
        {
            list.regedit();
        }
    }
}