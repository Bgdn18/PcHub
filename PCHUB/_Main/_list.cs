using System.Diagnostics;
using System.Security.Principal;

namespace PCHUB.Main
{
    internal class _list
    {
        // Информация о билде!!!
        public const string BuildInfo = "1.0.0 (build 2025-04-22)";
        // Информация о билде!!!


        public static class Open
        {
            public static void ShowForm<T>() where T : Form, new() // показыватель форм внутри PCHUB
            {
                try
                {
                    new T().ShowDialog(); // Пробует открыть Форму или же "T"
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening {typeof(T).Name}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void ProcessRun(string processName, string? arguments = null) // запуск новой задачи
            {
                try
                {
                    if (arguments == null)
                        Process.Start(processName);
                    else
                        Process.Start(processName, arguments);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening {processName}: {ex.Message}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }



                /*
                 * Не используется с 4/23/2025
                 * Встроенные программы были удалены
                 * Можно удалить
                 * ⏬⏬⏬
                 */

            /*
            public static void RunPCHUBTool(string folderName, string exeName, string toolName) // открытие встроеных приложений PCHUB
            {
                string hubDirectory = AppDomain.CurrentDomain.BaseDirectory; // Базовая папка PCHUB
                string toolDirectory = Path.Combine(hubDirectory, folderName); // Папка приложения
                string exePath = Path.Combine(toolDirectory, exeName); // Исполняемый файл встроеного приложения

                if (!File.Exists(exePath))
                {
                    MessageBox.Show($"Error: {toolName} executable not found at {exePath}",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Process.Start(exePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening {toolName}: {ex.Message}",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */

            public static void Build() // Открывает Информацию О приложении
            {
                try
                {
                    new About().ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening Build Info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } // конец ProcessOpen


        public static class SystemChecks // Проверки
        {
            public static bool isadmin() // проверка на то является ли пользователь админом
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                    .IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public static class OpenSystemTools // Системные приложения
        {
            //BROWSE FILE EXPLORER
            public static void OpenFileExplorer() // Открывает Проводник Который Может Быть Полезен В Среде Ввостановления
            {
                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        Title = "Explorer", // заголовок окна
                        Filter = "All|*.*" // будут показыватся все файлы
                    };

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sourceFileSysWow64 = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // CMD
            public static void Cmd() // открывает командную строку
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    UseShellExecute = true,
                    WorkingDirectory = @"C:\",
                    Arguments = "/k help", // моментально выполняет смену цвета и команду Help

                };
                try
                {
                    Process.Start(startInfo); // пытается открыть cmd с параметрами
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening cmd: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
