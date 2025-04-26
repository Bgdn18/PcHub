namespace PCHUB._Choice_Forms
{
    partial class BrowserOrYoutube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserOrYoutube));
            label1 = new Label();
            btnYoutube = new Button();
            btnBrowser = new Button();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
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
            label1.TabIndex = 9;
            label1.Text = "/";
            // 
            // btnYoutube
            // 
            btnYoutube.Cursor = Cursors.Hand;
            btnYoutube.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnYoutube.Location = new Point(192, 35);
            btnYoutube.Name = "btnYoutube";
            btnYoutube.Size = new Size(150, 50);
            btnYoutube.TabIndex = 8;
            btnYoutube.Text = "Search Youtube";
            btnYoutube.UseVisualStyleBackColor = true;
            btnYoutube.Click += btnYoutube_Click;
            // 
            // btnBrowser
            // 
            btnBrowser.Cursor = Cursors.Hand;
            btnBrowser.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnBrowser.Location = new Point(12, 35);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(150, 50);
            btnBrowser.TabIndex = 7;
            btnBrowser.Text = "Browser";
            btnBrowser.UseVisualStyleBackColor = true;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(353, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // BrowserOrYoutube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 97);
            Controls.Add(label1);
            Controls.Add(btnYoutube);
            Controls.Add(btnBrowser);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BrowserOrYoutube";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browser Or Youtube";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnYoutube;
        private Button btnBrowser;
        private ToolStripMenuItem quitToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}