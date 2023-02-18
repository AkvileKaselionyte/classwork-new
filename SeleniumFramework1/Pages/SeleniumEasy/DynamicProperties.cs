using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework1.Pages.SeleniumEasy
{
    public class DynamicProperties
    {  // DemoQA puslapis

        public static bool WaitForButtonToBeClickable()
        {
            string locator = "//*[@id='enableAfter']";
            Common.WaitForElementToBeClickable(locator);
            return Common.CheckIfElementIsEnabled(locator);
        }

        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/dynamic-properties");
        }

        public static void WaitForButtonClassToChange()
        {
            string locator = "//*[@id='colorChange']";
            Common.WaitForElementAttributeToContainValue(locator, "class", "text-danger");
        }

        public static void WaitForButtonTextToBeRed()
        {
            string locator = "//*[@id='colorChange']";
            Common.WaitForElementCssPropertyToBe(locator, "color", "rgba(255, 0, 0, 1)");
        }

        public static void WaitForButtonToBeVisible()
        {
            string locator = "//*[@id='visibleAfter']";
            Common.WaitForElementToBeVisible(locator);
        }
    }  
}
