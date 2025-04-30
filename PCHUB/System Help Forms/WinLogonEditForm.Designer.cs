namespace PCHUB.WinLogonSpace
{
    partial class WinLogonEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLogonEditForm));
            TextBoxLogon = new TextBox();
            btnSave = new Button();
            btnReset = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            regEditToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxLogon
            // 
            TextBoxLogon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxLogon.Font = new Font("Consolas", 9F);
            TextBoxLogon.Location = new Point(12, 33);
            TextBoxLogon.Multiline = true;
            TextBoxLogon.Name = "TextBoxLogon";
            TextBoxLogon.Size = new Size(425, 63);
            TextBoxLogon.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Consolas", 9F);
            btnSave.Location = new Point(12, 101);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 25);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Consolas", 9F);
            btnReset.Location = new Point(337, 101);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 25);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, regEditToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(449, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // regEditToolStripMenuItem
            // 
            regEditToolStripMenuItem.Name = "regEditToolStripMenuItem";
            regEditToolStripMenuItem.Size = new Size(59, 20);
            regEditToolStripMenuItem.Text = "RegEdit";
            regEditToolStripMenuItem.Click += regEditToolStripMenuItem_Click;
            // 
            // WinLogonEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 136);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(TextBoxLogon);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1300, 195);
            MinimizeBox = false;
            MinimumSize = new Size(465, 175);
            Name = "WinLogonEditForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinLogon Edit";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxLogon;
        private Button btnSave;
        private Button btnReset;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem regEditToolStripMenuItem;
    }
}