namespace PCHUB
{
    partial class YouTube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTube));
            defoultbrowserlabelyoutube = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            Settings = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // defoultbrowserlabelyoutube
            // 
            defoultbrowserlabelyoutube.AutoSize = true;
            defoultbrowserlabelyoutube.Cursor = Cursors.Help;
            defoultbrowserlabelyoutube.Font = new Font("Consolas", 9F);
            defoultbrowserlabelyoutube.Location = new Point(306, 282);
            defoultbrowserlabelyoutube.Name = "defoultbrowserlabelyoutube";
            defoultbrowserlabelyoutube.Size = new Size(203, 14);
            defoultbrowserlabelyoutube.TabIndex = 5;
            defoultbrowserlabelyoutube.Text = "Set up your defoult browser:";
            defoultbrowserlabelyoutube.Click += rickroll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnSearch.Location = new Point(12, 179);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(628, 65);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.AccessibleDescription = "";
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            txtSearch.Location = new Point(12, 41);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Browse in your YouTube!";
            txtSearch.Size = new Size(628, 132);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "Bogdan Khorolsky";
            // 
            // Settings
            // 
            Settings.Cursor = Cursors.Hand;
            Settings.Font = new Font("Consolas", 9F);
            Settings.Location = new Point(515, 265);
            Settings.Name = "Settings";
            Settings.Size = new Size(126, 48);
            Settings.TabIndex = 6;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(653, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // YouTube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(653, 325);
            Controls.Add(menuStrip1);
            Controls.Add(Settings);
            Controls.Add(defoultbrowserlabelyoutube);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "YouTube";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YouTube";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label defoultbrowserlabelyoutube;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button Settings;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}