using System.Diagnostics;

namespace PCHUB.About
{
    /// <summary>
    /// Предоставляет информацию о сборке и методы для отображения окна "О программе".
    /// <summary>
    internal static class AboutClass
    {
        /// <summary>
        /// Информация о версии и дате сборки PCHub
        /// </summary>
        public const string BuildInfo = "1.0.0 (build 2025-04-27)";

        /// <summary>
        /// Отображает диалоговое окно "О программе"
        /// </summary>
        public static void ShowAboutDialog()
        {
            try
            {
                using (var aboutForm = new AboutForm())
                {
                    aboutForm.ShowDialog();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Failed to open About dialog: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}