using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlServerCe;

namespace Negocio
{
    public class neg_Periodo_Movil
    {
        private ManejadorDatos_Movil mdS = new ManejadorDatos_Movil ();

        public neg_Periodo_Movil()
        {
        }

        public void Insertar(int id, String nombre)
        {
            dat_Periodo objP = new dat_Periodo(id, nombre);
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objP);
            mdS.CerrarConexion();
        }

        public void Actualizar(int id, String nombre)
        {
            dat_Periodo objP = new dat_Periodo(id, nombre);
            mdS.AbrirConexion();
            mdS.ActualizarObjeto(objP);
            mdS.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            dat_Periodo objP = new dat_Periodo();
            objP.Id = id;
            mdS.AbrirConexion();
            mdS.EliminarObjeto(objP);
            mdS.CerrarConexion();
        }

        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Periodo objP = new dat_Periodo();
            objP.Id = id;
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objP);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Parametrizado(String condicion)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Periodo objP = new dat_Periodo();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto_Parametrizado(objP, condicion);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Todos()
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;
            dat_Periodo objP = new dat_Periodo();

            mdS.AbrirConexion();
            dr = mdS.ObtenerObjetos(objP);
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
            dat_Periodo objP = new dat_Periodo();

            objP.Id = int.Parse(dr["Id"].ToString());
            objP.Nombre = dr["Nombre"].ToString();
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objP);
            mdS.CerrarConexion();
        }

    }
}
