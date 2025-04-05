namespace PCHUB
{
    partial class otherTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otherTools));
            REGEDIT = new Button();
            CONTROLPANEL = new Button();
            EXPLORER = new Button();
            CMD = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            ExplorerPP = new Button();
            ProccesHacker = new Button();
            IoBitUnlocker = new Button();
            BuildLabel = new Label();
            btnZapret = new Button();
            btnTaskMgr = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // REGEDIT
            // 
            REGEDIT.Cursor = Cursors.Hand;
            REGEDIT.Font = new Font("Consolas", 9F);
            REGEDIT.Location = new Point(282, 44);
            REGEDIT.Name = "REGEDIT";
            REGEDIT.Size = new Size(128, 50);
            REGEDIT.TabIndex = 17;
            REGEDIT.Text = "REGEDIT";
            REGEDIT.UseVisualStyleBackColor = true;
            REGEDIT.Click += REGEDIT_Click;
            // 
            // CONTROLPANEL
            // 
            CONTROLPANEL.Cursor = Cursors.Hand;
            CONTROLPANEL.Font = new Font("Consolas", 9F);
            CONTROLPANEL.Location = new Point(148, 45);
            CONTROLPANEL.Name = "CONTROLPANEL";
            CONTROLPANEL.Size = new Size(128, 50);
            CONTROLPANEL.TabIndex = 16;
            CONTROLPANEL.Text = "Control Panel";
            CONTROLPANEL.UseVisualStyleBackColor = true;
            CONTROLPANEL.Click += CONTROLPANEL_Click;
            // 
            // EXPLORER
            // 
            EXPLORER.Cursor = Cursors.Hand;
            EXPLORER.Font = new Font("Consolas", 9F);
            EXPLORER.Location = new Point(12, 44);
            EXPLORER.Name = "EXPLORER";
            EXPLORER.Size = new Size(128, 50);
            EXPLORER.TabIndex = 15;
            EXPLORER.Text = "File Explorer";
            EXPLORER.UseVisualStyleBackColor = true;
            EXPLORER.Click += EXPLORER_Click;
            // 
            // CMD
            // 
            CMD.Cursor = Cursors.Hand;
            CMD.Font = new Font("Consolas", 9F);
            CMD.Location = new Point(148, 101);
            CMD.Name = "CMD";
            CMD.Size = new Size(128, 50);
            CMD.TabIndex = 14;
            CMD.Text = "Windows CMD";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Font = new Font("Consolas", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(689, 24);
            menuStrip1.TabIndex = 20;
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
            // ExplorerPP
            // 
            ExplorerPP.Cursor = Cursors.Hand;
            ExplorerPP.Font = new Font("Consolas", 9F);
            ExplorerPP.Location = new Point(416, 44);
            ExplorerPP.Name = "ExplorerPP";
            ExplorerPP.Size = new Size(128, 50);
            ExplorerPP.TabIndex = 23;
            ExplorerPP.Text = "Explorer++";
            ExplorerPP.UseVisualStyleBackColor = true;
            ExplorerPP.Click += ExplorerPP_Click;
            // 
            // ProccesHacker
            // 
            ProccesHacker.Cursor = Cursors.Hand;
            ProccesHacker.Font = new Font("Consolas", 9F);
            ProccesHacker.Location = new Point(282, 100);
            ProccesHacker.Name = "ProccesHacker";
            ProccesHacker.Size = new Size(128, 50);
            ProccesHacker.TabIndex = 24;
            ProccesHacker.Text = "Procces Hacker";
            ProccesHacker.UseVisualStyleBackColor = true;
            ProccesHacker.Click += button1_Click;
            // 
            // IoBitUnlocker
            // 
            IoBitUnlocker.Cursor = Cursors.Hand;
            IoBitUnlocker.Font = new Font("Consolas", 9F);
            IoBitUnlocker.Location = new Point(550, 44);
            IoBitUnlocker.Name = "IoBitUnlocker";
            IoBitUnlocker.Size = new Size(128, 50);
            IoBitUnlocker.TabIndex = 25;
            IoBitUnlocker.Text = "IObit Unlocker";
            IoBitUnlocker.UseVisualStyleBackColor = true;
            IoBitUnlocker.Click += IObitUnlocker_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(0, 340);
            BuildLabel.Margin = new Padding(4, 0, 4, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 28;
            BuildLabel.Text = "null";
            BuildLabel.Click += BuildLabel_Click;
            // 
            // btnZapret
            // 
            btnZapret.Cursor = Cursors.Hand;
            btnZapret.Font = new Font("Consolas", 9F);
            btnZapret.Location = new Point(416, 100);
            btnZapret.Name = "btnZapret";
            btnZapret.Size = new Size(128, 50);
            btnZapret.TabIndex = 29;
            btnZapret.Text = "Zapret";
            btnZapret.UseVisualStyleBackColor = true;
            btnZapret.Click += btnZapret_Click;
            // 
            // btnTaskMgr
            // 
            btnTaskMgr.Cursor = Cursors.Hand;
            btnTaskMgr.Font = new Font("Consolas", 9F);
            btnTaskMgr.Location = new Point(12, 100);
            btnTaskMgr.Name = "btnTaskMgr";
            btnTaskMgr.Size = new Size(128, 50);
            btnTaskMgr.TabIndex = 30;
            btnTaskMgr.Text = "Task Manager";
            btnTaskMgr.UseVisualStyleBackColor = true;
            btnTaskMgr.Click += btnTaskMgr_Click;
            // 
            // otherTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 369);
            Controls.Add(btnTaskMgr);
            Controls.Add(btnZapret);
            Controls.Add(BuildLabel);
            Controls.Add(IoBitUnlocker);
            Controls.Add(ProccesHacker);
            Controls.Add(ExplorerPP);
            Controls.Add(REGEDIT);
            Controls.Add(CONTROLPANEL);
            Controls.Add(EXPLORER);
            Controls.Add(CMD);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "otherTools";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3rd party Apps";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button REGEDIT;
        private Button CONTROLPANEL;
        private Button EXPLORER;
        private Button CMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button ExplorerPP;
        private Button ProccesHacker;
        private Button IoBitUnlocker;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label BuildLabel;
        private Button btnZapret;
        private Button btnTaskMgr;
    }
}