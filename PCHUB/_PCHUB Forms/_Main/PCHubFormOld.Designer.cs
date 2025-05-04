namespace PCHUB
{
    partial class PCHubFormOld
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCHubFormOld));
            btnTaskMGR = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            btnTxtWriter = new Button();
            btnTaskkiller = new Button();
            btnFileExplorer = new Button();
            btnAddLocalUser = new Button();
            BuildLabel = new Label();
            btnPowerMgr = new Button();
            btnHostsFile = new Button();
            btnPowerShellPolicyManager = new Button();
            btnTools = new Button();
            btnFileDelete = new Button();
            btnUninstaller = new Button();
            UnlockSystem = new Button();
            btnBlockWebSite = new Button();
            btnUtilMan = new Button();
            btnCmdLine = new Button();
            btnMyProgramList = new Button();
            btnWinLogon = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTaskMGR
            // 
            btnTaskMGR.Anchor = AnchorStyles.Top;
            btnTaskMGR.BackColor = SystemColors.Control;
            btnTaskMGR.Cursor = Cursors.Hand;
            btnTaskMGR.FlatStyle = FlatStyle.System;
            btnTaskMGR.Font = new Font("Consolas", 8.25F);
            btnTaskMGR.ForeColor = Color.Black;
            btnTaskMGR.Location = new Point(178, 118);
            btnTaskMGR.Name = "btnTaskMGR";
            btnTaskMGR.Size = new Size(125, 35);
            btnTaskMGR.TabIndex = 8;
            btnTaskMGR.Text = "Taskmgr\r\nOr Resmon";
            btnTaskMGR.UseVisualStyleBackColor = false;
            btnTaskMGR.Click += TaskManager_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 8;
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
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Font = new Font("Consolas", 9F);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(54, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnTxtWriter
            // 
            btnTxtWriter.Anchor = AnchorStyles.Top;
            btnTxtWriter.BackColor = SystemColors.Control;
            btnTxtWriter.Cursor = Cursors.Hand;
            btnTxtWriter.FlatStyle = FlatStyle.System;
            btnTxtWriter.Font = new Font("Consolas", 8.25F);
            btnTxtWriter.ForeColor = Color.Black;
            btnTxtWriter.Location = new Point(45, 118);
            btnTxtWriter.Name = "btnTxtWriter";
            btnTxtWriter.Size = new Size(125, 35);
            btnTxtWriter.TabIndex = 7;
            btnTxtWriter.Text = "Writer";
            btnTxtWriter.UseVisualStyleBackColor = false;
            btnTxtWriter.Click += TxtWriter_Click;
            // 
            // btnTaskkiller
            // 
            btnTaskkiller.Anchor = AnchorStyles.Top;
            btnTaskkiller.BackColor = SystemColors.Control;
            btnTaskkiller.Cursor = Cursors.Hand;
            btnTaskkiller.FlatStyle = FlatStyle.System;
            btnTaskkiller.Font = new Font("Consolas", 8.25F);
            btnTaskkiller.ForeColor = Color.Black;
            btnTaskkiller.Location = new Point(178, 77);
            btnTaskkiller.Margin = new Padding(4, 3, 4, 3);
            btnTaskkiller.Name = "btnTaskkiller";
            btnTaskkiller.Size = new Size(125, 35);
            btnTaskkiller.TabIndex = 5;
            btnTaskkiller.Text = "TaskKiller";
            btnTaskkiller.UseVisualStyleBackColor = false;
            btnTaskkiller.Click += Taskkiller_Click;
            // 
            // btnFileExplorer
            // 
            btnFileExplorer.Anchor = AnchorStyles.Top;
            btnFileExplorer.BackColor = SystemColors.Control;
            btnFileExplorer.Cursor = Cursors.Hand;
            btnFileExplorer.FlatStyle = FlatStyle.System;
            btnFileExplorer.Font = new Font("Consolas", 8.25F);
            btnFileExplorer.ForeColor = Color.Black;
            btnFileExplorer.Location = new Point(310, 118);
            btnFileExplorer.Name = "btnFileExplorer";
            btnFileExplorer.Size = new Size(125, 35);
            btnFileExplorer.TabIndex = 9;
            btnFileExplorer.Text = "Browse Explorer \r\nOr File Explorer";
            btnFileExplorer.UseVisualStyleBackColor = false;
            btnFileExplorer.Click += FileExplorer_Click;
            // 
            // btnAddLocalUser
            // 
            btnAddLocalUser.Anchor = AnchorStyles.Top;
            btnAddLocalUser.BackColor = SystemColors.Control;
            btnAddLocalUser.Cursor = Cursors.Hand;
            btnAddLocalUser.FlatStyle = FlatStyle.System;
            btnAddLocalUser.Font = new Font("Consolas", 8.25F);
            btnAddLocalUser.ForeColor = Color.Black;
            btnAddLocalUser.Location = new Point(45, 36);
            btnAddLocalUser.Name = "btnAddLocalUser";
            btnAddLocalUser.Size = new Size(125, 35);
            btnAddLocalUser.TabIndex = 1;
            btnAddLocalUser.Text = "Add Local User";
            btnAddLocalUser.UseVisualStyleBackColor = false;
            btnAddLocalUser.Click += btnLocalUser_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(0, 432);
            BuildLabel.Margin = new Padding(4, 0, 4, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 18;
            BuildLabel.Text = "null";
            BuildLabel.Click += btnbuildhelp_Click;
            // 
            // btnPowerMgr
            // 
            btnPowerMgr.Anchor = AnchorStyles.Top;
            btnPowerMgr.BackColor = SystemColors.Control;
            btnPowerMgr.Cursor = Cursors.Hand;
            btnPowerMgr.FlatStyle = FlatStyle.System;
            btnPowerMgr.Font = new Font("Consolas", 8.25F);
            btnPowerMgr.ForeColor = Color.Black;
            btnPowerMgr.Location = new Point(45, 77);
            btnPowerMgr.Margin = new Padding(4, 3, 4, 3);
            btnPowerMgr.Name = "btnPowerMgr";
            btnPowerMgr.Size = new Size(125, 35);
            btnPowerMgr.TabIndex = 4;
            btnPowerMgr.Text = "Power \r\nmanagement";
            btnPowerMgr.UseVisualStyleBackColor = false;
            btnPowerMgr.Click += btnPowerMgr_Click;
            // 
            // btnHostsFile
            // 
            btnHostsFile.Anchor = AnchorStyles.Top;
            btnHostsFile.BackColor = SystemColors.Control;
            btnHostsFile.Cursor = Cursors.Hand;
            btnHostsFile.FlatStyle = FlatStyle.System;
            btnHostsFile.Font = new Font("Consolas", 8.25F);
            btnHostsFile.ForeColor = Color.Black;
            btnHostsFile.Location = new Point(310, 36);
            btnHostsFile.Margin = new Padding(4, 3, 4, 3);
            btnHostsFile.Name = "btnHostsFile";
            btnHostsFile.Size = new Size(125, 35);
            btnHostsFile.TabIndex = 3;
            btnHostsFile.Text = "HostsFile";
            btnHostsFile.UseVisualStyleBackColor = false;
            btnHostsFile.Click += btnHostsFile_Click;
            // 
            // btnPowerShellPolicyManager
            // 
            btnPowerShellPolicyManager.Anchor = AnchorStyles.Top;
            btnPowerShellPolicyManager.BackColor = SystemColors.Control;
            btnPowerShellPolicyManager.Cursor = Cursors.Hand;
            btnPowerShellPolicyManager.FlatStyle = FlatStyle.System;
            btnPowerShellPolicyManager.Font = new Font("Consolas", 8.25F);
            btnPowerShellPolicyManager.ForeColor = Color.Black;
            btnPowerShellPolicyManager.Location = new Point(310, 77);
            btnPowerShellPolicyManager.Margin = new Padding(4, 3, 4, 3);
            btnPowerShellPolicyManager.Name = "btnPowerShellPolicyManager";
            btnPowerShellPolicyManager.Size = new Size(125, 35);
            btnPowerShellPolicyManager.TabIndex = 6;
            btnPowerShellPolicyManager.Text = "PowerShell Policy Manager";
            btnPowerShellPolicyManager.UseVisualStyleBackColor = false;
            btnPowerShellPolicyManager.Click += btnPowerShellPolicyManager_Click;
            // 
            // btnTools
            // 
            btnTools.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTools.BackColor = SystemColors.Control;
            btnTools.Cursor = Cursors.Hand;
            btnTools.FlatStyle = FlatStyle.System;
            btnTools.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTools.ForeColor = Color.Black;
            btnTools.Location = new Point(371, 424);
            btnTools.Margin = new Padding(4, 3, 4, 3);
            btnTools.Name = "btnTools";
            btnTools.Size = new Size(100, 25);
            btnTools.TabIndex = 17;
            btnTools.Text = "Win...";
            btnTools.UseVisualStyleBackColor = false;
            btnTools.Click += btnTools_Click;
            // 
            // btnFileDelete
            // 
            btnFileDelete.Anchor = AnchorStyles.Top;
            btnFileDelete.BackColor = SystemColors.Control;
            btnFileDelete.Cursor = Cursors.Hand;
            btnFileDelete.FlatStyle = FlatStyle.System;
            btnFileDelete.Font = new Font("Consolas", 8.25F);
            btnFileDelete.ForeColor = Color.Black;
            btnFileDelete.Location = new Point(177, 36);
            btnFileDelete.Margin = new Padding(4, 3, 4, 3);
            btnFileDelete.Name = "btnFileDelete";
            btnFileDelete.Size = new Size(126, 35);
            btnFileDelete.TabIndex = 2;
            btnFileDelete.Text = "File Delete";
            btnFileDelete.UseVisualStyleBackColor = false;
            btnFileDelete.Click += btnFileDelete_Click;
            // 
            // btnUninstaller
            // 
            btnUninstaller.Anchor = AnchorStyles.Top;
            btnUninstaller.BackColor = SystemColors.Control;
            btnUninstaller.Cursor = Cursors.Hand;
            btnUninstaller.FlatStyle = FlatStyle.System;
            btnUninstaller.Font = new Font("Consolas", 8.25F);
            btnUninstaller.ForeColor = Color.Black;
            btnUninstaller.Location = new Point(45, 159);
            btnUninstaller.Name = "btnUninstaller";
            btnUninstaller.Size = new Size(125, 35);
            btnUninstaller.TabIndex = 10;
            btnUninstaller.Text = "UnInstaller";
            btnUninstaller.UseVisualStyleBackColor = false;
            btnUninstaller.Click += btnUninstaller_Click;
            // 
            // UnlockSystem
            // 
            UnlockSystem.Anchor = AnchorStyles.Top;
            UnlockSystem.BackColor = SystemColors.Control;
            UnlockSystem.Cursor = Cursors.Hand;
            UnlockSystem.FlatStyle = FlatStyle.System;
            UnlockSystem.Font = new Font("Consolas", 8.25F);
            UnlockSystem.ForeColor = Color.Black;
            UnlockSystem.Location = new Point(178, 159);
            UnlockSystem.Margin = new Padding(4, 3, 4, 3);
            UnlockSystem.Name = "UnlockSystem";
            UnlockSystem.Size = new Size(126, 35);
            UnlockSystem.TabIndex = 11;
            UnlockSystem.Text = "System Unlocker";
            UnlockSystem.UseVisualStyleBackColor = false;
            UnlockSystem.Click += UnlockSystem_Click;
            // 
            // btnBlockWebSite
            // 
            btnBlockWebSite.Anchor = AnchorStyles.Top;
            btnBlockWebSite.BackColor = SystemColors.Control;
            btnBlockWebSite.Cursor = Cursors.Hand;
            btnBlockWebSite.FlatStyle = FlatStyle.System;
            btnBlockWebSite.Font = new Font("Consolas", 8.25F);
            btnBlockWebSite.ForeColor = Color.Black;
            btnBlockWebSite.Location = new Point(309, 159);
            btnBlockWebSite.Margin = new Padding(4, 3, 4, 3);
            btnBlockWebSite.Name = "btnBlockWebSite";
            btnBlockWebSite.Size = new Size(125, 35);
            btnBlockWebSite.TabIndex = 12;
            btnBlockWebSite.Text = "Block Any WebSite";
            btnBlockWebSite.UseVisualStyleBackColor = false;
            btnBlockWebSite.Click += btnBlockWebSite_Click;
            // 
            // btnUtilMan
            // 
            btnUtilMan.Anchor = AnchorStyles.Top;
            btnUtilMan.BackColor = SystemColors.Control;
            btnUtilMan.Cursor = Cursors.Hand;
            btnUtilMan.FlatStyle = FlatStyle.System;
            btnUtilMan.Font = new Font("Consolas", 8.25F);
            btnUtilMan.ForeColor = Color.Black;
            btnUtilMan.Location = new Point(45, 200);
            btnUtilMan.Margin = new Padding(4, 3, 4, 3);
            btnUtilMan.Name = "btnUtilMan";
            btnUtilMan.Size = new Size(125, 35);
            btnUtilMan.TabIndex = 13;
            btnUtilMan.Text = "Add To UtilMan";
            btnUtilMan.UseVisualStyleBackColor = false;
            btnUtilMan.Click += btnUtilMan_Click;
            // 
            // btnCmdLine
            // 
            btnCmdLine.Anchor = AnchorStyles.Top;
            btnCmdLine.BackColor = SystemColors.Control;
            btnCmdLine.Cursor = Cursors.Hand;
            btnCmdLine.FlatStyle = FlatStyle.System;
            btnCmdLine.Font = new Font("Consolas", 8.25F);
            btnCmdLine.ForeColor = Color.Black;
            btnCmdLine.Location = new Point(177, 200);
            btnCmdLine.Margin = new Padding(4, 3, 4, 3);
            btnCmdLine.Name = "btnCmdLine";
            btnCmdLine.Size = new Size(125, 35);
            btnCmdLine.TabIndex = 14;
            btnCmdLine.Text = "Add To CmdLine";
            btnCmdLine.UseVisualStyleBackColor = false;
            btnCmdLine.Click += btnCmdLine_Click;
            // 
            // btnMyProgramList
            // 
            btnMyProgramList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMyProgramList.BackColor = SystemColors.Control;
            btnMyProgramList.Cursor = Cursors.Hand;
            btnMyProgramList.FlatStyle = FlatStyle.System;
            btnMyProgramList.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyProgramList.ForeColor = Color.Black;
            btnMyProgramList.Location = new Point(371, 393);
            btnMyProgramList.Margin = new Padding(4, 3, 4, 3);
            btnMyProgramList.Name = "btnMyProgramList";
            btnMyProgramList.Size = new Size(100, 25);
            btnMyProgramList.TabIndex = 16;
            btnMyProgramList.Text = "My programs";
            btnMyProgramList.UseVisualStyleBackColor = false;
            btnMyProgramList.Click += btnMyProgramList_Click;
            // 
            // btnWinLogon
            // 
            btnWinLogon.Anchor = AnchorStyles.Top;
            btnWinLogon.BackColor = SystemColors.Control;
            btnWinLogon.Cursor = Cursors.Hand;
            btnWinLogon.FlatStyle = FlatStyle.System;
            btnWinLogon.Font = new Font("Consolas", 8.25F);
            btnWinLogon.ForeColor = Color.Black;
            btnWinLogon.Location = new Point(309, 200);
            btnWinLogon.Margin = new Padding(4, 3, 4, 3);
            btnWinLogon.Name = "btnWinLogon";
            btnWinLogon.Size = new Size(125, 35);
            btnWinLogon.TabIndex = 15;
            btnWinLogon.Text = "WinLogon";
            btnWinLogon.UseVisualStyleBackColor = false;
            btnWinLogon.Click += btnWinLogon_Click;
            // 
            // PCHubFormOld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(484, 461);
            Controls.Add(btnWinLogon);
            Controls.Add(btnMyProgramList);
            Controls.Add(btnCmdLine);
            Controls.Add(btnUtilMan);
            Controls.Add(btnBlockWebSite);
            Controls.Add(UnlockSystem);
            Controls.Add(btnUninstaller);
            Controls.Add(btnFileDelete);
            Controls.Add(btnTools);
            Controls.Add(btnPowerShellPolicyManager);
            Controls.Add(btnHostsFile);
            Controls.Add(btnPowerMgr);
            Controls.Add(BuildLabel);
            Controls.Add(btnAddLocalUser);
            Controls.Add(btnFileExplorer);
            Controls.Add(btnTaskkiller);
            Controls.Add(btnTxtWriter);
            Controls.Add(btnTaskMGR);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 900);
            MinimizeBox = false;
            Name = "PCHubFormOld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PcHub";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTaskMGR;
        private MenuStrip menuStrip1;
        private Button btnTxtWriter;
        private Button btnTaskkiller;
        private Button btnFileExplorer;
        private Button btnAddLocalUser;
        private Label BuildLabel;
        private Button btnPowerMgr;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnHostsFile;
        private Button btnPowerShellPolicyManager;
        private Button btnTools;
        private Button btnFileDelete;
        private Button btnUninstaller;
        private Button UnlockSystem;
        private Button btnBlockWebSite;
        private Button btnUtilMan;
        private Button btnCmdLine;
        private Button btnMyProgramList;
        private Button btnWinLogon;
    }
}
