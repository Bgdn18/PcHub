namespace PCHUB._PCHUB_Forms._Main
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenClassSpace.OpenClass.ProcessRun("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
