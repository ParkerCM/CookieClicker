using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace CookieClicker
{
    class CookieClicker
    {
        private readonly String COOKIE = "//*[@id='bigCookie']";

        public CookieClicker()
        {
            GoToURL();
        }

        void GoToURL()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://orteil.dashnet.org/cookieclicker/");

            var cookie = Driver.FindElement(By.XPath(this.COOKIE));

            while (true)
            {
                cookie.Click();
            }
        }
    }
}
