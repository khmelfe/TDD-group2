using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Book_list
    {
        ///
        /// Fields
        ///
        private int size_list;
        private Book[] book_list;
        ///
        /// Constrctors.
        ///
        public Book_list()
        {
            this.size_list = 0;
            this.book_list = new Book[size_list];
        }
        /// <summary>
        /// Methods.
        /// </summary>

        public void addbook(Book book)
        {
            
                for (int i = 0; i < size_list; i++)
                {

                    if (book_list[i].getISBN() == book.getISBN())
                    {
                        throw new InvalidOperationException("The book you try to add is already in the library\n.please enter new ISBN");

                    }
                }
                if (book_list.Length == size_list)//take down if, because it always true.
                { resize_list();
                }
                book_list[size_list] = book;
                size_list++;
          
        }
       
        public void resize_list()
        {
            int newsize = book_list.Length + 1;
            Book[] templist = new Book[newsize];
            Array.Copy(book_list, templist, book_list.Length);//making a  copy of books.
            this.book_list = templist;
        }
        public double average_release()//getting the average of the book releasese.
        {
            int sum = 0;
            for(int i = 0; i < size_list; i++)
            {
                sum += book_list[i].getBook_release();
            }
            if(sum == 0) { return 0; } //making sure that we won't divive by zero.
            else { return (sum / size_list); }
            
        }
        public int amount_avalible()
        {
            int amount_avalible = 0;
            for (int i = 0; i < size_list; i++)
                if (!(book_list[i].getIsBorrowed()))
                    amount_avalible = amount_avalible + 1;
            return amount_avalible;
        }
        
        /// <summary>
        /// getters !.
        /// </summary>
        ///
        public Book[] getALL()//to get all books, without fear of editing the current book list.
        {
            Book[] allofthem = new Book[this.size_list];
            Array.Copy(book_list, allofthem, size_list);
            return allofthem;
        } 
        
        public int getSize()
        {
            return this.size_list;
        }
        public void setBookList(Book[] newlist)
        {
            this.book_list=newlist;
        }

        
        public void Bubble_Sort()
        {

            //ver 1.4 //fixing logic.
            Book temp = null;

            if (this.book_list.Length != 0)
            {
                for (int i = 0; i < this.book_list.Length; i++)
                {
                    for (int j = 0; j < this.book_list.Length - i - 1; j++)
                    {
                        if (this.book_list[j].getBook_release() > this.book_list[j+1].getBook_release())
                        {
                            temp = this.book_list[j];
                            this.book_list[j] = this.book_list[j + 1];
                            this.book_list[j + 1] = temp;
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Book list is empty..");
            }


            //last ver 1.3, fixed the sort itself(didn't work),added a check to see first if the booklist isn't empthy.
            //Book temp = null;
            //if (this.book_list.Length != 0)
            //{
            //    for (int i = 0; i < this.book_list.Length; i++)
            //    {
            //        for (int j = 0; j < this.book_list.Length - i - 1; j++)
            //        {
            //            if (this.book_list[j].getBook_release() > this.book_list[j].getBook_release())
            //            {
            //                temp = this.book_list[j];
            //                this.book_list[j] = this.book_list[j + 1];
            //                this.book_list[j + 1] = temp;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Book list is empty..");
            //}

            //Wrong tries
            //for (int i = 0; i < bookstest.getSize() - 1; i++)
            //{
            //    for (int j = 0; j < bookstest.getSize() - 1 - i; j++)
            //    {
            //        if (Book_lists[j].getBook_release() > Book_lists[j + 1].getBook_release())
            //        {
            //            temp = Book_lists[j];
            //            Book_lists[j] = Book_lists[j + 1];
            //            Book_lists[j + 1] = temp;
            //        }
            //    }
            //}



            //for (int i = 0; i < bookstest.getSize(); i++)
            //{
            //    for (int j = 0; j < bookstest.getSize() - i - 1; j++)
            //    {
            //        if (Book_lists[j].getBook_release() > Book_lists[j + 1].getBook_release())
            //        {
            //            temp = Book_lists[j];
            //            Book_lists[j] = Book_lists[j + 1];
            //            Book_lists[j + 1] = temp;
            //        }
            //    }
            //}
        }


    }
}
