//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblRol
    {
        public tblRol()
        {
            this.tblCuentaUsuario = new HashSet<tblCuentaUsuario>();
        }
    
        public int idRol { get; set; }
        public string TipoUsuario { get; set; }
        public int Permisos { get; set; }
    
        public virtual ICollection<tblCuentaUsuario> tblCuentaUsuario { get; set; }
    }
}
