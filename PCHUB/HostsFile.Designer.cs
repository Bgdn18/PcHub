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
            SuspendLayout();
            // 
            // btnReset
            // 
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
            txtHosts.Font = new Font("Consolas", 9F);
            txtHosts.Location = new Point(12, 12);
            txtHosts.Multiline = true;
            txtHosts.Name = "txtHosts";
            txtHosts.ScrollBars = ScrollBars.Both;
            txtHosts.Size = new Size(762, 397);
            txtHosts.TabIndex = 1;
            // 
            // Save
            // 
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
            OpenFolder.Font = new Font("Consolas", 9F);
            OpenFolder.Location = new Point(524, 415);
            OpenFolder.Name = "OpenFolder";
            OpenFolder.Size = new Size(250, 25);
            OpenFolder.TabIndex = 3;
            OpenFolder.Text = "Open Folder";
            OpenFolder.UseVisualStyleBackColor = true;
            OpenFolder.Click += OpenFolder_Click;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HostsFile";
            ShowIcon = false;
            Text = "HostsFile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private TextBox txtHosts;
        private Button Save;
        private Button OpenFolder;
    }
}