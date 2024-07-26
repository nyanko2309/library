using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using BookLibrary; // Ensure this namespace is correct

namespace Tests
{
    [TestClass]
    public class SortTests
    {
        private List<Book> Unsorted = new List<Book>
        {
            new Book(1, "Book A", "Author A", 2000, "Category A", false),
            new Book(2, "Book B", "Author B", 1990, "Category B", true),
            new Book(3, "Book C", "Author C", 2010, "Category C", false),
            new Book(4, "Book D", "Author D", 2005, "Category D", true)
        };

        private List<Book> Sorted = new List<Book>
        {
            new Book(2, "Book B", "Author B", 1990, "Category B", true),
            new Book(1, "Book A", "Author A", 2000, "Category A", false),
            new Book(4, "Book D", "Author D", 2005, "Category D", true),
            new Book(3, "Book C", "Author C", 2010, "Category C", false)
        };

        [TestMethod]
        public void TestQuickSort()
        {
            // Arrange
            var unsortedBooks = new List<Book>(Unsorted);

            // Act
            Dbcode.QuickSort(unsortedBooks, 0, unsortedBooks.Count - 1);

            // Assert
            Assert.IsTrue(AreBooksEqual(Sorted, unsortedBooks), "The books are not sorted correctly by QuickSort.");
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            // Arrange
            var unsortedBooks = new List<Book>(Unsorted);

            // Act
            Dbcode.BubbleSort(unsortedBooks);

            // Assert
            Assert.IsTrue(AreBooksEqual(Sorted, unsortedBooks), "The books are not sorted correctly by BubbleSort.");
        }

        [TestMethod]
        public void TestAveragePublicationYear()
        {
            // Arrange
            var averagePublicationYear = Dbcode.m();
            var expectedAverage = (Unsorted.Sum(b => b.PublicationYear) / (double)Unsorted.Count);

            // Act & Assert
            Assert.AreEqual(expectedAverage, averagePublicationYear, 0.1, "The average publication year is incorrect.");
        }

        private bool AreBooksEqual(List<Book> expected, List<Book> actual)
        {
            if (expected.Count != actual.Count) return false;

            for (int i = 0; i < expected.Count; i++)
            {
                if (!AreBooksEqual(expected[i], actual[i])) return false;
            }
            return true;
        }

        private bool AreBooksEqual(Book book1, Book book2)
        {
            return book1.ISBN == book2.ISBN &&
                   book1.BookTitle == book2.BookTitle &&
                   book1.AuthorName == book2.AuthorName &&
                   book1.PublicationYear == book2.PublicationYear &&
                   book1.Category == book2.Category &&
                   book1.LoanStatus == book2.LoanStatus;
        }
    }
}
