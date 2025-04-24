using System.Diagnostics;

namespace PCHUB
{
    public partial class LocalUser : Form
    {
        public LocalUser()
        {
            InitializeComponent();
        }

        private void AddLocalUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textboxUsername.Text.Trim();
                string password = UserPassword.Text.Trim();

                // Проверяем ввод пользователя
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter username",
                                    "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                // 1. Проверяем существование учётной записи
                if (CheckIfAccountExists(username))
                {
                    MessageBox.Show($"Account '{username}' already exists",
                                  "Info",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    return;
                }

                if (!string.IsNullOrEmpty(password))
                {
                    // Экранирование кавычек и пробелов
                    string safePassword = password
                        .Replace("\"", "\\\"")
                        .Replace("^", "^^");

                    ExecuteCommand($"net user \"{username}\" \"{safePassword}\" /add /active:yes /passwordreq:yes");
                }
                else
                {
                    ExecuteCommand($"net user \"{username}\" /add /active:yes /passwordreq:no");
                }

                // 3. Добавляем в администраторы только если checkbox отмечен
                if (checkboxAdminUser.Checked)
                {
                    ExecuteCommand($"net localgroup Administrators \"{username}\" /add");
                }

                // 4. Проверяем результат
                if (CheckIfAccountExists(username))
                {
                    string adminStatus = checkboxAdminUser.Checked ? "with Administrator rights" : "as a standard user";
                    MessageBox.Show($"Account '{username}' successfully created {adminStatus}!\n\n" +
                                    "Now you can:\n" +
                                    "1. Restart your computer\n" +
                                    "2. Select the new user on the login screen",
                                    "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to create an account\n" +
                                  "Try running the program as Administrator\n" +
                                  "You may have used Cyrillic, in which case the account has been created",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }

        }

        // Метод проверки существования аккаунта
        private bool CheckIfAccountExists(string username)
        {
            try
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = "net",
                    Arguments = $"user \"{username}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output.Contains(username);
            }
            catch
            {
                return false;
            }
        }

        // Метод выполнения команд
        private void ExecuteCommand(string command)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = $"/C {command}",
                Verb = "runas", // Запуск от имени администратора
                UseShellExecute = true
            };
            process.Start();
            process.WaitForExit();
        }

        private void DeleteLocalUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем имя пользователя из TextBox
                string username = textboxUsername.Text.Trim();

                // Проверка ввода
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Enter username to delete",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                // Запрос подтверждения
                var confirmResult = MessageBox.Show($"Are you sure you want to delete user '{username}'?", "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                if (confirmResult != DialogResult.Yes) return;

                // Проверяем существование аккаунта
                if (!CheckIfAccountExists(username))
                {
                    MessageBox.Show($"Account '{username}' not found",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return;
                }

                // Пытаемся удалить из администраторов (если есть)
                ExecuteCommand($"net localgroup Administrators \"{username}\" /delete");

                // Удаляем пользователя
                ExecuteCommand($"net user \"{username}\" /delete");

                // Проверяем результат
                if (!CheckIfAccountExists(username))
                {
                    MessageBox.Show($"Account '{username}' successfully removed!",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to delete the account.\n" +
                                    "Try running the program as Administrator.",
                                    "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while deleting: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewFolder_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем путь к папке Users
                string usersPath = Path.Combine(Environment.GetEnvironmentVariable("SystemDrive") ?? "C:", "Users");

                // Проверяем существование папки
                if (!Directory.Exists(usersPath))
                {
                    MessageBox.Show("Users folder not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Открываем проводник
                Process.Start("explorer.exe", usersPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            string settingsUri = "ms-settings:otherusers";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = settingsUri,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}