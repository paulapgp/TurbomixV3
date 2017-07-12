using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class Alimento
    {
        public string Nombre { get; set; }
        public float Peso { get; set; }
        public bool Calentado { get; set; }

        public Alimento()
        {
            Peso = 0;
            Calentado = false;
        }
        public Alimento(float Peso, bool Calentado)
        {
            this.Peso = Peso;
            this.Calentado = Calentado;
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if (this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            if (((Alimento)obj).Nombre == null )
            {
                if(this.Nombre != null)
                return false;
            } else
            {
                if(!((Alimento)obj).Nombre.Equals(this.Nombre))
                {
                    return false;
                }
            }

            return ((Alimento)obj).Calentado == this.Calentado && ((Alimento)obj).Peso == this.Peso;

        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
