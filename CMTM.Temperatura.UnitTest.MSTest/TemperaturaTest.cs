using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTM.Temperatura.UnitTest.MSTest
{
    [TestClass]
    public class TemperaturaTest
    {
        [TestMethod]
        public void CelsiusToFahrenheit_25C_Retorna77F()
        {
            // Arrange
            var temp = new Temperatura();
            double celsius = 25;

            // Act
            double resultado = temp.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(77, resultado, 0.001, "25°C debería ser 77°F");
        }

        [TestMethod]
        public void FahrenheitToCelsius_77F_Retorna25C()
        {
            // Arrange
            var temp = new Temperatura();
            double fahrenheit = 77;

            // Act
            double resultado = temp.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(25, resultado, 0.001, "77°F debería ser 25°C");
        }

        [TestMethod]
        public void CelsiusToFahrenheit_0C_Retorna32F()
        {
            var temp = new Temperatura();
            double resultado = temp.CelsiusToFahrenheit(0);
            Assert.AreEqual(32, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_32F_Retorna0C()
        {
            var temp = new Temperatura();
            double resultado = temp.FahrenheitToCelsius(32);
            Assert.AreEqual(0, resultado, 0.001);
        }
    }
}
