using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public interface IRecetaRepository
    {
        void Crear(Receta receta);
        Receta LeerR(String nombreReceta);
        IList<Receta> ListaR();
        void UpdateR(Receta receta);
        void DeleteR(string receta);


    }
}
