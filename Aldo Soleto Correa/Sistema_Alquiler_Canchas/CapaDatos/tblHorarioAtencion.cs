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
    
    public partial class tblHorarioAtencion
    {
        public int idHorarioAtencion { get; set; }
        public int fkPolideportivo { get; set; }
        public int fkDia { get; set; }
        public int fkHora { get; set; }
        public int Estado { get; set; }
    
        public virtual tblDia tblDia { get; set; }
        public virtual tblHora tblHora { get; set; }
        public virtual tblPoliDeportivo tblPoliDeportivo { get; set; }
    }
}
