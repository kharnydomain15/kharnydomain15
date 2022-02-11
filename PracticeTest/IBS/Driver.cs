using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeTest.IBS

{
    sealed class Driver
    {
        public static IWebDriver GenerateWebDriver(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    return GenerateChromeDriverLocal();
               // case "firefox":
                  //  return GenerateFireFoxDriverLocal();

                default:
                    throw new SystemException("No driver class provided.");
            }
        }

        private static IWebDriver GenerateChromeDriverLocal()
        {
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();

            //this for headless
            options.AddArguments(new string[] { "--headless", "--window-size=1920,1080" });

            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromSeconds(180));
           
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(30));
           
            return driver;
        }

    }
}