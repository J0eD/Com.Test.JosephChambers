using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public class SelectedTShirtPage : BasePage
    {
        IWebElement AddToCartButton => driver.FindElement(By.Id("add_to_cart"));
        IWebElement ProceedToCheckout => driver.FindElements(By.CssSelector("a[href='http://automationpractice.com/index.php?controller=order']")).ElementAt(2);

        public void GotoCheckOut()
        {
            ElementExtensions.WaitClickElement(AddToCartButton);
            Thread.Sleep(500);
            ElementExtensions.WaitClickElement(ProceedToCheckout);
        }

        public void PageIntro()
        {
            ElementExtensions.WaitURLIs("http://automationpractice.com/index.php?id_product=1&controller=product");
            Thread.Sleep(500);
        }
    }
}

