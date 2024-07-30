using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace TDD.Controls
{

    public partial class Insert_10k_books : UserControl
    {
        Book_list booklist = GlobalBookList.BookList;
        public Insert_10k_books()
        {
            InitializeComponent();
        }

        public void Random_books_Click(object sender, EventArgs e)
        {
            
            //Isbn,name_book,name_author,book_release,catagory,status.
            Random ISbn_num = new Random();
            Random name_book = new Random();
            Random name_auth = new Random();
            Random book_release = new Random();
            Random catagory = new Random();
            Random status_book = new Random();

            string[] book_names = { "King of Thorns", "My Life in France", "Savage Inequalities Children in Americas Schools", "Torment", "Hymns of The Church of Jesus Christ of Latter day Saints" };
            string[] book_auth = { "Mark Lawrence", "Julia Child ", "Alex Prud homme", "Jonathan Kozol", "Lauren Kate" };

            int counter = 0;
            for (; counter < 10000; counter++)
            {
   
                while (counter < 10000)
                {
                    bool flag_same_isbn = false;
                    Book[] list_show = booklist.getALL();
                    int size_booklist = booklist.getSize();
                    int Isbn = ISbn_num.Next(1, 20000);
                    if (list_show.Length > 0)
                    {
                        for (int j = 0; j < size_booklist; j++)
                        {
                            if (list_show[j].getISBN() == Isbn)
                            {
                                flag_same_isbn = true;
                                break;//to exit the for loop,and restart the while.
                            }
                        }
                    }
                    if (!flag_same_isbn)
                    {
                        counter++;
                        string getBookName = book_names[name_book.Next(book_names.Length)];
                        string getBookAuth = book_auth[name_auth.Next(book_names.Length)];
                        Category catego = (Category)Enum.GetValues(typeof(Category)).GetValue(catagory.Next(Enum.GetValues(typeof(Category)).Length));
                        int status = status_book.Next(2);
                        bool selectedOption = (status == 0) ? true : false; //random between borrowed or not.
                        int book_year = book_release.Next(1900, 2023);//random numbers.

                        Book newbook = new Book(Isbn, getBookName, getBookAuth, book_year, catego, selectedOption);
                        booklist.addbook(newbook);
                    }

                }

            }
            if (!checkrandom(booklist))
                MessageBox.Show("Failed to randomisze,please try again");
            else
            {
                int size_lists = booklist.getSize();
                MessageBox.Show("Success in making random,Book_list size is: " + size_lists);
            }
            }

        private bool checkrandom(Book_list booklist)
        {
            Book[] list_show = booklist.getALL();
            for (int i = 0; i < list_show.Length; i++)
            {
                if (list_show[i] == null) { return false; }
            }
            return true;
        }
    }
}
//Book[] list_show = booklist.getALL();

//for (int i = 0; i < booklist.getSize(); i++)
//{
//    if (list_show[i] != null)
//    {
//        //info
//        //MessageBox.Show(list_show[i].ToString(), "Book Details:", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
