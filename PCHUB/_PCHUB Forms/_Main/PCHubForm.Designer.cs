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
            customProgramsToolStripMenuItem = new ToolStripMenuItem();
            winToolsToolStripMenuItem = new ToolStripMenuItem();
            oldMenuToolStripMenuItem = new ToolStripMenuItem();
            PCHubItemsListBox = new ListBox();
            btnOpen = new Button();
            HelpLabel = new Label();
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
            menuStrip1.RenderMode = ToolStripRenderMode.System;
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
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customProgramsToolStripMenuItem, winToolsToolStripMenuItem, oldMenuToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            // 
            // customProgramsToolStripMenuItem
            // 
            customProgramsToolStripMenuItem.Name = "customProgramsToolStripMenuItem";
            customProgramsToolStripMenuItem.Size = new Size(170, 22);
            customProgramsToolStripMenuItem.Text = "Custom programs";
            customProgramsToolStripMenuItem.Click += customProgramsToolStripMenuItem_Click;
            // 
            // winToolsToolStripMenuItem
            // 
            winToolsToolStripMenuItem.Name = "winToolsToolStripMenuItem";
            winToolsToolStripMenuItem.Size = new Size(170, 22);
            winToolsToolStripMenuItem.Text = "WinTools";
            winToolsToolStripMenuItem.Click += winToolsToolStripMenuItem_Click;
            // 
            // oldMenuToolStripMenuItem
            // 
            oldMenuToolStripMenuItem.Name = "oldMenuToolStripMenuItem";
            oldMenuToolStripMenuItem.Size = new Size(170, 22);
            oldMenuToolStripMenuItem.Text = "Old Menu";
            oldMenuToolStripMenuItem.Click += oldMenuToolStripMenuItem_Click;
            // 
            // PCHubItemsListBox
            // 
            PCHubItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PCHubItemsListBox.BackColor = SystemColors.Control;
            PCHubItemsListBox.BorderStyle = BorderStyle.None;
            PCHubItemsListBox.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PCHubItemsListBox.FormattingEnabled = true;
            PCHubItemsListBox.ItemHeight = 18;
            PCHubItemsListBox.Items.AddRange(new object[] { "Add Local User", "File Delete", "Host File", "Power management", "Taskkiller", "PowerShell Policy Manager", "Writer", "Taskmgr Or Resmon", "Browse Or File Explorer", "Uninstaller", "System Unlocker", "Block any WebSite", "Add to UtilMan", "Add To CmdLine WinLogon" });
            PCHubItemsListBox.Location = new Point(12, 27);
            PCHubItemsListBox.Name = "PCHubItemsListBox";
            PCHubItemsListBox.Size = new Size(459, 360);
            PCHubItemsListBox.TabIndex = 76;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOpen.BackColor = SystemColors.Control;
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.FlatStyle = FlatStyle.System;
            btnOpen.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.Black;
            btnOpen.Location = new Point(13, 414);
            btnOpen.Margin = new Padding(4, 3, 4, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(460, 35);
            btnOpen.TabIndex = 77;
            btnOpen.Text = "Open (Enter)";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // HelpLabel
            // 
            HelpLabel.AutoSize = true;
            HelpLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpLabel.Location = new Point(380, 397);
            HelpLabel.Name = "HelpLabel";
            HelpLabel.Size = new Size(91, 14);
            HelpLabel.TabIndex = 78;
            HelpLabel.Text = "\".\" for help";
            // 
            // PCHubForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(484, 461);
            Controls.Add(HelpLabel);
            Controls.Add(btnOpen);
            Controls.Add(PCHubItemsListBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(305, 365);
            Name = "PCHubForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "w";
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
        private ToolStripMenuItem customProgramsToolStripMenuItem;
        private ToolStripMenuItem winToolsToolStripMenuItem;
        private ToolStripMenuItem oldMenuToolStripMenuItem;
        private Label HelpLabel;
    }
}