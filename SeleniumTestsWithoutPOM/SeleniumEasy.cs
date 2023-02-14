using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumTestsWithoutPOM
{
    public class SeleniumEasy
    {
        [Test]
        public void SingleInputField()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "Labas";

            IWebElement inputEnterMessage = driver.FindElement(By.XPath("//*[@id='user-message']"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            IWebElement spanMessageText = driver.FindElement(By.XPath("//*[@id='display']"));

            inputEnterMessage.SendKeys(expectedResult);
            buttonShowMessage.Click();
            string actualResult = spanMessageText.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();

        }

        [Test]
        public void TwoInputField()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string inputA = "5";
            string inputB = "6";
            string expectedResult = "11";


            IWebElement inputEnterA = driver.FindElement(By.XPath("//*[@id='sum1']"));
            IWebElement inputEnterB = driver.FindElement(By.XPath("//*[@id='sum2']"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            IWebElement spanTotalMessage = driver.FindElement(By.XPath("//*[@id='displayvalue']"));

            inputEnterA.SendKeys(inputA);
            inputEnterB.SendKeys(inputB);
            buttonGetTotal.Click();

            string actualResult = spanTotalMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();

        }

    }
}
