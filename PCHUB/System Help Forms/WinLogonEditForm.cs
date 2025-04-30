using Microsoft.Win32;
using PCHUB.OpenClassSpace;

namespace PCHUB.WinLogonSpace
{
    public partial class WinLogonEditForm : Form
    {
        // Путь в реестре, где хранится процесс входа
        private const string RegistryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
        private const string ValueName = "Shell";

        public WinLogonEditForm()
        {
            InitializeComponent();
            LoadCurrentShell();
        }

        private void LoadCurrentShell()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegistryPath)!)
                {
                    if (key != null)
                    {
                        string currentShell = key.GetValue(ValueName)?.ToString() ?? "explorer.exe";
                        TextBoxLogon.Text = currentShell;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading registry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegistryPath, true)!)
                {
                    if (key != null)
                    {
                        key.SetValue(ValueName, TextBoxLogon.Text.Trim());
                        MessageBox.Show("Changes saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to registry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(RegistryPath, true)!)
                {
                    if (key != null)
                    {
                        key.SetValue(ValueName, "explorer.exe");
                        MessageBox.Show("Changes saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to registry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void regEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenClass.ProcessRun("regedit");
        }
    }
}
