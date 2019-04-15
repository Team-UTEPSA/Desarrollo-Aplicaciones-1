using System;
using System.Collections.Generic;
using System.Text;
//Librerias necesarias
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlServerCe; 

namespace Negocio
{
    public class neg_Socio_Movil
    {
        private ManejadorDatos_Movil mdS = new ManejadorDatos_Movil();

        public neg_Socio_Movil()
        {
        }

        public void Insertar(int id, String nombre, String apellido, String telefono)
        {
            dat_Socio objL = new dat_Socio(id, nombre, apellido, telefono);
            mdS.AbrirConexion();
            mdS.InsertarObjeto(objL);
            mdS.CerrarConexion();
        }

        public void Actualizar(int id, String nombre, String apellido, String telefono)
        {
            dat_Socio objL = new dat_Socio(id, nombre, apellido, telefono);
            mdS.AbrirConexion();
            mdS.ActualizarObjeto(objL);
            mdS.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            dat_Socio objL = new dat_Socio();
            objL.Id = id;
            mdS.AbrirConexion();
            mdS.EliminarObjeto(objL);
            mdS.CerrarConexion();
        }

        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Socio objL = new dat_Socio();
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
            SqlCeDataReader dr;

            dat_Socio objL = new dat_Socio();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto(objL);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Parametrizado(String condicion)
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Socio objL = new dat_Socio();
            mdS.AbrirConexion();
            dr = mdS.ObtenerObjeto_Parametrizado(objL, condicion);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

        public DataTable Buscar_Todos()
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            dat_Socio objL = new dat_Socio();
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
            dat_Socio objL = new dat_Socio();
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
