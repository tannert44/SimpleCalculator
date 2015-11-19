using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void ParserEnsureICanCreateInstanceOfParser()
        {
            Parser parse = new Parser();
            Assert.IsNotNull(parse);
        }

        [TestMethod]
        public void ParserEnsureGetFirstWorksWithSpaces()
        {
            string input = "2 + 2";
            Parser parse = new Parser();
            Assert.AreEqual("2", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParserEnsureGetFirstWorksWithoutSpaces()
        {
            string input = "2+2";
            Parser parse = new Parser();
            Assert.AreEqual("2", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParserEnsureGetFirstWorksWithNegativeIntegersSpaces()
        {
            string input = "-2 + 2";
            Parser parse = new Parser();
            Assert.AreEqual("-2", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParserEnsureGetFirstWorksWithNegativeIntegersNoSpaces()
        {
            string input = "-2+2";
            Parser parse = new Parser();
            Assert.AreEqual("-2", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParserEnsureGetFirstWorksWithConstantsNoSpaces()
        {
            string input = "a+2";
            Parser parse = new Parser();
            Assert.AreEqual("a", parse.GetFirst(input));
        }
        [TestMethod]
        public void ParserEnsureGetFirstWorksWithConstantsSpaces()
        {
            string input = "a + 2";
            Parser parse = new Parser();
            Assert.AreEqual("a", parse.GetFirst(input));
        }



        [TestMethod]
        public void ParserEnsureGetOperatorWorksWithSpaces()
        {
            string input = "2 + 2";
            Parser parse = new Parser();
            Assert.AreEqual('+', parse.GetOperator(input));
        }
        [TestMethod]
        public void ParserEnsureGetOperatorWorksWithoutSpaces()
        {
            string input = "2+2";
            Parser parse = new Parser();
            Assert.AreEqual('+', parse.GetOperator(input));
        }
        [TestMethod]
        public void ParserEnsureGetOperatorWorksWithNegativeIntegersSpaces()
        {
            string input = "-2 + 2";
            Parser parse = new Parser();
            Assert.AreEqual('+', parse.GetOperator(input));
        }
        [TestMethod]
        public void ParserEnsureGetOperatorWorksWithNegativeIntegersNoSpaces()
        {
            string input = "-2+2";
            Parser parse = new Parser();
            Assert.AreEqual('+', parse.GetOperator(input));
        }
        [TestMethod]
        public void ParserEnsureGetOperatorWorksWithConstantsNoSpaces()
        {
            string input = "a+2";
            Parser parse = new Parser();
            Assert.AreEqual('+', parse.GetOperator(input));
        }
        [TestMethod]
        public void ParserEnsureGetOperatorWorksWithConstantsSpaces()
        {
            string input = "a + 2";
            Parser parse = new Parser();
            Assert.AreEqual('+', parse.GetOperator(input));
        }



        [TestMethod]
        public void ParserEnsureGetSecondWorksWithSpaces()
        {
            string input = "2 + 2";
            Parser parse = new Parser();
            Assert.AreEqual("2", parse.GetSecond(input));
        }
        [TestMethod]
        public void ParserEnsureGetSecondWorksWithoutSpaces()
        {
            string input = "2+2";
            Parser parse = new Parser();
            Assert.AreEqual("2", parse.GetSecond(input));
        }
        [TestMethod]
        public void ParserEnsureGetSecondWorksWithNegativeIntegersSpaces()
        {
            string input = "2 + -2";
            Parser parse = new Parser();
            Assert.AreEqual("-2", parse.GetSecond(input));
        }
        [TestMethod]
        public void ParserEnsureGetSecondWorksWithNegativeIntegersNoSpaces()
        {
            string input = "2+ -3";
            Parser parse = new Parser();
            Assert.AreEqual("-3", parse.GetSecond(input));
        }
        [TestMethod]
        public void ParserEnsureGetSecondWorksWithConstantsNoSpaces()
        {
            string input = "2+a";
            Parser parse = new Parser();
            Assert.AreEqual("a", parse.GetSecond(input));
        }
        [TestMethod]
        public void ParserEnsureGetSecondWorksWithConstantsSpaces()
        {
            string input = "2 + a";
            Parser parse = new Parser();
            Assert.AreEqual("a", parse.GetSecond(input));
        }

    }
}
