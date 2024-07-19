namespace TDD
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            Background_panel = new Panel();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            Top_panel = new Panel();
            Minimize_button = new Button();
            Restore_win_button = new Button();
            Exit_button = new Button();
            richTextBox2 = new RichTextBox();
            Background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Background_panel
            // 
            Background_panel.BackgroundImageLayout = ImageLayout.None;
            Background_panel.Controls.Add(richTextBox2);
            Background_panel.Controls.Add(richTextBox1);
            Background_panel.Controls.Add(pictureBox1);
            Background_panel.Dock = DockStyle.Fill;
            Background_panel.Location = new Point(0, 0);
            Background_panel.Margin = new Padding(1);
            Background_panel.Name = "Background_panel";
            Background_panel.Size = new Size(858, 521);
            Background_panel.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Arial Narrow", 25.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(223, 56);
            richTextBox1.Margin = new Padding(1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(395, 57);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Welcome to the library";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(858, 521);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Top_panel
            // 
            Top_panel.BackColor = Color.Black;
            Top_panel.Controls.Add(Minimize_button);
            Top_panel.Controls.Add(Restore_win_button);
            Top_panel.Controls.Add(Exit_button);
            Top_panel.ForeColor = Color.CornflowerBlue;
            Top_panel.Location = new Point(0, 1);
            Top_panel.Margin = new Padding(1);
            Top_panel.Name = "Top_panel";
            Top_panel.Size = new Size(856, 44);
            Top_panel.TabIndex = 1;
            // 
            // Minimize_button
            // 
            Minimize_button.BackColor = Color.Turquoise;
            Minimize_button.BackgroundImage = (Image)resources.GetObject("Minimize_button.BackgroundImage");
            Minimize_button.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize_button.FlatStyle = FlatStyle.Popup;
            Minimize_button.ForeColor = Color.Transparent;
            Minimize_button.Location = new Point(722, -1);
            Minimize_button.Margin = new Padding(1);
            Minimize_button.Name = "Minimize_button";
            Minimize_button.Size = new Size(45, 45);
            Minimize_button.TabIndex = 2;
            Minimize_button.UseVisualStyleBackColor = false;
            // 
            // Restore_win_button
            // 
            Restore_win_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Restore_win_button.BackColor = Color.White;
            Restore_win_button.BackgroundImage = (Image)resources.GetObject("Restore_win_button.BackgroundImage");
            Restore_win_button.BackgroundImageLayout = ImageLayout.Zoom;
            Restore_win_button.FlatAppearance.BorderSize = 0;
            Restore_win_button.FlatStyle = FlatStyle.Popup;
            Restore_win_button.ImageAlign = ContentAlignment.TopCenter;
            Restore_win_button.Location = new Point(768, -1);
            Restore_win_button.Margin = new Padding(1);
            Restore_win_button.Name = "Restore_win_button";
            Restore_win_button.Size = new Size(45, 45);
            Restore_win_button.TabIndex = 1;
            Restore_win_button.TextAlign = ContentAlignment.MiddleRight;
            Restore_win_button.UseVisualStyleBackColor = false;
            // 
            // Exit_button
            // 
            Exit_button.BackColor = Color.Transparent;
            Exit_button.BackgroundImage = (Image)resources.GetObject("Exit_button.BackgroundImage");
            Exit_button.BackgroundImageLayout = ImageLayout.Stretch;
            Exit_button.FlatStyle = FlatStyle.Popup;
            Exit_button.Location = new Point(813, -1);
            Exit_button.Margin = new Padding(1);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(45, 45);
            Exit_button.TabIndex = 0;
            Exit_button.UseVisualStyleBackColor = false;
            Exit_button.Click += Exit_button_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Black;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox2.ForeColor = Color.White;
            richTextBox2.Location = new Point(256, 115);
            richTextBox2.Margin = new Padding(1);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.RightToLeft = RightToLeft.No;
            richTextBox2.Size = new Size(320, 46);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "Please choose wisely";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 521);
            Controls.Add(Top_panel);
            Controls.Add(Background_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "Library";
            Text = "Library";
            Background_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Top_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Background_panel;
        private PictureBox pictureBox1;
        private Panel Top_panel;
        private RichTextBox richTextBox1;
        private Button Minimize_button;
        private Button Restore_win_button;
        private Button Exit_button;
        private RichTextBox richTextBox2;
    }
}

