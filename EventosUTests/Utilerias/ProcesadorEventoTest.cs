using Eventos.TipoEventos;
using Eventos.TipoEventos.Interfaces;
using Eventos.Utilerias;
using Eventos.Utilerias.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace EventosUTests.Utilerias
{
    [TestClass]
    public class ProcesadorEventoTest
    {
        protected ProcesadorEvento _procesadorEvento;

        protected Mock<ILectorArchivo> _lectorArchivo;
        protected Mock<IProcesadorString> _procesadorString;

        [TestInitialize]
        public void TestInitialize()
        {
            _lectorArchivo = new Mock<ILectorArchivo>();
            _procesadorString = new Mock<IProcesadorString>();

            _procesadorEvento = new ProcesadorEvento(_lectorArchivo.Object, _procesadorString.Object);
        }

        [TestMethod]
        public void ProcesarEvento_CuandoExisteEventos_DevuelveListaEventos()
        {
            //Arrange
            List<Contenedor> contenedores = new List<Contenedor>()
            {
                new Contenedor()
                {
                    Nombre = "Navidad",
                    Tipo = TipoEvento.Pasado,
                    Escala = EscalaTiempo.Dia,
                    Duracion = 12
                },
                new Contenedor()
                {
                    Nombre = "Vacaciones",
                    Tipo = TipoEvento.Futuro,
                    Escala = EscalaTiempo.Mes,
                    Duracion = 6
                }
            };

            _lectorArchivo.Setup(x => x.LeerArchivo(It.IsAny<string>())).Returns(new List<string>() { "Navidad,25/12/2019 05:50:06" });
            _procesadorString.Setup(x => x.ProcesarString(It.IsAny<List<string>>(), It.IsAny<char>())).Returns(contenedores);

            //Act
            List<IEvento> eventos = _procesadorEvento.ProcesarEvento("algunaRuta", ',');

            //Assert
            Assert.IsNotNull(eventos);
            Assert.AreEqual(2, eventos.Count);
        }
    }
}
