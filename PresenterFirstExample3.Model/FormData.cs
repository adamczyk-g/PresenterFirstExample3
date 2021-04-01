namespace PresenterFirstExample3.Model
{
    public class FormData
    {
        public FormData(string firstName, string lastName, string comments)
        {
            FirstName = firstName;
            LastName = lastName;
            Comments = comments;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Comments { get; }
    }
}
