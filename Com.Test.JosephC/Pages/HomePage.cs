using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public class HomePage : BasePage
    {
        IWebElement UserAccount => driver.FindElement(By.CssSelector("a[href='http://automationpractice.com/index.php?controller=my-account']"));
        IWebElement SignInButton => driver.FindElement(By.CssSelector("a[class='login']"));
        IWebElement TshirtButton => driver.FindElements(By.CssSelector("a[href='http://automationpractice.com/index.php?id_category=5&controller=category']")).ElementAt(1);


        public void ClickUserAccountMenu()
        {
            ElementExtensions.WaitClickElement(UserAccount);
        }
        public void ClickTshirtCategory()
        {
            ElementExtensions.WaitClickElement(TshirtButton);
        }

        public void PageIntro()
        {
            ElementExtensions.WaitURLEnds("http://automationpractice.com/index.php?");
            Thread.Sleep(500);
        }

        public void AssertUserLoggedIn()
        {
            Assert.IsTrue(UserAccount.Displayed);
        }

        public void CheckLogin()
        {
            if(SignInButton.Displayed)
            {
                ElementExtensions.WaitClickElement(SignInButton);
                SignInPage Sp = new SignInPage();
                Sp.SignIntoWebsite();
            }
            else { }
        }

        public void LaunchWebsite()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Thread.Sleep(500);
        }
    }
}
