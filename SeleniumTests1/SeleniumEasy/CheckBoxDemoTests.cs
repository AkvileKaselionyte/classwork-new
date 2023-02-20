using NUnit.Framework;
using SeleniumFramework1.Pages.SeleniumEasy;
using SeleniumFramework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework1.Pages.DemoQA;

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

        [Test]
        public void MultipleCheckboxesHW1()
        {
            CheckBoxDemo.ClickButtonMultipleCheckboxes();
            Assert.IsTrue(CheckBoxDemo.IfOption1IsSelected());
            Assert.IsTrue(CheckBoxDemo.IfOption2IsSelected());
            Assert.IsTrue(CheckBoxDemo.IfOption3IsSelected());
            Assert.IsTrue(CheckBoxDemo.IfOption4IsSelected());
        }

        [Test]
        public void MultipleCheckboxesHW2()
        {
            string expectedStatuses = "true";
            string actualGetStatuses = "";
        }

        [Test]
        public void MultipleCheckboxesHW3()
        {
            string expectedButtonText = "Check All";
            string expectedButtonTextWhenAllArePressed = "Uncheck All";

            CheckBoxDemo.ClickOption1();
            Assert.AreEqual(expectedButtonText, CheckBoxDemo.GetMultipleCheckboxButtonText());
            CheckBoxDemo.ClickOption2();
            Assert.AreEqual(expectedButtonText, CheckBoxDemo.GetMultipleCheckboxButtonText());
            CheckBoxDemo.ClickOption3();
            Assert.AreEqual(expectedButtonText, CheckBoxDemo.GetMultipleCheckboxButtonText());
            CheckBoxDemo.ClickOption4();
            Assert.AreEqual(expectedButtonTextWhenAllArePressed, CheckBoxDemo.GetMultipleCheckboxButtonText());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
