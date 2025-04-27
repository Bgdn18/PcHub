namespace PCHUB
{
    partial class TaskKiller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskKiller));
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            blockProcessToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            listBoxProcesses = new ListBox();
            TasksLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRunNewProcess = new Button();
            btnRefreshProcess = new Button();
            btnEndTask = new Button();
            tabPage2 = new TabPage();
            labelAutoStartCount = new Label();
            btnAddAutoStart = new Button();
            btnDeleteAutoStart = new Button();
            btnRefreshAutoStart = new Button();
            startupListView = new ListBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, blockProcessToolStripMenuItem, runToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(569, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Font = new Font("Consolas", 9F);
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(47, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click_1;
            // 
            // blockProcessToolStripMenuItem
            // 
            blockProcessToolStripMenuItem.Name = "blockProcessToolStripMenuItem";
            blockProcessToolStripMenuItem.Size = new Size(91, 20);
            blockProcessToolStripMenuItem.Text = "Block Process";
            blockProcessToolStripMenuItem.Click += blockProcessToolStripMenuItem_Click;
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(40, 20);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // listBoxProcesses
            // 
            listBoxProcesses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxProcesses.Font = new Font("Consolas", 9F);
            listBoxProcesses.FormattingEnabled = true;
            listBoxProcesses.ItemHeight = 14;
            listBoxProcesses.Location = new Point(6, 6);
            listBoxProcesses.Name = "listBoxProcesses";
            listBoxProcesses.Size = new Size(552, 396);
            listBoxProcesses.TabIndex = 4;
            // 
            // TasksLabel
            // 
            TasksLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TasksLabel.AutoSize = true;
            TasksLabel.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TasksLabel.Location = new Point(119, 412);
            TasksLabel.Name = "TasksLabel";
            TasksLabel.Size = new Size(98, 14);
            TasksLabel.TabIndex = 6;
            TasksLabel.Text = "Process: null";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(569, 463);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRunNewProcess);
            tabPage1.Controls.Add(btnRefreshProcess);
            tabPage1.Controls.Add(btnEndTask);
            tabPage1.Controls.Add(listBoxProcesses);
            tabPage1.Controls.Add(TasksLabel);
            tabPage1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(561, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Procces";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRunNewProcess
            // 
            btnRunNewProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRunNewProcess.Cursor = Cursors.Hand;
            btnRunNewProcess.Location = new Point(6, 408);
            btnRunNewProcess.Name = "btnRunNewProcess";
            btnRunNewProcess.Size = new Size(107, 23);
            btnRunNewProcess.TabIndex = 9;
            btnRunNewProcess.Text = "Run";
            btnRunNewProcess.UseVisualStyleBackColor = true;
            btnRunNewProcess.Click += runToolStripMenuItem_Click;
            // 
            // btnRefreshProcess
            // 
            btnRefreshProcess.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefreshProcess.Cursor = Cursors.Hand;
            btnRefreshProcess.Location = new Point(397, 408);
            btnRefreshProcess.Name = "btnRefreshProcess";
            btnRefreshProcess.Size = new Size(75, 23);
            btnRefreshProcess.TabIndex = 8;
            btnRefreshProcess.Text = "Refresh";
            btnRefreshProcess.UseVisualStyleBackColor = true;
            btnRefreshProcess.Click += btnRefresh_Click;
            // 
            // btnEndTask
            // 
            btnEndTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEndTask.Cursor = Cursors.Hand;
            btnEndTask.Location = new Point(478, 408);
            btnEndTask.Name = "btnEndTask";
            btnEndTask.Size = new Size(75, 23);
            btnEndTask.TabIndex = 7;
            btnEndTask.Text = "End Task";
            btnEndTask.UseVisualStyleBackColor = true;
            btnEndTask.Click += btnKillProcess_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelAutoStartCount);
            tabPage2.Controls.Add(btnAddAutoStart);
            tabPage2.Controls.Add(btnDeleteAutoStart);
            tabPage2.Controls.Add(btnRefreshAutoStart);
            tabPage2.Controls.Add(startupListView);
            tabPage2.Font = new Font("Consolas", 9F);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(561, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AutoStartup";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelAutoStartCount
            // 
            labelAutoStartCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelAutoStartCount.AutoSize = true;
            labelAutoStartCount.Font = new Font("Consolas", 9F, FontStyle.Bold);
            labelAutoStartCount.Location = new Point(119, 413);
            labelAutoStartCount.Name = "labelAutoStartCount";
            labelAutoStartCount.Size = new Size(98, 14);
            labelAutoStartCount.TabIndex = 4;
            labelAutoStartCount.Text = "Process: null";
            // 
            // btnAddAutoStart
            // 
            btnAddAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddAutoStart.Cursor = Cursors.Hand;
            btnAddAutoStart.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAutoStart.Location = new Point(6, 409);
            btnAddAutoStart.Name = "btnAddAutoStart";
            btnAddAutoStart.Size = new Size(107, 23);
            btnAddAutoStart.TabIndex = 3;
            btnAddAutoStart.Text = "Add Auto Start";
            btnAddAutoStart.UseVisualStyleBackColor = true;
            btnAddAutoStart.Click += btnAddAutoStart_Click;
            // 
            // btnDeleteAutoStart
            // 
            btnDeleteAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteAutoStart.Cursor = Cursors.Hand;
            btnDeleteAutoStart.Location = new Point(478, 409);
            btnDeleteAutoStart.Name = "btnDeleteAutoStart";
            btnDeleteAutoStart.Size = new Size(75, 23);
            btnDeleteAutoStart.TabIndex = 2;
            btnDeleteAutoStart.Text = "Delete";
            btnDeleteAutoStart.UseVisualStyleBackColor = true;
            btnDeleteAutoStart.Click += btnDeleteAutoStart_Click;
            // 
            // btnRefreshAutoStart
            // 
            btnRefreshAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefreshAutoStart.Cursor = Cursors.Hand;
            btnRefreshAutoStart.Location = new Point(397, 409);
            btnRefreshAutoStart.Name = "btnRefreshAutoStart";
            btnRefreshAutoStart.Size = new Size(75, 23);
            btnRefreshAutoStart.TabIndex = 1;
            btnRefreshAutoStart.Text = "Refresh";
            btnRefreshAutoStart.UseVisualStyleBackColor = true;
            btnRefreshAutoStart.Click += btnRefreshAutoStart_Click;
            // 
            // startupListView
            // 
            startupListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startupListView.FormattingEnabled = true;
            startupListView.ItemHeight = 14;
            startupListView.Location = new Point(6, 6);
            startupListView.Name = "startupListView";
            startupListView.Size = new Size(547, 396);
            startupListView.TabIndex = 0;
            // 
            // TaskKiller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 490);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new Size(300, 300);
            Name = "TaskKiller";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskKiller";
            Load += TaskKiller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ListBox listBoxProcesses;
        private Label TasksLabel;
        private ToolStripMenuItem runToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRefreshProcess;
        private Button btnEndTask;
        private Button btnRefreshAutoStart;
        private Button btnDeleteAutoStart;
        private Button btnAddAutoStart;
        private Label labelAutoStartCount;
        private ListBox startupListView;
        private Button btnRunNewProcess;
        private ToolStripMenuItem blockProcessToolStripMenuItem;
    }
}