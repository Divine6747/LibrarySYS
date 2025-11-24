using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS.Entities
{
    internal class ValidateMember
    {
        public static void validateName(string forename, string surname) { 
            if(forename.Contains(" ") || surname.Contains(" "))
            {
                throw new ArgumentException("Names cannot contain spaces");
            }
            if(forename.Any(char.IsDigit) || surname.Any(char.IsDigit))
            {
                throw new ArgumentException("Names cannot contain numbers");
            }
            if(string.IsNullOrWhiteSpace(forename) || string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("Names cannot be empty");
            }
        }
        public static void validateTown(string town) { 
        
        
        }
        public static void validateEircode(string eircode)
        { 
        
        
        
        }
        public static void validatePhone(string phone)
        {



        }
        public static void validateEmail(string email)
        {


        }
    }
}
