namespace PCHUB
{
    partial class OpenOrUnlockTaskMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenOrUnlockTaskMgr));
            OpenTaskMgr = new Button();
            UnlockTaskMgr = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // OpenTaskMgr
            // 
            OpenTaskMgr.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            OpenTaskMgr.Location = new Point(12, 35);
            OpenTaskMgr.Name = "OpenTaskMgr";
            OpenTaskMgr.Size = new Size(150, 50);
            OpenTaskMgr.TabIndex = 0;
            OpenTaskMgr.Text = "Open";
            OpenTaskMgr.UseVisualStyleBackColor = true;
            OpenTaskMgr.Click += OpenTaskMgr_Click;
            // 
            // UnlockTaskMgr
            // 
            UnlockTaskMgr.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            UnlockTaskMgr.Location = new Point(192, 35);
            UnlockTaskMgr.Name = "UnlockTaskMgr";
            UnlockTaskMgr.Size = new Size(150, 50);
            UnlockTaskMgr.TabIndex = 1;
            UnlockTaskMgr.Text = "Unlock TaskMgr";
            UnlockTaskMgr.UseVisualStyleBackColor = true;
            UnlockTaskMgr.Click += UnlockTaskMgr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 50);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 2;
            label1.Text = "/";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(353, 24);
            menuStrip1.TabIndex = 3;
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
            // OpenOrUnlockTaskMgr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 97);
            Controls.Add(label1);
            Controls.Add(UnlockTaskMgr);
            Controls.Add(OpenTaskMgr);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OpenOrUnlockTaskMgr";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Open/Unlock";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenTaskMgr;
        private Button UnlockTaskMgr;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}