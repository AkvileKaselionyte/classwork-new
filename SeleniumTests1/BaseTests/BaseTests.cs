using NUnit.Framework;
using SeleniumFramework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests1.BaseTests
{
    internal class BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }

    }
}
