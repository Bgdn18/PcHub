namespace PCHUB
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            ABOUTTEXT = new Label();
            BuildLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ABOUTTEXT
            // 
            ABOUTTEXT.AutoSize = true;
            ABOUTTEXT.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ABOUTTEXT.ForeColor = Color.FromArgb(64, 0, 64);
            ABOUTTEXT.Location = new Point(12, 9);
            ABOUTTEXT.Name = "ABOUTTEXT";
            ABOUTTEXT.Size = new Size(306, 19);
            ABOUTTEXT.TabIndex = 0;
            ABOUTTEXT.Text = "Сделано \"Bogodan\" для Nedohackers";
            // 
            // BuildLabel
            // 
            BuildLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(12, 182);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(35, 20);
            BuildLabel.TabIndex = 2;
            BuildLabel.Text = "null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Consolas", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(369, 9);
            label2.Name = "label2";
            label2.Size = new Size(207, 75);
            label2.TabIndex = 4;
            label2.Text = "PCHUB";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(427, 188);
            label1.Name = "label1";
            label1.Size = new Size(154, 14);
            label1.TabIndex = 5;
            label1.Text = "Все права не защищены";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(588, 211);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(BuildLabel);
            Controls.Add(ABOUTTEXT);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ABOUTTEXT;
        private Label BuildLabel;
        private Label label2;
        private Label label1;
    }
}