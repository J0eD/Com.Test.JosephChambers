using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public class ShoppingCartSummaryPage : BasePage
    {
        IWebElement ProceedToSigninTab => driver.FindElement(By.CssSelector("a[href='http://automationpractice.com/index.php?controller=order']"));
        IWebElement ProceedToAddresstab => driver.FindElement(By.CssSelector("a[href='http://automationpractice.com/index.php?controller=order&step=1']"));
        IWebElement ProceedToShippingab => driver.FindElement(By.CssSelector("button[name='processAddress']"));
        IWebElement TAndCs => driver.FindElement(By.Id("uniform-cgv"));
        IWebElement ProceedToPayment => driver.FindElement(By.CssSelector("button[name='processCarrier']"));
        IWebElement PayByCheck => driver.FindElement(By.CssSelector("a[href='http://automationpractice.com/index.php?fc=module&module=cheque&controller=payment']"));
        IWebElement IconfirmMyOrder => driver.FindElements(By.CssSelector("button[type='submit']")).ElementAt(1);
        IWebElement UserAccount => driver.FindElement(By.CssSelector("a[href='http://automationpractice.com/index.php?controller=my-account']"));


        public void QuickCheckout()
        {
            PageIntro();
            ProceedToAddressTab();
            ProceedToShippingTab();
            ProceedToPaymentTab();
            ProcessPaymentOptionsCheck();
        }

        public void ClickUserAccountMenu()
        {
            ElementExtensions.WaitClickElement(UserAccount);
        }
        public void ProcessPaymentOptionsCheck()
        {
            ElementExtensions.WaitClickElement(PayByCheck);
            ElementExtensions.WaitClickElement(IconfirmMyOrder);
        }
        public void ProceedToPaymentTab()
        {
            ElementExtensions.ClickActionsElement(TAndCs);
            ElementExtensions.WaitClickElement(ProceedToPayment);
        }
        public void ProceedToShippingTab()
        {
            ElementExtensions.WaitClickElement(ProceedToShippingab);
        }
        public void ProceedToAddressTab()
        {
            ElementExtensions.WaitClickElement(ProceedToAddresstab);
        }
        public void ProceedToSignInTab()
        {
            ElementExtensions.WaitClickElement(ProceedToSigninTab);
        }

        public void PageIntro()
        {
            ElementExtensions.WaitURLIs("http://automationpractice.com/index.php?controller=order");
            Thread.Sleep(500);
        }
    }
}
