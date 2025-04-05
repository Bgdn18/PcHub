namespace PCHUB
{
    partial class LocalUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalUser));
            ADDLocalUser = new Button();
            DeleteLocalUser = new Button();
            textboxUsername = new TextBox();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            ViewFolder = new Button();
            UserPassword = new TextBox();
            btnOpenSettings = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ADDLocalUser
            // 
            ADDLocalUser.Font = new Font("Consolas", 9F);
            ADDLocalUser.Location = new Point(12, 102);
            ADDLocalUser.Name = "ADDLocalUser";
            ADDLocalUser.Size = new Size(135, 40);
            ADDLocalUser.TabIndex = 0;
            ADDLocalUser.Text = "ADD";
            ADDLocalUser.UseVisualStyleBackColor = true;
            ADDLocalUser.Click += button1_Click;
            // 
            // DeleteLocalUser
            // 
            DeleteLocalUser.Font = new Font("Consolas", 9F);
            DeleteLocalUser.Location = new Point(153, 102);
            DeleteLocalUser.Name = "DeleteLocalUser";
            DeleteLocalUser.Size = new Size(135, 40);
            DeleteLocalUser.TabIndex = 1;
            DeleteLocalUser.Text = "DELETE";
            DeleteLocalUser.UseVisualStyleBackColor = true;
            DeleteLocalUser.Click += DeleteLocalUser_Click;
            // 
            // textboxUsername
            // 
            textboxUsername.Font = new Font("Consolas", 9F);
            textboxUsername.Location = new Point(12, 46);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.PlaceholderText = "UserName";
            textboxUsername.Size = new Size(390, 22);
            textboxUsername.TabIndex = 2;
            textboxUsername.Text = "PCHUB USER";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(481, 24);
            menuStrip1.TabIndex = 3;
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
            // ViewFolder
            // 
            ViewFolder.Font = new Font("Consolas", 9F);
            ViewFolder.Location = new Point(335, 102);
            ViewFolder.Name = "ViewFolder";
            ViewFolder.Size = new Size(135, 40);
            ViewFolder.TabIndex = 4;
            ViewFolder.Text = "View Folder";
            ViewFolder.UseVisualStyleBackColor = true;
            ViewFolder.Click += ViewFolder_Click;
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Consolas", 9F);
            UserPassword.Location = new Point(13, 74);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.PlaceholderText = "PassWord";
            UserPassword.Size = new Size(457, 22);
            UserPassword.TabIndex = 5;
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Font = new Font("Consolas", 9F);
            btnOpenSettings.Location = new Point(408, 46);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(61, 22);
            btnOpenSettings.TabIndex = 6;
            btnOpenSettings.Text = "View";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click;
            // 
            // LocalUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 151);
            Controls.Add(btnOpenSettings);
            Controls.Add(UserPassword);
            Controls.Add(ViewFolder);
            Controls.Add(textboxUsername);
            Controls.Add(DeleteLocalUser);
            Controls.Add(ADDLocalUser);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LocalUser";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LocalUser Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ADDLocalUser;
        private Button DeleteLocalUser;
        private TextBox textboxUsername;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button ViewFolder;
        private TextBox UserPassword;
        private Button btnOpenSettings;
    }
}