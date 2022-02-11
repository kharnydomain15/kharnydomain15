using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace PracticeTest
{
    class BasicActions
    {
        public static void GotoWebsite(IWebDriver driver, string parentUrl)
        {
            var url = parentUrl;
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            var count = 0;
            var maxTries = 3;
            while (true)
            {
                try
                {
                    driver.Navigate().GoToUrl(url);
                    break;
                }
                catch (WebDriverException e)
                {
                    if (++count == maxTries) throw e;
                }
            }


        }
    }
}