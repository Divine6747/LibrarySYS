using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Helpers;
using LibrarySYS.Managers;
using System;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmAddBook : Form
    {
        private BookManager _bookManager;
        public frmAddBook(BookManager bookManager)
        {
            InitializeComponent();
            _bookManager = bookManager;
        }
        private void mnuAddBookBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddBook_Load(object sender, EventArgs e)
        {
            cboGenre.Items.AddRange(System.Enum.GetNames(typeof(Genre)));
            cboGenre.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate with error message
            if (!ValidateBook.ValidateBookData(
                txtISBN.Text,
                txtTitle.Text,
                txtAuthor.Text,
                dtpPublication.Text,
                cboGenre,
                txtDescription.Text,
                out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected genre - FIXED: Get by name, not index
            string selectedGenreName = cboGenre.SelectedItem.ToString();
            Genre genreEnum = (Genre)Enum.Parse(typeof(Genre), selectedGenreName);

            // Generate book ID
            string bookId = IdGenerator.GenerateBookId();

            Book newBook = new Book(
                bookId, // Pass the generated ID
                txtISBN.Text,
                txtTitle.Text,
                txtAuthor.Text,
                dtpPublication.Value,
                genreEnum,
                txtDescription.Text,
                true
            );

            _bookManager.AddBook(newBook);
            MessageBox.Show($"Book '{newBook.Title}' added successfully with ID: {newBook.BookId}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            cboGenre.SelectedIndex = -1;
            dtpPublication.Value = DateTime.Now;
            txtDescription.Clear();
        }
    }
}
