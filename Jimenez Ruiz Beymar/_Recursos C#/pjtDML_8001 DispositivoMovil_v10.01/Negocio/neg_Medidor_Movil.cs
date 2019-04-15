using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlServerCe;

namespace Negocio
{
    public class neg_Medidor_Movil
    {
        private ManejadorDatos_Movil mdS = new ManejadorDatos_Movil();

        public neg_Medidor_Movil()
        {
        }

        public void Insertar(int id, String direccion, int idsocio, int idzona, int idcategoria)
        {
            dat_Medidor objM = new dat_Medidor(id, direccion, idsocio, idzona, idcategoria);
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objM);
            mdS.CerrarConexion();
        }

        public void Actualizar(int id, String direccion, int idsocio, int idzona, int idcategoria)
        {
            dat_Medidor objM = new dat_Medidor(id, direccion, idsocio, idzona, idcategoria);
            mdS.AbrirConexion();
            mdS.ActualizarObjeto(objM);
            mdS.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            dat_Medidor objM = new dat_Medidor();
            objM.Id = id;
            mdS.AbrirConexion();
            mdS.EliminarObjeto(objM);
            mdS.CerrarConexion();
        }

        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Medidor objM = new dat_Medidor();
            objM.Id = id;
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objM);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Parametrizado(String condicion)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Medidor objM = new dat_Medidor();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto_Parametrizado(objM, condicion);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Todos()
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Medidor objM = new dat_Medidor();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjetos(objM);
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
            dat_Medidor objM = new dat_Medidor();
            objM.Id = int.Parse(dr["Id"].ToString());
            objM.Direccion = dr["Direccion"].ToString();
            objM.IdSocio = int.Parse(dr["IdSocio"].ToString());
            objM.IdZona = int.Parse(dr["IdZona"].ToString());
            objM.IdCategoria = int.Parse(dr["IdCategoria"].ToString());
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objM);
            mdS.CerrarConexion();
        }

    }
}
