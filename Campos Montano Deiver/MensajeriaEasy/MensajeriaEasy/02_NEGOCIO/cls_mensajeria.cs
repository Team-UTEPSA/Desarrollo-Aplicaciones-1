using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_DATOS;

namespace _02_NEGOCIO
{
    public class cls_mensajeria
    {
        c_cnx claseConexion = new c_cnx();


        public DataTable listar()
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select * from tblMensajes");

                return claseConexion.obtenerTabla(query.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable buscarMensaje(string codigo)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendFormat("select * from tblMensajes where idMensaje={0} order by idMensaje desc", codigo);

                return claseConexion.obtenerTabla(query.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int guardarMensaje(string mensaje)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendFormat("insert into tblMensajes(Mensaje, Estado) values ('{0}',0)", mensaje);

                return claseConexion.ejecutarScript(query.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int actualizarEstado(string codigo)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendFormat("update tblMensajes set Estado=1 where idMensaje={0}", codigo);

                return claseConexion.ejecutarScript(query.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public int eliminarMensaje(string codigo)
        {
            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendFormat("delete from tblMensajes where idMensaje={0}", codigo);

                return claseConexion.ejecutarScript(query.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
