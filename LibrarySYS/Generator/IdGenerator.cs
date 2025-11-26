using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS.Helpers
{
    public static class IdGenerator
    {
        private static int _memberCounter = 0;
        private static int _bookCounter = 0;
        private static int _reservationCounter = 0;
        private static int _loanCounter = 0;

        public static string GenerateMemberId()
        {
            _memberCounter++;
            return "M" + _memberCounter.ToString("D4");
        }

        public static string GenerateBookId()
        {
            _bookCounter++;
            return "B" + _bookCounter.ToString("D4");
        }

        public static string GenerateReservationId()
        {
            _reservationCounter++;
            return "R" + _reservationCounter.ToString("D4");
        }

        public static string GenerateLoanId()
        {
            _loanCounter++;
            return "L" + _loanCounter.ToString("D4");
        }
    }
}
