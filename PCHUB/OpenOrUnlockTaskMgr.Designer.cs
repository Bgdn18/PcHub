namespace PCHUB
{
    partial class OpenOrUnlockTaskMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenOrUnlockTaskMgr));
            OpenTaskMgr = new Button();
            UnlockTaskMgr = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // OpenTaskMgr
            // 
            OpenTaskMgr.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            OpenTaskMgr.Location = new Point(12, 12);
            OpenTaskMgr.Name = "OpenTaskMgr";
            OpenTaskMgr.Size = new Size(150, 50);
            OpenTaskMgr.TabIndex = 0;
            OpenTaskMgr.Text = "Open";
            OpenTaskMgr.UseVisualStyleBackColor = true;
            OpenTaskMgr.Click += OpenTaskMgr_Click;
            // 
            // UnlockTaskMgr
            // 
            UnlockTaskMgr.Font = new Font("Consolas", 11.25F, FontStyle.Bold);
            UnlockTaskMgr.Location = new Point(192, 12);
            UnlockTaskMgr.Name = "UnlockTaskMgr";
            UnlockTaskMgr.Size = new Size(150, 50);
            UnlockTaskMgr.TabIndex = 1;
            UnlockTaskMgr.Text = "Unlock";
            UnlockTaskMgr.UseVisualStyleBackColor = true;
            UnlockTaskMgr.Click += UnlockTaskMgr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 2;
            label1.Text = "/";
            // 
            // OpenOrUnlockTaskMgr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 78);
            Controls.Add(label1);
            Controls.Add(UnlockTaskMgr);
            Controls.Add(OpenTaskMgr);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OpenOrUnlockTaskMgr";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Open/Unlock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenTaskMgr;
        private Button UnlockTaskMgr;
        private Label label1;
    }
}