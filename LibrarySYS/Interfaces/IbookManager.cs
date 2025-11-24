using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    interface IbookManager
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void RemoveBook(Book book);
        void FindBookById(Book book);
        List<Book> SearchByTitle(String tile);

        List<Book> GetAllBooks();






    }
}