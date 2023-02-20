using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework1.Pages.SeleniumEasy
{
    public class CheckBoxDemo
    {
        private static string inputSingleCheckbox = "//*[@id='isAgeSelected']";
        private static string fieldSingleCheckboxSuccessMessage = "//*[@id='txtAge']";
        private static string inputsMultipleCheckbox = "//*[@class='cb1-element']";
        private static string buttonMultipleCheckboxes = "//*[@id='check1']";
        private static string fieldOption1 = "(//*[@class='checkbox']//*[@class='cb1-element'])[1]";
        private static string fieldOption2 = "(//*[@class='checkbox']//*[@class='cb1-element'])[2]";
        private static string fieldOption3 = "(//*[@class='checkbox']//*[@class='cb1-element'])[3]";
        private static string fieldOption4 = "(//*[@class='checkbox']//*[@class='cb1-element'])[4]";

        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static void ClickSingleCheckbox()
        {
            Common.ClickElement(inputSingleCheckbox);
        }

        public static string GetSingleCheckboxSuccessMessage()
        {
            return Common.GetElementText(fieldSingleCheckboxSuccessMessage);
        }

        public static void ClickEachOfMultipleCheckboxes()
        {
            Common.ClickElements(inputsMultipleCheckbox);
        }

        public static string GetMultipleCheckboxButtonText()
        {
            return Common.GetAttributeValue(buttonMultipleCheckboxes, "value");
        }

        // nd 3 uzdavinio

        public static void ClickOption1()
        {
            Common.ClickElement(fieldOption1);
        }

        public static void ClickOption2()
        {
            Common.ClickElement(fieldOption2);
        }

        public static void ClickOption3()
        {
            Common.ClickElement(fieldOption3);
        }

        public static void ClickOption4()
        {
            Common.ClickElement(fieldOption4);
        }

     
    }
}
