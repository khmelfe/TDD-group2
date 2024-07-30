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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;


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

            //loading Bar.
            dataGridView1.Show();
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;



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

            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();
            //Starts the function for sort
            backgroundWorker1.RunWorkerAsync();
           
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //making sort,and checking how much it took.
            DateTime startTime = DateTime.Now;
            booklist.Bubble_Sort();//code to check.
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime;
            MessageBox.Show("Finished Bubble_Sort in :" + elapsed,"\nPlease Wait to the bar to Finish before looking.");
            backgroundWorker1.ReportProgress(0);


            //Loading the list to the view.
            Book[] listbook = booklist.getALL();
            int totalBooks = booklist.getSize();
            for (int i = 0; i < booklist.getSize(); i++)
            {
                int isbn = listbook[i].getISBN();

                int progressPercentage = (i * 100) / totalBooks;
                backgroundWorker1.ReportProgress(progressPercentage);

                Invoke(new Action(() =>
                {
                    //isbnSet.Add(isbn);
                    dataGridView1.Rows.Add(listbook[i].getISBN(), listbook[i].getBook_name(), listbook[i].getBook_author(), listbook[i].getBook_release(),
                        listbook[i].BookCategory.ToString(), listbook[i].getIsBorrowed());
                }));
            }
            backgroundWorker1.ReportProgress(100);// to make it full.
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Finished processing!");

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }
    }
}


