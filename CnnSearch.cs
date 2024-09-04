// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_First {
    class CnnSearch {
        static void Main(string[] args) {
            Console.WriteLine("Hi, this is Preetham");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.cnn.com/";
            By elem = By.XPath("/html/body/header/div/nav/div/div/div[1]/div[2]/button");
            IWebElement searchicon = driver.FindElement(elem);
            searchicon.Click();
            IWebElement searchbar = driver.FindElement(By.XPath("/html/body/header/div/nav/div/div/div[2]/div/div[1]/form/input"));
            Thread.Sleep(5000);
            searchbar.SendKeys("wars");
            searchbar.SendKeys(Keys.Enter);

        }
    }
}
