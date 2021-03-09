using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyStringRetutnsZero()
        {
            Calculator calculator = new Calculator();
            string input = "";
            int xOutput = 0;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void SingleNumberReturnsValue()
        {
            Calculator calculator = new Calculator();
            string input = "22";
            int xOutput = 22;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void TwoNumbersSeparatedByCommaReturnSum()
        {
            Calculator calculator = new Calculator();
            string input = "10,26";
            int xOutput = 36;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void TwoNumbersSeparatedByNewLineReturnSum()
        {
            Calculator calculator = new Calculator();
            string input = "10\n26";
            int xOutput = 36;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void ThreeNumbersSeparatedByCommaReturnSum()
        {
            Calculator calculator = new Calculator();
            string input = "10,26,4";
            int xOutput = 40;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void ThreeNumbersSeparatedByNewLineReturnSum()
        {
            Calculator calculator = new Calculator();
            string input = "10\n26\n4";
            int xOutput = 40;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void NegativeNumberThrowsException()
        {
            Calculator calculator = new Calculator();
            string input = "10\n-3";
            Assert.Catch(() => calculator.Add(input));
        }

        [Test]
        public void NumbersGreaterThan1000AreIgnored()
        {
            Calculator calculator = new Calculator();
            string input = "10,100,2000";
            int xOutput = 110;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void UserDefiniedCharDelimiterInFirstLine()
        {
            Calculator calculator = new Calculator();
            string input = "//#\n2#3";
            int xOutput = 5;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void UserDefiniedStringDelimiterInFirstLine()
        {
            Calculator calculator = new Calculator();
            string input = "//[##]\n2##3##5";
            int xOutput = 10;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }

        [Test]
        public void ManyUserDefiniedStringDelimiterInFirstLine()
        {
            Calculator calculator = new Calculator();
            string input = "//[##][$$]\n2##3$$5";
            int xOutput = 10;
            int output = calculator.Add(input);
            Assert.AreEqual(xOutput, output);
        }
    }
}