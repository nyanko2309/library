using library;
using System;
using System.Collections.Generic;
using System.Linq;

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
                        isbn: random.Next(1, 15000).ToString(),
                        bookTitle: Randoms.bookNames[random.Next(Randoms.bookNames.Length)],
                        authorName: Randoms.authors[random.Next(Randoms.authors.Length)],
                        publicationYear: random.Next(1900, 2024),
                        category: Randoms.bookCategories[random.Next(Randoms.bookCategories.Length)],
                        loanStatus: random.Next(2) == 0
                    );

                    books.Add(book);
                }
               


            }
            else
            {
                Console.WriteLine("The library already has 10,000 or more books.");
            }
        }

        // Method to get all books as a List<Book>
        public static List<Book> GetBooks()
        {
            return books;
        }

        // Method to get a book by ISBN
        public static Book GetBookByISBN(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        // Method to delete a book by ISBN
        public static bool DeleteBookByISBN(string isbn)
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
            var existingBook = books.FirstOrDefault(b => b.ISBN == updatedBook.ISBN);
            if (existingBook != null)
            {
                existingBook.BookTitle = updatedBook.BookTitle;
                existingBook.AuthorName = updatedBook.AuthorName;
                existingBook.PublicationYear = updatedBook.PublicationYear;
                existingBook.Category = updatedBook.Category;
                existingBook.LoanStatus = updatedBook.LoanStatus;
               
            }
            else
            { books.Add(updatedBook); }
            
        }

    


public static void Sort()
        {
        }




    }
}

      
