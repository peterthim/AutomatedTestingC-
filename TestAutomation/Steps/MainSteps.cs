using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestAutomation.Helpers;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace TestAutomation
{

   /// <summary>
   /// Base class that all step classes should inherit from to get basic functionality in one place.
   /// </summary>
    [Binding]
    public class MainSteps
    {
        public static string testUri = "http://www.phptravels.net/";
        IWebDriver driver;
        IWebElement lastElement;
        bool elementStatus;


        public void Startup(string url,Browser browser = Browser.Chrome)
        {
            driver = Connector.Connect(url, browser);

            try
            {
                lastElement = WaitForElement(ElementType.Type, "body", 10);
                elementStatus = true;
            }
            catch(TimeoutException ex)
            {
                elementStatus = false;
                Console.Write("TIMEOUT "+ex);
            }

            
        }

        public void BrowseToUrl(string url)
        {
            driver.Url = url;
        }

        public void Shutdown()
        {
            driver.Quit();
            Connector.Disconnect();
        }

        /// <summary>
        /// Wait for a given element found on the driver
        /// </summary>
        /// <param name="type">What are you matching against id,class,name etc matches Helpers.Connector.ElementType  default tagType </param>
        /// <param name="ElementName">Tag data to look for default body tag </param>
        /// <param name="TimeoutSeconds">seconds before the wait will fail default 10s</param>
        /// <returns></returns>
        public IWebElement WaitForElement(ElementType type = ElementType.Type, string ElementName = "body",  int TimeoutSeconds=10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeoutSeconds));

            IWebElement myDynamicElement = null;

            switch(type)
            {
                case ElementType.Id:
                    myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Id(ElementName)));
                    break;
                case ElementType.Class:
                    myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.ClassName(ElementName)));
                    break;
                case ElementType.Name:
                    myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Name(ElementName)));
                    break;
                case ElementType.Type:
                    myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.TagName(ElementName)));
                    break;
                default:
                    myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.XPath(ElementName)));
                    break;

            }
            return myDynamicElement;
        }


        public IWebElement WaitForClickable(ElementType type = ElementType.Type, string ElementName = "body", int TimeoutSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeoutSeconds));

            IWebElement myDynamicElement = null;

            switch (type)
            {
                case ElementType.Id:
                    myDynamicElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(ElementName)));
                    break;
                case ElementType.Class:
                    myDynamicElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName(ElementName)));
                    break;
                case ElementType.Name:
                    myDynamicElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(ElementName)));
                    break;
                case ElementType.Type:
                    myDynamicElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.TagName(ElementName)));
                    break;
                default:
                    myDynamicElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ElementName)));
                    break;

            }
            return myDynamicElement;
        }


        /// <summary>
        ///  Wait statement to wait X amount of milliseconds before executing next statment
        /// </summary>
        /// <param name="ms">miliseconds to wait default 1000</param>
        public void Wait(int ms=1000)
        {
            System.Threading.Thread.Sleep(ms);
        }


    }
}
