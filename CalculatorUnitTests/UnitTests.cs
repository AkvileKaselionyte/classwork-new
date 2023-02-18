using NUnit.Framework;

namespace CalculatorUnitTests
{
    public class UnitTests
    {
        [Test]
        public void Sum1And1()
        {

            int expectedResult = 2;
                
            int actualResult = CalculatorNew.Calculator.SumInt(1, 1);
            
            Assert.AreEqual(expectedResult, actualResult);
        
        }

        [Test]
        public void Sum2And2()
        {

            Assert.AreEqual(4, CalculatorNew.Calculator.SumInt(2, 2)); // galima ir taip

        }

        [Test]
        public void SumDouble01And01And01()
        {

            double expectedResult = 0.3;

            double actualResult = CalculatorNew.Calculator.SumDouble3(0.1, 0.1, 0.1);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void SumDecimal01And01And01()
        {

            decimal expectedResult = 0.3m;

            decimal actualResult = CalculatorNew.Calculator.SumDecimal3(0.1m, 0.1m, 0.1m);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void Sum3And3()
        {

            Assert.AreEqual(6, CalculatorNew.Calculator.SumInt(3, 3));

        }
    }
}
