using NUnit.Framework;
using System;

namespace Task_16_7_1.Tests
{
    public class Tests
    {
        [Test]
        public void Success_Test_10_Add_20_Return_30()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(30, calculator.Additional(10, 20));
        }

        [Test]
        public void Fail_Test_10_Add_20_Return_10()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(10, calculator.Additional(10, 20));
        }
        [Test]
        public void Success_Test_20_Subtract_10_Return_10()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(10, calculator.Subtraction(20, 10));
        }
        [Test]
        public void Fail_Test_20_Subtract_10_Return_1()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(1, calculator.Subtraction(20, 10));
        }

        [Test]
        public void Success_Test_20_Miltiply_10_Return_200()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(200, calculator.Miltiplication(20, 10));
        }
        [Test]
        public void Fail_Test_20_Miltiply_10_Return_20()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(20, calculator.Miltiplication(20, 10));
        }

        [Test]
        public void Success_Test_20_Divide_10_Return_2()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.Division(20, 10));
        }
        [Test]
        public void Fail_Test_20_Divide_2_Return_2()
        {
            Calculator calculator = new Calculator();
            Assert.AreNotEqual(2, calculator.Division(20, 2));
        }
        [Test]
        public void Success_Test_20_Divide_0_Return_Exception()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(20, 0));
        }
    }
}