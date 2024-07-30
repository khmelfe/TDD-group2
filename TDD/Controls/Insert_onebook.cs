using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public void Add_book_button_Click(object sender, EventArgs e)
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

                if (isvalidbook(ISBN_NUM, Bookname, Book_author, book_release_num))
                {
                    
                    Book new_book = new Book(ISBN_NUM, Bookname, Book_author, book_release_num, name, Borrowed);
                    {
                        booklist.addbook(new_book);//adding to the list.
                        string message = $"ISBN: {ISBN_NUM}\nBook Name: {Bookname}\nAuthor: {Book_author}\nRelease Year: {book_release_num}\n" +
                            $"Catogory: {selectedCatogory}\nStatus {selectedstaus}";//getting all the things.
                        MessageBox.Show(message, "Book Details:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Clearing the fiels.
                        Text_ISBN.Texts = "";
                        Text_Book_name.Texts = "";
                        Text_Book_author.Texts = "";
                        Text_book_release.Texts = "";
                        Catogory_select.SelectedIndex = -1;
                        Borrowedstatus.SelectedIndex = -1;
                    }

                }        
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

        private Boolean isvalidbook(int iSBN_NUM, string bookname, string book_author, int book_release_num)
        {
            try { 
            if (!(iSBN_NUM > 0)) { throw new ArgumentOutOfRangeException(nameof(iSBN_NUM), "ISBN must be between Postive."); }

            if (!(IsValid(bookname))){ // checks if a book is only letters.    
                   throw new ArgumentException("Books can only be letters,please try again."); }
           
            if (!(IsValid(book_author))) { throw new ArgumentException("Authors can only be letters,please try again."); }
          
            if (!(book_release_num >= 1900 && book_release_num <= 2023)) { throw new ArgumentOutOfRangeException(nameof(book_release_num), "Book_release must be between 1900 and 20230,please try again."); }
           
            return true;
            }

            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;// Handle.
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; // Handle
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Handle anything else.
                return false; 
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

        public bool IsValid(string title) // will check that the title is only letters.
        {
            // Regex pattern to match only letters,checks if there is at least one letter ,and end to the string,and only english letters.
            var pattern = @"^[A-Za-z\s]+$";
            return Regex.IsMatch(title, pattern);
        }

    }
}
