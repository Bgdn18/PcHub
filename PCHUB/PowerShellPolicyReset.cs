using System;
using System.Diagnostics;
using System.Windows.Forms;
using PCHUB.Main;

namespace PCHUB
{
    public partial class PowerShellPolicyReset : Form
    {
        public PowerShellPolicyReset()
        {
            InitializeComponent();
            CheckCurrentPolicy();
        }

        _list list = new _list();

        // Проверка текущей политики
        private void CheckCurrentPolicy()
        {
            try
            {
                var process = new Process
                {
                    StartInfo = {
                        FileName = "powershell.exe",
                        Arguments = "Get-ExecutionPolicy -Scope CurrentUser",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                string output = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();

                lblCurrentPolicy.Text = $"Current Policy (CurrentUser): {output}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Общий метод для изменения политики
        private void SetPolicy(string policyName, string scope = "CurrentUser")
        {
            try
            {
                var process = new Process
                {
                    StartInfo = {
                        FileName = "powershell.exe", // повершелл
                        Arguments = $"-Command Set-ExecutionPolicy {policyName} -Scope {scope} -Force",
                        Verb = "runas", //права администратора
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                };

                process.Start();
                process.WaitForExit();
                CheckCurrentPolicy();
                MessageBox.Show($"Policy changed to {policyName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопки для разных политик
        private void btnResetPolicy_Click(object sender, EventArgs e) => SetPolicy("Unrestricted"); //сбрасывает политику
        private void btnUnrestricted_Click(object sender, EventArgs e) => SetPolicy("Unrestricted"); // Unrestricted
        private void btnRemoteSigned_Click(object sender, EventArgs e) => SetPolicy("RemoteSigned"); // RemoteSigned
        private void btnAllSigned_Click(object sender, EventArgs e) => SetPolicy("AllSigned"); // AllSigned
        private void btnRestricted_Click(object sender, EventArgs e) => SetPolicy("Restricted"); // Restricted
        private void btnBypass_Click(object sender, EventArgs e) => SetPolicy("Bypass"); // Bypass
        private void btnUndefined_Click(object sender, EventArgs e) => SetPolicy("Undefined"); // Undefined



        // Кнопка проверки текущей политики
        private void btnCheck_Click(object sender, EventArgs e) => CheckCurrentPolicy();



        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build();
        }
    }
}