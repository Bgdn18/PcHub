using PCHUB._Main.Class;
using PCHUB.Main;
using PCHUB.WindowsTool.Class;

namespace PCHUB
{
    public partial class otherTools : Form
    {
        public otherTools()
        {
            InitializeComponent();

            BuildLabel.Text = AboutClass.BuildInfo.ToString();
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

        private void BuildLabel_Click(object sender, EventArgs e) // информация о билде
        {
            AboutClass.Open.Build();
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