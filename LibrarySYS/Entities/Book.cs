using System;
using LibrarySYS.Enums;

namespace LibrarySYS.Entities
{
    public class Book
    {
        private string _bookId;
        private string _isbn;
        private string _title;
        private string _author;
        private DateTime _publication;
        private Genre _genre;
        private string _description;
        private bool _isAvailable;

        public string BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public DateTime Publication
        {
            get { return _publication; }
            set { _publication = value; }
        }

        public Genre Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        public Book(string bookId, string isbn, string title, string author, DateTime publication, Genre genre, string description, bool isAvailable)
        {
            _bookId = bookId;
            _isbn = isbn;
            _title = title;
            _author = author;
            _publication = publication;
            _genre = genre;
            _description = description;
            _isAvailable = isAvailable = true;
        }
    }
}
