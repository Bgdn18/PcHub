namespace PCHUB
{
    partial class TextFileCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFileCreator));
            txtFilePath = new TextBox();
            btnCreateFile = new Button();
            lblStatus = new Label();
            txtFileName = new TextBox();
            txtFileContent = new TextBox();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtExtension = new TextBox();
            FileExplorer = new Button();
            btnBinaryFile = new Button();
            btn16DigitCodeFile = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilePath.Cursor = Cursors.IBeam;
            txtFilePath.Font = new Font("Consolas", 8.25F);
            txtFilePath.Location = new Point(12, 35);
            txtFilePath.Multiline = true;
            txtFilePath.Name = "txtFilePath";
            txtFilePath.PlaceholderText = "TXT Path";
            txtFilePath.Size = new Size(484, 27);
            txtFilePath.TabIndex = 0;
            txtFilePath.Text = "C:\\";
            // 
            // btnCreateFile
            // 
            btnCreateFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateFile.Cursor = Cursors.Hand;
            btnCreateFile.Font = new Font("Consolas", 8.25F);
            btnCreateFile.Location = new Point(560, 35);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(161, 27);
            btnCreateFile.TabIndex = 1;
            btnCreateFile.Text = "Create File";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Cursor = Cursors.Hand;
            lblStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 435);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(344, 17);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "STATUS STATUS STATUS STATUS STATUS STATUS STATUS ";
            lblStatus.Click += lblStatus_Click;
            // 
            // txtFileName
            // 
            txtFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileName.Cursor = Cursors.IBeam;
            txtFileName.Font = new Font("Consolas", 8.25F);
            txtFileName.Location = new Point(12, 68);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.PlaceholderText = "TXT Name";
            txtFileName.Size = new Size(543, 27);
            txtFileName.TabIndex = 3;
            // 
            // txtFileContent
            // 
            txtFileContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFileContent.Cursor = Cursors.IBeam;
            txtFileContent.Font = new Font("Consolas", 8.25F);
            txtFileContent.Location = new Point(12, 133);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.PlaceholderText = "TXT File";
            txtFileContent.ScrollBars = ScrollBars.Both;
            txtFileContent.Size = new Size(543, 299);
            txtFileContent.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(736, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Font = new Font("Consolas", 9F);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(54, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Font = new Font("Consolas", 9F);
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(47, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(561, 69);
            label1.Name = "label1";
            label1.Size = new Size(121, 26);
            label1.TabIndex = 6;
            label1.Text = "Use \"\" in file name\r\n for hidden file\r\n";
            // 
            // txtExtension
            // 
            txtExtension.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExtension.Cursor = Cursors.IBeam;
            txtExtension.Font = new Font("Consolas", 8.25F);
            txtExtension.Location = new Point(12, 101);
            txtExtension.Multiline = true;
            txtExtension.Name = "txtExtension";
            txtExtension.PlaceholderText = "Extension";
            txtExtension.Size = new Size(543, 27);
            txtExtension.TabIndex = 7;
            txtExtension.Text = ".txt";
            // 
            // FileExplorer
            // 
            FileExplorer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileExplorer.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileExplorer.Location = new Point(502, 35);
            FileExplorer.Name = "FileExplorer";
            FileExplorer.Size = new Size(53, 27);
            FileExplorer.TabIndex = 24;
            FileExplorer.Text = "File";
            FileExplorer.UseVisualStyleBackColor = true;
            FileExplorer.Click += FileExplorer_Click;
            // 
            // btnBinaryFile
            // 
            btnBinaryFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBinaryFile.Cursor = Cursors.Hand;
            btnBinaryFile.Font = new Font("Consolas", 8.25F);
            btnBinaryFile.Location = new Point(561, 101);
            btnBinaryFile.Name = "btnBinaryFile";
            btnBinaryFile.Size = new Size(161, 27);
            btnBinaryFile.TabIndex = 26;
            btnBinaryFile.Text = "Create Binary File";
            btnBinaryFile.UseVisualStyleBackColor = true;
            btnBinaryFile.Click += btnBinaryFile_Click;
            // 
            // btn16DigitCodeFile
            // 
            btn16DigitCodeFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn16DigitCodeFile.Cursor = Cursors.Hand;
            btn16DigitCodeFile.Font = new Font("Consolas", 8.25F);
            btn16DigitCodeFile.Location = new Point(561, 134);
            btn16DigitCodeFile.Name = "btn16DigitCodeFile";
            btn16DigitCodeFile.Size = new Size(161, 27);
            btn16DigitCodeFile.TabIndex = 27;
            btn16DigitCodeFile.Text = "Create 16DigitCode File";
            btn16DigitCodeFile.UseVisualStyleBackColor = true;
            btn16DigitCodeFile.Click += btn16DigitCodeFile_Click;
            // 
            // TextFileCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 467);
            Controls.Add(btn16DigitCodeFile);
            Controls.Add(btnBinaryFile);
            Controls.Add(FileExplorer);
            Controls.Add(txtExtension);
            Controls.Add(label1);
            Controls.Add(txtFileContent);
            Controls.Add(txtFileName);
            Controls.Add(lblStatus);
            Controls.Add(btnCreateFile);
            Controls.Add(txtFilePath);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new Size(300, 300);
            Name = "TextFileCreator";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextFileCreator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnCreateFile;
        private Label lblStatus;
        private TextBox txtFileName;
        private TextBox txtFileContent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label1;
        private TextBox txtExtension;
        private Button FileExplorer;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button btnBinaryFile;
        private Button btn16DigitCodeFile;
    }
}