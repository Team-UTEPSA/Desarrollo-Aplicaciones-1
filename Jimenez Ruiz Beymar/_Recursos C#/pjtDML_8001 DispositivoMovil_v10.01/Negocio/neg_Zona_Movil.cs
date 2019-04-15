using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlServerCe;

namespace Negocio
{
    public class neg_Zona_Movil
    {
        private ManejadorDatos_Movil mdS = new ManejadorDatos_Movil();

        public neg_Zona_Movil()
        {
        }

        public void Insertar(int id, String nombre, int idLecturador)
        {
            dat_Zona objZ = new dat_Zona(id, nombre, idLecturador);
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objZ);
            mdS.CerrarConexion();
        }

        public void Actualizar(int id, String nombre, int idLecturador)
        {
            dat_Zona objZ = new dat_Zona(id, nombre, idLecturador);
            mdS.AbrirConexion();
            mdS.ActualizarObjeto(objZ);
            mdS.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            dat_Zona objZ = new dat_Zona();
            objZ.Id = id;
            mdS.AbrirConexion();
            mdS.EliminarObjeto(objZ);
            mdS.CerrarConexion();
        }

        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Zona objZ = new dat_Zona();
            objZ.Id = id;
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objZ);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Parametrizado(String condicion)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Zona objZ = new dat_Zona();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto_Parametrizado(objZ, condicion);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Bucar_Todos()
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Zona objZ = new dat_Zona();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjetos(objZ);
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
            dat_Zona objZ = new dat_Zona();

            objZ.Id = int.Parse(dr["Id"].ToString());
            objZ.Nombre = dr["Nombre"].ToString();
            objZ.IdLecturador = int.Parse(dr["IdLecturador"].ToString());
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objZ);
            mdS.CerrarConexion();
        }

    }
}
