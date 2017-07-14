using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class Receta
    {
        public Alimento alimentoPrincipal { get; set; }
        public Alimento alimentoSecundario { get; set; }
        public String nombre;

        public Receta() { }
        public Receta(Alimento alimentoPrincipal, Alimento alimentoSecundario)
        {
            this.alimentoPrincipal = alimentoPrincipal;
            this.alimentoSecundario = alimentoSecundario;
        }
    }
}
