namespace PCHUB.About
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            ABOUTTEXT = new Label();
            BuildLabel = new Label();
            label2 = new Label();
            TelegrammChannel = new PictureBox();
            GitHub = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TelegrammChannel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GitHub).BeginInit();
            SuspendLayout();
            // 
            // ABOUTTEXT
            // 
            ABOUTTEXT.AutoSize = true;
            ABOUTTEXT.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ABOUTTEXT.ForeColor = Color.Black;
            ABOUTTEXT.Location = new Point(12, 9);
            ABOUTTEXT.Name = "ABOUTTEXT";
            ABOUTTEXT.Size = new Size(245, 56);
            ABOUTTEXT.TabIndex = 0;
            ABOUTTEXT.Text = "Сделано Bgdn18\r\nСделал для ввостановления системы.\r\nИсходные файлы программы доступны\r\nНа GitHub.";
            // 
            // BuildLabel
            // 
            BuildLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BuildLabel.AutoSize = true;
            BuildLabel.BackColor = Color.Gray;
            BuildLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BuildLabel.ForeColor = Color.White;
            BuildLabel.Location = new Point(12, 179);
            BuildLabel.Name = "BuildLabel";
            BuildLabel.Size = new Size(94, 20);
            BuildLabel.TabIndex = 2;
            BuildLabel.Text = "Version: null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(356, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 4;
            label2.Text = "PCHUB";
            label2.Click += PCHUBlabel_Click;
            // 
            // TelegrammChannel
            // 
            TelegrammChannel.Cursor = Cursors.Hand;
            TelegrammChannel.Image = Properties.Resources.telegramm_icon;
            TelegrammChannel.Location = new Point(395, 149);
            TelegrammChannel.Name = "TelegrammChannel";
            TelegrammChannel.Size = new Size(50, 50);
            TelegrammChannel.SizeMode = PictureBoxSizeMode.Zoom;
            TelegrammChannel.TabIndex = 6;
            TelegrammChannel.TabStop = false;
            TelegrammChannel.Click += TelegrammChannel_Click;
            // 
            // GitHub
            // 
            GitHub.AccessibleDescription = "";
            GitHub.AccessibleName = "";
            GitHub.Cursor = Cursors.Hand;
            GitHub.Image = Properties.Resources.github;
            GitHub.Location = new Point(339, 149);
            GitHub.Name = "GitHub";
            GitHub.Size = new Size(50, 50);
            GitHub.SizeMode = PictureBoxSizeMode.Zoom;
            GitHub.TabIndex = 7;
            GitHub.TabStop = false;
            GitHub.Click += GitHub_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(454, 211);
            Controls.Add(GitHub);
            Controls.Add(TelegrammChannel);
            Controls.Add(label2);
            Controls.Add(BuildLabel);
            Controls.Add(ABOUTTEXT);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About PcHub";
            ((System.ComponentModel.ISupportInitialize)TelegrammChannel).EndInit();
            ((System.ComponentModel.ISupportInitialize)GitHub).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ABOUTTEXT;
        private Label BuildLabel;
        private Label label2;
        private PictureBox TelegrammChannel;
        private PictureBox GitHub;
    }
}