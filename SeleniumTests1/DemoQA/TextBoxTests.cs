using NUnit.Framework;
using SeleniumFramework1.Pages.SeleniumEasy;
using SeleniumFramework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework1.Pages.DemoQA;

namespace SeleniumTests1.DemoQA
{
    internal class TextBoxTests
    {

        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            TextBox.Open();
        }

        [Test]
        public void FillFormatWithValidEmail()
        {
            string valueInputName = "My Name";
            string valueInputEmail = "email@email.com";
            string valueInputCurrentAddress = "My current address";
            string valueInputPermanentAddress = "My permanent address";

            TextBox.EnterFullName(valueInputName);
            TextBox.EnterEmail(valueInputEmail);
            TextBox.EnterCurrentAddress(valueInputCurrentAddress);
            TextBox.EnterPermanentAddress(valueInputPermanentAddress);
            TextBox.ClickSubmitButton();

            string actualFullName = TextBox.GetFullNameOutput();
            string actualEmail = TextBox.GetEmailOutput();
            string actualCurrentAddress = TextBox.GetCurrentAddressOutput();
            string actualPermanentAddress = TextBox.GetPermanentAddressOutput();

            Assert.IsTrue(actualFullName.Contains(valueInputName));
            Assert.IsTrue(actualEmail.Contains(valueInputEmail));
            Assert.IsTrue(actualCurrentAddress.Contains(valueInputCurrentAddress));
            Assert.IsTrue(actualPermanentAddress.Contains(valueInputPermanentAddress));
        }

        [Test]
        public void FillFormatWithInvalidEmail()
        {
            string valueInputEmail = "invalidEmail";

            TextBox.EnterEmail(valueInputEmail);
            TextBox.ClickSubmitButton();

            Assert.IsTrue(TextBox.CheckIfEmailErrorIsDisplayed());
            Assert.IsTrue(TextBox.CheckIfEmailBorderIsRed());
        }

            [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }





    }

    
    
}
