namespace PCHUB
{
    partial class PowerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerManagement));
            Shutdown = new Button();
            Restart = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Shutdown
            // 
            Shutdown.Cursor = Cursors.Hand;
            Shutdown.Font = new Font("Consolas", 12F);
            Shutdown.Location = new Point(12, 27);
            Shutdown.Name = "Shutdown";
            Shutdown.Size = new Size(193, 58);
            Shutdown.TabIndex = 0;
            Shutdown.Text = "Shutdown";
            Shutdown.UseVisualStyleBackColor = true;
            Shutdown.Click += Shutdown_Click;
            // 
            // Restart
            // 
            Restart.Cursor = Cursors.Hand;
            Restart.Font = new Font("Consolas", 12F);
            Restart.Location = new Point(216, 27);
            Restart.Name = "Restart";
            Restart.Size = new Size(193, 58);
            Restart.TabIndex = 1;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(419, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Font = new Font("Consolas", 9F);
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(47, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // PowerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 94);
            Controls.Add(Restart);
            Controls.Add(Shutdown);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PowerManagement";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PowerManagement";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Shutdown;
        private Button Restart;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}