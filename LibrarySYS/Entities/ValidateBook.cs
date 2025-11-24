using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS.Entities
{
    internal class ValidateBook
    {
        public static bool ValidateBookData(
            string isbn,string title, string author, string publication,string genre,string description,
            out string errorMessage)
        {
            // Title and Author rules 
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                errorMessage = "Title and Author cannot be empty.";
                return false;
            }
            if (title.Any(char.IsDigit) || author.Any(char.IsDigit))
            {
                errorMessage = "Title and Author cannot contain numbers.";
                return false;
            }
            // ISBN rules
            if (isbn.Length != 13 || isbn.Any(char.IsLetter))
            {
                errorMessage = "ISBN must be a 13-digit number.";
                return false;
            }
            errorMessage = "";
            return true;
        }
    }
}
