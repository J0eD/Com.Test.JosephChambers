using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Test.JosephC
{
    public static class ElementExtensions
    {
        public static void WaitClickElement(this IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(BasePage._Driver, TimeSpan.FromSeconds(5));
            wait.Until(_driver => element.Displayed);
            element.Click();
        }

        public static void WaitSendElement(this IWebElement element, string text)
        {
            WebDriverWait wait = new WebDriverWait(BasePage._Driver, TimeSpan.FromSeconds(5));
            wait.Until(_driver => element.Displayed);
            element.SendKeys(text);
        }

        public static void ClickActionsElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(BasePage._Driver, TimeSpan.FromSeconds(5));
            Actions actions = new Actions(BasePage._Driver);
            wait.Until(_driver => element.Displayed);
            actions.MoveToElement(element).Click().Build().Perform();
        }

        public static void MoveToElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(BasePage._Driver, TimeSpan.FromSeconds(5));
            Actions actions = new Actions(BasePage._Driver);
            wait.Until(_driver => element.Displayed);
            actions.MoveToElement(element).Build().Perform();
        }

        public static void WaitURLIs(string uRL)
        {
            WebDriverWait wait = new WebDriverWait(BasePage._Driver, TimeSpan.FromSeconds(40));
            BasePage._Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(_driver => BasePage._Driver.Url.Contains(uRL));
        }
        public static void WaitURLEnds(string uRLChange)
        {
            WebDriverWait wait = new WebDriverWait(BasePage._Driver, TimeSpan.FromSeconds(40));
            BasePage._Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(_driver => BasePage._Driver.Url.EndsWith(uRLChange));
        }

        public static void AssertThroughItemRows(IList<IWebElement> element, string wordToAssert)
        {
            int maxRows = element.Count;
            Console.WriteLine(element.Count());
            for (int i = 0; i < maxRows; i++)
            {
                Console.WriteLine(element.ElementAt(i).Text);
                if (element.ElementAt(i).Text.Contains(wordToAssert))
                {
                    //Assert.IsTrue(element.ElementAt(i).Text.Contains(wordToAssert));
                    Assert.IsTrue(element.ElementAt(i).Text.Contains(wordToAssert));
                    break;
                }
            }
        }
    }

}
