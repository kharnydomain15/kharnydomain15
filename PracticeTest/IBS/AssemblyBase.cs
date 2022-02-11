using NUnit.Framework;
using OpenQA.Selenium;


[assembly: NonParallelizable]
namespace PracticeTest.IBS
{
    [TestFixture(new object[] { "https://www-stage.ibselectronics.com/", "chrome" }, Category = "Stage-Chrome")]
    [TestFixture(new object[] { "https://www.google.com/", "chrome" }, Category = "Prod-Chrome")]

    abstract class AssemblyBase
    {
        protected string parentUrl, browser;
        protected IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = Driver.GenerateWebDriver(browser);
     
            
        }

        [TearDown]
        public void Cleanup()
        {
            //_driver.Quit();
        }
    }
}