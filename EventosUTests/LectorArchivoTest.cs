using Eventos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace EventosUTests
{
    [TestClass]
    public class LectorArchivoTest
    {
        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void LeerArchivo_RutaInexistente_DevuelveExcepcion(string ruta)
        {
            //Arrange
            LectorArchivo lector = new LectorArchivo();

            //Act
            ArgumentException error = Assert.ThrowsException<ArgumentException>(() => lector.LeerArchivo(ruta));

            //Assert
            Assert.AreEqual("El archivo no existe", error.Message);
        }

        [TestMethod]
        public void LeerArchivo_RutaExistente_DevuelveListaEventos()
        {
            //Arrange
            LectorArchivo lector = new LectorArchivo();
            string ruta = Path.GetFullPath("eventos.txt");

            //Act
            List<string> eventos = lector.LeerArchivo(ruta);

            //Assert
            Assert.AreEqual(5, eventos.Count);
        }
    }
}
