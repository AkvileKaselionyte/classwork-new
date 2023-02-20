using SeleniumFramework1.Pages.DemoQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework1.Pages.SeleniumEasy
{
    public class DynamicDataLoading
    {
        private static string buttonGetNewUser = "//*[@id='save']";
        private static string image = "//*[@id='loading']/img";


        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        public static void ClickButtonGetNewUser()
        {
            Common.ClickElement(buttonGetNewUser);
        }

        public static void WaitForImageToBeVisible()
        {
            Common.WaitForElementToBeVisible(image);
        }

        public static bool GetFirstNameMessage()
        {
            string attributeText = Common.GetAttributeValue(image, "text");

            if (attributeText.Contains("First Name :"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool GetLastNameMessage()
        {
            string attributeText = Common.GetAttributeValue(image, "text");

            if (attributeText.Contains("Last Name :"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
