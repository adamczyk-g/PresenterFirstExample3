using System.Text.RegularExpressions;

namespace PresenterFirstExample3.Model
{
    public class FormValidator: IFormValidator
    {
        private readonly EmailValidator emailValidator;
        public FormValidator(EmailValidator emailValidator) 
        {
            this.emailValidator = emailValidator;
        }
        public Notification Validate(FormData formData, EmailData emailData)
        {
            Notification result = new Notification();

            string message = string.Empty;

            if (!FirstNameValidator(formData.FirstName)) result.AddMessage("First name is invalid!");
            if (!LastNameValidator(formData.LastName)) result.AddMessage("Last name is invalid!");
            if (!CommentsValidator(formData.Comments)) result.AddMessage("Comments are invalid!");
            if (!emailValidator.Validate(emailData.ToAddress)) result.AddMessage("Email address is invalid!");
            if (!SmtpHostValidator(emailData.SmtpHost)) result.AddMessage("Smtp host is invalid!");

            return result;
        }

        bool FirstNameValidator(string firstName)
        {
            return Regex.Match(firstName, "^[A-Z][a-zA-Z]+$").Success;
        }

        bool LastNameValidator(string lastName)
        {
            return Regex.Match(lastName, "^[A-Z][a-zA-Z]+$").Success;
        }

        bool SmtpHostValidator(string smtpHost)
        {
            return Regex.Match(smtpHost, @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$").Success;
        }

        bool CommentsValidator(string comments)
        {
            return comments.Length < 255;
        }
    }
}
