using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDA
{
    public class DonacionDA
    {
        public static List<Donacion> listado()
        {
            using (var data = new TrabajoEntities())
            {
                return data.Donacion.ToList();

            }
        }

        public static Donacion obtener(int donacionCodigo)
        {
            using (var data = new TrabajoEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.Donacion.Where(x => x.idDonacion == donacionCodigo).FirstOrDefault();

            }

        }

        public static bool eliminar(int donacionCodigo)
        {
            bool exito = true;
            try
            {
                using (var data = new TrabajoEntities())
                {
                    Donacion donacion = data.Donacion.Where(x => x.idDonacion == donacionCodigo).FirstOrDefault();
                    data.Donacion.Remove(donacion);
                    data.SaveChanges();

                }
            }
            catch (Exception)
            {


                exito = false;
            }
            return exito;

        }


        public static bool registrar(Donacion donacion)
        {
            bool exito = true;
            try
            {
                using (var data = new TrabajoEntities())
                {
                    data.Donacion.Add(donacion);
                    data.SaveChanges();

                }



            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;

        }

        public static bool actualizar(Donacion donacion)
        {
            bool exito = true;
            try
            {
                using (var data = new TrabajoEntities())
                {
                    Donacion donacionActualizar = data.Donacion.Where(x => x.idDonacion == donacion.idDonacion).FirstOrDefault();
                    donacionActualizar.idDonador = donacion.idDonador;
                    donacionActualizar.idUsuario = donacion.idUsuario;
                    donacion.idPersona = donacion.idPersona;
                    donacionActualizar.fechaEntrega = donacion.fechaEntrega;
                    donacionActualizar.Estado = donacion.Estado;
                    data.SaveChanges();

                }



            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;

        }

    }

}

