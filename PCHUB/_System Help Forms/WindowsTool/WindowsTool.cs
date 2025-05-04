using System.Diagnostics;
using PCHUB.ChoiceSpace;

namespace PCHUB.WinToolSpace
{
    public partial class WinToolsForm : Form
    {
        public WinToolsForm()
        {
            InitializeComponent();
        }

        #region Buttons Event Handlers
        private void CONTROLPANEL_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ProcessRun("control.exe");

        private void CMD_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ProcessRun("cmd", "/k help & cd C:\\");

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void btnRegedit_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ProcessRun("regedit");

        private void btnDeviceMGR_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ProcessRun("mmc.exe", "devmgmt.msc");

        private void btnTaskmgrOrResmon_Click(object sender, EventArgs e) => OpenClassSpace.OpenClass.ShowForm<ResmonOrTaskmgr>();
        #endregion
    }
}