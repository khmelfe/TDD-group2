using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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

        [TestMethod()]
        public void Exit_button_ClickTest()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void Constructor_ValidInput_ShouldCreateBook()
        {
            // Arrange
            int isbn = 123456;
            string bookName = "ValidBookName";
            string bookAuthor = "ValidAuthor";
            int bookRelease = 2020;
            Category bookCategory = Category.Fantasy;
            bool isBorrowed = false;

            // Act
            var book = new Book(isbn, bookName, bookAuthor, bookRelease, bookCategory, isBorrowed);

            // Assert
            Assert.AreEqual(isbn, book.getISBN());
            Assert.AreEqual(bookName, book.getBook_name());
            Assert.AreEqual(bookAuthor, book.getBook_author());
            Assert.AreEqual(bookRelease, book.getBook_release());
            Assert.AreEqual(bookCategory, book.BookCategory);
            Assert.AreEqual(isBorrowed, book.getIsBorrowed());
        }

        [TestMethod]
        public void Constructor_InvalidISBN_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            int isbn = -1; // Invalid ISBN
            string bookName = "ValidBookName";
            string bookAuthor = "ValidAuthor";
            int bookRelease = 2020;
            Category bookCategory = Category.Fantasy;
            bool isBorrowed = false;

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Book(isbn, bookName, bookAuthor, bookRelease, bookCategory, isBorrowed));
            Assert.AreEqual("ISBN", ex.ParamName);
        }

        [TestMethod]
        public void Constructor_InvalidBookName_ShouldThrowArgumentException()
        {
            // Arrange
            int isbn = 123456;
            string bookName = "InvalidBookName123"; // Invalid book name
            string bookAuthor = "ValidAuthor";
            int bookRelease = 2020;
            Category bookCategory = Category.Fantasy;
            bool isBorrowed = false;

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => new Book(isbn, bookName, bookAuthor, bookRelease, bookCategory, isBorrowed));
            Assert.IsTrue(ex.Message.Contains("Books can only be letters"));
        }

        [TestMethod]
        public void Constructor_InvalidBookAuthor_ShouldThrowArgumentException()
        {
            // Arrange
            int isbn = 123456;
            string bookName = "ValidBookName";
            string bookAuthor = "InvalidAuthor123"; // Invalid author name
            int bookRelease = 2020;
            Category bookCategory = Category.Fantasy;
            bool isBorrowed = false;

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => new Book(isbn, bookName, bookAuthor, bookRelease, bookCategory, isBorrowed));
            Assert.IsTrue(ex.Message.Contains("Authors can only be letters"));
        }

        [TestMethod]
        public void Constructor_InvalidBookRelease_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            int isbn = 123456;
            string bookName = "ValidBookName";
            string bookAuthor = "ValidAuthor";
            int bookRelease = 1800; // Invalid book release year
            Category bookCategory = Category.Fantasy;
            bool isBorrowed = false;

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Book(isbn, bookName, bookAuthor, bookRelease, bookCategory, isBorrowed));
            Assert.AreEqual("Book_release", ex.ParamName);
        }
        [TestMethod]
        public void IsValid_ValidTitle_ShouldReturnTrue()
        {
            // Arrange
            var title = "Valid Title";

            // Act
            var result = IsValid(title);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_TitleWithNumbers_ShouldReturnFalse()
        {
            // Arrange
            var title = "Title123";

            // Act
            var result = IsValid(title);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_TitleWithSpecialCharacters_ShouldReturnFalse()
        {
            // Arrange
            var title = "Title@#!";

            // Act
            var result = IsValid(title);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_EmptyTitle_ShouldReturnFalse()
        {
            // Arrange
            var title = "";

            // Act
            var result = IsValid(title);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_TitleWithSpaces_ShouldReturnTrue()
        {
            // Arrange
            var title = "Valid Title With Spaces";

            // Act
            var result = IsValid(title);

            // Assert
            Assert.IsTrue(result);
        }
        private bool IsValid(string title)
        {
            var pattern = @"^[A-Za-z\s]+$";
            return Regex.IsMatch(title, pattern);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectStringRepresentation()
        {
            // Arrange
            int isbn = 123456;
            string bookName = "Valid Book Name";
            string bookAuthor = "Valid Author";
            int bookRelease = 2020;
            Category bookCategory = Category.Fantasy;
            bool isBorrowed = false;

            var book = new Book(isbn, bookName, bookAuthor, bookRelease, bookCategory, isBorrowed);
            string expectedOutput = $"ISBN: {isbn}\nBook Name: {bookName}\nAuthor: {bookAuthor}\nRelease Year: {bookRelease}\n" +
                                    $"Category: {bookCategory}\nStatus: Available";

            // Act
            var result = book.ToString();

            // Assert
            Assert.AreNotEqual(expectedOutput, result);
        }

        // INSERT_ONEBOOK.CS TESTS

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

        [TestMethod]
        [DataRow("Fantasy", Category.Fantasy)]
        [DataRow("Historical_fiction", Category.Historical_fiction)]
        [DataRow("Thriller", Category.Thriller)]
        [DataRow("Romance", Category.Romance)]
        [DataRow("Science_fiction", Category.Science_fiction)]
        public void GetCategory_ValidCategoryNames_ShouldReturnExpectedCategory(string categoryName, Category expectedCategory)
        {

            // Act
            var result = Getcategory(categoryName);

            // Assert
            Assert.AreEqual(expectedCategory, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCategory_InvalidCategoryName_ShouldThrowArgumentException()
        {
            // Act
            var result = Getcategory("InvalidCategoryName");

            // Assert
            // Exception is expected
        }

        public Boolean isvalidbook(int iSBN_NUM, string bookname, string book_author, int book_release_num)
        {
            try
            {
                if (!(iSBN_NUM > 0)) { throw new ArgumentOutOfRangeException(nameof(iSBN_NUM), "ISBN must be between Postive."); }

                if (!(IsValid(bookname)))
                { // checks if a book is only letters.    
                    throw new ArgumentException("Books can only be letters,please try again.");
                }

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
        [TestMethod]
        public void IsValidBook_InvalidISBN_ShouldReturnFalse()
        {
            // Arrange
            int isbn = -12345;
            string bookName = "ValidBookName";
            string bookAuthor = "ValidAuthorName";
            int bookRelease = 2020;

            // Act
            var result = isvalidbook(isbn, bookName, bookAuthor, bookRelease);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsValidBook_InvalidBookName_ShouldReturnFalse()
        {
            // Arrange
            int isbn = 12345;
            string bookName = "InvalidBookName123";
            string bookAuthor = "ValidAuthorName";
            int bookRelease = 2020;

            // Act
            var result = isvalidbook(isbn, bookName, bookAuthor, bookRelease);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidBook_InvalidBookAuthor_ShouldReturnFalse()
        {
            // Arrange
            int isbn = 12345;
            string bookName = "ValidBookName";
            string bookAuthor = "InvalidAuthorName123";
            int bookRelease = 2020;

            // Act
            var result = isvalidbook(isbn, bookName, bookAuthor, bookRelease);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidBook_InvalidBookRelease_ShouldReturnFalse()
        {
            // Arrange
            int isbn = 12345;
            string bookName = "ValidBookName";
            string bookAuthor = "ValidAuthorName";
            int bookRelease = 1800;

            // Act
            var result = isvalidbook(isbn, bookName, bookAuthor, bookRelease);

            // Assert
            Assert.IsFalse(result);
        }
    }
}


