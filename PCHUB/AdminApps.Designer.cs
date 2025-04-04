namespace PCHUB
{
    partial class AdminApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminApps));
            TxtWriter = new Button();
            TaskMgr = new Button();
            REGEDIT = new Button();
            CONTROLPANEL = new Button();
            EXPLORER = new Button();
            CMD = new Button();
            menuStrip1 = new MenuStrip();
            themesToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            ExplorerPP = new Button();
            ProccesHacker = new Button();
            IoBitUnlocker = new Button();
            AddLocalUser = new Button();
            TaskMgrControl = new Button();
            BuildLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtWriter
            // 
            TxtWriter.Cursor = Cursors.Hand;
            TxtWriter.Font = new Font("Consolas", 9F);
            TxtWriter.Location = new Point(14, 44);
            TxtWriter.Name = "TxtWriter";
            TxtWriter.Size = new Size(128, 50);
            TxtWriter.TabIndex = 19;
            TxtWriter.Text = "Writer";
            TxtWriter.UseVisualStyleBackColor = true;
            TxtWriter.Click += TxtWriter_Click;
            // 
            // TaskMgr
            // 
            TaskMgr.Cursor = Cursors.Hand;
            TaskMgr.Font = new Font("Consolas", 9F);
            TaskMgr.Location = new Point(148, 44);
            TaskMgr.Name = "TaskMgr";
            TaskMgr.Size = new Size(128, 50);
            TaskMgr.TabIndex = 18;
            TaskMgr.Text = "Task Mgr";
            TaskMgr.UseVisualStyleBackColor = true;
            TaskMgr.Click += RESOURCEMONITOR_Click;
            // 
            // REGEDIT
            // 
            REGEDIT.Cursor = Cursors.Hand;
            REGEDIT.Font = new Font("Consolas", 9F);
            REGEDIT.Location = new Point(550, 45);
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
            CONTROLPANEL.Location = new Point(416, 45);
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
            EXPLORER.Location = new Point(282, 44);
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
            CMD.Text = "CMD";
            CMD.UseVisualStyleBackColor = true;
            CMD.Click += CMD_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Font = new Font("Consolas", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { themesToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(689, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // themesToolStripMenuItem
            // 
            themesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, purpleToolStripMenuItem });
            themesToolStripMenuItem.Font = new Font("Consolas", 9F);
            themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            themesToolStripMenuItem.Size = new Size(61, 20);
            themesToolStripMenuItem.Text = "Themes";
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(116, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // purpleToolStripMenuItem
            // 
            purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            purpleToolStripMenuItem.Size = new Size(116, 22);
            purpleToolStripMenuItem.Text = "Purple";
            purpleToolStripMenuItem.Click += purpleToolStripMenuItem_Click;
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
            ExplorerPP.Location = new Point(282, 100);
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
            ProccesHacker.Location = new Point(416, 101);
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
            IoBitUnlocker.Location = new Point(14, 100);
            IoBitUnlocker.Name = "IoBitUnlocker";
            IoBitUnlocker.Size = new Size(128, 50);
            IoBitUnlocker.TabIndex = 25;
            IoBitUnlocker.Text = "Unlocker";
            IoBitUnlocker.UseVisualStyleBackColor = true;
            IoBitUnlocker.Click += IObitUnlocker_Click;
            // 
            // AddLocalUser
            // 
            AddLocalUser.Font = new Font("Consolas", 9F);
            AddLocalUser.Location = new Point(550, 100);
            AddLocalUser.Name = "AddLocalUser";
            AddLocalUser.Size = new Size(128, 53);
            AddLocalUser.TabIndex = 26;
            AddLocalUser.Text = "Add Local User 👥";
            AddLocalUser.UseVisualStyleBackColor = true;
            AddLocalUser.Click += LocalUser_Click;
            // 
            // TaskMgrControl
            // 
            TaskMgrControl.Cursor = Cursors.Hand;
            TaskMgrControl.Font = new Font("Consolas", 9F);
            TaskMgrControl.Location = new Point(14, 156);
            TaskMgrControl.Name = "TaskMgrControl";
            TaskMgrControl.Size = new Size(128, 50);
            TaskMgrControl.TabIndex = 27;
            TaskMgrControl.Text = "Task Manager Control";
            TaskMgrControl.UseVisualStyleBackColor = true;
            TaskMgrControl.Click += TaskMgrUnlocker_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(13, 340);
            BuildLabel.Margin = new Padding(4, 0, 4, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 28;
            BuildLabel.Text = "null";
            BuildLabel.Click += BuildLabel_Click;
            // 
            // AdminApps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(689, 369);
            Controls.Add(BuildLabel);
            Controls.Add(TaskMgrControl);
            Controls.Add(AddLocalUser);
            Controls.Add(IoBitUnlocker);
            Controls.Add(ProccesHacker);
            Controls.Add(ExplorerPP);
            Controls.Add(TxtWriter);
            Controls.Add(TaskMgr);
            Controls.Add(REGEDIT);
            Controls.Add(CONTROLPANEL);
            Controls.Add(EXPLORER);
            Controls.Add(CMD);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminApps";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tools";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TxtWriter;
        private Button TaskMgr;
        private Button REGEDIT;
        private Button CONTROLPANEL;
        private Button EXPLORER;
        private Button CMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button ExplorerPP;
        private Button ProccesHacker;
        private Button IoBitUnlocker;
        private Button AddLocalUser;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button TaskMgrControl;
        private Label BuildLabel;
    }
}