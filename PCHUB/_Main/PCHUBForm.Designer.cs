namespace PCHUB
{
    partial class PCHUBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCHUBForm));
            btnTaskMGR = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            btnTxtWriter = new Button();
            btnTaskkiller = new Button();
            btnFileExplorer = new Button();
            btnAddLocalUser = new Button();
            BuildLabel = new Label();
            btnPowerMgr = new Button();
            btnHostsFile = new Button();
            btnPowerShellPolicyManager = new Button();
            HybsLabel = new Label();
            btnTools = new Button();
            btnFileDelete = new Button();
            btnUninstaller = new Button();
            btnBrowseForms = new Button();
            UnlockSystem = new Button();
            btnBlockProcessForm = new Button();
            btnToTray = new Button();
            btnBlockWebSite = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTaskMGR
            // 
            btnTaskMGR.Anchor = AnchorStyles.Top;
            btnTaskMGR.Cursor = Cursors.Hand;
            btnTaskMGR.Font = new Font("Consolas", 8.25F);
            btnTaskMGR.Location = new Point(178, 118);
            btnTaskMGR.Name = "btnTaskMGR";
            btnTaskMGR.Size = new Size(125, 35);
            btnTaskMGR.TabIndex = 6;
            btnTaskMGR.Text = "Taskmgr\r\nOr Resmon";
            btnTaskMGR.UseVisualStyleBackColor = true;
            btnTaskMGR.Click += TaskManager_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem, runToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 8;
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
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(40, 20);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // btnTxtWriter
            // 
            btnTxtWriter.Anchor = AnchorStyles.Top;
            btnTxtWriter.Cursor = Cursors.Hand;
            btnTxtWriter.Font = new Font("Consolas", 8.25F);
            btnTxtWriter.Location = new Point(45, 118);
            btnTxtWriter.Name = "btnTxtWriter";
            btnTxtWriter.Size = new Size(125, 35);
            btnTxtWriter.TabIndex = 10;
            btnTxtWriter.Text = "Writer";
            btnTxtWriter.UseVisualStyleBackColor = true;
            btnTxtWriter.Click += TxtWriter_Click;
            // 
            // btnTaskkiller
            // 
            btnTaskkiller.Anchor = AnchorStyles.Top;
            btnTaskkiller.Cursor = Cursors.Hand;
            btnTaskkiller.Font = new Font("Consolas", 8.25F);
            btnTaskkiller.Location = new Point(178, 77);
            btnTaskkiller.Margin = new Padding(4, 3, 4, 3);
            btnTaskkiller.Name = "btnTaskkiller";
            btnTaskkiller.Size = new Size(125, 35);
            btnTaskkiller.TabIndex = 18;
            btnTaskkiller.Text = "TaskKiller";
            btnTaskkiller.UseVisualStyleBackColor = true;
            btnTaskkiller.Click += Taskkiller_Click;
            // 
            // btnFileExplorer
            // 
            btnFileExplorer.Anchor = AnchorStyles.Top;
            btnFileExplorer.Cursor = Cursors.Hand;
            btnFileExplorer.Font = new Font("Consolas", 8.25F);
            btnFileExplorer.Location = new Point(310, 118);
            btnFileExplorer.Name = "btnFileExplorer";
            btnFileExplorer.Size = new Size(125, 35);
            btnFileExplorer.TabIndex = 23;
            btnFileExplorer.Text = "Browse Explorer \r\nOr File Explorer";
            btnFileExplorer.UseVisualStyleBackColor = true;
            btnFileExplorer.Click += FileExplorer_Click;
            // 
            // btnAddLocalUser
            // 
            btnAddLocalUser.Anchor = AnchorStyles.Top;
            btnAddLocalUser.Cursor = Cursors.Hand;
            btnAddLocalUser.Font = new Font("Consolas", 8.25F);
            btnAddLocalUser.Location = new Point(45, 36);
            btnAddLocalUser.Name = "btnAddLocalUser";
            btnAddLocalUser.Size = new Size(125, 35);
            btnAddLocalUser.TabIndex = 32;
            btnAddLocalUser.Text = "Add Local User";
            btnAddLocalUser.UseVisualStyleBackColor = true;
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
            BuildLabel.TabIndex = 36;
            BuildLabel.Text = "null";
            BuildLabel.Click += btnbuildhelp_Click;
            // 
            // btnPowerMgr
            // 
            btnPowerMgr.Anchor = AnchorStyles.Top;
            btnPowerMgr.Cursor = Cursors.Hand;
            btnPowerMgr.Font = new Font("Consolas", 8.25F);
            btnPowerMgr.Location = new Point(45, 77);
            btnPowerMgr.Margin = new Padding(4, 3, 4, 3);
            btnPowerMgr.Name = "btnPowerMgr";
            btnPowerMgr.Size = new Size(125, 35);
            btnPowerMgr.TabIndex = 37;
            btnPowerMgr.Text = "Power \r\nmanagement";
            btnPowerMgr.UseVisualStyleBackColor = true;
            btnPowerMgr.Click += btnPowerMgr_Click;
            // 
            // btnHostsFile
            // 
            btnHostsFile.Anchor = AnchorStyles.Top;
            btnHostsFile.Cursor = Cursors.Hand;
            btnHostsFile.Font = new Font("Consolas", 8.25F);
            btnHostsFile.Location = new Point(310, 36);
            btnHostsFile.Margin = new Padding(4, 3, 4, 3);
            btnHostsFile.Name = "btnHostsFile";
            btnHostsFile.Size = new Size(125, 35);
            btnHostsFile.TabIndex = 39;
            btnHostsFile.Text = "HostsFile";
            btnHostsFile.UseVisualStyleBackColor = true;
            btnHostsFile.Click += btnHostsFile_Click;
            // 
            // btnPowerShellPolicyManager
            // 
            btnPowerShellPolicyManager.Anchor = AnchorStyles.Top;
            btnPowerShellPolicyManager.Cursor = Cursors.Hand;
            btnPowerShellPolicyManager.Font = new Font("Consolas", 8.25F);
            btnPowerShellPolicyManager.Location = new Point(310, 77);
            btnPowerShellPolicyManager.Margin = new Padding(4, 3, 4, 3);
            btnPowerShellPolicyManager.Name = "btnPowerShellPolicyManager";
            btnPowerShellPolicyManager.Size = new Size(125, 35);
            btnPowerShellPolicyManager.TabIndex = 40;
            btnPowerShellPolicyManager.Text = "PowerShell Policy Manager";
            btnPowerShellPolicyManager.UseVisualStyleBackColor = true;
            btnPowerShellPolicyManager.Click += btnPowerShellPolicyManager_Click;
            // 
            // HybsLabel
            // 
            HybsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            HybsLabel.AutoSize = true;
            HybsLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HybsLabel.Location = new Point(12, 359);
            HybsLabel.Name = "HybsLabel";
            HybsLabel.Size = new Size(60, 22);
            HybsLabel.TabIndex = 43;
            HybsLabel.Text = "Hubs:";
            // 
            // btnTools
            // 
            btnTools.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTools.Cursor = Cursors.Hand;
            btnTools.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTools.Location = new Point(12, 384);
            btnTools.Margin = new Padding(4, 3, 4, 3);
            btnTools.Name = "btnTools";
            btnTools.Size = new Size(124, 35);
            btnTools.TabIndex = 44;
            btnTools.Text = "3rd Party Apps";
            btnTools.UseVisualStyleBackColor = true;
            btnTools.Click += btnTools_Click;
            // 
            // btnFileDelete
            // 
            btnFileDelete.Anchor = AnchorStyles.Top;
            btnFileDelete.Cursor = Cursors.Hand;
            btnFileDelete.Font = new Font("Consolas", 8.25F);
            btnFileDelete.Location = new Point(177, 36);
            btnFileDelete.Margin = new Padding(4, 3, 4, 3);
            btnFileDelete.Name = "btnFileDelete";
            btnFileDelete.Size = new Size(126, 35);
            btnFileDelete.TabIndex = 46;
            btnFileDelete.Text = "File Delete";
            btnFileDelete.UseVisualStyleBackColor = true;
            btnFileDelete.Click += btnFileDelete_Click;
            // 
            // btnUninstaller
            // 
            btnUninstaller.Anchor = AnchorStyles.Top;
            btnUninstaller.Cursor = Cursors.Hand;
            btnUninstaller.Font = new Font("Consolas", 8.25F);
            btnUninstaller.Location = new Point(45, 159);
            btnUninstaller.Name = "btnUninstaller";
            btnUninstaller.Size = new Size(125, 35);
            btnUninstaller.TabIndex = 47;
            btnUninstaller.Text = "UnInstaller";
            btnUninstaller.UseVisualStyleBackColor = true;
            btnUninstaller.Click += btnUninstaller_Click;
            // 
            // btnBrowseForms
            // 
            btnBrowseForms.Anchor = AnchorStyles.Top;
            btnBrowseForms.Cursor = Cursors.Hand;
            btnBrowseForms.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowseForms.Location = new Point(45, 200);
            btnBrowseForms.Margin = new Padding(4, 3, 4, 3);
            btnBrowseForms.Name = "btnBrowseForms";
            btnBrowseForms.Size = new Size(126, 35);
            btnBrowseForms.TabIndex = 48;
            btnBrowseForms.Text = "Your browser \r\nOr Youtube";
            btnBrowseForms.UseVisualStyleBackColor = true;
            btnBrowseForms.Click += btnBrowseForms_Click;
            // 
            // UnlockSystem
            // 
            UnlockSystem.Anchor = AnchorStyles.Top;
            UnlockSystem.Cursor = Cursors.Hand;
            UnlockSystem.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnlockSystem.Location = new Point(178, 159);
            UnlockSystem.Margin = new Padding(4, 3, 4, 3);
            UnlockSystem.Name = "UnlockSystem";
            UnlockSystem.Size = new Size(126, 35);
            UnlockSystem.TabIndex = 49;
            UnlockSystem.Text = "System Unlocker";
            UnlockSystem.UseVisualStyleBackColor = true;
            UnlockSystem.Click += UnlockSystem_Click;
            // 
            // btnBlockProcessForm
            // 
            btnBlockProcessForm.Anchor = AnchorStyles.Top;
            btnBlockProcessForm.Cursor = Cursors.Hand;
            btnBlockProcessForm.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBlockProcessForm.Location = new Point(309, 159);
            btnBlockProcessForm.Margin = new Padding(4, 3, 4, 3);
            btnBlockProcessForm.Name = "btnBlockProcessForm";
            btnBlockProcessForm.Size = new Size(126, 35);
            btnBlockProcessForm.TabIndex = 50;
            btnBlockProcessForm.Text = "Block Process";
            btnBlockProcessForm.UseVisualStyleBackColor = true;
            btnBlockProcessForm.Click += btnBlockProcessForm_Click;
            // 
            // btnToTray
            // 
            btnToTray.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnToTray.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToTray.Location = new Point(387, 424);
            btnToTray.Name = "btnToTray";
            btnToTray.Size = new Size(85, 25);
            btnToTray.TabIndex = 51;
            btnToTray.Text = "To Tray ⏬";
            btnToTray.UseVisualStyleBackColor = true;
            btnToTray.Click += btnToTray_Click;
            // 
            // btnBlockWebSite
            // 
            btnBlockWebSite.Anchor = AnchorStyles.Top;
            btnBlockWebSite.Cursor = Cursors.Hand;
            btnBlockWebSite.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBlockWebSite.Location = new Point(177, 200);
            btnBlockWebSite.Margin = new Padding(4, 3, 4, 3);
            btnBlockWebSite.Name = "btnBlockWebSite";
            btnBlockWebSite.Size = new Size(126, 35);
            btnBlockWebSite.TabIndex = 52;
            btnBlockWebSite.Text = "Block WebSite";
            btnBlockWebSite.UseVisualStyleBackColor = true;
            btnBlockWebSite.Click += btnBlockWebSite_Click;
            // 
            // PCHUBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(btnBlockWebSite);
            Controls.Add(btnToTray);
            Controls.Add(btnBlockProcessForm);
            Controls.Add(UnlockSystem);
            Controls.Add(btnBrowseForms);
            Controls.Add(btnUninstaller);
            Controls.Add(btnFileDelete);
            Controls.Add(btnTools);
            Controls.Add(HybsLabel);
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
            MinimumSize = new Size(500, 500);
            Name = "PCHUBForm";
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
        private Label HybsLabel;
        private Button btnTools;
        private Button btnFileDelete;
        private Button btnUninstaller;
        private ToolStripMenuItem runToolStripMenuItem;
        private Button btnBrowseForms;
        private Button UnlockSystem;
        private Button btnBlockProcessForm;
        private Button btnToTray;
        private Button btnBlockWebSite;
    }
}
