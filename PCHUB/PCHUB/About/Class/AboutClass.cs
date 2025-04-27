using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHUB.About
{
    internal class AboutClass
    {
        // Информация о билде!!!
        public const string BuildInfo = "1.0.0 (build 2025-04-27)";
        // Информация о билде!!!

        public static class Open
        {
            public static void Build() // Открывает Информацию О приложении
            {
                try
                {
                    new AboutForm().ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening Build Info: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
