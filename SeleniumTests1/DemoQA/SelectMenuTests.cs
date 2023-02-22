using NUnit.Framework;
using SeleniumFramework1.Pages.DemoQA;
using SeleniumTests1.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests1.DemoQA
{
    internal class SelectMenuTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            SelectMenu.Open();
        }

        [Test]
        public void SelectTitle()
        {
            string expectedValue = "Mr.";

            SelectMenu.SelectTitle(expectedValue);
            string actuallySelectedTitle = SelectMenu.GetSelectedTitle();

            Assert.IsTrue(actuallySelectedTitle.Contains(expectedValue));
        }
    }
}
