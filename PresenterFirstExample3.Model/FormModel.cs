using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing.Layout;

namespace PresenterFirstExample3.Model
{
    public class FormModel : IFormModel
    {
        private readonly IFormValidator formValidator;
        private Notification validationResult;
        private EmailSendingResult sendingResult;

        public event EventHandler InvalidFormData;
        public event EventHandler SendingErrors;
        public FormModel(IFormValidator formValidator)
        {
            this.formValidator = formValidator;
        }
        public FormData DefaultFormData
        {
            get
            {
                return new FormData("John", "Smith", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco" +
                    " laboris nisi ut aliquip ex ea commodo consequat.");
            }
        }

        public void EmailFormAsPdf(FormData formData, EmailData emailData)
        {
            validationResult = ValidateForm(formData, emailData);
            sendingResult = new EmailSendingResult(string.Empty);

            if (validationResult.HasErrors == false)
            {
                Pdf pdf = GeneratePdf(formData);
                sendingResult = SendFileByEmail(emailData, pdf);

                if (sendingResult.WasSend == false)
                    SendingErrors.Invoke(this, EventArgs.Empty);
            }
            else
                InvalidFormData.Invoke(this, EventArgs.Empty);
        }

        public Notification LastFormValidationResult => validationResult;
        public EmailSendingResult EmailSendingError => sendingResult;

        private Notification ValidateForm(FormData formData, EmailData emailData)
        {
            return formValidator.Validate(formData, emailData);
        }

        private Pdf GeneratePdf(FormData formData)
        {
            string text = "first name: " + formData.FirstName + Environment.NewLine + Environment.NewLine +
                "last name: " + formData.LastName + Environment.NewLine + Environment.NewLine +
                "comments: " + formData.Comments + Environment.NewLine;


            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Times New Roman", 10, XFontStyle.Bold);
            XTextFormatter tf = new XTextFormatter(gfx);

            XRect rect = new XRect(40, 100, 250, 220);
            gfx.DrawRectangle(XBrushes.SeaShell, rect);
            tf.DrawString(text, font, XBrushes.Black, rect, XStringFormats.TopLeft);

            document.Save("myDocument.pdf");

            return new Pdf("myDocument.pdf");
        }

        private EmailSendingResult SendFileByEmail(EmailData email, Pdf pdf)
        {
            string emailFrom = "notify@mvptest.com.pl";
            string displayName = "PresenterFirst_example_1";

            EmailSendingResult emailError = new EmailSendingResult(string.Empty);

            SmtpClient client = new SmtpClient(email.SmtpHost);
            MailAddress from = new MailAddress(emailFrom, displayName, System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress(email.ToAddress);
            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test email message sent by an application.";
            message.Attachments.Add(new Attachment(pdf.PathToFile));

            try
            {
                client.Send(message);
            }
            catch (Exception e)
            {
                emailError = new EmailSendingResult(e.Message);
            }

            message.Dispose();

            return emailError;
        }
    }
}
