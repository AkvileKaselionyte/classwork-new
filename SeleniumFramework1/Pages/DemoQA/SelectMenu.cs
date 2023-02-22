using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework1.Pages.DemoQA
{
    public class SelectMenu
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/select-menu");
        }

        public static void SelectTitle(string expectedValue)
        {
            Common.ClickElement(Locators.SelectMenu.dropdownTitle);
            Common.ClickElement(Locators.SelectMenu.dropdownTitleOptionMr);
        }

        public static string GetSelectedTitle()
        {
            return Common.GetElementText(Locators.SelectMenu.dropdownTitle);
        }
    }
}
