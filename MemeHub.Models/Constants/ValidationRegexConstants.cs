namespace MemeHub.Models.Constants
{
    public class ValidationRegexConstants
    {
        public const string UsernameRegexValidation = "^[A-z0-9]*$";
        public const string PasswordRegexValidation = "(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).*$";
    }
}
