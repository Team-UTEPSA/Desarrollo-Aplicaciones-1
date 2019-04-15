using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Datos
{
    public class ManejadorDatos_Servidor
    {
        //private String CadenaCnx = "Data Source=AMSAVS1;Initial Catalog=dbLecturaMedidor;User ID=sa; Password=123";
        private String CadenaCnx = "Data Source=BEYMAR;Initial Catalog=dbLecturaMedidor;User ID=admin-01; Password=123";

        private SqlConnection cnx = null;
        private SqlCommand cmd = null;
        private SqlTransaction tr = null;

        public ManejadorDatos_Servidor()
        {
            //String c;
            //ArchivoTexto objA = new ArchivoTexto();
            //c = objA.CadenaCnx();
            //cnx = new SqlConnection(c);

            cnx = new SqlConnection(CadenaCnx);
            cmd = new SqlCommand();
            cmd.Connection = cnx;
        }

        private String ObtenerCadenaCnx()
        {
            String c;
            ArchivoTexto objA = new ArchivoTexto();
            c = objA.CadenaCnx();
            return c;
        }

        public void AbrirConexion()
        {
            try
            {
                cnx.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                cnx.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //METODO:: Ejecuta una instruccion SQL ABM
        public void EjecutarComando(String sql)
        {
            try
            {
                tr = cnx.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Transaction = tr;
                cmd.ExecuteNonQuery();
                tr.Commit();
            }
            catch (Exception)
            {
                tr.Rollback();
                throw;
            }
        }

        //METODO:: Devuelve un DataReader con los datos del SELECT
        public SqlDataReader EjecutarConsulta(String consulta)
        {
            SqlDataReader dr;
            try
            {
                cmd.CommandText = consulta;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {
                //return rd; //tomar en cuenta el retorno, aunque retorna NULL o vacio
                throw;
            }
        }

        public void InsertarObjeto(SQLSerializable objeto)
        {
            try
            {
                this.EjecutarComando(objeto.toInsert());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarObjeto(SQLSerializable objeto)
        {
            try
            {
                this.EjecutarComando(objeto.toDelete());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarObjeto(SQLSerializable objeto)
        {
            try
            {
                this.EjecutarComando(objeto.toUpdate());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader ObtenerObjeto(SQLSerializable objeto)
        {
            try
            {
                return this.EjecutarConsulta(objeto.toSelect());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader ObtenerObjeto_Parametrizado(SQLSerializable objeto, String condicion)
        {
            try
            {
                return this.EjecutarConsulta(objeto.toSelect_Parametrizado(condicion));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader ObtenerObjetos(SQLSerializable objeto)
        {
            try
            {
                return this.EjecutarConsulta(objeto.toSelectTodo());
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
