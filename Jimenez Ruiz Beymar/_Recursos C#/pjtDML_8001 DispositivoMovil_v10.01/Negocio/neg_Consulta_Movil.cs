using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data; //Para definir DataTable, SqlDataReader
using System.Data.SqlServerCe;

namespace Negocio
{
    public class neg_Consulta_Movil
    {
        private ManejadorDatos_Movil mdS = new ManejadorDatos_Movil();
        private String consulta;

        public neg_Consulta_Movil(String sqlSelect)
        {
            consulta = sqlSelect;
        }

        public DataTable ObtenerConsulta()
        {
            DataTable dt = new DataTable();
            SqlCeDataReader dr;

            mdS.AbrirConexion();
            dr = mdS.EjecutarConsulta(consulta);
            dt.Load(dr);
            mdS.CerrarConexion();
            return dt;
        }

    }
}
