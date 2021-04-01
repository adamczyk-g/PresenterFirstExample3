using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterFirstExample3.Model;

namespace PresenterFirstExample3.Presenter
{
    public class FormPresenter
    {
        private readonly IFormView view;
        private readonly IFormModel model;

        public FormPresenter(IFormView view, IFormModel model)
        {
            this.view = view;
            this.model = model;

            this.view.SubmitButtonClick += OnSubmitButtonClick;
            view.ViewLoad += OnViewLoad;            
        }

        private void OnViewLoad(object obj, EventArgs e)
        {
            view.SetDefaultData(model.DefaultFormData);
        }

        private void OnSubmitButtonClick(object obj, EventArgs e)
        {
            FormData formData = view.FormData;
            EmailData emailData = view.EmailData;
            Results results = model.TryEmailFormAsPdf(formData, emailData);

            view.ClearValidationError();
            view.DisplayValidationResult(results.ValidationResult);
            view.DisplayEmailError(results.SendingResult);
        }
    }
}
