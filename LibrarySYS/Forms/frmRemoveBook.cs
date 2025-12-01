using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmRemoveBook : Form
    {
        private readonly BookManager _bookManager;
        private Book _currentBook;
        public frmRemoveBook(BookManager bookManager)
        {
            InitializeComponent();
            _bookManager = bookManager;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            string bookId = txtSearchUpdateBookID.Text.Trim();

            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Enter a Book ID.");
                return;
            }

            _currentBook = _bookManager.FindBookById(bookId);

            if (_currentBook == null)
            {
                MessageBox.Show("Book not found.");
                return;
            }

            // Fill fields
            txtSearchUpdateBookID.Text = _currentBook.BookId;
            txtUpdateISBN.Text = _currentBook.ISBN;
            txtUpdateTitle.Text = _currentBook.Title;
            txtUpdateBookAuthor.Text = _currentBook.Author;
            dtpPublication.Value = _currentBook.Publication;

            cboGenre.DataSource = Enum.GetValues(typeof(Genre));
            cboGenre.SelectedItem = _currentBook.Genre;

            txtDescription.Text = _currentBook.Description;

            grpUpdateBook.Visible = true;
            btnRemoveBook.Visible = true;
        }

        private void btnSearchBookId_Click(object sender, EventArgs e)
        {

        }
    }
}
