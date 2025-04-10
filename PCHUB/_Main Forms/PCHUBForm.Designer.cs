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
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTaskMGR
            // 
            btnTaskMGR.Cursor = Cursors.Hand;
            btnTaskMGR.Font = new Font("Consolas", 8.25F);
            btnTaskMGR.Location = new Point(145, 118);
            btnTaskMGR.Name = "btnTaskMGR";
            btnTaskMGR.Size = new Size(125, 35);
            btnTaskMGR.TabIndex = 6;
            btnTaskMGR.Text = "Task Manager";
            btnTaskMGR.UseVisualStyleBackColor = true;
            btnTaskMGR.Click += TaskManager_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem, runToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(419, 24);
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
            btnTxtWriter.Cursor = Cursors.Hand;
            btnTxtWriter.Font = new Font("Consolas", 8.25F);
            btnTxtWriter.Location = new Point(12, 118);
            btnTxtWriter.Name = "btnTxtWriter";
            btnTxtWriter.Size = new Size(125, 35);
            btnTxtWriter.TabIndex = 10;
            btnTxtWriter.Text = "Writer";
            btnTxtWriter.UseVisualStyleBackColor = true;
            btnTxtWriter.Click += TxtWriter_Click;
            // 
            // btnTaskkiller
            // 
            btnTaskkiller.Cursor = Cursors.Hand;
            btnTaskkiller.Font = new Font("Consolas", 8.25F);
            btnTaskkiller.Location = new Point(145, 77);
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
            btnFileExplorer.Cursor = Cursors.Hand;
            btnFileExplorer.Font = new Font("Consolas", 8.25F);
            btnFileExplorer.Location = new Point(277, 118);
            btnFileExplorer.Name = "btnFileExplorer";
            btnFileExplorer.Size = new Size(125, 35);
            btnFileExplorer.TabIndex = 23;
            btnFileExplorer.Text = "File Explorer";
            btnFileExplorer.UseVisualStyleBackColor = true;
            btnFileExplorer.Click += FileExplorer_Click;
            // 
            // btnAddLocalUser
            // 
            btnAddLocalUser.Cursor = Cursors.Hand;
            btnAddLocalUser.Font = new Font("Consolas", 8.25F);
            btnAddLocalUser.Location = new Point(12, 36);
            btnAddLocalUser.Name = "btnAddLocalUser";
            btnAddLocalUser.Size = new Size(125, 35);
            btnAddLocalUser.TabIndex = 32;
            btnAddLocalUser.Text = "Add Local User";
            btnAddLocalUser.UseVisualStyleBackColor = true;
            btnAddLocalUser.Click += btnLocalUser_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(0, 276);
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
            btnPowerMgr.Location = new Point(12, 77);
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
            btnHostsFile.Cursor = Cursors.Hand;
            btnHostsFile.Font = new Font("Consolas", 8.25F);
            btnHostsFile.Location = new Point(277, 36);
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
            btnPowerShellPolicyManager.Location = new Point(277, 77);
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
            HybsLabel.AutoSize = true;
            HybsLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HybsLabel.Location = new Point(12, 206);
            HybsLabel.Name = "HybsLabel";
            HybsLabel.Size = new Size(60, 22);
            HybsLabel.TabIndex = 43;
            HybsLabel.Text = "Hubs:";
            // 
            // btnTools
            // 
            btnTools.Cursor = Cursors.Hand;
            btnTools.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTools.Location = new Point(12, 231);
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
            btnFileDelete.Cursor = Cursors.Hand;
            btnFileDelete.Font = new Font("Consolas", 8.25F);
            btnFileDelete.Location = new Point(144, 36);
            btnFileDelete.Margin = new Padding(4, 3, 4, 3);
            btnFileDelete.Name = "btnFileDelete";
            btnFileDelete.Size = new Size(125, 35);
            btnFileDelete.TabIndex = 46;
            btnFileDelete.Text = "File Delete";
            btnFileDelete.UseVisualStyleBackColor = true;
            btnFileDelete.Click += btnFileDelete_Click;
            // 
            // btnUninstaller
            // 
            btnUninstaller.Cursor = Cursors.Hand;
            btnUninstaller.Font = new Font("Consolas", 8.25F);
            btnUninstaller.Location = new Point(12, 159);
            btnUninstaller.Name = "btnUninstaller";
            btnUninstaller.Size = new Size(125, 35);
            btnUninstaller.TabIndex = 47;
            btnUninstaller.Text = "UnInstaller";
            btnUninstaller.UseVisualStyleBackColor = true;
            btnUninstaller.Click += btnUninstaller_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Consolas", 8.25F);
            button1.Location = new Point(145, 159);
            button1.Name = "button1";
            button1.Size = new Size(125, 35);
            button1.TabIndex = 48;
            button1.Text = "Procces Run";
            button1.UseVisualStyleBackColor = true;
            // 
            // PCHUBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(419, 305);
            Controls.Add(button1);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Button button1;
    }
}
