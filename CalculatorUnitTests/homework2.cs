using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests
{
    internal class homework2
    {
        [Test]
        public void FillFormatWithValidEmail()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string full_name = "Akvile";
            string email = "akvile@gmail.com";
            string current_address = "Kaunas";
            string permanent_address = "Vilnius";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id='submit']/.."));

            inputFullName.SendKeys(full_name);
            inputEmail.SendKeys(email);
            inputCurrentAddress.SendKeys(current_address);
            inputPermanentAddress.SendKeys(permanent_address);
            submitButton.Click();

            IWebElement outputName = driver.FindElement(By.XPath("//*[@id='output']//*[@id='name']"));
            IWebElement outputEmail = driver.FindElement(By.XPath("//*[@id='output']//*[@id='email']"));
            IWebElement outputCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement outputPermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            Assert.IsTrue(outputName.Text.Contains(full_name));
            Assert.IsTrue(outputEmail.Text.Contains(email));
            Assert.IsTrue(outputCurrentAddress.Text.Contains(current_address));
            Assert.IsTrue(outputPermanentAddress.Text.Contains(permanent_address));

            driver.Quit();

        }

        [Test]
        public void FillFormatWithInvalidEmail()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string valueInputEmail = "invalidEmail";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputEmail.SendKeys(valueInputEmail);
            buttonSubmit.Click();

            Assert.IsTrue(inputEmail.GetAttribute("class").Contains("field-error"));

            driver.Quit();
        }



    }
}

