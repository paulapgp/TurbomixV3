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

        public Plato PrepararReceta(Alimento alimentoPrimero, Alimento alimentoSegundo, Receta r)
        {
            if (MismoNombreAlimentosConReceta(alimentoPrimero, alimentoSegundo, r))
            {
                if (!alimentoPrimero.Calentado && !alimentoSegundo.Calentado)
                {

                    if (bascula.Pesar(alimentoPrimero) < r.alimentoPrincipal.Peso || bascula.Pesar(alimentoSegundo) < r.alimentoPrincipal.Peso)
                    {
                        return null;
                    }
                    else
                    {
                        if (bascula.Pesar(alimentoPrimero) > r.alimentoPrincipal.Peso || bascula.Pesar(alimentoSegundo) > r.alimentoPrincipal.Peso)
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