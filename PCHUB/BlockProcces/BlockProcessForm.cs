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
        private const string SettingsFileName = "blocker_settings.txt";
        private const string AppDataFolder = "PCHUB";
        private const string BlockerExeName = "PCHUBBlockingApps.exe";

        private readonly string _appDataPath;
        private readonly string _settingsFilePath;
        private readonly string _blockerAppPath;

        public BlockProcessForm()
        {
            InitializeComponent();

            //APPDATA
            _appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                AppDataFolder);

            //SETTINGS FILE
            _settingsFilePath = Path.Combine(_appDataPath, SettingsFileName);

            //BLOCKER APP
            _blockerAppPath = Path.Combine(
                _appDataPath,
                "Blocker",
                BlockerExeName);

            ValidateBlockerExistence();
            CheckAutoStartStatus();
        }

        private void ValidateBlockerExistence()
        {
            if (!File.Exists(_blockerAppPath))
            {
                MessageBox.Show($"{BlockerExeName} not found in the expected location.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void CheckAutoStartStatus()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryRunKey))
            {
                bool isAutoStartEnabled = key?.GetValue(AppName) != null;
                btnStart.Enabled = !isAutoStartEnabled;
                btnStop.Enabled = isAutoStartEnabled;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int killInterval, out string processesInput))
            {
                return;
            }

            SaveSettings(processesInput, killInterval);

            if (!SetAutoStart() || !StartBlockingProcess(processesInput, killInterval))
            {
                return;
            }

            UpdateUIAfterStart();
            ShowSuccessMessage(processesInput);
        }

        private bool ValidateInputs(out int killInterval, out string processesInput)
        {
            killInterval = 0;
            processesInput = textBoxProcessName.Text.Trim();

            if (!int.TryParse(textBoxTimer.Text, out killInterval) || killInterval <= 0)
            {
                MessageBox.Show("Please specify a valid interval greater than 0.",
                    "Invalid Interval",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(processesInput))
            {
                MessageBox.Show("Please enter process names (comma separated if multiple).",
                    "Missing Processes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveSettings(string processes, int interval)
        {
            try
            {
                Directory.CreateDirectory(_appDataPath);
                File.WriteAllText(_settingsFilePath, $"{processes}\n{interval}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save settings: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool SetAutoStart()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(RegistryRunKey, true))
                {
                    key?.SetValue(AppName, $"\"{_blockerAppPath}\" --autostart");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to set autostart: {ex.Message}",
                    "Autostart Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        private bool StartBlockingProcess(string processes, int interval)
        {
            try
            {
                var processInfo = new ProcessStartInfo
                {
                    FileName = _blockerAppPath,
                    Arguments = $"\"{processes}\" {interval}",
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(processInfo);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start blocking process: {ex.Message}",
                    "Launch Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateUIAfterStart()
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void ShowSuccessMessage(string processes)
        {
            MessageBox.Show($"Blocking has been enabled for: {processes}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            RemoveAutoStart();
            StopBlockingProcess();
            UpdateUIAfterStop();
        }

        private void RemoveAutoStart()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(RegistryRunKey, true))
                {
                    key?.DeleteValue(AppName, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove from autostart: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void StopBlockingProcess()
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("PCHUBBlockingApps"))
                {
                    process.Kill();
                    process.WaitForExit(1000);
                }

                MessageBox.Show("Blocking has been stopped and removed from startup.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error stopping process: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateUIAfterStop()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void taskKillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Предполагается, что _list.Open.ShowForm<TaskKiller>() доступен в контексте
            _list.Open.ShowForm<TaskKiller>();
        }

        private void configFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureSettingsFileExists();
                OpenSettingsInExplorer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing settings: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void EnsureSettingsFileExists()
        {
            if (!File.Exists(_settingsFilePath))
            {
                Directory.CreateDirectory(_appDataPath);
                File.WriteAllText(_settingsFilePath, "process1.exe,process2.exe\n5");
            }
        }

        private void OpenSettingsInExplorer()
        {
            Process.Start("explorer.exe", $"/select,\"{_settingsFilePath}\"");
        }
    }
}