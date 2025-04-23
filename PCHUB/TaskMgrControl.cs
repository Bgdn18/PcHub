using System.Diagnostics;
using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB
{
    public partial class TaskMgrControl : Form
    {
        // Путь к нужному разделу реестра
        private const string RegistryPath = @"Software\Microsoft\Windows\CurrentVersion\Policies\System";
        private const string ValueName = "DisableTaskMgr";

        public TaskMgrControl()
        {
            InitializeComponent();
        }


        // Проверка текущего статуса
        private void CheckStatus()
        {
            try
            {
                using (RegistryKey? key = Registry.LocalMachine.OpenSubKey(RegistryPath))
                {
                    int value = (int?)key?.GetValue(ValueName, 0) ?? 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Verification error: {ex.Message}");
            }
        }

        // Кнопка Разблокировать
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            try
            {

                SetTaskManagerAccess(0);

                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(RegistryPath, true))
                {

                    key?.SetValue(ValueName, 0, RegistryValueKind.DWord);
                    MessageBox.Show("Task Manager unlocked!", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        // Кнопка Заблокировать
        private void btnLock_Click(object sender, EventArgs e)
        {
            SetTaskManagerAccess(1);

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
                {
                    key.SetValue(ValueName, 1, RegistryValueKind.DWord);
                    MessageBox.Show("Task Manager is blocked!", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void SetTaskManagerAccess(int value)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(RegistryPath))
                {
                    key.SetValue(ValueName, value, RegistryValueKind.DWord);
                    CheckStatus();

                    // Настройки для скрытого выполнения
                    var processInfo = new ProcessStartInfo
                    {
                        FileName = "gpupdate",
                        Arguments = "/force",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    };

                    using (Process process = new Process { StartInfo = processInfo })
                    {
                        process.Start();
                        process.WaitForExit(1); // Максимальное время ожидания - 1 мс
                        if (!process.HasExited)
                            process.Kill(); // Принудительное завершение при необходимости
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nRun as administrator");
            }
        }

        private void HandleError(Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}\n\nRun the program as administrator!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Open.Build();
        }
    }
}