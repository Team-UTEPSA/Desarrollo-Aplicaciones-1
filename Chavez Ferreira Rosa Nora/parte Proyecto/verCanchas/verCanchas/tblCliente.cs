//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace verCanchas
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCliente
    {
        public tblCliente()
        {
            this.tblMensajes = new HashSet<tblMensajes>();
            this.tblReserva = new HashSet<tblReserva>();
        }
    
        public int idCliente { get; set; }
        public int fkPersona { get; set; }
        public string NIT { get; set; }
        public string RazonSocial { get; set; }
    
        public virtual tblPersona tblPersona { get; set; }
        public virtual ICollection<tblMensajes> tblMensajes { get; set; }
        public virtual ICollection<tblReserva> tblReserva { get; set; }
    }
}
