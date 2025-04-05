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
using PCHUB.Main;

namespace PCHUB
{
    public partial class TaskKiller : Form
    {
        public TaskKiller()
        {
            InitializeComponent();
        }

        _list list = new _list();

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            string processName = txtProcessName.Text; // текстовое имя

            try
            {
                // Получаем все процессы с указанным именем
                Process[] processes = Process.GetProcessesByName(processName);

                // Проверяем, есть ли такие процессы
                if (processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                        process.Kill(); // Завершаем процесс
                    }
                    MessageBox.Show($"Process '{processName}' successfully completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProcessName.Text = "";
                }
                else
                {
                    MessageBox.Show($"Process '{processName}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProcessName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error terminating process: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcessName.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build();
        }

        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            list.quit();
        }
    }
}
