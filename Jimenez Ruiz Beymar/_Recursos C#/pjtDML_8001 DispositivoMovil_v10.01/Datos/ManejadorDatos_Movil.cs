using System;
using System.Collections.Generic;
using System.Text;
//Librerias necesarias
using System.Data.SqlServerCe;

namespace Datos
{
    public class ManejadorDatos_Movil
    {
        private String CadenaCnx = "Data Source = Archivos de programa/Presentacion/dbLM.sdf";
        private SqlCeConnection cnx = null;
        private SqlCeCommand cmd = null;
        private SqlCeTransaction tr = null;

        public ManejadorDatos_Movil()
        {
            //String c;
            //ArchivoTexto objA = new ArchivoTexto();
            //cnx = new SqlCeConnection(c);

            cnx = new SqlCeConnection(CadenaCnx);
            cmd = new SqlCeCommand();
            cmd.Connection = cnx;
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
        public SqlCeDataReader EjecutarConsulta(String consulta)
        {
            SqlCeDataReader dr;
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

        public SqlCeDataReader ObtenerObjeto(SQLSerializable objeto)
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

        public SqlCeDataReader ObtenerObjeto_Parametrizado(SQLSerializable objeto, String condicion)
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

        public SqlCeDataReader ObtenerObjetos(SQLSerializable objeto)
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
