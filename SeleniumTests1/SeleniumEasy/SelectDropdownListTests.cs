using NUnit.Framework;
using SeleniumFramework1.Pages.SeleniumEasy;
using SeleniumFramework1;
using SeleniumTests1.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests1.SeleniumEasy
{
    internal class SelectDropdownListTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SelectDropdownList.Open();
        }

        [Test]
        public void SelectDay()
        {
            string expectedDay = "Tuesday";

            SelectDropdownList.SelectDay(expectedDay);
            string actualResult = SelectDropdownList.GetSelectedDay();

            Assert.IsTrue(actualResult.Contains(expectedDay));
        }
    }
}
