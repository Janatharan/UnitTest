using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestSample;

namespace UnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddmethod()
        {
            var calculator = new Calculator();
            int? result = calculator.Add(4, 3);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestInputValue()
        {
            var calculator = new Calculator();
            int? result = calculator.Add(5, null);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),"Test")]
        public void TestMaximunInputValue()
        {
            var calculator = new Calculator();
            int? result = calculator.Add(551, 5);
            
        }

        [TestMethod]
        public void TestNethodUsingMOQ()
        {
            Mock<CheckEmployee> chk = new Mock<CheckEmployee>();
            chk.Setup(x => x.CheckEmp()).Returns(true);

            ProcessEmployee obje = new ProcessEmployee();
            Assert.AreEqual(obje.InsertEmployee(chk.Object), true);
        }

        [TestMethod]
        public void TestGetSomeString()
        {
            const string EXPECTED_STRING = "Hello World";
            Mock<IDependance> myMock = new Mock<IDependance>();
            myMock.Setup(m => m.GiveMeAString()).Returns("Hello World");
            MyClass myobject = new MyClass();
            string someString = myobject.GetSomeString(myMock.Object);
            Assert.AreEqual(EXPECTED_STRING, someString);
            myMock.VerifyAll();
        }
    }
}