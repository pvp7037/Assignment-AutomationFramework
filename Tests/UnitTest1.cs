using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Testautomation7070@gmail.com
        //Qwerty@7037
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
           
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }
        [TestMethod]
        public void CanAccessLoginPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickLoginLink();
            Assert.IsTrue(Pages.Login.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("authentication"));
        }
        [TestMethod]
        public void CanLoginAsUser()
        {

            
            Pages.Login.Goto();
            Pages.Login.LogIn("UserUser");

            Assert.IsTrue(Pages.TopNavigation.userName.Displayed);
            Pages.Home.Goto();
        }
        [TestMethod]
        public void ProductSearch()
        {
         
            Pages.TopNavigation.SearchProduct();
         
        }
        [TestMethod]
        public void ProductSearchClick()
        {
         
            Pages.Products.ClickProduct();
       
        }
        [TestMethod]
        public void ProductSearchQuantityUP()
        {
          
            Pages.Products.IncreaseQuantity();
          
        }

        [TestMethod]
        public void ProductSearchSelectPinkColor()
        {
       
            Pages.Products.SelectPinkColor();
       
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart()
        {
      
            Pages.Products.AddToCart();
     
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout()
        {
     
            System.Threading.Thread.Sleep(5000);
            Pages.Products.CheckOut();
       
        }

        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product()
        {
        
            
            Pages.Checkout.SubstractProduct();
            System.Threading.Thread.Sleep(3000);
        
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed()
        {
      

            Pages.Checkout.ProceedToCheckOut();
            System.Threading.Thread.Sleep(3000);
      
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address()
        {
      

            Pages.Checkout.ProceedAddress();
            System.Threading.Thread.Sleep(3000);
        
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms()
        {
      

            Pages.Checkout.TermsOfServiceAccept();
            System.Threading.Thread.Sleep(3000);
      
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier()
        {
         

            Pages.Checkout.ProcessCarrier();
            System.Threading.Thread.Sleep(3000);
         
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque()
        {
      

            Pages.Checkout.PayByCheque();
            System.Threading.Thread.Sleep(3000);
        
        }
        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit()
        {
      

            Pages.Checkout.Submit();
            System.Threading.Thread.Sleep(3000);
         
        }

        [TestMethod]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit_confirm()
        {
       

            Pages.Checkout.OrderConfirm();
            System.Threading.Thread.Sleep(3000);
        
        }
     
       
        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
    
}
