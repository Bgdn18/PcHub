namespace PCHUB
{
    partial class UnlockPowerMgrForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnlockPowerMgrForm));
            btnDisable = new Button();
            btnEnable = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDisable
            // 
            btnDisable.Cursor = Cursors.Hand;
            btnDisable.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnDisable.Location = new Point(12, 90);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(245, 42);
            btnDisable.TabIndex = 1;
            btnDisable.Text = "Disable Power Mgr";
            btnDisable.UseVisualStyleBackColor = true;
            btnDisable.Click += btnDisable_Click;
            // 
            // btnEnable
            // 
            btnEnable.Cursor = Cursors.Hand;
            btnEnable.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            btnEnable.Location = new Point(12, 42);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(245, 42);
            btnEnable.TabIndex = 2;
            btnEnable.Text = "Enable Power Mgr";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += btnEnable_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(280, 24);
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
            // UnlockPowerMgrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 146);
            Controls.Add(btnEnable);
            Controls.Add(btnDisable);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnlockPowerMgrForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Power Unlock/Lock";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}