using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS.Entities
{
    public class ValidateBook
    {
        private static readonly int ISBN_LENGTH = 13;

        public static bool ValidateBookData(
            string isbn, string title, string author,
            string publication, ComboBox genre, string description,
            out string errorMessage)
        {
            errorMessage = "";

            // Title and Author rules 
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                errorMessage = "Title and Author cannot be empty.";
                return false;
            }

            // Title and Author shouldn't contain numbers
            if (title.Any(char.IsDigit) || author.Any(char.IsDigit))
            {
                errorMessage = "Title and Author cannot contain numbers.";
                return false;
            }

            // ISBN rules
            if (isbn.Length != ISBN_LENGTH || isbn.Any(char.IsLetter))
            {
                errorMessage = "ISBN must be a 13-digit number.";
                return false;
            }

            DateTime pubDate;
            if (!DateTime.TryParse(publication, out pubDate))
            {
                errorMessage = "Please enter a valid publication date.";
                return false;
            }
            if (pubDate > DateTime.Now)
            {
                errorMessage = "Publication date cannot be in the future.";
                return false;
            }

            if (genre.SelectedIndex < 0)
            {
                errorMessage = "Genre cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                errorMessage = "Description cannot be empty.";
                return false;
            }

            return true;
        }
    }
}