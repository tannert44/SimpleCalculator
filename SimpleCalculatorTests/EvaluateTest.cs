using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void EvaluateEnsureICanCreateEvaluateInstance()
        {
            Evaluate newSession = new Evaluate();
            Assert.IsNotNull(newSession);
        }

        [TestMethod]
        public void EvaluateInputWorksForAddition()
        {
            string input = "1+5";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(6 ,newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputWorksForConstantAddition()
        {
            string input = "a+5";
            Constant constant = new Constant();
            constant.AddConstant('a', 1);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(6, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputWorksForConstantAdditionBackwards()
        {
            string input = "7+a";
            Constant constant = new Constant();
            constant.AddConstant('a', 5);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(12, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputWorksForSubtract()
        {
            string input = "1-5";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(-4, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputWorksForConstantSubtract()
        {
            string input = "a-5";
            Constant constant = new Constant();
            constant.AddConstant('a', 7);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(2, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputWorksForMultiply()
        {
            string input = "1*5";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(5, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputWorksForConstantMultiply()
        {
            string input = "a*5";
            Constant constant = new Constant();
            constant.AddConstant('a', 1);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(5, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputWorksForDivision()
        {
            string input = "10/5";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(2, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputWorksForConstantDivision()
        {
            string input = "a/5";
            Constant constant = new Constant();
            constant.AddConstant('a', 10);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(2, newSession.EvaluateInput(input, constant));
        }

        [TestMethod]
        public void EvaluateInputWorksForModulo()
        {
            string input = "11%5";
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(1, newSession.EvaluateInput(input));
        }

        [TestMethod]
        public void EvaluateInputWorksForConstantModulo()
        {
            string input = "a%5";
            Constant constant = new Constant();
            constant.AddConstant('a', 11);
            Evaluate newSession = new Evaluate();
            Assert.AreEqual(1, newSession.EvaluateInput(input, constant));
        }
    }
}
