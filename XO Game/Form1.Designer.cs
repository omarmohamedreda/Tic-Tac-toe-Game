namespace XO_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(378, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(165, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // A1
            // 
            A1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A1.Location = new Point(30, 55);
            A1.Name = "A1";
            A1.Size = new Size(100, 90);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            // 
            // A2
            // 
            A2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A2.Location = new Point(136, 55);
            A2.Name = "A2";
            A2.Size = new Size(100, 90);
            A2.TabIndex = 2;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            // 
            // A3
            // 
            A3.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A3.Location = new Point(242, 55);
            A3.Name = "A3";
            A3.Size = new Size(100, 90);
            A3.TabIndex = 3;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            // 
            // B1
            // 
            B1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B1.Location = new Point(30, 151);
            B1.Name = "B1";
            B1.Size = new Size(100, 90);
            B1.TabIndex = 4;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_click;
            // 
            // B2
            // 
            B2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B2.Location = new Point(136, 151);
            B2.Name = "B2";
            B2.Size = new Size(100, 90);
            B2.TabIndex = 5;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_click;
            // 
            // B3
            // 
            B3.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B3.Location = new Point(242, 151);
            B3.Name = "B3";
            B3.Size = new Size(100, 90);
            B3.TabIndex = 6;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_click;
            // 
            // C1
            // 
            C1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            C1.Location = new Point(30, 247);
            C1.Name = "C1";
            C1.Size = new Size(100, 90);
            C1.TabIndex = 7;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_click;
            // 
            // C2
            // 
            C2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            C2.Location = new Point(136, 247);
            C2.Name = "C2";
            C2.Size = new Size(100, 90);
            C2.TabIndex = 8;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_click;
            // 
            // C3
            // 
            C3.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            C3.Location = new Point(242, 247);
            C3.Name = "C3";
            C3.Size = new Size(100, 90);
            C3.TabIndex = 9;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 358);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "XO Game";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
    }
}
