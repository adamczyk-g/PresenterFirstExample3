using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterFirstExample3.Model;

namespace PresenterFirstExample3.Presenter
{
    public interface IFormView
    {
        FormData FormData { get; }
        EmailData EmailData { get; }
        void DisplayValidationResult(IEnumerable<string> errorMessage);
        void DisplayEmailError(string text);
        void ClearValidationError();
        void SetDefaultData(FormData formData);

        event EventHandler SubmitButtonClick;
        event EventHandler ViewLoad;
    }
}
