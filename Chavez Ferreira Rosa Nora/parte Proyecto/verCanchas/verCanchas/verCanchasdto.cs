using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verCanchas
{
    public partial class verCanchasdto
    {
        //public  tblCancha()
        //{
        //    this.tblReserva = new HashSet<tblReserva>();
            
        //}

    public int idCancha { get; set; }
    //public int fkPoliDeportivo { get; set; }
    public string Codigo { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public string Capacidad { get; set; }
    public int Largo { get; set; }
    public int Ancho { get; set; }
    public decimal PrecioDia { get; set; }
    public decimal PrecioNoche { get; set; }
    public System.Data.Spatial.DbGeography Ubicacion { get; set; }

    //public virtual tblPoliDeportivo tblPoliDeportivo { get; set; }
    public virtual ICollection<tblReserva> tblReserva { get; set; }
}
    }

