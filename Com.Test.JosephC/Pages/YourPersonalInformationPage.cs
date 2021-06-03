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
    public class YourPersonalInformationPage : BasePage
    {
        IWebElement FirstNameField => driver.FindElement(By.Id("firstname"));
        IWebElement OldPasswordField => driver.FindElement(By.Id("old_passwd"));
        IWebElement SaveButton => driver.FindElements(By.CssSelector("button[type='submit']")).ElementAt(1);
        IWebElement SuccessAlert => driver.FindElement(By.CssSelector("p[class$='alert-success']"));
        IWebElement UserAccountName => driver.FindElement(By.CssSelector("div[class='header_user_info']>a>span"));
        //
        public static string previousName;
        public static string newName;


        public void AssertUpdatedInformation()
        {
            Thread.Sleep(800);
            Assert.IsTrue(SuccessAlert.Displayed);
            Assert.IsTrue(SuccessAlert.Text.Contains("Your personal information has been successfully updated"));
            Assert.IsTrue(UserAccountName.Text.Contains(newName));
        }
        public void EditFirstNameField()
        {
            MyAccountPage Map = new MyAccountPage();
            Map.ClickMyPersonalInformation();
            PageIntro();
            previousName = FirstNameField.GetAttribute("value");
            Console.WriteLine(previousName);
            ElementExtensions.WaitClickElement(FirstNameField);
            FirstNameField.Clear();
            if(previousName == "Joe")
            {
                ElementExtensions.WaitSendElement(FirstNameField, "Josif");
                newName = "Josif";
            }
            else
            {
                ElementExtensions.WaitSendElement(FirstNameField, "Joe");
                newName = "Joe";
            }
            ElementExtensions.WaitClickElement(OldPasswordField);
            ElementExtensions.WaitSendElement(OldPasswordField, "Test123");
            ClickSave();
        }

        public void ClickSave()
        {
            ElementExtensions.WaitClickElement(SaveButton);
        }
        public void PageIntro()
        {
            ElementExtensions.WaitURLIs("http://automationpractice.com/index.php?controller=identity");
            Thread.Sleep(500);
        }
    }
}
