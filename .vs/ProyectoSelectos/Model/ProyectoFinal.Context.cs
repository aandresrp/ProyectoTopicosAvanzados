﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProyectoFinalEntities : DbContext
    {
        public ProyectoFinalEntities()
            : base("name=ProyectoFinalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Articulo> Articuloes { get; set; }
        public virtual DbSet<EstadoArticulo> EstadoArticuloes { get; set; }
        public virtual DbSet<Permiso> Permisoes { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
    }
}
