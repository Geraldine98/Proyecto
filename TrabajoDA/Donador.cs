//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donador()
        {
            this.Donacion = new HashSet<Donacion>();
        }
    
        public int idDonador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string tipoDonacion { get; set; }
        public string Caracteristicas { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Estado { get; set; }
        public string Dni { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donacion> Donacion { get; set; }
    }
}