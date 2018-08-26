using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class HomePage
    {
        static string Url = "/";
        private static string PageTitle = "My Store";
        public HomePage()
        {
            //System.setProperty("webdriver.chrome.driver", "/path/to/chromedriver");
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

     }
}