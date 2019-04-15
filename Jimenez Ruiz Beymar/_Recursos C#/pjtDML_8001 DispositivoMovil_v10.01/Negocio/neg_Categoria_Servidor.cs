using System;
using System.Collections.Generic;
using System.Text;
//Librerias necesarias
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlClient;

namespace Negocio
{
    public class neg_Categoria_Servidor
    {
        private ManejadorDatos_Servidor mdS = new ManejadorDatos_Servidor();

        public neg_Categoria_Servidor()
        {
        }

        public void Insertar(int id, String servicio, String nombre, String unidad, float precio)
        {
            dat_Categoria objC = new dat_Categoria(id, servicio, nombre, unidad, precio);
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objC);
            mdS.CerrarConexion();
        }

        public void Actualizar(int id, String servicio, String nombre, String unidad, float precio)
        {
            dat_Categoria objC = new dat_Categoria(id, servicio, nombre, unidad, precio);
            mdS.AbrirConexion();
            mdS.ActualizarObjeto(objC);
            mdS.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            dat_Categoria objC = new dat_Categoria();
            objC.Id = id;
            mdS.AbrirConexion();
            mdS.EliminarObjeto(objC);
            mdS.CerrarConexion();
        }

        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_Categoria objC = new dat_Categoria();
            objC.Id = id;
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objC);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_Categoria objC = new dat_Categoria();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objC);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Parametrizado(String condicion)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_Categoria objC = new dat_Categoria();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto_Parametrizado(objC, condicion);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Todos()
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_Categoria objC = new dat_Categoria();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjetos(objC);
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
            dat_Categoria objC = new dat_Categoria();
            objC.Id = int.Parse(dr["Id"].ToString());
            objC.Nombre = dr["Nombre"].ToString();
            objC.Servicio = dr["Servicio"].ToString();
            objC.Unidad = dr["Unidad"].ToString();
            objC.Precio = float.Parse(dr["Precio"].ToString());
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objC);
            mdS.CerrarConexion();
        }
    }
}
