using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomation.Helpers;

namespace TestAutomation
{
    [Binding]
    public static class TestSetup
    {
       

        [BeforeTestRun]
        public static void PreTestSuite()
        {
            
        }

        [BeforeScenario]
        public static void PreTest()
        {

        }

        [AfterScenario]
        public static void AfterTest()
        {
            //do nothing its always better to reset all data in before then in After
        }

        [AfterTestRun]
        public static void AfterTestSuite()
        {

        }
    }
}
