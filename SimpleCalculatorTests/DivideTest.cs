using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class DivideTest
    {
        [TestMethod]
        public void DivideWorks()
        {
            string mock_input = "2 / 2";
            Divide addItems = new Divide();
            Assert.AreEqual(1, addItems.DivideItems(mock_input));
        }

        [TestMethod]
        public void DivideWorksWithConstants()
        {
            string mock_input = "a / 2";
            Parser parse = new Parser();
            char toBeKey = char.Parse(parse.GetFirst(mock_input));
            int toBeKeyValue = int.Parse(parse.GetSecond(mock_input));
            Constant constant = new Constant();
            constant.AddConstant(toBeKey, 2);
            Divide items = new Divide();
            Assert.AreEqual(1, items.DivideConstants(mock_input, constant));
        }
    }
}
