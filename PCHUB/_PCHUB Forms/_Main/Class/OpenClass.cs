using System.Diagnostics;

namespace PCHUB.OpenClassSpace
{
    internal class OpenClass
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


        /// <summary>
        /// Запускает задачу например: OpenClassSpace.OpenClass.ProcessRun("cmd", "/k help");
        /// </summary>
        public static void ProcessRun(string processName, string? arguments = null)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = processName,
                    UseShellExecute = true
                };

                if (arguments != null)
                {
                    startInfo.Arguments = arguments;
                }

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening {processName}: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        //BROWSE FILE EXPLORER
        public static void OpenBrowserExplorer() // Открывает Проводник и файл, если выбран
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Explorer"; // заголовок окна
                    openFileDialog.Filter = "All|*.*"; // будут показываться все файлы

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        // Открываем файл с помощью ассоциированной программы
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = selectedFilePath,
                            UseShellExecute = true // Важно для открытия через стандартные программы
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
