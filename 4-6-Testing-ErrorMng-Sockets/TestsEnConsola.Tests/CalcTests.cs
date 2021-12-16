using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEnConsola.Tests
{
    [TestClass]
    public class CalcTests
    {
        // se pasan 2 ints y devuelve un int suma
        [TestMethod]
        public void Suma_ShouldCalcSameValue()
        {
            // Arrange
            // 5 + 5 = 10
            int a = 5;
            int b = 5;
            int expected = 10;
            // Act
            int actual = Calc.Suma(a, b);
            // Assert
            Assert.AreEqual(actual, expected);
        }
        [DataRow(10,10,20)]
        [DataRow(99, 1, 100)]
        [TestMethod]
        public void Suma_ShouldCalcValueDatarowm(int a, int b, int expected)
        {
            // Arrange

            // Act
            int actual = Calc.Suma(a, b);

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
