﻿using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace PCHUB
{
    public partial class TextFileCreator : Form
    {
        private enum ConversionType { None, Binary, Hex }

        public TextFileCreator()
        {
            InitializeComponent();
            ConfigureInitialUI();
        }

        private void ConfigureInitialUI()
        {
            this.BackColor = Color.White;
            menuStrip1.BackColor = Color.Silver;
            lblStatus.ForeColor = Color.Black;
        }

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
            lblStatus.Text = $"Файл создан: {Path.GetFileName(path)}";
            lblStatus.ForeColor = Color.Green;
            lblStatus.BackColor = Color.LightGreen;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            menuStrip1.BackColor = Color.Silver;
        }

        private void purpleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.RebeccaPurple;
            menuStrip1.BackColor = Color.MediumPurple;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Обработка кликов по меню
        }
    }
}