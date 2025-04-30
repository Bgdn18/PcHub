using System.Diagnostics;


namespace PCHUB.About
{
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Версия программы
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();

            BuildLabel.Text = ($"Version: {AboutClass.BuildInfo}");
        }

        private void PCHUBlabel_Click(object sender, EventArgs e)
        {
            // где Text это название AboutForm точно также как this.Text
            Text = $"{AboutClass.BuildInfo} !!!"; // меняю название формы

            Random rand = new Random();

            BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            ABOUTTEXT.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            label2.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            ABOUTTEXT.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            label2.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void TelegrammChannel_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/bgdnchannel";

            try {Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });} catch (Exception ex) {MessageBox.Show("Error opening telegramm channel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Bgdn18";

            try {Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });} catch (Exception ex) {MessageBox.Show("Error opening GitHub: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
    }
}
