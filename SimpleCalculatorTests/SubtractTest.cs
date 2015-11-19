using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class SubtractTest
    {
        [TestMethod]
        public void SubtractWorks()
        {
            string mock_input = "1 - 2";
            Subtract addItems = new Subtract();
            Assert.AreEqual(-1, addItems.SubtractItems(mock_input));
        }

        [TestMethod]
        public void SubtractWorksWithConstants()
        {
            string mock_input = "a - 2";
            Parser parse = new Parser();
            char toBeKey = char.Parse(parse.GetFirst(mock_input));
            int toBeKeyValue = int.Parse(parse.GetSecond(mock_input));
            Constant constant = new Constant();
            constant.AddConstant(toBeKey, 1);
            Subtract items = new Subtract();
            Assert.AreEqual(-1, items.SubtractConstants(mock_input, constant));
        }
    }
}
