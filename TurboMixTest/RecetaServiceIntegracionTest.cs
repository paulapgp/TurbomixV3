using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaServiceIntegracionTest
    {
        [TestMethod]
        public void TestGuardarReceta()
        {
            Receta receta = new Receta();
            IRecetaRepository recetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(recetaRepository);

            sut.Aniadir(receta);
        }
    }
}
