//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caso_EnviarMensaje
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPersonal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPersonal()
        {
            this.tblReserva = new HashSet<tblReserva>();
        }
    
        public int idPersonal { get; set; }
        public int fkPersona { get; set; }
        public string Cargo { get; set; }
        public int Horario { get; set; }
        public string Direccion { get; set; }
    
        public virtual tblPersona tblPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReserva> tblReserva { get; set; }
    }
}