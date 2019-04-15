using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlClient;

namespace Negocio
{
    public class neg_Consulta_Servidor
    {
        private ManejadorDatos_Servidor mdS = new ManejadorDatos_Servidor();
        private String consulta;

        public neg_Consulta_Servidor(String sqlSelect)
        {
            consulta = sqlSelect;
        }

        public DataTable ObtenerConsulta()
        {
            DataTable dt = new DataTable();
            SqlDataReader dr;

            mdS.AbrirConexion();
            dr = mdS.EjecutarConsulta(consulta);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

    }
}
