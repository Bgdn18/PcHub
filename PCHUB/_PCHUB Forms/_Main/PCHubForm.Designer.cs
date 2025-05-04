namespace PCHUB._PCHUB_Forms._Main
{
    partial class PCHubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCHubForm));
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            oldMenuToolStripMenuItem = new ToolStripMenuItem();
            PCHubItemsListBox = new ListBox();
            btnOpen = new Button();
            btnWinTool = new Button();
            btnMyProgramsList = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Font = new Font("Consolas", 9F);
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(54, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, aboutToolStripMenuItem, openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 58;
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
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oldMenuToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            // 
            // oldMenuToolStripMenuItem
            // 
            oldMenuToolStripMenuItem.Name = "oldMenuToolStripMenuItem";
            oldMenuToolStripMenuItem.Size = new Size(127, 22);
            oldMenuToolStripMenuItem.Text = "Old Menu";
            oldMenuToolStripMenuItem.Click += oldMenuToolStripMenuItem_Click;
            // 
            // PCHubItemsListBox
            // 
            PCHubItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PCHubItemsListBox.BackColor = SystemColors.Window;
            PCHubItemsListBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PCHubItemsListBox.FormattingEnabled = true;
            PCHubItemsListBox.ItemHeight = 18;
            PCHubItemsListBox.Items.AddRange(new object[] { "Add Local User", "File Delete", "Host File", "Power management", "Taskkiller", "PowerShell Policy Manager", "Writer", "Browse Or File Explorer", "Uninstaller", "System Unlocker", "Block any WebSite", "Add to UtilMan", "Add To CmdLine", "WinLogon" });
            PCHubItemsListBox.Location = new Point(12, 27);
            PCHubItemsListBox.Name = "PCHubItemsListBox";
            PCHubItemsListBox.Size = new Size(459, 400);
            PCHubItemsListBox.TabIndex = 76;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOpen.BackColor = SystemColors.Control;
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.FlatStyle = FlatStyle.System;
            btnOpen.Font = new Font("Consolas", 9F);
            btnOpen.ForeColor = Color.Black;
            btnOpen.Location = new Point(12, 429);
            btnOpen.Margin = new Padding(4, 3, 4, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 77;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnWinTool
            // 
            btnWinTool.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnWinTool.BackColor = SystemColors.Control;
            btnWinTool.Cursor = Cursors.Hand;
            btnWinTool.FlatStyle = FlatStyle.System;
            btnWinTool.Font = new Font("Consolas", 9F);
            btnWinTool.ForeColor = Color.Black;
            btnWinTool.Location = new Point(293, 429);
            btnWinTool.Margin = new Padding(4, 3, 4, 3);
            btnWinTool.Name = "btnWinTool";
            btnWinTool.Size = new Size(85, 23);
            btnWinTool.TabIndex = 78;
            btnWinTool.Text = "Win...";
            btnWinTool.UseVisualStyleBackColor = false;
            btnWinTool.Click += btnWinTool_Click;
            // 
            // btnMyProgramsList
            // 
            btnMyProgramsList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMyProgramsList.BackColor = SystemColors.Control;
            btnMyProgramsList.Cursor = Cursors.Hand;
            btnMyProgramsList.FlatStyle = FlatStyle.System;
            btnMyProgramsList.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyProgramsList.ForeColor = Color.Black;
            btnMyProgramsList.Location = new Point(386, 429);
            btnMyProgramsList.Margin = new Padding(4, 3, 4, 3);
            btnMyProgramsList.Name = "btnMyProgramsList";
            btnMyProgramsList.Size = new Size(85, 23);
            btnMyProgramsList.TabIndex = 79;
            btnMyProgramsList.Text = "My programs";
            btnMyProgramsList.UseVisualStyleBackColor = false;
            btnMyProgramsList.Click += btnMyProgramsList_Click;
            // 
            // PCHubForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(484, 461);
            Controls.Add(btnMyProgramsList);
            Controls.Add(btnWinTool);
            Controls.Add(btnOpen);
            Controls.Add(PCHubItemsListBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(305, 365);
            Name = "PCHubForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PCHub";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ListBox PCHubItemsListBox;
        private Button btnOpen;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem oldMenuToolStripMenuItem;
        private Button btnWinTool;
        private Button btnMyProgramsList;
    }
}