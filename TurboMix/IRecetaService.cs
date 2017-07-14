using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public interface IRecetaService
    {
        void Aniadir(Receta receta);
        Receta Leer(String nombreReceta);
        IList<Receta> Lista();
        void Update(Receta receta);
        void Delete(string receta);
    }
}
