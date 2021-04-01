using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PresenterFirstExample3.Model
{
    public class Notification
    {
        private readonly List<string> messages;

        public Notification()
        {
            messages = new List<string>();
        }

        public void AddMessage(string message) { messages.Add(message); }
        public bool HasErrors { get { return messages.Count != 0; } }
        public IEnumerable<string> Messages { get { return new ReadOnlyCollection<string>(messages); } }
    };
}
