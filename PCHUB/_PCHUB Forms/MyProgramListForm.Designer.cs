namespace PCHUB
{
    partial class MyProgramListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProgramListForm));
            ListBoxMyProgram = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnOpen = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            txtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnRefresh = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxMyProgram
            // 
            ListBoxMyProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            ListBoxMyProgram.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            ListBoxMyProgram.FormattingEnabled = true;
            ListBoxMyProgram.ItemHeight = 14;
            ListBoxMyProgram.Location = new System.Drawing.Point(12, 40);
            ListBoxMyProgram.Name = "ListBoxMyProgram";
            ListBoxMyProgram.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            ListBoxMyProgram.Size = new System.Drawing.Size(460, 396);
            ListBoxMyProgram.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Font = new System.Drawing.Font("Consolas", 9F);
            btnAdd.Location = new System.Drawing.Point(12, 441);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Font = new System.Drawing.Font("Consolas", 9F);
            btnDelete.Location = new System.Drawing.Point(93, 441);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOpen.Font = new System.Drawing.Font("Consolas", 9F);
            btnOpen.Location = new System.Drawing.Point(397, 441);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(75, 23);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { quitToolStripMenuItem, txtFileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(484, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F);
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // txtFileToolStripMenuItem
            // 
            txtFileToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F);
            txtFileToolStripMenuItem.Name = "txtFileToolStripMenuItem";
            txtFileToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            txtFileToolStripMenuItem.Text = "TxtFile";
            txtFileToolStripMenuItem.Click += txtFileToolStripMenuItem_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.Font = new System.Drawing.Font("Consolas", 9F);
            btnRefresh.Location = new System.Drawing.Point(174, 441);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(75, 23);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MyProgramList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 476);
            Controls.Add(btnRefresh);
            Controls.Add(btnOpen);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(ListBoxMyProgram);
            Controls.Add(menuStrip1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(300, 300);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "My program list";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxMyProgram;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnOpen;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem txtFileToolStripMenuItem;
        private Button btnRefresh;
    }
}