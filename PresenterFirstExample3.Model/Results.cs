using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterFirstExample3.Model
{
    public class Results
    {
        public Results(Notification validationResult, EmailSendingResult sendingResult)
        {
            ValidationResult = validationResult.Messages;
            SendingResult = sendingResult.Message;
        }
        public IEnumerable<string> ValidationResult { get; private set; }
        public string SendingResult { get; private set; }
    }
}
