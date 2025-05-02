namespace PCHUB.ChoiceSpace
{
    public partial class ResmonOrTaskmgr : Form
    {
        public ResmonOrTaskmgr()
        {
            InitializeComponent();
        }

        private void btnPerfmon_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ProcessRun("resmon");
            Close();
        }

        private void btnTaskmgr_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ProcessRun("taskmgr");
            Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
