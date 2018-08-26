using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get 
            { 
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static ContactPage Contact
        {
            get { return GetPage<ContactPage>(); }
        }

        public static ProductsPage Products
        {
            get { return GetPage<ProductsPage>(); }
        }

        public static CartPage Cart
        {
            get { return GetPage<CartPage>(); }
        }

        public static RegisterPage Register
        {
            get { return GetPage<RegisterPage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static Checkout Checkout
        {
            get { return GetPage<Checkout>(); }
        }

        public static TopNavigationBar TopNavigation
        {
            get { return GetPage<TopNavigationBar>(); }
        }

    }
}