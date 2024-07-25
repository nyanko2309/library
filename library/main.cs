using BookLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace library
{
    public partial class main : Form
    {
        private int currentPage = 0; // Current page index
        private const int BooksPerPage = 500; // Number of books to show per page
        public int? currentBookISBN = null;
        Insert_b f;

        public main()
        {
            f = new Insert_b(this);
            InitializeComponent();
            Dbcode.AddAllBooks();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            Dbcode.Sort();
            DisplayBooks(0);
        }

        private void Main_page_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            currentBookISBN = null;

            f = new Insert_b(this);
            sort.Visible = false;
            panel1.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel1.Controls.Add(f);
            f.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            sort.Visible = true;
            currentPage = 0; // Reset to first page
            DisplayBooks(currentPage);
        }

        private void DisplayBooks(int pageIndex)
        {
            panel1.Controls.Clear(); // Clear any existing controls from the panel
            panel1.AutoScroll = true;

            List<Book> books = Dbcode.GetBooks(); // Get the list of books
            int startIndex = pageIndex * BooksPerPage;
            int endIndex = Math.Min(startIndex + BooksPerPage, books.Count);

            int yPosition = 10; // Initial Y position for the first control

            // Create a button for each book
            for (int i = startIndex; i < endIndex; i++)
            {
                Book book = books[i];

                Button bookButton = new Button
                {
                    Text = $"{i + 1} - {book.BookTitle} by {book.AuthorName} - ({book.PublicationYear})",
                    Tag = book.ISBN, // Store the book's ISBN in the Tag property for later use
                    Location = new Point(10, yPosition),
                    Size = new Size(500, 30)
                };

                bookButton.Click += BookButton_Click;
                panel1.Controls.Add(bookButton);

                yPosition += 40; // Move down for the next button
            }

            // Create and add the "Next" button if there are more books to display
            if (endIndex < books.Count)
            {
                Button nextButton = new Button
                {
                    Text = "Next",
                    Location = new Point(400, yPosition),
                    BackColor = Color.White,
                    Size = new Size(100, 30)
                };
                nextButton.Click += next_Click;
                panel1.Controls.Add(nextButton);
            }

            if (pageIndex > 0)
            {
                Button prevButton = new Button
                {
                    Text = "Previous",
                    Location = new Point(10, yPosition),
                    BackColor = Color.White,
                    Size = new Size(100, 30)
                };
                prevButton.Click += prev_Click;
                panel1.Controls.Add(prevButton);
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            currentPage--;
            DisplayBooks(currentPage);
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentPage++;
            DisplayBooks(currentPage);
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int isbn = (int)clickedButton.Tag;

            Book selectedBook = Dbcode.GetBookByISBN(isbn);

            if (selectedBook != null)
            {
                // Populate the form fields with the selected book's details
                f.name.Text = selectedBook.BookTitle;
                f.author.Text = selectedBook.AuthorName;
                f.Yearlist.SelectedItem = selectedBook.PublicationYear; // Ensure that Yearlist contains this year
                f.category.Text = selectedBook.Category;
                f.checkBox1.Checked = selectedBook.LoanStatus;
                f.checkBox1.Text = f.checkBox1.Checked ? "Taken" : "Available";
                // ISBN send
                currentBookISBN = selectedBook.ISBN;
                // Show the insert form in the panel
                panel1.Controls.Clear();
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                panel1.Controls.Add(f);
                f.Show();
            }
        }
    }
}
