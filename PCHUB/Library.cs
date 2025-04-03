using System.Diagnostics;
using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            BuildLabel.Text = list.buildinfo;
        }
        _list list = new _list();

        //Название Приложения!!!
        public class AppnamePcHub
        {
            public const string AppName = "PCHUB";
        }




        public void ZAPRET_Click(object sender, EventArgs e)
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

        private void CMD_Click(object? sender, EventArgs e)
        {
            list.cmd();
        }

        public void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            list.controlpanel(); // открывается панель управления
        }

        private void REGEDIT_Click(object sender, EventArgs e) // открывается RegEdit тоесть реестер
        {
            list.regedit();
        }

        public void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // белая тема
        }

        public void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple; // фиолетовая тема
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

        public void Browse_Click(object sender, EventArgs e)
        {
            list.browser(); // откроется искатель по браузеру
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            list.taskkill(); // Откроется форма TaskKiller.cs
        }

        private void FileExplorer_Click(object? sender, EventArgs e)
        {
            list.fileexplorer();
        }

        private void btnProccesHacker_Click(object sender, EventArgs e)
        {
            list.procceshacker(); // процесс хакер
        }

        private void btnLocalUser_Click(object? sender, EventArgs e)
        {
            list.localuser(); // добавление локального пользователя
        }

        private void btnExplorerPP_Click(object? sender, EventArgs e)
        {
            list.explorerpp(); //explorer++
        }

        private void btnWindowsSettings_Click(object? sender, EventArgs e)
        {
            list.settings();
        }

        private void btnbuildhelp_Click(object sender, EventArgs e)
        {
            list.build();
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.quit();
        }

        private void btnPowerMgr_Click(object? sender, EventArgs e)
        {
            list.powermgr();
        }

        public void btnTaskMgrUnlocker_Click(object sender, EventArgs e)
        {
            list.taskmgrunlocker();
        }

        public void btnHostsFile_Click(object sender, EventArgs e)
        {
            list.HostsFile();
        }

        public void btnPowerShellPolicyManager_Click(object sender, EventArgs e)
        {
            list.powershellpolicymgr();
        }

        private void btnIObitUnlocker_Click(object? sender, EventArgs e)
        {
            list.unlocker();
        }

        public void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.addtostartup();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.removefromstartup();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            list.main();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            list.tools();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            list.library();
        }
    }
}
