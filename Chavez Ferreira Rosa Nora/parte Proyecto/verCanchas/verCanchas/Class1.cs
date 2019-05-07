using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
    

namespace verCanchas
{
    class Canchas
    {
        public List<verCanchasdto> listarCanchas()
        {

            using (dbCanchaEntities1 dbcanchas = new dbCanchaEntities1())
            {
               // var re = dbcanchas.tblReserva;
                
                var query = (from n in dbcanchas.tblCancha
                             select new verCanchasdto
                             {
                                 Codigo = n.Codigo,
                                 Nombre = n.Nombre,
                                 Tipo = n.Tipo,
                                 Capacidad = n.Capacidad,
                                 Largo = n.Largo,
                                 Ancho = n.Ancho,
                                 PrecioDia = n.PrecioDia,
                                 PrecioNoche = n.PrecioNoche
                             }).ToList();
                
                return query;
                
                    } }
        
    }
}
