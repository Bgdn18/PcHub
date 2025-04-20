using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace PCHUBBlockingApps
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;

        static void Main(string[] args)
        {
            ShowWindow(GetConsoleWindow(), SW_HIDE);

            if (args.Length == 0)
                return;

            string[] processNames;
            int killInterval;

            // Режим автозапуска (читаем из файла)
            if (args[0] == "--autostart")
            {
                string settingsPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "PCHUBBlocker",
                    "blocker_settings.txt"
                );

                if (!File.Exists(settingsPath))
                    return;

                string[] settings = File.ReadAllLines(settingsPath);
                if (settings.Length < 2)
                    return;

                processNames = settings[0].Split(',')
                    .Select(p => p.Trim().ToLower().Replace(".exe", ""))
                    .Distinct()
                    .ToArray();

                if (!int.TryParse(settings[1], out killInterval))
                    return;
            }
            // Обычный режим (запуск из GUI)
            else if (args.Length >= 2)
            {
                processNames = args[0].Split(',')
                    .Select(p => p.Trim().ToLower().Replace(".exe", ""))
                    .Distinct()
                    .ToArray();

                if (!int.TryParse(args[1], out killInterval))
                    return;
            }
            else
            {
                return;
            }

            // Основной цикл блокировки
            while (true)
            {
                foreach (var name in processNames)
                    KillProcess(name);

                Thread.Sleep(killInterval * 1000);
            }
        }

        static void KillProcess(string name)
        {
            foreach (Process process in Process.GetProcessesByName(name))
            {
                if (!process.HasExited)
                {
                    process.Kill();
                    process.WaitForExit(500);
                }
            }
        }
    }
}