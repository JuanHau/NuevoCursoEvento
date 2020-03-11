using Eventos.TipoEventos;
using Eventos.Utilerias;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventosUTests.TipoEventos
{
    [TestClass]
    public class EventoFuturoTest
    {
        [TestMethod]
        public void ToString_EventoFuturoMes_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 1, EscalaTiempo.Mes);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 1 mes", resultado);
        }

        [TestMethod]
        public void ToString_EventoFuturoMeses_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 2, EscalaTiempo.Mes);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 2 meses", resultado);
        }

        [TestMethod]
        public void ToString_EventoFuturoDia_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 1, EscalaTiempo.Dia);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 1 día", resultado);
        }

        [TestMethod]
        public void ToString_EventoFuturoDias_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 21, EscalaTiempo.Dia);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 21 días", resultado);
        }

        [TestMethod]
        public void ToString_EventoFuturoHora_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 1, EscalaTiempo.Hora);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 1 hora", resultado);
        }

        [TestMethod]
        public void ToString_EventoFuturoHoras_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 21, EscalaTiempo.Hora);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 21 horas", resultado);
        }

        [TestMethod]
        public void ToString_EventoFuturoMinuto_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 1, EscalaTiempo.Minuto);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 1 minuto", resultado);
        }

        [TestMethod]
        public void ToString_EventoFuturoMinutos_RepresentacionEventoFuturo()
        {
            //Arrange
            EventoFuturo eventoFuturo = new EventoFuturo("Vacaciones", 21, EscalaTiempo.Minuto);

            //Act
            string resultado = eventoFuturo.ToString();

            //Assert
            Assert.AreEqual("Vacaciones ocurrirá dentro de 21 minutos", resultado);
        }
    }
}
