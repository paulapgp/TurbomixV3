using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class RecetaRepository : IRecetaRepository
    {
        private IList<Receta> listaRecetas = new List<Receta>();

        public void Crear(Receta receta)
        {
            listaRecetas.Add(receta);
        }

        public void DeleteR(string receta)
        {
        }

        public Receta LeerR(string nombreReceta)
        {
            Receta receta = new Receta();
                receta.nombre = "" + nombreReceta;
                return receta;
        }

        public IList<Receta> ListaR()
        {
            return this.listaRecetas;
        }

        public void UpdateR(Receta receta)
        {
            
        }

        

    }
}
