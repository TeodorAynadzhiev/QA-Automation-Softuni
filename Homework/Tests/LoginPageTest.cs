using NUnit.Framework;

namespace Homework.Tests
{
    public class LoginPageTest : NegativeRegTests

    {       
        [Test]
        public void RegistrationPageTest()
        {            
            _regPage.NavigateToLogin(_loginPage);
            _regPage.AssertRegPage(_regPage.RegisterButton);
        }
    }
}
