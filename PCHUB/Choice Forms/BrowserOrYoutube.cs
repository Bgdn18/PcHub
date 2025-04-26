using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCHUB._Main.Class;

namespace PCHUB._Choice_Forms
{
    public partial class BrowserOrYoutube : Form
    {
        public BrowserOrYoutube()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<Browse>();
            this.Close();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            OpenClass.Open.ShowForm<YouTube>();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutClass.Open.Build();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
