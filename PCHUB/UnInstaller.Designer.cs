namespace PCHUB
{
    partial class UnInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnInstaller));
            listBoxPrograms = new ListBox();
            progressBar1 = new ProgressBar();
            buttonUninstall = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            btnRefresh = new Button();
            labelTotal = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPrograms
            // 
            listBoxPrograms.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxPrograms.FormattingEnabled = true;
            listBoxPrograms.HorizontalScrollbar = true;
            listBoxPrograms.ItemHeight = 15;
            listBoxPrograms.Location = new Point(12, 57);
            listBoxPrograms.Name = "listBoxPrograms";
            listBoxPrograms.Size = new Size(632, 334);
            listBoxPrograms.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 427);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(632, 23);
            progressBar1.TabIndex = 1;
            // 
            // buttonUninstall
            // 
            buttonUninstall.Location = new Point(12, 397);
            buttonUninstall.Name = "buttonUninstall";
            buttonUninstall.Size = new Size(310, 25);
            buttonUninstall.TabIndex = 2;
            buttonUninstall.Text = "Delete";
            buttonUninstall.UseVisualStyleBackColor = true;
            buttonUninstall.Click += buttonUninstall_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(656, 24);
            menuStrip1.TabIndex = 3;
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
            // btnRefresh
            // 
            btnRefresh.Location = new Point(334, 397);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(310, 25);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += buttonRefresh_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(12, 39);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(35, 15);
            labelTotal.TabIndex = 5;
            labelTotal.Text = "null";
            // 
            // UnInstaller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 465);
            Controls.Add(labelTotal);
            Controls.Add(btnRefresh);
            Controls.Add(buttonUninstall);
            Controls.Add(progressBar1);
            Controls.Add(listBoxPrograms);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnInstaller";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UnInstaller";
            Load += UnInstaller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPrograms;
        private ProgressBar progressBar1;
        private Button buttonUninstall;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button btnRefresh;
        private Label labelTotal;
    }
}