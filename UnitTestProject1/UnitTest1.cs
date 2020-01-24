using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMathLib;
using System;

namespace UnitTestProject1
{
    /// <summary>
    ///This is a test class for MathClassTest and is intended
    ///to contain all MathClassTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MathClassTest
    {
        private readonly MathClass target;

        public MathClassTest()
        {
            target = new MathClass();
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        //[DeploymentItem("SimpleMathLib.dll")]
        [TestCategory("UnitTest")]
        public void AddTest()
        {
            MathClass target = new MathClass();

            int a = 2;
            int b = 3;
            int expected = 5;
            int actual = 0;

            actual = target.Add(a, b);
            Assert.AreEqual(expected, actual, 1, "You are getting close!");        
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void AddDataTest(int a, int b, int expected)
        {
            MathClass target = new MathClass();

            int actual = target.Add(a, b);
            Assert.AreEqual(expected, actual);        
        }
        
        /// <summary>
        ///A test for Multiply
        ///</summary>
        [TestMethod()]
        //[DeploymentItem("SimpleMathLib.dll")]
        public void MultiplyTest()
        {
            MathClass target = new MathClass();
            
            int a = 5;
            int b = 5;
            int expected = 25;
            int actual = 0;
            actual = target.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Subtract
        ///</summary>
        [TestMethod()]
        //[DeploymentItem("SimpleMathLib.dll"), TestCategory("UnitTest")]
        public void SubtractTest()
        {
            MathClass target = new MathClass(); 
            
            int a = 10; 
            int b = 5; 
            int expected = 5;
            int actual = 0;
            actual = target.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Divide
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideTest()
        {
            MathClass target = new MathClass();

            int a = 25;
            int b = 0;
            int expected = 0;
            int actual = 0;
            actual = target.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Data.csv", "Data#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void MultiplyTestDataTest()
        {
            //MathClass target = new MathClass();

            //var a = int.Parse(TestContext.DataRow["value1"].ToString());
            //var b = int.Parse(TestContext.DataRow["value2"].ToString());
            //var expected = int.Parse(TestContext.DataRow["expected"].ToString());
            
            //Assert.AreEqual(target.Multiply(a, b), expected);
        }
    }
}
