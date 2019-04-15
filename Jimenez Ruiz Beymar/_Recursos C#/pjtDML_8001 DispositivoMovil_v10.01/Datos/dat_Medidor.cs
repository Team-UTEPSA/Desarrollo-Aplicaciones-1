using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class dat_Medidor : SQLSerializable
    {
        private int iId;
        private String sDireccion;
        private int iIdSocio;
        private int iIdZona;
        private int iIdCategoria;

        public dat_Medidor()
        {
            this.iId = 0;
            this.sDireccion = "";
            this.iIdSocio = 0;
            this.iIdZona = 0;
            this.iIdCategoria = 0;
        }

        public dat_Medidor(int id, String direccion, int idsocio, int idzona, int idcategoria)
        {
            this.iId = id;
            this.sDireccion = direccion;
            this.iIdSocio = idsocio;
            this.iIdZona = idzona;
            this.iIdCategoria = idcategoria;
        }

        public int Id
        {
            get { return iId; }
            set { iId = value; }
        }

        public String Direccion
        {
            get { return sDireccion; }
            set { sDireccion = value; }
        }

        public int IdSocio
        {
            get { return iIdSocio; }
            set { iIdSocio = value; }
        }

        public int IdZona
        {
            get { return iIdZona; }
            set { iIdZona = value; }
        }

        public int IdCategoria
        {
            get { return iIdCategoria; }
            set { iIdCategoria = value; }
        }

        public String toInsert()
        {
            String sentencia = "INSERT INTO tblMedidor VALUES (" + iId + ", '" + sDireccion + "', " + iIdSocio + ", " + iIdZona + ", " + iIdCategoria;
            return sentencia;
        }

        public String toUpdate()
        {
            String sentencia = "UPDATE tblMedidor SET Direccion = '" + sDireccion + ", IdSocio = " + iIdSocio + ", IdZona= " + iIdZona + ", IdCategoria= " + iIdCategoria + " WHERE Id = " + iId;
            return sentencia;
        }

        public String toDelete()
        {
            String sentencia = "DELETE FROM tblMedidor WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect()
        {
            String sentencia = "SELECT * FROM tblMedidor WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect_Parametrizado(String condicion)
        {
            String sentencia = "SELECT * FROM tblMedidor WHERE " + condicion;
            return sentencia;
        }

        public String toSelectTodo()
        {
            String sentencia = "SELECT * FROM tblMedidor";
            return sentencia;
        }

    }
}
