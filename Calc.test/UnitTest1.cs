using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calc.test
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
        [TestMethod]
        public void FuncTestsqrt()
        {
            string s = "sqrt";
            string input = "81";
            string expected = "9";
            CALC.Calculate cl = new CALC.Calculate();
            string actual = cl.Calcfnc(input,s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FuncTestsqrt1()
        {
            string s = "sqrt";
            string input = "81+9";
            string expected = "81+3";
            CALC.Calculate cl = new CALC.Calculate();
            string actual = cl.Calcfnc(input, s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FuncTestx2()
        {
            string s = "x2";
            string input = "4";
            string expected = "16";
            CALC.Calculate cl = new CALC.Calculate();
            string actual = cl.Calcfnc(input, s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FuncTestsin()
        {
            string s = "sin";
            string input = "9";
            string expected = "0,412118485241757";
            CALC.Calculate cl = new CALC.Calculate();
            string actual = cl.Calcfnc(input, s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FuncTestcos()
        {
            string s = "cos";
            string input = "6";
            string expected = "0,960170286650366";
            CALC.Calculate cl = new CALC.Calculate();
            string actual = cl.Calcfnc(input, s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FuncTestfib()
        {
            string s = "fib";
            string input = "5";
            string expected = "120";
            CALC.Calculate cl = new CALC.Calculate();
            string actual = cl.Calcfnc(input, s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FuncTesttgn()
        {
            string s = "tgn";
            string input = "0,5";
            string expected = "0,54630248984379";
            CALC.Calculate cl = new CALC.Calculate();
            string actual = cl.Calcfnc(input, s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AuthTest1()
        {
            string user = "usersdsd";
            string password = "12345";
            int expected = 0;
            CALC.DB db = new CALC.DB();
            int actual = db.Aut(user, password);
            Assert.AreEqual(expected, actual);
        }
    }
}
