using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.AccessControl;

namespace CalculatorAppTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calc;

        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(2, calc.Add(1, 1));
            Assert.AreEqual(1.42, calc.Add(3.14, -1.72), 0.001);
            Assert.AreEqual(2.0 / 3, calc.Add(1.0 / 3, 1.0 / 3), 0.001);
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(0, calc.Subtract(1, 1));
            Assert.AreEqual(4.86, calc.Subtract(3.14, -1.72), 0.001);
            Assert.AreEqual(2.0 / 3, calc.Subtract(1.0 / 3, -1.0 / 3), 0.001);
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(2, calc.Multiply(1, 2));
            Assert.AreEqual(-5.4008, calc.Multiply(3.14, -1.72), 0.001);
            Assert.AreEqual(0.111, calc.Multiply(1.0 / 3, 1.0 / 3), 0.001);
        }

        [TestMethod]
        public void Divide()
        {
            Assert.AreEqual(2, calc.Divide(4, 2));
            Assert.AreEqual(-1.826, calc.Divide(3.14, -1.72), 0.001);
            Assert.AreEqual(1, calc.Divide(1.0 / 3, 1.0 / 3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideException()
        {
            calc.Divide(2, 0);
        }

        [TestCleanup]
        public void Cleanup() 
        {

        }
    }
}