using LibrarySYS.Entities;
using LibrarySYS.Helpers;
using LibrarySYS.Interfaces;
using System;
using System.Collections.Generic;

namespace LibrarySYS.Managers
{
    public class BookManager : IBookManager
    {
        private List<Book> _books;

        public BookManager()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            book.BookId = IdGenerator.GenerateBookId();
            _books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            foreach (Book b in _books)
            {
                if (b.BookId == book.BookId)
                {
                    b.ISBN = book.ISBN;
                    b.Title = book.Title;
                    b.Author = book.Author;
                    b.Publication = book.Publication;
                    b.Genre = book.Genre;
                    b.Description = book.Description;
                    b.IsAvailable = book.IsAvailable;
                    break;
                }
            }
        }

        public void RemoveBook(string bookId)
        {
            foreach (var book in _books)
            {
                if (book.BookId == bookId)
                {
                    _books.Remove(book);
                    break;
                }
            }
        }

        public Book FindBookById(string bookId)
        {
            foreach (Book b in _books)
            {
                if (b.BookId == bookId)
                    return b;
            }
            return null;
        }

        public List<Book> SearchBooksByTitle(string title)
        {
            List<Book> results = new List<Book>();
            foreach (Book b in _books)
            {
                if (!string.IsNullOrWhiteSpace(b.Title) &&
                    b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    results.Add(b);
                }
            }
            return results;
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }
        public void SetAvailability(string bookId, bool value)
        {
            foreach (Book b in _books)
            {
                if (b.BookId == bookId)
                {
                    b.IsAvailable = value;
                    break;
                }
            }
        }
    }
}
