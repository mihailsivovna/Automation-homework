using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Console.WriteLine(driver.Title);

            IWebElement userName = driver.FindElement(By.Name("email"));
            userName.SendKeys("");

            IWebElement password = driver.FindElement(By.Name("pass"));
            password.SendKeys("");
            Thread.Sleep(2000);

            IWebElement button3 = driver.FindElement(By.Id("loginbutton"));
            button3.Click();

            IWebElement button4 = driver.FindElement(By.ClassName("_1vp5"));
            button4.Click();

            Thread.Sleep(2000);
            IWebElement button5 = driver.FindElement(By.XPath("//a[@data-tab-key='friends']"));
            button5.Click();

            Thread.Sleep(2000);
            IWebElement button6 = driver.FindElement(By.XPath("//div[@class ='fsl fwb fcb']"));
            button6.Click();

            Thread.Sleep(2000);
            IWebElement button7 = driver.FindElement(By.XPath("//div[@class ='_1ktf']"));
            button7.Click();

            Thread.Sleep(2000);
            IWebElement button8 = driver.FindElement(By.XPath("//form[contains(@class,'fbPhotosSnowliftFeedbackForm')]//a[contains(@class,'UFILikeLink')]"));
            button8.Click();

            Thread.Sleep(2000);
            IWebElement button9 = driver.FindElement(By.XPath("//a[contains(@class,'_xlt _418x')]"));
            button9.Click();

            Thread.Sleep(2000);
            IWebElement button10 = driver.FindElement(By.XPath("//a[@data-referrerid ='100003385789583']"));
            button10.Click();

            Thread.Sleep(2000);
            IWebElement button11 = driver.FindElement(By.XPath("//form[contains(@class,'fbPhotosSnowliftFeedbackForm')]//a[contains(@class,'UFILikeLink')]"));
            button11.Click();

            Thread.Sleep(2000);
            IWebElement button12 = driver.FindElement(By.XPath("//a[contains(@class,'_xlt _418x')]"));
            button12.Click();





        }

    }
}

