using System.Diagnostics;
using Microsoft.Win32;
using PCHUB._Choice_Forms;
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
            _list.ProcessOpen.ShowForm<OpenOrUnlockTaskMgr>(); // откроется диспетчер задач
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Build(); // откроется информация
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<TextFileCreator>(); // откроется писатель (writer)
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<TaskKiller>(); // Откроется форма TaskKiller.cs
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
            _list.ProcessOpen.ShowForm<LocalUser>(); // добавление локального пользователя
        }

        private void btnbuildhelp_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Build();
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPowerMgr_Click(object? sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<PowerManagement>();
        }

        public void btnHostsFile_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<HostsFile>();
        }

        public void btnPowerShellPolicyManager_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<PowerShellPolicyReset>();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<otherTools>();
        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<Delete_files>();
        }

        private void btnUninstaller_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<UnInstaller>();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<ProccesStartForm>();
        }

        private void btnBrowseForms_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<BrowserOrYoutube>();
        }
    }
}
