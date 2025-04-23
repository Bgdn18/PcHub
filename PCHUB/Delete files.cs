using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCHUB.Main;

namespace PCHUB
{
    public partial class Delete_files : Form
    {
        public Delete_files()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter the path to the file or folder", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isFile = File.Exists(path);
            bool isDirectory = Directory.Exists(path);

            if (!isFile && !isDirectory)
            {
                MessageBox.Show("The specified file or folder does not exist", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (isFile)
                {
                    // Удаление файла
                    File.SetAttributes(path, FileAttributes.Normal);
                    File.Delete(path);

                    MessageBox.Show("File successfully deleted", "Info",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (isDirectory)
                {
                    // Удаление папки
                    DeleteDirectory(path);
                    MessageBox.Show("The folder was deleted successfully", "info",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access denied: {ex.Message}", "Access error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Input/output error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Рекурсивное удаление папки
        private void DeleteDirectory(string targetDir)
        {
            foreach (string file in Directory.GetFiles(targetDir))
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string subDir in Directory.GetDirectories(targetDir))
            {
                DeleteDirectory(subDir);
            }

            DirectoryInfo dirInfo = new DirectoryInfo(targetDir);
            dirInfo.Attributes = FileAttributes.Normal;
            Directory.Delete(targetDir, false);
        }

        // Выбор файла
        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dlg.FileName;
                }
            }
        }

        // Выбор папки
        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dlg.SelectedPath;
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
