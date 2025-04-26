using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;
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
        }

        private async void btnDisable_Click(object sender, EventArgs e)
        {
            await ExecuteWithRefreshAsync(async () =>
            {
                await Task.Run(() => SetPowerRegistry(false));
                await ExecutePowerCommandAsync("/hibernate off");
                return "Power management is disabled";
            });
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutClass.Open.Build();
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
                return "Power management is enabled";
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

                MessageBox.Show(message, "Info",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
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
            });
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
    }
}