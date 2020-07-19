using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestApp()
        {
            driver.Url = "https://google.com.ua";
            driver.FindElement(By.Name("q")).Click();
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("selenium");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
