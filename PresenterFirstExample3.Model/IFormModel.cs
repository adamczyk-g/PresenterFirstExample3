namespace PresenterFirstExample3.Model
{
    public interface IFormModel
    {
        //Notification ValidateForm(FormData formData, EmailData emailData);
        //Pdf GeneratePdf(FormData formData);
        //EmailSendingResult EmailFile(EmailData email, Pdf pdf);
        FormData DefaultFormData { get; }
        Results TryEmailFormAsPdf(FormData formData, EmailData emailData);
    }
}
