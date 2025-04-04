namespace PCHUB
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            btnZAPRET = new Button();
            btnCMD = new Button();
            btnCONTROLPANEL = new Button();
            btnREGEDIT = new Button();
            btnTaskMGR = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            aDDTOSTARTUPToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnTxtWriter = new Button();
            btnTaskkiller = new Button();
            btnFileExplorer = new Button();
            btnProccesHacker = new Button();
            btnAddLocalUser = new Button();
            btnExplorerPP = new Button();
            btnWindowsSettings = new Button();
            BuildLabel = new Label();
            btnPowerMgr = new Button();
            btnTaskMgrControl = new Button();
            btnHostsFile = new Button();
            btnPowerShellPolicyManager = new Button();
            label1 = new Label();
            btnIObitUnlocker = new Button();
            label2 = new Label();
            btnTools = new Button();
            btnMain = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnZAPRET
            // 
            btnZAPRET.Cursor = Cursors.Hand;
            btnZAPRET.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZAPRET.Location = new Point(143, 172);
            btnZAPRET.Name = "btnZAPRET";
            btnZAPRET.Size = new Size(124, 35);
            btnZAPRET.TabIndex = 0;
            btnZAPRET.Text = "ZAPRET 🐱‍👤";
            btnZAPRET.UseVisualStyleBackColor = true;
            btnZAPRET.Click += ZAPRET_Click;
            // 
            // btnCMD
            // 
            btnCMD.Cursor = Cursors.Hand;
            btnCMD.Font = new Font("Consolas", 8.25F);
            btnCMD.Location = new Point(537, 90);
            btnCMD.Name = "btnCMD";
            btnCMD.Size = new Size(125, 35);
            btnCMD.TabIndex = 2;
            btnCMD.Text = "CMD ";
            btnCMD.UseVisualStyleBackColor = true;
            btnCMD.Click += CMD_Click;
            // 
            // btnCONTROLPANEL
            // 
            btnCONTROLPANEL.Cursor = Cursors.Hand;
            btnCONTROLPANEL.Font = new Font("Consolas", 8.25F);
            btnCONTROLPANEL.Location = new Point(405, 90);
            btnCONTROLPANEL.Name = "btnCONTROLPANEL";
            btnCONTROLPANEL.Size = new Size(125, 35);
            btnCONTROLPANEL.TabIndex = 4;
            btnCONTROLPANEL.Text = "Control Panel 🛂";
            btnCONTROLPANEL.UseVisualStyleBackColor = true;
            btnCONTROLPANEL.Click += CONTROLPANEL_Click;
            // 
            // btnREGEDIT
            // 
            btnREGEDIT.Cursor = Cursors.Hand;
            btnREGEDIT.Font = new Font("Consolas", 8.25F);
            btnREGEDIT.Location = new Point(274, 90);
            btnREGEDIT.Name = "btnREGEDIT";
            btnREGEDIT.Size = new Size(125, 35);
            btnREGEDIT.TabIndex = 5;
            btnREGEDIT.Text = "REGEDIT ®";
            btnREGEDIT.UseVisualStyleBackColor = true;
            btnREGEDIT.Click += REGEDIT_Click;
            // 
            // btnTaskMGR
            // 
            btnTaskMGR.Cursor = Cursors.Hand;
            btnTaskMGR.Font = new Font("Consolas", 8.25F);
            btnTaskMGR.Location = new Point(143, 90);
            btnTaskMGR.Name = "btnTaskMGR";
            btnTaskMGR.Size = new Size(125, 35);
            btnTaskMGR.TabIndex = 6;
            btnTaskMGR.Text = "Task Manager 💻";
            btnTaskMGR.UseVisualStyleBackColor = true;
            btnTaskMGR.Click += TaskManager_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem, aDDTOSTARTUPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(673, 24);
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
            // aDDTOSTARTUPToolStripMenuItem
            // 
            aDDTOSTARTUPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem });
            aDDTOSTARTUPToolStripMenuItem.Font = new Font("Consolas", 9F);
            aDDTOSTARTUPToolStripMenuItem.Name = "aDDTOSTARTUPToolStripMenuItem";
            aDDTOSTARTUPToolStripMenuItem.Size = new Size(117, 20);
            aDDTOSTARTUPToolStripMenuItem.Text = "Add to startup";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(116, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(116, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnTxtWriter
            // 
            btnTxtWriter.Cursor = Cursors.Hand;
            btnTxtWriter.Font = new Font("Consolas", 8.25F);
            btnTxtWriter.Location = new Point(12, 90);
            btnTxtWriter.Name = "btnTxtWriter";
            btnTxtWriter.Size = new Size(125, 35);
            btnTxtWriter.TabIndex = 10;
            btnTxtWriter.Text = "Writer ✒";
            btnTxtWriter.UseVisualStyleBackColor = true;
            btnTxtWriter.Click += TxtWriter_Click;
            // 
            // btnTaskkiller
            // 
            btnTaskkiller.Cursor = Cursors.Hand;
            btnTaskkiller.Font = new Font("Consolas", 8.25F);
            btnTaskkiller.Location = new Point(405, 49);
            btnTaskkiller.Margin = new Padding(4, 3, 4, 3);
            btnTaskkiller.Name = "btnTaskkiller";
            btnTaskkiller.Size = new Size(125, 35);
            btnTaskkiller.TabIndex = 18;
            btnTaskkiller.Text = "TaskKill 🔪";
            btnTaskkiller.UseVisualStyleBackColor = true;
            btnTaskkiller.Click += Taskkiller_Click;
            // 
            // btnFileExplorer
            // 
            btnFileExplorer.Font = new Font("Consolas", 8.25F);
            btnFileExplorer.Location = new Point(537, 49);
            btnFileExplorer.Name = "btnFileExplorer";
            btnFileExplorer.Size = new Size(125, 35);
            btnFileExplorer.TabIndex = 23;
            btnFileExplorer.Text = "File Explorer";
            btnFileExplorer.UseVisualStyleBackColor = true;
            btnFileExplorer.Click += FileExplorer_Click;
            // 
            // btnProccesHacker
            // 
            btnProccesHacker.Cursor = Cursors.Hand;
            btnProccesHacker.Font = new Font("Consolas", 8.25F);
            btnProccesHacker.Location = new Point(274, 49);
            btnProccesHacker.Name = "btnProccesHacker";
            btnProccesHacker.Size = new Size(125, 35);
            btnProccesHacker.TabIndex = 30;
            btnProccesHacker.Text = "Procces Hacker 💀";
            btnProccesHacker.UseVisualStyleBackColor = true;
            btnProccesHacker.Click += btnProccesHacker_Click;
            // 
            // btnAddLocalUser
            // 
            btnAddLocalUser.Cursor = Cursors.Hand;
            btnAddLocalUser.Font = new Font("Consolas", 8.25F);
            btnAddLocalUser.Location = new Point(12, 49);
            btnAddLocalUser.Name = "btnAddLocalUser";
            btnAddLocalUser.Size = new Size(125, 35);
            btnAddLocalUser.TabIndex = 32;
            btnAddLocalUser.Text = "Add Local User 👥";
            btnAddLocalUser.UseVisualStyleBackColor = true;
            btnAddLocalUser.Click += btnLocalUser_Click;
            // 
            // btnExplorerPP
            // 
            btnExplorerPP.Cursor = Cursors.Hand;
            btnExplorerPP.Font = new Font("Consolas", 8.25F);
            btnExplorerPP.Location = new Point(143, 49);
            btnExplorerPP.Name = "btnExplorerPP";
            btnExplorerPP.Size = new Size(125, 35);
            btnExplorerPP.TabIndex = 34;
            btnExplorerPP.Text = "Explorer++";
            btnExplorerPP.UseVisualStyleBackColor = true;
            btnExplorerPP.Click += btnExplorerPP_Click;
            // 
            // btnWindowsSettings
            // 
            btnWindowsSettings.Cursor = Cursors.Hand;
            btnWindowsSettings.Font = new Font("Consolas", 8.25F);
            btnWindowsSettings.Location = new Point(12, 131);
            btnWindowsSettings.Margin = new Padding(4, 3, 4, 3);
            btnWindowsSettings.Name = "btnWindowsSettings";
            btnWindowsSettings.Size = new Size(125, 35);
            btnWindowsSettings.TabIndex = 35;
            btnWindowsSettings.Text = "Windows Settings ⚙";
            btnWindowsSettings.UseVisualStyleBackColor = true;
            btnWindowsSettings.Click += btnWindowsSettings_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(0, 417);
            BuildLabel.Margin = new Padding(4, 0, 4, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 36;
            BuildLabel.Text = "null";
            BuildLabel.Click += btnbuildhelp_Click;
            // 
            // btnPowerMgr
            // 
            btnPowerMgr.Cursor = Cursors.Hand;
            btnPowerMgr.Font = new Font("Consolas", 8.25F);
            btnPowerMgr.Location = new Point(143, 131);
            btnPowerMgr.Margin = new Padding(4, 3, 4, 3);
            btnPowerMgr.Name = "btnPowerMgr";
            btnPowerMgr.Size = new Size(125, 35);
            btnPowerMgr.TabIndex = 37;
            btnPowerMgr.Text = "Power \r\nmanagement ⚡";
            btnPowerMgr.UseVisualStyleBackColor = true;
            btnPowerMgr.Click += btnPowerMgr_Click;
            // 
            // btnTaskMgrControl
            // 
            btnTaskMgrControl.Cursor = Cursors.Hand;
            btnTaskMgrControl.Font = new Font("Consolas", 8.25F);
            btnTaskMgrControl.Location = new Point(274, 131);
            btnTaskMgrControl.Margin = new Padding(4, 3, 4, 3);
            btnTaskMgrControl.Name = "btnTaskMgrControl";
            btnTaskMgrControl.Size = new Size(125, 35);
            btnTaskMgrControl.TabIndex = 38;
            btnTaskMgrControl.Text = "TaskMgr Unlocker";
            btnTaskMgrControl.UseVisualStyleBackColor = true;
            btnTaskMgrControl.Click += btnTaskMgrUnlocker_Click;
            // 
            // btnHostsFile
            // 
            btnHostsFile.Cursor = Cursors.Hand;
            btnHostsFile.Font = new Font("Consolas", 8.25F);
            btnHostsFile.Location = new Point(405, 131);
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
            btnPowerShellPolicyManager.Cursor = Cursors.Hand;
            btnPowerShellPolicyManager.Font = new Font("Consolas", 8.25F);
            btnPowerShellPolicyManager.Location = new Point(537, 131);
            btnPowerShellPolicyManager.Margin = new Padding(4, 3, 4, 3);
            btnPowerShellPolicyManager.Name = "btnPowerShellPolicyManager";
            btnPowerShellPolicyManager.Size = new Size(125, 35);
            btnPowerShellPolicyManager.TabIndex = 40;
            btnPowerShellPolicyManager.Text = "PowerShell Policy Manager";
            btnPowerShellPolicyManager.UseVisualStyleBackColor = true;
            btnPowerShellPolicyManager.Click += btnPowerShellPolicyManager_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 41;
            label1.Text = "Library:";
            // 
            // btnIObitUnlocker
            // 
            btnIObitUnlocker.Cursor = Cursors.Hand;
            btnIObitUnlocker.Font = new Font("Consolas", 8.25F);
            btnIObitUnlocker.Location = new Point(12, 172);
            btnIObitUnlocker.Margin = new Padding(4, 3, 4, 3);
            btnIObitUnlocker.Name = "btnIObitUnlocker";
            btnIObitUnlocker.Size = new Size(125, 35);
            btnIObitUnlocker.TabIndex = 42;
            btnIObitUnlocker.Text = "IObit Unlocker 🗝";
            btnIObitUnlocker.UseVisualStyleBackColor = true;
            btnIObitUnlocker.Click += btnIObitUnlocker_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 342);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 43;
            label2.Text = "Hubs:";
            // 
            // btnTools
            // 
            btnTools.Cursor = Cursors.Hand;
            btnTools.Font = new Font("Consolas", 9F);
            btnTools.Location = new Point(13, 367);
            btnTools.Margin = new Padding(4, 3, 4, 3);
            btnTools.Name = "btnTools";
            btnTools.Size = new Size(124, 35);
            btnTools.TabIndex = 44;
            btnTools.Text = "Tools...";
            btnTools.UseVisualStyleBackColor = true;
            btnTools.Click += btnTools_Click;
            // 
            // btnMain
            // 
            btnMain.Cursor = Cursors.Hand;
            btnMain.Font = new Font("Consolas", 9F);
            btnMain.Location = new Point(143, 367);
            btnMain.Margin = new Padding(4, 3, 4, 3);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(124, 35);
            btnMain.TabIndex = 45;
            btnMain.Text = "Main...";
            btnMain.UseVisualStyleBackColor = true;
            btnMain.Click += btnMain_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 448);
            Controls.Add(btnMain);
            Controls.Add(btnTools);
            Controls.Add(label2);
            Controls.Add(btnIObitUnlocker);
            Controls.Add(label1);
            Controls.Add(btnPowerShellPolicyManager);
            Controls.Add(btnHostsFile);
            Controls.Add(btnTaskMgrControl);
            Controls.Add(btnPowerMgr);
            Controls.Add(BuildLabel);
            Controls.Add(btnWindowsSettings);
            Controls.Add(btnExplorerPP);
            Controls.Add(btnAddLocalUser);
            Controls.Add(btnProccesHacker);
            Controls.Add(btnFileExplorer);
            Controls.Add(btnTaskkiller);
            Controls.Add(btnTxtWriter);
            Controls.Add(btnTaskMGR);
            Controls.Add(btnREGEDIT);
            Controls.Add(btnCONTROLPANEL);
            Controls.Add(btnCMD);
            Controls.Add(btnZAPRET);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Library";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZAPRET;
        private Button btnCMD;
        private Button btnCONTROLPANEL;
        private Button btnREGEDIT;
        private Button btnTaskMGR;
        private MenuStrip menuStrip1;
        private Button btnTxtWriter;
        private Button btnTaskkiller;
        private Button btnFileExplorer;
        private Button btnProccesHacker;
        private Button btnAddLocalUser;
        private Button btnExplorerPP;
        private Button btnWindowsSettings;
        private Label BuildLabel;
        private Button btnPowerMgr;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnTaskMgrControl;
        private Button btnHostsFile;
        private Button btnPowerShellPolicyManager;
        private Label label1;
        private Button btnIObitUnlocker;
        private ToolStripMenuItem aDDTOSTARTUPToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label2;
        private Button btnTools;
        private Button btnMain;
    }
}
