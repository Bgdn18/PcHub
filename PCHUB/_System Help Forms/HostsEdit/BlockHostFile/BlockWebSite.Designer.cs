namespace PCHUB.HostsSpace
{
    partial class BlockWebSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockWebSite));
            TextBoxBlock = new TextBox();
            btnBlock = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            hostFileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxBlock
            // 
            TextBoxBlock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxBlock.Font = new Font("Consolas", 9F);
            TextBoxBlock.Location = new Point(12, 27);
            TextBoxBlock.Multiline = true;
            TextBoxBlock.Name = "TextBoxBlock";
            TextBoxBlock.PlaceholderText = "Site name";
            TextBoxBlock.ScrollBars = ScrollBars.Both;
            TextBoxBlock.Size = new Size(425, 23);
            TextBoxBlock.TabIndex = 0;
            TextBoxBlock.Text = "www.youtube.com";
            // 
            // btnBlock
            // 
            btnBlock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBlock.Cursor = Cursors.Hand;
            btnBlock.Font = new Font("Consolas", 9F);
            btnBlock.Location = new Point(12, 56);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(425, 27);
            btnBlock.TabIndex = 1;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, hostFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(449, 24);
            menuStrip1.TabIndex = 2;
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
            // hostFileToolStripMenuItem
            // 
            hostFileToolStripMenuItem.Font = new Font("Consolas", 9F);
            hostFileToolStripMenuItem.Name = "hostFileToolStripMenuItem";
            hostFileToolStripMenuItem.Size = new Size(82, 20);
            hostFileToolStripMenuItem.Text = "Host File";
            hostFileToolStripMenuItem.Click += hostFileToolStripMenuItem_Click;
            // 
            // BlockWebSite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 91);
            Controls.Add(btnBlock);
            Controls.Add(TextBoxBlock);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new Size(465, 130);
            Name = "BlockWebSite";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Block WebSite";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxBlock;
        private Button btnBlock;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem hostFileToolStripMenuItem;
    }
}