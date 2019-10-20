using NUnit.Framework;

namespace Homework.Tests
{
    public class RegNegativeTests : NegativeRegTests

    {
        [Test]

        public void PhoneNumberNegTest()
        {
            _user.Phone = "";
            _regPage.NavigateToLogin(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("You must register at least one phone number.");

        }

        [Test]
        public void LastNameNegTest()
        {
            _user.LastName = "";
            _regPage.NavigateToLogin(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("lastname is required.");

        }

        [Test]
        public void FirstNameNegTest()
        {
            _user.FirstName = "";
            _regPage.NavigateToLogin(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("firstname is required.");

        }

        [Test]
        public void PostCodeNegTest()
        {
            _user.PostCode = "";
            _regPage.NavigateToLogin(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("The Zip/Postal code you've entered is invalid. It must follow this format: 00000");

        }

        [Test]
        public void CityNegTest()
        {
            _user.City = "";
            _regPage.NavigateToLogin(_loginPage);
            _regPage.FillForm(_user);
            _regPage.AssertErrorMessage("city is required.");

        }
    }
}