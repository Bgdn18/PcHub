namespace PCHUB
{
    partial class PowerShellPolicyReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerShellPolicyReset));
            lblCurrentPolicy = new Label();
            btnResetPolicy = new Button();
            btnCheck = new Button();
            btnUnrestricted = new Button();
            btnRemoteSigned = new Button();
            btnAllSigned = new Button();
            btnRestricted = new Button();
            btnBypass = new Button();
            btnUndefined = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCurrentPolicy
            // 
            lblCurrentPolicy.AutoSize = true;
            lblCurrentPolicy.Font = new Font("Consolas", 9F);
            lblCurrentPolicy.Location = new Point(12, 32);
            lblCurrentPolicy.Name = "lblCurrentPolicy";
            lblCurrentPolicy.Size = new Size(168, 14);
            lblCurrentPolicy.TabIndex = 0;
            lblCurrentPolicy.Text = "Current policy: Unknown";
            // 
            // btnResetPolicy
            // 
            btnResetPolicy.Cursor = Cursors.Hand;
            btnResetPolicy.Font = new Font("Consolas", 9F);
            btnResetPolicy.Location = new Point(12, 110);
            btnResetPolicy.Name = "btnResetPolicy";
            btnResetPolicy.Size = new Size(268, 55);
            btnResetPolicy.TabIndex = 1;
            btnResetPolicy.Text = "Reset policy";
            btnResetPolicy.UseVisualStyleBackColor = true;
            btnResetPolicy.Click += btnResetPolicy_Click;
            // 
            // btnCheck
            // 
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.Font = new Font("Consolas", 9F);
            btnCheck.Location = new Point(12, 49);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(268, 55);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check current policy";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnUnrestricted
            // 
            btnUnrestricted.Cursor = Cursors.Hand;
            btnUnrestricted.Font = new Font("Consolas", 9F);
            btnUnrestricted.Location = new Point(304, 110);
            btnUnrestricted.Name = "btnUnrestricted";
            btnUnrestricted.Size = new Size(136, 55);
            btnUnrestricted.TabIndex = 3;
            btnUnrestricted.Text = "Set Unrestricted";
            btnUnrestricted.UseVisualStyleBackColor = true;
            btnUnrestricted.Click += btnUnrestricted_Click;
            // 
            // btnRemoteSigned
            // 
            btnRemoteSigned.Cursor = Cursors.Hand;
            btnRemoteSigned.Font = new Font("Consolas", 9F);
            btnRemoteSigned.Location = new Point(446, 110);
            btnRemoteSigned.Name = "btnRemoteSigned";
            btnRemoteSigned.Size = new Size(136, 55);
            btnRemoteSigned.TabIndex = 4;
            btnRemoteSigned.Text = "Set RemoteSigned";
            btnRemoteSigned.UseVisualStyleBackColor = true;
            btnRemoteSigned.Click += btnRemoteSigned_Click;
            // 
            // btnAllSigned
            // 
            btnAllSigned.Cursor = Cursors.Hand;
            btnAllSigned.Font = new Font("Consolas", 9F);
            btnAllSigned.Location = new Point(588, 110);
            btnAllSigned.Name = "btnAllSigned";
            btnAllSigned.Size = new Size(136, 55);
            btnAllSigned.TabIndex = 5;
            btnAllSigned.Text = "Set AllSigned";
            btnAllSigned.UseVisualStyleBackColor = true;
            btnAllSigned.Click += btnAllSigned_Click;
            // 
            // btnRestricted
            // 
            btnRestricted.Cursor = Cursors.Hand;
            btnRestricted.Font = new Font("Consolas", 9F);
            btnRestricted.Location = new Point(588, 49);
            btnRestricted.Name = "btnRestricted";
            btnRestricted.Size = new Size(136, 55);
            btnRestricted.TabIndex = 6;
            btnRestricted.Text = "Set Restricted";
            btnRestricted.UseVisualStyleBackColor = true;
            btnRestricted.Click += btnRestricted_Click;
            // 
            // btnBypass
            // 
            btnBypass.Cursor = Cursors.Hand;
            btnBypass.Font = new Font("Consolas", 9F);
            btnBypass.Location = new Point(446, 49);
            btnBypass.Name = "btnBypass";
            btnBypass.Size = new Size(136, 55);
            btnBypass.TabIndex = 7;
            btnBypass.Text = "Set Bypass";
            btnBypass.UseVisualStyleBackColor = true;
            btnBypass.Click += btnBypass_Click;
            // 
            // btnUndefined
            // 
            btnUndefined.Cursor = Cursors.Hand;
            btnUndefined.Font = new Font("Consolas", 9F);
            btnUndefined.Location = new Point(304, 49);
            btnUndefined.Name = "btnUndefined";
            btnUndefined.Size = new Size(136, 55);
            btnUndefined.TabIndex = 8;
            btnUndefined.Text = "Set Undefined";
            btnUndefined.UseVisualStyleBackColor = true;
            btnUndefined.Click += btnUndefined_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Font = new Font("Consolas", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(736, 24);
            menuStrip1.TabIndex = 9;
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
            // PowerShellPolicyReset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 178);
            Controls.Add(btnUndefined);
            Controls.Add(btnBypass);
            Controls.Add(btnRestricted);
            Controls.Add(btnAllSigned);
            Controls.Add(btnRemoteSigned);
            Controls.Add(btnUnrestricted);
            Controls.Add(btnCheck);
            Controls.Add(btnResetPolicy);
            Controls.Add(lblCurrentPolicy);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PowerShellPolicyReset";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PowerShell Policy Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentPolicy;
        private Button btnResetPolicy;
        private Button btnCheck;
        private Button btnUnrestricted;
        private Button btnRemoteSigned;
        private Button btnAllSigned;
        private Button btnRestricted;
        private Button btnBypass;
        private Button btnUndefined;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}