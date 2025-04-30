using PCHUB._Main;
using PCHUB.WinToolSpace;

namespace PCHUB
{
    public partial class PCHUBForm : Form
    {
        private NotifyIcon? trayIcon; //TRAY

        public PCHUBForm()
        {
            InitializeComponent();
            SystemCheckSpace.SystemCheckClass.isadmin();

            BuildLabel.Text = ($"Version: {About.AboutClass.BuildInfo.ToString()}");

            // Инициализация иконки в трее ⏬
            trayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,  // ICON
                Text = $"PcHub {About.AboutClass.BuildInfo}",
                Visible = false,
                ContextMenuStrip = CreateTrayContextMenu()
            };

            trayIcon.DoubleClick += (s, e) => RestoreFromTray();
        }

        // Метод для создания контекстного меню
        private ContextMenuStrip CreateTrayContextMenu()
        {
            var menu = new ContextMenuStrip();

            menu.Items.Add("Expand", null, (s, e) => RestoreFromTray());
            menu.Items.Add(new ToolStripSeparator());  // Разделитель
            menu.Items.Add("Close", null, (s, e) => Application.Exit());

            return menu;
        }
        // Инициализация иконки в трее ⬆


        private void TaskManager_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<ChoiceSpace.PerfmonOrTaskmgr>();
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.AboutClass.ShowAboutDialog(); // откроется информация о PCHub
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<Writer>(); // откроется писатель (writer)
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<TaskKiller>(); // Откроется форма TaskKiller.cs
        }

        private void FileExplorer_Click(object? sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<ChoiceSpace.BrowserExplorerOrJustExplorerDotExe>(); // Откроется форма TaskKiller.cs
        }

        private void btnLocalUser_Click(object? sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<LocalUserSpace.LocalUserForm>(); // добавление локального пользователя
        }

        private void btnbuildhelp_Click(object sender, EventArgs e)
        {
            About.AboutClass.ShowAboutDialog();
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPowerMgr_Click(object? sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<PowerSpace.PowerManagement>();
        }

        public void btnHostsFile_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<HostsSpace.HostsFile>();
        }

        public void btnPowerShellPolicyManager_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<PowerShellPolicyReset>();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<WinToolsForm>();
        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<Delete_files>();
        }

        private void btnUninstaller_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<UnInstaller>();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<ProccesStartForm>();
        }

        private void UnlockSystem_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<SystemUnlocker>();
        }

        private void btnToTray_Click(object sender, EventArgs e)
        {
            Hide();
            trayIcon!.Visible = true;
        }

        private void RestoreFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal; // Разворачиваем (если было свернуто)
            trayIcon!.Visible = false; // Скрываем иконку из трея
        }

        private void btnBlockWebSite_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<HostsSpace.BlockWebSite>();
        }

        private void btnUtilMan_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<UtilManForm>();
        }

        private void btnCmdLine_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<CmdLineForm>();
        }

        private void btnMyProgramList_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<MyProgramList>();
        }

        private void btnWinLogon_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<WinLogonSpace.WinLogonEditForm>();
        }
    }
}
