using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public class MyAccountPage : BasePage
    {
        IWebElement ViewOrderHistoryButton=> driver.FindElement(By.CssSelector("a[href='http://automationpractice.com/index.php?controller=history']"));
        IWebElement MyPersonalInformationButton => driver.FindElement(By.CssSelector("a[href='http://automationpractice.com/index.php?controller=identity']"));

        public void ClickMyPersonalInformation()
        {
            PageIntro();
            ElementExtensions.WaitClickElement(MyPersonalInformationButton);
        }
        public void ClickViewHistoryButtonPage()
        {
            PageIntro();
            ElementExtensions.WaitClickElement(ViewOrderHistoryButton);
        }

        public void PageIntro()
        {
            ElementExtensions.WaitURLIs("http://automationpractice.com/index.php?controller=my-account");
            Thread.Sleep(500);
        }
    }
}
