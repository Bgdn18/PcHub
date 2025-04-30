namespace PCHUB.ChoiceSpace
{
    public partial class BrowserExplorerOrJustExplorerDotExe : Form
    {
        public BrowserExplorerOrJustExplorerDotExe()
        {
            InitializeComponent();
        }

        private void btnFileExplorer_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ProcessRun("explorer");

            Close(); // Закрываем форму
        }


        private void btnBrowseFileExplorer_Click(object sender, EventArgs e)
        {
            WinToolSpace.WinToolClass.Open.OpenBrowserExplorer();

            Close(); // Закрываем форму
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}