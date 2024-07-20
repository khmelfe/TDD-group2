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
            Main_page_button = new Button();
            List_books = new Button();
            Main_page = new Panel();
            insert_10k_books1 = new Controls.Insert_10k_books();
            insert_onebook1 = new Controls.Insert_onebook();
            sort_list = new Button();
            Onebook = new Button();
            Books = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            Add_book_button = new Button();
            Top_panel = new Panel();
            Minimize_button = new Button();
            Restore_win_button = new Button();
            Exit_button = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            Background_panel.SuspendLayout();
            Main_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Background_panel
            // 
            Background_panel.BackgroundImageLayout = ImageLayout.None;
            Background_panel.Controls.Add(Main_page_button);
            Background_panel.Controls.Add(List_books);
            Background_panel.Controls.Add(Main_page);
            Background_panel.Controls.Add(sort_list);
            Background_panel.Controls.Add(Onebook);
            Background_panel.Controls.Add(Books);
            Background_panel.Controls.Add(richTextBox2);
            Background_panel.Controls.Add(richTextBox1);
            Background_panel.Controls.Add(pictureBox1);
            Background_panel.Controls.Add(Add_book_button);
            Background_panel.Dock = DockStyle.Fill;
            Background_panel.Location = new Point(0, 0);
            Background_panel.Margin = new Padding(1);
            Background_panel.Name = "Background_panel";
            Background_panel.Size = new Size(1055, 722);
            Background_panel.TabIndex = 0;
            // 
            // Main_page_button
            // 
            Main_page_button.Location = new Point(29, 185);
            Main_page_button.Name = "Main_page_button";
            Main_page_button.Size = new Size(111, 89);
            Main_page_button.TabIndex = 7;
            Main_page_button.Text = "Main_page";
            Main_page_button.UseVisualStyleBackColor = true;
            // 
            // List_books
            // 
            List_books.Location = new Point(29, 621);
            List_books.Name = "List_books";
            List_books.Size = new Size(111, 89);
            List_books.TabIndex = 6;
            List_books.Text = "View Books";
            List_books.UseVisualStyleBackColor = true;
            // 
            // Main_page
            // 
            Main_page.BackColor = Color.Transparent;
            Main_page.Controls.Add(insert_10k_books1);
            Main_page.Controls.Add(insert_onebook1);
            Main_page.Location = new Point(146, 165);
            Main_page.Name = "Main_page";
            Main_page.Size = new Size(909, 557);
            Main_page.TabIndex = 5;
            // 
            // insert_10k_books1
            // 
            insert_10k_books1.Location = new Point(-1, 0);
            insert_10k_books1.Name = "insert_10k_books1";
            insert_10k_books1.Size = new Size(909, 557);
            insert_10k_books1.TabIndex = 1;
            insert_10k_books1.Visible = false;
            insert_10k_books1.Load += insert_10k_books1_Load;
            // 
            // insert_onebook1
            // 
            insert_onebook1.Location = new Point(0, 0);
            insert_onebook1.Name = "insert_onebook1";
            insert_onebook1.Size = new Size(909, 557);
            insert_onebook1.TabIndex = 0;
            insert_onebook1.Visible = false;
            // 
            // sort_list
            // 
            sort_list.Location = new Point(29, 508);
            sort_list.Name = "sort_list";
            sort_list.Size = new Size(111, 89);
            sort_list.TabIndex = 4;
            sort_list.Text = "Sort";
            sort_list.UseVisualStyleBackColor = true;
            // 
            // Onebook
            // 
            Onebook.Location = new Point(29, 290);
            Onebook.Name = "Onebook";
            Onebook.Size = new Size(111, 89);
            Onebook.TabIndex = 3;
            Onebook.Text = "Inset one book";
            Onebook.UseVisualStyleBackColor = true;
            Onebook.Click += Onebook_Click;
            // 
            // Books
            // 
            Books.Location = new Point(29, 395);
            Books.Name = "Books";
            Books.Size = new Size(111, 89);
            Books.TabIndex = 2;
            Books.Text = "Insert 10k books.";
            Books.UseVisualStyleBackColor = true;
            Books.Click += Open_panel_10k;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Black;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox2.ForeColor = Color.White;
            richTextBox2.Location = new Point(367, 115);
            richTextBox2.Margin = new Padding(1);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.RightToLeft = RightToLeft.No;
            richTextBox2.Size = new Size(320, 46);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "Please choose wisely";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Arial Narrow", 25.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(339, 47);
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
            pictureBox1.Size = new Size(1055, 722);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Add_book_button
            // 
            Add_book_button.Location = new Point(-153, 56);
            Add_book_button.Name = "Add_book_button";
            Add_book_button.Size = new Size(907, 556);
            Add_book_button.TabIndex = 24;
            Add_book_button.Visible = false;
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
            Top_panel.Size = new Size(1054, 44);
            Top_panel.TabIndex = 1;
            // 
            // Minimize_button
            // 
            Minimize_button.BackColor = Color.Turquoise;
            Minimize_button.BackgroundImage = (Image)resources.GetObject("Minimize_button.BackgroundImage");
            Minimize_button.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize_button.FlatStyle = FlatStyle.Popup;
            Minimize_button.ForeColor = Color.Transparent;
            Minimize_button.Location = new Point(914, -2);
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
            Restore_win_button.Location = new Point(961, 0);
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
            Exit_button.Location = new Point(1008, -2);
            Exit_button.Margin = new Padding(1);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(45, 45);
            Exit_button.TabIndex = 0;
            Exit_button.UseVisualStyleBackColor = false;
            Exit_button.Click += Exit_button_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 722);
            Controls.Add(Top_panel);
            Controls.Add(Background_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            Name = "Library";
            Text = "Library";
            Background_panel.ResumeLayout(false);
            Main_page.ResumeLayout(false);
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
        private Button sort_list;
        private Button Onebook;
        private Button Books;
        private Panel Main_page;
        private Button List_books;
        private Button Main_page_button;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private Button Add_book_button;
        private Controls.Insert_onebook insert_onebook1;
        private Controls.Insert_10k_books insert_10k_books1;
    }
}

