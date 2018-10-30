using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSample;

namespace UnitTest
{

    [TestClass]
    public class Tests
    {
        TestClass objt;
        string rvalue;

        [TestCleanup]
        public void TestClean()
        {
            objt = null;
            rvalue = String.Empty;
        }

        [TestInitialize]
        public void TestInit()
        {
            objt = new TestClass();
            rvalue = "done";
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(rvalue, objt.TestFun());
        }     
    }
}
