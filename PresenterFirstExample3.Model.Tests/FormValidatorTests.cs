using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PresenterFirstExample3.Model.Tests
{
    [TestFixture]
    public class FormValidatorTests
    {
        private Mock<EmailValidator> emailValidator;

        [SetUp]
        public void Setup()
        {
            emailValidator = new Mock<EmailValidator>();
        }               

        [TestCase("ProperFirstName", "ProperLastName", "proper comment", "some@email.address", "proper.host.name", new object[] {  }, false)]
        [TestCase("unproperFirstName", "ProperLastName", "proper comment", "some@email.address", "proper.host.name", new object[] { "First name is invalid!" }, true)]
        [TestCase("ProperFirstName", "unpoperLastName", "proper comment", "some@email.address", "proper.host.name", new object[] { "Last name is invalid!" }, true)]
        [TestCase("ProperFirstName", "ProperLastName", "proper comment", "some@email.address", "", new object[] { "Smtp host is invalid!" }, true)]
        [TestCase("unproperFirstName", "unproperLastName", "proper comment", "some@email.address", "proper.host.name", new object[] { "First name is invalid!" , "Last name is invalid!" }, true)]
        [TestCase("unproperFirstName", "unproperLastName", "proper comment", "some@email.address", "", new object[] { "First name is invalid!", "Last name is invalid!", "Smtp host is invalid!" }, true)]

        public void Form_validator_with_correct_email_address_and_incorrect_other_data_return_errors(
            string firstName, 
            string lastName, 
            string comment,
            string emailAddress,
            string smtpHost,
            Object[] expectedMessage,
            bool hasErrors)
        {
            //arrange
            FormData formData = new FormData(firstName, lastName, comment);
            EmailData emailData = new EmailData(emailAddress, smtpHost);
            emailValidator.Setup(m => m.Validate("some@email.address")).Returns(true);
            IFormValidator sut = new FormValidator(emailValidator.Object);

            //act
            Notification notification = sut.Validate(formData, emailData);

            //assert
            CollectionAssert.AreEquivalent(expectedMessage, notification.Messages.ToArray());
            Assert.AreEqual(hasErrors, notification.HasErrors);
        }
    }
}
