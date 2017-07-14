using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;

namespace TurboMixTest

{
    [TestClass]
    public class CocinaServiceTest
    {
        [TestMethod]
        public void CalentarTest()
        {

            ICocinaService sut = new CocinaService();
            Alimento alimento1 = new Alimento();
            Alimento alimento2 = new Alimento();

            sut.Calentar(alimento1, alimento2);

            Assert.IsTrue(alimento1.Calentado);
            Assert.IsTrue(alimento2.Calentado);
        }
    }
}
