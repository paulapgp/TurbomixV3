using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class CocinaService : ICocinaService
    {

        //public Plato PrepararReceta(Alimento alimento1, Alimento alimento2)
        //{
        //    return 
            
        //}

        public void Calentar(Alimento alimento1, Alimento alimento2)
            {
                alimento1.Calentado = true;
                alimento2.Calentado = true;
            }
        

        /// <summary>
        /// Método de cocina de dos alimentos.
        /// </summary>
        /// <param name="a">Primer alimento</param>
        /// <param name="b">Segundo alimento</param>
        /// <returns>El plato</returns>
        //public Plato Calentar(Alimento alimento1, Alimento alimento2)
        //{
        //    Plato plato = new Plato();
        //    plato.alimentoPrincipal = alimento1;
        //    plato.alimentoSecundario = alimento2;
        //    return plato;
        //}
    }
}

