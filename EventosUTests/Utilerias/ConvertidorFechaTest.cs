using Eventos.Utilerias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EventosUTests.Utilerias
{
    [TestClass]
    public class ConvertidorFechaTest
    {
        [TestMethod]
        [DataRow("01/01/2020 00:01:00")]
        [DataRow("21/03/2020")]
        public void ConvertirFecha_FechaCorrecta_Fecha(string fecha)
        {
            //Arrange
            ConvertidorFecha convertidorFecha = new ConvertidorFecha();

            //Act
            DateTime fechaEvento = convertidorFecha.ConvertirFecha(fecha);

            //Assert
            Assert.IsNotNull(fechaEvento);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void ConvertirFecha_FechaInCorrecta_Excepcion(string fecha)
        {
            //Arrange
            ConvertidorFecha convertidorFecha = new ConvertidorFecha();

            //Act
            ArgumentException error = Assert.ThrowsException<ArgumentException>(()=> convertidorFecha.ConvertirFecha(fecha));

            //Assert
            Assert.AreEqual("Formato de fecha incorrecto", error.Message);
        }
    }
}
