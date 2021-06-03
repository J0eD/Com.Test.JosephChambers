using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public class TshirtPage : BasePage
    {
        IWebElement OnlyTshirt => driver.FindElement(By.CssSelector("img[src='http://automationpractice.com/img/p/1/1-home_default.jpg']"));
      

        public void SelectATshirttoCheckout()
        {
            PageIntro();
            ElementExtensions.ClickActionsElement(OnlyTshirt);
        }

        public void PageIntro()
        {
            ElementExtensions.WaitURLIs("http://automationpractice.com/index.php?id_category=5&controller=category");
            Thread.Sleep(500);
        }
    }
}
