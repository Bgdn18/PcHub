using Microsoft.Win32;
using PCHUB.Main;

namespace PCHUB
{
    public partial class SystemUnlocker : Form
    {
        public SystemUnlocker()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (chkCmd.Checked) // Cmd restore
            {
                EnableCmd();
            }

            if (chkRegedit.Checked) // regedit restore
            {
                EnableRegedit();
            }

            if (chkTaskmgr.Checked) // taskmgr restore
            {
                EnableTaskmgr();
            }

            MessageBox.Show("Recovery complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Включаем CMD
        private void EnableCmd()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Windows\System");
                key.SetValue("DisableCMD", 0, RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when turning on CMD: " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        // Включаем Regedit
        private void EnableRegedit()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                key.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when turning on Regedit: " + ex.Message);
            }
        }

        // Включаем Taskmgr
        private void EnableTaskmgr()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                key.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when turning on Taskmgr: " + ex.Message);
            }
        }


        private void DisableCmd()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Windows\System");
                key.SetValue("DisableCMD", 1, RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when turning off CMD: " + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Error);
            }
        }

        private void DisableRegedit()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                key.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when turning off Regedit: " + ex.Message);
            }
        }

        private void DisableTaskmgr()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                key.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when turning off Taskmgr: " + ex.Message);
            }
        }


        private void btnLock_Click(object sender, EventArgs e)
        {
            if (chkCmd.Checked) // Cmd block
            {
                DisableCmd();
            }

            if (chkRegedit.Checked) // regedit block
            {
                DisableRegedit();
            }

            if (chkTaskmgr.Checked) // taskmgr block
            {
                DisableTaskmgr();
            }

            MessageBox.Show("Block complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
