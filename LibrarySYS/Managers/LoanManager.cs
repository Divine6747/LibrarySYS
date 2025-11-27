using LibrarySYS.Entities;
using LibrarySYS.Helpers;
using LibrarySYS.Interfaces;
using System;
using System.Collections.Generic;

namespace LibrarySYS.Managers
{
    public class LoanManager : ILoanManager
    {
        private List<Loan> _loans;

        public LoanManager()
        {
            _loans = new List<Loan>();
        }

        public void ReserveBook(string memberId, string bookId, string reservationId)
        {
            Loan loan = new Loan
            {
                LoanId = null,
                ReservationId = reservationId,
                MemberId = memberId,
                BookId = bookId,
                DateReserved = DateTime.Now,
                DateCollected = null,
                DateReturned = null
            };

            _loans.Add(loan);
        }
        public List<string> CollectBooks(string reservationId)
        {
            List<string> generatedLoanIds = new List<string>();

            string sharedLoanId = IdGenerator.GenerateLoanId();

            bool anyCollected = false;

            foreach (Loan loan in _loans)
            {
                if (loan.ReservationId == reservationId && loan.DateCollected == null)
                {
                    loan.LoanId = sharedLoanId;
                    loan.DateCollected = DateTime.Now;
                    anyCollected = true;
                }
            }

            if (anyCollected)
                generatedLoanIds.Add(sharedLoanId);

            return generatedLoanIds;
        }

        public void ReturnBook(string loanId)
        {
            Loan loan = GetLoanById(loanId);
            if (loan != null && loan.DateCollected != null && loan.DateReturned == null)
            {
                loan.DateReturned = DateTime.Now;
            }
        }

        public Loan GetLoanById(string loanId)
        {
            foreach (Loan l in _loans)
            {
                if (l.LoanId == loanId)
                    return l;
            }
            return null;
        }

        public List<Loan> GetLoansByReservationId(string reservationId)
        {
            List<Loan> list = new List<Loan>();
            foreach (Loan l in _loans)
            {
                if (l.ReservationId == reservationId)
                    list.Add(l);
            }
            return list;
        }

        public List<Loan> GetLoansByMember(string memberId)
        {
            List<Loan> list = new List<Loan>();
            foreach (Loan l in _loans)
            {
                if (l.MemberId == memberId)
                    list.Add(l);
            }
            return list;
        }

        public List<Loan> GetActiveLoans()
        {
            List<Loan> list = new List<Loan>();
            foreach (Loan l in _loans)
            {
                if (l.DateReturned == null)
                    list.Add(l);
            }
            return list;
        }
    }
}
