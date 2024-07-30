using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;
using TDD.Controls;

namespace TDD.Tests
{
    [TestClass()]


    public class Insert10kBooksTests
    {
        private Insert_10k_books insert10kBooks;

        [TestInitialize]
        public void TestInitialize()
        {
            insert10kBooks = new Insert_10k_books();
            GlobalBookList.BookList = new Book_list();
        }



        [TestMethod]
        public void AddSingleBookManually()
        {
            // Arrange
            var initialCount = GlobalBookList.BookList.getSize();
            var newBook = new Book(1, "Test Book", "Test Author", 2023, Category.Romance, true);

            // Act
            GlobalBookList.BookList.addbook(newBook);

            // Assert
            var finalCount = GlobalBookList.BookList.getSize();
            Assert.AreEqual(initialCount + 1, finalCount, $"Expected {initialCount + 1} book, but found {finalCount}");
        }

        [TestMethod]
        public void Random_books_Click_AddsUniqueISBNs()
        {
            // Act
            insert10kBooks.Random_books_Click(null, EventArgs.Empty);

            // Assert
            var allBooks = GlobalBookList.BookList.getALL();
            var uniqueISBNs = new HashSet<int>();
            foreach (var book in allBooks)
            {
                Assert.IsTrue(uniqueISBNs.Add(book.getISBN()), "Duplicate ISBN found");
            }
        }

        [TestMethod]
        public void Random_books_Click_AddsValidBooks()
        {
            // Act
            insert10kBooks.Random_books_Click(null, EventArgs.Empty);

            // Assert
            var allBooks = GlobalBookList.BookList.getALL();
            foreach (var book in allBooks)
            {
                Assert.IsNotNull(book);
                Assert.IsTrue(book.getISBN() > 0 && book.getISBN() < 20000);
                Assert.IsFalse(string.IsNullOrEmpty(book.getBook_name()));
                Assert.IsFalse(string.IsNullOrEmpty(book.getBook_author()));
                Assert.IsTrue(book.getBook_release() >= 1900 && book.getBook_release() <= 2023);
                Assert.IsTrue(Enum.IsDefined(typeof(Category), book.BookCategory));
            }
        }

        [TestMethod]
        public void CheckRandom_ReturnsTrue_ForValidBookList()
        {
            // Arrange
            insert10kBooks.Random_books_Click(null, EventArgs.Empty);

            // Act
            var checkRandomMethod = insert10kBooks.GetType().GetMethod("checkrandom", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var result = checkRandomMethod?.Invoke(insert10kBooks, new object[] { GlobalBookList.BookList });

            // Assert
            Assert.IsTrue((bool?)result);
        }
    }
}
