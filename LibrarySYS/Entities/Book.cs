using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    class Book : IbookManager
    {
        // test add
        private static List<Book> books = new List<Book>();
        private string BookID;
        private string ISBN;
        private string Title;
        private string Author;
        private DateTime Publication;
        private string Genre;
        private string Description;


        public Book(string bookID, string isbn, string title, string author, DateTime publication, string genre, string description)
        {
            this.BookID = bookID;
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
            this.Publication = publication;
            this.Genre = genre;
            this.Description = description;

        }


        public string GetBookID() { return BookID; }
        public string GetISBN() { return ISBN; }
        public string GetTitle() { return Title; }
        public string GetAuthor() { return Author; }
        public DateTime GetPublication() { return Publication; }
        public string GetGenre() { return Genre; }
        public string GetDescription() { return Description; }


        public void setBookID(string bookID) { this.BookID = bookID; }
        public void SetISBN(string isbn) { this.ISBN = isbn; }
        public void SetTitle(string title) { this.Title = title; }
        public void SetAuthor(string author) { this.Author = author; }
        public void SetPublication(DateTime publication) { this.Publication = publication; }
        public void SetGenre(string genre) { this.Genre = genre; }
        public void SetDescription(string description) { this.Description = description; }

        public void AddBook(Book book)
        {

        }

        public void UpdateBook(Book book)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].BookID == book.BookID)
                {
                    books[i].SetISBN(book.ISBN);
                    books[i].SetTitle(book.Title);
                    books[i].SetAuthor(book.Author);
                    books[i].SetPublication(book.Publication);
                    books[i].SetGenre(book.Genre);
                    books[i].SetDescription(book.Description);
                    break;
                }
            }
        }

        public void RemoveBook(Book book)
        {

        }

        public void FindBookById(Book book)
        {

        }

        public List<Book> SearchByTitle(String tile)
        {
            return books;
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }



    }
}
