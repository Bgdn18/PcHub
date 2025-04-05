using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCHUB.Main;

namespace PCHUB
{
    public partial class PowerManagement : Form
    {
        [DllImport("ntdll.dll")]
        private static extern int RtlAdjustPrivilege(int Privilege, bool Enable, bool CurrentThread, out bool Enabled);

        [DllImport("ntdll.dll")]
        private static extern int NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

        const int SE_SHUTDOWN_PRIVILEGE = 0x13;


        _list list = new _list();
        public PowerManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSOD_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Через 3 секунды Windows уйдет в BSOD...");
            System.Threading.Thread.Sleep(3000);

            bool enabled;
            RtlAdjustPrivilege(SE_SHUTDOWN_PRIVILEGE, true, false, out enabled);
            uint response;
            NtRaiseHardError(0xC000021A, 0, 0, IntPtr.Zero, 6, out response);
        }
    }
}
