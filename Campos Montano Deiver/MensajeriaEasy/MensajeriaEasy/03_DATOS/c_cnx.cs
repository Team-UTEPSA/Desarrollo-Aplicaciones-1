using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _03_DATOS
{
    public class c_cnx
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        private string cadenaConexion =
            "Server=vps229753.vps.ovh.ca;" +
            "Port=5432;" +
            "Database=db_presupuesto;" +
            "User Id=postgres;" +
            "Password=123456Zxcv";




        void conectar()
        {
            conexion = new NpgsqlConnection(cadenaConexion);
            conexion.Open();
        }


        public DataTable obtenerTabla(string SQL)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conectar();
                }
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(SQL, conexion);
                DataTable Tabla = new DataTable();
                adap.Fill(Tabla);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }
        public int ejecutarScript(string SQL)
        {
            try
            {
                if(conexion.State == ConnectionState.Closed)
                {
                    conectar();
                }
                NpgsqlCommand comando = new NpgsqlCommand(SQL, conexion);
                return comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }




    }
}
