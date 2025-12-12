using LibrarySYS.Entities;
using LibrarySYS.Helpers;
using LibrarySYS.Managers;
using LibrarySystem.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace LibrarySYS
{
    public partial class frmCollectBook : Form
    {
        private readonly BookManager _bookManager;
        private readonly LoanManager _loanManager;

        public frmCollectBook(LoanManager loanManager, BookManager bookManager)
        {
            InitializeComponent();
            _bookManager = bookManager;
            _loanManager = loanManager;

            dgvReservedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSerachResID_Click(object sender, EventArgs e)
        {
            string reservationId = txtResId.Text.Trim();

            if (reservationId == "")
            {
                MessageBox.Show("Enter a Reservation ID.");
                return;
            }

            List<Loan> list = _loanManager.GetLoansByReservationId(reservationId);

            if (list.Count == 0)
            {
                MessageBox.Show("No reservation found.");
                return;
            }

            dgvReservedBooks.Visible = true;
            btnConfirm.Visible = true;
            LoadReservedBooks(list);

        }
        private void LoadReservedBooks(List<Loan> loans)
        {
            dgvReservedBooks.Rows.Clear();
            dgvReservedBooks.Columns.Clear();

            dgvReservedBooks.Columns.Add("LoanId", "Loan ID");
            dgvReservedBooks.Columns.Add("BookId", "Book ID");
            dgvReservedBooks.Columns.Add("Title", "Title");

            foreach (Loan l in loans)
            {
                Book b = _bookManager.FindBookById(l.BookId);
                string status = l.DateCollected == null ? "Reserved" : "Already Collected";

                dgvReservedBooks.Rows.Add(b.BookId, b.Title, status);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string reservationId = txtResId.Text.Trim();

            if (reservationId == "")
            {
                MessageBox.Show("Enter a Reservation ID first.");
                return;
            }

            List<string> loanIds = _loanManager.CollectBooks(reservationId);

            if (loanIds.Count == 0)
            {
                MessageBox.Show("Books are already collected or reservation not found.");
                return;
            }

            string message = "Collection successful.\nLoan IDs:\n";

            foreach (string id in loanIds)
            {
                message += id + "\n";
            }

            MessageBox.Show(message);

            LoadReservedBooks(_loanManager.GetLoansByReservationId(reservationId));
        }
    }
}
