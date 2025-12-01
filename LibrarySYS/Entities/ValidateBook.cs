using System.CodeDom;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS.Entities
{
    internal class ValidateBook
    {

        private static readonly int ISBN_LENGTH = 13;

        public static bool ValidateBookData(
            string isbn,string title, string author, string publication,string genre,string description)
        {
            // Title and Author rules 
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Title and Author cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // ISBN rules
            if (title.Any(char.IsDigit) || author.Any(char.IsDigit))
            {
                MessageBox.Show("Title and Author cannot contain numbers.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (isbn.Length > ISBN_LENGTH || isbn.Any(char.IsLetter) || isbn.Length < ISBN_LENGTH)
            {
                MessageBox.Show("ISBN must be a 13-digit number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (publication == default)
            {
                MessageBox.Show("Publication date is not valid.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(genre))
            {
                MessageBox.Show("Genre cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
            
            if (string.IsNullOrWhiteSpace(description)) {
                MessageBox.Show("Description cannot be empty.", "Validation Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
