using System.Linq;

internal class ValidateMember
{
    public static bool ValidateMemberData(
        string forename, string surname, string town,
        string eircode, string phone, string email,
        out string errorMessage)
    {
        //Name rules 
        if (forename.Contains(" ") || surname.Contains(" "))
        {
            errorMessage = "Names cannot contain spaces.";
            return false;
        }

        if (forename.Any(char.IsDigit) || surname.Any(char.IsDigit))
        {
            errorMessage = "Names cannot contain numbers.";
            return false;
        }

        //Empty fields
        if (string.IsNullOrWhiteSpace(forename) ||
            string.IsNullOrWhiteSpace(surname) ||
            string.IsNullOrWhiteSpace(town) ||
            string.IsNullOrWhiteSpace(eircode) ||
            string.IsNullOrWhiteSpace(phone) ||
            string.IsNullOrWhiteSpace(email))
        {
            errorMessage = "Fields cannot be empty.";
            return false;
        }

        //Town
        if (town.Any(char.IsDigit))
        {
            errorMessage = "Town cannot contain numbers.";
            return false;
        }

        //Eircode
        if (eircode.Length != 7)
        {
            errorMessage = "Eircode must be 7 characters long.";
            return false;
        }

        //Phone
        if (phone.Length < 7 || phone.Length > 15 || phone.Any(char.IsLetter))
        {
            errorMessage = "Phone number must be valid.";
            return false;
        }

        //Email
        if (!email.Contains("@") || !email.Contains("."))
        {
            errorMessage = "Email must be valid.";
            return false;
        }

        // Success
        errorMessage = "";
        return true;
    }
}
