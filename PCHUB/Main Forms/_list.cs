using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using static PCHUB.Library;

namespace PCHUB.Main
{
    internal class _list
    {
        // Информация о билде!!!
        public string? buildinfo = ("build: 4/3/2025");




        // Ниже все функции которые используются в других формах ⏬⏬⏬

        public void tools() // открывает Форму AdminApps
        {
            try
            {
                new otherTools().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void library() // открывает библеотеку
        {
            try
            {
                new Library().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void main() // Открывает Форму MAIN (Начальную)
        {
            try
            {
                new _MAIN().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void removefromstartup() // Удаление Из Автозагрузки
        {
            try
            {
                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key?.GetValue(AppnamePcHub.AppName) == null)
                    {
                        MessageBox.Show("The program was not in startup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    key.DeleteValue(AppnamePcHub.AppName);
                    MessageBox.Show("The program has been removed from startup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addtostartup() // Добавляет В Автозагрузку
        {
            try
            {
                string exePath = Application.ExecutablePath;

                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (key?.GetValue(AppnamePcHub.AppName) != null)
                    {
                        MessageBox.Show("The program is already in startup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    key?.SetValue(AppnamePcHub.AppName, exePath);
                    MessageBox.Show("The program has been successfully added to startup", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void unlocker() // Открывает IObit unlocker
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

        public void powershellpolicymgr() // Открывает Менеджер По Политике PowerShell
        {
            try
            {
                new PowerShellPolicyReset().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening PowerShellReset: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HostsFile() // Открывает Файл Hosts
        {
            try
            {
                new HostsFile().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening HostFile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void taskmgrunlocker() // Открывает Разблокировщик Диспетчера Задач
        {
            try
            {
                new TaskMgrControl().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening TaskMgrControl: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void powermgr() // Открывает  Управление Питанием (Не Работает В Среде Ввостановления)
        {
            try
            {
                new PowerManagement().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening PowerMgr: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void build() // Открывает Информацию О Билде
        {
            try
            {
                new About().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening Build Info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void settings() // Открывает Настройки Windows
        {
            try
            {
                Process.Start("explorer.exe", "ms-settings:");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void explorerpp() // Открывает Проводник++
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

        public void localuser() // Открывает Добавление Локального Пользователя
        {
            try
            {
                new LocalUser().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening LocalUserCreate" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void procceshacker() // Открывает Проццес Хакер
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
                MessageBox.Show("Error opening IObit Unlocker maybe it is missing from the application folder ?" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fileexplorer() // Открывает Проводник Который Может Быть Полезен В Среде Ввостановления
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Explorer",
                    Filter = "All|*.*"
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

        public void taskkill() // Открывает Снятие Задач
        {
            try
            {
                new TaskKiller().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening TaskKiller: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void browser() // Открывает Искатель По Браузеру
        {
            try
            {
                new Browse().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening Browser: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void writer() // Открывает Писатель
        {
            try
            {
                new TextFileCreator().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error opening Writer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void taskmgr() // Диспетчер Задач
        {
            OpenOrUnlockTaskMgr taskmgr = new OpenOrUnlockTaskMgr();

            try
            {
                taskmgr.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Writer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void quit() // Выход Из Приложения
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Quit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cmd() // открывает командную строку
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                UseShellExecute = true,
                WorkingDirectory = @"C:\",
                Arguments = "/k color 3 & help",
            };
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening cmd: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void regedit() // открывает реестер
        {
            if (!isadmin()) //если не админ
                MessageBox.Show("Before using the program, you MUST run it as administrator.: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                try
                {
                    Process.Start("regedit.exe"); // пробуем открыть
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening RegEdit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //ошибка
                }
        }
        public void controlpanel() // открывает панель задач
        {
            try
            {
                Process.Start("control.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening ControlPanel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool isadmin() // проверка на то является ли пользователь админом
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                .IsInRole(WindowsBuiltInRole.Administrator);
        }
         public void deletefilesform()
        {
            Delete_files deletefiles = new Delete_files();

            try
            {
                deletefiles.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error opening: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
