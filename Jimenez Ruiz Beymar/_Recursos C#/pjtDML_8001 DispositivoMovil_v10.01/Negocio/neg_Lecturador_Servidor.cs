using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlClient;

namespace Negocio
{
    public class neg_Lecturador_Servidor
    {
        private ManejadorDatos_Servidor mdS = new ManejadorDatos_Servidor();

        public neg_Lecturador_Servidor()
        {
        }

        public void Insertar(int id, String nombre, String apellido, String telefono)
        {
            dat_Lecturador objL = new dat_Lecturador(id, nombre, apellido, telefono);
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objL);
            mdS.CerrarConexion();
        }

        public void Actualizar(int id, String nombre, String apellido, String telefono)
        {
            dat_Lecturador objL = new dat_Lecturador(id, nombre, apellido, telefono);
            mdS.AbrirConexion();
            mdS.ActualizarObjeto(objL);
            mdS.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            dat_Lecturador objL = new dat_Lecturador();
            objL.Id = id;
            mdS.AbrirConexion();
            mdS.EliminarObjeto(objL);
            mdS.CerrarConexion();
        }

        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_Lecturador objL = new dat_Lecturador();
            objL.Id = id;
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objL);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
            ////txtNombre.Text = dt.Columns.ToString();
            ////txtNombre.Text = dt.Columns.Count.ToString(); //Cantidad de columnas de dt
            ////txtNombre.Text = dt.Rows.ToString(); //Devuelve su origen System.Data.DataRowCollection
            ////txtNombre.Text = dt.Constraints.IsReadOnly.ToString(); //Devuelve false
            ////txtNombre.Text = dt.;
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_Lecturador objL = new dat_Lecturador();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objL);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Parametrizado(String condicion)
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            dat_Lecturador objL = new dat_Lecturador();
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

            dat_Lecturador objL = new dat_Lecturador();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjetos(objL);
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
            dat_Lecturador objL = new dat_Lecturador();
            objL.Id = int.Parse(dr["Id"].ToString());
            objL.Nombre = dr["Nombre"].ToString();
            objL.Apellido = dr["Apellido"].ToString();
            objL.Telefono = dr["Telefono"].ToString();
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objL);
            mdS.CerrarConexion();
        }
    }
}
