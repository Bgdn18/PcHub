using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using PCHUB.Main;

namespace PCHUB
{
    public partial class TextFileCreator : Form
    {
        private enum ConversionType { None, Binary, Hex }

        public TextFileCreator()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        _list list = new _list();

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            var (conversionType, cleanFileName, isHidden) = ProcessFileName();
            var fileContent = ProcessFileContent(txtFileContent.Text, conversionType);
            var fullPath = CreateFile(cleanFileName, fileContent);

            if (isHidden)
            {
                File.SetAttributes(fullPath, File.GetAttributes(fullPath) | FileAttributes.Hidden);
            }

            UpdateUIOnSuccess(fullPath);
        }

        private (ConversionType type, string name, bool isHidden) ProcessFileName()
        {
            string originalName = txtFileName.Text.Trim();

            var conversionType = originalName switch
            {
                string s when s.StartsWith("isbinary_") && s.EndsWith("_isbinary") => ConversionType.Binary,
                string s when s.StartsWith("16DigiCode_") && s.EndsWith("_16DigiCode") => ConversionType.Hex,
                _ => ConversionType.None
            };

            string cleanName = CleanFileName(originalName, conversionType);
            bool isHidden = CleanHiddenFileName(ref cleanName);

            return (conversionType, cleanName, isHidden);
        }

        private string CleanFileName(string fileName, ConversionType type)
        {
            return type switch
            {
                ConversionType.Binary => fileName.Replace("isbinary_", "").Replace("_isbinary", ""),
                ConversionType.Hex => fileName.Replace("16DigiCode_", "").Replace("_16DigiCode", ""),
                _ => fileName
            };
        }

        private bool CleanHiddenFileName(ref string fileName)
        {
            if (fileName.StartsWith("\"") && fileName.EndsWith("\""))
            {
                fileName = fileName.Trim('"');
                return true;
            }
            return false;
        }

        private string ProcessFileContent(string content, ConversionType type)
        {
            return type switch
            {
                ConversionType.Binary => TextToBinary(content),
                ConversionType.Hex => TextToHex(content),
                _ => ProcessContentBlocks(content)
            };
        }

        private string CreateFile(string fileName, string content)
        {
            string path = Path.Combine(
                txtFilePath.Text.Trim(),
                $"{fileName}{txtExtension.Text.Trim()}"
            );

            File.WriteAllText(path, content, Encoding.UTF8);
            return path;
        }

        private string ProcessContentBlocks(string content)
        {
            content = Regex.Replace(content,
                @"isbinary_([\s\S]*?)_isbinary",
                m => $"isbinary_{TextToBinary(m.Groups[1].Value)}_isbinary",
                RegexOptions.Singleline);

            return Regex.Replace(content,
                @"16DigiCode_([\s\S]*?)_16DigiCode",
                m => $"16DigiCode_{TextToHex(m.Groups[1].Value)}_16DigiCode",
                RegexOptions.Singleline);
        }

        private string TextToBinary(string text)
        {
            return string.Join(" ", Encoding.UTF8.GetBytes(text)
                .Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        }

        private string TextToHex(string text)
        {
            return BitConverter.ToString(Encoding.UTF8.GetBytes(text))
                .Replace("-", " ").ToLower();
        }

        private void UpdateUIOnSuccess(string path)
        {
            lblStatus.Text = $"File created: {Path.GetFileName(path)}";
            lblStatus.ForeColor = Color.Green;
            lblStatus.BackColor = Color.LightGreen;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.build();
        }


        private void lblStatus_Click(object sender, EventArgs e)
        {
            string path = txtFilePath.Text.Trim();

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Enter the path in the text field");
                return;
            }

            try
            {
                if (File.Exists(path))
                {
                    // Открыть проводник с выделенным файлом
                    Process.Start("explorer.exe", $"/select, \"{path}\"");
                }
                else if (Directory.Exists(path))
                {
                    // Открыть проводник в указанной папке
                    Process.Start("explorer.exe", path);
                }
                else
                {
                    MessageBox.Show("The specified path does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FileExplorer_Click(object sender, EventArgs e)
        {
            list.fileexplorer();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}