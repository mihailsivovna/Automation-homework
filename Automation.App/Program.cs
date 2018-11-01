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

            IWebElement username = driver.FindElement(By.Name("email"));
            username.SendKeys("");

            IWebElement password = driver.FindElement(By.Name("pass"));
            password.SendKeys("");
            Thread.Sleep(2000);

            IWebElement closenotification = driver.FindElement(By.Id("loginbutton"));
            closenotification.Click();

            IWebElement profile = driver.FindElement(By.ClassName("_1vp5"));
            profile.Click();

            Thread.Sleep(2000);
            IWebElement friends = driver.FindElement(By.XPath("//a[@data-tab-key='friends']"));
            friends.Click();

            Thread.Sleep(2000);
            IWebElement friend = driver.FindElement(By.XPath("//div[@class ='fsl fwb fcb']"));
            friend.Click();

            Thread.Sleep(2000);
            IWebElement photo = driver.FindElement(By.XPath("//div[@class ='_1ktf']"));
            photo.Click();

            Thread.Sleep(2000);
            IWebElement like = driver.FindElement(By.XPath("//form[contains(@class,'fbPhotosSnowliftFeedbackForm')]//a[contains(@class,'UFILikeLink')]"));
            like.Click();

            Thread.Sleep(2000);
            IWebElement close = driver.FindElement(By.XPath("//a[contains(@class,'_xlt _418x')]"));
            close.Click();

            Thread.Sleep(2000);
            IWebElement nextphoto = driver.FindElement(By.XPath("//a[@data-referrerid ='100003385789583']"));
            nextphoto.Click();

            Thread.Sleep(2000);
            IWebElement nextlike = driver.FindElement(By.XPath("//form[contains(@class,'fbPhotosSnowliftFeedbackForm')]//a[contains(@class,'UFILikeLink')]"));
            nextlike.Click();

            Thread.Sleep(2000);
            IWebElement nextclose = driver.FindElement(By.XPath("//a[contains(@class,'_xlt _418x')]"));
            nextclose.Click();





        }

    }
}

