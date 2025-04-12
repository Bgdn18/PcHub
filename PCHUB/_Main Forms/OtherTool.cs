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
            _list.OpenApps.Build();
        }

        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ProcessRun("control.exe");
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Cmd();
        }



        private void ExplorerPP_Click(object sender, EventArgs e)
        {
            _list.Tools.ExplorerPP();
        }

        private void processhacker_Click(object sender, EventArgs e)
        {
            _list.Tools.ProccesHacker();
        }

        private void IObitUnlocker_Click(object sender, EventArgs e)
        {
            _list.Tools.Unlocker();  // Запуск IObit Unlocker
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildLabel_Click(object sender, EventArgs e) // информация о билде
        {
            _list.OpenApps.Build();
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

        private void btnRegedit_Click(object sender, EventArgs e)
        {
            if (!_list.SystemChecks.isadmin())
            {
                MessageBox.Show("Error, try running as administrator: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                _list.ProcessOpen.ProcessRun("regedit");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Regedit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}