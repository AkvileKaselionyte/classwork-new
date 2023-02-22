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
    internal class DynamicDataLoadingTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            DynamicDataLoading.Open();
        }

        [Test]
        public void LoadingTheDataDynamically()
        {
            DynamicDataLoading.ClickGetNewUserButton();
            string userInformation = DynamicDataLoading.GetUserInformation();

            Assert.IsTrue(userInformation.Contains("First Name : "));
            Assert.IsTrue(userInformation.Contains("Last Name : "));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
