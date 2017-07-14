using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class BasculaService : IBasculaService
    {
        private bool pesado = false;

        public float Pesar(Alimento alimento)
        {
            return alimento.Peso;
        }

        public bool IsLlamado()
        {
            return pesado;
        }
    }
}
