﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbCancha2Entities : DbContext
    {
        public dbCancha2Entities()
            : base("name=dbCancha2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCalendarioAtencion> tblCalendarioAtencion { get; set; }
        public virtual DbSet<tblCancha> tblCancha { get; set; }
        public virtual DbSet<tblCliente> tblCliente { get; set; }
        public virtual DbSet<tblCuentaUsuario> tblCuentaUsuario { get; set; }
        public virtual DbSet<tblMensajes> tblMensajes { get; set; }
        public virtual DbSet<tblPago> tblPago { get; set; }
        public virtual DbSet<tblPersona> tblPersona { get; set; }
        public virtual DbSet<tblPersonal> tblPersonal { get; set; }
        public virtual DbSet<tblPoliDeportivo> tblPoliDeportivo { get; set; }
        public virtual DbSet<tblReserva> tblReserva { get; set; }
    }
}
