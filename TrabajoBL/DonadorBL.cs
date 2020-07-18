using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoDA;

namespace TrabajoBL
{
   public  class DonadorBL
    {
        public static List<Donador> listado()
        {
            return DonadorDA.listado();

        }

        public static Donador obtener(int donadorCodigo)
        {
            return DonadorDA.obtener(donadorCodigo);
        }

        public static bool eliminar(int donadorCodigo)
        {
            return DonadorDA.eliminar(donadorCodigo);

        }

        public static bool registrar(Donador donador)
        {
            return DonadorDA.registrar(donador);

        }

        public static bool actualizar(Donador donador)
        {
            return DonadorDA.actualizar(donador);

        }


    }
}
