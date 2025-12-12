using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Managers;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
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
            if (_currentBook == null)
            {
                MessageBox.Show("Please search for a book first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to set this book to inactive?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _bookManager.SetAvailability(_currentBook.BookId, false);
                MessageBox.Show($"Book '{_currentBook.Title}' has been set to inactive.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSearchRemoveBookID.Clear();
                grpRemoveBook.Visible = false;
                btnRemoveBookConfirm.Visible = false;
                _currentBook = null;
            }
        }

        private void btnSearchBookId_Click(object sender, EventArgs e)
        {
            string bookId = txtSearchRemoveBookID.Text.Trim();

            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter a Book ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentBook = _bookManager.FindBookById(bookId);

            if (_currentBook == null)
            {
                MessageBox.Show("Book not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpRemoveBook.Visible = false;
                btnRemoveBookConfirm.Visible = false;
            }
            else
            {
                string bookDetails = "Book ID:  " + _currentBook.BookId + "  \t\t  " +
                                     "ISBN:  " + _currentBook.ISBN + "\n\n" +
                                     "Title:  " + _currentBook.Title + "  \t\t  " +
                                     "Author:  " + _currentBook.Author + "\n\n" +
                                     "Publication Date:  " + _currentBook.Publication.ToShortDateString() + "  \t" +
                                     "Genre:  " + _currentBook.Genre + "\n\n" +
                                     "Description:  " + _currentBook.Description + "\n\n" +
                                     "Status:  " + (_currentBook.IsAvailable ? "Available" : "Not Available");

                lblBookDetails.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                lblBookDetails.Text = bookDetails;
                grpRemoveBook.Visible = true;
                btnRemoveBookConfirm.Visible = true;
            }
        }
    }
}
