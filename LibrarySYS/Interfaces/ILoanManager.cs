using LibrarySYS.Entities;
using System.Collections.Generic;

namespace LibrarySYS.Interfaces
{
    public interface ILoanManager
    {
        void ReserveBook(string memberId, string bookId, string reservationId);
        List<string> CollectBooks(string reservationId);
        void ReturnBook(string loanId);
        Loan GetLoanById(string loanId);
        List<Loan> GetLoansByReservationId(string reservationId);
        List<Loan> GetLoansByMember(string memberId);
        List<Loan> GetActiveLoans();
    }
}
