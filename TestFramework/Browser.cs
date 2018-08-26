using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace TestFramework
{

    public class Browser
    {
        public IWebDriver WebDriver { get; set; }
        

        private static string baseUrl = ConfigurationManager.AppSettings["url"]; //use app config for determining environment
        private static IWebDriver webDriver = new ChromeDriver();

        public Browser(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public static void Initialize()
        {

            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver _Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Close();
            webDriver.Quit();
        }


    }
 }