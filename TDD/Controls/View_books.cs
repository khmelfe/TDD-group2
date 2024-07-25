using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDD.Controls
{
    public partial class View_books : UserControl
    {
        private Book_list booklist = GlobalBookList.BookList; //getting the same book list.
        HashSet<int> isbnSet = new HashSet<int>(); //a set that will check if isbn is there.
        bool islist_open = false;//making sure that the list will be updated if we adding more books.

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

        private void button3_Click(object sender, EventArgs e)
        {
            int size = booklist.getSize();
            MessageBox.Show("Amount of Books: " + size);
        }

        private void Average_book_relese(object sender, EventArgs e)
        {
            double avg = booklist.average_release();
            MessageBox.Show("Average of books relesase is: " + avg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int avalible = booklist.amount_avalible();
            MessageBox.Show("Amount of avalible books is: " + avalible);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                //making sort,and checking how much it took.
                DateTime startTime = DateTime.Now;
                booklist.Bubble_Sort();//code to check.
                DateTime endTime = DateTime.Now;
                TimeSpan elapsed = endTime - startTime;
                MessageBox.Show("Finished Bubble_Sort in :" + elapsed);


                //Loading the list to the view.
                Book[] listbook = booklist.getALL();
                for (int i = 0; i < booklist.getSize(); i++)
                {
                    int isbn = listbook[i].getISBN();
                    
                        //isbnSet.Add(isbn);
                        dataGridView1.Rows.Add(listbook[i].getISBN(), listbook[i].getBook_name(), listbook[i].getBook_author(), listbook[i].getBook_release(),
                            listbook[i].BookCategory.ToString(), listbook[i].getIsBorrowed());
                    
                }
        }
    }
}


