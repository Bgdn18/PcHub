using PCHUB.Main;

namespace PCHUB
{
    public partial class _MAIN : Form
    {
        public _MAIN()
        {
            InitializeComponent();

            BuildLabel.Text = list.buildinfo;
        }

        //List объявление
        _list list = new _list();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build(); // информация о программме
        }

        private void Library_Click(object sender, EventArgs e)
        {
            list.library();
        }

        private void TxtWriter_Click(object sender, EventArgs e)
        {
            list.writer();
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
            list.tools();
        }

        private void LocalUser_Click(object sender, EventArgs e)
        {
            list.localuser();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.quit();
        }

        private void Taskkiller_Click(object sender, EventArgs e)
        {
            list.taskkill();
        }

        private void build_Click(object sender, EventArgs e)
        {
            list.build();
        }

        private void ADDTXTFILE_TEXT_Click(object sender, EventArgs e)
        {
            list.writer();
        }

        private void PowerManagement_Click(object sender, EventArgs e)
        {
            list.powermgr();
        }
        public void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.addtostartup();
        }

        public void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.removefromstartup();
        }

        private void CMD_Click(object sender, EventArgs e)
        {
            list.cmd();
        }

        private void IOBitUnlocker_Click(object sender, EventArgs e)
        {
            list.unlocker();
        }

        private void TaskMgr_Click(object sender, EventArgs e)
        {
            list.taskmgr();
        }

        private void ExplorerPP_Click(object sender, EventArgs e)
        {
            list.explorerpp();
        }

        private void fileexplorer_Click(object sender, EventArgs e)
        {
            list.fileexplorer();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            list.deletefilesform();
        }
    }
}