using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PCHUB.SystemCheckSpace
{
    internal class SystemCheckClass
    {
        public static class SystemChecks // Проверки
        {
            public static bool isadmin() // проверка на то является ли пользователь админом
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                    .IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
