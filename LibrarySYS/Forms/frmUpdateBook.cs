using System;
using System.Windows.Forms;
using LibrarySYS.Entities;
using LibrarySYS.Enums;
using LibrarySYS.Managers;

namespace LibrarySYS
{
    public partial class frmUpdateBook : Form
    {
        private BookManager _bookManager;
        private Book _currentBook;
        public frmUpdateBook(BookManager bookManager)
        {
            InitializeComponent();
            _bookManager = bookManager;

            cboGenre.DataSource = Enum.GetValues(typeof(Genre));
            cboGenre.SelectedIndex = -1;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)
        {
            ResetUpdateFields();
        }

        private void ResetUpdateFields()
        {
            txtSearchUpdateMemberID.Clear();
            txtUpdateTitle.Clear();
            txtUpdateBookAuthor.Clear();
            txtUpdateISBN.Clear();
            txtDescription.Clear();
            cboGenre.SelectedIndex = -1;
            dtpPublication.Value = DateTime.Today;

            grpUpdateBook.Visible = false;
            btnSubmitUpdate.Visible = false;

            _currentBook = null;
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (_currentBook == null)
            {
                MessageBox.Show("Please search for a book first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUpdateTitle.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateBookAuthor.Text) ||
                cboGenre.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            _currentBook.Title = txtUpdateTitle.Text.Trim();
            _currentBook.Author = txtUpdateBookAuthor.Text.Trim();
            _currentBook.ISBN = txtUpdateISBN.Text.Trim();
            _currentBook.Description = txtDescription.Text.Trim();
            _currentBook.Genre = (Genre)cboGenre.SelectedItem;
            _currentBook.Publication = dtpPublication.Value;

            _bookManager.UpdateBook(_currentBook);

            MessageBox.Show($"Book '{_currentBook.Title}' updated successfully.");
            ResetUpdateFields();
        }

        private void btnSearchBookID_Click(object sender, EventArgs e)
        {
            string bookId = txtSearchUpdateMemberID.Text.Trim();
            if (string.IsNullOrWhiteSpace(bookId))
            {
                MessageBox.Show("Please enter a Book ID to search.");
                return;
            }

            _currentBook = _bookManager.FindBookById(bookId);

            if (_currentBook == null)
            {
                MessageBox.Show("Book not found.");
                grpUpdateBook.Visible = false;
                btnSubmitUpdate.Visible = false;
            }
            else
            {
                // Populate controls
                txtUpdateTitle.Text = _currentBook.Title;
                txtUpdateBookAuthor.Text = _currentBook.Author;
                txtUpdateISBN.Text = _currentBook.ISBN;
                txtDescription.Text = _currentBook.Description;
                cboGenre.SelectedItem = _currentBook.Genre;
                dtpPublication.Value = _currentBook.Publication;

                grpUpdateBook.Visible = true;
                btnSubmitUpdate.Visible = true;
            }
        }
    }
}
