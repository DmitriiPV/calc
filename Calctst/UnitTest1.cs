using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calctst
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTest()
        {
            // arrange
            string input = "1+5+7+9+0";
            decimal expected = 22;
            // act
            CALC.Calculate cl = new CALC.Calculate();
            decimal actual = cl.result(input);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumTest1()
        {
            // arrange
            string input = "1+(5*5)/2+6,35";
            decimal expected = 19.85m;
            // act
            CALC.Calculate cl = new CALC.Calculate();
            decimal actual = cl.result(input);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
