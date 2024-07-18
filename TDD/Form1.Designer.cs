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
            pictureBox1 = new PictureBox();
            Top_panel = new Panel();
            richTextBox1 = new RichTextBox();
            Exit_button = new Button();
            Restore_win_button = new Button();
            Minimize_button = new Button();
            Background_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Background_panel
            // 
            Background_panel.BackgroundImageLayout = ImageLayout.None;
            Background_panel.Controls.Add(richTextBox1);
            Background_panel.Controls.Add(pictureBox1);
            Background_panel.Dock = DockStyle.Fill;
            Background_panel.Location = new Point(0, 0);
            Background_panel.Name = "Background_panel";
            Background_panel.Size = new Size(1823, 1068);
            Background_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1823, 1068);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Top_panel
            // 
            Top_panel.BackColor = Color.Black;
            Top_panel.Controls.Add(Minimize_button);
            Top_panel.Controls.Add(Restore_win_button);
            Top_panel.Controls.Add(Exit_button);
            Top_panel.Location = new Point(0, 2);
            Top_panel.Name = "Top_panel";
            Top_panel.Size = new Size(1820, 78);
            Top_panel.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(305, 96);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1195, 113);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Exit_button
            // 
            Exit_button.BackColor = Color.Transparent;
            Exit_button.BackgroundImageLayout = ImageLayout.Stretch;
            Exit_button.FlatStyle = FlatStyle.Popup;
            Exit_button.Image = (Image)resources.GetObject("Exit_button.Image");
            Exit_button.Location = new Point(1727, -2);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(96, 80);
            Exit_button.TabIndex = 0;
            Exit_button.UseVisualStyleBackColor = false;
            // 
            // Restore_win_button
            // 
            Restore_win_button.BackColor = Color.Transparent;
            Restore_win_button.BackgroundImageLayout = ImageLayout.Stretch;
            Restore_win_button.FlatStyle = FlatStyle.Popup;
            Restore_win_button.Image = (Image)resources.GetObject("Restore_win_button.Image");
            Restore_win_button.Location = new Point(1631, 1);
            Restore_win_button.Name = "Restore_win_button";
            Restore_win_button.Size = new Size(96, 77);
            Restore_win_button.TabIndex = 1;
            Restore_win_button.UseVisualStyleBackColor = false;
            // 
            // Minimize_button
            // 
            Minimize_button.Location = new Point(1535, 3);
            Minimize_button.Name = "Minimize_button";
            Minimize_button.Size = new Size(96, 75);
            Minimize_button.TabIndex = 2;
            Minimize_button.UseVisualStyleBackColor = true;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1823, 1068);
            Controls.Add(Top_panel);
            Controls.Add(Background_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}

