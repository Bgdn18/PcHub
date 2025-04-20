namespace PCHUB
{
    partial class SystemUnlocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemUnlocker));
            chkCmd = new CheckBox();
            chkRegedit = new CheckBox();
            chkTaskmgr = new CheckBox();
            btnUnlock = new Button();
            btnLock = new Button();
            SuspendLayout();
            // 
            // chkCmd
            // 
            chkCmd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkCmd.AutoSize = true;
            chkCmd.Checked = true;
            chkCmd.CheckState = CheckState.Checked;
            chkCmd.Font = new Font("Consolas", 9F);
            chkCmd.Location = new Point(12, 12);
            chkCmd.Name = "chkCmd";
            chkCmd.Size = new Size(138, 18);
            chkCmd.TabIndex = 0;
            chkCmd.Text = "Cmd Unlock/Block";
            chkCmd.UseVisualStyleBackColor = true;
            // 
            // chkRegedit
            // 
            chkRegedit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkRegedit.AutoSize = true;
            chkRegedit.Checked = true;
            chkRegedit.CheckState = CheckState.Checked;
            chkRegedit.Font = new Font("Consolas", 9F);
            chkRegedit.Location = new Point(12, 37);
            chkRegedit.Name = "chkRegedit";
            chkRegedit.Size = new Size(166, 18);
            chkRegedit.TabIndex = 1;
            chkRegedit.Text = "RegEdit Unlock/Block";
            chkRegedit.UseVisualStyleBackColor = true;
            // 
            // chkTaskmgr
            // 
            chkTaskmgr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkTaskmgr.AutoSize = true;
            chkTaskmgr.Checked = true;
            chkTaskmgr.CheckState = CheckState.Checked;
            chkTaskmgr.Font = new Font("Consolas", 9F);
            chkTaskmgr.Location = new Point(13, 62);
            chkTaskmgr.Name = "chkTaskmgr";
            chkTaskmgr.Size = new Size(159, 18);
            chkTaskmgr.TabIndex = 2;
            chkTaskmgr.Text = "TakMgr Unlock/Block";
            chkTaskmgr.UseVisualStyleBackColor = true;
            // 
            // btnUnlock
            // 
            btnUnlock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUnlock.Font = new Font("Consolas", 9F);
            btnUnlock.Location = new Point(12, 98);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(172, 23);
            btnUnlock.TabIndex = 3;
            btnUnlock.Text = "Unlock";
            btnUnlock.UseVisualStyleBackColor = true;
            btnUnlock.Click += btnRestore_Click;
            // 
            // btnLock
            // 
            btnLock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLock.Font = new Font("Consolas", 9F);
            btnLock.Location = new Point(12, 127);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(172, 23);
            btnLock.TabIndex = 4;
            btnLock.Text = "Lock";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // SystemUnlocker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 161);
            Controls.Add(btnLock);
            Controls.Add(btnUnlock);
            Controls.Add(chkTaskmgr);
            Controls.Add(chkRegedit);
            Controls.Add(chkCmd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(700, 475);
            MinimizeBox = false;
            MinimumSize = new Size(200, 200);
            Name = "SystemUnlocker";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SystemUnlocker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkCmd;
        private CheckBox chkRegedit;
        private CheckBox chkTaskmgr;
        private Button btnUnlock;
        private Button btnLock;
    }
}