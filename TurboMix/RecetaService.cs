using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class RecetaService : IRecetaService
    {
        public IRecetaRepository recetaRepository;

        public RecetaService(IRecetaRepository _recetaRepository)
        {
            this.recetaRepository = _recetaRepository;
        }

        public void Aniadir(Receta receta)
        {
            recetaRepository.Crear(receta);
        }

        public void Delete(string nombreReceta)
        {
            recetaRepository.DeleteR(nombreReceta);
        }

        public Receta Leer(string nombreReceta)
        {

            return recetaRepository.LeerR(nombreReceta);
        }

        public IList<Receta> Lista()
        {
            return recetaRepository.ListaR();
        }

        public void Update(Receta receta)
        {
            recetaRepository.UpdateR(receta);
        }
    }
}
