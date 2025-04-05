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
            menuStrip1 = new MenuStrip();
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
            btnLocalUser = new Button();
            btnDeleteFile = new Button();
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
            btnPowerManagement.Text = "Power \r\nmanagement";
            btnPowerManagement.UseVisualStyleBackColor = true;
            btnPowerManagement.Click += PowerManagement_Click;
            // 
            // btnADMIN
            // 
            btnADMIN.Cursor = Cursors.Hand;
            btnADMIN.Font = new Font("Consolas", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnADMIN.Location = new Point(284, 174);
            btnADMIN.Margin = new Padding(4, 3, 4, 3);
            btnADMIN.Name = "btnADMIN";
            btnADMIN.Size = new Size(178, 53);
            btnADMIN.TabIndex = 2;
            btnADMIN.Text = "3rd Party...";
            btnADMIN.UseVisualStyleBackColor = true;
            btnADMIN.Click += ADMIN_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(475, 24);
            menuStrip1.TabIndex = 4;
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
            aDDToolStripMenuItem.Size = new Size(116, 22);
            aDDToolStripMenuItem.Text = "ADD";
            aDDToolStripMenuItem.Click += aDDToolStripMenuItem_Click;
            // 
            // dELETEToolStripMenuItem
            // 
            dELETEToolStripMenuItem.Font = new Font("Consolas", 9F);
            dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            dELETEToolStripMenuItem.Size = new Size(116, 22);
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
            BuildLabel.Location = new Point(0, 305);
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
            btnALL.Location = new Point(285, 233);
            btnALL.Margin = new Padding(4, 3, 4, 3);
            btnALL.Name = "btnALL";
            btnALL.Size = new Size(178, 53);
            btnALL.TabIndex = 11;
            btnALL.Text = "View All...";
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
            btnTxtWriter.Text = "Writer";
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
            btnWindowsSettings.Text = "Task Manager";
            btnWindowsSettings.UseVisualStyleBackColor = true;
            btnWindowsSettings.Click += TaskMgr_Click;
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
            // btnLocalUser
            // 
            btnLocalUser.Font = new Font("Consolas", 9F);
            btnLocalUser.Location = new Point(285, 56);
            btnLocalUser.Name = "btnLocalUser";
            btnLocalUser.Size = new Size(178, 53);
            btnLocalUser.TabIndex = 21;
            btnLocalUser.Text = "Add Local User";
            btnLocalUser.UseVisualStyleBackColor = true;
            btnLocalUser.Click += LocalUser_Click;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Font = new Font("Consolas", 9F);
            btnDeleteFile.Location = new Point(284, 115);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(178, 53);
            btnDeleteFile.TabIndex = 23;
            btnDeleteFile.Text = "File Delete";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // _MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(475, 335);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnLocalUser);
            Controls.Add(btnTaskkiller);
            Controls.Add(btnWindowsSettings);
            Controls.Add(btnTxtWriter);
            Controls.Add(btnALL);
            Controls.Add(BuildLabel);
            Controls.Add(btnADMIN);
            Controls.Add(btnPowerManagement);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "_MAIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PcHub";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPowerManagement;
        private Button btnADMIN;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label BuildLabel;
        private Button btnALL;
        private Button btnTxtWriter;
        private Button btnWindowsSettings;
        private Button btnTaskkiller;
        private Button btnLocalUser;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aDDToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private Button btnDeleteFile;
    }
}