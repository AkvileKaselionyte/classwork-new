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

        // 1 uzdavinio

        public static void ClickButtonMultipleCheckboxes()
        {
            Common.ClickElement(buttonMultipleCheckboxes);
        }

        public static bool IfOption1IsSelected()
        {
            return Common.IsElementSelected(fieldOption1);
        }

        public static bool IfOption2IsSelected()
        {
            return Common.IsElementSelected(fieldOption2);
        }

        public static bool IfOption3IsSelected()
        {
            return Common.IsElementSelected(fieldOption3);
        }

        public static bool IfOption4IsSelected()
        {
            return Common.IsElementSelected(fieldOption4);
        }

        //2 uzdavinio

        public static void ClickAllOptionsFields()
        {
            Common.ClickElements(inputsMultipleCheckbox);
        }

        public static List<bool> GetStatusOfAllCheckboxes()
        {
            return Common.GetMultipleElementSelectedStatus(inputsMultipleCheckbox);
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
