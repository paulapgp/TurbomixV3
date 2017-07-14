using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;
using Moq;

namespace TurboMixTest
{
    [TestClass]
    public class TurboMixServiceTest
    {

        private Alimento alimento1;
        private Alimento alimento2;
        private TurboMixService sut;
        private Receta receta;
        private Alimento alimentoCocinado1;
        private Alimento alimentoCocinado2;

        [TestMethod]
        public void TestPrepararPlato()
        {
            var mockBasculaService = new Mock<IBasculaService>();
            var mockCocinaService = new Mock<ICocinaService>();

            //       mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>())).Returns(1.5F);
            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>())).Returns((Alimento p) => p.Peso);
            // mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>())).Returns(5F);
            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>())).Returns((Alimento p) => p.Peso);

            mockCocinaService.Setup(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()))
                .Callback(
                (Alimento p1, Alimento p2)
                => 
                {
                    p1.Calentado = true;
                    p2.Calentado = true;
                }
                );

            IBasculaService basculaService = mockBasculaService.Object;
            ICocinaService cocinaService = mockCocinaService.Object;

            TurboMixService sut = new TurboMixService(basculaService, cocinaService);
            Alimento alimento1 = new Alimento();
            alimento1.Peso = 1.5f;
            alimento1.Calentado = true;
            Alimento alimento2 = new Alimento();
            alimento2.Peso = 5f;
            alimento2.Calentado = true;

            Alimento alimentoCocinado1 = new Alimento();
            alimentoCocinado1.Peso = 1.5f;
            alimentoCocinado1.Calentado = true;
            Alimento alimentoCocinado2 = new Alimento();
            alimentoCocinado2.Peso = 5f;
            alimentoCocinado2.Calentado = true;

            Plato resultado = sut.PesarYCalentar(alimento1, alimento2);
            mockBasculaService.Verify(bascula => bascula.Pesar(It.IsAny<Alimento>()), Times.AtLeast(2));
            mockCocinaService.Verify(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()), Times.AtLeastOnce);

            Plato mPlato = new Plato(alimento1, alimento2);
            Assert.AreNotEqual(mPlato, resultado);
        }
    }
}
