using PCHUB._Main.Class;

namespace PCHUB._Choice_Forms
{
    public partial class PerfmonOrTaskmgr : Form
    {
        public PerfmonOrTaskmgr()
        {
            InitializeComponent();
        }

        private void btnPerfmon_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ProcessRun("resmon");
            this.Close();
        }

        private void btnTaskmgr_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ProcessRun("taskmgr");
            this.Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
