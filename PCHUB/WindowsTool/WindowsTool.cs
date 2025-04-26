using PCHUB._Main.Class;
using PCHUB.WindowsTool.Class;

namespace PCHUB
{
    public partial class otherTools : Form
    {
        public otherTools()
        {
            InitializeComponent();
        }

        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ProcessRun("control.exe");
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            WinToolClass.Open.Cmd();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegedit_Click(object sender, EventArgs e) // Regedit
        {
            if (!SystemCheckClass.SystemChecks.isadmin())
            {
                MessageBox.Show("Error, try running as administrator: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OpenClass.Open.ProcessRun("regedit");
        }
    }
}