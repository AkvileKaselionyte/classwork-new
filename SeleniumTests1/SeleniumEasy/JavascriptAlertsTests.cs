using NUnit.Framework;
using SeleniumFramework1;
using SeleniumFramework1.Pages.SeleniumEasy;
using SeleniumTests1.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests1.SeleniumEasy
{
    internal class JavascriptAlertsTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            JavascriptAlerts.Open();
        }

        [Test]
        public void TestJavascriptAlerts()
        {
            string expectedValue = "I am an alert box!";

            JavascriptAlerts.OpenSimpleAlert();
            string actualValue = JavascriptAlerts.GetAlertText();

            Assert.AreEqual(expectedValue, actualValue);
        }
    
    }
}
