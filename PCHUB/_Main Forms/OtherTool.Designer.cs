﻿namespace PCHUB
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
            btnCONTROLPANEL = new Button();
            btnCMD = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            btnExplorerPP = new Button();
            btnProccesHacker = new Button();
            btnIoBitUnlocker = new Button();
            BuildLabel = new Label();
            btnZapret = new Button();
            btnRegedit = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCONTROLPANEL
            // 
            btnCONTROLPANEL.Cursor = Cursors.Hand;
            btnCONTROLPANEL.Font = new Font("Consolas", 9F);
            btnCONTROLPANEL.Location = new Point(282, 44);
            btnCONTROLPANEL.Name = "btnCONTROLPANEL";
            btnCONTROLPANEL.Size = new Size(128, 50);
            btnCONTROLPANEL.TabIndex = 16;
            btnCONTROLPANEL.Text = "Control Panel";
            btnCONTROLPANEL.UseVisualStyleBackColor = true;
            btnCONTROLPANEL.Click += CONTROLPANEL_Click;
            // 
            // btnCMD
            // 
            btnCMD.Cursor = Cursors.Hand;
            btnCMD.Font = new Font("Consolas", 9F);
            btnCMD.Location = new Point(12, 44);
            btnCMD.Name = "btnCMD";
            btnCMD.Size = new Size(128, 50);
            btnCMD.TabIndex = 14;
            btnCMD.Text = "CMD";
            btnCMD.UseVisualStyleBackColor = true;
            btnCMD.Click += CMD_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Font = new Font("Consolas", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(423, 24);
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
            // btnExplorerPP
            // 
            btnExplorerPP.Cursor = Cursors.Hand;
            btnExplorerPP.Font = new Font("Consolas", 9F);
            btnExplorerPP.Location = new Point(148, 44);
            btnExplorerPP.Name = "btnExplorerPP";
            btnExplorerPP.Size = new Size(128, 50);
            btnExplorerPP.TabIndex = 23;
            btnExplorerPP.Text = "Explorer++";
            btnExplorerPP.UseVisualStyleBackColor = true;
            btnExplorerPP.Click += ExplorerPP_Click;
            // 
            // btnProccesHacker
            // 
            btnProccesHacker.Cursor = Cursors.Hand;
            btnProccesHacker.Font = new Font("Consolas", 9F);
            btnProccesHacker.Location = new Point(12, 100);
            btnProccesHacker.Name = "btnProccesHacker";
            btnProccesHacker.Size = new Size(128, 50);
            btnProccesHacker.TabIndex = 24;
            btnProccesHacker.Text = "Procces Hacker";
            btnProccesHacker.UseVisualStyleBackColor = true;
            btnProccesHacker.Click += processhacker_Click;
            // 
            // btnIoBitUnlocker
            // 
            btnIoBitUnlocker.Cursor = Cursors.Hand;
            btnIoBitUnlocker.Font = new Font("Consolas", 9F);
            btnIoBitUnlocker.Location = new Point(148, 100);
            btnIoBitUnlocker.Name = "btnIoBitUnlocker";
            btnIoBitUnlocker.Size = new Size(128, 50);
            btnIoBitUnlocker.TabIndex = 25;
            btnIoBitUnlocker.Text = "IObit Unlocker";
            btnIoBitUnlocker.UseVisualStyleBackColor = true;
            btnIoBitUnlocker.Click += IObitUnlocker_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(0, 226);
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
            btnZapret.Location = new Point(282, 100);
            btnZapret.Name = "btnZapret";
            btnZapret.Size = new Size(128, 50);
            btnZapret.TabIndex = 29;
            btnZapret.Text = "Zapret";
            btnZapret.UseVisualStyleBackColor = true;
            btnZapret.Click += btnZapret_Click;
            // 
            // btnRegedit
            // 
            btnRegedit.Cursor = Cursors.Hand;
            btnRegedit.Font = new Font("Consolas", 9F);
            btnRegedit.Location = new Point(12, 156);
            btnRegedit.Name = "btnRegedit";
            btnRegedit.Size = new Size(128, 50);
            btnRegedit.TabIndex = 30;
            btnRegedit.Text = "RegEdit";
            btnRegedit.UseVisualStyleBackColor = true;
            btnRegedit.Click += btnRegedit_Click;
            // 
            // otherTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 256);
            Controls.Add(btnRegedit);
            Controls.Add(btnZapret);
            Controls.Add(BuildLabel);
            Controls.Add(btnIoBitUnlocker);
            Controls.Add(btnProccesHacker);
            Controls.Add(btnExplorerPP);
            Controls.Add(btnCONTROLPANEL);
            Controls.Add(btnCMD);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(439, 450);
            MinimizeBox = false;
            MinimumSize = new Size(439, 295);
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
        private Button btnCONTROLPANEL;
        private Button btnCMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnExplorerPP;
        private Button btnProccesHacker;
        private Button btnIoBitUnlocker;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label BuildLabel;
        private Button btnZapret;
        private Button btnRegedit;
    }
}