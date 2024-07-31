namespace TDD.Controls
{
    partial class Insert_10k_books
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
            insert_10k = new Panel();
            Random_books = new Button();
            richTextBox5 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            insert_10k.SuspendLayout();
            SuspendLayout();
            // 
            // insert_10k
            // 
            insert_10k.Controls.Add(Random_books);
            insert_10k.Controls.Add(richTextBox5);
            insert_10k.Controls.Add(richTextBox4);
            insert_10k.Dock = DockStyle.Fill;
            insert_10k.Location = new Point(0, 0);
            insert_10k.Margin = new Padding(3, 2, 3, 2);
            insert_10k.Name = "insert_10k";
            insert_10k.Size = new Size(794, 417);
            insert_10k.TabIndex = 24;
            // 
            // Random_books
            // 
            Random_books.Location = new Point(248, 308);
            Random_books.Margin = new Padding(3, 2, 3, 2);
            Random_books.Name = "Random_books";
            Random_books.Size = new Size(217, 67);
            Random_books.TabIndex = 13;
            Random_books.Text = "Random books";
            Random_books.UseVisualStyleBackColor = true;
            Random_books.Click += Random_books_Click;
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.White;
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Arial Narrow", 20F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox5.ForeColor = Color.Black;
            richTextBox5.Location = new Point(146, 93);
            richTextBox5.Margin = new Padding(1);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.RightToLeft = RightToLeft.No;
            richTextBox5.Size = new Size(484, 194);
            richTextBox5.TabIndex = 12;
            richTextBox5.Text = "The button below...it scares Computers from the old generation..\nplease, for the sake of the Cpu!\nUse this button lightly...\nOr else..\nSuffer the consequences";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.White;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Arial Narrow", 20F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox4.ForeColor = Color.Black;
            richTextBox4.Location = new Point(248, 28);
            richTextBox4.Margin = new Padding(1);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.RightToLeft = RightToLeft.No;
            richTextBox4.Size = new Size(224, 34);
            richTextBox4.TabIndex = 11;
            richTextBox4.Text = "Inserting 10k Books";
            // 
            // Insert_10k_books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(insert_10k);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Insert_10k_books";
            Size = new Size(794, 417);
            insert_10k.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel insert_10k;
        private Button Random_books;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
    }
}
