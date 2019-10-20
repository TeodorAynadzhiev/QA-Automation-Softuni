using Homework.Pages;
using NUnit.Framework;


namespace Homework
{
    [TestFixture]
    public class NegativeRegTests : BaseTest
    {
        protected LoginPage _loginPage;
        protected RegistrationPage _regPage;
        protected RegistrationUser _user;
        
        [SetUp]

        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);
            _user = UserFactory.CreateValidUser();
        }       
        
    }
}
