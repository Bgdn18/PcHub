using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using PCHUB.Main;

namespace PCHUB
{
    public partial class HostsFile : Form
    {
        private readonly string HostsPath = Path.Combine(
            Environment.SystemDirectory,
            "drivers\\etc\\hosts");

        public HostsFile()
        {
            InitializeComponent();
            LoadHostsContent();
        }

        // Подгрузка файла hosts
        private void LoadHostsContent()
        {
            try
            {
                if (File.Exists(HostsPath))
                {
                    txtHosts.Text = File.ReadAllText(HostsPath, Encoding.ASCII);
                }
                else
                {
                    txtHosts.Text = "Hosts file not found";
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error reading file: {ex.Message}");
            }
        }

        // Сброс
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                string defaultContent =
                    "# Restored HostsResetter\n" +
                    "127.0.0.1 localhost\n" +
                    "::1 localhost\n" +
                    "# Ad blocking (example):\n" +
                    "# 0.0.0.0 ads.google.com\n";

                File.WriteAllText(HostsPath, defaultContent, Encoding.ASCII);
                LoadHostsContent();
                MessageBox.Show("The hosts file has been reset successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                ShowError("Run the program as administrator!");
            }
            catch (Exception ex)
            {
                ShowError($"Error: {ex.Message}");
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка прав администратора
                if (!_list.SystemChecks.isadmin())
                {
                    MessageBox.Show("Administrator rights required!");
                    return;
                }

                // Сохранение изменений
                File.WriteAllText(HostsPath, txtHosts.Text, Encoding.UTF8);

                // Обновление DNS
                FlushDNS();

                MessageBox.Show("File saved successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Saving error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сброс DNS-кэша
        private void FlushDNS()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "ipconfig",
                Arguments = "/flushdns",
                WindowStyle = ProcessWindowStyle.Hidden
            })?.WaitForExit();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(
            Environment.SystemDirectory,
            "drivers\\etc\\hosts");

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Enter the path in the text field");
                return;
            }

            try
            {
                if (File.Exists(path))
                {
                    // Открыть проводник с выделенным файлом
                    Process.Start("explorer.exe", $"/select, \"{path}\"");
                }
                else if (Directory.Exists(path))
                {
                    // Открыть проводник в указанной папке
                    Process.Start("explorer.exe", path);
                }
                else
                {
                    MessageBox.Show("The specified path does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Open.Build();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}