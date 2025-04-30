namespace PCHUB.WinToolSpace
{
    public partial class WinToolsForm : Form
    {
        public WinToolsForm()
        {
            InitializeComponent();
        }

        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ProcessRun("control.exe");
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            WinToolClass.Open.Cmd();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegedit_Click(object sender, EventArgs e) // Regedit
        {
            if (!SystemCheckSpace.SystemCheckClass.isadmin())
            {
                MessageBox.Show("Error, try running as administrator: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OpenClassSpace.OpenClass.ProcessRun("regedit");
        }

        private void btnDeviceMGR_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ProcessRun("mmc.exe", "devmgmt.msc");
        }

        private void btnWinLogon_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ShowForm<WinLogonSpace.WinLogonEditForm>();
        }
    }
}