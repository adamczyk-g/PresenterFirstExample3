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

            view.SubmitButtonClick += OnSubmitButtonClick;
            view.ViewLoad += OnViewLoad;
            model.InvalidFormData += OnInvalidFormData;
            model.SendingErrors += OnSendingErrors;
        }

        private void OnViewLoad(object obj, EventArgs e)
        {
            view.SetDefaultData(model.DefaultFormData);            
        }

        private void OnSubmitButtonClick(object obj, EventArgs e)
        {
            model.EmailFormAsPdf(view.FormData, view.EmailData);
        }

        private void OnInvalidFormData(object sender, EventArgs e)
        {
            view.DisplayValidationResult(model.LastFormValidationResult.Messages);
        }

        private void OnSendingErrors(object sender, EventArgs e)
        {
            view.DisplayEmailError(model.EmailSendingError.Message);
        }
    }
}
