using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCHUB
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "ms-settings:");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии параметров: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Получаем текст из текстового поля
            string query = txtSearch.Text;

            // Проверяем, что текстовое поле не пустое
            if (!string.IsNullOrWhiteSpace(query))
            {
                // Формируем URL для поиска
                string url = "https://" +  Uri.EscapeDataString(query);

                try
                {
                    // Открытие браузера по умолчанию
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии браузера: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(); // Создаем новый экземпляр Form2
            about.Show(); // Открываем Form2 как независимую форму
        }

        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        //WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE WHITE 

        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
        private void purpleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
        }
        //PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE PURPLE 
    }
}
