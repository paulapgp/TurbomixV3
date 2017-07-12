using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class TurboMixService
    {
        public IBascula bascula { get; set; }
        public ICocina cocina { get; set; }
        public TurboMixService(IBascula _Bascula, ICocina _Cocina)
        {
            this.bascula = _Bascula;
            this.cocina = _Cocina;

        }

        public Plato PesarYCalentar(Alimento alimentoPrimero, Alimento alimentoSegundo)
        {            
            bascula.Pesar(alimentoPrimero);
            bascula.Pesar(alimentoSegundo);

            cocina.Calentar(alimentoPrimero, alimentoSegundo);

            return new Plato(alimentoPrimero, alimentoSegundo);
        }
    }
}
