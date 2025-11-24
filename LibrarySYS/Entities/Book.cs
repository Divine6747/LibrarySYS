using LibrarySYS.Enum;
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
        List<Genre> Genre;
        private string Description;


        public Book(string bookID, string isbn, string title, string author, DateTime publication, List<Genre> genre, string description)
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
        public List<Genre> GetGenre() { return Genre; }
        public string GetDescription() { return Description; }


        public void setBookID (string bookID) { this.BookID = bookID; }
        public void SetISBN(string isbn) { this.ISBN = isbn; }
        public void SetTitle(string title) { this.Title = title; }
        public void SetAuthor(string author) { this.Author = author; }
        public void SetPublication(DateTime publication) { this.Publication = publication; }
        public void SetGenre(List<Genre> genre) { this.Genre = genre; }
        public void SetDescription(string description) { this.Description = description; }

        public void AddBook(Book book)
        {
            books.Add(book);

        }

        public void UpdateBook(Book book)
        {

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
