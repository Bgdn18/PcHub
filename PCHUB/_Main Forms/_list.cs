using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using static PCHUB.PCHUBForm;

namespace PCHUB.Main
{
    internal class _list
    {
        // Информация о билде!!!
        public string? buildinfo = ("1.0.0");

        // Информация о билде!!!

        //начало tools
        public static class Tools // полезные приложения
        {
            public static void Unlocker() // Открывает IObit unlocker
            {
                string hubDirectory = AppDomain.CurrentDomain.BaseDirectory; // путь испольняемого файла
                string customCmdDirectory = Path.Combine(hubDirectory, "IObit"); //путь папки
                string IoBit = Path.Combine(customCmdDirectory, "IObit Unlocker"); // Iobit
                string IoBitUnlockerExe = Path.Combine(IoBit, "IObitUnlocker.exe"); // исполняемый файл IoBit Unlocker
                try
                {
                    Process.Start(IoBitUnlockerExe);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening IObit Unlocker maybe it is missing from the application folder ?" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            public static void ExplorerPP() // Открывает Проводник++
            {
                string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string customCmdDirectory = Path.Combine(hubDirectory, "ExplorerPP");
                string customCmdPath = Path.Combine(customCmdDirectory, "Explorer++.exe");

                try
                {
                    Process.Start(customCmdPath);
                }
                catch
                {
                    MessageBox.Show("Error opening Explorer++ maybe it is missing from the application folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void ProccesHacker() // Открывает Проццес Хакер
            {
                string hubDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string procceshackerfolder = Path.Combine(hubDirectory, "Process Hacker 2");
                string ProccesHacker = Path.Combine(procceshackerfolder, "ProcessHacker.exe");

                try
                {
                    Process.Start(ProccesHacker);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening ProcessHacker maybe it is missing from the application folder ?" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //конец tools

        // начало processstart
        public static class ProcessOpen // методы с открытием окон приложения или же открытие новой задачи
        {
            public static void ShowForm<T>() where T : Form, new() // показыватель форм
            {
                try
                {
                    new T().ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening {typeof(T).Name}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void ProcessRun(string processName, string? arguments = null) // новая задача
            {
                try
                {
                    if (arguments == null) // если пусто в аргументах
                        Process.Start(processName);
                    else // если аргументы прописаны
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
        } // конец processstart


        public static class SystemChecks
        {
            public static bool isadmin() // проверка на то является ли пользователь админом
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                    .IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public static class OpenApps
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
            public static void Build() // Открывает Информацию О Билде
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
        }
    }
}
