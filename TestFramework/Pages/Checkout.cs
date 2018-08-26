using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace TestFramework
{
    public class Checkout
    {
        [FindsBy(How = How.Id, Using = "cart_quantity_down_4_43_0_92286")]
        public IWebElement substractItem;
        [FindsBy(How = How.Name, Using = "quantity_4_43_0_92286")]
        public IWebElement itemcount;
        [FindsBy(How = How.ClassName, Using = "standard-checkout")]
        public IWebElement proceedToCheckOut;
        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement processAddress;
        [FindsBy(How = How.Name, Using = "cgv")]
        public IWebElement cgv;
        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement processCarrier;
        [FindsBy(How = How.ClassName, Using = "cheque")]
        public IWebElement cheque;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/form/p/button")]
        public IWebElement submit;
        [FindsBy(How = How.ClassName, Using = "alert alert-success")]
        public IWebElement orderConfirm;

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        public IWebElement addresstab;

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        public IWebElement choosepaymentmethod;

        


        public void SubstractProduct()
        {
            substractItem.Click();
        }

        public bool AddressTab()
        {
            return addresstab.Text.Contains("ADDRESSES");
        }

        public bool Choosepaymentmethod()
        {
            return choosepaymentmethod.Text.Contains("Please choose your payment method");
        }
        public bool IsProductCount()
        {
            System.Diagnostics.Debug.Write(itemcount.GetAttribute("value").ToString());
            return itemcount.GetAttribute("value").ToString() == "1";
        }

        public void ProceedToCheckOut()
        {
            proceedToCheckOut.Click();
        }

        public void ProceedAddress()
        {
            processAddress.Click();
        }

        public void TermsOfServiceAccept()
        {
            cgv.Click();
        }
        public void ProcessCarrier()
        {
            processCarrier.Click();
        }
        public void PayByCheque()
        {
            cheque.Click();
        }
        public void Submit()
        {
            submit.Click();
        }
        public bool OrderConfirm()
        {
           return Browser.Title.Contains("Order confirmation");
        }

      
    }
}
