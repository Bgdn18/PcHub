using System.Diagnostics;

namespace PCHUB._Main
{
    public partial class UtilManForm : Form
    {
        private string utilmanPath;
        private string backupPath;
        private string currentExePath;

        public UtilManForm()
        {
            InitializeComponent();

            currentExePath = Process.GetCurrentProcess().MainModule!.FileName;
            utilmanPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "utilman.exe");
            backupPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "utilman_original.exe");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, не пытаемся ли мы заменить сами себя
                if (string.Equals(currentExePath, utilmanPath, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("You can't replace utilman.exe with itself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создаем резервную копию оригинального utilman.exe
                if (File.Exists(utilmanPath) && !File.Exists(backupPath))
                {
                    File.Move(utilmanPath, backupPath);
                }

                // Копируем текущий исполняемый файл в system32 как utilman.exe
                File.Copy(currentExePath, utilmanPath, true);

                // Устанавливаем атрибуты скрытого и системного файла (опционально)
                File.SetAttributes(utilmanPath, File.GetAttributes(utilmanPath) | FileAttributes.Hidden | FileAttributes.System);

                MessageBox.Show("The current program has been successfully copied as utilman.exe", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                // Если не хватает прав, пробуем через командную строку с повышенными привилегиями
                ExecuteAsAdmin($"/c takeown /f \"{utilmanPath}\" && icacls \"{utilmanPath}\" /grant administrators:F && copy /Y \"{currentExePath}\" \"{utilmanPath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(backupPath))
                {
                    MessageBox.Show("Backup not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Восстанавливаем оригинальный файл
                if (File.Exists(utilmanPath))
                {
                    File.Delete(utilmanPath);
                }
                File.Move(backupPath, utilmanPath);

                MessageBox.Show("Original utilman.exe successfully restored", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                // Если не хватает прав, пробуем через командную строку с повышенными привилегиями
                ExecuteAsAdmin($"/c takeown /f \"{utilmanPath}\" && icacls \"{utilmanPath}\" /grant administrators:F && move /Y \"{backupPath}\" \"{utilmanPath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Recovery error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteAsAdmin(string arguments)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = arguments,
                    Verb = "runas",
                    UseShellExecute = true,
                    CreateNoWindow = true
                };
                Process.Start(psi);
                MessageBox.Show("The command was executed with elevated rights. Check the result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running with elevated privileges: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void system32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string system32Path = Environment.GetFolderPath(Environment.SpecialFolder.System);
            try
            {
                Process.Start("explorer.exe", system32Path);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error opening: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
