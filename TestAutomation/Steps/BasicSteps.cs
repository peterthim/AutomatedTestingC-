using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;


namespace TestAutomation
{
    [Binding]
    public sealed class BasicSteps: MainSteps
    {

        [Given(@"i have started browser and browsed to the site")]
        public void GivenIHaveStartedBrowserAndBrowsedToTheSite()
        {
            // dealt with by the Specflow flags below but this can be expanded to meet the needs of the project
            Startup(testUri);
        }


        [Given(@"Im on the testSite")]
        public void GivenImOnTheTestSite()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
