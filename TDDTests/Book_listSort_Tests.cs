using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TDD.Tests
{
    [TestClass()]
    public class Book_listSort_Tests
    {
        [TestMethod()]
        public void Bubble_SortSort_Tests1()//checking if the sort works.
        {
            //Arragne
            Book_list bookstest = new Book_list();
            Book temp = null;

            Book new_book1 = new Book(1, "King of Thorns", "Mark Lawrence", 1905, Category.Science_fiction, true);
            Book new_book2 = new Book(2, "King of Thorns", "Mark Lawrence", 1907, Category.Romance, true);
            Book new_book3 = new Book(3, "My Life in France", "Julia Child", 1908, Category.Romance, true);
            Book new_book4 = new Book(4, "My Life in France", "Julia Child", 1910, Category.Romance, true);

            bookstest.addbook(new_book1);
            bookstest.addbook(new_book2);
            bookstest.addbook(new_book3);
            bookstest.addbook(new_book4);
            Book[] Book_lists = bookstest.getALL();//getting the array of the list

            for (int i = 0; i < bookstest.getSize(); i++)
            {
                for (int j = 0; j < bookstest.getSize() - i - 1; j++)
                {
                    if (Book_lists[j].getBook_release() > Book_lists[j + 1].getBook_release())
                    {
                        temp = Book_lists[j];
                        Book_lists[j] = Book_lists[j + 1];
                        Book_lists[j + 1] = temp;
                    }
                }
            }
            bookstest.setBookList(Book_lists);

            //Act
            //Bubble_SortSort_Tests();

            //assert
            Assert.AreEqual(Book_lists[0], new_book1);
            Assert.AreEqual(Book_lists[3], new_book2);

        }

        [TestMethod()]
        public void Bubble_SortSort_Tests2() //checks first that the list is not empty.
        {
            //Arragne
            Book_list bookstest = new Book_list();
            Book temp = null;


            Book[] Book_lists = bookstest.getALL();//getting the array of the list

            if (Book_lists.Length != 0)
            {
                for (int i = 0; i < bookstest.getSize(); i++)
                {
                    for (int j = 0; j < bookstest.getSize() - i - 1; j++)
                    {
                        if (Book_lists[j].getBook_release() > Book_lists[j + 1].getBook_release())
                        {
                            temp = Book_lists[j];
                            Book_lists[j] = Book_lists[j + 1];
                            Book_lists[j + 1] = temp;
                        }
                    }
                }
                bookstest.setBookList(Book_lists);
            }
            //assert
            Assert.AreEqual(Book_lists.Length, 0);

        }

        [TestMethod()]
        //testing avg releasesort
        public void average_releaseSort_Tests()
        {
            //Arrange
            Book_list bookstest = new Book_list();
            Book[] empty = new Book[0];
            bookstest.setBookList(empty);


            int sum = 0;
            if (bookstest.getSize() > 0)
            {
                for (int i = 0; i < bookstest.getSize(); i++)
                {
                    sum += empty[i].getBook_release();
                }
                //if (sum == 0) { return 0; } //making sure that we won't divive by zero.
                //else { return (sum / bookstest.getSize()); }
            }

            Assert.AreEqual(sum,0);
        }
       
    }
}



