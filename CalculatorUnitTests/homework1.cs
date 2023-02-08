﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests
{
    internal class homework1
    {
        [Test]
        public void CheckRemainder995DividedBy3()
        {
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void TodayIsWednesdayTest()
        {

            Assert.AreEqual(DayOfWeek.Wednesday, DateTime.Today.DayOfWeek);

        }
    }
}