using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;
using Moq;
using System.Collections.Generic;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaServiceTest
    {
        [TestMethod]
        public void TestRecetaService()
        {
            var mockRecetaRepository = new Mock<IRecetaRepository>();
            Receta receta = new Receta();

            mockRecetaRepository.Setup(recetaRepository => recetaRepository.LeerR(It.IsAny<string>())).Returns((Receta r) => r);
            mockRecetaRepository.Setup(recetaRepository => recetaRepository.ListaR()).Returns((List<Receta> r) => r);


            IRecetaService sut = new RecetaService(mockRecetaRepository.Object);
            sut.Aniadir(receta);
            sut.Delete("receta");
            sut.Leer("receta");
            sut.Lista();
            sut.Update(receta);

            mockRecetaRepository.Verify(recetaRepository => recetaRepository.Crear(It.IsAny<Receta>()), Times.Once);

            mockRecetaRepository.Verify(recetaRepository => recetaRepository.DeleteR(It.IsAny<string>()), Times.Once);
            mockRecetaRepository.Verify(recetaRepository => recetaRepository.LeerR(It.IsAny<string>()), Times.Once);
            mockRecetaRepository.Verify(recetaRepository => recetaRepository.ListaR(), Times.Once);
            mockRecetaRepository.Verify(recetaRepository => recetaRepository.UpdateR(It.IsAny<Receta>()), Times.Once);

        }
    }
}
