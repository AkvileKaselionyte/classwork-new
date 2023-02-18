using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework1.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/text-box");
        }

        public static void EnterFullName(string valueInputName)
        {
            Common.SendKeys(Locators.inputFullName, valueInputName);
        }

        public static void EnterEmail(string valueInputEmail)
        {
            Common.SendKeys(Locators.inputEmail, valueInputEmail);
        }

        public static void EnterCurrentAddress(string valueInputCurrentAddress)
        {
            Common.SendKeys(Locators.inputCurrentAddress, valueInputCurrentAddress);
        }

        public static void EnterPermanentAddress(string valueInputPermanentAddress)
        {
            Common.SendKeys(Locators.inputPermanentAddress, valueInputPermanentAddress);
        }

        public static void ClickSubmitButton()
        {
            // Need to scroll down a bit because button is hidden under footer element
            Common.ScrollBy(0, 100);
            Common.ClickElement(Locators.buttonSubmit);
        }

        public static string GetFullNameOutput()
        {
            return Common.GetElementText(Locators.outputFullName);
        }

        public static string GetEmailOutput()
        {
            return Common.GetElementText(Locators.outputEmail);
        }

        public static string GetCurrentAddressOutput()
        {
            return Common.GetElementText(Locators.outputCurrentAddress);
        }

        public static string GetPermanentAddressOutput()
        {
            return Common.GetElementText(Locators.outputPermanentAddress);
        }

        public static bool CheckIfEmailErrorIsDisplayed()
        {
            string attributeClassValue = Common.GetAttributeValue(Locators.inputEmail, "class");

            if (attributeClassValue.Contains("field-error"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckIfEmailBorderIsRed()
        {
            Common.Wait(500);

            string cssBorderColor = Common.GetCssValue(Locators.inputEmail, "border-color");
            if (cssBorderColor == "rgb(255, 0, 0)")
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
