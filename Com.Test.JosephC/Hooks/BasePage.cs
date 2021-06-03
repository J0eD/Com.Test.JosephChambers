using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Com.Test.JosephC
{
    public class BasePage
    {
        public static IWebDriver _Driver;

        public IWebDriver driver
        {
            get
            {
                return _Driver;
            }
            set
            {
                _Driver = value;
            }
        
        }

    }
}
