using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ConstantTest
    {
        [TestMethod]
        public void ConstantEnsureICanCreateConstant()
        {
            Constant constant = new Constant();
            Assert.IsNotNull(constant);
        }

        [TestMethod]
        public void ConstantEnsureICanAddConstantToDictionary()
        {
            Constant constant = new Constant();
            constant.AddConstant('x', 5);
            int result;
            constant.constant_dictionary.TryGetValue('x', out result);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ConstantEnsureICanRetrieveFromDictionary()
        {
            Constant constant = new Constant();
            constant.AddConstant('x', 5);
            Assert.AreEqual(5, constant.GetConstant('x'));
        }


    }
}
