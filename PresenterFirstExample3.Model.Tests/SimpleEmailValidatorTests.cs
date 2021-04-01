using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterFirstExample3.Model.Tests
{
    [TestFixture]
    public class SimpleEmailValidatorTests
    {
        [TestCase("abc@abc.com")]
        [TestCase("abc@abc.def.com")]
        [TestCase("abc.abc@abc.com")]
        [TestCase("abc-abc@abc.com")]
        [TestCase("abc_abc@abc.com")]
        public void Correct_email_address_test(string email)
        {
            EmailValidator sut = new SimpleEmailValidator();
            Assert.AreEqual(true, sut.Validate(email), email);
        }
        
        [TestCase("address_without_at.com")]
        [TestCase("abc@domain_without_dot")]
        [TestCase("abc@to_many_dots...before_domain")]
        [TestCase("too_long_user_name_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx@abc.com")]
        public void Incorrect_email_address_test(string email)
        {
            EmailValidator sut = new SimpleEmailValidator();
            Assert.AreEqual(false, sut.Validate(email), email);
        }
    }
}
