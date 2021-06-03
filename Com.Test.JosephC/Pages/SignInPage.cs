using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public class SignInPage : BasePage
    {
        IWebElement EmailAddressField => driver.FindElement(By.Id("email"));
        IWebElement PasswordField => driver.FindElement(By.Id("passwd"));
        IWebElement SigninButton => driver.FindElement(By.Id("SubmitLogin"));

        public void SignIntoWebsite()
        {
            PageIntro();
            EnterCredentials();
            ClickSigninButton();
        }

        public void ClickSigninButton()
        {
            ElementExtensions.WaitClickElement(SigninButton);
        }
        
        public void EnterCredentials()
        {
            ElementExtensions.WaitClickElement(EmailAddressField);
            ElementExtensions.WaitSendElement(EmailAddressField, "Darren-Chambers@hotmail.com");
            Thread.Sleep(500);
            ElementExtensions.WaitClickElement(PasswordField);
            ElementExtensions.WaitSendElement(PasswordField, "Test123");
        }

        public void PageIntro()
        {
            ElementExtensions.WaitURLIs("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            Thread.Sleep(500);
        }
    }
}
