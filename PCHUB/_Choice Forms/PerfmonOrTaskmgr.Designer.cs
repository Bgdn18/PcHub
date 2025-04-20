namespace PCHUB._Choice_Forms
{
    partial class PerfmonOrTaskmgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfmonOrTaskmgr));
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnTaskmgr = new Button();
            btnPerfmon = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(353, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 50);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 14;
            label1.Text = "/";
            // 
            // btnTaskmgr
            // 
            btnTaskmgr.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnTaskmgr.Location = new Point(191, 35);
            btnTaskmgr.Name = "btnTaskmgr";
            btnTaskmgr.Size = new Size(150, 50);
            btnTaskmgr.TabIndex = 13;
            btnTaskmgr.Text = "Taskmgr";
            btnTaskmgr.UseVisualStyleBackColor = true;
            btnTaskmgr.Click += btnTaskmgr_Click;
            // 
            // btnPerfmon
            // 
            btnPerfmon.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            btnPerfmon.Location = new Point(11, 35);
            btnPerfmon.Name = "btnPerfmon";
            btnPerfmon.Size = new Size(150, 50);
            btnPerfmon.TabIndex = 12;
            btnPerfmon.Text = "Resmon";
            btnPerfmon.UseVisualStyleBackColor = true;
            btnPerfmon.Click += btnPerfmon_Click;
            // 
            // PerfmonOrTaskmgr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 97);
            Controls.Add(label1);
            Controls.Add(btnTaskmgr);
            Controls.Add(btnPerfmon);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PerfmonOrTaskmgr";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PerfmonOrTaskmgr";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label label1;
        private Button btnTaskmgr;
        private Button btnPerfmon;
    }
}