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
            Catogory_select = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Borrowedstatus = new ComboBox();
            Text_book_release = new Custom_textbox();
            Text_Book_author = new Custom_textbox();
            Text_Book_name = new Custom_textbox();
            richTextBox3 = new RichTextBox();
            Add_book_button = new Button();
            Text_ISBN = new Custom_textbox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Catogory_select);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Borrowedstatus);
            panel1.Controls.Add(Text_book_release);
            panel1.Controls.Add(Text_Book_author);
            panel1.Controls.Add(Text_Book_name);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(Add_book_button);
            panel1.Controls.Add(Text_ISBN);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 557);
            panel1.TabIndex = 8;
            // 
            // Catogory_select
            // 
            Catogory_select.DropDownStyle = ComboBoxStyle.DropDownList;
            Catogory_select.Font = new Font("Segoe UI", 12F);
            Catogory_select.ForeColor = SystemColors.HotTrack;
            Catogory_select.FormattingEnabled = true;
            Catogory_select.Items.AddRange(new object[] { "Fantasy", "Historical fiction", "Thriller", "Romance", "Science fiction" });
            Catogory_select.Location = new Point(479, 348);
            Catogory_select.Name = "Catogory_select";
            Catogory_select.Size = new Size(312, 36);
            Catogory_select.TabIndex = 22;
            Catogory_select.SelectedIndexChanged += Catogory_select_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(132, 410);
            label6.Name = "label6";
            label6.Size = new Size(219, 43);
            label6.TabIndex = 21;
            label6.Text = "Is borrowed?";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 348);
            label5.Name = "label5";
            label5.Size = new Size(219, 43);
            label5.TabIndex = 20;
            label5.Text = "Enter Catogory";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 288);
            label4.Name = "label4";
            label4.Size = new Size(219, 43);
            label4.TabIndex = 19;
            label4.Text = "Enter book release";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 229);
            label3.Name = "label3";
            label3.Size = new Size(219, 43);
            label3.TabIndex = 18;
            label3.Text = "enter Book author";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 169);
            label2.Name = "label2";
            label2.Size = new Size(219, 43);
            label2.TabIndex = 17;
            label2.Text = "enter Book name";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 107);
            label1.Name = "label1";
            label1.Size = new Size(219, 43);
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
            Borrowedstatus.Location = new Point(561, 416);
            Borrowedstatus.Name = "Borrowedstatus";
            Borrowedstatus.Size = new Size(147, 36);
            Borrowedstatus.TabIndex = 15;
            Borrowedstatus.SelectedIndexChanged += Borrowedstatus_SelectedIndexChanged;
            // 
            // Text_book_release
            // 
            Text_book_release.BackColor = SystemColors.Window;
            Text_book_release.BorderColor = Color.MediumSlateBlue;
            Text_book_release.BorderFocusColor = Color.Red;
            Text_book_release.Bordersize = 2;
            Text_book_release.Font = new Font("Segoe UI", 12F);
            Text_book_release.ForeColor = Color.DimGray;
            Text_book_release.Location = new Point(479, 282);
            Text_book_release.Multline = false;
            Text_book_release.Name = "Text_book_release";
            Text_book_release.Padding = new Padding(7);
            Text_book_release.PasswordChar = false;
            Text_book_release.Size = new Size(312, 43);
            Text_book_release.TabIndex = 13;
            Text_book_release.Texts = "";
            Text_book_release.UnderlinedStyle = true;
            Text_book_release._TextChanged += Text_book_release__TextChanged;
            // 
            // Text_Book_author
            // 
            Text_Book_author.BackColor = SystemColors.Window;
            Text_Book_author.BorderColor = Color.MediumSlateBlue;
            Text_Book_author.BorderFocusColor = Color.Red;
            Text_Book_author.Bordersize = 2;
            Text_Book_author.Font = new Font("Segoe UI", 12F);
            Text_Book_author.ForeColor = Color.DimGray;
            Text_Book_author.Location = new Point(479, 223);
            Text_Book_author.Multline = false;
            Text_Book_author.Name = "Text_Book_author";
            Text_Book_author.Padding = new Padding(7);
            Text_Book_author.PasswordChar = false;
            Text_Book_author.Size = new Size(312, 43);
            Text_Book_author.TabIndex = 12;
            Text_Book_author.Texts = "";
            Text_Book_author.UnderlinedStyle = true;
            Text_Book_author._TextChanged += Text_Book_author__TextChanged;
            // 
            // Text_Book_name
            // 
            Text_Book_name.BackColor = SystemColors.Window;
            Text_Book_name.BorderColor = Color.MediumSlateBlue;
            Text_Book_name.BorderFocusColor = Color.Red;
            Text_Book_name.Bordersize = 2;
            Text_Book_name.Font = new Font("Segoe UI", 12F);
            Text_Book_name.ForeColor = Color.DimGray;
            Text_Book_name.Location = new Point(479, 163);
            Text_Book_name.Multline = false;
            Text_Book_name.Name = "Text_Book_name";
            Text_Book_name.Padding = new Padding(7);
            Text_Book_name.PasswordChar = false;
            Text_Book_name.Size = new Size(312, 43);
            Text_Book_name.TabIndex = 11;
            Text_Book_name.Texts = "";
            Text_Book_name.UnderlinedStyle = true;
            Text_Book_name._TextChanged += Text_Book_name__TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.White;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Arial Narrow", 20F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox3.ForeColor = Color.Black;
            richTextBox3.Location = new Point(307, 19);
            richTextBox3.Margin = new Padding(1);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.RightToLeft = RightToLeft.No;
            richTextBox3.Size = new Size(177, 45);
            richTextBox3.TabIndex = 10;
            richTextBox3.Text = "Adding a book";
            // 
            // Add_book_button
            // 
            Add_book_button.Location = new Point(307, 479);
            Add_book_button.Name = "Add_book_button";
            Add_book_button.Size = new Size(216, 50);
            Add_book_button.TabIndex = 9;
            Add_book_button.Text = "Add book";
            Add_book_button.UseVisualStyleBackColor = true;
            Add_book_button.Click += Add_book_button_Click;
            // 
            // Text_ISBN
            // 
            Text_ISBN.BackColor = SystemColors.Window;
            Text_ISBN.BorderColor = Color.MediumSlateBlue;
            Text_ISBN.BorderFocusColor = Color.Red;
            Text_ISBN.Bordersize = 2;
            Text_ISBN.Font = new Font("Segoe UI", 12F);
            Text_ISBN.ForeColor = Color.DimGray;
            Text_ISBN.Location = new Point(479, 101);
            Text_ISBN.Multline = false;
            Text_ISBN.Name = "Text_ISBN";
            Text_ISBN.Padding = new Padding(7);
            Text_ISBN.PasswordChar = false;
            Text_ISBN.Size = new Size(312, 43);
            Text_ISBN.TabIndex = 8;
            Text_ISBN.Texts = "";
            Text_ISBN.UnderlinedStyle = true;
            Text_ISBN._TextChanged += Text_ISBN__TextChanged;
            // 
            // Insert_onebook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Insert_onebook";
            Size = new Size(908, 556);
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
