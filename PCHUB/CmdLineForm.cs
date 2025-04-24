using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB
{
    public partial class CmdLineForm : Form
    {
        private const string RegPath = @"SYSTEM\CurrentControlSet\Control\Session Manager";
        private const string CmdLineValue = "CmdLine";
        private const string SetupTypeValue = "SetupType";

        public CmdLineForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем путь к текущему EXE (где лежит программа)
                string exePath = Process.GetCurrentProcess().MainModule!.FileName;

                // Открываем раздел реестра
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegPath, true)!)
                {
                    if (key == null)
                    {
                        MessageBox.Show("Failed to open registry key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Устанавливаем CmdLine (путь к EXE)
                    key.SetValue(CmdLineValue, exePath, RegistryValueKind.ExpandString);

                    // Устанавливаем SetupType = 1
                    key.SetValue(SetupTypeValue, 1, RegistryValueKind.DWord);

                    MessageBox.Show("The parameters have been successfully added to the registry", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем раздел реестра
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegPath, true)!)
                {
                    if (key == null)
                    {
                        MessageBox.Show("Failed to open registry key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Удаляем CmdLine (если существует)
                    if (key.GetValue(CmdLineValue) != null)
                    {
                        key.DeleteValue(CmdLineValue);
                    }

                    // Устанавливаем SetupType = 0
                    key.SetValue(SetupTypeValue, 0, RegistryValueKind.DWord);

                    MessageBox.Show("The parameters have been successfully removed from the registry", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Open.ProcessRun("regedit");
        }
    }
}