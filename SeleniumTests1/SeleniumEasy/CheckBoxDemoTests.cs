using NUnit.Framework;
using SeleniumFramework1.Pages.SeleniumEasy;
using SeleniumFramework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests1.SeleniumEasy
{
    internal class CheckBoxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            CheckBoxDemo.Open();
        }

        [Test]
        public void SingleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";

            CheckBoxDemo.ClickSingleCheckbox();
            string actualResult = CheckBoxDemo.GetSingleCheckboxSuccessMessage();

            Assert.AreEqual(expectedMessage, actualResult);
        }

        [Test]
        public void MultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            CheckBoxDemo.ClickEachOfMultipleCheckboxes();
            string actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }


        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
