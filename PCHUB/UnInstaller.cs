using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB
{
    public partial class UnInstaller : Form
    {
        public UnInstaller()
        {
            InitializeComponent();
        }

        _list list = new _list();

        private void UnInstaller_Load(object sender, EventArgs e)
        {
            LoadInstalledPrograms();
        }

        private void LoadInstalledPrograms()
        {
            listBoxPrograms.Items.Clear();
            int programCount = 0; // Счетчик программ

            string[] registryKeys =
            {
        @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
        @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
    };

            foreach (string registryKey in registryKeys)
            {
                using (RegistryKey? key = Registry.LocalMachine.OpenSubKey(registryKey))
                {
                    if (key == null) continue;

                    foreach (string subKeyName in key.GetSubKeyNames())
                    {
                        using (RegistryKey? subKey = key.OpenSubKey(subKeyName))
                        {
                            try
                            {
                                string? displayName = subKey?.GetValue("DisplayName")?.ToString();
                                string? uninstallString = subKey?.GetValue("UninstallString")?.ToString();
                                string? installDate = subKey?.GetValue("InstallDate")?.ToString();

                                if (!string.IsNullOrEmpty(displayName) && !string.IsNullOrEmpty(uninstallString))
                                {
                                    // Форматирование даты установки
                                    if (!string.IsNullOrEmpty(installDate) && installDate.Length == 8)
                                    {
                                        installDate = $"{installDate.Substring(6, 2)}.{installDate.Substring(4, 2)}.{installDate.Substring(0, 4)}";
                                    }
                                    else
                                    {
                                        installDate = "N/A";
                                    }

                                    listBoxPrograms.Items.Add(new ProgramInfo(
                                        displayName,
                                        uninstallString,
                                        installDate));

                                    programCount++; // Увеличиваем счетчик
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"Error reading registry key {subKeyName}: {ex.Message}");
                            }
                        }
                    }
                }
            }

            labelTotal.Text = $"{programCount} programs";

            listBoxPrograms.Sorted = true; // сортировка по алфавиту
        }

        public class ProgramInfo
        {
            public string Name { get; set; }
            public string UninstallString { get; set; }
            public string InstallDate { get; set; }

            public ProgramInfo(string name, string uninstallString, string installDate)
            {
                Name = name;
                UninstallString = uninstallString;
                InstallDate = installDate;
            }

            public override string ToString()
            {
                return $"{Name} (Installed: {InstallDate})";
            }
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
            if (listBoxPrograms.SelectedItem == null)
            {
                MessageBox.Show("Select a program to uninstall", "Select a program",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedProgram = (ProgramInfo)listBoxPrograms.SelectedItem;
            string programName = selectedProgram.Name;
            string uninstallString = selectedProgram.UninstallString;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to uninstall '{programName}'?",
                "Confirm uninstallation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteToolStripMenuItem.Enabled = false;
                progressBar1.Style = ProgressBarStyle.Marquee;
                Refresh();

                try
                {
                    uninstallString = uninstallString.Trim();

                    string fileName;
                    string arguments = "";

                    if (uninstallString.StartsWith("\""))
                    {
                        int endQuoteIndex = uninstallString.IndexOf('"', 1);
                        if (endQuoteIndex > 0)
                        {
                            fileName = uninstallString.Substring(1, endQuoteIndex - 1);
                            arguments = uninstallString.Substring(endQuoteIndex + 1).Trim();
                        }
                        else
                        {
                            fileName = uninstallString.Trim('"');
                        }
                    }
                    else
                    {
                        int spaceIndex = uninstallString.IndexOf(' ');
                        if (spaceIndex > 0)
                        {
                            fileName = uninstallString.Substring(0, spaceIndex);
                            arguments = uninstallString.Substring(spaceIndex + 1).Trim();
                        }
                        else
                        {
                            fileName = uninstallString;
                        }
                    }

                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = fileName;
                    psi.Arguments = arguments;
                    psi.UseShellExecute = true;

                    if (fileName.EndsWith("msiexec.exe", StringComparison.OrdinalIgnoreCase) &&
                        !arguments.Contains("/I") && !arguments.Contains("/X"))
                    {
                        if (!string.IsNullOrEmpty(arguments))
                            psi.Arguments = "/X " + arguments + " /quiet";
                        else
                            psi.Arguments = "/X " + uninstallString.Split(' ')[1] + " /quiet";
                    }

                    Process.Start(psi);

                    MessageBox.Show($"Uninstallation process started for: {programName}",
                        "Uninstall", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while uninstalling: {ex.Message}\n\nTry to run this program as Administrator.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    deleteToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Build(); // информация о программе
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadInstalledPrograms(); // перезагружает список программ
        }
    }
}