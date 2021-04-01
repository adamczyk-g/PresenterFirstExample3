using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresenterFirstExample3.Presenter;
using PresenterFirstExample3.Model;

namespace PresenterFirstExample3.View
{
    public partial class FormView : Form, IFormView
    {
        public FormData FormData { get { return new FormData(firstNameTextBox.Text, lastNameTextBox.Text, commentsTextBox.Text); } }
        public EmailData EmailData { get { return new EmailData( emailTextBox.Text, smtpTextBox.Text); } }

        public event EventHandler SubmitButtonClick;
        public event EventHandler ViewLoad;

        public FormView()
        {
            InitializeComponent();
            submitButton.Click += OnSubmitButtonClick;
            this.Load += FormView_Load;
        }

        private void OnSubmitButtonClick(object sender, EventArgs e)
        {
            SubmitButtonClick.Invoke(sender, EventArgs.Empty);
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            ViewLoad.Invoke(sender, EventArgs.Empty);
        }

        public void DisplayValidationResult(IEnumerable<string> errorMessage)
        {
            validationErrors.DataSource = errorMessage;
        }

        public void DisplayEmailError(string error)
        {
            sendingErrors.Text = error;
        }

        public void ClearValidationError()
        {
            validationErrors.DataSource = new List<string>();
            sendingErrors.Text = string.Empty;
        }

        public void SetDefaultData(FormData formData)
        {
            firstNameTextBox.Text = formData.FirstName;
            lastNameTextBox.Text = formData.LastName;
            commentsTextBox.Text = formData.Comments;
        }
    }
}
