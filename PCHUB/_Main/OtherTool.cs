using PCHUB.Main;

namespace PCHUB
{
    public partial class otherTools : Form
    {
        public otherTools()
        {
            InitializeComponent();

            BuildLabel.Text = _list.BuildInfo;
        }

        private void CONTROLPANEL_Click(object sender, EventArgs e)
        {
            _list.Open.ProcessRun("control.exe");
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            _list.OpenSystemTools.Cmd();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildLabel_Click(object sender, EventArgs e) // информация о билде
        {
            _list.Open.Build();
        }

        private void btnRegedit_Click(object sender, EventArgs e) // Regedit
        {
            if (!_list.SystemChecks.isadmin())
            {
                MessageBox.Show("Error, try running as administrator: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                _list.Open.ProcessRun("regedit");
        }
    }
}