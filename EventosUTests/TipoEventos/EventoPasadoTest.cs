using Eventos.TipoEventos;
using Eventos.Utilerias;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventosUTests.TipoEventos
{
    [TestClass]
    public class EventoPasadoTest
    {
        [TestMethod]
        public void ToString_EventoContruidoMes_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 1, EscalaTiempo.Mes);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 1 mes", resultado);
        }

        [TestMethod]
        public void ToString_EventoContruidoMeses_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 4, EscalaTiempo.Mes);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 4 meses", resultado);
        }

        [TestMethod]
        public void ToString_EventoContruidoDia_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 1, EscalaTiempo.Dia);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 1 día", resultado);
        }

        [TestMethod]
        public void ToString_EventoContruidoDias_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 4, EscalaTiempo.Dia);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 4 días", resultado);
        }

        [TestMethod]
        public void ToString_EventoContruidoHora_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 1, EscalaTiempo.Hora);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 1 hora", resultado);
        }

        [TestMethod]
        public void ToString_EventoContruidoHoras_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 17, EscalaTiempo.Hora);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 17 horas", resultado);
        }

        [TestMethod]
        public void ToString_EventoContruidoMinuto_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 1, EscalaTiempo.Minuto);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 1 minuto", resultado);
        }

        [TestMethod]
        public void ToString_EventoContruidoMinutos_RepresentacionEventoPasado()
        {
            //Arrange
            EventoPasado eventoPasado = new EventoPasado("Navidad", 21, EscalaTiempo.Minuto);

            //Act
            string resultado = eventoPasado.ToString();

            //Assert
            Assert.AreEqual("Navidad ocurrió hace 21 minutos", resultado);
        }
    }
}
