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
            Showlist = new Button();
            Sort = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ISBN_Column = new DataGridViewTextBoxColumn();
            Book_release_Column = new DataGridViewTextBoxColumn();
            Isborrowed_colum = new DataGridViewTextBoxColumn();
            Book_name_Column = new DataGridViewTextBoxColumn();
            Book_Author_Column = new DataGridViewTextBoxColumn();
            Category_Column = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.White;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Arial Narrow", 20F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox4.ForeColor = Color.Black;
            richTextBox4.Location = new Point(688, 57);
            richTextBox4.Margin = new Padding(2, 2, 2, 2);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.RightToLeft = RightToLeft.No;
            richTextBox4.Size = new Size(321, 92);
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
            dataGridView1.Location = new Point(28, 191);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
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
            dataGridView1.Size = new Size(1813, 775);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Showlist
            // 
            Showlist.Location = new Point(72, 1017);
            Showlist.Margin = new Padding(2, 2, 2, 2);
            Showlist.Name = "Showlist";
            Showlist.Size = new Size(187, 57);
            Showlist.TabIndex = 14;
            Showlist.Text = "Showlist";
            Showlist.UseVisualStyleBackColor = true;
            Showlist.Click += Showlist_Click;
            // 
            // Sort
            // 
            Sort.Location = new Point(289, 1017);
            Sort.Margin = new Padding(2, 2, 2, 2);
            Sort.Name = "Sort";
            Sort.Size = new Size(278, 57);
            Sort.TabIndex = 15;
            Sort.Text = "Sort and show.";
            Sort.UseVisualStyleBackColor = true;
            Sort.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(595, 1017);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(363, 57);
            button2.TabIndex = 16;
            button2.Text = "Average book release";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Average_book_relese;
            // 
            // button3
            // 
            button3.Location = new Point(982, 1017);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(291, 57);
            button3.TabIndex = 17;
            button3.Text = "Amout of books";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1313, 1017);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(291, 57);
            button4.TabIndex = 18;
            button4.Text = "Amount Avalible";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1538, 123);
            progressBar1.Margin = new Padding(6, 6, 6, 6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(266, 59);
            progressBar1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1538, 57);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 41);
            label1.TabIndex = 20;
            label1.Text = "Loading bar";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork_1;
            // 
            // ISBN_Column
            // 
            ISBN_Column.HeaderText = "ISBN";
            ISBN_Column.MinimumWidth = 12;
            ISBN_Column.Name = "ISBN_Column";
            ISBN_Column.ReadOnly = true;
            ISBN_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            ISBN_Column.Width = 260;
            // 
            // Book_release_Column
            // 
            Book_release_Column.HeaderText = "Book_release";
            Book_release_Column.MinimumWidth = 12;
            Book_release_Column.Name = "Book_release_Column";
            Book_release_Column.ReadOnly = true;
            Book_release_Column.SortMode = DataGridViewColumnSortMode.Programmatic;
            Book_release_Column.Width = 250;
            // 
            // Isborrowed_colum
            // 
            Isborrowed_colum.HeaderText = "Isborrowed";
            Isborrowed_colum.MinimumWidth = 12;
            Isborrowed_colum.Name = "Isborrowed_colum";
            Isborrowed_colum.ReadOnly = true;
            Isborrowed_colum.SortMode = DataGridViewColumnSortMode.Programmatic;
            Isborrowed_colum.Width = 200;
            // 
            // Book_name_Column
            // 
            Book_name_Column.HeaderText = "Book_Name";
            Book_name_Column.MinimumWidth = 12;
            Book_name_Column.Name = "Book_name_Column";
            Book_name_Column.ReadOnly = true;
            Book_name_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            Book_name_Column.Width = 400;
            // 
            // Book_Author_Column
            // 
            Book_Author_Column.HeaderText = "Book_Author";
            Book_Author_Column.MinimumWidth = 12;
            Book_Author_Column.Name = "Book_Author_Column";
            Book_Author_Column.ReadOnly = true;
            Book_Author_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            Book_Author_Column.Width = 300;
            // 
            // Category_Column
            // 
            Category_Column.HeaderText = "Category";
            Category_Column.MinimumWidth = 12;
            Category_Column.Name = "Category_Column";
            Category_Column.ReadOnly = true;
            Category_Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            Category_Column.Width = 400;
            // 
            // View_books
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Sort);
            Controls.Add(Showlist);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox4);
            Margin = new Padding(2, 2, 2, 2);
            Name = "View_books";
            Size = new Size(1932, 1142);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox4;
        private DataGridView dataGridView1;
        private Button Showlist;
        private Button Sort;
        private Button button2;
        private Button button3;
        private Button button4;
        private ProgressBar progressBar1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn ISBN_Column;
        private DataGridViewTextBoxColumn Book_release_Column;
        private DataGridViewTextBoxColumn Isborrowed_colum;
        private DataGridViewTextBoxColumn Book_name_Column;
        private DataGridViewTextBoxColumn Book_Author_Column;
        private DataGridViewTextBoxColumn Category_Column;
    }
}
