using System.Security.Principal;

namespace PCHUB.SystemCheckSpace
{
    internal class SystemCheckClass
    {
        public static bool isadmin() // вернет значение true или false от того является ли пользователь адмном
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                .IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void CheckAdminStatus() // если isadmin == false тогда выдает ошибку
        {
            if (!isadmin())
            {
                MessageBoxClassSpace.MessageBoxShowClass.ShowErrorMessage("No administrator rights");
                Environment.Exit(0);
            }
        }
    }
}
