using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class RegistrationPage
    {
        public void AssertErrorMessage(string expected)
        {
            Assert.AreEqual(expected, ErrorMessages[0].Text);
        }

        public void AssertRegPage(IWebElement element)
        {
            Assert.IsNotNull(element, "Registration Page is not opened");
        }
               
    }
}
