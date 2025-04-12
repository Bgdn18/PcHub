using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;
using PCHUB.Main;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace PCHUB
{
    public partial class UnlockPowerMgrForm : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const int HWND_BROADCAST = 0xffff;
        private const uint WM_SETTINGCHANGE = 0x001A;

        public UnlockPowerMgrForm()
        {
            InitializeComponent();
            CheckAdminStatus();
        }

        _list list = new _list();

        private async void CheckAdminStatus()
        {
            bool isAdmin = await Task.Run(() => IsAdministrator());
            if (!isAdmin)
            {
                MessageBox.Show("Требуются права администратора!", "PCHUB",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool IsAdministrator()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                  .IsInRole(WindowsBuiltInRole.Administrator);
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            await ExecuteWithRefreshAsync(async () =>
            {
                await ExecutePowerCommandAsync("/restoredefaultschemes");
                return "Стандартные схемы питания восстановлены!";
            });
        }

        private async void btnDisable_Click(object sender, EventArgs e)
        {
            await ExecuteWithRefreshAsync(async () =>
            {
                await Task.Run(() => SetPowerRegistry(false));
                await ExecutePowerCommandAsync("/hibernate off");
                return "Управление питанием отключено!";
            });
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Build();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEnable_Click(object sender, EventArgs e)
        {
            await ExecuteWithRefreshAsync(async () =>
            {
                await Task.Run(() => SetPowerRegistry(true));
                await ExecutePowerCommandAsync("/hibernate on");
                await ExecutePowerCommandAsync("/restoredefaultschemes");
                return "Управление питанием включено!";
            });
        }

        private async Task ExecuteWithRefreshAsync(Func<Task<string>> action)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Enabled = false;

                string message = await action.Invoke();
                await RefreshSystemAsync();

                MessageBox.Show(message, "PCHUB - Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "PCHUB - Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private async Task RefreshSystemAsync()
        {
            await Task.Run(() =>
            {
                SendMessage((IntPtr)HWND_BROADCAST, WM_SETTINGCHANGE, IntPtr.Zero, IntPtr.Zero);
                RestartExplorer();
            });
        }

        private void RestartExplorer()
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                }
                Process.Start("explorer.exe");
            }
            catch { /* Игнорируем ошибки */ }
        }

        private async Task ExecutePowerCommandAsync(string arguments)
        {
            await Task.Run(() =>
            {
                using (Process p = new Process())
                {
                    p.StartInfo = new ProcessStartInfo
                    {
                        FileName = "powercfg.exe",
                        Arguments = arguments,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        Verb = "runas"
                    };
                    p.Start();
                    p.WaitForExit();
                }
            });
        }

        private void SetPowerRegistry(bool enable)
        {
            using (RegistryKey powerSettings = Registry.LocalMachine.OpenSubKey(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", true) ??
                Registry.LocalMachine.CreateSubKey(
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer"))
            {
                if (enable)
                {
                    powerSettings.DeleteValue("NoClose", false);
                    powerSettings.DeleteValue("StartMenuLogOff", false);
                }
                else
                {
                    powerSettings.SetValue("NoClose", 1, RegistryValueKind.DWord);
                    powerSettings.SetValue("StartMenuLogOff", 1, RegistryValueKind.DWord);
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("powercfg.cpl");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "PCHUB - Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}