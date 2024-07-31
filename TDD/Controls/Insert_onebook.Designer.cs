namespace TDD.Controls
{
    partial class Insert_onebook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Text_book_release = new Custom_textbox();
            Text_Book_author = new Custom_textbox();
            Text_Book_name = new Custom_textbox();
            Text_ISBN = new Custom_textbox();
            Catogory_select = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Borrowedstatus = new ComboBox();
            richTextBox3 = new RichTextBox();
            Add_book_button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Text_book_release);
            panel1.Controls.Add(Text_Book_author);
            panel1.Controls.Add(Text_Book_name);
            panel1.Controls.Add(Text_ISBN);
            panel1.Controls.Add(Catogory_select);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Borrowedstatus);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(Add_book_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 417);
            panel1.TabIndex = 8;
            // 
            // Text_book_release
            // 
            Text_book_release.BackColor = SystemColors.Window;
            Text_book_release.BorderColor = Color.MediumSlateBlue;
            Text_book_release.BorderFocusColor = Color.HotPink;
            Text_book_release.Bordersize = 2;
            Text_book_release.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Text_book_release.ForeColor = Color.DimGray;
            Text_book_release.Location = new Point(396, 216);
            Text_book_release.Multline = false;
            Text_book_release.Name = "Text_book_release";
            Text_book_release.Padding = new Padding(7);
            Text_book_release.PasswordChar = false;
            Text_book_release.Size = new Size(273, 40);
            Text_book_release.TabIndex = 26;
            Text_book_release.Texts = "";
            Text_book_release.UnderlinedStyle = false;
            // 
            // Text_Book_author
            // 
            Text_Book_author.BackColor = SystemColors.Window;
            Text_Book_author.BorderColor = Color.MediumSlateBlue;
            Text_Book_author.BorderFocusColor = Color.HotPink;
            Text_Book_author.Bordersize = 2;
            Text_Book_author.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Text_Book_author.ForeColor = Color.DimGray;
            Text_Book_author.Location = new Point(396, 172);
            Text_Book_author.Multline = false;
            Text_Book_author.Name = "Text_Book_author";
            Text_Book_author.Padding = new Padding(7);
            Text_Book_author.PasswordChar = false;
            Text_Book_author.Size = new Size(273, 40);
            Text_Book_author.TabIndex = 25;
            Text_Book_author.Texts = "";
            Text_Book_author.UnderlinedStyle = false;
            // 
            // Text_Book_name
            // 
            Text_Book_name.BackColor = SystemColors.Window;
            Text_Book_name.BorderColor = Color.MediumSlateBlue;
            Text_Book_name.BorderFocusColor = Color.HotPink;
            Text_Book_name.Bordersize = 2;
            Text_Book_name.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Text_Book_name.ForeColor = Color.DimGray;
            Text_Book_name.Location = new Point(396, 127);
            Text_Book_name.Multline = false;
            Text_Book_name.Name = "Text_Book_name";
            Text_Book_name.Padding = new Padding(7);
            Text_Book_name.PasswordChar = false;
            Text_Book_name.Size = new Size(273, 40);
            Text_Book_name.TabIndex = 24;
            Text_Book_name.Texts = "";
            Text_Book_name.UnderlinedStyle = false;
            // 
            // Text_ISBN
            // 
            Text_ISBN.BackColor = SystemColors.Window;
            Text_ISBN.BorderColor = Color.MediumSlateBlue;
            Text_ISBN.BorderFocusColor = Color.HotPink;
            Text_ISBN.Bordersize = 2;
            Text_ISBN.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Text_ISBN.ForeColor = Color.DimGray;
            Text_ISBN.Location = new Point(396, 80);
            Text_ISBN.Multline = false;
            Text_ISBN.Name = "Text_ISBN";
            Text_ISBN.Padding = new Padding(7);
            Text_ISBN.PasswordChar = false;
            Text_ISBN.Size = new Size(273, 40);
            Text_ISBN.TabIndex = 23;
            Text_ISBN.Texts = "";
            Text_ISBN.UnderlinedStyle = false;
            // 
            // Catogory_select
            // 
            Catogory_select.DropDownStyle = ComboBoxStyle.DropDownList;
            Catogory_select.Font = new Font("Segoe UI", 12F);
            Catogory_select.ForeColor = SystemColors.HotTrack;
            Catogory_select.FormattingEnabled = true;
            Catogory_select.Items.AddRange(new object[] { "Fantasy", "Historical fiction", "Thriller", "Romance", "Science fiction" });
            Catogory_select.Location = new Point(396, 264);
            Catogory_select.Margin = new Padding(2);
            Catogory_select.Name = "Catogory_select";
            Catogory_select.Size = new Size(273, 29);
            Catogory_select.TabIndex = 22;
            Catogory_select.SelectedIndexChanged += Catogory_select_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 307);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 32);
            label6.TabIndex = 21;
            label6.Text = "Is borrowed?";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 261);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(191, 32);
            label5.TabIndex = 20;
            label5.Text = "Enter Catogory";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 216);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(191, 32);
            label4.TabIndex = 19;
            label4.Text = "Enter book release";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 172);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 18;
            label3.Text = "enter Book author";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 127);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 17;
            label2.Text = "enter Book name";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 16;
            label1.Text = "enter ISBN";
            // 
            // Borrowedstatus
            // 
            Borrowedstatus.BackColor = SystemColors.Window;
            Borrowedstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            Borrowedstatus.Font = new Font("Segoe UI", 12F);
            Borrowedstatus.ForeColor = SystemColors.HotTrack;
            Borrowedstatus.FormattingEnabled = true;
            Borrowedstatus.Items.AddRange(new object[] { "Yes", "No" });
            Borrowedstatus.Location = new Point(456, 307);
            Borrowedstatus.Margin = new Padding(2);
            Borrowedstatus.Name = "Borrowedstatus";
            Borrowedstatus.Size = new Size(129, 29);
            Borrowedstatus.TabIndex = 15;
            Borrowedstatus.SelectedIndexChanged += Borrowedstatus_SelectedIndexChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.White;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Arial Narrow", 20F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox3.ForeColor = Color.Black;
            richTextBox3.Location = new Point(268, 14);
            richTextBox3.Margin = new Padding(1);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.RightToLeft = RightToLeft.No;
            richTextBox3.Size = new Size(166, 34);
            richTextBox3.TabIndex = 10;
            richTextBox3.Text = "Adding a book";
            // 
            // Add_book_button
            // 
            Add_book_button.Location = new Point(268, 359);
            Add_book_button.Margin = new Padding(2);
            Add_book_button.Name = "Add_book_button";
            Add_book_button.Size = new Size(189, 37);
            Add_book_button.TabIndex = 9;
            Add_book_button.Text = "Add book";
            Add_book_button.UseVisualStyleBackColor = true;
            Add_book_button.Click += Add_book_button_Click;
            // 
            // Insert_onebook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Insert_onebook";
            Size = new Size(795, 417);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox Catogory_select;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox Borrowedstatus;
        private Custom_textbox Text_book_release;
        private Custom_textbox Text_Book_author;
        private Custom_textbox Text_Book_name;
        private RichTextBox richTextBox3;
        private Button Add_book_button;
        private Custom_textbox Text_ISBN;
       
    }
}
