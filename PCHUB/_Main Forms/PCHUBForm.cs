using System.Diagnostics;
using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB
{
    public partial class PCHUBForm : Form
    {
        public PCHUBForm()
        {
            InitializeComponent();

            BuildLabel.Text = list.buildinfo;
        }
        _list list = new _list();

        //Название Приложения!!!
        public class AppnamePcHub
        {
            public const string AppName = "PCHUB";
        }


        private void TaskManager_Click(object sender, EventArgs e)
        {
            list.taskmgr(); // откроется диспетчер задач
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build(); // откроется информация
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            list.writer(); // откроется писатель (writer)
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            list.taskkill(); // Откроется форма TaskKiller.cs
        }

        private void FileExplorer_Click(object? sender, EventArgs e)
        {
            try
            {
                new BrowserExplorerOrJustExplorerDotExe().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening File Explorer" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalUser_Click(object? sender, EventArgs e)
        {
            list.localuser(); // добавление локального пользователя
        }

        private void btnbuildhelp_Click(object sender, EventArgs e)
        {
            list.build();
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPowerMgr_Click(object? sender, EventArgs e)
        {
            list.powermgr();
        }

        public void btnHostsFile_Click(object sender, EventArgs e)
        {
            list.HostsFile();
        }

        public void btnPowerShellPolicyManager_Click(object sender, EventArgs e)
        {
            list.powershellpolicymgr();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            list.tools();
        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            list.deletefilesform();
        }

        private void btnUninstaller_Click(object sender, EventArgs e)
        {
            list.uninstaller();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.runform();
        }
    }
}
