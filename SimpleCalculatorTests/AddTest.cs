using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void AddWorks()
        {
            string mock_input = "1 + 2";
            Add items = new Add();
            Assert.AreEqual(3, items.AddItems(mock_input));
        }

        [TestMethod]
        public void AddWorksWithConstants()
        {
            string mock_input = "a + 2";
            Parser parse = new Parser();
            char toBeKey = char.Parse(parse.GetFirst(mock_input));
            int toBeKeyValue = int.Parse(parse.GetSecond(mock_input));
            Constant constant = new Constant();
            constant.AddConstant(toBeKey, 1);
            Add items = new Add();
            Assert.AreEqual(3, items.AddConstants(mock_input, constant));
        }
    }
}
