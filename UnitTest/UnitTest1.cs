using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramToTest;

namespace Unittest

{
    [TestClass]
    public class UnitTest1
    {
        Testable test;

        [TestMethod]
        public void CheckLastInt()
        {
            Assert.AreEqual(9, test.popI());
            test.pushI(9); //restore values 
        }

        [TestMethod]
        public void CheckLastDouble()
        {
            Assert.AreEqual(3.9, test.popD());
            test.pushD(3.9);
        }

        [TestMethod]
        public void CheckLastString()
        {
            Assert.AreEqual("TestString9", test.popS());
            test.pushS("TestString9");
        }

        [TestMethod]
        public void CheckFirstInt()
        {
            int lastInt = -1;
            int curInt;

            curInt = test.popI();
            while(curInt!=-1)
            {
                lastInt = curInt;
                curInt = test.popI();
            }
            Assert.AreEqual(0, lastInt);
        }

        [TestMethod]
        public void CheckFirstDouble()
        {
            double lastD = -1;
            double curD;

            curD = test.popD();
            while (curD != -1)
            {
                lastD = curD;
                curD = test.popD();
            }
            //Should throw an exception this is correct since there is a mistake in code
            Assert.AreEqual(0, lastD);
        }

        [TestMethod]
        public void CheckFirstString()
        {
            string lastS = "";
            string curS;

            curS = test.popS();
            while (curS != "")
            {
                lastS = curS;
                curS = test.popS();
            }
            Assert.AreEqual("TestString0", lastS);
        }



        [TestInitialize]
        public void Setup()
        {
            test = new Testable();
            
            //Add some testdata
                for(int j=0;j<10;j++)
                {
                    test.pushI(j); // 1 , 2 , 3
                    test.pushD(3 + (j * 0.1)); // 1.1 1.2 etc
                    test.pushS("TestString" + j);
                }
        }

        [TestCleanup]
        public void Cleanup()
        {

        }
    }
}
