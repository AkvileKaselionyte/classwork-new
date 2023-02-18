using NUnit.Framework;
using SeleniumFramework1;
using SeleniumFramework1.Pages.SeleniumEasy;

namespace SeleniumTests1.SeleniumEasy
{
    internal class SimpleFormDemoTests
    {

        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SimpleFormDemo.Open();
        }

        [Test]
        public void SingleInputField()
        {
            string expectedResult = "Test";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TwoInputFields()
        {
            string inputAValue = "5";
            string inputBValue = "7";
            string expectedResult = "12";

            SimpleFormDemo.EnterInputA(inputAValue);
            SimpleFormDemo.EnterInputB(inputBValue);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldsMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
