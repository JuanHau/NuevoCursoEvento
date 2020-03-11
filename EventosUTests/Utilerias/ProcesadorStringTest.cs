using Eventos.TipoEventos;
using Eventos.Utilerias;
using Eventos.Utilerias.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace EventosUTests.Utilerias
{
    [TestClass]
    public class ProcesadorStringTest
    {
        protected ProcesadorString _procesadorString;

        protected Mock<IObtenedorEscala> _obtenedorEscala;
        protected Mock<IObtenedorTipoEvento> _obtenedorTipoEvento;
        protected Mock<IObtenedorDuracion> _obtenedorDuracion;
        protected Mock<IConvertidorFecha> _convertidorFecha;

        [TestInitialize]
        public void TestInitialize()
        {
            _obtenedorEscala = new Mock<IObtenedorEscala>();
            _obtenedorTipoEvento = new Mock<IObtenedorTipoEvento>();
            _obtenedorDuracion = new Mock<IObtenedorDuracion>();
            _convertidorFecha = new Mock<IConvertidorFecha>();

            _procesadorString = new ProcesadorString(
                _obtenedorEscala.Object,
                _obtenedorTipoEvento.Object,
                _obtenedorDuracion.Object,
                _convertidorFecha.Object);
        }

        [TestMethod]
        public void ProcesarString_CuandoHayEventos_DevuelveContenedores()
        {
            //Arrange
            _obtenedorTipoEvento.Setup(x => x.ObtenerTipoEvento(It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(TipoEvento.Futuro);
            _obtenedorEscala.Setup(x => x.ObtenerEscalaTiempo(It.IsAny<DateTime>(), It.IsAny<DateTime>())).Returns(EscalaTiempo.Mes);
            _obtenedorDuracion.Setup(x => x.ObtenerDuracion(It.IsAny<DateTime>(), It.IsAny<DateTime>(), It.IsAny<EscalaTiempo>())).Returns(3);

            List<string> eventos = new List<string>()
            {
                "Navidad,25/12/2019 05:50:06",
                "Escuela,02/05/2019"
            };

            //Act
            List<Contenedor> contenedores = _procesadorString.ProcesarString(eventos, ',');

            //Assert
            Assert.AreEqual(2, contenedores.Count);
        }
    }
}
