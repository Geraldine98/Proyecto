﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrabajoEntities : DbContext
    {
        public TrabajoEntities()
            : base("name=TrabajoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Donacion> Donacion { get; set; }
        public virtual DbSet<Donador> Donador { get; set; }
        public virtual DbSet<personaPobreza> personaPobreza { get; set; }
        public virtual DbSet<Situacion> Situacion { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Territorio> Territorio { get; set; }
        public virtual DbSet<Triaje> Triaje { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}