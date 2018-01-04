using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;


namespace TestAutomation
{
    /// <summary>
    /// Test site home page 
    /// </summary>
    [Binding]
    public sealed class PhpTravelHomeSteps : MainSteps
    {


        [Then(@"there should be a correct logo")]
        public void ThenThereShouldBeACorrectLogo()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
