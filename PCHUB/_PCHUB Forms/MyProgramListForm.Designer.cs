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
            ListBoxMyProgram = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnOpen = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            txtFileToolStripMenuItem = new ToolStripMenuItem();
            btnRefresh = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxMyProgram
            // 
            ListBoxMyProgram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxMyProgram.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBoxMyProgram.FormattingEnabled = true;
            ListBoxMyProgram.ItemHeight = 14;
            ListBoxMyProgram.Location = new Point(12, 40);
            ListBoxMyProgram.Name = "ListBoxMyProgram";
            ListBoxMyProgram.SelectionMode = SelectionMode.MultiExtended;
            ListBoxMyProgram.Size = new Size(460, 396);
            ListBoxMyProgram.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Consolas", 9F);
            btnAdd.Location = new Point(12, 441);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Consolas", 9F);
            btnDelete.Location = new Point(93, 441);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.FlatStyle = FlatStyle.System;
            btnOpen.Font = new Font("Consolas", 9F);
            btnOpen.Location = new Point(397, 441);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, txtFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 4;
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
            // txtFileToolStripMenuItem
            // 
            txtFileToolStripMenuItem.Font = new Font("Consolas", 9F);
            txtFileToolStripMenuItem.Name = "txtFileToolStripMenuItem";
            txtFileToolStripMenuItem.Size = new Size(68, 20);
            txtFileToolStripMenuItem.Text = "TxtFile";
            txtFileToolStripMenuItem.Click += txtFileToolStripMenuItem_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.System;
            btnRefresh.Font = new Font("Consolas", 9F);
            btnRefresh.Location = new Point(174, 441);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MyProgramListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 476);
            Controls.Add(btnRefresh);
            Controls.Add(btnOpen);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(ListBoxMyProgram);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new Size(300, 300);
            Name = "MyProgramListForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
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