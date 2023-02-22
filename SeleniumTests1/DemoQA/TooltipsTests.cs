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
    internal class TooltipsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Tooltips.Open();
        }

        [Test]
        public void HoverOnButton()
        {
            string expectedMessage = "You hovered over the Button";

            string actualMessage = Tooltips.GetTooltipMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
