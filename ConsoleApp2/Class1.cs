using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;


namespace ConsoleApp2
{

    public class Class1
    {
        [Test]
        public void SearchForWord()
        {
            var driver = new ChromeDriver();

            {

                driver.Navigate().GoToUrl("http://www.google.com/");


                IWebElement query = driver.FindElement(By.Name("q"));


                Console.WriteLine(driver.Title);


                query.Submit();



                driver.Quit();
            }

        }
    }
}
