using System.Text.RegularExpressions;

namespace PresenterFirstExample3.Model
{
    public class SimpleEmailValidator: EmailValidator
    {
        public bool Validate(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]{1,64}@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,63}$");
        }
    }
}