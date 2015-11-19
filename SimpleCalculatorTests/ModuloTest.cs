using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ModuloTest
    {
        [TestMethod]
        public void ModuloWorks()
        {
            string mock_input = "2 % 2";
            Modulo addItems = new Modulo();
            Assert.AreEqual(0, addItems.ModuloItems(mock_input));
        }

        [TestMethod]
        public void ModuloWorksWithConstants()
        {
            string mock_input = "a % 2";
            Parser parse = new Parser();
            char toBeKey = char.Parse(parse.GetFirst(mock_input));
            int toBeKeyValue = int.Parse(parse.GetSecond(mock_input));
            Constant constant = new Constant();
            constant.AddConstant(toBeKey, 5);
            Modulo items = new Modulo();
            Assert.AreEqual(1, items.ModuloConstants(mock_input, constant));
        }
    }
}
