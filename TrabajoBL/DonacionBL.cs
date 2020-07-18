using System;
using TrabajoDA;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoBL
{
    public class DonacionBL
    {
        public static List<Donacion> listado()
        {
            return DonacionDA.listado();

        }

        public static Donacion obtener(int donacionCodigo)
        {
            return DonacionDA.obtener(donacionCodigo);
        }

        public static bool eliminar(int donacionCodigo)
        {
            return DonacionDA.eliminar(donacionCodigo);

        }

        public static bool registrar(Donacion donacion)
        {
            return DonacionDA.registrar(donacion);

        }

        public static bool actualizar(Donacion donacion)
        {
            return DonacionDA.actualizar(donacion);

        }


    }

}

