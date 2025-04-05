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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            FileExplorer = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilePath
            // 
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
            btnCreateFile.Cursor = Cursors.Hand;
            btnCreateFile.Font = new Font("Consolas", 8.25F);
            btnCreateFile.Location = new Point(560, 35);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(161, 60);
            btnCreateFile.TabIndex = 1;
            btnCreateFile.Text = "Create TXT File";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // lblStatus
            // 
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
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(560, 269);
            label1.Name = "label1";
            label1.Size = new Size(121, 26);
            label1.TabIndex = 6;
            label1.Text = "Use \"\" in file name\r\n for hidden file\r\n";
            // 
            // txtExtension
            // 
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
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Consolas", 8.25F);
            textBox1.Location = new Point(560, 368);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 64);
            textBox1.TabIndex = 10;
            textBox1.Text = "use \"16DigiCode_\" and \"_16DigiCode\" at the end\r\n to make the text binary";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Consolas", 8.25F);
            textBox2.Location = new Point(559, 298);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(161, 64);
            textBox2.TabIndex = 11;
            textBox2.Text = "use \"isbinary_\" and \"_isbinary\" at the end\r\n to make the text binary";
            // 
            // FileExplorer
            // 
            FileExplorer.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileExplorer.Location = new Point(502, 35);
            FileExplorer.Name = "FileExplorer";
            FileExplorer.Size = new Size(53, 27);
            FileExplorer.TabIndex = 24;
            FileExplorer.Text = "File";
            FileExplorer.UseVisualStyleBackColor = true;
            FileExplorer.Click += FileExplorer_Click;
            // 
            // TextFileCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 467);
            Controls.Add(FileExplorer);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            MaximizeBox = false;
            MinimizeBox = false;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button FileExplorer;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}