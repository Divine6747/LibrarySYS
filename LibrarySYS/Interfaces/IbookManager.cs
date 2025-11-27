using LibrarySYS.Entities;
using System.Collections.Generic;

namespace LibrarySYS.Interfaces
{
    interface IBookManager
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void RemoveBook(string bookId);
        Book FindBookById(string bookId);
        List<Book> SearchBooksByTitle(string tile);
        List<Book> GetAllBooks();
        void SetAvailability(string bookId, bool value);
    }
}