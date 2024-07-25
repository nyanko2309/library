using DocumentFormat.OpenXml.Office2010.ExcelAc;
using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookLibrary
{
    public static class Dbcode
    {
        // Create a list to hold the books
        private static List<Book> books = new List<Book>();

        // Method to add books to the list
        public static void AddAllBooks()
        {
            var random = new Random();

            // Check if the number of books is less than 10,000
            if (books.Count <= 10000)
            {
                // Calculate how many more books are needed
                int booksToAdd = 10000 - books.Count;

                for (int i = 0; i < booksToAdd; i++)
                {
                    var book = new Book(
                        isbn: random.Next(1, 15000),
                        bookTitle: Randoms.bookNames[random.Next(Randoms.bookNames.Length)],
                        authorName: Randoms.authors[random.Next(Randoms.authors.Length)],
                        publicationYear: random.Next(1900, 2024),
                        category: Randoms.bookCategories[random.Next(Randoms.bookCategories.Length)],
                        loanStatus: random.Next(2) == 0
                    );

                    while (Newr(book.ISBN))
                    {
                        book.ISBN = random.Next(1, 15000);
                    }
                    books.Add(book);
                }
            }
            else
            {
                Console.WriteLine("The library already has 10,000 or more books.");
            }
        }

        public static bool Newr(int isbn)
        {
            foreach (var book in books)
            {
                if (book.ISBN == isbn)
                    return true;
            }
            return false;
        }

        // Method to get all books as a List<Book>
        public static List<Book> GetBooks()
        {
            return books;
        }

        // Method to get a book by ISBN
        public static Book GetBookByISBN(int isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        // Method to delete a book by ISBN
        public static bool DeleteBookByISBN(int isbn)
        {
            var bookToRemove = books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                return true;
            }
            return false;
        }

        // Method to update a book's details
        public static void UpdateBook(Book updatedBook)
        {
            Book existingBook = books.FirstOrDefault(b => b.ISBN == updatedBook.ISBN);

            if (existingBook != null)
            {
                MessageBox.Show("Updating book: " + updatedBook.ISBN);

                // Update existing book details
                existingBook.BookTitle = updatedBook.BookTitle;
                existingBook.AuthorName = updatedBook.AuthorName;
                existingBook.PublicationYear = updatedBook.PublicationYear;
                existingBook.Category = updatedBook.Category;
                existingBook.LoanStatus = updatedBook.LoanStatus;
            }
            else
            {
                // If the book doesn't exist, add it to the list
                books.Add(updatedBook);
                MessageBox.Show("Added new book. Total books: " + books.Count);
            }
        }

        // Method to sort books by publication year
        public static void Sort()
        {
            DateTime startTime = DateTime.Now;
            QuickSort(books, 0, books.Count - 1);
            DateTime endTime = DateTime.Now;

            // Calculate the elapsed time
            TimeSpan elapsed = endTime - startTime;
            MessageBox.Show($"Sorting completed in {elapsed.TotalMilliseconds} milliseconds.", "Sort Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void QuickSort(List<Book> list, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(list, low, high);
                QuickSort(list, low, pi - 1);
                QuickSort(list, pi + 1, high);
            }
        }

        private static int Partition(List<Book> list, int low, int high)
        {
            Book pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j].PublicationYear <= pivot.PublicationYear)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }

        private static void Swap(List<Book> list, int i, int j)
        {
            Book temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
