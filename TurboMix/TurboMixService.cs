using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class TurboMixService
    {
        public IBasculaService basculaService { get; set; }
        public ICocinaService cocinaService { get; set; }

       

        public TurboMixService(IBasculaService _Bascula, ICocinaService _Cocina)
        {
            this.basculaService = _Bascula;
            this.cocinaService = _Cocina;

        }

        public Plato PesarYCalentar(Alimento alimentoPrimero, Alimento alimentoSegundo)
        {
            basculaService.Pesar(alimentoPrimero);
            basculaService.Pesar(alimentoSegundo);
            cocinaService.Calentar(alimentoPrimero, alimentoSegundo);

            return new Plato(alimentoPrimero, alimentoSegundo);
        }

        public Plato PrepararReceta(Alimento alimentoPrimero, Alimento alimentoSegundo, Receta r)
        {
            if (MismoNombreAlimentosConReceta(alimentoPrimero, alimentoSegundo, r))
            {
                if (!alimentoPrimero.Calentado && !alimentoSegundo.Calentado)
                {

                    if (basculaService.Pesar(alimentoPrimero) < r.alimentoPrincipal.Peso || basculaService.Pesar(alimentoSegundo) < r.alimentoPrincipal.Peso)
                    {
                        return null;
                    }
                    else
                    {
                        if (basculaService.Pesar(alimentoPrimero) > r.alimentoPrincipal.Peso || basculaService.Pesar(alimentoSegundo) > r.alimentoPrincipal.Peso)
                        {
                            alimentoPrimero.Peso = r.alimentoPrincipal.Peso;
                            alimentoSegundo.Peso = r.alimentoSecundario.Peso;
                        }
                    }
                }

            }
            Plato plato = new Plato();

            return plato;
        }

        private static bool MismoNombreAlimentosConReceta(Alimento alimentoPrimero, Alimento alimentoSegundo, Receta r)
        {
            return alimentoPrimero.Nombre.Equals(r.alimentoPrincipal.Nombre) && alimentoSegundo.Nombre.Equals(r.alimentoSecundario.Nombre);
        }
        
    }
}