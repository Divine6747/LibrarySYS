using System;

namespace LibrarySYS.Entities
{
    public class Loan
    {
        private string _loanId;
        private string _reservationId;
        private string _memberId;
        private string _bookId;
        private DateTime _dateReserved;
        private DateTime? _dateCollected;
        private DateTime? _dateReturned;

        public string LoanId
        {
            get { return _loanId; }
            set { _loanId = value; }
        }

        public string ReservationId
        {
            get { return _reservationId; }
            set { _reservationId = value; }
        }

        public string MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }

        public string BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        public DateTime DateReserved
        {
            get { return _dateReserved; }
            set { _dateReserved = value; }
        }

        public DateTime? DateCollected
        {
            get { return _dateCollected; }
            set { _dateCollected = value; }
        }

        public DateTime? DateReturned
        {
            get { return _dateReturned; }
            set { _dateReturned = value; }
        }

        public Loan()
        {
            _loanId = string.Empty;
            _reservationId = string.Empty;
            _memberId = string.Empty;
            _bookId = string.Empty;
            _dateReserved = DateTime.Now;
            _dateCollected = null;
            _dateReturned = null;
        }
    }
}