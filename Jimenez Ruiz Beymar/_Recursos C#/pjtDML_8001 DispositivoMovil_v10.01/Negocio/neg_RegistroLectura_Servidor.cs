using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlClient;

namespace Negocio
{
    public class neg_RegistroLectura_Servidor
    {
        private ManejadorDatos_Servidor mdS = new ManejadorDatos_Servidor();

        public neg_RegistroLectura_Servidor()
        {
        }

        public void Insertar(int id, DateTime fecha, int lectura, bool enviado, int idLecturador, int idPeriodo, int idMedidor)
        {
            dat_RegistroLectura objRL = new dat_RegistroLectura(id, fecha, lectura, enviado, idLecturador, idPeriodo, idMedidor);

            mdS.AbrirConexion();
            mdS.InsertarObjeto(objRL);
            mdS.CerrarConexion();
        }

        public void Actualizar(int id, DateTime fecha, int lectura, bool enviado, int idLecturador, int idPeriodo, int idMedidor)
        {
            dat_RegistroLectura objRL = new dat_RegistroLectura(id, fecha, lectura, enviado, idLecturador, idPeriodo, idMedidor);

            mdS.AbrirConexion();
            mdS.ActualizarObjeto(objRL);
            mdS.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            dat_RegistroLectura objRL = new dat_RegistroLectura();

            objRL.Id = id;
            mdS.AbrirConexion();
            mdS.EliminarObjeto(objRL);
            mdS.CerrarConexion();
        }

        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_RegistroLectura objRL = new dat_RegistroLectura();
            objRL.Id = id;
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objRL);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Parametrizado(String condicion)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_RegistroLectura objL = new dat_RegistroLectura();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto_Parametrizado(objL, condicion);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Todos()
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_RegistroLectura objRL = new dat_RegistroLectura();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjetos(objRL);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public void InsertarTabla(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow d = dt.Rows[i];
                InsertarTupla(d);
            }
        }

        private void InsertarTupla(DataRow dr)
        {
            dat_RegistroLectura objRL = new dat_RegistroLectura();

            objRL.Id = int.Parse(dr["Id"].ToString());
            objRL.Fecha = DateTime.Parse(dr["Fecha"].ToString());
            objRL.Lectura = int.Parse(dr["Lectura"].ToString());
            objRL.Enviado = bool.Parse(dr["Enviado"].ToString());
            objRL.IdLecturador = int.Parse(dr["IdLecturador"].ToString());
            objRL.IdPeriodo = int.Parse(dr["IdPeriodo"].ToString());
            objRL.IdMedidor = int.Parse(dr["IdMedidor"].ToString());
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objRL);
            mdS.CerrarConexion();
        }
    }
}
