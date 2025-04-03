namespace PCHUB
{
    partial class _MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_MAIN));
            btnPowerManagement = new Button();
            btnADMIN = new Button();
            btnCMD = new Button();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aDDToolStripMenuItem = new ToolStripMenuItem();
            dELETEToolStripMenuItem = new ToolStripMenuItem();
            BuildLabel = new Label();
            btnALL = new Button();
            btnTxtWriter = new Button();
            btnWindowsSettings = new Button();
            btnTaskkiller = new Button();
            btnExplorerPP = new Button();
            btnIOBitUnlocker = new Button();
            btnLocalUser = new Button();
            btnfileexplorer = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPowerManagement
            // 
            btnPowerManagement.Cursor = Cursors.Hand;
            btnPowerManagement.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPowerManagement.Location = new Point(13, 56);
            btnPowerManagement.Margin = new Padding(4, 3, 4, 3);
            btnPowerManagement.Name = "btnPowerManagement";
            btnPowerManagement.Size = new Size(178, 53);
            btnPowerManagement.TabIndex = 0;
            btnPowerManagement.Text = "Power \r\nmanagement ⚡";
            btnPowerManagement.UseVisualStyleBackColor = true;
            btnPowerManagement.Click += PowerManagement_Click;
            // 
            // btnADMIN
            // 
            btnADMIN.Cursor = Cursors.Hand;
            btnADMIN.Font = new Font("Consolas", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnADMIN.Location = new Point(284, 233);
            btnADMIN.Margin = new Padding(4, 3, 4, 3);
            btnADMIN.Name = "btnADMIN";
            btnADMIN.Size = new Size(178, 53);
            btnADMIN.TabIndex = 2;
            btnADMIN.Text = "Tools...";
            btnADMIN.UseVisualStyleBackColor = true;
            btnADMIN.Click += ADMIN_Click;
            // 
            // btnCMD
            // 
            btnCMD.Cursor = Cursors.Hand;
            btnCMD.Font = new Font("Consolas", 9F);
            btnCMD.Location = new Point(13, 292);
            btnCMD.Margin = new Padding(4, 3, 4, 3);
            btnCMD.Name = "btnCMD";
            btnCMD.Size = new Size(178, 53);
            btnCMD.TabIndex = 3;
            btnCMD.Text = "CMD 🖥";
            btnCMD.UseVisualStyleBackColor = true;
            btnCMD.Click += CMD_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { themeToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(475, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, purpleToolStripMenuItem });
            themeToolStripMenuItem.Font = new Font("Consolas", 9F);
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(54, 20);
            themeToolStripMenuItem.Text = "Theme";
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aDDToolStripMenuItem, dELETEToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Consolas", 9F);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(117, 20);
            toolStripMenuItem1.Text = "Add To StartUp";
            // 
            // aDDToolStripMenuItem
            // 
            aDDToolStripMenuItem.Font = new Font("Consolas", 9F);
            aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            aDDToolStripMenuItem.Size = new Size(180, 22);
            aDDToolStripMenuItem.Text = "ADD";
            aDDToolStripMenuItem.Click += aDDToolStripMenuItem_Click;
            // 
            // dELETEToolStripMenuItem
            // 
            dELETEToolStripMenuItem.Font = new Font("Consolas", 9F);
            dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            dELETEToolStripMenuItem.Size = new Size(180, 22);
            dELETEToolStripMenuItem.Text = "DELETE";
            dELETEToolStripMenuItem.Click += dELETEToolStripMenuItem_Click;
            // 
            // BuildLabel
            // 
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Cursor = Cursors.Hand;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(0, 414);
            BuildLabel.Margin = new Padding(4, 0, 4, 0);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 10;
            BuildLabel.Text = "null";
            BuildLabel.Click += build_Click;
            // 
            // btnALL
            // 
            btnALL.Cursor = Cursors.Hand;
            btnALL.Font = new Font("Consolas", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnALL.Location = new Point(284, 292);
            btnALL.Margin = new Padding(4, 3, 4, 3);
            btnALL.Name = "btnALL";
            btnALL.Size = new Size(178, 112);
            btnALL.TabIndex = 11;
            btnALL.Text = "Library...";
            btnALL.UseVisualStyleBackColor = true;
            btnALL.Click += Library_Click;
            // 
            // btnTxtWriter
            // 
            btnTxtWriter.Cursor = Cursors.Hand;
            btnTxtWriter.Font = new Font("Consolas", 9F);
            btnTxtWriter.Location = new Point(12, 233);
            btnTxtWriter.Margin = new Padding(4, 3, 4, 3);
            btnTxtWriter.Name = "btnTxtWriter";
            btnTxtWriter.Size = new Size(178, 53);
            btnTxtWriter.TabIndex = 13;
            btnTxtWriter.Text = "Writer ✒";
            btnTxtWriter.UseVisualStyleBackColor = true;
            btnTxtWriter.Click += TxtWriter_Click;
            // 
            // btnWindowsSettings
            // 
            btnWindowsSettings.Cursor = Cursors.Hand;
            btnWindowsSettings.Font = new Font("Consolas", 9F);
            btnWindowsSettings.Location = new Point(13, 115);
            btnWindowsSettings.Margin = new Padding(4, 3, 4, 3);
            btnWindowsSettings.Name = "btnWindowsSettings";
            btnWindowsSettings.Size = new Size(178, 53);
            btnWindowsSettings.TabIndex = 15;
            btnWindowsSettings.Text = "Windows Settings ⚙";
            btnWindowsSettings.UseVisualStyleBackColor = true;
            btnWindowsSettings.Click += WindowsSettings_Click;
            // 
            // btnTaskkiller
            // 
            btnTaskkiller.Cursor = Cursors.Hand;
            btnTaskkiller.Font = new Font("Consolas", 9F);
            btnTaskkiller.Location = new Point(12, 174);
            btnTaskkiller.Margin = new Padding(4, 3, 4, 3);
            btnTaskkiller.Name = "btnTaskkiller";
            btnTaskkiller.Size = new Size(178, 53);
            btnTaskkiller.TabIndex = 17;
            btnTaskkiller.Text = "TaskKill";
            btnTaskkiller.UseVisualStyleBackColor = true;
            btnTaskkiller.Click += Taskkiller_Click;
            // 
            // btnExplorerPP
            // 
            btnExplorerPP.Font = new Font("Consolas", 9F);
            btnExplorerPP.Location = new Point(13, 351);
            btnExplorerPP.Name = "btnExplorerPP";
            btnExplorerPP.Size = new Size(178, 53);
            btnExplorerPP.TabIndex = 19;
            btnExplorerPP.Text = "Explorer++";
            btnExplorerPP.UseVisualStyleBackColor = true;
            btnExplorerPP.Click += ExplorerPP_Click;
            // 
            // btnIOBitUnlocker
            // 
            btnIOBitUnlocker.Cursor = Cursors.Hand;
            btnIOBitUnlocker.Font = new Font("Consolas", 9F);
            btnIOBitUnlocker.Location = new Point(284, 56);
            btnIOBitUnlocker.Margin = new Padding(4, 3, 4, 3);
            btnIOBitUnlocker.Name = "btnIOBitUnlocker";
            btnIOBitUnlocker.Size = new Size(178, 53);
            btnIOBitUnlocker.TabIndex = 20;
            btnIOBitUnlocker.Text = "Unlocker";
            btnIOBitUnlocker.UseVisualStyleBackColor = true;
            btnIOBitUnlocker.Click += IOBitUnlocker_Click;
            // 
            // btnLocalUser
            // 
            btnLocalUser.Font = new Font("Consolas", 9F);
            btnLocalUser.Location = new Point(284, 174);
            btnLocalUser.Name = "btnLocalUser";
            btnLocalUser.Size = new Size(178, 53);
            btnLocalUser.TabIndex = 21;
            btnLocalUser.Text = "Add Local User 👥";
            btnLocalUser.UseVisualStyleBackColor = true;
            btnLocalUser.Click += LocalUser_Click;
            // 
            // btnfileexplorer
            // 
            btnfileexplorer.Font = new Font("Consolas", 9F);
            btnfileexplorer.Location = new Point(284, 115);
            btnfileexplorer.Name = "btnfileexplorer";
            btnfileexplorer.Size = new Size(178, 53);
            btnfileexplorer.TabIndex = 22;
            btnfileexplorer.Text = "File Explorer 🚎";
            btnfileexplorer.UseVisualStyleBackColor = true;
            btnfileexplorer.Click += fileexplorer_Click;
            // 
            // _MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(475, 446);
            Controls.Add(btnfileexplorer);
            Controls.Add(btnLocalUser);
            Controls.Add(btnIOBitUnlocker);
            Controls.Add(btnExplorerPP);
            Controls.Add(btnTaskkiller);
            Controls.Add(btnWindowsSettings);
            Controls.Add(btnTxtWriter);
            Controls.Add(btnALL);
            Controls.Add(BuildLabel);
            Controls.Add(btnCMD);
            Controls.Add(btnADMIN);
            Controls.Add(btnPowerManagement);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "_MAIN";
            Text = "PcHub for Windows 10/11";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPowerManagement;
        private Button btnADMIN;
        private Button btnCMD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem purpleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label BuildLabel;
        private Button btnALL;
        private Button btnTxtWriter;
        private Button btnWindowsSettings;
        private Button btnTaskkiller;
        private Button btnExplorerPP;
        private Button btnIOBitUnlocker;
        private Button btnLocalUser;
        private Button btnfileexplorer;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aDDToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
    }
}