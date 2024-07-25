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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            richTextBox4 = new RichTextBox();
            dataGridView1 = new DataGridView();
            ISBN_Column = new DataGridViewTextBoxColumn();
            Book_release_Column = new DataGridViewTextBoxColumn();
            Isborrowed_colum = new DataGridViewTextBoxColumn();
            Book_name_Column = new DataGridViewTextBoxColumn();
            Book_Author_Column = new DataGridViewTextBoxColumn();
            Category_Column = new DataGridViewTextBoxColumn();
            Showlist = new Button();
            Sort = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.White;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Arial Narrow", 20F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox4.ForeColor = Color.Black;
            richTextBox4.Location = new Point(324, 28);
            richTextBox4.Margin = new Padding(1);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.RightToLeft = RightToLeft.No;
            richTextBox4.Size = new Size(151, 45);
            richTextBox4.TabIndex = 12;
            richTextBox4.Text = "View_books";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ISBN_Column, Book_release_Column, Isborrowed_colum, Book_name_Column, Book_Author_Column, Category_Column });
            dataGridView1.Location = new Point(13, 93);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(853, 378);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ISBN_Column
            // 
            ISBN_Column.HeaderText = "ISBN";
            ISBN_Column.MinimumWidth = 12;
            ISBN_Column.Name = "ISBN_Column";
            ISBN_Column.ReadOnly = true;
            ISBN_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            ISBN_Column.Width = 128;
            // 
            // Book_release_Column
            // 
            Book_release_Column.HeaderText = "Book_release";
            Book_release_Column.MinimumWidth = 12;
            Book_release_Column.Name = "Book_release_Column";
            Book_release_Column.ReadOnly = true;
            Book_release_Column.SortMode = DataGridViewColumnSortMode.Programmatic;
            Book_release_Column.Width = 140;
            // 
            // Isborrowed_colum
            // 
            Isborrowed_colum.HeaderText = "Isborrowed";
            Isborrowed_colum.MinimumWidth = 12;
            Isborrowed_colum.Name = "Isborrowed_colum";
            Isborrowed_colum.ReadOnly = true;
            Isborrowed_colum.SortMode = DataGridViewColumnSortMode.Programmatic;
            Isborrowed_colum.Width = 132;
            // 
            // Book_name_Column
            // 
            Book_name_Column.HeaderText = "Book_Name";
            Book_name_Column.MinimumWidth = 12;
            Book_name_Column.Name = "Book_name_Column";
            Book_name_Column.ReadOnly = true;
            Book_name_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            Book_name_Column.Width = 150;
            // 
            // Book_Author_Column
            // 
            Book_Author_Column.HeaderText = "Book_Author";
            Book_Author_Column.MinimumWidth = 12;
            Book_Author_Column.Name = "Book_Author_Column";
            Book_Author_Column.ReadOnly = true;
            Book_Author_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            Book_Author_Column.Width = 150;
            // 
            // Category_Column
            // 
            Category_Column.HeaderText = "Category";
            Category_Column.MinimumWidth = 12;
            Category_Column.Name = "Category_Column";
            Category_Column.ReadOnly = true;
            Category_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            Category_Column.Width = 150;
            // 
            // Showlist
            // 
            Showlist.Location = new Point(34, 496);
            Showlist.Margin = new Padding(1);
            Showlist.Name = "Showlist";
            Showlist.Size = new Size(88, 28);
            Showlist.TabIndex = 14;
            Showlist.Text = "Showlist";
            Showlist.UseVisualStyleBackColor = true;
            Showlist.Click += Showlist_Click;
            // 
            // Sort
            // 
            Sort.Location = new Point(136, 496);
            Sort.Margin = new Padding(1);
            Sort.Name = "Sort";
            Sort.Size = new Size(131, 28);
            Sort.TabIndex = 15;
            Sort.Text = "Sort and show.";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 496);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(171, 28);
            button2.TabIndex = 16;
            button2.Text = "Average book release";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Average_book_relese;
            // 
            // button3
            // 
            button3.Location = new Point(462, 496);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(137, 28);
            button3.TabIndex = 17;
            button3.Text = "Amout of books";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(618, 496);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(137, 28);
            button4.TabIndex = 18;
            button4.Text = "Amount Avalible";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // View_books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Sort);
            Controls.Add(Showlist);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox4);
            Margin = new Padding(1);
            Name = "View_books";
            Size = new Size(909, 557);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox4;
        private DataGridView dataGridView1;
        private Button Showlist;
        private Button Sort;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn ISBN_Column;
        private DataGridViewTextBoxColumn Book_release_Column;
        private DataGridViewTextBoxColumn Isborrowed_colum;
        private DataGridViewTextBoxColumn Book_name_Column;
        private DataGridViewTextBoxColumn Book_Author_Column;
        private DataGridViewTextBoxColumn Category_Column;
    }
}
