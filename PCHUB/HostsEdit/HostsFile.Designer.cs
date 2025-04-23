namespace PCHUB
{
    partial class HostsFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostsFile));
            btnReset = new Button();
            txtHosts = new TextBox();
            Save = new Button();
            OpenFolder = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Consolas", 9F);
            btnReset.Location = new Point(12, 415);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(250, 25);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset hosts file";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtHosts
            // 
            txtHosts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHosts.Font = new Font("Consolas", 9F);
            txtHosts.Location = new Point(12, 31);
            txtHosts.Multiline = true;
            txtHosts.Name = "txtHosts";
            txtHosts.ScrollBars = ScrollBars.Both;
            txtHosts.Size = new Size(762, 378);
            txtHosts.TabIndex = 1;
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom;
            Save.Cursor = Cursors.Hand;
            Save.Font = new Font("Consolas", 9F);
            Save.Location = new Point(268, 415);
            Save.Name = "Save";
            Save.Size = new Size(250, 25);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // OpenFolder
            // 
            OpenFolder.Anchor = AnchorStyles.Bottom;
            OpenFolder.Cursor = Cursors.Hand;
            OpenFolder.Font = new Font("Consolas", 9F);
            OpenFolder.Location = new Point(524, 415);
            OpenFolder.Name = "OpenFolder";
            OpenFolder.Size = new Size(250, 25);
            OpenFolder.TabIndex = 3;
            OpenFolder.Text = "Open Folder";
            OpenFolder.UseVisualStyleBackColor = true;
            OpenFolder.Click += OpenFolder_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(787, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // HostsFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 450);
            Controls.Add(OpenFolder);
            Controls.Add(Save);
            Controls.Add(txtHosts);
            Controls.Add(btnReset);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "HostsFile";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HostsFile";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private TextBox txtHosts;
        private Button Save;
        private Button OpenFolder;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}