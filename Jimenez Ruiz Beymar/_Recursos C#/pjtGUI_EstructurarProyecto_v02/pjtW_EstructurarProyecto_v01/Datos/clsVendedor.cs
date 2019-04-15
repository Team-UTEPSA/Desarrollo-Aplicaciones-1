using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjtW_EstructurarProyecto_v01.Datos
{
    public class clsVendedor : SQLSerializable
    {
        int id;
        string ci;
        string nombre;
        string telefono;
        string direccion;
        string email;

        public clsVendedor(int id, string ci, string no, string te, string di, string em)
        {
            this.id = id;
            this.ci = ci;
            this.nombre = no;
            this.telefono = te;
            this.direccion = di;
            this.email = em;
        }

        #region Metodos: SET/GET
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string CI
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email= value; }
        }

        #endregion


        #region Metodos Serializable

        public string toInsert()
        {
            throw new NotImplementedException();

        }

        public string toUpdate()
        {
            throw new NotImplementedException();
        }

        public string toDelete()
        {
            throw new NotImplementedException();
        }

        public string toSelect()
        {
            throw new NotImplementedException();
        }

        public string toSelectTodo()
        {
            throw new NotImplementedException();
        }

        public string toSelect_Parametrizado(string condicion)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Metodos (Funciones y Procedimientos)

        #endregion
    }




}
