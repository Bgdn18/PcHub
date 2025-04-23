using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PCHUBBlockingApps
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow); // скрывает консоль

        private const int SW_HIDE = 0;
        private const string AutostartFlag = "--autostart";
        private const string SettingsFileName = "blocker_settings.txt";
        private const string AppDataFolder = "PCHUBBlocker";

        static void Main(string[] args)
        {
            ShowWindow(GetConsoleWindow(), SW_HIDE);

            if (args.Length == 0) return;

            var (processNames, killInterval) = ParseArguments(args);
            if (processNames == null || killInterval <= 0) return;

            RunBlockingLoop(processNames, killInterval);
        }

        private static (string[] processNames, int killInterval) ParseArguments(string[] args)
        {
            if (args[0] == AutostartFlag)
            {
                string settingsPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    AppDataFolder,
                    SettingsFileName);

                if (!File.Exists(settingsPath)) return (null!, 0);

                string[] settings = File.ReadAllLines(settingsPath);
                if (settings.Length < 2) return (null!, 0);

                return (ParseProcessNames(settings[0]),
                       int.TryParse(settings[1], out int interval) ? interval : 0);
            }

            if (args.Length >= 2)
            {
                return (ParseProcessNames(args[0]),
                       int.TryParse(args[1], out int interval) ? interval : 0);
            }

            return (null!, 0);
        }

        private static string[] ParseProcessNames(string input) // удаляет .exe из имени
        {
            return input.Split(',')
                       .Select(p => p.Trim().ToLower().Replace(".exe", ""))
                       .Distinct()
                       .ToArray();
        }

        private static void RunBlockingLoop(string[] processNames, int killInterval)
        {
            while (true)
            {
                foreach (var name in processNames)
                {
                    KillProcess(name);
                }
                Thread.Sleep(killInterval * 1000);
            }
        }

        private static void KillProcess(string name)
        {
            foreach (var process in Process.GetProcessesByName(name).Where(p => !p.HasExited))
            {
                    process.Kill();
                    process.WaitForExit(500);
            }
        }
    }
}