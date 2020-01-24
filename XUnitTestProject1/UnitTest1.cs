using System;
using Xunit;
using SimpleMathLib;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly MathClass target;

        public UnitTest1()
        {
            target = new MathClass();
        }

        [Fact]
        /// <summary>
        ///A test for Add
        ///</summary>
        public void AddTest()
        {
            int a = 2;
            int b = 3;
            int expected = 5;
            int actual = 0;

            actual = target.Add(a, b);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        ///A test for Multiply
        ///</summary>
        [Fact]
        public void MultiplyTest()
        {
            MathClass target = new MathClass();

            int a = 5; // TODO: Initialize to an appropriate value
            int b = 5; // TODO: Initialize to an appropriate value
            int expected = 25; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Multiply(a, b);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        ///A test for Subtract
        ///</summary>
        [Fact]
        public void SubtractTest()
        {
            MathClass target = new MathClass();

            int a = 10;
            int b = 5;
            int expected = 5;
            int actual = 0;
            actual = target.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        /// <summary>
        ///A test for Divide
        ///</summary>

        [Fact]
        public void DivideTest()
        {
            MathClass target = new MathClass();

            int a = 25; // TODO: Initialize to an appropriate value
            int b = 5; // TODO: Initialize to an appropriate value
            int expected = 5
                ; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Divide(a, b);
            Assert.Equal(expected, actual);
        }


    }
}
