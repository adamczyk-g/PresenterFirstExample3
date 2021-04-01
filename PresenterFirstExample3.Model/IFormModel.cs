namespace PresenterFirstExample3.Model
{
    public interface IFormModel
    {
        //Notification ValidateForm(FormData formData, EmailData emailData);
        //Pdf GeneratePdf(FormData formData);
        //EmailSendingResult EmailFile(EmailData email, Pdf pdf);
        FormData DefaultFormData { get; }
        void EmailFormAsPdf(FormData formData, EmailData emailData);
        Notification LastFormValidationResult { get; }
        EmailSendingResult EmailSendingError { get; }

        event System.EventHandler InvalidFormData;
        event System.EventHandler SendingErrors;
    }
}
