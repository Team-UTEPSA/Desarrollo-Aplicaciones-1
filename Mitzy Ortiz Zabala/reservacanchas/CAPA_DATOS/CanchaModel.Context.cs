﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAPA_DATOS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbCanchaEntities2 : DbContext
    {
        public dbCanchaEntities2()
            : base("name=dbCanchaEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblCancha> tblCancha { get; set; }
        public DbSet<tblCliente> tblCliente { get; set; }
        public DbSet<tblCuentaUsuario> tblCuentaUsuario { get; set; }
        public DbSet<tblDetallePago> tblDetallePago { get; set; }
        public DbSet<tblDia> tblDia { get; set; }
        public DbSet<tblHora> tblHora { get; set; }
        public DbSet<tblHorarioAtencion> tblHorarioAtencion { get; set; }
        public DbSet<tblMensajes> tblMensajes { get; set; }
        public DbSet<tblPago> tblPago { get; set; }
        public DbSet<tblPersona> tblPersona { get; set; }
        public DbSet<tblPersonal> tblPersonal { get; set; }
        public DbSet<tblPoliDeportivo> tblPoliDeportivo { get; set; }
        public DbSet<tblReserva> tblReserva { get; set; }
        public DbSet<tblRol> tblRol { get; set; }
        public DbSet<tblServicios> tblServicios { get; set; }
    }
}
