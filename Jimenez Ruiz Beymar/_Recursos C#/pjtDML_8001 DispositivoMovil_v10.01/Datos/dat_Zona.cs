using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class dat_Zona : SQLSerializable
    {
        private int iId;
        private String sNombre;
        private int iIdLecturador;

        public dat_Zona()
        {
            this.iId = 0;
            this.sNombre = "";
            this.iIdLecturador = 0;
        }

        public dat_Zona(int id, String nombre, int idLecturador)
        {
            this.iId = id;
            this.sNombre = nombre;
            this.iId = idLecturador;
        }

        public int Id
        {
            get { return iId; }
            set { iId = value; }
        }

        public String Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public int IdLecturador
        {
            get { return iIdLecturador; }
            set { iIdLecturador = value; }
        }

        public String toInsert()
        {
            String sentencia = "INSERT INTO tblZona VALUES (" + iId + ", '" + sNombre + "', " + iIdLecturador;
            return sentencia;
        }

        public String toUpdate()
        {
            String sentencia = "UPDATE tblZona SET Nombre = '" + sNombre + "', IdLecturador = " + IdLecturador + " WHERE Id = " + Id;
            return sentencia;
        }

        public String toDelete()
        {
            String sentencia = "DELETE FROM tblZona WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect()
        {
            String sentencia = "SELECT * FROM tblZona WHERE Id = " + iId;
            return sentencia;
        }

        public String toSelect_Parametrizado(String condicion)
        {
            String sentencia = "SELECT * FROM tblZona WHERE " + condicion;
            return sentencia;
        }

        public String toSelectTodo()
        {
            String sentencia = "SELECT * FROM tblZona";
            return sentencia;
        }

    }
}
