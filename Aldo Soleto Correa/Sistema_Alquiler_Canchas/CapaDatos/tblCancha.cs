//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblCancha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCancha()
        {
            this.tblReserva = new HashSet<tblReserva>();
        }
    
        public int idCancha { get; set; }
        public int fkPolideportivo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Capacidad { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int PrecioDia { get; set; }
        public int PrecioNoche { get; set; }
        public System.Data.Entity.Spatial.DbGeography Ubicacion { get; set; }
    
        public virtual tblPoliDeportivo tblPoliDeportivo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReserva> tblReserva { get; set; }
    }
}
