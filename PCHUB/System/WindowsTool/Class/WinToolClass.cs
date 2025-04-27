using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHUB.WinToolSpace
{
    internal class WinToolClass
    {
        public static class Open // Системные приложения
        {
            //BROWSE FILE EXPLORER
            public static void OpenBrowserExplorer() // Открывает Проводник Который Может Быть Полезен В Среде Ввостановления
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
