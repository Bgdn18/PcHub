namespace PCHUB
{
    partial class CmdLineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CmdLineForm));
            btnAdd = new Button();
            btnRemove = new Button();
            menuStrip1 = new MenuStrip();
            quitToolStripMenuItem = new ToolStripMenuItem();
            regeditToolStripMenuItem = new ToolStripMenuItem();
            TextBoxCmdLine = new TextBox();
            TextBoxSetupType = new TextBox();
            btnDotDotDot = new Button();
            label1 = new Label();
            label2 = new Label();
            btnOne = new Button();
            btnTwo = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Consolas", 9F);
            btnAdd.Location = new Point(12, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.Font = new Font("Consolas", 9F);
            btnRemove.Location = new Point(372, 116);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 25);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Reset";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitToolStripMenuItem, regeditToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(459, 24);
            menuStrip1.TabIndex = 3;
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
            // regeditToolStripMenuItem
            // 
            regeditToolStripMenuItem.Name = "regeditToolStripMenuItem";
            regeditToolStripMenuItem.Size = new Size(59, 20);
            regeditToolStripMenuItem.Text = "Regedit";
            regeditToolStripMenuItem.Click += regeditToolStripMenuItem_Click;
            // 
            // TextBoxCmdLine
            // 
            TextBoxCmdLine.Location = new Point(12, 32);
            TextBoxCmdLine.Name = "TextBoxCmdLine";
            TextBoxCmdLine.PlaceholderText = "CmdLine";
            TextBoxCmdLine.Size = new Size(379, 23);
            TextBoxCmdLine.TabIndex = 4;
            // 
            // TextBoxSetupType
            // 
            TextBoxSetupType.Location = new Point(12, 74);
            TextBoxSetupType.Name = "TextBoxSetupType";
            TextBoxSetupType.PlaceholderText = "SetupType";
            TextBoxSetupType.Size = new Size(379, 23);
            TextBoxSetupType.TabIndex = 5;
            // 
            // btnDotDotDot
            // 
            btnDotDotDot.Cursor = Cursors.Hand;
            btnDotDotDot.Font = new Font("Consolas", 9F);
            btnDotDotDot.Location = new Point(397, 32);
            btnDotDotDot.Name = "btnDotDotDot";
            btnDotDotDot.Size = new Size(50, 25);
            btnDotDotDot.TabIndex = 6;
            btnDotDotDot.Text = "...";
            btnDotDotDot.UseVisualStyleBackColor = true;
            btnDotDotDot.Click += btnDotDotDot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(55, 13);
            label1.TabIndex = 7;
            label1.Text = "SetupType";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(46, 13);
            label2.TabIndex = 8;
            label2.Text = "CmdLine";
            // 
            // btnOne
            // 
            btnOne.Cursor = Cursors.Hand;
            btnOne.Font = new Font("Consolas", 9F);
            btnOne.Location = new Point(422, 74);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(25, 25);
            btnOne.TabIndex = 9;
            btnOne.Text = "0";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Cursor = Cursors.Hand;
            btnTwo.Font = new Font("Consolas", 9F);
            btnTwo.Location = new Point(397, 74);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(25, 25);
            btnTwo.TabIndex = 10;
            btnTwo.Text = "1";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // CmdLineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 153);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDotDotDot);
            Controls.Add(TextBoxSetupType);
            Controls.Add(TextBoxCmdLine);
            Controls.Add(menuStrip1);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CmdLineForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CmdLine";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem regeditToolStripMenuItem;
        private TextBox TextBoxCmdLine;
        private TextBox TextBoxSetupType;
        private Button btnDotDotDot;
        private Label label1;
        private Label label2;
        private Button btnOne;
        private Button btnTwo;
    }
}