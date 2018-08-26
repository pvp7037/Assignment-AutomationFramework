using System.Runtime.InteropServices;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestFramework.TestData;

namespace TestFramework
{
    public class LoginPage
    {
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement emailField;

        [FindsBy(How = How.Name, Using = "passwd")]
        private IWebElement passwordField;

        [FindsBy(How = How.Name, Using = "SubmitLogin")]
        private IWebElement loginButton;

        [FindsBy(How = How.ClassName, Using = "page-heading")]
        private IWebElement pageheading;

        [FindsBy(How = How.ClassName, Using = "alert-danger")]
        private IWebElement invalidPassword;

        public void Goto()
        {
            Pages.TopNavigation.clickLoginLink();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Login");

        }

        //alert alert-danger
        public bool IsInvalidPassword()
        {
            return invalidPassword.Displayed;
        }


        public bool IsAtSignout()
        {
            return Browser.Title.Contains("Login - My Store");

        }
        public bool IsText()
        {
            return pageheading.Text == "AUTHENTICATION";

        }

        public void LogInAsLastRegisteredUser()
        {
            LogIn(UserGenerator.Generate());
        }

        public void LogInAsLastRegisteredUser(LoginOptions useLastGeneratedPassword)
        {
            var user = new User()
            {
                EmailAddress = UserGenerator.LastGeneratedUser.EmailAddress,
                Password = UserGenerator.LastGeneratedUser.Password
            };

            LogIn(user);
        }

        private void ClearLoginFields()
        {
            emailField.Clear();
            passwordField.Clear();
        }

        private void LogIn(User user)
        {
            ClearLoginFields();
            emailField.SendKeys(user.EmailAddress);
            passwordField.SendKeys(user.Password);
            loginButton.Click();
        }

        public void LogIn(string testName)
        {
            var UserData = DataAccess.GetTestData(testName);
            ClearLoginFields();
            emailField.SendKeys(UserData.Username);
            passwordField.SendKeys(UserData.Password);
            loginButton.Click();
        }



        public enum LoginOptions
        {
            UseLastGeneratedPassword
        }


    }
}
