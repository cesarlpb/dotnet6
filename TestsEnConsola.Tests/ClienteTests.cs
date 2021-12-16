using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEnConsola.Tests
{
    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            // Arrange
            Cliente[] clientes = new Cliente[2] { new Cliente { Nombre = "Pepe", Apellido = "Muñoz"}, 
                                                  new Cliente { Nombre = "María", Apellido = "Ramírez"} };
            int index = 1;
            Cliente expected = clientes[index];
            // Act
            Cliente actual = CollectionSample.GetCustomer(clientes, index);
            // Assert
            Assert.IsInstanceOfType(actual, typeof(Cliente));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutOfRangeException()
        {
            // Arrange
            Cliente[] clientes = new Cliente[2] { new Cliente { Nombre = "Pepe", Apellido = "Muñoz"},
                                                  new Cliente { Nombre = "María", Apellido = "Ramírez"} };
            int index = 3;
            // Act
            Cliente actual = CollectionSample.GetCustomer(clientes, index);
            // Assert

        }
    }
}
