namespace PCHUB
{
    partial class Browse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browse));
            txtSearch = new TextBox();
            btnSearch = new Button();
            defoultbrowserlabel = new Label();
            Settings = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.AccessibleDescription = "";
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Consolas", 11.25F);
            txtSearch.Location = new Point(12, 41);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Browse in your defoult browser!";
            txtSearch.Size = new Size(628, 132);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "https://www.google.com/search?q=PCHUB";
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Consolas", 11.25F);
            btnSearch.Location = new Point(12, 179);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(628, 65);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // defoultbrowserlabel
            // 
            defoultbrowserlabel.AutoSize = true;
            defoultbrowserlabel.Font = new Font("Consolas", 9F);
            defoultbrowserlabel.Location = new Point(306, 282);
            defoultbrowserlabel.Name = "defoultbrowserlabel";
            defoultbrowserlabel.Size = new Size(203, 14);
            defoultbrowserlabel.TabIndex = 2;
            defoultbrowserlabel.Text = "Set up your defoult browser:";
            // 
            // Settings
            // 
            Settings.Cursor = Cursors.Hand;
            Settings.Font = new Font("Consolas", 9F);
            Settings.Location = new Point(515, 265);
            Settings.Name = "Settings";
            Settings.Size = new Size(126, 48);
            Settings.TabIndex = 3;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(653, 24);
            menuStrip1.TabIndex = 4;
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
            // Browse
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 325);
            Controls.Add(Settings);
            Controls.Add(defoultbrowserlabel);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Browse";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browse";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Label defoultbrowserlabel;
        private Button Settings;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}