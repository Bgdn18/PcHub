namespace PCHUB._Main
{
    partial class UtilManForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilManForm));
            btnAdd = new Button();
            btnOff = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            system32ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Consolas", 9F);
            btnAdd.Location = new Point(12, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add PCHub";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnOff
            // 
            btnOff.Cursor = Cursors.Hand;
            btnOff.Font = new Font("Consolas", 9F);
            btnOff.Location = new Point(118, 27);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(100, 50);
            btnOff.TabIndex = 1;
            btnOff.Text = "Reset utilman";
            btnOff.UseVisualStyleBackColor = true;
            btnOff.Click += btnOff_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, system32ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(226, 24);
            menuStrip1.TabIndex = 2;
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
            // system32ToolStripMenuItem
            // 
            system32ToolStripMenuItem.Name = "system32ToolStripMenuItem";
            system32ToolStripMenuItem.Size = new Size(69, 20);
            system32ToolStripMenuItem.Text = "System32";
            system32ToolStripMenuItem.Click += system32ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 3;
            label1.Text = "Works only with compilation\r\n to self-contained";
            // 
            // UtilManForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 119);
            Controls.Add(label1);
            Controls.Add(btnOff);
            Controls.Add(btnAdd);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UtilManForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UtilMan";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnOff;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem system32ToolStripMenuItem;
        private Label label1;
    }
}