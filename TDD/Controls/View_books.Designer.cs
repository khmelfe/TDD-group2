namespace TDD.Controls
{
    partial class View_books
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
            richTextBox4 = new RichTextBox();
            dataGridView1 = new DataGridView();
            ISBN_Column = new DataGridViewTextBoxColumn();
            Book_name_Column = new DataGridViewTextBoxColumn();
            Book_Author_Column = new DataGridViewTextBoxColumn();
            Book_release_Column = new DataGridViewTextBoxColumn();
            Category_Column = new DataGridViewTextBoxColumn();
            Isborrowed_colum = new DataGridViewTextBoxColumn();
            Showlist = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.White;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Arial Narrow", 20F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox4.ForeColor = Color.Black;
            richTextBox4.Location = new Point(624, 95);
            richTextBox4.Margin = new Padding(2);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.RightToLeft = RightToLeft.No;
            richTextBox4.Size = new Size(321, 92);
            richTextBox4.TabIndex = 12;
            richTextBox4.Text = "View_books";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ISBN_Column, Book_name_Column, Book_Author_Column, Book_release_Column, Category_Column, Isborrowed_colum });
            dataGridView1.Location = new Point(68, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(1605, 750);
            dataGridView1.TabIndex = 13;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ISBN_Column
            // 
            ISBN_Column.HeaderText = "ISBN";
            ISBN_Column.MinimumWidth = 12;
            ISBN_Column.Name = "ISBN_Column";
            ISBN_Column.Width = 250;
            // 
            // Book_name_Column
            // 
            Book_name_Column.HeaderText = "Book_Name";
            Book_name_Column.MinimumWidth = 12;
            Book_name_Column.Name = "Book_name_Column";
            Book_name_Column.Width = 250;
            // 
            // Book_Author_Column
            // 
            Book_Author_Column.HeaderText = "Book_Author";
            Book_Author_Column.MinimumWidth = 12;
            Book_Author_Column.Name = "Book_Author_Column";
            Book_Author_Column.Width = 250;
            // 
            // Book_release_Column
            // 
            Book_release_Column.HeaderText = "Book_release";
            Book_release_Column.MinimumWidth = 12;
            Book_release_Column.Name = "Book_release_Column";
            Book_release_Column.Width = 250;
            // 
            // Category_Column
            // 
            Category_Column.HeaderText = "Category";
            Category_Column.MinimumWidth = 12;
            Category_Column.Name = "Category_Column";
            Category_Column.Width = 250;
            // 
            // Isborrowed_colum
            // 
            Isborrowed_colum.HeaderText = "Isborrowed";
            Isborrowed_colum.MinimumWidth = 12;
            Isborrowed_colum.Name = "Isborrowed_colum";
            Isborrowed_colum.Width = 250;
            // 
            // Showlist
            // 
            Showlist.Location = new Point(703, 1000);
            Showlist.Name = "Showlist";
            Showlist.Size = new Size(188, 58);
            Showlist.TabIndex = 14;
            Showlist.Text = "Showlist";
            Showlist.UseVisualStyleBackColor = true;
            Showlist.Click += Showlist_Click;
            // 
            // View_books
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Showlist);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox4);
            Name = "View_books";
            Size = new Size(1932, 1142);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ISBN_Column;
        private DataGridViewTextBoxColumn Book_name_Column;
        private DataGridViewTextBoxColumn Book_Author_Column;
        private DataGridViewTextBoxColumn Book_release_Column;
        private DataGridViewTextBoxColumn Category_Column;
        private DataGridViewTextBoxColumn Isborrowed_colum;
        private Button Showlist;
    }
}
