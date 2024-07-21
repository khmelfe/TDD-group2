using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD
{
    public enum Category
    {
        Fantasy,
        Historical_fiction,
        Thriller,
        Romance,
        Science_fiction,
    }

    public class Book
    {
        ///
        ///Fields
        ///
        private int ISBN;
        private string Book_name;
        private string Book_author;
        private int Book_release ;
        private  Category Book_Category;
        private bool IsBorrowed;

        ///
        /// Constrctors,beacuse why not?.
        ///
        private bool IsValid(string title) // will check that the title is only letters.
        {
            // Regex pattern to match only letters,checks if there is at least one letter ,and end to the string,and only english letters.
            var pattern = @"^[A-Za-z\s]+$";
            return Regex.IsMatch(title, pattern);
        }
       
        public Book(int iSBN, string book_name, string book_author, int book_release, Category Book_Category, bool isBorrowed)
        {
            try
            {
                if (iSBN > 0 ) {this.ISBN = iSBN;}
                else
                {  throw new ArgumentOutOfRangeException(nameof(ISBN), "ISBN must be between Postive."); }/*wrong input.*/
                //
                //
                if (IsValid(book_name))// checks if a book is only letters.
                    this.Book_name = book_name;
                else
                {throw new ArgumentException("Books can only be letters,please try again.");}//wrong input.
                //
                //
                if (IsValid(book_author)) { this.Book_author = book_author; }
                else { throw new ArgumentException("Authors can only be letters,please try again."); }
                //
                //

                if(book_release >=1900 && book_release <= 2023) { this.Book_release= book_release; }
                else { throw new ArgumentOutOfRangeException(nameof(Book_release), "Book_release must be between 1900 and 20230,please try again."); }
                //
                //
                this.Book_Category = Book_Category;
                //
                this.IsBorrowed = isBorrowed;
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); // Handle.
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Handle
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message); // Handle anything else.
            }
        }

        public override string ToString() //printing book.
        {
            //return $"{ISBN}: {Book_name} by {Book_author}, {Book_release}, Category: {Book_Category}, Borrowed: {IsBorrowed}";
            return $"ISBN: {ISBN}\nBook Name: {Book_name}\nAuthor: {Book_author}\nRelease Year: {Book_release}\n" +
                   $"Catogory: {Book_Category}\nStatus {IsBorrowed}";
        }

        ///
        /// Getters 
        ///
        public int getISBN() {return this.ISBN;}
        public string getBook_name() { return this.Book_name; }
        public string getBook_author() { return this.Book_author; }
        public int getBook_release() { return this.Book_release; }
        public Category BookCategory
        {
            get { return Book_Category; }
        }
        public bool getIsBorrowed() { return this.IsBorrowed;}
        
    }
}
