using PCHUB.Main;

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
            _list.Open.ProcessRun("resmon");
            this.Close();
        }

        private void btnTaskmgr_Click(object sender, EventArgs e)
        {
            _list.Open.ProcessRun("taskmgr");
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _list.Open.ShowForm<About>();
            this.Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
