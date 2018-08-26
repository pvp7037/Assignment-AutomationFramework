using System;
using NUnit.Framework;
using TestFramework;
using TestFramework.Logs;

namespace Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Can_Go_To_HomePage()
        {
            LogHelpers.CreateLogFile();
            LogHelpers.Write("Start Can_Go_To_HomePage");
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
            LogHelpers.Write("End Can_Go_To_HomePage");
        }
        
        [Test]
        public void CanAccessLoginPage()
        {
            LogHelpers.Write("Start CanAccessLoginPage");
            Pages.TopNavigation.clickLoginLink();
            Assert.IsTrue(Pages.Login.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("authentication"));
            Assert.IsTrue(Pages.Login.IsText());
            LogHelpers.Write("End CanAccessLoginPage");
        }
        [Test]
        public void CanLoginAsInValidUser()
        {

            LogHelpers.Write("Start CanLoginAsInValidUser");
            Pages.Login.Goto();
            Pages.Login.LogIn("InValidUser");
            Assert.IsTrue(Pages.Login.IsInvalidPassword());
            Pages.Home.Goto();
            LogHelpers.Write("End CanLoginAsInValidUser");
        }

        [Test]
        public void CanLoginAsUser()
        {

            LogHelpers.Write("Start CanLoginAsUser");
            Pages.Login.Goto();
            Pages.Login.LogIn("UserUser");
            Assert.IsTrue(Pages.TopNavigation.userName.Displayed);
            Pages.Home.Goto();
            LogHelpers.Write("End CanLoginAsUser");
        }
        [Test]
        public void Product_Required_Search()
        {
            LogHelpers.Write("Start Product_Required_Search");
            Pages.TopNavigation.SearchProduct();
            LogHelpers.Write("End Product_Required_Search");
        }
        [Test]
        public void Product_Search_Click()
        {
            LogHelpers.Write("Start Product_Search_Click");
            Pages.Products.ClickProduct();
            System.Threading.Thread.Sleep(5000);
            //Assert.IsTrue(Pages.Products.Searchresult());
            LogHelpers.Write("End Product_Search_Click");
        }

        [Test]
        public void ProductSearchQuantityUP()
        {
            LogHelpers.Write("Start ProductSearchQuantityUP");
            Pages.Products.IncreaseQuantity();
            LogHelpers.Write("End ProductSearchQuantityUP");
        }

        [Test]
        public void ProductSearchSelectPinkColor()
        {
            LogHelpers.Write("Start ProductSearchSelectPinkColor");
            Pages.Products.SelectPinkColor();
            LogHelpers.Write("End ProductSearchSelectPinkColor");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart()
        {
            LogHelpers.Write("Start ProductSearchSelectSAddtoCart");
            Pages.Products.AddToCart();
            System.Threading.Thread.Sleep(6000);
            Assert.IsTrue(Pages.Products.Qtyselected());
            Assert.IsTrue(Pages.Products.Popupdressnames());

            LogHelpers.Write("End ProductSearchSelectSAddtoCart");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart_checkout()
        {
            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout");
            //System.Threading.Thread.Sleep(5000);
            Pages.Products.CheckOut();
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout");
        }

        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product");
            Pages.Checkout.SubstractProduct();
            System.Threading.Thread.Sleep(3000);
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed");
            Pages.Checkout.ProceedToCheckOut();
            System.Threading.Thread.Sleep(3000);
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address");
            Assert.IsTrue(Pages.Checkout.AddressTab());
            Pages.Checkout.ProceedAddress();
            System.Threading.Thread.Sleep(3000);
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms");
            Pages.Checkout.TermsOfServiceAccept();
            System.Threading.Thread.Sleep(3000);
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier");
            Pages.Checkout.ProcessCarrier();
            System.Threading.Thread.Sleep(3000);
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque");
            //Assert.IsTrue(Pages.Checkout.Choosepaymentmethod());
            Pages.Checkout.PayByCheque();
            System.Threading.Thread.Sleep(3000);
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque");
        }
        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit");
            Pages.Checkout.Submit();
            System.Threading.Thread.Sleep(3000);
            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit");
        }

        [Test]
        public void ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit_confirm()
        {

            LogHelpers.Write("Start ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit_confirm");
            //Pages.Checkout.OrderConfirm();
            //Assert.IsTrue(Pages.Checkout.OrderConfirm());
            System.Threading.Thread.Sleep(3000);

            LogHelpers.Write("End ProductSearchSelectSAddtoCart_checkout_substract_Product_proceed_address_terms_processCarrier_cheque_submit_confirm");
        }

        [Test]
        public void Signout()
        {
            LogHelpers.Write("Start Signout");
            Pages.TopNavigation.LogoutLink();
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(Pages.Login.IsAtSignout());
            Browser.Close();
            LogHelpers.Write("End Signout");
        }

    }

}
