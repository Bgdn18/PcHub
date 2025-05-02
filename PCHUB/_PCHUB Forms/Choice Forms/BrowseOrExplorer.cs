namespace PCHUB.ChoiceSpace
{
    public partial class BrowseOrExplorer : Form
    {
        public BrowseOrExplorer()
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
            OpenClassSpace.OpenClass.OpenBrowserExplorer();

            Close(); // Закрываем форму
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}