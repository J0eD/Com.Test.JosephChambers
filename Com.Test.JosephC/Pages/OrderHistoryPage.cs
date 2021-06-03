using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public class OrderHistoryPage : BasePage
    {
        IList<IWebElement> AllItems => driver.FindElements(By.CssSelector(""));
        IWebElement MostRecentOrder => driver.FindElement(By.CssSelector("tr[class^='first_item']"));
        
        public void AssertNewShirtOrdered()
        {
            MyAccountPage MaP = new MyAccountPage();
            MaP.ClickViewHistoryButtonPage();
            PageIntro();
            Assert.IsTrue(MostRecentOrder.Displayed);
            Assert.IsTrue(MostRecentOrder.Text.Contains("$18.51"));
            Assert.IsTrue(MostRecentOrder.Text.Contains("Payment by check"));
        }

        public void PageIntro()
        {
            ElementExtensions.WaitURLIs("http://automationpractice.com/index.php?controller=history");
            Thread.Sleep(500);
        }
    }
}
