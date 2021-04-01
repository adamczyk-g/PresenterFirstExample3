namespace PresenterFirstExample3.Model
{
    public class EmailSendingResult
    {
        public EmailSendingResult (string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
        public bool Send { get { return Message == string.Empty; } }
    }
}
