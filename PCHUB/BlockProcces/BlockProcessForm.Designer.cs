namespace PCHUB.BlockProcces
{
    partial class BlockProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockProcessForm));
            textBoxProcessName = new TextBox();
            textBoxTimer = new TextBox();
            btnStart = new Button();
            btnStop = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            configFileToolStripMenuItem = new ToolStripMenuItem();
            taskKillerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxProcessName
            // 
            textBoxProcessName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProcessName.Font = new Font("Consolas", 9F);
            textBoxProcessName.Location = new Point(12, 36);
            textBoxProcessName.Multiline = true;
            textBoxProcessName.Name = "textBoxProcessName";
            textBoxProcessName.PlaceholderText = "Process Name, for example: Cmd";
            textBoxProcessName.Size = new Size(524, 38);
            textBoxProcessName.TabIndex = 0;
            // 
            // textBoxTimer
            // 
            textBoxTimer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTimer.Font = new Font("Consolas", 9F);
            textBoxTimer.Location = new Point(12, 80);
            textBoxTimer.Multiline = true;
            textBoxTimer.Name = "textBoxTimer";
            textBoxTimer.PlaceholderText = "Interval in second, for example: 5";
            textBoxTimer.Size = new Size(524, 38);
            textBoxTimer.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Font = new Font("Consolas", 9F);
            btnStart.Location = new Point(12, 128);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(524, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Blocking";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStop.Enabled = false;
            btnStop.Font = new Font("Consolas", 9F);
            btnStop.Location = new Point(12, 157);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(524, 23);
            btnStop.TabIndex = 3;
            btnStop.Text = "Unlock All";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, configFileToolStripMenuItem, taskKillerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(544, 24);
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
            // configFileToolStripMenuItem
            // 
            configFileToolStripMenuItem.Name = "configFileToolStripMenuItem";
            configFileToolStripMenuItem.Size = new Size(76, 20);
            configFileToolStripMenuItem.Text = "Config File";
            configFileToolStripMenuItem.Click += configFileToolStripMenuItem_Click;
            // 
            // taskKillerToolStripMenuItem
            // 
            taskKillerToolStripMenuItem.Font = new Font("Consolas", 9F);
            taskKillerToolStripMenuItem.Name = "taskKillerToolStripMenuItem";
            taskKillerToolStripMenuItem.Size = new Size(89, 20);
            taskKillerToolStripMenuItem.Text = "TaskKiller";
            taskKillerToolStripMenuItem.Click += taskKillerToolStripMenuItem_Click;
            // 
            // BlockProcessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 194);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(textBoxTimer);
            Controls.Add(textBoxProcessName);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 600);
            MinimizeBox = false;
            MinimumSize = new Size(265, 230);
            Name = "BlockProcessForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Block Procces";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProcessName;
        private TextBox textBoxTimer;
        private Button btnStart;
        private Button btnStop;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem taskKillerToolStripMenuItem;
        private ToolStripMenuItem configFileToolStripMenuItem;
    }
}