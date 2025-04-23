using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB.BlockProcces
{
    public partial class BlockProcessForm : Form
    {
        private const string AppName = "PCHUBBlocker";
        private const string RegistryRunKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private string? _settingsPath;
        private const string SettingsFileName = "blocker_settings.txt"; // blocker config 
        private const string AppDataFolder = "PCHUBBlocker"; // Папка внутри appdata


        public BlockProcessForm()
        {
            InitializeComponent();

            string appPath = Path.Combine(Application.StartupPath, "Blocker", "PCHUBBlockingApps.exe");
            if (!File.Exists(appPath))
            {
                MessageBox.Show("PCHUBBlockingApps.exe not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _settingsPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                AppName,
                "blocker_settings.txt"
            );

            CheckAutoStartStatus(); // проверка на автозагрузку
        }

        private void CheckAutoStartStatus()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryRunKey)!)
            {
                if (key?.GetValue(AppName) != null)
                {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTimer.Text, out int killInterval) || killInterval <= 0)
            {
                MessageBox.Show("Specify interval > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string processesInput = textBoxProcessName.Text.Trim();
            if (string.IsNullOrEmpty(processesInput))
            {
                MessageBox.Show("Enter processes (can be separated by commas)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Сохраняем настройки
            string settingsDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "PCHUBBlocker"
            );
            Directory.CreateDirectory(settingsDir);
            File.WriteAllText(Path.Combine(settingsDir, "blocker_settings.txt"), $"{processesInput}\n{killInterval}");

            // Добавляем в автозагрузку
            try
            {
                string appPath = Path.Combine(Application.StartupPath, "Blocker", "PCHUBBlockingApps.exe");
                if (!File.Exists(appPath))
                {
                    MessageBox.Show("PCHUBBlockingApps.exe not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryRunKey, true)!)
                {
                    key?.SetValue(AppName, $"\"{appPath}\" --autostart");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Autoload error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Запускаем блокировку
            try
            {
                var blockingProcess = new Process();
                blockingProcess.StartInfo.FileName = Path.Combine(Application.StartupPath, "Blocker", "PCHUBBlockingApps.exe");
                blockingProcess.StartInfo.Arguments = $"\"{processesInput}\" {killInterval}";
                blockingProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                blockingProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Launch error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            MessageBox.Show($"Blocking is enabled for: {processesInput}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Удаляем из автозагрузки
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryRunKey, true)!)
            {
                key?.DeleteValue(AppName, false);
            }

            // Убиваем процесс блокировки
            try
            {
                foreach (Process process in Process.GetProcessesByName("PCHUBBlockingApps"))
                {
                    process.Kill();
                }
                MessageBox.Show("Blocking stopped and removed from startup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taskKillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Open.ShowForm<TaskKiller>();
        }

        private void configFileToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // Получаем путь к AppData/Roaming текущего пользователя
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Формируем полный путь к папке с настройками
            string settingsFolderPath = Path.Combine(appDataPath, AppDataFolder);

            // Создаем папку, если ее нет
            Directory.CreateDirectory(settingsFolderPath);

            // Формируем полный путь к файлу настроек
            string settingsFilePath = Path.Combine(settingsFolderPath, SettingsFileName);

            // Создаем файл с настройками по умолчанию, если его нет
            if (!File.Exists(settingsFilePath))
            {
                File.WriteAllText(settingsFilePath, "process1.exe,process2.exe\n5");
            }

            // Открываем папку в проводнике и выделяем файл
            Process.Start("explorer.exe", $"/select,\"{settingsFilePath}\"");
        }
    }
}