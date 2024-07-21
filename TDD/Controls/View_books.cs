using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.Controls
{
    public partial class View_books : UserControl
    {
        private Book_list booklist = GlobalBookList.BookList; //getting the same book list.
        HashSet<int> isbnSet = new HashSet<int>(); //a set that will check if isbn is there.

        public View_books()
        {
            InitializeComponent();
            dataGridView1.Show();
        }


        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Showlist_Click(object sender, EventArgs e)
        {

            
            Book[] listbook = booklist.getALL();
            for (int i = 0; i < booklist.getSize(); i++)
            {
                int isbn = listbook[i].getISBN();
                if (!isbnSet.Contains(isbn))
                {
                    isbnSet.Add(isbn);
                    dataGridView1.Rows.Add(listbook[i].getISBN(), listbook[i].getBook_name(), listbook[i].getBook_author(), listbook[i].getBook_release(),
                        listbook[i].BookCategory.ToString(), listbook[i].getIsBorrowed());
                }
        }
            
        }
    }
}
