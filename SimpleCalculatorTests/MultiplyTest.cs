using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class MultiplyTest
    {
        [TestMethod]
        public void MultiplyWorks()
        {
            string mock_input = "1 * 2";
            Multiply addItems = new Multiply();
            Assert.AreEqual(2, addItems.MultiplyItems(mock_input));
        }

        [TestMethod]
        public void MultiplyWorksWithConstants()
        {
            string mock_input = "a * 2";
            Parser parse = new Parser();
            char toBeKey = char.Parse(parse.GetFirst(mock_input));
            int toBeKeyValue = int.Parse(parse.GetSecond(mock_input));
            Constant constant = new Constant();
            constant.AddConstant(toBeKey, 1);
            Multiply items = new Multiply();
            Assert.AreEqual(2, items.MultiplyConstants(mock_input, constant));
        }
    }
}
