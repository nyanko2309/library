using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System;

namespace BookLibrary
{
    public class Book
    {
        private string isbn;
        private string bookTitle;
        private string authorName;
        private int publicationYear;
        private string category;
        private bool loanStatus;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }

        public int PublicationYear
        {
            get { return publicationYear; }
            set
            {
                if (value > 0)
                {
                    publicationYear = value;
                }
                else
                {
                    throw new ArgumentException("Publication year must be a positive number.");
                }
            }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public bool LoanStatus
        {
            get { return loanStatus; }
            set { loanStatus = value; }
        }

        public Book(string isbn, string bookTitle, string authorName, int publicationYear, string category, bool loanStatus)
        {
            ISBN = isbn;
            BookTitle = bookTitle;
            AuthorName = authorName;
            PublicationYear = publicationYear;
            Category = category;
            LoanStatus = loanStatus;
        }

        public void PrintBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"שם הספר: {BookTitle}");
            Console.WriteLine($"שם המחבר: {AuthorName}");
            Console.WriteLine($"שנת פרסום: {PublicationYear}");
            Console.WriteLine($"קטגוריה: {Category}");
            Console.WriteLine($"סטטוס השאלה: {(LoanStatus ? "מושאל" : "זמין")}");
        }
    }

}