using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHUB._Main.Class
{
    internal class OpenClass
    {
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
        }
    }
}
