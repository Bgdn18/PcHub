using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PCHUB
{
    public partial class ProccesStartForm : Form
    {
        // Импортируем ShellExecute для правильного запуска .cpl, .msc и других команд
        [DllImport("shell32.dll", SetLastError = true)]
        private static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            int nShowCmd);

        public ProccesStartForm()
        {
            InitializeComponent();

            textBox1.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnRun.PerformClick();
                }
            };
        }

        private void buttonrun_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Enter the command (for example: appwiz.cpl, cmd, notepad)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (input == "BrowseExplorer")
                {
                    OpenClassSpace.OpenClass.OpenBrowserExplorer();
                }

                if (System.IO.File.Exists(input) || System.IO.Directory.Exists(input))
                {
                    Process.Start(input);
                    return;
                }

                ShellExecute(IntPtr.Zero, "open", input, "", "", 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to execute", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e) // открывает настройку path
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "rundll32.exe",
                    Arguments = "sysdm.cpl,EditEnvironmentVariables",
                    UseShellExecute = true,
                    Verb = "runas" // открывается с правами админа
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to open", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}