using LibrarySYS.Entities;
using LibrarySYS.Helpers;
using LibrarySYS.Managers;
using LibrarySystem.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmReserveBook : Form
    {
        private readonly MemberManager _memberManager;
        private readonly BookManager _bookManager;
        private readonly LoanManager _loanManager;

        private Member _currentMember;
        private readonly List<Book> _cartBooks = new List<Book>();

        public frmReserveBook(MemberManager memberManager, BookManager bookManager, LoanManager loanManager)
        {
            InitializeComponent();

            _memberManager = memberManager;
            _bookManager = bookManager;
            _loanManager = loanManager;

            dgvSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSearchResults.AllowUserToAddRows = false;
            dgvResCart.AllowUserToAddRows = false;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchMemberID_Click(object sender, EventArgs e)
        {
            string memberID = txtMemberId.Text.Trim();

            if (memberID == "")
            {
                MessageBox.Show("Enter a Member ID.");
                return;
            }

            _currentMember = _memberManager.FindMemberById(memberID);

            if (_currentMember == null)
            {
                MessageBox.Show("Member not found.");
                return;
            }

            lblMemberInfo.Text =
                "ID: " + _currentMember.MemberId + Environment.NewLine +
                "Name: " + _currentMember.Forename + " " + _currentMember.Surname + Environment.NewLine +
                "County: " + _currentMember.Town + Environment.NewLine +
                "Email: " + _currentMember.Email;

            grpMemberInfo.Visible = true;
        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();

            if (title == "")
            {
                MessageBox.Show("Enter a book title.");
                return;
            }

            List<Book> results = _bookManager.SearchBooksByTitle(title);

            if (results.Count == 0)
            {
                MessageBox.Show("No books found.");
                return;
            }

            LoadSearchResults(results);
        }

        private void LoadSearchResults(List<Book> books)
        {
            dgvSearchResults.Rows.Clear();
            dgvSearchResults.Columns.Clear();

            dgvSearchResults.Columns.Add("BookId", "Book ID");
            dgvSearchResults.Columns.Add("Title", "Title");
            dgvSearchResults.Columns.Add("Author", "Author");
            dgvSearchResults.Columns.Add("Genre", "Genre");
            dgvSearchResults.Columns.Add("ISBN", "ISBN");
            dgvSearchResults.Columns.Add("Status", "Status");

            foreach (Book b in books)
            {
                string availability = b.IsAvailable ? "Available" : "Not Available";

                dgvSearchResults.Rows.Add(
                    b.BookId,
                    b.Title,
                    b.Author,
                    b.Genre.ToString(),
                    b.ISBN,
                    availability
                );
            }
        }

        private void RefreshCart()
        {
            dgvResCart.Rows.Clear();
            dgvResCart.Columns.Clear();

            dgvResCart.Columns.Add("BookId", "Book ID");
            dgvResCart.Columns.Add("Title", "Title");
            dgvResCart.Columns.Add("Genre", "Genre");

            foreach (Book b in _cartBooks)
            {
                dgvResCart.Rows.Add(b.BookId, b.Title, b.Genre.ToString());
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (_currentMember == null)
            {
                MessageBox.Show("No member selected.");
                return;
            }

            if (_cartBooks.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            string reservationId = IdGenerator.GenerateReservationId();

            foreach (Book book in _cartBooks)
            {
                _loanManager.ReserveBook(_currentMember.MemberId, book.BookId, reservationId);

                _bookManager.SetAvailability(book.BookId, false);
            }

            MessageBox.Show(
                "Reservation successful." + Environment.NewLine +
                "Reservation ID: " + reservationId,
                "Success"
            );

            this.Close();
        }

        private void dgvSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (_cartBooks.Count >= 5)
            {
                MessageBox.Show("A member may only reserve up to 5 books.");
                return;
            }

            string bookId = dgvSearchResults.Rows[e.RowIndex].Cells["BookId"].Value.ToString();
            Book selectedBook = _bookManager.FindBookById(bookId);

            if (selectedBook == null)
            {
                MessageBox.Show("Invalid book selected.");
                return;
            }

            if (!selectedBook.IsAvailable)
            {
                MessageBox.Show("Book is not available.");
                return;
            }

            if (_cartBooks.Exists(b => b.BookId == selectedBook.BookId))
            {
                MessageBox.Show("This book is already in the cart.");
                return;
            }

            _cartBooks.Add(selectedBook);
            RefreshCart();
        }

        private void dgvResCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string bookId = dgvResCart.Rows[e.RowIndex].Cells["BookId"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Remove this book from reservation cart?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < _cartBooks.Count; i++)
                {
                    if (_cartBooks[i].BookId == bookId)
                    {
                        _cartBooks.RemoveAt(i);
                        break;
                    }
                }
                RefreshCart();
            }
        }
    }
}
