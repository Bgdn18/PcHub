using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB
{
    public partial class TaskKiller : Form
    {
        public TaskKiller()
        {
            InitializeComponent();
        }

        _list list = new _list();

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedItem != null)
            {
                string? selectedProcessName = listBoxProcesses.SelectedItem.ToString();

                try
                {
                    // Находим все процессы с таким именем
                    Process[] processes = Process.GetProcessesByName(selectedProcessName);

                    // Завершаем каждый из них
                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }

                    MessageBox.Show($"Process {selectedProcessName} completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProcesses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a process to complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.OpenApps.Build();
        }

        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadProcesses()
        {
            int programCount = 0;

            listBoxProcesses.Items.Clear();

            Process[] processes = Process.GetProcesses()
        .OrderBy(p => p.ProcessName)
        .ToArray();


            // Добавляем имена процессов в ListBox
            foreach (Process process in processes)
            {
                listBoxProcesses.Items.Add(process.ProcessName);
                programCount++;
            }
            TasksLabel.Text = $"{programCount} programs";
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void TaskKiller_Load(object sender, EventArgs e)
        {
            LoadProcesses();
            btnRefreshAutoStart_Click(null,null);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.ProcessOpen.ShowForm<ProccesStartForm>();
        }

        private void btnRefreshAutoStart_Click(object sender, EventArgs e)
        {
            startupListView.Items.Clear();

            RegistryKey? currentUserKey = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run");

            LoadStartupItems(currentUserKey, "User");

            RegistryKey? localMachineKey = Registry.LocalMachine.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run");

            LoadStartupItems(localMachineKey, "System");
        }

        private void LoadStartupItems(RegistryKey key, string category)
        {
            int startup = 0;

            if (key == null) return;

            foreach (string appName in key.GetValueNames())
            {
                startup++;

                string? appPath = key.GetValue(appName)?.ToString();
                if (string.IsNullOrEmpty(appPath)) continue;

                ListViewItem item = new ListViewItem(appName);
                item.SubItems.Add(appPath);
                item.SubItems.Add(category);
                item.Tag = key.Name;

                startupListView.Items.Add(item);
            }

            labelAutoStartCount.Text = ($"process: " + startup);

            key.Close();
        }

        private void btnDeleteAutoStart_Click(object sender, EventArgs e)
        {
            if (startupListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to delete", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = (ListViewItem)startupListView.SelectedItems[0];
            string? appName = selectedItem.Text;
            string? registryPath = selectedItem.Tag.ToString();

            try
            {
                RegistryKey key = registryPath.Contains("HKEY_LOCAL_MACHINE")
                    ? Registry.LocalMachine
                    : Registry.CurrentUser;

                using (RegistryKey startupKey = key.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (startupKey != null)
                    {
                        startupKey.DeleteValue(appName, false);
                        MessageBox.Show($"'{appName}' removed from startup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefreshAutoStart_Click(null, null); // Обновляем список
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Insufficient rights to delete system entry", "Errir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while deleting: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAutoStart_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Applications (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.Title = "Select a program to add to startup";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string appPath = openFileDialog.FileName;
                        string appName = Path.GetFileNameWithoutExtension(appPath);

                        // Запрашиваем куда добавить (для текущего пользователя или всех)
                        var result = MessageBox.Show("Add for current user? (No - for all users)",
                            "Select startup type",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Cancel) return;

                        RegistryKey key = result == DialogResult.Yes
                            ? Registry.CurrentUser
                            : Registry.LocalMachine;

                        using (RegistryKey startupKey = key.OpenSubKey(
                            @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                        {
                            startupKey?.SetValue(appName, appPath);
                            MessageBox.Show($"'{appName}' added to startup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnRefreshAutoStart_Click(null, null); // Обновляем список
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Insufficient rights to add to system startup", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while adding: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}