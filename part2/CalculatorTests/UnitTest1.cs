using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTests
{
    public class Tests
    {
        [Test]
        public void TestValidAddition()
        {
            Calculator calc = new Calculator(10, 5, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(15));
        }

        [Test]
        public void TestValidSubtraction()
        {
            Calculator calc = new Calculator(10, 5, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(5));
        }

        [Test]
        public void TestValidMultiplication()
        {
            Calculator calc = new Calculator(10, 5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(50));
        }

        [Test]
        public void TestValidDivision()
        {
            Calculator calc = new Calculator(10, 5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Calculator calc = new Calculator(10, 0, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(double.NaN));
        }

        [Test]
        public void TestInvalidOperation()
        {
            Calculator calc = new Calculator(10, 5, "%");
            Assert.That(calc.Calculate(), Is.EqualTo(double.NaN));
        }

        [Test]
        public void TestNegativeNumbers()
        {
            Calculator calc = new Calculator(-10, -5, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(-15));
        }

        [Test]
        public void TestDecimalNumbers()
        {
            Calculator calc = new Calculator(2.5, 2.5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(6.25));
        }
    }
}
