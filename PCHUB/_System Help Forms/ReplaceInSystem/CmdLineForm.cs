using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PCHUB
{
    public partial class CmdLineForm : Form
    {
        private const string RegPath = @"SYSTEM\Setup";
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
                string exePath = Process.GetCurrentProcess().MainModule!.FileName;

                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegPath, true)!)
                {
                    if (key == null)
                    {
                        using (RegistryKey newKey = Registry.LocalMachine.CreateSubKey(RegPath))
                        {
                            newKey.SetValue(CmdLineValue, exePath, RegistryValueKind.ExpandString);
                            newKey.SetValue(SetupTypeValue, 1, RegistryValueKind.DWord);
                        }
                    }
                    else
                    {
                        key.SetValue(CmdLineValue, exePath, RegistryValueKind.ExpandString);
                        key.SetValue(SetupTypeValue, 1, RegistryValueKind.DWord);
                    }

                    MessageBox.Show("Parameters successfully added to registry",
                                   "Success",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Administrator privileges required to write to registry.\nPlease run as administrator.",
                              "Access Denied",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegPath, true)!)
                {
                    if (key == null)
                    {
                        MessageBox.Show("Registry key not found",
                                      "Information",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        return;
                    }

                    if (key.GetValue(CmdLineValue) != null)
                    {
                        key.SetValue(CmdLineValue, 0, RegistryValueKind.DWord);
                    }

                    key.SetValue(SetupTypeValue, 0, RegistryValueKind.DWord);

                    MessageBox.Show("Parameters successfully removed from registry",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Administrator privileges required to modify registry.\nPlease run as administrator.",
                              "Access Denied",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void regeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ProcessRun("regedit");
        }
    }
}