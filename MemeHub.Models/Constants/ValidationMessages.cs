namespace MemeHub.Models.Constants
{
    public class ValidationMessages
    {
        public const string UsernameFormatValidationString =
            "Username must contain only letters and digits.";

        public const string UsernameLengthValidationString =
            "Username must be between 5 and 20 symbols.";

        public const string PasswordFormatValidationString =
            "Password must contain a special symbol, uppercase, lowercase letter and a digit";

        public const string PasswordLengthValidationString =
            "Password must be at least 6 symbols long.";
    }
}
