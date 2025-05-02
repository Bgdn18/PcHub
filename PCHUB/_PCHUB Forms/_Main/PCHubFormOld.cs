using PCHUB._Main;
using PCHUB.WinToolSpace;

namespace PCHUB
{
    public partial class PCHubFormOld : Form
    {
        public PCHubFormOld()
        {
            InitializeComponent();
            SystemCheckSpace.SystemCheckClass.isadmin();

            BuildLabel.Text = ($"Version: {About.AboutClass.BuildInfo.ToString()}");
        }

        #region Buttons
        private void TaskManager_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<ChoiceSpace.ResmonOrTaskmgr>();

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e) => About.AboutClass.ShowAboutDialog(); // откроется информация о PCHub

        private void TxtWriter_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<WriterForm>(); // откроется писатель (writer)

        private void Taskkiller_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<TaskKiller>(); // Откроется форма TaskKiller.cs

        private void FileExplorer_Click(object? sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<ChoiceSpace.BrowseOrExplorer>(); // Откроется форма TaskKiller.cs

        private void btnLocalUser_Click(object? sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<LocalUserSpace.LocalUserForm>(); // добавление локального пользователя

        private void btnbuildhelp_Click(object sender, EventArgs e) => About.AboutClass.ShowAboutDialog();

        public void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void btnPowerMgr_Click(object? sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<PowerSpace.PowerManagement>();

        public void btnHostsFile_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<HostsSpace.HostsFile>();

        public void btnPowerShellPolicyManager_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<PowerShellPolicyReset>();

        private void btnTools_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<WinToolsForm>();

        private void btnFileDelete_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<Delete_files>();

        private void btnUninstaller_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<UnInstaller>();

        private void UnlockSystem_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<SystemUnlocker>();

        private void btnBlockWebSite_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<HostsSpace.BlockWebSite>();

        private void btnUtilMan_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<UtilManForm>();

        private void btnCmdLine_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<CmdLineForm>();

        private void btnMyProgramList_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<MyProgramListForm>();

        private void btnWinLogon_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<WinLogonSpace.WinLogonEditForm>();
        #endregion Buttons
    }
}
