namespace PCHUB
{
    partial class BrowserExplorerOrJustExplorerDotExe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserExplorerOrJustExplorerDotExe));
            label1 = new Label();
            btnBrowseFileExplorer = new Button();
            btnFileExplorer = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 50);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 5;
            label1.Text = "/";
            // 
            // btnBrowseFileExplorer
            // 
            btnBrowseFileExplorer.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnBrowseFileExplorer.Location = new Point(192, 35);
            btnBrowseFileExplorer.Name = "btnBrowseFileExplorer";
            btnBrowseFileExplorer.Size = new Size(150, 50);
            btnBrowseFileExplorer.TabIndex = 4;
            btnBrowseFileExplorer.Text = "Browse File Explorer";
            btnBrowseFileExplorer.UseVisualStyleBackColor = true;
            btnBrowseFileExplorer.Click += btnBrowseFileExplorer_Click;
            // 
            // btnFileExplorer
            // 
            btnFileExplorer.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnFileExplorer.Location = new Point(12, 35);
            btnFileExplorer.Name = "btnFileExplorer";
            btnFileExplorer.Size = new Size(150, 50);
            btnFileExplorer.TabIndex = 3;
            btnFileExplorer.Text = "File Explorer";
            btnFileExplorer.UseVisualStyleBackColor = true;
            btnFileExplorer.Click += btnFileExplorer_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(353, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // BrowserExplorerOrJustExplorerDotExe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 97);
            Controls.Add(label1);
            Controls.Add(btnBrowseFileExplorer);
            Controls.Add(btnFileExplorer);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BrowserExplorerOrJustExplorerDotExe";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileExplorer/BrowseFileExplorer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBrowseFileExplorer;
        private Button btnFileExplorer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}