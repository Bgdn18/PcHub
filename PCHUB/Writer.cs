using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Diagnostics;

namespace PCHUB
{
    public partial class Writer : Form
    {
        private enum ConversionType { None, Binary, Hex }

        public Writer()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e) => CreateFileWithConversion(ConversionType.None);
        private void btnBinaryFile_Click(object sender, EventArgs e) => CreateFileWithConversion(ConversionType.Binary);
        private void btn16DigitCodeFile_Click(object sender, EventArgs e) => CreateFileWithConversion(ConversionType.Hex);

        private void CreateFileWithConversion(ConversionType conversionType)
        {
            try
            {
                var (cleanFileName, isHidden) = ProcessFileName(txtFileName.Text.Trim());
                string content = ProcessContent(txtFileContent.Text, conversionType);
                string fullPath = SaveFile(cleanFileName, content, isHidden);

                UpdateStatus($"File created: {Path.GetFileName(fullPath)}", true);
            }
            catch (Exception ex)
            {
                ShowError($"Error creating file: {ex.Message}");
            }
        }

        private (string fileName, bool isHidden) ProcessFileName(string fileName)
        {
            bool isHidden = fileName.StartsWith("\"") && fileName.EndsWith("\"");
            return (isHidden ? fileName.Trim('"') : fileName, isHidden);
        }

        private string ProcessContent(string content, ConversionType conversionType)
        {
            content = Regex.Replace(content,
                @"isbinary_([\s\S]*?)_isbinary",
                m => $"isbinary_{ConvertToBinary(m.Groups[1].Value)}_isbinary",
                RegexOptions.Singleline);

            content = Regex.Replace(content,
                @"16DigiCode_([\s\S]*?)_16DigiCode",
                m => $"16DigiCode_{ConvertToHex(m.Groups[1].Value)}_16DigiCode",
                RegexOptions.Singleline);

            return conversionType switch
            {
                ConversionType.Binary => ConvertToBinary(content),
                ConversionType.Hex => ConvertToHex(content),
                _ => content
            };
        }

        private string SaveFile(string fileName, string content, bool isHidden)
        {
            string path = Path.Combine(txtFilePath.Text.Trim(), $"{fileName}{txtExtension.Text.Trim()}");
            File.WriteAllText(path, content, Encoding.UTF8);

            if (isHidden)
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);

            return path;
        }

        private string ConvertToBinary(string text) =>
            string.Join(" ", Encoding.UTF8.GetBytes(text).Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

        private string ConvertToHex(string text) =>
            BitConverter.ToString(Encoding.UTF8.GetBytes(text)).Replace("-", " ").ToLower();

        private void UpdateStatus(string message, bool isSuccess) // обновление Статуса при успешном сохранении
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = isSuccess ? Color.Green : Color.Red;
            lblStatus.BackColor = isSuccess ? Color.LightGreen : Color.LightPink;
        }

        private void ShowError(string message) =>
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void lblStatus_Click(object sender, EventArgs e)
        {
            string path = txtFilePath.Text.Trim();

            if (string.IsNullOrEmpty(path))
            {
                ShowError("Enter the path in the text field");
                return;
            }

            try
            {
                if (File.Exists(path))
                    Process.Start("explorer.exe", $"/select, \"{path}\"");
                else if (Directory.Exists(path))
                    Process.Start("explorer.exe", path);
                else
                    ShowError("The specified path does not exist");
            }
            catch (Exception ex)
            {
                ShowError($"Error: {ex.Message}");
            }
        }

        private void FileExplorer_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                txtFilePath.Text = dlg.SelectedPath;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutClass.Open.Build();
        }
    }
}