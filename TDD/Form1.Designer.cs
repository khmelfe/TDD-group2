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
            main_page1 = new Controls.Main_page();
            view_books1 = new Controls.View_books();
            Onebook = new Button();
            Books = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            Add_book_button = new Button();
            Top_panel = new Panel();
            Minimize_button = new Button();
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
            Background_panel.Size = new Size(923, 553);
            Background_panel.TabIndex = 0;
            // 
            // Main_page_button
            // 
            Main_page_button.Location = new Point(11, 124);
            Main_page_button.Margin = new Padding(2);
            Main_page_button.Name = "Main_page_button";
            Main_page_button.Size = new Size(97, 67);
            Main_page_button.TabIndex = 7;
            Main_page_button.Text = "Main page";
            Main_page_button.UseVisualStyleBackColor = true;
            Main_page_button.Click += Main_page_button_Click;
            // 
            // List_books
            // 
            List_books.Location = new Point(11, 369);
            List_books.Margin = new Padding(2);
            List_books.Name = "List_books";
            List_books.Size = new Size(97, 67);
            List_books.TabIndex = 6;
            List_books.Text = "Report";
            List_books.UseVisualStyleBackColor = true;
            List_books.Click += List_books_Click;
            // 
            // Main_page
            // 
            Main_page.BackColor = Color.Transparent;
            Main_page.Controls.Add(view_books1);
            Main_page.Controls.Add(insert_10k_books1);
            Main_page.Controls.Add(insert_onebook1);
            Main_page.Controls.Add(main_page1);
            Main_page.Location = new Point(128, 124);
            Main_page.Margin = new Padding(2);
            Main_page.Name = "Main_page";
            Main_page.Size = new Size(784, 418);
            Main_page.TabIndex = 5;
            // 
            // insert_10k_books1
            // 
            insert_10k_books1.Location = new Point(-18, 0);
            insert_10k_books1.Margin = new Padding(5, 4, 5, 4);
            insert_10k_books1.Name = "insert_10k_books1";
            insert_10k_books1.Size = new Size(802, 418);
            insert_10k_books1.TabIndex = 1;
            insert_10k_books1.Visible = false;
            insert_10k_books1.Load += insert_10k_books1_Load;
            // 
            // insert_onebook1
            // 
            insert_onebook1.Location = new Point(-18, 0);
            insert_onebook1.Margin = new Padding(5, 4, 5, 4);
            insert_onebook1.Name = "insert_onebook1";
            insert_onebook1.Size = new Size(802, 418);
            insert_onebook1.TabIndex = 0;
            insert_onebook1.Visible = false;
            insert_onebook1.Load += insert_onebook1_Load;
            // 
            // main_page1
            // 
            main_page1.Location = new Point(-2, 0);
            main_page1.Margin = new Padding(0);
            main_page1.Name = "main_page1";
            main_page1.Size = new Size(786, 418);
            main_page1.TabIndex = 3;
            main_page1.Load += main_page1_Load;
            // 
            // view_books1
            // 
            view_books1.Location = new Point(0, 0);
            view_books1.Margin = new Padding(0);
            view_books1.Name = "view_books1";
            view_books1.Size = new Size(784, 417);
            view_books1.TabIndex = 4;
            // 
            // Onebook
            // 
            Onebook.Location = new Point(11, 207);
            Onebook.Margin = new Padding(2);
            Onebook.Name = "Onebook";
            Onebook.Size = new Size(97, 67);
            Onebook.TabIndex = 3;
            Onebook.Text = "Inset one book";
            Onebook.UseVisualStyleBackColor = true;
            Onebook.Click += Onebook_Click;
            // 
            // Books
            // 
            Books.Location = new Point(11, 288);
            Books.Margin = new Padding(2);
            Books.Name = "Books";
            Books.Size = new Size(97, 67);
            Books.TabIndex = 2;
            Books.Text = "Insert 10k books.";
            Books.UseVisualStyleBackColor = true;
            Books.Click += Open_panel_10k;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Black;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox2.ForeColor = Color.White;
            richTextBox2.Location = new Point(330, 87);
            richTextBox2.Margin = new Padding(1);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.RightToLeft = RightToLeft.No;
            richTextBox2.Size = new Size(197, 30);
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
            richTextBox1.Location = new Point(275, 42);
            richTextBox1.Margin = new Padding(1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(345, 43);
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
            pictureBox1.Size = new Size(923, 553);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Add_book_button
            // 
            Add_book_button.Location = new Point(-134, 42);
            Add_book_button.Margin = new Padding(2);
            Add_book_button.Name = "Add_book_button";
            Add_book_button.Size = new Size(793, 417);
            Add_book_button.TabIndex = 24;
            Add_book_button.Visible = false;
            // 
            // Top_panel
            // 
            Top_panel.BackColor = Color.Black;
            Top_panel.Controls.Add(Minimize_button);
            Top_panel.Controls.Add(Exit_button);
            Top_panel.ForeColor = Color.CornflowerBlue;
            Top_panel.Location = new Point(0, 1);
            Top_panel.Margin = new Padding(1);
            Top_panel.Name = "Top_panel";
            Top_panel.Size = new Size(922, 33);
            Top_panel.TabIndex = 1;
            // 
            // Minimize_button
            // 
            Minimize_button.BackColor = Color.Turquoise;
            Minimize_button.BackgroundImage = (Image)resources.GetObject("Minimize_button.BackgroundImage");
            Minimize_button.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize_button.FlatStyle = FlatStyle.Popup;
            Minimize_button.ForeColor = Color.Transparent;
            Minimize_button.Location = new Point(841, -1);
            Minimize_button.Margin = new Padding(1);
            Minimize_button.Name = "Minimize_button";
            Minimize_button.Size = new Size(40, 34);
            Minimize_button.TabIndex = 2;
            Minimize_button.UseVisualStyleBackColor = false;
            Minimize_button.Click += Minimize_button_Click;
            // 
            // Exit_button
            // 
            Exit_button.BackColor = Color.Transparent;
            Exit_button.BackgroundImage = (Image)resources.GetObject("Exit_button.BackgroundImage");
            Exit_button.BackgroundImageLayout = ImageLayout.Stretch;
            Exit_button.FlatStyle = FlatStyle.Popup;
            Exit_button.Location = new Point(882, -1);
            Exit_button.Margin = new Padding(1);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(40, 34);
            Exit_button.TabIndex = 0;
            Exit_button.UseVisualStyleBackColor = false;
            Exit_button.Click += Exit_button_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(923, 553);
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
        private Button Exit_button;
        private RichTextBox richTextBox2;
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
        private Controls.Main_page main_page1;
        private Controls.View_books view_books1;
    }
}

