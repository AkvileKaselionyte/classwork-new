using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumFramework1
{
    public class Driver
    {
        private static IWebDriver driver;
        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            // Su refresh
            driver.Url = url;

            // Be refresh, išlaikom veiksmus kurie galėjo būti atlikti svetainėje
            //driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }

    }
}
