using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTM.Texto.UnitTest.xUnit
{
    public class TextoTest
    {
        [Fact]
        public void ReverseString_Hola_RetornaAloH()
        {
            // Arrange
            var texto = new Texto();

            // Act
            string resultado = texto.ReverseString("Hola");

            // Assert
            Assert.Equal("aloH", resultado);
        }

        [Fact]
        public void RemoveSpaces_HolaMundo_RetornaHolaMundo()
        {
            var texto = new Texto();
            string resultado = texto.RemoveSpaces("Hola Mundo");
            Assert.Equal("HolaMundo", resultado);
        }

        [Fact]
        public void ReverseString_Null_RetornaNull()
        {
            var texto = new Texto();
            string resultado = texto.ReverseString(null);
            Assert.Null(resultado);
        }

        [Fact]
        public void RemoveSpaces_Null_RetornaNull()
        {
            var texto = new Texto();
            string resultado = texto.RemoveSpaces(null);
            Assert.Null(resultado);
        }
    }
}
