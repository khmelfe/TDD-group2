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
    public partial class Insert_onebook : UserControl
    {
        private Book_list booklist = GlobalBookList.BookList; //getting the same book list.


        public Insert_onebook()
        {
            InitializeComponent();
            

        }


        private void Text_ISBN__TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Book_name__TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Book_author__TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_book_release__TextChanged(object sender, EventArgs e)
        {

        }

        private void Catogory_select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Borrowedstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Add_book_button_Click(object sender, EventArgs e)
        {

            try
            {
                //ISBN,Book_name,Book_AUTHOR,book_release,Catgorybook,isborrowed.
                string ISBN = Text_ISBN.Texts;
                string Bookname = Text_Book_name.Texts;
                string Book_author = Text_Book_author.Texts;
                string book_release = Text_book_release.Texts;
                string selectedCatogory = Catogory_select.GetItemText(Catogory_select.SelectedItem);
                string selectedstaus = Borrowedstatus.GetItemText(Borrowedstatus.SelectedItem);
                bool Borrowed = true;

                if (Catogory_select.SelectedItem == null)//making sure the user selected a Catogory.
                {
                    MessageBox.Show("Please select a Catogory select.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Borrowedstatus.SelectedItem == null)//making sure the user selected a statues
                {
                    MessageBox.Show("Please select a Borrowed status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Borrowedstatus.SelectedItem == "Yes")
                {
                    Borrowed = true;
                }
                else { Borrowed = false; }
                //parse throw excptions!.
                int book_release_num = int.Parse(book_release);
                int ISBN_NUM = int.Parse(ISBN);

                Category name = Getcategory(selectedCatogory);


                Book new_book = new Book(ISBN_NUM, Bookname, Book_author, book_release_num, name, Borrowed);
                booklist.addbook(new_book);//adding to the list.
                string message = $"ISBN: {ISBN_NUM}\nBook Name: {Bookname}\nAuthor: {Book_author}\nRelease Year: {book_release_num}\n" +
                    $"Catogory: {selectedCatogory}\nStatus {selectedstaus}";//getting all the things.
                MessageBox.Show(message, "Book Details:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                // Show a message box with the exception message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("please check Book release number and ISBN number and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("please check Book release number and ISBN number and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("please check Book release number and ISBN number and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static Category Getcategory(string name)
        {
            switch (name)
            {
                case "Fantasy":
                    return Category.Fantasy;
                case "Historical_fiction":
                    return Category.Historical_fiction;
                case "Thriller":
                    return Category.Thriller;
                case "Romance":
                    return Category.Romance;
                case "Science_fiction":
                    return Category.Science_fiction;
            }
            return Category.Fantasy;//default value.
        }
     
    }
}
