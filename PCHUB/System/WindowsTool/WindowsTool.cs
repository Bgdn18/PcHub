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
            OpenClassSpace.OpenClass.Open.ProcessRun("control.exe");
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
            if (!SystemCheckSpace.SystemCheckClass.SystemChecks.isadmin())
            {
                MessageBox.Show("Error, try running as administrator: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OpenClassSpace.OpenClass.Open.ProcessRun("regedit");
        }
    }
}