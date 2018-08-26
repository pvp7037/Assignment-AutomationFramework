using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class ProductsPage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div[2]/ul/li[2]/div/div[2]/h5/a")]
        public IWebElement productLink;
        [FindsBy(How = How.ClassName, Using = "product_quantity_up")]
        public IWebElement quantityUP;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[4]/div/div/div/div[4]/form/div/div[3]/div[1]/p/button")]
        public IWebElement addtoCart;

        [FindsBy(How = How.ClassName, Using = "heading-counter")]
        public IWebElement searchresults;

        [FindsBy(How = How.Id, Using = "layer_cart_product_title")]
        public IWebElement popupdressname;

        [FindsBy(How = How.Id, Using = "layer_cart_product_quantity")]
        public IWebElement quantityselected;
        
        [FindsBy(How = How.Name, Using = "Pink")]
        public IWebElement colorElement;
        //
        [FindsBy(How = How.LinkText, Using = "Proceed to checkout")]
        public IWebElement checkOut;
        public void ClickProduct()
        {
            productLink.Click();
        }

        public bool Qtyselected()
        {
            return quantityselected.Text.Equals("2");
        }

        public bool Popupdressnames()
        {
            return popupdressname.Text.Contains("Printed Dress");
        }
        public bool Searchresult()
        {
            return searchresults.Text.Trim().Contains("5 results have been found.");
        }


        public void IncreaseQuantity()
        {
            quantityUP.Click();

        }
        public void SelectPinkColor()
        {
            colorElement.Click();

        }

        public void AddToCart()
        {
            addtoCart.Click();

        }

        public void CheckOut()
        {
            checkOut.Click();

        }
    }
}