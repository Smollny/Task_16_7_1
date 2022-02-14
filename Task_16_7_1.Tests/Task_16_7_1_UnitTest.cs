using NUnit.Framework;
using System;

namespace Task_16_7_1.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(30, calculator.Additional(10, 20));
        }

        [Test]
        public void Additional_MustReturnUncorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(10, calculator.Additional(10, 20));
        }
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(10, calculator.Subtraction(20, 10));
        }
        [Test]
        public void Subtraction_MustReturnUncorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(1, calculator.Subtraction(20, 10));
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(200, calculator.Miltiplication(20, 10));
        }
        [Test]
        public void Miltiplication_MustReturnUncorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(20, calculator.Miltiplication(20, 10));
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.Division(20, 10));
        }
        [Test]
        public void Division_MustReturnUncorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(2, calculator.Division(20, 2));
        }
        [Test]
        public void Division_MustReturnDivideByZeroException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(20, 0));
        }
    }
}