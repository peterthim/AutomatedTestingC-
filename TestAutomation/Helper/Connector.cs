using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation.Helpers
{
    public enum Browser { Chrome, Firefox, IE, Edge, PhantomJs };
    public enum ElementType { Id, Class, Name, Type };

    public static class Connector
    {
        private static Browser selectedDriver;
        private static IWebDriver driver;
        private static string prevUrl;


        /// <summary>
        /// Connect to a given url with a given browser 
        /// </summary>
        /// <param name="url">connect to the url</param>
        /// <param name="browser">select Browser from the Browser Enum</param>
        /// <returns>Webdriver selected</returns>
        public static IWebDriver Connect(string url, Browser browser = Browser.Chrome)
        {
            if((selectedDriver == browser) && (prevUrl == url) && (driver != null))
            {
                //do nothing we just return the prev. object.
            }
            else
            {
                selectedDriver = browser;
                prevUrl = url;

                switch (browser)
                {
                    default:
                    case Browser.Chrome:
                        driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                        break;
                    case Browser.Firefox:
                        driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
                        break;
                    case Browser.Edge:
                        driver = new OpenQA.Selenium.Edge.EdgeDriver();
                        break;
                    case Browser.IE:
                        driver = new OpenQA.Selenium.IE.InternetExplorerDriver();
                        break;
                    case Browser.PhantomJs:
                        driver = new OpenQA.Selenium.PhantomJS.PhantomJSDriver();
                        break;
                }
                driver.Url = url;
            }
           
            return driver;
        }


        /// <summary>
        ///  fetches the selected Browser string
        /// </summary>
        /// <returns>enum of browser set</returns>
        public static Browser getSelectedBrowser()
        {
            return selectedDriver;
        }


        /// <summary>
        ///  disconnect the browser and all its sub browsers
        /// </summary>
        public static void Disconnect()
        {
            driver.Quit();
            driver = null;
        }



    }
}
