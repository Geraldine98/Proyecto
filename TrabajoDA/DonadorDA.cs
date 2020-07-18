using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoDA
{
    public class DonadorDA
    {
        public static List<Donador> listado()
        {
            using (var data = new TrabajoEntities())
            {
                return data.Donador.ToList();

            }
        }

        public static Donador obtener(int donadorCodigo)
        {
            using (var data = new TrabajoEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.Donador.Where(x => x.idDonador == donadorCodigo).FirstOrDefault();

            }

        }

        public static bool eliminar(int donadorCodigo)
        {
            bool exito = true;
            try
            {
                using (var data = new TrabajoEntities())
                {
                    Donador donador = data.Donador.Where(x => x.idDonador == donadorCodigo).FirstOrDefault();
                    data.Donador.Remove(donador);
                    data.SaveChanges();

                }
            }
            catch (Exception)
            {


                exito = false;
            }
            return exito;

        }


        public static bool registrar(Donador donador)
        {
            bool exito = true;
            try
            {
                using (var data = new TrabajoEntities())
                {
                    data.Donador.Add(donador);
                    data.SaveChanges();

                }



            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;

        }

        public static bool actualizar(Donador donador)
        {
            bool exito = true;
            try
            {
                using (var data = new TrabajoEntities())
                {
                    Donador donadorActualizar = data.Donador.Where(x => x.idDonador == donador.idDonador).FirstOrDefault();
                    donadorActualizar.Nombre= donador.Nombre;
                    donadorActualizar.Apellidos = donador.Apellidos;
                    donadorActualizar.tipoDonacion = donador.tipoDonacion;
                    donadorActualizar.Caracteristicas = donador.Caracteristicas;
                    donadorActualizar.Cantidad = donador.Cantidad;
                    donadorActualizar.Dni = donador.Dni;
                    donadorActualizar.Fecha = donador.Fecha;
                    donadorActualizar.Estado = donador.Estado;
                    donadorActualizar.Dni = donador.Dni;
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
