using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace CAPA_DATOS
{
    public class ReservasData
    {
        dbCanchaEntities2 bd = new dbCanchaEntities2();
        public void guardar(int idPersonal, int idCliente, int idCancha, DateTime fecha, 
            string horaEntrada, string horaSalida, int tipoPago, double monto, double descuento)
        {
            tblReserva reserva = new tblReserva();
            reserva.idReserva = 0;
            reserva.Fecha = fecha;
            reserva.Inicio = TimeSpan.Parse(horaEntrada);
            reserva.Final = TimeSpan.Parse(horaSalida);
            reserva.fkCancha = idCancha;
            reserva.fkPersonal = idPersonal;
            reserva.fkCliente = idCliente;

            bd.tblReserva.Add(reserva);
            bd.SaveChanges();

            tblPago pago = new tblPago();
            pago.Fecha = fecha;
            pago.fkCliente = idCliente;
            pago.Total = monto;
            pago.Descuento = descuento;
            pago.TotalPagado = monto - descuento;
            pago.fkReserva = reserva.idReserva;

            bd.tblPago.Add(pago);
            bd.SaveChanges();
        }

        public List<tblCliente> obtenerDatosClientes()
        {
            return bd.tblCliente.ToList();
        }

        public List<tblPersonal> obtenerDatosPersonal()
        {
            return bd.tblPersonal.ToList();
        }

        public List<tblCancha> obtenerDatosCancha()
        {
            return bd.tblCancha.ToList();
        }
    }
}
