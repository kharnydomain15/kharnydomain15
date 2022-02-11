using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;

namespace PracticeTest.IBS
{
    class VisitTestSuite : AssemblyBase
    {
        public VisitTestSuite(string parentUrl, string browser)
        {
            this.parentUrl = parentUrl;
            this.browser = browser;

        }

        [Test]
        public void First_test()
        {
            BasicActions.GotoWebsite(_driver, parentUrl);
            Assert.Pass();
        }

        [Test]
        public void Second_test()
        {
           
            BasicActions.GotoWebsite(_driver, parentUrl);
            //BrowserTestActions.drop(_driver);
           
            BrowserTestActions.enterEmail(_driver);
        
            BrowserTestActions.ndhover(_driver);
            BrowserTestActions.fillup(_driver);
            //BrowserTestActions.clickme(_driver);
            //Thread.Sleep(2000);
            //BrowserTestActions.phonenumclick(_driver);
            //BrowserTestActions.enternumber(_driver);

            // Console.WriteLine(BrowserTestActions.errorcode(_driver));
            // Assert.AreEqual("The email address or mobile number you entered isn't connected to an account. Find your account and log in.", BrowserTestActions.errorcode(_driver));
            Assert.Pass();
        }

        [Test]
        public void Third_test()
        {
            BasicActions.GotoWebsite(_driver, parentUrl);
            Assert.Pass();
        }
    }

}