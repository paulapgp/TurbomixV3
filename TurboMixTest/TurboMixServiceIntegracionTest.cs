using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;

namespace TurboMixTest
{
    [TestClass]
    public class TurboMixServiceIntegracionTest
    {
        [TestMethod]
        public void TestPesarYCocinar()
        {
            IBascula basculaService = new BasculaService();
            ICocina cocinaService = new CocinaService();

            TurboMixService sut = new TurboMixService(basculaService, cocinaService);
            Alimento alimento1 = new Alimento();
            Alimento alimento2 = new Alimento();
            alimento1.Peso = 1.5f;
            alimento2.Peso = 5f;

            Plato resultado = sut.PesarYCalentar(alimento1, alimento2);
            
            Plato mPlato = new Plato(alimento1, alimento2);
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
