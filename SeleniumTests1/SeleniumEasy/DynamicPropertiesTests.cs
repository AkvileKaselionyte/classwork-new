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
    internal class DynamicPropertiesTests
    { // DemoQA puslapis

        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            DynamicProperties.Open();
        }

        [Test]
        public void WaitForButtonToBeClickable()
        {
            Assert.IsTrue(DynamicProperties.WaitForButtonToBeClickable());
        }

        [Test]
        public void WaitForButtonClassToChange()
        {
            DynamicProperties.WaitForButtonClassToChange();
        }

        [Test]
        public void WaitForButtonBorderToBeRed()
        {
            DynamicProperties.WaitForButtonTextToBeRed();
        }

        [Test]
        public void WaitForButtonToBeVisible()
        {
            DynamicProperties.WaitForButtonToBeVisible();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
