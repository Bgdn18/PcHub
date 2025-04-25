using System.Diagnostics;
using Microsoft.Win32;
using PCHUB._Choice_Forms;
using PCHUB._Main;
using PCHUB._Main.Class;
using PCHUB.BlockProcces;
using PCHUB.HostsEdit;
using PCHUB.Main;

namespace PCHUB
{
    public partial class PCHUBForm : Form
    {
        private NotifyIcon? trayIcon; //TRAY

        public PCHUBForm()
        {
            InitializeComponent();
            CheckadminStatus();
            BuildLabel.Text = AboutClass.BuildInfo.ToString();

            string appPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "PCHUB",
            "Blocker",
            "PCHUBBlockingApps.exe"
            );

            if (!File.Exists(appPath)) // Blocker app
            {
                btnBlockProcessForm.Enabled = false;
            };

            //TRAY
            trayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Exclamation, // ICON
                Text = "PcHub" + AboutClass.BuildInfo, // NAME
                Visible = false
            };
            trayIcon.DoubleClick += (s, e) => RestoreFromTray(); //RESTORE DOUBLE CLICK
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Expand", null, (s, e) => RestoreFromTray()); //EXPAND
            contextMenu.Items.Add("Close PCHUB", null, (s, e) => Application.Exit()); //CLOSE
            trayIcon.ContextMenuStrip = contextMenu; // MENU
            //TRAY
        }

        private void CheckadminStatus()
        {
            if (!SystemCheckClass.SystemChecks.isadmin())
            {
                MessageBox.Show("Run the program as administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void TaskManager_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<PerfmonOrTaskmgr>();
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutClass.Open.Build(); // откроется информация
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<Writer>(); // откроется писатель (writer)
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<TaskKiller>(); // Откроется форма TaskKiller.cs
        }

        private void FileExplorer_Click(object? sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<BrowserExplorerOrJustExplorerDotExe>(); // Откроется форма TaskKiller.cs
        }

        private void btnLocalUser_Click(object? sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<LocalUser>(); // добавление локального пользователя
        }

        private void btnbuildhelp_Click(object sender, EventArgs e)
        {
            AboutClass.Open.Build();
        }

        public void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPowerMgr_Click(object? sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<PowerManagement>();
        }

        public void btnHostsFile_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<HostsFile>();
        }

        public void btnPowerShellPolicyManager_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<PowerShellPolicyReset>();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<otherTools>();
        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<Delete_files>();
        }

        private void btnUninstaller_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<UnInstaller>();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<ProccesStartForm>();
        }

        private void UnlockSystem_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<SystemUnlocker>();
        }

        private void btnBlockProcessForm_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<BlockProcessForm>();
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
            OpenClass.Open.ShowForm<BlockWebSite>();
        }

        private void btnUtilMan_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<UtilManForm>();
        }

        private void btnCmdLine_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<CmdLineForm>();
        }

        private void btnMyProgramList_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<MyProgramList>();
        }
    }
}
