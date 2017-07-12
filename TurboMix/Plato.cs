using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class Plato
    {
        public Alimento alimentoPrincipal { get; set; }
        public Alimento alimentoSecundario { get; set; }

        public Plato() { }
        public Plato(Alimento alimentoPrincipal, Alimento alimentoSecundario) {
            this.alimentoPrincipal = alimentoPrincipal;
            this.alimentoSecundario = alimentoSecundario;
                }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            if (this.alimentoPrincipal == null && ((Plato)obj).alimentoPrincipal != null)
            {
                return false;
            }
            if (this.alimentoPrincipal != null && !this.alimentoPrincipal.Equals(((Plato)obj).alimentoPrincipal))
            {
                return false;
            }
            if (this.alimentoSecundario == null && ((Plato)obj).alimentoSecundario != null)
            {
                return false;
            }
            if (this.alimentoSecundario != null && !this.alimentoSecundario.Equals(((Plato)obj).alimentoSecundario))
            {
                return false;
            }
            return true;
        }

            public override string ToString()
        {
            return alimentoPrincipal + " al " + alimentoSecundario;
        }
    }
}

