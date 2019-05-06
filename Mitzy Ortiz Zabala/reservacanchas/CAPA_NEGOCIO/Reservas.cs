using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CAPA_NEGOCIO
{
    public class Reservas
    {

        public void guardar(int idPersonal, int idCliente, int idCancha, 
            DateTime fecha, string horaEntrada, string horaSalida, int tipoPago, double monto)
        {
            
        }

        public DataSet obtenerDatosClientes()
        {
            DataSet datos = new DataSet();

            return datos;
        }

        public DataSet obtenerDatosPersonal()
        {
            DataSet datos = new DataSet();

            return datos;
        }

        public DataSet obtenerDatosCancha()
        {
            DataSet datos = new DataSet();

            return datos;
        }
    }
}
