namespace PCHUB.ChoiceSpace
{
    public partial class PerfmonOrTaskmgr : Form
    {
        public PerfmonOrTaskmgr()
        {
            InitializeComponent();
        }

        private void btnPerfmon_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.Open.ProcessRun("resmon");
            Close();
        }

        private void btnTaskmgr_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.Open.ProcessRun("taskmgr");
            Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
