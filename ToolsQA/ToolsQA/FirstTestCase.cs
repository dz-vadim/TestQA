using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ToolsQA
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            NUnitTest test = new NUnitTest();
            test.Initialize();
            test.TestApp();



            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com");
            //driver.Manage().Window.Maximize();
            //driver.Close();
            //driver.Quit();

        }
    }
}
