using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class Reservas
    {
        ReservasData reservasData = new ReservasData();

        public void guardar(int idPersonal, int idCliente, int idCancha, 
            DateTime fecha, string horaEntrada, string horaSalida, int tipoPago, double monto, double descuento)
        {
            reservasData.guardar(idPersonal, idCliente, idCancha, fecha, horaEntrada, horaSalida, tipoPago, monto, descuento);
        }

        public List<tblCliente> obtenerDatosClientes()
        {
            return reservasData.obtenerDatosClientes();
        }

        public List<tblPersonal> obtenerDatosPersonal()
        {
            return reservasData.obtenerDatosPersonal();
        }

        public List<tblCancha> obtenerDatosCancha()
        {
            return reservasData.obtenerDatosCancha();
        }
    }
}
