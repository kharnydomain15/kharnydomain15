using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeTest.IBS
{
	class BrowserTestActions
	{

		public static void enterEmail(IWebDriver driver)
		{
			//hover products 
			WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			IWebElement D = wait1.Until(e => e.FindElement(By.XPath("//a[@class='[ nav-link ]']")));

			Actions act = new Actions(driver);
			act.MoveToElement(D).Perform();

			//hover Products
			WebDriverWait wait11 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			IWebElement A = wait11.Until(e => e.FindElement(By.XPath("//li[@class='[ nav-panel-item ]']")));
			Actions act1 = new Actions(driver);
			act1.MoveToElement(A).Perform();

			//hover star-ships and clicking it
			WebDriverWait wait111 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			IWebElement Q = wait111.Until(e => e.FindElement(By.XPath("//a[@href='/products/circuit-protection/fuses/']")));
			Actions act11 = new Actions(driver);
			act11.MoveToElement(Q).Perform();
			Q.Click();

			//hover the contact us and clicking it
			WebDriverWait wait21 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			IWebElement C = wait21.Until(e => e.FindElement(By.CssSelector("body > div > footer > div:nth-child(1) > div > div > div > div:nth-child(5) > div:nth-child(4) > a")));
			Actions act21 = new Actions(driver);
			act21.MoveToElement(C).Perform();
			C.Click();


			//contact location
			WebDriverWait wait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var dropdown = wait10.Until(e => e.FindElement(By.XPath("//select[@class='form-control placeholder-gray-400']")));
			dropdown.Click();
			dropdown.SendKeys("Option 2");
			dropdown.SendKeys(Keys.Enter);

			//first name
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var emailInput = wait.Until(e => e.FindElement(By.XPath("//input[@placeholder='First Name']")));
			emailInput.SendKeys("test run");

			//Lastname
			WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var emailInput1 = wait2.Until(e => e.FindElement(By.XPath("//input[@placeholder='Last Name']")));
			emailInput1.SendKeys("running test");

			//email name
			WebDriverWait wait33 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var emailInput33 = wait33.Until(e => e.FindElement(By.XPath("//input[@placeholder='Enter Email']")));
			emailInput33.SendKeys("Wazzuup11@gmail.com");

			//phone number
			WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var emailInput3 = wait.Until(e => e.FindElement(By.XPath("//input[@placeholder='XXX-XXX-XXXX']")));
			emailInput3.SendKeys("09121212121");

			//company name
			WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var emailInput4 = wait4.Until(e => e.FindElement(By.XPath("//input[@placeholder='Enter Company']")));
			emailInput4.SendKeys("innovuze");

			//company type
			WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var emailInput5 = wait5.Until(e => e.FindElement(By.XPath("//input[@placeholder='Enter Type']")));
			emailInput5.SendKeys("IT Solutions");


			//company type
			WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var emailInput6 = wait6.Until(e => e.FindElement(By.XPath("//textarea[@placeholder='Enter Comments']")));
			emailInput6.SendKeys("hey wazupppppppppppp\n hellooooooo woooooorlldddddddddd \n hey wazupppppppppppp hellooooooo\nwoooooorlldddddddddd");

			WebDriverWait wait12 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn = wait12.Until(e => e.FindElement(By.XPath("//input[@value='Submit']")));
			clickbtn.Click();





		}
		public static void ndhover(IWebDriver driver)
		{

			//hover products 

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn2 = wait.Until(e => e.FindElement(By.XPath("//div[@class='[ limit ] flex items-center']")));

			WebDriverWait wait0 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			//Task.Delay(2000).Wait();
			var clickbtn = wait0.Until(e => e.FindElement(By.XPath("//span[@title='Products']")));
			//wait0.Until(e => clickbtn.Displayed);
			// Console.WriteLine(clickbtn.Displayed);
			Actions act11 = new Actions(driver);
			act11.MoveToElement(clickbtn).Perform();
			clickbtn.Click();

			WebDriverWait wait40 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn40 = wait40.Until(e => e.FindElement(By.CssSelector("body > div > main > div:nth-child(3) > div > a:nth-child(2)")));
			Console.WriteLine(clickbtn40.Displayed);


			WebDriverWait wait19 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn23 = wait19.Until(e => e.FindElement(By.CssSelector("body > div > main > div:nth-child(3) > div > a:nth-child(2)")));
			clickbtn23.Click();

			WebDriverWait wait20 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn20 = wait20.Until(e => e.FindElement(By.XPath("//a[@href='/products/te-connectivity/0-0735187-2/']")));
			clickbtn20.Click();

			WebDriverWait wait21 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn21 = wait21.Until(e => e.FindElement(By.XPath("//a[@href='/contact-us/quote-request/']")));
			clickbtn21.Click();

			//WebDriverWait wait30 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			//	var clickbtn30 = wait30.Until(e => e.FindElement(By.XPath("//a[@href='']")));


		}

		public static void fillup(IWebDriver driver)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input = wait.Until(e => e.FindElement(By.XPath("//input[@placeholder='input']")));
			input.SendKeys("hey");

			WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input2 = wait1.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[1]/input")));
			input2.SendKeys("123");

			WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input3 = wait2.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[2]/input")));
			input3.SendKeys("2");

			WebDriverWait wait22 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input32 = wait22.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[3]/input")));
			input32.SendKeys("$900");

			WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var drop = wait5.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[4]/select/option[9]")));
			drop.Click();

			WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input4 = wait3.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[1]/div[2]/div[2]/table/tbody/tr[3]/td[1]/input")));
			input4.SendKeys("4443434232");

			WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input6 = wait6.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[2]/div[1]/input")));
			input6.SendKeys("test run");

			WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input7 = wait7.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[2]/div[2]/input")));
			input7.SendKeys("QA test");

			WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input8 = wait8.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[2]/div[3]/input")));
			input8.SendKeys("krosalejos@innovuze.com");

			WebDriverWait wait9 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input9 = wait9.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[2]/div[5]/input")));
			input9.SendKeys("KIER");

			WebDriverWait wait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input10 = wait10.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[2]/div[6]/input")));
			input10.SendKeys("Computer Company");

			WebDriverWait wait11 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input11 = wait11.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[2]/div[7]/textarea")));
			input11.SendKeys("hey this is our product in the i don't know");

			WebDriverWait wait12 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var input12 = wait12.Until(e => e.FindElement(By.XPath("/html/body/div/main/div[3]/div[2]/section/div[2]/div[9]/button")));
			input12.Click();

		}


		public static void clickme(IWebDriver driver)
		{

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn = wait.Until(e => e.FindElement(By.Id("selectioni1")));
			clickbtn.Click();
			WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn1 = wait1.Until(e => e.FindElement(By.CssSelector("#accountDetailsNext > div > button")));
			clickbtn1.Click();





		}

		public static void phonenumclick(IWebDriver driver)
		{

			WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn2 = wait2.Until(e => e.FindElement(By.CssSelector("#phoneNumberId")));
			clickbtn2.Click();
		}
		public static void enternumber(IWebDriver driver)
		{
			//long num = 10;

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var numInput = wait.Until(e => e.FindElement(By.CssSelector("#phoneNumberId")));
			numInput.SendKeys("" + 9515565707);

			WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var clickbtn = wait1.Until(e => e.FindElement(By.CssSelector("#view_container > div > div > div.pwWryf.bxPAYd > div > div.zQJV3 > div > div.qhFLie > div > div > button")));
			clickbtn.Click();

			//var numInput = wait.Until(e => e.FindElement(By.CssSelector("#phoneNumberId"))).GetAttribute("value");
			//numInput = "123";

		}

		public static string errorcode(IWebDriver driver)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
			var errortxt = wait.Until(e => e.FindElement(By.ClassName("_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy")));
			return errortxt.Text;

		}

	}
}
