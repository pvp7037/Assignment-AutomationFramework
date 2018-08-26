
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class TopNavigationBar
    {
        [FindsBy(How = How.ClassName, Using = "header_logo")]
        public IWebElement companyLink;

        [FindsBy(How = How.Id, Using = "search_query_top")]
        public IWebElement searchInput;

        [FindsBy(How = How.Name, Using = "submit_search")]
        public IWebElement searchButton;

        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement loginLink;

        [FindsBy(How = How.ClassName, Using = "header_user_info")]
        public IWebElement userName;

        [FindsBy(How = How.ClassName, Using = "logout")]
        public IWebElement logoutLink;


        public void clickCompanyLink()
        {
            companyLink.Click();
        }

        public void LogoutLink()
        {
            logoutLink.Click();
        }

        public void SearchProduct()
        {
            searchInput.SendKeys(ProductGenerater.Generate());
            searchButton.Click();
        }

        public void clickLoginLink()
        {
            loginLink.Click();
        }

    }
}
