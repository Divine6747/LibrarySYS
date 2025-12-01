using LibrarySYS.Entities;
using LibrarySYS.Interfaces;
using LibrarySYS.Managers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace LibrarySYS
{
    public partial class frmReturnBook : Form
    {
        private readonly LoanManager _loanManager;
        private readonly BookManager _bookManager;

        private List<Loan> _loansToReturn = new List<Loan>();

        public frmReturnBook(LoanManager loanManager, BookManager bookManager)
        {
            InitializeComponent();
            _loanManager = loanManager;
            _bookManager = bookManager;

            dgvLoanedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLoansToGrid()
        {
            dgvLoanedBooks.Rows.Clear();
            dgvLoanedBooks.Columns.Clear();

            dgvLoanedBooks.Columns.Add("BookId", "Book ID");
            dgvLoanedBooks.Columns.Add("Title", "Title");
            dgvLoanedBooks.Columns.Add("Status", "Status");

            foreach (var loan in _loansToReturn)
            {
                Book book = _bookManager.FindBookById(loan.BookId);
                if (book != null)
                {
                    string status;

                    if (loan.DateReturned == null)
                    {
                        status = "Collected";
                    }
                    else
                    {
                        status = "Returned";
                    }

                    dgvLoanedBooks.Rows.Add(book.BookId, book.Title, status);
                }
            }
        }

        private void dgvLoanedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_loansToReturn.Count == 0)
            {
                MessageBox.Show("No books to return.");
                return;
            }

            foreach (var loan in _loansToReturn)
            {
                if (loan.DateReturned == null)
                {
                    _loanManager.ReturnBook(loan.LoanId);

                    Book book = _bookManager.FindBookById(loan.BookId);
                    if (book != null)
                        book.IsAvailable = true;
                }
            }

            MessageBox.Show("Books successfully returned.");
            LoadLoansToGrid();
        }
    }
}
